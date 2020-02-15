using DAW.Domain.EF;
using DAW.Domain.EF.IRepositories;
using DAW.Services.Interfaces;

namespace DAW.Services.Implementations
{
    public class ItemServices : BaseServices, IItemServices
    {
        public IItemRepository ItemRepository { get; }

        public ItemServices(Storage context, IItemRepository itemRepository) : base(context)
        {
            ItemRepository = itemRepository;
        }

    }
}