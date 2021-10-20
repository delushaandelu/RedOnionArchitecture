using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.EntityMapper
{
    public class ProductCategoryMap :IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.HasKey(x => x.Id).HasName("pk_productCategoryId");
            builder.Property(x => x.Id).ValueGeneratedOnAdd()
                .HasColumnName("Id")
                .HasColumnType("Int");
            builder.Property(x => x.CategoryName)
                .HasColumnName("CategoryName")
                .HasColumnType("NVARCHAR(100)")
                .IsRequired();
            builder.Property(x => x.CategoryDescription)
                .HasColumnName("CategoryDescription")
                .HasColumnType("NVARCHAR(100)")
                .IsRequired();
            builder.Property(x => x.ProductUrl)
                .HasColumnName("ProductUrl")
                .HasColumnType("NVARCHAR(100)");
            builder.Property(x => x.ImageUrl)
                .HasColumnName("ImageUrl")
                .HasColumnType("NVARCHAR(100)");
            builder.Property(x => x.CratedBy)
                .HasColumnName("CratedBy")
                .HasColumnType("NVARCHAR(100)");
            builder.Property(x => x.CreatedDateTime)
               .HasColumnName("CreatedDateTime")
               .HasColumnType("datetime");
            builder.Property(x => x.UpdatedBy)
                .HasColumnName("UpdatedBy")
                .HasColumnType("NVARCHAR(100)");
            builder.Property(x => x.UpdatedDateTime)
               .HasColumnName("UpdatedDateTime")
               .HasColumnType("datetime");
            builder.Property(x => x.IsActive)
               .HasColumnName("IsActive")
               .HasColumnType("bit");

            builder.HasMany(x => x.ProductSeries).WithOne(x => x.ProductCategory).HasForeignKey(x => x.ProductCategoriesId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
