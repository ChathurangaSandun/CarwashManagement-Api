using CliveKumara.CarwashManagement.Api.Models.Common;
using CliveKumara.CarwashManagement.Api.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CliveKumara.CarwashManagement.Api.Models.DatabaseModel
{
    public class CarWashManagementDbContext : DbContext
    {
        public CarWashManagementDbContext(DbContextOptions<CarWashManagementDbContext> options)
       : base(options)
        { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ShopService> ShopServices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (IMutableEntityType entity in modelBuilder.Model.GetEntityTypes())
            {
                entity.SetTableName("CWM." + entity.GetTableName());
            }

            modelBuilder.Entity<ShopService>()
                    .HasKey(c => new { c.ServiceId, c.ShopId});


            modelBuilder.Entity<Shop>()
                    .Property(c => c.NumOfRate).HasDefaultValue(default(int));
            modelBuilder.Entity<Shop>()
                 .Property(c => c.Rate).HasDefaultValue(default(int));
        }
    }
}
