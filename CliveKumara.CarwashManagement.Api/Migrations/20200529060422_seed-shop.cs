using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CliveKumara.CarwashManagement.Api.Migrations
{
    public partial class seedshop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CWM.Categories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 29, 14, 4, 21, 655, DateTimeKind.Local).AddTicks(8782), new DateTime(2020, 5, 29, 14, 4, 21, 657, DateTimeKind.Local).AddTicks(4828) });

            migrationBuilder.UpdateData(
                table: "CWM.Categories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 29, 14, 4, 21, 660, DateTimeKind.Local).AddTicks(526), new DateTime(2020, 5, 29, 14, 4, 21, 660, DateTimeKind.Local).AddTicks(575) });

            migrationBuilder.UpdateData(
                table: "CWM.Categories",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 29, 14, 4, 21, 660, DateTimeKind.Local).AddTicks(977), new DateTime(2020, 5, 29, 14, 4, 21, 660, DateTimeKind.Local).AddTicks(985) });

            migrationBuilder.UpdateData(
                table: "CWM.Locations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 29, 6, 4, 21, 660, DateTimeKind.Utc).AddTicks(4924), new DateTime(2020, 5, 29, 6, 4, 21, 660, DateTimeKind.Utc).AddTicks(4934) });

            migrationBuilder.UpdateData(
                table: "CWM.Locations",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 29, 6, 4, 21, 660, DateTimeKind.Utc).AddTicks(5331), new DateTime(2020, 5, 29, 6, 4, 21, 660, DateTimeKind.Utc).AddTicks(5333) });

            migrationBuilder.UpdateData(
                table: "CWM.Locations",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 29, 6, 4, 21, 660, DateTimeKind.Utc).AddTicks(5371), new DateTime(2020, 5, 29, 6, 4, 21, 660, DateTimeKind.Utc).AddTicks(5373) });

            migrationBuilder.UpdateData(
                table: "CWM.Services",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 29, 6, 4, 21, 660, DateTimeKind.Utc).AddTicks(7530), new DateTime(2020, 5, 29, 6, 4, 21, 660, DateTimeKind.Utc).AddTicks(7536) });

            migrationBuilder.UpdateData(
                table: "CWM.Services",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 29, 6, 4, 21, 660, DateTimeKind.Utc).AddTicks(7792), new DateTime(2020, 5, 29, 6, 4, 21, 660, DateTimeKind.Utc).AddTicks(7795) });

            migrationBuilder.UpdateData(
                table: "CWM.Services",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 29, 6, 4, 21, 660, DateTimeKind.Utc).AddTicks(7827), new DateTime(2020, 5, 29, 6, 4, 21, 660, DateTimeKind.Utc).AddTicks(7829) });

            migrationBuilder.UpdateData(
                table: "CWM.ShopOwner",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 29, 6, 4, 21, 660, DateTimeKind.Utc).AddTicks(9849), new DateTime(2020, 5, 29, 6, 4, 21, 660, DateTimeKind.Utc).AddTicks(9854) });

            migrationBuilder.UpdateData(
                table: "CWM.ShopOwner",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 29, 6, 4, 21, 661, DateTimeKind.Utc).AddTicks(91), new DateTime(2020, 5, 29, 6, 4, 21, 661, DateTimeKind.Utc).AddTicks(94) });

            migrationBuilder.UpdateData(
                table: "CWM.ShopOwner",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 29, 6, 4, 21, 661, DateTimeKind.Utc).AddTicks(124), new DateTime(2020, 5, 29, 6, 4, 21, 661, DateTimeKind.Utc).AddTicks(126) });

            migrationBuilder.InsertData(
                table: "CWM.Shops",
                columns: new[] { "Id", "Address", "CategoryId", "CreatedDate", "Description", "Email", "Hour", "Hours", "Image", "LocationId", "Mobile", "Phone", "Phone2", "PriceRangeStart", "PriceRangeStop", "RateText", "ShopOwnerId", "Status", "SubTitle", "TabSettings", "Title", "UpdatedDate", "Website" },
                values: new object[,]
                {
                    { 1L, "Nugegoda", 1L, new DateTime(2020, 5, 29, 6, 4, 21, 662, DateTimeKind.Utc).AddTicks(7095), "Loresipsm", null, "9-6", "{}", "", 1L, "0718256773", "0718256773", null, 250.0, 6500.0, null, 1L, "Featured", "Echo Zone - 3M Tint", "{}", "Echo Zone - 3M Tint", new DateTime(2020, 5, 29, 6, 4, 21, 662, DateTimeKind.Utc).AddTicks(7115), null },
                    { 2L, "Colombo 6", 1L, new DateTime(2020, 5, 29, 6, 4, 21, 662, DateTimeKind.Utc).AddTicks(7993), "Loresipsm", null, "9-6", "{}", "", 2L, "0718256773", "0718256773", null, 250.0, 6500.0, null, 2L, "Featured", "Alpine Car Wash", "{}", "Alpine Car Wash", new DateTime(2020, 5, 29, 6, 4, 21, 662, DateTimeKind.Utc).AddTicks(7999), null },
                    { 3L, "Colombo", 1L, new DateTime(2020, 5, 29, 6, 4, 21, 662, DateTimeKind.Utc).AddTicks(8056), "Loresipsm", null, "9-6", "{}", "", 3L, "0718256773", "0718256773", null, 250.0, 6500.0, null, 3L, "Featured", "Staford motors ", "{}", "Staford motors ", new DateTime(2020, 5, 29, 6, 4, 21, 662, DateTimeKind.Utc).AddTicks(8058), null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CWM.Shops",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "CWM.Shops",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "CWM.Shops",
                keyColumn: "Id",
                keyValue: 3L);

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

            migrationBuilder.UpdateData(
                table: "CWM.ShopOwner",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 29, 5, 53, 57, 408, DateTimeKind.Utc).AddTicks(1084), new DateTime(2020, 5, 29, 5, 53, 57, 408, DateTimeKind.Utc).AddTicks(1087) });

            migrationBuilder.UpdateData(
                table: "CWM.ShopOwner",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 29, 5, 53, 57, 408, DateTimeKind.Utc).AddTicks(1252), new DateTime(2020, 5, 29, 5, 53, 57, 408, DateTimeKind.Utc).AddTicks(1253) });

            migrationBuilder.UpdateData(
                table: "CWM.ShopOwner",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 29, 5, 53, 57, 408, DateTimeKind.Utc).AddTicks(1274), new DateTime(2020, 5, 29, 5, 53, 57, 408, DateTimeKind.Utc).AddTicks(1275) });
        }
    }
}
