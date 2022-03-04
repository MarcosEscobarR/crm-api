using Core.Interfaces.Services;
using Core.Models.Cases;
using Microsoft.AspNetCore.Mvc;
using WebApi.Helpers;

namespace WebApi.Controllers.V1;

[ApiVersion("1.0")]
[Route("v{version:apiVersion}/api/[controller]")]
public class CasesController : BaseApiController
{
    private readonly ICasesServices _services;

    public CasesController(ICasesServices services)
    {
        _services = services;
    }

    [HttpGet("list-view")]
    public async Task<IActionResult> GetListView(int pageIndex = 0, int pageSize = 20)
    {
        var result = await _services.GetListView(pageIndex, pageSize);
        return result.ToActionResult();
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateCaseModel model, CancellationToken cancellationToken)
    {
        var result = await _services.Create(model, cancellationToken);
        return result.ToActionResult();
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> Get(int id)
    {
        var result = await _services.GetCase(id);
        return result.ToActionResult();
    }
}