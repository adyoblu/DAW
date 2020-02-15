using DAW.Domain.EF;
using DAW.Services.Interfaces;
using System.Threading.Tasks;

namespace DAW.Services.Implementations
{
    public class BaseServices : IBaseServices
    {
        private readonly Storage _context;

        public BaseServices(Storage context)
        {
            _context = context;
        }

        public async Task CommitChanges()
        {
            await _context.SaveChangesAsync(true);
        }
    }
}