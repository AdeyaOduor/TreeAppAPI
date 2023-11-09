using System.Threading.Tasks;

namespace TreeAppAPIv1.Interfaces
{
    public interface IUnitOfWork
    {
        IRegionRepository RegionRepository { get; }
        IUserRepository UserRepository { get; }
        Task<bool> SaveAsync();
    }
}
