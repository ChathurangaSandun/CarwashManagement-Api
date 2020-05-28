using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CliveKumara.CarwashManagement.Api.Migrations
{
    public partial class addshop7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ShopOwnerId",
                table: "CWM.Shops",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<string>(
                name: "Path",
                table: "CWM.ShopImage",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CWM.ShopImage",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "CWM.ShopOwner",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    FullName = table.Column<string>(nullable: false),
                    Photo = table.Column<string>(nullable: false),
                    Url = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Tag = table.Column<string>(nullable: true),
                    Rate = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CWM.ShopOwner", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CWM.Shops_ShopOwnerId",
                table: "CWM.Shops",
                column: "ShopOwnerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CWM.Shops_CWM.ShopOwner_ShopOwnerId",
                table: "CWM.Shops",
                column: "ShopOwnerId",
                principalTable: "CWM.ShopOwner",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CWM.Shops_CWM.ShopOwner_ShopOwnerId",
                table: "CWM.Shops");

            migrationBuilder.DropTable(
                name: "CWM.ShopOwner");

            migrationBuilder.DropIndex(
                name: "IX_CWM.Shops_ShopOwnerId",
                table: "CWM.Shops");

            migrationBuilder.DropColumn(
                name: "ShopOwnerId",
                table: "CWM.Shops");

            migrationBuilder.AlterColumn<string>(
                name: "Path",
                table: "CWM.ShopImage",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CWM.ShopImage",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
