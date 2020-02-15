using DAW.Domain.EF;
using DAW.Domain.EF.IRepositories;
using DAW.Services.Interfaces;

namespace DAW.Services.Implementations
{
    public class DepozitServices : BaseServices, IDepozitServices
    {
        public IDepozitRepository DepozitRepository { get; }

        public DepozitServices(Storage context, IDepozitRepository depozitRepository) : base(context)
        {
            DepozitRepository = depozitRepository;
        }

    }
}