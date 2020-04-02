using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library_Test.Migrations
{
    public partial class DB_ContextLibraryContextSeed_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfCheckout",
                schema: "dbo",
                table: "Users",
                type: "date",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<decimal>(
                name: "CoverPrice",
                schema: "dbo",
                table: "Books",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Books",
                columns: new[] { "BookId", "AvailabilityStatus", "CoverPrice", "Isbn", "PublishYear", "Title" },
                values: new object[] { new Guid("73a2f969-eda1-44d6-8512-aa49fdc3e633"), "check-in", 1800.00m, "1234-PPL-HS", "2020", "Being a great Staff of Health Station" });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Books",
                columns: new[] { "BookId", "AvailabilityStatus", "CoverPrice", "Isbn", "PublishYear", "Title" },
                values: new object[] { new Guid("54e6c636-55f6-4176-97ca-60cb32e8ed8e"), "check-Out", 1800.00m, "13454-PPL-HS", "2020", "INterview 101" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Books",
                keyColumn: "BookId",
                keyValue: new Guid("54e6c636-55f6-4176-97ca-60cb32e8ed8e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Books",
                keyColumn: "BookId",
                keyValue: new Guid("73a2f969-eda1-44d6-8512-aa49fdc3e633"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfCheckout",
                schema: "dbo",
                table: "Users",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldMaxLength: 50,
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AlterColumn<decimal>(
                name: "CoverPrice",
                schema: "dbo",
                table: "Books",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money");
        }
    }
}
