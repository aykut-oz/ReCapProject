using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class MyDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MyDatabase;Database=MyRentACar;Trusted_Connection=true");
        }

        public DbSet<User> User { get; set; }
        public DbSet<Flag> Flag { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Country> Countrie { get; set; }
        public DbSet<Continent> Continent { get; set; }
        public DbSet<Car> Car { get; set; }
        public DbSet<Color> Color { get; set; }
    }

   
}
