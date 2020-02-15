using DAW.Domain.EF.IRepositories;

namespace DAW.Services.Interfaces
{
    public interface IItemServices : IBaseServices
    {
        IItemRepository ItemRepository { get; }
    }
}