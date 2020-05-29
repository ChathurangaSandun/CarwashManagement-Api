using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CliveKumara.CarwashManagement.Api.Migrations
{
    public partial class seedlocations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "CWM.Locations",
                columns: new[] { "Id", "Address", "CreatedDate", "Lat", "Long", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, "Nugegoda", new DateTime(2020, 5, 29, 5, 45, 54, 969, DateTimeKind.Utc).AddTicks(710), 79.86965f, 6.864756f, "Echo Zone - 3M Tint", new DateTime(2020, 5, 29, 5, 45, 54, 969, DateTimeKind.Utc).AddTicks(714) },
                    { 2L, "Colombo 6", new DateTime(2020, 5, 29, 5, 45, 54, 969, DateTimeKind.Utc).AddTicks(906), 79.86487f, 6.87702f, "Alpine Car Wash", new DateTime(2020, 5, 29, 5, 45, 54, 969, DateTimeKind.Utc).AddTicks(907) },
                    { 3L, "Colombo", new DateTime(2020, 5, 29, 5, 45, 54, 969, DateTimeKind.Utc).AddTicks(929), 79.79967f, 6.864813f, "Staford motors ", new DateTime(2020, 5, 29, 5, 45, 54, 969, DateTimeKind.Utc).AddTicks(929) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CWM.Locations",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "CWM.Locations",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "CWM.Locations",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.UpdateData(
                table: "CWM.Categories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 29, 11, 47, 13, 426, DateTimeKind.Local).AddTicks(2628), new DateTime(2020, 5, 29, 11, 47, 13, 427, DateTimeKind.Local).AddTicks(1155) });

            migrationBuilder.UpdateData(
                table: "CWM.Categories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 29, 11, 47, 13, 428, DateTimeKind.Local).AddTicks(2913), new DateTime(2020, 5, 29, 11, 47, 13, 428, DateTimeKind.Local).AddTicks(2928) });

            migrationBuilder.UpdateData(
                table: "CWM.Categories",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 29, 11, 47, 13, 428, DateTimeKind.Local).AddTicks(3052), new DateTime(2020, 5, 29, 11, 47, 13, 428, DateTimeKind.Local).AddTicks(3054) });
        }
    }
}
