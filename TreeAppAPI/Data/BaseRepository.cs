using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreeAppAPIv1.Interfaces;
using TreeAppAPIv1.Entities;
using System.Numerics;

namespace TreeAppAPIv1.Data.Repo
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext dc;

        public UserRepository(DataContext dc)
        {
            this.dc = dc;
        }
        public void AddUser(User auser)
        {
            dc.USERS.AddAsync(auser);
        }
        public void AddSystemUser(APILogin auser)
        {
            dc.APILogins.AddAsync(auser);
        }

        public void DeleteUser(string code)
        {
            var aUSER = dc.USERS.Find(code);
            dc.USERS.Remove(aUSER);
        }

        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            return await dc.USERS.ToListAsync();
        }

        public async Task<User> GetUserByUsernameAsync(string code)
        {
            var auser = await dc.USERS
            .Where(p => p.PNumber == code)
            .FirstOrDefaultAsync();

            return auser;
        }

        public async Task<User> Authenticate(string username, string password)
        {
            return await dc.USERS.FirstOrDefaultAsync(x => x.PNumber == username
                        && x.Password == password);
        }
    }


    public class RegionRepository : IRegionRepository
    {
        private readonly DataContext dc;

        public RegionRepository(DataContext dc)
        {
            this.dc = dc;
        }
        public async Task<IEnumerable<region>> GetRegionsAsync()
        {
            return await dc.region.ToListAsync();
        }

        public async Task<region> GetRegionByNoAsync(int id)
        {
            var aregion = await dc.region
            .Where(p => p.id == id)
            .FirstOrDefaultAsync();

            return aregion;
        }
        public async Task<region> GetRegionByCodeAsync(int code)
        {
            var aregion = await dc.region
                .Where(p=> p.region_code == code)
                .FirstOrDefaultAsync();
            return aregion;
        }
        public void AddRegion(region aregion)
        {
            dc.region.AddAsync(aregion);
        }
        public void DeleteRegion(int id)
        {
            var aregion = dc.region.Find(id);
            dc.region.Remove(aregion);
        }
    }

    public class CountyRepository : ICountyRepository
    {
        private readonly DataContext dc;

        public CountyRepository(DataContext dc)
        {
            this.dc = dc;
        }
        public async Task<IEnumerable<county>> GetCountyAsync()
        {
            return await dc.county.ToListAsync();
        }

        public async Task<county> GetCountyByNoAsync(int id)
        {
            var acounty = await dc.county
            .Where(p => p.id == id)
            .FirstOrDefaultAsync();

            return acounty;
        }
        public async Task<county> GetCountyByCodeAsync(int code)
        {
            var acounty = await dc.county
                .Where(p=> p.county_code == code)
                .FirstOrDefaultAsync();
            return acounty;
        }
        public void AddCounty(county acounty)
        {
            dc.county.AddAsync(acounty);
        }
        public void DeleteCounty(int id)
        {
            var acounty = dc.county.Find(id);
            dc.county.Remove(acounty);
        }
    }

    public class SubCountyRepository : IRegionRepository
    {
        private readonly DataContext dc;

        public SubCountyRepository(DataContext dc)
        {
            this.dc = dc;
        }
        public async Task<IEnumerable<subcounty>> GetSubCountyAsync()
        {
            return await dc.subcounty.ToListAsync();
        }

        public async Task<subcounty> GetSubCountyByNoAsync(int id)
        {
            var asubcounty = await dc.subcounty
            .Where(p => p.id == id)
            .FirstOrDefaultAsync();

            return asubcounty;
        }
        public async Task<subcounty> GetSubCountyByCodeAsync(int code)
        {
            var asubcounty = await dc.subcounty
                .Where(p=> p.subcounty_code == code)
                .FirstOrDefaultAsync();
            return asubcounty;
        }
        public void AddSubCounty(subcounty asubcounty)
        {
            dc.region.AddAsync(asubcounty);
        }
        public void DeleteSubCounty(int id)
        {
            var asubcounty = dc.subcounty.Find(id);
            dc.subcounty.Remove(asubcounty);
        }
    }

    public class SchoolRepository : ISchoolRepository
    {
        private readonly DataContext dc;

        public SchoolRepository(DataContext dc)
        {
            this.dc = dc;
        }
        public async Task<IEnumerable<School>> GetSchoolAsync()
        {
            return await dc.school.ToListAsync();
        }

        public async Task<school> GetSchoolByNoAsync(int id)
        {
            var aschool = await dc.school
            .Where(p => p.id == id)
            .FirstOrDefaultAsync();

            return aschool;
        }
        public async Task<school> GetschoolByCodeAsync(int code)
        {
            var aschool = await dc.school;
                .Where(p=> p.uic_code == code)
                .FirstOrDefaultAsync();
            return aschool;
        }
        public void AddSchool(institution aschool)
        {
            dc.school.AddAsync(aschool);
        }
        public void DeleteSchool(int id)
        {
            var aschool = dc.school.Find(id);
            dc.school.Remove(aschool);
        }
    }
}
