using Microsoft.EntityFrameworkCore.Migrations;

namespace PaymentManager.Data.Migrations
{
    public partial class AddPaymentAmountSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CardPayments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Amount",
                value: 99.99m);

            migrationBuilder.UpdateData(
                table: "CardPayments",
                keyColumn: "Id",
                keyValue: 2,
                column: "Amount",
                value: 100m);

            migrationBuilder.UpdateData(
                table: "CardPayments",
                keyColumn: "Id",
                keyValue: 3,
                column: "Amount",
                value: 637m);

            migrationBuilder.UpdateData(
                table: "CardPayments",
                keyColumn: "Id",
                keyValue: 4,
                column: "Amount",
                value: 33.7m);

            migrationBuilder.UpdateData(
                table: "CardPayments",
                keyColumn: "Id",
                keyValue: 5,
                column: "Amount",
                value: 7000m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CardPayments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "CardPayments",
                keyColumn: "Id",
                keyValue: 2,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "CardPayments",
                keyColumn: "Id",
                keyValue: 3,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "CardPayments",
                keyColumn: "Id",
                keyValue: 4,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "CardPayments",
                keyColumn: "Id",
                keyValue: 5,
                column: "Amount",
                value: 0m);
        }
    }
}
