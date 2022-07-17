using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EShop.Catalog.DAL.Migrations
{
    public partial class ManufacturerSeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "manufacturers",
                columns: new[] { "id", "created_at", "deleted_at", "description", "name", "updated_at" },
                values: new object[,]
                {
                    { new Guid("03618b30-ffa1-44cb-8bd7-94e1bab58ece"), new DateTimeOffset(new DateTime(2022, 7, 17, 13, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0)), null, null, "Remo", new DateTimeOffset(new DateTime(2022, 7, 17, 13, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0)) },
                    { new Guid("13e22dc8-e1e1-489f-a618-9dae375bdace"), new DateTimeOffset(new DateTime(2022, 7, 17, 13, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0)), null, null, "Casio", new DateTimeOffset(new DateTime(2022, 7, 17, 13, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0)) },
                    { new Guid("990025a6-5d43-44ef-aaae-76b158a0b61a"), new DateTimeOffset(new DateTime(2022, 7, 17, 13, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0)), null, null, "Ableton", new DateTimeOffset(new DateTime(2022, 7, 17, 13, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0)) },
                    { new Guid("b3964f15-ddcc-4582-bcca-43ec7c31e1c2"), new DateTimeOffset(new DateTime(2022, 7, 17, 13, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0)), null, null, "Kremona", new DateTimeOffset(new DateTime(2022, 7, 17, 13, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0)) },
                    { new Guid("c828b3d4-c478-427f-82d6-bffc681626b9"), new DateTimeOffset(new DateTime(2022, 7, 17, 13, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0)), null, null, "Moog", new DateTimeOffset(new DateTime(2022, 7, 17, 13, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0)) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "manufacturers",
                keyColumn: "id",
                keyValue: new Guid("03618b30-ffa1-44cb-8bd7-94e1bab58ece"));

            migrationBuilder.DeleteData(
                table: "manufacturers",
                keyColumn: "id",
                keyValue: new Guid("13e22dc8-e1e1-489f-a618-9dae375bdace"));

            migrationBuilder.DeleteData(
                table: "manufacturers",
                keyColumn: "id",
                keyValue: new Guid("990025a6-5d43-44ef-aaae-76b158a0b61a"));

            migrationBuilder.DeleteData(
                table: "manufacturers",
                keyColumn: "id",
                keyValue: new Guid("b3964f15-ddcc-4582-bcca-43ec7c31e1c2"));

            migrationBuilder.DeleteData(
                table: "manufacturers",
                keyColumn: "id",
                keyValue: new Guid("c828b3d4-c478-427f-82d6-bffc681626b9"));
        }
    }
}
