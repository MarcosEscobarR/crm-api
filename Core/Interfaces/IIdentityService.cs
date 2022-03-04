using Core.Entities.User;
using Core.Helpers;

namespace Core.Interfaces;

public interface IIdentityService
{
    Task<User> GetCurrentUser();
    Task<IdentityUserInfoModel> GetIdentityUserInfo();
}