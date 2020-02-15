using DAW.Domain.EF.IRepositories;

namespace DAW.Services.Interfaces
{
    public interface IComandaServices : IBaseServices
    {
        IComandaRepository ComandaRepository { get; }
    }
}