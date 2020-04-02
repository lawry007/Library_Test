﻿// <auto-generated />
using System;
using Library_Test.DB_Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Library_Test.Migrations
{
    [DbContext(typeof(LibraryContext))]
    [Migration("20200402151102_DB_Context.LibraryContextSeed_3")]
    partial class DB_ContextLibraryContextSeed_3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Library_Test.Entities.Books", b =>
                {
                    b.Property<Guid>("BookId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AvailabilityStatus")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<decimal>("CoverPrice")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 38, scale: 17)))
                        .HasColumnType("money");

                    b.Property<string>("Isbn")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("PublishYear")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("BookId");

                    b.ToTable("Books","dbo");

                    b.HasData(
                        new
                        {
                            BookId = new Guid("afe05eb1-2bd1-4f52-918d-93a704e0c788"),
                            AvailabilityStatus = "check-in",
                            CoverPrice = 1800m,
                            Isbn = "1234-PPL-HS",
                            PublishYear = "2020",
                            Title = "Being a great Staff of Health Station"
                        },
                        new
                        {
                            BookId = new Guid("6f4302a6-951f-4f1f-b875-e6af9ff78180"),
                            AvailabilityStatus = "check-Out",
                            CoverPrice = 1800m,
                            Isbn = "13454-PPL-HS",
                            PublishYear = "2020",
                            Title = "INterview 101"
                        });
                });

            modelBuilder.Entity("Library_Test.Entities.Users", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("BookId");

                    b.Property<DateTime>("DateOfCheckout")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("date")
                        .HasDefaultValueSql("(getdate())")
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("ExpectedDateOfReturn")
                        .HasMaxLength(50);

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool>("HasReturnedBook");

                    b.Property<string>("NationalIdentificationNumber")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("UserId");

                    b.ToTable("Users","dbo");

                    b.HasData(
                        new
                        {
                            UserId = new Guid("de1a8215-098d-4d3e-bfb3-296f506732a1"),
                            BookId = new Guid("54e6c636-55f6-4176-97ca-60cb32e8ed8e"),
                            DateOfCheckout = new DateTime(2020, 4, 2, 16, 11, 2, 126, DateTimeKind.Local).AddTicks(8707),
                            Email = "lawrenceolaoluwa1@gmail.com",
                            ExpectedDateOfReturn = new DateTime(2020, 4, 16, 16, 11, 2, 128, DateTimeKind.Local).AddTicks(4170),
                            FullName = "Lawrence Olaoluwa",
                            HasReturnedBook = false,
                            NationalIdentificationNumber = "12345678",
                            PhoneNumber = "08161813410"
                        },
                        new
                        {
                            UserId = new Guid("151be746-4e35-401c-9b17-dcdb87a63638"),
                            BookId = new Guid("54e6c636-55f6-4176-97ca-60cb32e8ed8e"),
                            DateOfCheckout = new DateTime(2020, 4, 2, 16, 11, 2, 128, DateTimeKind.Local).AddTicks(9958),
                            Email = "lawrenceolaolaoluwa@outlook.com",
                            ExpectedDateOfReturn = new DateTime(2020, 4, 16, 16, 11, 2, 128, DateTimeKind.Local).AddTicks(9972),
                            FullName = "Joseph Olaoluwa",
                            HasReturnedBook = false,
                            NationalIdentificationNumber = "123",
                            PhoneNumber = "12345678980"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
