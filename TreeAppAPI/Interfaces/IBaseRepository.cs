using TreeAppAPIv1.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TreeAppAPIv1.Interfaces
{
    public interface ICountyRepository
    {
        Task<IEnumerable<ST_COUNTY>> GetCountiesAsync();
        Task<ST_COUNTY> GetCountyByCodeAsync(string code);
        void AddCounty(ST_COUNTY acounty);
        void DeleteCounty(string acounty);
    }

    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetUsersAsync();
        Task<User> GetUserByUsernameAsync(string username);
        void AddUser(User auser);
        void AddSystemUser(APILogin auser);
        void DeleteUser(string username);
        Task<User> Authenticate(string username, string password);
    }

    public interface IRegionRepository
    {
        Task<IEnumerable<region>> GetRegionsAsync();
        Task<region> GetRegionByNoAsync(int id);
        Task<region> GetRegionByCodeAsync(int code);
        void AddRegion(region aregion);
        void DeleteRegion(int id);
    }

}
