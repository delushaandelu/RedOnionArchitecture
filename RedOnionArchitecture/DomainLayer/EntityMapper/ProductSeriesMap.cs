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
    public class ProductSeriesMap : IEntityTypeConfiguration<ProductSeries>
    {
        public void Configure(EntityTypeBuilder<ProductSeries> builder)
        {
            builder.HasKey(x => x.Id).HasName("pk_ProductSeriesId");

            builder.Property(x => x.Id).ValueGeneratedOnAdd()
                .HasColumnName("Id")
                .HasColumnType("Int")
                .HasDefaultValueSql("NULL"); 
            builder.Property(x => x.SeriesName)
                .HasColumnName("SeriesName")
                .HasColumnType("NVARCHAR(100)")
                .IsRequired();
            builder.Property(x => x.SeriesDescription)
                .HasColumnName("SeriesDescription")
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

            builder.HasMany(x => x.ProductModels).WithOne(x => x.ProductSeries).HasForeignKey(x => x.ProductSeriesId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
