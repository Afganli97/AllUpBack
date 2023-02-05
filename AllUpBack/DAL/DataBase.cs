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
        public DbSet<Advantage> Advantages { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Bio> Bios { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogTag> BlogTags { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Composition> Compositions { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Partner> Partners { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductColor> ProductColors { get; set; }
        public DbSet<ProductComposition> ProductCompositions { get; set; }
        public DbSet<ProductSize> ProductSizes { get; set; }
        public DbSet<ProductTag> ProductTags { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Tag> Tags { get; set; }

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