namespace Core.Interfaces
{
    public interface IFechasRepository
    {
        Task<bool> EsDiaHabil(DateTime fecha);
    }
}