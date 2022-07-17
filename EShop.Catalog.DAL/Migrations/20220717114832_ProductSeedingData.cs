using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EShop.Catalog.DAL.Migrations
{
    public partial class ProductSeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "id", "created_at", "deleted_at", "description", "manufacturer_id", "name", "updated_at" },
                values: new object[,]
                {
                    { new Guid("45458fa1-c499-4c60-b373-072d7fa12fb0"), new DateTimeOffset(new DateTime(2022, 7, 17, 13, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0)), null, null, new Guid("03618b30-ffa1-44cb-8bd7-94e1bab58ece"), "Remo Mondo Djembe 14\" Adinkra", new DateTimeOffset(new DateTime(2022, 7, 17, 13, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0)) },
                    { new Guid("48e06835-984b-48ba-8dd7-97a99092c77d"), new DateTimeOffset(new DateTime(2022, 7, 17, 13, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0)), null, null, new Guid("03618b30-ffa1-44cb-8bd7-94e1bab58ece"), "Remo Djembe Bag Deluxe 14\"", new DateTimeOffset(new DateTime(2022, 7, 17, 13, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0)) },
                    { new Guid("81675ffa-c0cd-4c60-bd12-8368f08dedf4"), new DateTimeOffset(new DateTime(2022, 7, 17, 13, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0)), null, null, new Guid("13e22dc8-e1e1-489f-a618-9dae375bdace"), "Casio Celviano AP-470", new DateTimeOffset(new DateTime(2022, 7, 17, 13, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0)) },
                    { new Guid("d11cfe18-d46e-4c85-a726-dd41aca37b99"), new DateTimeOffset(new DateTime(2022, 7, 17, 13, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0)), null, "Part of Kremona's Flamenco Series, the Rosa Morena's subtle flamenco design elements enable snap and spontaneity, while its Indian rosewood and European spruce construct conveys the stately depth of a concert classical. Other appointments include a bone nut and saddle, wood binding and rosette, and a gold machines with pearloid buttons.", new Guid("b3964f15-ddcc-4582-bcca-43ec7c31e1c2"), "Kremona Rosa Morena", new DateTimeOffset(new DateTime(2022, 7, 17, 13, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0)) },
                    { new Guid("d2406749-4588-4c95-8849-e82c9a38768f"), new DateTimeOffset(new DateTime(2022, 7, 17, 13, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0)), null, null, new Guid("c828b3d4-c478-427f-82d6-bffc681626b9"), "Moog Subsequent 37", new DateTimeOffset(new DateTime(2022, 7, 17, 13, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0)) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("45458fa1-c499-4c60-b373-072d7fa12fb0"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("48e06835-984b-48ba-8dd7-97a99092c77d"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("81675ffa-c0cd-4c60-bd12-8368f08dedf4"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("d11cfe18-d46e-4c85-a726-dd41aca37b99"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("d2406749-4588-4c95-8849-e82c9a38768f"));
        }
    }
}
