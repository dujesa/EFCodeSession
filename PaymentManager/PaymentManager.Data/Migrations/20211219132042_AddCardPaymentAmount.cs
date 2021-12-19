using Microsoft.EntityFrameworkCore.Migrations;

namespace PaymentManager.Data.Migrations
{
    public partial class AddCardPaymentAmount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Amount",
                table: "CardPayments",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "CardPayments");
        }
    }
}
