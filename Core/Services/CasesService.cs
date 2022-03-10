using Core.Helpers.Result;
using Core.Interfaces;
using Core.Interfaces.Repositories;
using Core.Interfaces.Services;
using Core.Models.Cases;

namespace Core.Services;

public class CasesService :BaseService, ICasesServices
{
    private readonly ICasesRepository _casesRepository;


    public CasesService(ICasesRepository casesRepository)
    {
        _casesRepository = casesRepository;
    }

    public async Task<Result> GetListView(int pageIndex, int pageSize)
    {
        var data = await _casesRepository.GetListView(pageIndex, pageSize);
        return MatchResult(data);
    }

    public async Task<Result> GetKanbanView(int pageIndex, int pageSize)
    {
        var data = await _casesRepository.GetKanvanView(pageIndex, pageSize);
        return MatchResult(data);
    }

    public Task<Result> GetCanvasView(int pageIndex, int pageSize)
    {
        throw new System.NotImplementedException();
    }

    public async Task<Result> GetCase(int id)
    {
        return Result.Ok(await _casesRepository.GetCase(id));
    }

    public async Task<Result> Create(CreateCaseModel model, CancellationToken cancellationToken)
    {
        await _casesRepository.Create(model, cancellationToken);
        
        return Result.Ok();
    }

    public Task<Result> Update<TRequestModel>(TRequestModel model, CancellationToken cancellationToken)
    {
        throw new System.NotImplementedException();
    }

}