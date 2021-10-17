using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class TableCreateinit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "Int", nullable: false),
                    CategoryName = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    CategoryDescription = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    ProductUrl = table.Column<string>(type: "NVARCHAR(100)", nullable: true),
                    ImageUrl = table.Column<string>(type: "NVARCHAR(100)", nullable: true),
                    CratedBy = table.Column<string>(type: "NVARCHAR(100)", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<string>(type: "NVARCHAR(100)", nullable: true),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_productCategoryId", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductSeries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "Int", nullable: false, defaultValueSql: "NULL"),
                    ProductCategoriesId = table.Column<int>(type: "Int", nullable: false),
                    SeriesName = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    SeriesDescription = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    ProductUrl = table.Column<string>(type: "NVARCHAR(100)", nullable: true),
                    ImageUrl = table.Column<string>(type: "NVARCHAR(100)", nullable: true),
                    CratedBy = table.Column<string>(type: "NVARCHAR(100)", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<string>(type: "NVARCHAR(100)", nullable: true),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ProductSeriesId", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductSeries_ProductCategory_ProductCategoriesId",
                        column: x => x.ProductCategoriesId,
                        principalTable: "ProductCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "Int", nullable: false),
                    ProductSeriesId = table.Column<int>(type: "Int", nullable: false),
                    ModelName = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    ModelDescription = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    ProductUrl = table.Column<string>(type: "NVARCHAR(100)", nullable: true),
                    ImageUrl = table.Column<string>(type: "NVARCHAR(100)", nullable: true),
                    SKU = table.Column<string>(type: "NVARCHAR(500)", nullable: false),
                    CratedBy = table.Column<string>(type: "NVARCHAR(100)", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<string>(type: "NVARCHAR(100)", nullable: true),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ProductModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductModel_ProductSeries_ProductSeriesId",
                        column: x => x.ProductSeriesId,
                        principalTable: "ProductSeries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductPart",
                columns: table => new
                {
                    Id = table.Column<int>(type: "Int", nullable: false),
                    ProductModelId = table.Column<int>(type: "Int", nullable: false),
                    PartName = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    PartDescription = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    ProductUrl = table.Column<string>(type: "NVARCHAR(100)", nullable: true),
                    ImageUrl = table.Column<string>(type: "NVARCHAR(100)", nullable: true),
                    Cost = table.Column<string>(type: "NVARCHAR(500)", nullable: false),
                    CratedBy = table.Column<string>(type: "NVARCHAR(100)", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<string>(type: "NVARCHAR(100)", nullable: true),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ProductPart", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductPart_ProductModel_ProductModelId",
                        column: x => x.ProductModelId,
                        principalTable: "ProductModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    Id = table.Column<int>(type: "Int", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    NormalizedName = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    UserId = table.Column<int>(type: "Int", nullable: true),
                    CratedBy = table.Column<string>(type: "NVARCHAR(100)", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<string>(type: "NVARCHAR(100)", nullable: true),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_UserRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "Int", nullable: false),
                    UserRoleId = table.Column<int>(type: "Int", nullable: false),
                    NormalizedUserName = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    Username = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    Email = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    Password = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    LockOutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NULL"),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CratedBy = table.Column<string>(type: "NVARCHAR(100)", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<string>(type: "NVARCHAR(100)", nullable: true),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_UserRole_UserRoleId",
                        column: x => x.UserRoleId,
                        principalTable: "UserRole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductModel_ProductSeriesId",
                table: "ProductModel",
                column: "ProductSeriesId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPart_ProductModelId",
                table: "ProductPart",
                column: "ProductModelId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSeries_ProductCategoriesId",
                table: "ProductSeries",
                column: "ProductCategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_User_UserRoleId",
                table: "User",
                column: "UserRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_UserId",
                table: "UserRole",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_User_UserId",
                table: "UserRole",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_UserRole_UserRoleId",
                table: "User");

            migrationBuilder.DropTable(
                name: "ProductPart");

            migrationBuilder.DropTable(
                name: "ProductModel");

            migrationBuilder.DropTable(
                name: "ProductSeries");

            migrationBuilder.DropTable(
                name: "ProductCategory");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
