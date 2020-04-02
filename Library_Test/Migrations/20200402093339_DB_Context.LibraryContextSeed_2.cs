using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library_Test.Migrations
{
    public partial class DB_ContextLibraryContextSeed_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Books",
                columns: new[] { "BookId", "AvailabilityStatus", "CoverPrice", "Isbn", "PublishYear", "Title" },
                values: new object[,]
                {
                    { new Guid("005873f6-f02f-4ab2-951f-6209a5639a52"), "check-in", 1800.00m, "1234-PPL-HS", "2020", "Being a great Staff of Health Station" },
                    { new Guid("0375286f-f10b-4119-bd5c-77eb880aae78"), "check-Out", 1800.00m, "13454-PPL-HS", "2020", "INterview 101" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Users",
                columns: new[] { "UserId", "BookId", "DateOfCheckout", "Email", "ExpectedDateOfReturn", "FullName", "NationalIdentificationNumber", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("6a441cbc-ab57-4e57-9382-707ce8ec86d6"), new Guid("54e6c636-55f6-4176-97ca-60cb32e8ed8e"), new DateTime(2020, 4, 2, 10, 33, 38, 571, DateTimeKind.Local).AddTicks(2622), "lawrenceolaoluwa1@gmail.com", new DateTime(2020, 4, 16, 10, 33, 38, 583, DateTimeKind.Local).AddTicks(5649), "Lawrence Olaoluwa", "12345678", "08161813410" },
                    { new Guid("2773e6dc-b39d-4168-afce-7fd066ef8841"), new Guid("54e6c636-55f6-4176-97ca-60cb32e8ed8e"), new DateTime(2020, 4, 2, 10, 33, 38, 584, DateTimeKind.Local).AddTicks(435), "lawrenceolaolaoluwa@outlook.com", new DateTime(2020, 4, 16, 10, 33, 38, 584, DateTimeKind.Local).AddTicks(450), "Joseph Olaoluwa", "123", "12345678980" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Books",
                keyColumn: "BookId",
                keyValue: new Guid("005873f6-f02f-4ab2-951f-6209a5639a52"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Books",
                keyColumn: "BookId",
                keyValue: new Guid("0375286f-f10b-4119-bd5c-77eb880aae78"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("2773e6dc-b39d-4168-afce-7fd066ef8841"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("6a441cbc-ab57-4e57-9382-707ce8ec86d6"));

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
    }
}
