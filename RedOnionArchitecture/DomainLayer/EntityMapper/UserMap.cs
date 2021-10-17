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
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id).HasName("pk_User");

            builder.Property(x => x.Id).ValueGeneratedNever()
                .HasColumnName("Id")
                .HasColumnType("Int");
            builder.Property(x => x.NormalizedUserName).ValueGeneratedOnAdd()
                .HasColumnName("NormalizedUserName")
                .HasColumnType("NVARCHAR(100)")
                .IsRequired();
            builder.Property(x => x.NormalizedUserName).ValueGeneratedOnAdd()
                .HasColumnName("NormalizedUserName")
                .HasColumnType("NVARCHAR(100)")
                .IsRequired();
            builder.Property(x => x.Username).ValueGeneratedOnAdd()
                .HasColumnName("Username")
                .HasColumnType("NVARCHAR(100)")
                .IsRequired();
            builder.Property(x => x.Email).ValueGeneratedOnAdd()
                .HasColumnName("Email")
                .HasColumnType("NVARCHAR(100)")
                .IsRequired();
            builder.Property(x => x.Password).ValueGeneratedOnAdd()
                .HasColumnName("Password")
                .HasColumnType("NVARCHAR(100)")
                .IsRequired();
            builder.Property(x => x.LockOutEnabled).ValueGeneratedOnAdd()
                .HasColumnName("LockOutEnabled")
                .HasColumnType("bit")
                .IsRequired();
            builder.Property(x => x.AccessFailedCount).ValueGeneratedOnAdd()
                .HasColumnName("AccessFailedCount")
                .HasColumnType("int")
                .HasDefaultValueSql("NULL")
                .IsRequired();
            builder.Property(x => x.Status).ValueGeneratedOnAdd()
                .HasColumnName("Status")
                .HasColumnType("bit")
                .IsRequired();
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
        }
    }
}
