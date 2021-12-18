using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PaymentManager.Data.Migrations
{
    public partial class AddSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FirstName", "LastName", "Oib" },
                values: new object[,]
                {
                    { 1, "Marko", "Markovic", "98765678345" },
                    { 2, "Marjan", "Marjanovic", "6783947345" },
                    { 3, "Ivo", "Ivic", "98767898765" },
                    { 4, "Pero", "Peric", "234567887633" },
                    { 5, "Luka", "Lukovic", "67876432554" }
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Balance", "Iban", "RegisteredAt", "UserId" },
                values: new object[,]
                {
                    { 1, 100m, "1234567890", new DateTime(2020, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, 92100m, "298765432", new DateTime(2019, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 3, 0m, "76584932234", new DateTime(2021, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 4, 14500m, "1234567890", new DateTime(2010, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 5, 1324m, "89876542345", new DateTime(2017, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "Description", "ExecutedAt", "PaymentStatus", "ReceiverCardId" },
                values: new object[,]
                {
                    { 1, "Rodendanska cestitka", new DateTime(2021, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2 },
                    { 2, "Rodendanska cestitka za dogodine", new DateTime(2022, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 4, "Greskom odradena uplata", new DateTime(2021, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3 },
                    { 3, "Povrat sredstava", new DateTime(2020, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 4 }
                });

            migrationBuilder.InsertData(
                table: "CardPayments",
                columns: new[] { "Id", "CardId", "CreatedAt", "PaymentId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, 3, new DateTime(2021, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 3, 3, new DateTime(2021, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 4, 2, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 5, 1, new DateTime(2021, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CardPayments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CardPayments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CardPayments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CardPayments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CardPayments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
