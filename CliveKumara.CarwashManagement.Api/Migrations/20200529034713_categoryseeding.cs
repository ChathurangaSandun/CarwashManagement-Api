using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CliveKumara.CarwashManagement.Api.Migrations
{
    public partial class categoryseeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CWM.Locations",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.InsertData(
                table: "CWM.Categories",
                columns: new[] { "Id", "Color", "CreatedDate", "Icon", "Image", "Name", "Type", "UpdatedDate" },
                values: new object[] { 1L, "#ff8a65", new DateTime(2020, 5, 29, 11, 47, 13, 426, DateTimeKind.Local).AddTicks(2628), "directions_car", "assets/images/banner3.jpg", "Car Wash", "CARWASH", new DateTime(2020, 5, 29, 11, 47, 13, 427, DateTimeKind.Local).AddTicks(1155) });

            migrationBuilder.InsertData(
                table: "CWM.Categories",
                columns: new[] { "Id", "Color", "CreatedDate", "Icon", "Image", "Name", "Type", "UpdatedDate" },
                values: new object[] { 2L, "#5d6d7e", new DateTime(2020, 5, 29, 11, 47, 13, 428, DateTimeKind.Local).AddTicks(2913), "directions_car", "assets/images/banner4.jpg", "Car Service", "CARSERVICE", new DateTime(2020, 5, 29, 11, 47, 13, 428, DateTimeKind.Local).AddTicks(2928) });

            migrationBuilder.InsertData(
                table: "CWM.Categories",
                columns: new[] { "Id", "Color", "CreatedDate", "Icon", "Image", "Name", "Type", "UpdatedDate" },
                values: new object[] { 3L, "#a569bd", new DateTime(2020, 5, 29, 11, 47, 13, 428, DateTimeKind.Local).AddTicks(3052), "directions_car", "assets/images/banner5.jpg", "Car Parts", "CARPARTS", new DateTime(2020, 5, 29, 11, 47, 13, 428, DateTimeKind.Local).AddTicks(3054) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CWM.Categories",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "CWM.Categories",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "CWM.Categories",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.InsertData(
                table: "CWM.Locations",
                columns: new[] { "Id", "Address", "CreatedDate", "Lat", "Long", "Name", "UpdatedDate" },
                values: new object[] { 1L, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 52.36f, 5.69f, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
