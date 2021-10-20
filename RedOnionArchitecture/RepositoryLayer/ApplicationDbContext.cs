using DomainLayer.EntityMapper;
using DomainLayer.IdentityAuth;
using DomainLayer.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer
{
    public class ApplicationDbContext :IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options) :base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductCategoryMap());
            modelBuilder.ApplyConfiguration(new ProductSeriesMap());
            modelBuilder.ApplyConfiguration(new ProductModelMap());
            modelBuilder.ApplyConfiguration(new ProductPartMap());
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<ProductCategory>().HasData(
            //    new ProductCategory 
            //    { 
                    
            //    });
        }

        
    }
}
