namespace Core.Interfaces;

public interface IGenericCrud
{
    Task<TResponseModel> GetListView<TResponseModel>(int pageIndex, int pageSize);
    Task<TResponseModel> GetKanbanView<TResponseModel>(int pageIndex, int pageSize);
    Task<TResponseModel> GetCanvasView<TResponseModel>(int pageIndex, int pageSize);
    Task Create<TRequestModel>(TRequestModel model);
    Task Update<TRequestModel>(TRequestModel model);
}