using _10._3dbCRUD.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._3dbCRUD.Data
{
    public class CarContext:DbContext
    {
        public DbSet<Car> Cars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=MariePC\MSSQLSERVER01;Database=carsdb;Integrated Security=true;Trusted_Connection=true;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasData(
                new Car { CarId = 1, VIN = "VA00900", Make = "Toyota", Model = "MR2" , Price = 12200 , Year = 1988 },
                new Car { CarId = 2, VIN = "VA36500", Make = "Jeep", Model = "Wrangler" , Price = 75099 , Year = 2024 },
                new Car { CarId = 3, VIN = "VR80508", Make = "Toyota", Model = "Rav4" , Price = 27899 , Year = 2012 }
                );

        }
    }
}
