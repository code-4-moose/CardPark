uusing System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectCardPark1.Migrations
{
    /// <inheritdoc />
    public partial class ReviewerName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ReviewerName",
                table: "Rating",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 31, 23, 13, 57, 383, DateTimeKind.Local).AddTicks(9486), new DateTime(2025, 1, 31, 23, 13, 57, 383, DateTimeKind.Local).AddTicks(9499) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6180512b-9726-4ea2-b37e-2cf7a9f1c014", "AQAAAAIAAYagAAAAEI8uMqPO2iIC2rM+S7Z9CW9tIz0gEye4e1+mWIVHo6PjMhhU9kNw9/oigEfYodM7Sw==", "d97190a6-c512-4720-9144-1e26277d3fe6" });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 31, 23, 13, 57, 383, DateTimeKind.Local).AddTicks(9778), new DateTime(2025, 1, 31, 23, 13, 57, 383, DateTimeKind.Local).AddTicks(9779) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 31, 23, 13, 57, 383, DateTimeKind.Local).AddTicks(9782), new DateTime(2025, 1, 31, 23, 13, 57, 383, DateTimeKind.Local).AddTicks(9782) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 31, 23, 13, 57, 383, DateTimeKind.Local).AddTicks(9784), new DateTime(2025, 1, 31, 23, 13, 57, 383, DateTimeKind.Local).AddTicks(9784) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 31, 23, 13, 57, 383, DateTimeKind.Local).AddTicks(9786), new DateTime(2025, 1, 31, 23, 13, 57, 383, DateTimeKind.Local).AddTicks(9786) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 31, 23, 13, 57, 383, DateTimeKind.Local).AddTicks(9788), new DateTime(2025, 1, 31, 23, 13, 57, 383, DateTimeKind.Local).AddTicks(9788) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 31, 23, 13, 57, 383, DateTimeKind.Local).AddTicks(9903), new DateTime(2025, 1, 31, 23, 13, 57, 383, DateTimeKind.Local).AddTicks(9904) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 31, 23, 13, 57, 383, DateTimeKind.Local).AddTicks(9906), new DateTime(2025, 1, 31, 23, 13, 57, 383, DateTimeKind.Local).AddTicks(9907) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 31, 23, 13, 57, 383, DateTimeKind.Local).AddTicks(9908), new DateTime(2025, 1, 31, 23, 13, 57, 383, DateTimeKind.Local).AddTicks(9909) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "ReviewerName" },
                values: new object[] { new DateTime(2025, 1, 31, 23, 13, 57, 384, DateTimeKind.Local).AddTicks(19), new DateTime(2025, 1, 31, 23, 13, 57, 384, DateTimeKind.Local).AddTicks(20), null });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "ReviewerName" },
                values: new object[] { new DateTime(2025, 1, 31, 23, 13, 57, 384, DateTimeKind.Local).AddTicks(23), new DateTime(2025, 1, 31, 23, 13, 57, 384, DateTimeKind.Local).AddTicks(23), null });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "ReviewerName" },
                values: new object[] { new DateTime(2025, 1, 31, 23, 13, 57, 384, DateTimeKind.Local).AddTicks(25), new DateTime(2025, 1, 31, 23, 13, 57, 384, DateTimeKind.Local).AddTicks(26), null });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated", "ReviewerName" },
                values: new object[] { new DateTime(2025, 1, 31, 23, 13, 57, 384, DateTimeKind.Local).AddTicks(27), new DateTime(2025, 1, 31, 23, 13, 57, 384, DateTimeKind.Local).AddTicks(27), null });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated", "ReviewerName" },
                values: new object[] { new DateTime(2025, 1, 31, 23, 13, 57, 384, DateTimeKind.Local).AddTicks(29), new DateTime(2025, 1, 31, 23, 13, 57, 384, DateTimeKind.Local).AddTicks(29), null });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated", "ReviewerName" },
                values: new object[] { new DateTime(2025, 1, 31, 23, 13, 57, 384, DateTimeKind.Local).AddTicks(31), new DateTime(2025, 1, 31, 23, 13, 57, 384, DateTimeKind.Local).AddTicks(31), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReviewerName",
                table: "Rating");

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 25, 56, 326, DateTimeKind.Local).AddTicks(9286), new DateTime(2025, 1, 30, 17, 25, 56, 326, DateTimeKind.Local).AddTicks(9298) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ca26d35-c2fe-46a7-8abc-70b48104dc78", "AQAAAAIAAYagAAAAEBIwFBqyB/LyaHY8ecbnNOvdSQK5K/k41I0RzcD9jHzWfL6gK8asG8slFrTCarXHIw==", "9cce76a4-1484-4ffa-b6aa-9330b0540f7f" });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 25, 56, 326, DateTimeKind.Local).AddTicks(9688), new DateTime(2025, 1, 30, 17, 25, 56, 326, DateTimeKind.Local).AddTicks(9688) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 25, 56, 326, DateTimeKind.Local).AddTicks(9692), new DateTime(2025, 1, 30, 17, 25, 56, 326, DateTimeKind.Local).AddTicks(9692) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 25, 56, 326, DateTimeKind.Local).AddTicks(9694), new DateTime(2025, 1, 30, 17, 25, 56, 326, DateTimeKind.Local).AddTicks(9694) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 25, 56, 326, DateTimeKind.Local).AddTicks(9696), new DateTime(2025, 1, 30, 17, 25, 56, 326, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 25, 56, 326, DateTimeKind.Local).AddTicks(9698), new DateTime(2025, 1, 30, 17, 25, 56, 326, DateTimeKind.Local).AddTicks(9699) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 25, 56, 326, DateTimeKind.Local).AddTicks(9832), new DateTime(2025, 1, 30, 17, 25, 56, 326, DateTimeKind.Local).AddTicks(9832) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 25, 56, 326, DateTimeKind.Local).AddTicks(9835), new DateTime(2025, 1, 30, 17, 25, 56, 326, DateTimeKind.Local).AddTicks(9835) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 25, 56, 326, DateTimeKind.Local).AddTicks(9837), new DateTime(2025, 1, 30, 17, 25, 56, 326, DateTimeKind.Local).AddTicks(9837) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 25, 56, 327, DateTimeKind.Local).AddTicks(235), new DateTime(2025, 1, 30, 17, 25, 56, 327, DateTimeKind.Local).AddTicks(240) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 25, 56, 327, DateTimeKind.Local).AddTicks(244), new DateTime(2025, 1, 30, 17, 25, 56, 327, DateTimeKind.Local).AddTicks(244) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 25, 56, 327, DateTimeKind.Local).AddTicks(246), new DateTime(2025, 1, 30, 17, 25, 56, 327, DateTimeKind.Local).AddTicks(247) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 25, 56, 327, DateTimeKind.Local).AddTicks(249), new DateTime(2025, 1, 30, 17, 25, 56, 327, DateTimeKind.Local).AddTicks(249) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 25, 56, 327, DateTimeKind.Local).AddTicks(251), new DateTime(2025, 1, 30, 17, 25, 56, 327, DateTimeKind.Local).AddTicks(252) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 25, 56, 327, DateTimeKind.Local).AddTicks(253), new DateTime(2025, 1, 30, 17, 25, 56, 327, DateTimeKind.Local).AddTicks(254) });
        }
    }
}
