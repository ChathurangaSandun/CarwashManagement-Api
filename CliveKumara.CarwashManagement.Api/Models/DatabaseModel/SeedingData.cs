using CliveKumara.CarwashManagement.Api.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CliveKumara.CarwashManagement.Api.Models.DatabaseModel
{
    public static class SeedingDataExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //categories
            modelBuilder.Entity<Category>().HasData(new Category { Id = 1, Icon = "directions_car", Color = "#ff8a65", Image = "assets/images/banner3.jpg", Name = "Car Wash", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, Type = "carwash".ToUpper() });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 2, Icon = "directions_car", Color = "#5d6d7e", Image = "assets/images/banner4.jpg", Name = "Car Service", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, Type = "carservice".ToUpper() });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 3, Icon = "directions_car", Color = "#a569bd", Image = "assets/images/banner5.jpg", Name = "Car Parts", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, Type = "carparts".ToUpper() });

            // Locations
            modelBuilder.Entity<Location>()
                .HasData(new Location
                {
                    Id = 1,
                    Name = "Echo Zone - 3M Tint",
                    Long = 6.864756f,
                    Lat = 79.869652f,
                    Address = "Nugegoda",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow,
                });
            modelBuilder.Entity<Location>()
                .HasData(new Location
                {
                    Id = 2,
                    Name = "Alpine Car Wash",
                    Long = 6.87702f,
                    Lat = 79.864867f,
                    Address = "Colombo 6",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow,
                });
            modelBuilder.Entity<Location>()
                .HasData(new Location
                {
                    Id = 3,
                    Name = "Staford motors ",
                    Long = 6.8648127f,
                    Lat = 79.7996681f,
                    Address = "Colombo",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow,
                });


            // services
            modelBuilder.Entity<Service>()
                .HasData(new Service
                {
                    Id = 1,
                    Title = "Wash",
                    Icon = "",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow,
                });
            modelBuilder.Entity<Service>()
                .HasData(new Service
                {
                    Id = 2,
                    Title = "Vax",
                    Icon = "",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow,
                });
            modelBuilder.Entity<Service>()
               .HasData(new Service
               {
                   Id = 3,
                   Title = "Full Body",
                   Icon = "",
                   CreatedDate = DateTime.UtcNow,
                   UpdatedDate = DateTime.UtcNow,
               });

            //shop owner
            modelBuilder.Entity<ShopOwner>()
              .HasData(new ShopOwner
              {
                  Id = 1,
                  FullName = "Chathuranga",
                  Photo = "",
                  CreatedDate = DateTime.UtcNow,
                  UpdatedDate = DateTime.UtcNow,
              });
            modelBuilder.Entity<ShopOwner>()
              .HasData(new ShopOwner
              {
                  Id = 2,
                  FullName = "sandun",
                  Photo = "",
                  CreatedDate = DateTime.UtcNow,
                  UpdatedDate = DateTime.UtcNow,
              });
            modelBuilder.Entity<ShopOwner>()
             .HasData(new ShopOwner
             {
                 Id = 3,
                 FullName = "kumara",
                 Photo = "",
                 CreatedDate = DateTime.UtcNow,
                 UpdatedDate = DateTime.UtcNow,
             });

            // shop
            modelBuilder.Entity<Shop>()
             .HasData(new Shop
             {
                 Id = 1,
                 Title = "Echo Zone - 3M Tint",
                 SubTitle = "Echo Zone - 3M Tint",
                 Image = "",
                 Rate = 0,
                 NumOfRate = 0,
                 Status = "Featured",
                 Address = "Nugegoda",
                 Phone = "0718256773",
                 Mobile = "0718256773",
                 Hour = "9-6",
                 Description = "Loresipsm",
                 PriceRangeStart = 250f,
                 PriceRangeStop = 6500f,
                 CategoryId = 1,
                 LocationId = 1,
                 ShopOwnerId = 1,
                 Hours = "{}",
                 TabSettings = "{}",
                 CreatedDate = DateTime.UtcNow,
                 UpdatedDate = DateTime.UtcNow,
             });

            modelBuilder.Entity<Shop>()
            .HasData(new Shop
            {
                Id = 2,
                Title = "Alpine Car Wash",
                SubTitle = "Alpine Car Wash",
                Image = "",
                Rate = 0,
                NumOfRate = 0,
                Status = "Featured",
                Address = "Colombo 6",
                Phone = "0718256773",
                Mobile = "0718256773",
                Hour = "9-6",
                Description = "Loresipsm",
                PriceRangeStart = 250f,
                PriceRangeStop = 6500f,
                CategoryId = 1,
                LocationId = 2,
                ShopOwnerId = 2,
                Hours = "{}",
                TabSettings = "{}",
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = DateTime.UtcNow,
            });

            modelBuilder.Entity<Shop>()
            .HasData(new Shop
            {
                Id = 3,
                Title = "Staford motors ",
                SubTitle = "Staford motors ",
                Image = "",
                Rate = 0,
                NumOfRate = 0,
                Status = "Featured",
                Address = "Colombo",
                Phone = "0718256773",
                Mobile = "0718256773",
                Hour = "9-6",
                Description = "Loresipsm",
                PriceRangeStart = 250f,
                PriceRangeStop = 6500f,
                CategoryId = 1,
                LocationId = 3,
                ShopOwnerId = 3,
                Hours = "{}",
                TabSettings = "{}",
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = DateTime.UtcNow,
            });
        }
    }
}
