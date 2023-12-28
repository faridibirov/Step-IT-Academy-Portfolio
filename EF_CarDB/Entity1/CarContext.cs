using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity1
{
    internal class CarContext : DbContext
    {

        public DbSet<Car> Cars { get; set; }


        public CarContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = DESKTOP-FARID; Integrated Security = True;   TrustServerCertificate=True;  Initial Catalog = MyCarsDB;");
        }

    }
}
