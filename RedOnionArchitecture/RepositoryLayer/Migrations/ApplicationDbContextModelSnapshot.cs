﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RepositoryLayer;

namespace RepositoryLayer.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DomainLayer.IdentityAuth.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("DomainLayer.Models.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("Int")
                        .HasColumnName("Id");

                    b.Property<string>("CategoryDescription")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("CategoryDescription");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("CategoryName");

                    b.Property<string>("CratedBy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("CratedBy");

                    b.Property<DateTime>("CreatedDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("CreatedDateTime");

                    b.Property<string>("ImageUrl")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("ImageUrl");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasColumnName("IsActive");

                    b.Property<string>("ProductUrl")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("ProductUrl");

                    b.Property<string>("UpdatedBy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("UpdatedBy");

                    b.Property<DateTime>("UpdatedDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("UpdatedDateTime");

                    b.HasKey("Id")
                        .HasName("pk_productCategoryId");

                    b.ToTable("ProductCategory");
                });

            modelBuilder.Entity("DomainLayer.Models.ProductModel", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("Int")
                        .HasColumnName("Id");

                    b.Property<string>("CratedBy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("CratedBy");

                    b.Property<DateTime>("CreatedDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("CreatedDateTime");

                    b.Property<string>("ImageUrl")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("ImageUrl");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasColumnName("IsActive");

                    b.Property<string>("ModelDescription")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("ModelDescription");

                    b.Property<string>("ModelName")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("ModelName");

                    b.Property<int>("ProductSeriesId")
                        .HasColumnType("Int");

                    b.Property<string>("ProductUrl")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("ProductUrl");

                    b.Property<string>("SKU")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NVARCHAR(500)")
                        .HasColumnName("SKU");

                    b.Property<string>("UpdatedBy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("UpdatedBy");

                    b.Property<DateTime>("UpdatedDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("UpdatedDateTime");

                    b.HasKey("Id")
                        .HasName("pk_ProductModel");

                    b.HasIndex("ProductSeriesId");

                    b.ToTable("ProductModel");
                });

            modelBuilder.Entity("DomainLayer.Models.ProductPart", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("Int")
                        .HasColumnName("Id");

                    b.Property<string>("Cost")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NVARCHAR(500)")
                        .HasColumnName("Cost");

                    b.Property<string>("CratedBy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("CratedBy");

                    b.Property<DateTime>("CreatedDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("CreatedDateTime");

                    b.Property<string>("ImageUrl")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("ImageUrl");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasColumnName("IsActive");

                    b.Property<string>("PartDescription")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("PartDescription");

                    b.Property<string>("PartName")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("PartName");

                    b.Property<int>("ProductModelId")
                        .HasColumnType("Int");

                    b.Property<string>("ProductUrl")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("ProductUrl");

                    b.Property<string>("UpdatedBy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("UpdatedBy");

                    b.Property<DateTime>("UpdatedDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("UpdatedDateTime");

                    b.HasKey("Id")
                        .HasName("pk_ProductPart");

                    b.HasIndex("ProductModelId");

                    b.ToTable("ProductPart");
                });

            modelBuilder.Entity("DomainLayer.Models.ProductSeries", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("Int")
                        .HasColumnName("Id")
                        .HasDefaultValueSql("NULL");

                    b.Property<string>("CratedBy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("CratedBy");

                    b.Property<DateTime>("CreatedDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("CreatedDateTime");

                    b.Property<string>("ImageUrl")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("ImageUrl");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasColumnName("IsActive");

                    b.Property<int>("ProductCategoriesId")
                        .HasColumnType("Int");

                    b.Property<string>("ProductUrl")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("ProductUrl");

                    b.Property<string>("SeriesDescription")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("SeriesDescription");

                    b.Property<string>("SeriesName")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("SeriesName");

                    b.Property<string>("UpdatedBy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("UpdatedBy");

                    b.Property<DateTime>("UpdatedDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("UpdatedDateTime");

                    b.HasKey("Id")
                        .HasName("pk_ProductSeriesId");

                    b.HasIndex("ProductCategoriesId");

                    b.ToTable("ProductSeries");
                });

            modelBuilder.Entity("DomainLayer.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("Int")
                        .HasColumnName("Id");

                    b.Property<int>("AccessFailedCount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("AccessFailedCount")
                        .HasDefaultValueSql("NULL");

                    b.Property<string>("CratedBy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("CratedBy");

                    b.Property<DateTime>("CreatedDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("CreatedDateTime");

                    b.Property<string>("Email")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("Email");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasColumnName("IsActive");

                    b.Property<bool>("LockOutEnabled")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasColumnName("LockOutEnabled");

                    b.Property<string>("NormalizedUserName")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("NormalizedUserName");

                    b.Property<string>("Password")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("Password");

                    b.Property<bool>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasColumnName("Status");

                    b.Property<string>("UpdatedBy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("UpdatedBy");

                    b.Property<DateTime>("UpdatedDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("UpdatedDateTime");

                    b.Property<int>("UserRoleId")
                        .HasColumnType("Int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("Username");

                    b.HasKey("Id")
                        .HasName("pk_User");

                    b.HasIndex("UserRoleId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("DomainLayer.Models.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("Int")
                        .HasColumnName("Id");

                    b.Property<string>("CratedBy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("CratedBy");

                    b.Property<DateTime>("CreatedDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("CreatedDateTime");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasColumnName("IsActive");

                    b.Property<string>("Name")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("Name");

                    b.Property<string>("NormalizedName")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("NormalizedName");

                    b.Property<string>("UpdatedBy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("UpdatedBy");

                    b.Property<DateTime>("UpdatedDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("UpdatedDateTime");

                    b.Property<int?>("UserId")
                        .HasColumnType("Int");

                    b.HasKey("Id")
                        .HasName("pk_UserRole");

                    b.HasIndex("UserId");

                    b.ToTable("UserRole");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("DomainLayer.Models.ProductModel", b =>
                {
                    b.HasOne("DomainLayer.Models.ProductSeries", "ProductSeries")
                        .WithMany("ProductModels")
                        .HasForeignKey("ProductSeriesId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ProductSeries");
                });

            modelBuilder.Entity("DomainLayer.Models.ProductPart", b =>
                {
                    b.HasOne("DomainLayer.Models.ProductModel", "ProductModel")
                        .WithMany("ProductParts")
                        .HasForeignKey("ProductModelId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ProductModel");
                });

            modelBuilder.Entity("DomainLayer.Models.ProductSeries", b =>
                {
                    b.HasOne("DomainLayer.Models.ProductCategory", "ProductCategory")
                        .WithMany("ProductSeries")
                        .HasForeignKey("ProductCategoriesId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ProductCategory");
                });

            modelBuilder.Entity("DomainLayer.Models.User", b =>
                {
                    b.HasOne("DomainLayer.Models.UserRole", "UserRole")
                        .WithMany()
                        .HasForeignKey("UserRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserRole");
                });

            modelBuilder.Entity("DomainLayer.Models.UserRole", b =>
                {
                    b.HasOne("DomainLayer.Models.User", null)
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("DomainLayer.IdentityAuth.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("DomainLayer.IdentityAuth.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DomainLayer.IdentityAuth.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("DomainLayer.IdentityAuth.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DomainLayer.Models.ProductCategory", b =>
                {
                    b.Navigation("ProductSeries");
                });

            modelBuilder.Entity("DomainLayer.Models.ProductModel", b =>
                {
                    b.Navigation("ProductParts");
                });

            modelBuilder.Entity("DomainLayer.Models.ProductSeries", b =>
                {
                    b.Navigation("ProductModels");
                });

            modelBuilder.Entity("DomainLayer.Models.User", b =>
                {
                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
