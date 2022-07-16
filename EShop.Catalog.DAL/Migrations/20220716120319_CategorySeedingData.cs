using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EShop.Catalog.DAL.Migrations
{
    public partial class CategorySeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "id", "created_at", "deleted_at", "description", "name", "updated_at" },
                values: new object[,]
                {
                    { new Guid("0aedc2cf-3338-44df-b346-37adc399acae"), new DateTimeOffset(new DateTime(2022, 7, 16, 15, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 3, 0, 0, 0)), null, "Acoustic and electric drums for beginners and professionals.", "Drums", new DateTimeOffset(new DateTime(2022, 7, 16, 15, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7720), new TimeSpan(0, 3, 0, 0, 0)) },
                    { new Guid("4f71bda6-0fb9-4b45-aada-39e3bfd89548"), new DateTimeOffset(new DateTime(2022, 7, 16, 15, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7700), new TimeSpan(0, 3, 0, 0, 0)), null, "Acoustic and electric guitars for beginners and professionals.", "Guitars", new DateTimeOffset(new DateTime(2022, 7, 16, 15, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 3, 0, 0, 0)) },
                    { new Guid("84ddb38f-8d9e-4e4b-9022-4085ced63475"), new DateTimeOffset(new DateTime(2022, 7, 16, 15, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0)), null, "Digital pianos for beginners and professionals.", "Pianos", new DateTimeOffset(new DateTime(2022, 7, 16, 15, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7690), new TimeSpan(0, 3, 0, 0, 0)) },
                    { new Guid("b5718b16-3974-4949-a372-b8d93d2352f4"), new DateTimeOffset(new DateTime(2022, 7, 16, 15, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7730), new TimeSpan(0, 3, 0, 0, 0)), null, null, "Synthesizers", new DateTimeOffset(new DateTime(2022, 7, 16, 15, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7730), new TimeSpan(0, 3, 0, 0, 0)) },
                    { new Guid("c547c364-5434-428f-803d-0fdd04f7d48e"), new DateTimeOffset(new DateTime(2022, 7, 16, 15, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7740), new TimeSpan(0, 3, 0, 0, 0)), null, null, "Accessories", new DateTimeOffset(new DateTime(2022, 7, 16, 15, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7750), new TimeSpan(0, 3, 0, 0, 0)) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("0aedc2cf-3338-44df-b346-37adc399acae"));

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("4f71bda6-0fb9-4b45-aada-39e3bfd89548"));

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("84ddb38f-8d9e-4e4b-9022-4085ced63475"));

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("b5718b16-3974-4949-a372-b8d93d2352f4"));

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("c547c364-5434-428f-803d-0fdd04f7d48e"));
        }
    }
}
