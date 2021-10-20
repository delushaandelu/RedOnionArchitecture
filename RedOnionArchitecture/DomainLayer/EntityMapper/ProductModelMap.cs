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

            builder.Property(x => x.Id).ValueGeneratedOnAdd()
                .HasColumnName("Id")
                .HasColumnType("Int");
            builder.Property(x => x.ModelName)
                .HasColumnName("ModelName")
                .HasColumnType("NVARCHAR(100)")
                .IsRequired();
            builder.Property(x => x.ModelDescription)
                .HasColumnName("ModelDescription")
                .HasColumnType("NVARCHAR(100)")
                .IsRequired();
            builder.Property(x => x.SKU)
                .HasColumnName("SKU")
                .HasColumnType("NVARCHAR(500)")
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

            builder.HasMany(x => x.ProductParts).WithOne(x => x.ProductModel).HasForeignKey(x => x.ProductModelId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
