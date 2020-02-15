using DAW.Domain.EF.IRepositories;
using DAW.Domain.Models;

namespace DAW.Domain.EF.Repositories
{
    public class ComandaRepository : BaseRepository<Comanda>, IComandaRepository
    {
        public ComandaRepository(Storage context) : base(context)
        {
        }
    }
}