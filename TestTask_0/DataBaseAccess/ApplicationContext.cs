using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTask_0.Model;
using TestTask_0.Models;

namespace TestTask_0.DataBase
{
    public class ApplicationContext : DbContext
    {

        public DbSet<Review> Reviews { get; set; }
        public DbSet<Category> Categories { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> opts) : base(opts)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo");

            #region Review Table
            modelBuilder.Entity<Review>().Property(r => r.Id).HasColumnName("Id");
            modelBuilder.Entity<Review>().HasKey(r => r.Id);
            modelBuilder.Entity<Review>().Property(r => r.Id).HasColumnType("int");
            modelBuilder.Entity<Review>().Property(r => r.Name).HasColumnName("Name").HasColumnType("nvarchar(100)").IsRequired();
            modelBuilder.Entity<Review>().Property(r => r.Description).HasColumnName("Description").HasColumnType("nvarchar(100)").IsRequired();
            modelBuilder.Entity<Review>().Property(r => r.CategoryId).HasColumnName("CategoryId").HasColumnType("int");
            #endregion

            #region Category Table
            modelBuilder.Entity<Category>().Property(c => c.Id).HasColumnName("Id");
            modelBuilder.Entity<Category>().HasKey(c => c.Id);
            modelBuilder.Entity<Category>().Property(c => c.Id).HasColumnType("int");
            modelBuilder.Entity<Category>().Property(c => c.Name).HasColumnName("Name").HasColumnType("nvarchar(100)");
            #endregion

            #region  (Category Table -> Review Table)  one-to-many Relationship
            modelBuilder.Entity<Category>().HasMany(c => c.Reviews).WithOne(e => e.Category).HasForeignKey(e => e.CategoryId); 
            #endregion
        }
    }
}
