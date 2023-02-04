using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllUpBack.Helpers;
using AllUpBack.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AllUpBack.DAL
{
    public class DataBase : IdentityDbContext<AppUser>
    {
        public DataBase(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Blog> Blogs { get; set; }

        public override int SaveChanges()
        {
            var time = ChangeTracker.Entries<ModifyTime>();

            foreach (var entry in time)
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.CreatedTime = DateTime.Now;
                }
                entry.Entity.LastModifiedTime = DateTime.Now;
            }
            return base.SaveChanges();
        }
    }
}