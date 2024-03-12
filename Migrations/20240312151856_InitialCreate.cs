using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace katalog_3d_api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OfferedServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfferedServices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NewsArticles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(500)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Publisher = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetaScript = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    Keyword = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsArticles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NewsArticles_Users_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UploadModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwnerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UploadModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UploadModels_Users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserProfiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserProfiles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OfferedServiceId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_OfferedServices_OfferedServiceId",
                        column: x => x.OfferedServiceId,
                        principalTable: "OfferedServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UploadModelDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Material = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecommendedUses = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<double>(type: "float", nullable: true),
                    SpecialFeature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    About = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UploadModelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UploadModelDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UploadModelDetails_UploadModels_UploadModelId",
                        column: x => x.UploadModelId,
                        principalTable: "UploadModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NewsArticles_AuthorId",
                table: "NewsArticles",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OfferedServiceId",
                table: "OrderItems",
                column: "OfferedServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UploadModelDetails_UploadModelId",
                table: "UploadModelDetails",
                column: "UploadModelId");

            migrationBuilder.CreateIndex(
                name: "IX_UploadModels_OwnerId",
                table: "UploadModels",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfiles_UserId",
                table: "UserProfiles",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NewsArticles");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "UploadModelDetails");

            migrationBuilder.DropTable(
                name: "UserProfiles");

            migrationBuilder.DropTable(
                name: "OfferedServices");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "UploadModels");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
