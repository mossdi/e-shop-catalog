﻿// <auto-generated />
using System;
using EShop.Catalog.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EShop.Catalog.DAL.Migrations
{
    [DbContext(typeof(DataAccessDbContext))]
    partial class DataAccessDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("EShop.Catalog.DAL.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("deleted_at");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.ToTable("categories", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("84ddb38f-8d9e-4e4b-9022-4085ced63475"),
                            CreatedAt = new DateTimeOffset(new DateTime(2022, 7, 16, 15, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0)),
                            Description = "Digital pianos for beginners and professionals.",
                            Name = "Pianos",
                            UpdatedAt = new DateTimeOffset(new DateTime(2022, 7, 16, 15, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7690), new TimeSpan(0, 3, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("4f71bda6-0fb9-4b45-aada-39e3bfd89548"),
                            CreatedAt = new DateTimeOffset(new DateTime(2022, 7, 16, 15, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7700), new TimeSpan(0, 3, 0, 0, 0)),
                            Description = "Acoustic and electric guitars for beginners and professionals.",
                            Name = "Guitars",
                            UpdatedAt = new DateTimeOffset(new DateTime(2022, 7, 16, 15, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 3, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("0aedc2cf-3338-44df-b346-37adc399acae"),
                            CreatedAt = new DateTimeOffset(new DateTime(2022, 7, 16, 15, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 3, 0, 0, 0)),
                            Description = "Acoustic and electric drums for beginners and professionals.",
                            Name = "Drums",
                            UpdatedAt = new DateTimeOffset(new DateTime(2022, 7, 16, 15, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7720), new TimeSpan(0, 3, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("b5718b16-3974-4949-a372-b8d93d2352f4"),
                            CreatedAt = new DateTimeOffset(new DateTime(2022, 7, 16, 15, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7730), new TimeSpan(0, 3, 0, 0, 0)),
                            Name = "Synthesizers",
                            UpdatedAt = new DateTimeOffset(new DateTime(2022, 7, 16, 15, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7730), new TimeSpan(0, 3, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("c547c364-5434-428f-803d-0fdd04f7d48e"),
                            CreatedAt = new DateTimeOffset(new DateTime(2022, 7, 16, 15, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7740), new TimeSpan(0, 3, 0, 0, 0)),
                            Name = "Accessories",
                            UpdatedAt = new DateTimeOffset(new DateTime(2022, 7, 16, 15, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7750), new TimeSpan(0, 3, 0, 0, 0))
                        });
                });

            modelBuilder.Entity("EShop.Catalog.DAL.Entities.Manufacturer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("deleted_at");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.ToTable("manufacturers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("b3964f15-ddcc-4582-bcca-43ec7c31e1c2"),
                            CreatedAt = new DateTimeOffset(new DateTime(2022, 7, 17, 13, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0)),
                            Name = "Kremona",
                            UpdatedAt = new DateTimeOffset(new DateTime(2022, 7, 17, 13, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("03618b30-ffa1-44cb-8bd7-94e1bab58ece"),
                            CreatedAt = new DateTimeOffset(new DateTime(2022, 7, 17, 13, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0)),
                            Name = "Remo",
                            UpdatedAt = new DateTimeOffset(new DateTime(2022, 7, 17, 13, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("13e22dc8-e1e1-489f-a618-9dae375bdace"),
                            CreatedAt = new DateTimeOffset(new DateTime(2022, 7, 17, 13, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0)),
                            Name = "Casio",
                            UpdatedAt = new DateTimeOffset(new DateTime(2022, 7, 17, 13, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("c828b3d4-c478-427f-82d6-bffc681626b9"),
                            CreatedAt = new DateTimeOffset(new DateTime(2022, 7, 17, 13, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0)),
                            Name = "Moog",
                            UpdatedAt = new DateTimeOffset(new DateTime(2022, 7, 17, 13, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("990025a6-5d43-44ef-aaae-76b158a0b61a"),
                            CreatedAt = new DateTimeOffset(new DateTime(2022, 7, 17, 13, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0)),
                            Name = "Ableton",
                            UpdatedAt = new DateTimeOffset(new DateTime(2022, 7, 17, 13, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0))
                        });
                });

            modelBuilder.Entity("EShop.Catalog.DAL.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("deleted_at");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<Guid>("ManufacturerId")
                        .HasColumnType("uuid")
                        .HasColumnName("manufacturer_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex("ManufacturerId");

                    b.ToTable("products", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("d11cfe18-d46e-4c85-a726-dd41aca37b99"),
                            CreatedAt = new DateTimeOffset(new DateTime(2022, 7, 17, 13, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0)),
                            Description = "Part of Kremona's Flamenco Series, the Rosa Morena's subtle flamenco design elements enable snap and spontaneity, while its Indian rosewood and European spruce construct conveys the stately depth of a concert classical. Other appointments include a bone nut and saddle, wood binding and rosette, and a gold machines with pearloid buttons.",
                            ManufacturerId = new Guid("b3964f15-ddcc-4582-bcca-43ec7c31e1c2"),
                            Name = "Kremona Rosa Morena",
                            UpdatedAt = new DateTimeOffset(new DateTime(2022, 7, 17, 13, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("45458fa1-c499-4c60-b373-072d7fa12fb0"),
                            CreatedAt = new DateTimeOffset(new DateTime(2022, 7, 17, 13, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0)),
                            ManufacturerId = new Guid("03618b30-ffa1-44cb-8bd7-94e1bab58ece"),
                            Name = "Remo Mondo Djembe 14\" Adinkra",
                            UpdatedAt = new DateTimeOffset(new DateTime(2022, 7, 17, 13, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("81675ffa-c0cd-4c60-bd12-8368f08dedf4"),
                            CreatedAt = new DateTimeOffset(new DateTime(2022, 7, 17, 13, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0)),
                            ManufacturerId = new Guid("13e22dc8-e1e1-489f-a618-9dae375bdace"),
                            Name = "Casio Celviano AP-470",
                            UpdatedAt = new DateTimeOffset(new DateTime(2022, 7, 17, 13, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("d2406749-4588-4c95-8849-e82c9a38768f"),
                            CreatedAt = new DateTimeOffset(new DateTime(2022, 7, 17, 13, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0)),
                            ManufacturerId = new Guid("c828b3d4-c478-427f-82d6-bffc681626b9"),
                            Name = "Moog Subsequent 37",
                            UpdatedAt = new DateTimeOffset(new DateTime(2022, 7, 17, 13, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("48e06835-984b-48ba-8dd7-97a99092c77d"),
                            CreatedAt = new DateTimeOffset(new DateTime(2022, 7, 17, 13, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0)),
                            ManufacturerId = new Guid("03618b30-ffa1-44cb-8bd7-94e1bab58ece"),
                            Name = "Remo Djembe Bag Deluxe 14\"",
                            UpdatedAt = new DateTimeOffset(new DateTime(2022, 7, 17, 13, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0))
                        });
                });

            modelBuilder.Entity("EShop.Catalog.DAL.Entities.ProductCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uuid")
                        .HasColumnName("category_id");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("deleted_at");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid")
                        .HasColumnName("product_id");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ProductId");

                    b.ToTable("product_categories", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("1b2f3b8e-cddd-443a-a5fa-1833241d9168"),
                            CategoryId = new Guid("84ddb38f-8d9e-4e4b-9022-4085ced63475"),
                            CreatedAt = new DateTimeOffset(new DateTime(2022, 7, 17, 15, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0)),
                            ProductId = new Guid("81675ffa-c0cd-4c60-bd12-8368f08dedf4"),
                            UpdatedAt = new DateTimeOffset(new DateTime(2022, 7, 17, 15, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("aeddf5ab-4401-4ce7-ad9d-b870352f1232"),
                            CategoryId = new Guid("4f71bda6-0fb9-4b45-aada-39e3bfd89548"),
                            CreatedAt = new DateTimeOffset(new DateTime(2022, 7, 17, 15, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0)),
                            ProductId = new Guid("d11cfe18-d46e-4c85-a726-dd41aca37b99"),
                            UpdatedAt = new DateTimeOffset(new DateTime(2022, 7, 17, 15, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("6526eb2e-3162-4100-b391-c03c638515b9"),
                            CategoryId = new Guid("0aedc2cf-3338-44df-b346-37adc399acae"),
                            CreatedAt = new DateTimeOffset(new DateTime(2022, 7, 17, 15, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0)),
                            ProductId = new Guid("45458fa1-c499-4c60-b373-072d7fa12fb0"),
                            UpdatedAt = new DateTimeOffset(new DateTime(2022, 7, 17, 15, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("b0dfab09-edf1-4b55-a055-1627fd2db059"),
                            CategoryId = new Guid("b5718b16-3974-4949-a372-b8d93d2352f4"),
                            CreatedAt = new DateTimeOffset(new DateTime(2022, 7, 17, 15, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0)),
                            ProductId = new Guid("d2406749-4588-4c95-8849-e82c9a38768f"),
                            UpdatedAt = new DateTimeOffset(new DateTime(2022, 7, 17, 15, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("abfe8f1f-093a-4851-9cf3-c832ea8ed923"),
                            CategoryId = new Guid("c547c364-5434-428f-803d-0fdd04f7d48e"),
                            CreatedAt = new DateTimeOffset(new DateTime(2022, 7, 17, 15, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0)),
                            ProductId = new Guid("48e06835-984b-48ba-8dd7-97a99092c77d"),
                            UpdatedAt = new DateTimeOffset(new DateTime(2022, 7, 17, 15, 3, 18, 771, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 3, 0, 0, 0))
                        });
                });

            modelBuilder.Entity("EShop.Catalog.DAL.Entities.Product", b =>
                {
                    b.HasOne("EShop.Catalog.DAL.Entities.Manufacturer", "Manufacturer")
                        .WithMany()
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manufacturer");
                });

            modelBuilder.Entity("EShop.Catalog.DAL.Entities.ProductCategory", b =>
                {
                    b.HasOne("EShop.Catalog.DAL.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EShop.Catalog.DAL.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Product");
                });
#pragma warning restore 612, 618
        }
    }
}
