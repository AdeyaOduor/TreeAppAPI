using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreeAppAPIv1.Data.Repo;
using TreeAppAPIv1.Interfaces;

namespace TreeAppAPIv1.Data
{
    public class RegionUnitOfWork : IUnitOfWork
    {
        private readonly DataContext dc;

        public RegionUnitOfWork(DataContext dc)
        {
            this.dc = dc;
        }
        public IRegionRepository RegionRepository =>
            new RegionRepository(dc);
        public IUserRepository UserRepository => new UserRepository(dc);
        
        public async Task<bool> SaveAsync()
        {
            return await dc.SaveChangesAsync() > 0;
        }
    }

    // public class CountyUnitOfWork : IUnitOfWork
    // {
    //     private readonly DataContext dc;

    //     public CountyUnitOfWork(DataContext dc)
    //     {
    //         this.dc = dc;
    //     }
    //     public ICountyRepository CountyRepository =>
    //         new CountyRepository(dc);
    //     public IUserRepository UserRepository => new UserRepository(dc);
        
    //     public async Task<bool> SaveAsync()
    //     {
    //         return await dc.SaveChangesAsync() > 0;
    //     }
    // }

    // public class SubCountyUnitOfWork : IUnitOfWork
    // {
    //     private readonly DataContext dc;

    //     public SubCountyUnitOfWork(DataContext dc)
    //     {
    //         this.dc = dc;
    //     }
    //     public ISubCountyRepository SubCountyRepositoryRepository =>
    //         new SubCountyRepository(dc);
    //     public IUserRepository UserRepository => new UserRepository(dc);
        
    //     public async Task<bool> SaveAsync()
    //     {
    //         return await dc.SaveChangesAsync() > 0;
    //     }
    // }

    // public class SchoolUnitOfWork : IUnitOfWork
    // {
    //     private readonly DataContext dc;

    //     public SchoolUnitOfWork(DataContext dc)
    //     {
    //         this.dc = dc;
    //     }
    //     public ISchoolRepository SchoolRepository =>
    //         new SchoolRepository(dc);
    //     public IUserRepository UserRepository => new UserRepository(dc);
        
    //     public async Task<bool> SaveAsync()
    //     {
    //         return await dc.SaveChangesAsync() > 0;
        }
    // }
// }
