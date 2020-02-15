using DAW.Domain.EF.IRepositories;
using DAW.Domain.Models;

namespace DAW.Domain.EF.Repositories
{
    public class DepozitRepository : BaseRepository<Depozit>, IDepozitRepository
    {
        public DepozitRepository(Storage context) : base(context)
        {
        }
    }
}