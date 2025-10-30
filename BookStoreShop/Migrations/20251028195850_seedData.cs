using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStoreShop.Migrations
{
    /// <inheritdoc />
    public partial class seedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImagePath",
                table: "Categories",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "ImagePath",
                table: "Books",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedAtFA",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PublishYear",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedAt", "Description", "ImagePath" },
                values: new object[,]
                {
                    { 1, "Biography", new DateTime(2025, 10, 28, 23, 28, 49, 212, DateTimeKind.Local).AddTicks(5542), "Bio", "/img/category/bio.jpeg" },
                    { 2, "Comedy", new DateTime(2025, 10, 28, 23, 28, 49, 212, DateTimeKind.Local).AddTicks(5552), "Comedy", "/img/category/comedy.jpeg" },
                    { 3, "Political", new DateTime(2025, 10, 28, 23, 28, 49, 212, DateTimeKind.Local).AddTicks(5555), "Political", "/img/category/political.jpeg" },
                    { 4, "Sport", new DateTime(2025, 10, 28, 23, 28, 49, 212, DateTimeKind.Local).AddTicks(5557), "Sport", "/img/category/sport.jpeg" },
                    { 5, "Tragedi", new DateTime(2025, 10, 28, 23, 28, 49, 212, DateTimeKind.Local).AddTicks(5558), "Tragedi", "/img/category/tragedi.jpeg" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CategoryId", "CreatedAt", "CreatedAtFA", "ImagePath", "PageCount", "Price", "PublishYear", "Title" },
                values: new object[,]
                {
                    { 1, "Asghar Farhadi", 1, new DateTime(2025, 10, 28, 23, 28, 49, 212, DateTimeKind.Local).AddTicks(3124), null, "/img/books/seller.jpeg", 200, 200000m, "1398", "Seller" },
                    { 2, "Soroush Sehat", 1, new DateTime(2025, 10, 28, 23, 28, 49, 212, DateTimeKind.Local).AddTicks(3149), null, "/img/books/zarrafeh.jpeg", 200, 200000m, "1398", "Breakfast with " },
                    { 3, "Asghar Farhadi", 1, new DateTime(2025, 10, 28, 23, 28, 49, 212, DateTimeKind.Local).AddTicks(3152), null, "/img/books/hero.jpeg", 200, 200000m, "1398", "Hero" },
                    { 4, "Saead Roustaiee", 1, new DateTime(2025, 10, 28, 23, 28, 49, 212, DateTimeKind.Local).AddTicks(3156), null, "/img/books/metri.jpeg", 200, 200000m, "1398", "Metri Shish o nim" },
                    { 5, "Asghar Farhadi", 1, new DateTime(2025, 10, 28, 23, 28, 49, 212, DateTimeKind.Local).AddTicks(3158), null, "/img/books/hotel.jpeg", 200, 200000m, "1398", "Hotel" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "CreatedAtFA",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "PublishYear",
                table: "Books");

            migrationBuilder.AlterColumn<string>(
                name: "ImagePath",
                table: "Categories",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImagePath",
                table: "Books",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);
        }
    }
}
