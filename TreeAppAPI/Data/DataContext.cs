using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreeAppAPIv1.Entities;
using Microsoft.Data.SqlClient;

namespace TreeAppAPIv1.Data
{
    public class DataContext : DbContext
    {
        //public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> USERS { get; set; }
        public DbSet<region> region { get; set; }
        public DbSet<county> county { get; set; }
        public DbSet<subcounty> subcounty { get; set; }
        public DbSet<school> school { get; set; }
        public DbSet<APILogin> APILogins { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connstr = @"Server =SANG_DEV.;Initial Catalog=School_Tree_Planting_Monitoring_System;User Id=sa;Password=P@ssw0rd;";
            //string connstr = @"Server =192.168.1.234\NITASQL;Initial Catalog=NITADB;User Id=NITA\bsang;Password=123@Boiyo;Trusted_Connection=True;";
            if (!optionsBuilder.IsConfigured)
            {
                var conn = new SqlConnectionStringBuilder(connstr)
                {
                    ConnectRetryCount = 5,
                    Pooling = false
                };
                optionsBuilder.UseSqlServer(conn.ToString(),
                    options => options.EnableRetryOnFailure());
            }
            base.OnConfiguring(optionsBuilder);

        }

        public override void Dispose()
        {
            base.Dispose();
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<APILogin>().ToTable("APILogin");
            builder.Entity<region>().ToTable("regions");
           
            //builder.Ignore<ECitizenApplicant>(); //ignore create the table for the stored procedure
            //builder.Query<ECitizenApplicant>();  //register stored procedure.

        }
    }
}
