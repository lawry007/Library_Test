using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library_Test.Migrations
{
    public partial class DB_ContextLibraryContextSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Books",
                schema: "dbo",
                columns: table => new
                {
                    BookId = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(maxLength: 50, nullable: false),
                    Isbn = table.Column<string>(maxLength: 20, nullable: false),
                    PublishYear = table.Column<string>(maxLength: 10, nullable: false),
                    CoverPrice = table.Column<decimal>(nullable: false),
                    AvailabilityStatus = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "dbo",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    FullName = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 50, nullable: false),
                    NationalIdentificationNumber = table.Column<string>(maxLength: 50, nullable: false),
                    DateOfCheckout = table.Column<DateTime>(maxLength: 50, nullable: false),
                    ExpectedDateOfReturn = table.Column<DateTime>(maxLength: 50, nullable: false),
                    BookId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "dbo");
        }
    }
}
