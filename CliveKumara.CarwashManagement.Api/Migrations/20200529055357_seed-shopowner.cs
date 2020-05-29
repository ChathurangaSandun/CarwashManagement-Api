using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CliveKumara.CarwashManagement.Api.Migrations
{
    public partial class seedshopowner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CWM.Categories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 29, 13, 53, 57, 405, DateTimeKind.Local).AddTicks(1652), new DateTime(2020, 5, 29, 13, 53, 57, 406, DateTimeKind.Local).AddTicks(1478) });

            migrationBuilder.UpdateData(
                table: "CWM.Categories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 29, 13, 53, 57, 407, DateTimeKind.Local).AddTicks(4831), new DateTime(2020, 5, 29, 13, 53, 57, 407, DateTimeKind.Local).AddTicks(4846) });

            migrationBuilder.UpdateData(
                table: "CWM.Categories",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 29, 13, 53, 57, 407, DateTimeKind.Local).AddTicks(4983), new DateTime(2020, 5, 29, 13, 53, 57, 407, DateTimeKind.Local).AddTicks(4985) });

            migrationBuilder.UpdateData(
                table: "CWM.Locations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 29, 5, 53, 57, 407, DateTimeKind.Utc).AddTicks(7691), new DateTime(2020, 5, 29, 5, 53, 57, 407, DateTimeKind.Utc).AddTicks(7695) });

            migrationBuilder.UpdateData(
                table: "CWM.Locations",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 29, 5, 53, 57, 407, DateTimeKind.Utc).AddTicks(7917), new DateTime(2020, 5, 29, 5, 53, 57, 407, DateTimeKind.Utc).AddTicks(7920) });

            migrationBuilder.UpdateData(
                table: "CWM.Locations",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 29, 5, 53, 57, 407, DateTimeKind.Utc).AddTicks(7946), new DateTime(2020, 5, 29, 5, 53, 57, 407, DateTimeKind.Utc).AddTicks(7947) });

            migrationBuilder.UpdateData(
                table: "CWM.Services",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 29, 5, 53, 57, 407, DateTimeKind.Utc).AddTicks(9419), new DateTime(2020, 5, 29, 5, 53, 57, 407, DateTimeKind.Utc).AddTicks(9423) });

            migrationBuilder.UpdateData(
                table: "CWM.Services",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 29, 5, 53, 57, 407, DateTimeKind.Utc).AddTicks(9618), new DateTime(2020, 5, 29, 5, 53, 57, 407, DateTimeKind.Utc).AddTicks(9620) });

            migrationBuilder.UpdateData(
                table: "CWM.Services",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 29, 5, 53, 57, 407, DateTimeKind.Utc).AddTicks(9643), new DateTime(2020, 5, 29, 5, 53, 57, 407, DateTimeKind.Utc).AddTicks(9644) });

            migrationBuilder.InsertData(
                table: "CWM.ShopOwner",
                columns: new[] { "Id", "CreatedDate", "Description", "FullName", "Photo", "Rate", "Tag", "UpdatedDate", "Url" },
                values: new object[,]
                {
                    { 1L, new DateTime(2020, 5, 29, 5, 53, 57, 408, DateTimeKind.Utc).AddTicks(1084), null, "Chathuranga", "", 0.0, null, new DateTime(2020, 5, 29, 5, 53, 57, 408, DateTimeKind.Utc).AddTicks(1087), null },
                    { 2L, new DateTime(2020, 5, 29, 5, 53, 57, 408, DateTimeKind.Utc).AddTicks(1252), null, "sandun", "", 0.0, null, new DateTime(2020, 5, 29, 5, 53, 57, 408, DateTimeKind.Utc).AddTicks(1253), null },
                    { 3L, new DateTime(2020, 5, 29, 5, 53, 57, 408, DateTimeKind.Utc).AddTicks(1274), null, "kumara", "", 0.0, null, new DateTime(2020, 5, 29, 5, 53, 57, 408, DateTimeKind.Utc).AddTicks(1275), null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CWM.ShopOwner",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "CWM.ShopOwner",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "CWM.ShopOwner",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.UpdateData(
                table: "CWM.Categories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 29, 13, 49, 8, 868, DateTimeKind.Local).AddTicks(2336), new DateTime(2020, 5, 29, 13, 49, 8, 869, DateTimeKind.Local).AddTicks(2039) });

            migrationBuilder.UpdateData(
                table: "CWM.Categories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 29, 13, 49, 8, 870, DateTimeKind.Local).AddTicks(5090), new DateTime(2020, 5, 29, 13, 49, 8, 870, DateTimeKind.Local).AddTicks(5107) });

            migrationBuilder.UpdateData(
                table: "CWM.Categories",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 29, 13, 49, 8, 870, DateTimeKind.Local).AddTicks(5249), new DateTime(2020, 5, 29, 13, 49, 8, 870, DateTimeKind.Local).AddTicks(5251) });

            migrationBuilder.UpdateData(
                table: "CWM.Locations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 29, 5, 49, 8, 870, DateTimeKind.Utc).AddTicks(8118), new DateTime(2020, 5, 29, 5, 49, 8, 870, DateTimeKind.Utc).AddTicks(8122) });

            migrationBuilder.UpdateData(
                table: "CWM.Locations",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 29, 5, 49, 8, 870, DateTimeKind.Utc).AddTicks(8339), new DateTime(2020, 5, 29, 5, 49, 8, 870, DateTimeKind.Utc).AddTicks(8340) });

            migrationBuilder.UpdateData(
                table: "CWM.Locations",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 29, 5, 49, 8, 870, DateTimeKind.Utc).AddTicks(8366), new DateTime(2020, 5, 29, 5, 49, 8, 870, DateTimeKind.Utc).AddTicks(8367) });

            migrationBuilder.UpdateData(
                table: "CWM.Services",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 29, 5, 49, 8, 870, DateTimeKind.Utc).AddTicks(9919), new DateTime(2020, 5, 29, 5, 49, 8, 870, DateTimeKind.Utc).AddTicks(9923) });

            migrationBuilder.UpdateData(
                table: "CWM.Services",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 29, 5, 49, 8, 871, DateTimeKind.Utc).AddTicks(90), new DateTime(2020, 5, 29, 5, 49, 8, 871, DateTimeKind.Utc).AddTicks(92) });

            migrationBuilder.UpdateData(
                table: "CWM.Services",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 29, 5, 49, 8, 871, DateTimeKind.Utc).AddTicks(116), new DateTime(2020, 5, 29, 5, 49, 8, 871, DateTimeKind.Utc).AddTicks(117) });
        }
    }
}
