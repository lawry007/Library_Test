using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library_Test.Migrations
{
    public partial class DB_ContextLibraryContextSeed_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "HasReturnedBook",
                schema: "dbo",
                table: "Users",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Books",
                columns: new[] { "BookId", "AvailabilityStatus", "CoverPrice", "Isbn", "PublishYear", "Title" },
                values: new object[,]
                {
                    { new Guid("afe05eb1-2bd1-4f52-918d-93a704e0c788"), "check-in", 1800m, "1234-PPL-HS", "2020", "Being a great Staff of Health Station" },
                    { new Guid("6f4302a6-951f-4f1f-b875-e6af9ff78180"), "check-Out", 1800m, "13454-PPL-HS", "2020", "INterview 101" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Users",
                columns: new[] { "UserId", "BookId", "DateOfCheckout", "Email", "ExpectedDateOfReturn", "FullName", "HasReturnedBook", "NationalIdentificationNumber", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("de1a8215-098d-4d3e-bfb3-296f506732a1"), new Guid("54e6c636-55f6-4176-97ca-60cb32e8ed8e"), new DateTime(2020, 4, 2, 16, 11, 2, 126, DateTimeKind.Local).AddTicks(8707), "lawrenceolaoluwa1@gmail.com", new DateTime(2020, 4, 16, 16, 11, 2, 128, DateTimeKind.Local).AddTicks(4170), "Lawrence Olaoluwa", false, "12345678", "08161813410" },
                    { new Guid("151be746-4e35-401c-9b17-dcdb87a63638"), new Guid("54e6c636-55f6-4176-97ca-60cb32e8ed8e"), new DateTime(2020, 4, 2, 16, 11, 2, 128, DateTimeKind.Local).AddTicks(9958), "lawrenceolaolaoluwa@outlook.com", new DateTime(2020, 4, 16, 16, 11, 2, 128, DateTimeKind.Local).AddTicks(9972), "Joseph Olaoluwa", false, "123", "12345678980" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Books",
                keyColumn: "BookId",
                keyValue: new Guid("6f4302a6-951f-4f1f-b875-e6af9ff78180"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Books",
                keyColumn: "BookId",
                keyValue: new Guid("afe05eb1-2bd1-4f52-918d-93a704e0c788"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("151be746-4e35-401c-9b17-dcdb87a63638"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("de1a8215-098d-4d3e-bfb3-296f506732a1"));

            migrationBuilder.DropColumn(
                name: "HasReturnedBook",
                schema: "dbo",
                table: "Users");

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
    }
}
