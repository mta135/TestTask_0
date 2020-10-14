using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTask_2.Models;

namespace TestTask_2.DataBaseAccess
{
    public class ApplicationContext_2 : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Street> Streets { get; set; }
        public DbSet<CityDetail> CityDetails { get; set; }
        public DbSet<StreetCityDetail> StreetCityDetails { get; set; }

        public ApplicationContext_2(DbContextOptions<ApplicationContext_2> options) : base(options) { }
    }
}
