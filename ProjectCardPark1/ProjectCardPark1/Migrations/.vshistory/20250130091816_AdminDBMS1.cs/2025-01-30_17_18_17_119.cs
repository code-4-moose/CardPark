using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectCardPark1.Migrations
{
    /// <inheritdoc />
    public partial class AdminDBMS1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 18, 15, 169, DateTimeKind.Local).AddTicks(5191), new DateTime(2025, 1, 30, 17, 18, 15, 169, DateTimeKind.Local).AddTicks(5216) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "96493331-b392-4a49-8dac-0e143b87082d", "AQAAAAIAAYagAAAAED/3X8xHICkVQrF7osAl67+V6O1YIXaQA4talGHPfqGiKBejANBWx7GAKY1GGEZ5Sg==", "fe2ce151-383a-418c-a722-b819662b4c7e" });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 18, 15, 169, DateTimeKind.Local).AddTicks(5978), new DateTime(2025, 1, 30, 17, 18, 15, 169, DateTimeKind.Local).AddTicks(5984) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 18, 15, 169, DateTimeKind.Local).AddTicks(5988), new DateTime(2025, 1, 30, 17, 18, 15, 169, DateTimeKind.Local).AddTicks(5989) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 18, 15, 169, DateTimeKind.Local).AddTicks(5992), new DateTime(2025, 1, 30, 17, 18, 15, 169, DateTimeKind.Local).AddTicks(5993) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 18, 15, 169, DateTimeKind.Local).AddTicks(5995), new DateTime(2025, 1, 30, 17, 18, 15, 169, DateTimeKind.Local).AddTicks(5996) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 18, 15, 169, DateTimeKind.Local).AddTicks(5998), new DateTime(2025, 1, 30, 17, 18, 15, 169, DateTimeKind.Local).AddTicks(5999) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 18, 15, 169, DateTimeKind.Local).AddTicks(6204), new DateTime(2025, 1, 30, 17, 18, 15, 169, DateTimeKind.Local).AddTicks(6205) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 18, 15, 169, DateTimeKind.Local).AddTicks(6208), new DateTime(2025, 1, 30, 17, 18, 15, 169, DateTimeKind.Local).AddTicks(6209) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 18, 15, 169, DateTimeKind.Local).AddTicks(6211), new DateTime(2025, 1, 30, 17, 18, 15, 169, DateTimeKind.Local).AddTicks(6212) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 18, 15, 169, DateTimeKind.Local).AddTicks(6400), new DateTime(2025, 1, 30, 17, 18, 15, 169, DateTimeKind.Local).AddTicks(6402) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 18, 15, 169, DateTimeKind.Local).AddTicks(6407), new DateTime(2025, 1, 30, 17, 18, 15, 169, DateTimeKind.Local).AddTicks(6407) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 18, 15, 169, DateTimeKind.Local).AddTicks(6410), new DateTime(2025, 1, 30, 17, 18, 15, 169, DateTimeKind.Local).AddTicks(6410) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 18, 15, 169, DateTimeKind.Local).AddTicks(6412), new DateTime(2025, 1, 30, 17, 18, 15, 169, DateTimeKind.Local).AddTicks(6413) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 18, 15, 169, DateTimeKind.Local).AddTicks(6416), new DateTime(2025, 1, 30, 17, 18, 15, 169, DateTimeKind.Local).AddTicks(6416) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 18, 15, 169, DateTimeKind.Local).AddTicks(6418), new DateTime(2025, 1, 30, 17, 18, 15, 169, DateTimeKind.Local).AddTicks(6419) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 13, 37, 208, DateTimeKind.Local).AddTicks(5938), new DateTime(2025, 1, 30, 17, 13, 37, 208, DateTimeKind.Local).AddTicks(5956) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "616adf23-dd69-4790-9cf6-2206d3546e0e", "AQAAAAIAAYagAAAAEOv6huGD6Cs7hh8HLbm1Qmp/NYBCiOGOqndp3RoaWSk03aSSXCeNvQsfqonObLbU5Q==", "14a30fdc-3e6c-454a-ba31-77b8688fbfc5" });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 13, 37, 208, DateTimeKind.Local).AddTicks(6371), new DateTime(2025, 1, 30, 17, 13, 37, 208, DateTimeKind.Local).AddTicks(6371) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 13, 37, 208, DateTimeKind.Local).AddTicks(6374), new DateTime(2025, 1, 30, 17, 13, 37, 208, DateTimeKind.Local).AddTicks(6374) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 13, 37, 208, DateTimeKind.Local).AddTicks(6376), new DateTime(2025, 1, 30, 17, 13, 37, 208, DateTimeKind.Local).AddTicks(6377) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 13, 37, 208, DateTimeKind.Local).AddTicks(6378), new DateTime(2025, 1, 30, 17, 13, 37, 208, DateTimeKind.Local).AddTicks(6379) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 13, 37, 208, DateTimeKind.Local).AddTicks(6380), new DateTime(2025, 1, 30, 17, 13, 37, 208, DateTimeKind.Local).AddTicks(6381) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 13, 37, 208, DateTimeKind.Local).AddTicks(6529), new DateTime(2025, 1, 30, 17, 13, 37, 208, DateTimeKind.Local).AddTicks(6530) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 13, 37, 208, DateTimeKind.Local).AddTicks(6532), new DateTime(2025, 1, 30, 17, 13, 37, 208, DateTimeKind.Local).AddTicks(6533) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 13, 37, 208, DateTimeKind.Local).AddTicks(6534), new DateTime(2025, 1, 30, 17, 13, 37, 208, DateTimeKind.Local).AddTicks(6535) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 13, 37, 208, DateTimeKind.Local).AddTicks(6673), new DateTime(2025, 1, 30, 17, 13, 37, 208, DateTimeKind.Local).AddTicks(6673) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 13, 37, 208, DateTimeKind.Local).AddTicks(6677), new DateTime(2025, 1, 30, 17, 13, 37, 208, DateTimeKind.Local).AddTicks(6677) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 13, 37, 208, DateTimeKind.Local).AddTicks(6679), new DateTime(2025, 1, 30, 17, 13, 37, 208, DateTimeKind.Local).AddTicks(6679) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 13, 37, 208, DateTimeKind.Local).AddTicks(6681), new DateTime(2025, 1, 30, 17, 13, 37, 208, DateTimeKind.Local).AddTicks(6681) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 13, 37, 208, DateTimeKind.Local).AddTicks(6683), new DateTime(2025, 1, 30, 17, 13, 37, 208, DateTimeKind.Local).AddTicks(6683) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 13, 37, 208, DateTimeKind.Local).AddTicks(6685), new DateTime(2025, 1, 30, 17, 13, 37, 208, DateTimeKind.Local).AddTicks(6685) });
        }
    }
}
