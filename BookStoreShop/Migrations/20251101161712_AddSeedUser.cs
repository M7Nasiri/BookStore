using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreShop.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 1, 19, 47, 11, 676, DateTimeKind.Local).AddTicks(5868));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 1, 19, 47, 11, 676, DateTimeKind.Local).AddTicks(5888));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 1, 19, 47, 11, 676, DateTimeKind.Local).AddTicks(5891));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 1, 19, 47, 11, 676, DateTimeKind.Local).AddTicks(5893));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 1, 19, 47, 11, 676, DateTimeKind.Local).AddTicks(5952));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 1, 19, 47, 11, 676, DateTimeKind.Local).AddTicks(8068));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 1, 19, 47, 11, 676, DateTimeKind.Local).AddTicks(8074));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 1, 19, 47, 11, 676, DateTimeKind.Local).AddTicks(8076));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 1, 19, 47, 11, 676, DateTimeKind.Local).AddTicks(8078));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 1, 19, 47, 11, 676, DateTimeKind.Local).AddTicks(8079));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FullName", "Password", "Role", "UserImagePath", "UserName" },
                values: new object[] { 1, "admin", "123", 1, null, "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 1, 15, 42, 25, 800, DateTimeKind.Local).AddTicks(9920));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 1, 15, 42, 25, 800, DateTimeKind.Local).AddTicks(9953));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 1, 15, 42, 25, 800, DateTimeKind.Local).AddTicks(9957));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 1, 15, 42, 25, 800, DateTimeKind.Local).AddTicks(9961));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 1, 15, 42, 25, 800, DateTimeKind.Local).AddTicks(9965));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 1, 15, 42, 25, 801, DateTimeKind.Local).AddTicks(2976));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 1, 15, 42, 25, 801, DateTimeKind.Local).AddTicks(2989));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 1, 15, 42, 25, 801, DateTimeKind.Local).AddTicks(2991));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 1, 15, 42, 25, 801, DateTimeKind.Local).AddTicks(2993));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 1, 15, 42, 25, 801, DateTimeKind.Local).AddTicks(2995));
        }
    }
}
