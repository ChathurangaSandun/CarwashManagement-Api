using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CliveKumara.CarwashManagement.Api.Migrations
{
    public partial class addshop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Hours",
                table: "CWM.Shops",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TabSettings",
                table: "CWM.Shops",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "CWM.ShopImage",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Path = table.Column<string>(nullable: true),
                    ShopId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CWM.ShopImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CWM.ShopImage_CWM.Shops_ShopId",
                        column: x => x.ShopId,
                        principalTable: "CWM.Shops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CWM.ShopImage_ShopId",
                table: "CWM.ShopImage",
                column: "ShopId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CWM.ShopImage");

            migrationBuilder.DropColumn(
                name: "Hours",
                table: "CWM.Shops");

            migrationBuilder.DropColumn(
                name: "TabSettings",
                table: "CWM.Shops");
        }
    }
}
