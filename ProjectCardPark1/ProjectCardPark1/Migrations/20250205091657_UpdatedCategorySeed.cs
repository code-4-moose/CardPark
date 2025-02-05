using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectCardPark1.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedCategorySeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f37c16b9-9645-438e-9b71-d20bb7ea72a8", "AQAAAAIAAYagAAAAEDuL2YW8ubR8QkOfX8mkPAbXtckd4+ZLg2CAYhGcq/LoajdqPhc9paPSJMjerkWdQA==", "35cf0245-87a2-45eb-9259-68d78b1b0a2b" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Name" },
                values: new object[] { new DateTime(2025, 2, 5, 17, 16, 56, 452, DateTimeKind.Local).AddTicks(5290), new DateTime(2025, 2, 5, 17, 16, 56, 452, DateTimeKind.Local).AddTicks(5301), "Vanguard" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Name" },
                values: new object[] { new DateTime(2025, 2, 5, 17, 16, 56, 452, DateTimeKind.Local).AddTicks(5305), new DateTime(2025, 2, 5, 17, 16, 56, 452, DateTimeKind.Local).AddTicks(5305), "Pokemon" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "Name" },
                values: new object[] { new DateTime(2025, 2, 5, 17, 16, 56, 452, DateTimeKind.Local).AddTicks(5307), new DateTime(2025, 2, 5, 17, 16, 56, 452, DateTimeKind.Local).AddTicks(5308), "Hololive" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4be3847a-6325-492e-8b4b-b4080439f5ad", "AQAAAAIAAYagAAAAEMAlAzcmWIbAvB5mgGCcgbjzWPlTNDfcPIAa5NdWVBRobwk+YaY2D0frPdV1l/3Tiw==", "5c55e5ef-4786-4043-8cfa-b763061560b5" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Name" },
                values: new object[] { new DateTime(2025, 2, 5, 17, 4, 29, 640, DateTimeKind.Local).AddTicks(4164), new DateTime(2025, 2, 5, 17, 4, 29, 640, DateTimeKind.Local).AddTicks(4181), "PG" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Name" },
                values: new object[] { new DateTime(2025, 2, 5, 17, 4, 29, 640, DateTimeKind.Local).AddTicks(4185), new DateTime(2025, 2, 5, 17, 4, 29, 640, DateTimeKind.Local).AddTicks(4186), "PG" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "Name" },
                values: new object[] { new DateTime(2025, 2, 5, 17, 4, 29, 640, DateTimeKind.Local).AddTicks(4187), new DateTime(2025, 2, 5, 17, 4, 29, 640, DateTimeKind.Local).AddTicks(4188), "R18" });
        }
    }
}
