using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EShop.Catalog.DAL.Migrations
{
    public partial class ProductCategorySeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "product_categories",
                columns: new[] { "id", "category_id", "created_at", "deleted_at", "product_id", "updated_at" },
                values: new object[,]
                {
                    { new Guid("1b2f3b8e-cddd-443a-a5fa-1833241d9168"), new Guid("84ddb38f-8d9e-4e4b-9022-4085ced63475"), new DateTimeOffset(new DateTime(2022, 7, 17, 15, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0)), null, new Guid("81675ffa-c0cd-4c60-bd12-8368f08dedf4"), new DateTimeOffset(new DateTime(2022, 7, 17, 15, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0)) },
                    { new Guid("6526eb2e-3162-4100-b391-c03c638515b9"), new Guid("0aedc2cf-3338-44df-b346-37adc399acae"), new DateTimeOffset(new DateTime(2022, 7, 17, 15, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0)), null, new Guid("45458fa1-c499-4c60-b373-072d7fa12fb0"), new DateTimeOffset(new DateTime(2022, 7, 17, 15, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0)) },
                    { new Guid("abfe8f1f-093a-4851-9cf3-c832ea8ed923"), new Guid("c547c364-5434-428f-803d-0fdd04f7d48e"), new DateTimeOffset(new DateTime(2022, 7, 17, 15, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0)), null, new Guid("48e06835-984b-48ba-8dd7-97a99092c77d"), new DateTimeOffset(new DateTime(2022, 7, 17, 15, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0)) },
                    { new Guid("aeddf5ab-4401-4ce7-ad9d-b870352f1232"), new Guid("4f71bda6-0fb9-4b45-aada-39e3bfd89548"), new DateTimeOffset(new DateTime(2022, 7, 17, 15, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0)), null, new Guid("d11cfe18-d46e-4c85-a726-dd41aca37b99"), new DateTimeOffset(new DateTime(2022, 7, 17, 15, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0)) },
                    { new Guid("b0dfab09-edf1-4b55-a055-1627fd2db059"), new Guid("b5718b16-3974-4949-a372-b8d93d2352f4"), new DateTimeOffset(new DateTime(2022, 7, 17, 15, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0)), null, new Guid("d2406749-4588-4c95-8849-e82c9a38768f"), new DateTimeOffset(new DateTime(2022, 7, 17, 15, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0)) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product_categories",
                keyColumn: "id",
                keyValue: new Guid("1b2f3b8e-cddd-443a-a5fa-1833241d9168"));

            migrationBuilder.DeleteData(
                table: "product_categories",
                keyColumn: "id",
                keyValue: new Guid("6526eb2e-3162-4100-b391-c03c638515b9"));

            migrationBuilder.DeleteData(
                table: "product_categories",
                keyColumn: "id",
                keyValue: new Guid("abfe8f1f-093a-4851-9cf3-c832ea8ed923"));

            migrationBuilder.DeleteData(
                table: "product_categories",
                keyColumn: "id",
                keyValue: new Guid("aeddf5ab-4401-4ce7-ad9d-b870352f1232"));

            migrationBuilder.DeleteData(
                table: "product_categories",
                keyColumn: "id",
                keyValue: new Guid("b0dfab09-edf1-4b55-a055-1627fd2db059"));
        }
    }
}
