using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CliveKumara.CarwashManagement.Api.Migrations
{
    public partial class seedservices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "CWM.Services",
                columns: new[] { "Id", "CreatedDate", "Icon", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2020, 5, 29, 5, 49, 8, 870, DateTimeKind.Utc).AddTicks(9919), "", "Wash", new DateTime(2020, 5, 29, 5, 49, 8, 870, DateTimeKind.Utc).AddTicks(9923) },
                    { 2L, new DateTime(2020, 5, 29, 5, 49, 8, 871, DateTimeKind.Utc).AddTicks(90), "", "Vax", new DateTime(2020, 5, 29, 5, 49, 8, 871, DateTimeKind.Utc).AddTicks(92) },
                    { 3L, new DateTime(2020, 5, 29, 5, 49, 8, 871, DateTimeKind.Utc).AddTicks(116), "", "Full Body", new DateTime(2020, 5, 29, 5, 49, 8, 871, DateTimeKind.Utc).AddTicks(117) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CWM.Services",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "CWM.Services",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "CWM.Services",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.UpdateData(
                table: "CWM.Categories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 29, 13, 45, 54, 966, DateTimeKind.Local).AddTicks(8026), new DateTime(2020, 5, 29, 13, 45, 54, 967, DateTimeKind.Local).AddTicks(6495) });

            migrationBuilder.UpdateData(
                table: "CWM.Categories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 29, 13, 45, 54, 968, DateTimeKind.Local).AddTicks(8179), new DateTime(2020, 5, 29, 13, 45, 54, 968, DateTimeKind.Local).AddTicks(8193) });

            migrationBuilder.UpdateData(
                table: "CWM.Categories",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 29, 13, 45, 54, 968, DateTimeKind.Local).AddTicks(8311), new DateTime(2020, 5, 29, 13, 45, 54, 968, DateTimeKind.Local).AddTicks(8314) });

            migrationBuilder.UpdateData(
                table: "CWM.Locations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 29, 5, 45, 54, 969, DateTimeKind.Utc).AddTicks(710), new DateTime(2020, 5, 29, 5, 45, 54, 969, DateTimeKind.Utc).AddTicks(714) });

            migrationBuilder.UpdateData(
                table: "CWM.Locations",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 29, 5, 45, 54, 969, DateTimeKind.Utc).AddTicks(906), new DateTime(2020, 5, 29, 5, 45, 54, 969, DateTimeKind.Utc).AddTicks(907) });

            migrationBuilder.UpdateData(
                table: "CWM.Locations",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 29, 5, 45, 54, 969, DateTimeKind.Utc).AddTicks(929), new DateTime(2020, 5, 29, 5, 45, 54, 969, DateTimeKind.Utc).AddTicks(929) });
        }
    }
}
