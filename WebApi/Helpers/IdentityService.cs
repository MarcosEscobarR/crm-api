using System.Security.Claims;
using Core.Entities.User;
using Core.Helpers;
using Core.Interfaces;
using IdentityModel;
using IdentityModel.Client;
using Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Net.Http.Headers;

namespace WebApi.Helpers;

public class IdentityService : IIdentityService
{
    private readonly ApplicationDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly IMemoryCache _memoryCache;
    private readonly string _identityId = null;

    public IdentityService(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor,
        IMemoryCache memoryCache)
    {
        _context = context;
        _httpContextAccessor = httpContextAccessor;
        _memoryCache = memoryCache;
    }

    private string IdentityId =>
        _identityId ?? _httpContextAccessor.HttpContext!.User.FindFirstValue(JwtClaimTypes.Subject);

    public async Task<User> GetCurrentUser()
    {
        if (IdentityId is null) return null;

        if (_memoryCache.TryGetValue(IdentityId, out User user)) return user;
        
        user = await _context.Users.FirstOrDefaultAsync(p => p.IdentityId == IdentityId);

        return _memoryCache.Set(IdentityId, user);
    }

    private string GetAccessToken()
    {
        var request = _httpContextAccessor.HttpContext!.Request;
        var authorization = (string) request.Headers[HeaderNames.Authorization];
        return authorization?[7..];
    }

    public async Task<IdentityUserInfoModel> GetIdentityUserInfo()
    {
        var request = new UserInfoRequest()
        {
            Address = "https://localhost:7138/connect/userinfo",
            Token = GetAccessToken()
        };
        using var httpClient = new HttpClient();
        var info = await httpClient.GetUserInfoAsync(request);
        var value = new IdentityUserInfoModel(
            info.Claims.FirstOrDefault(claim => claim.Type == JwtClaimTypes.Subject)?.Value,
            info.Claims.FirstOrDefault(claim => claim.Type == JwtClaimTypes.Email)?.Value,
            info.Claims.FirstOrDefault(claim => claim.Type == JwtClaimTypes.GivenName)?.Value,
            info.Claims.FirstOrDefault(claim => claim.Type == JwtClaimTypes.FamilyName)?.Value,
            info.Claims.FirstOrDefault(claim => claim.Type == JwtClaimTypes.PhoneNumber)?.Value
        );

        return value;
    }
}