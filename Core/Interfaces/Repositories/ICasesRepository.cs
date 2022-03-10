using Core.Models.Cases;

namespace Core.Interfaces.Repositories;

public interface ICasesRepository
{
    Task<List<CasesListView>> GetListView(int pageIndex, int pageSize);
    Task<object> GetKanvanView(int pageIndex, int pageSize);
    Task<TResponseModel> GetCanvasView<TResponseModel>(int pageIndex, int pageSize);
    Task<CaseModel?> GetCase(int id);
    Task Create(CreateCaseModel model, CancellationToken cancellationToken = default);
    Task Update<TRequestModel>(TRequestModel model, CancellationToken cancellationToken = default);
}