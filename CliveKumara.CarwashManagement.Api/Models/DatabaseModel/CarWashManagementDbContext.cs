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
    public class CarWashManagementDbContext: DbContext
    {
        public CarWashManagementDbContext(DbContextOptions<CarWashManagementDbContext> options)
       : base(options)
        { }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (IMutableEntityType entity in modelBuilder.Model.GetEntityTypes())
            {
                entity.SetTableName("CWM." + entity.GetTableName());
            }
        }
    }
}
