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
    public class ProductModelMap : IEntityTypeConfiguration<ProductModel>
    {
        public void Configure(EntityTypeBuilder<ProductModel> builder)
        {
            builder.HasKey(x => x.Id).HasName("pk_ProductModel");

            builder.Property(x => x.Id).ValueGeneratedNever()
                .HasColumnName("Id")
                .HasColumnType("Int");
            builder.Property(x => x.ModelName).ValueGeneratedOnAdd()
                .HasColumnName("ModelName")
                .HasColumnType("NVARCHAR(100)")
                .IsRequired();
            builder.Property(x => x.ModelDescription).ValueGeneratedOnAdd()
                .HasColumnName("ModelDescription")
                .HasColumnType("NVARCHAR(100)")
                .IsRequired();
            builder.Property(x => x.SKU).ValueGeneratedOnAdd()
                .HasColumnName("SKU")
                .HasColumnType("NVARCHAR(500)")
                .IsRequired();
            builder.Property(x => x.ProductUrl).ValueGeneratedOnAdd()
                .HasColumnName("ProductUrl")
                .HasColumnType("NVARCHAR(100)");
            builder.Property(x => x.ImageUrl).ValueGeneratedOnAdd()
                .HasColumnName("ImageUrl")
                .HasColumnType("NVARCHAR(100)");
            builder.Property(x => x.CratedBy).ValueGeneratedOnAdd()
                .HasColumnName("CratedBy")
                .HasColumnType("NVARCHAR(100)");
            builder.Property(x => x.CreatedDateTime).ValueGeneratedOnAdd()
               .HasColumnName("CreatedDateTime")
               .HasColumnType("datetime");
            builder.Property(x => x.UpdatedBy).ValueGeneratedOnAdd()
                .HasColumnName("UpdatedBy")
                .HasColumnType("NVARCHAR(100)");
            builder.Property(x => x.UpdatedDateTime).ValueGeneratedOnAdd()
               .HasColumnName("UpdatedDateTime")
               .HasColumnType("datetime");
            builder.Property(x => x.IsActive).ValueGeneratedOnAdd()
               .HasColumnName("IsActive")
               .HasColumnType("bit");

            builder.HasMany(x => x.ProductParts).WithOne(x => x.ProductModel).HasForeignKey(x => x.ProductModelId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
