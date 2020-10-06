using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTask_1.Models;

namespace TestTask_1.DataBaseAccess
{
    public class ApplicationContext_1  : DbContext
    {

        public DbSet<Review> Reviews { get; set; }
        public DbSet<Category> Categories { get; set; }

        public ApplicationContext_1(DbContextOptions<ApplicationContext_1> opts) : base(opts) { }
    }
}
