using Core.Helpers.Result;
using Core.Models.Cases;

namespace Core.Interfaces.Services;

public interface ICasesServices
{
    Task<Result> GetListView(int pageIndex, int pageSize);
    Task<Result> GetKanbanView(int pageIndex, int pageSize);
    Task<Result> GetCanvasView(int pageIndex, int pageSize);
    Task<Result> GetCase(int id);
    Task<Result> Create(CreateCaseModel model, CancellationToken cancellationToken = default);
    Task<Result> Update<TRequestModel>(TRequestModel model, CancellationToken cancellationToken = default);
}