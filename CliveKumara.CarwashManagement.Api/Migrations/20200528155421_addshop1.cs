using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CliveKumara.CarwashManagement.Api.Migrations
{
    public partial class addshop1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "CWM.Categories",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "CWM.Categories",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "CWM.Locations",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Lat = table.Column<float>(nullable: false),
                    Long = table.Column<float>(nullable: false),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CWM.Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CWM.Services",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Icon = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CWM.Services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CWM.Shops",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    SubTitle = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Rate = table.Column<double>(nullable: false),
                    NumOfRate = table.Column<int>(nullable: false),
                    ReteText = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Phone2 = table.Column<string>(nullable: true),
                    Mobile = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Website = table.Column<string>(nullable: true),
                    Hour = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    PriceRangeStart = table.Column<double>(nullable: false),
                    PriceRangeStop = table.Column<double>(nullable: false),
                    CategoryId = table.Column<long>(nullable: false),
                    LocationId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CWM.Shops", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CWM.Shops_CWM.Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "CWM.Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CWM.Shops_CWM.Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "CWM.Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CWM.ShopServices",
                columns: table => new
                {
                    ShopId = table.Column<long>(nullable: false),
                    ServiceId = table.Column<long>(nullable: false),
                    Price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CWM.ShopServices", x => new { x.ServiceId, x.ShopId });
                    table.ForeignKey(
                        name: "FK_CWM.ShopServices_CWM.Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "CWM.Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CWM.ShopServices_CWM.Shops_ShopId",
                        column: x => x.ShopId,
                        principalTable: "CWM.Shops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CWM.Shops_CategoryId",
                table: "CWM.Shops",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CWM.Shops_LocationId",
                table: "CWM.Shops",
                column: "LocationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CWM.ShopServices_ShopId",
                table: "CWM.ShopServices",
                column: "ShopId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CWM.ShopServices");

            migrationBuilder.DropTable(
                name: "CWM.Services");

            migrationBuilder.DropTable(
                name: "CWM.Shops");

            migrationBuilder.DropTable(
                name: "CWM.Locations");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "CWM.Categories");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "CWM.Categories");
        }
    }
}
