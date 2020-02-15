using DAW.Domain.EF;
using DAW.Domain.EF.IRepositories;
using DAW.Domain.EF.Repositories;
using DAW.Services.Interfaces;

namespace DAW.Services.Implementations
{
    public class ComandaServices : BaseServices, IComandaServices
    {
        public IComandaRepository ComandaRepository { get; }

        public ComandaServices(Storage context, IComandaRepository comandaRepository) : base(context)
        {
            ComandaRepository = comandaRepository;
        }
    }
}