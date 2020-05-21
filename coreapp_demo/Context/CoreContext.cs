using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using coreapp_demo.Models;

namespace coreapp_demo.Context
{
    public class CoreContext: DbContext
    {
        public DbSet<coreapp_demo.Models.Employee> Employee { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=tcp:mujtabactl.database.windows.net,1433;Initial Catalog=test_db;Persist Security Info=False;User ID=mujtaba;Password=Ayaz@1988;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
        
    }
}
