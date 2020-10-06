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

        public ApplicationContext_1(DbContextOptions<ApplicationContext_1> opts) : base(opts)
        {
        }


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{

        //    modelBuilder.HasDefaultSchema("dbo");


        //    #region Review Table
        //    modelBuilder.Entity<Review>().Property(r => r.Id).HasColumnName("Id").IsRequired();
        //    modelBuilder.Entity<Review>().HasKey(r => r.Id);
        //    modelBuilder.Entity<Review>().Property(r => r.Id).HasColumnType("int");
        //    modelBuilder.Entity<Review>().Property(r => r.Id).ValueGeneratedOnAdd();

        //    modelBuilder.Entity<Review>().Property(r => r.Name).HasColumnName("Name").HasColumnType("nvarchar(100)").IsRequired();
        //    modelBuilder.Entity<Review>().Property(r => r.Category).HasColumnName("Category").HasColumnType("nvarchar(100)").IsRequired();
        //    modelBuilder.Entity<Review>().Property(r => r.Description).HasColumnName("Description").HasColumnType("nvarchar(150)").IsRequired();

        //    #endregion
        //}
    }
}
