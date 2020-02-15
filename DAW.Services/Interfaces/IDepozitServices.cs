using DAW.Domain.EF.IRepositories;

namespace DAW.Services.Interfaces
{
    public interface IDepozitServices : IBaseServices
    {
        IDepozitRepository DepozitRepository { get; }
    }
}