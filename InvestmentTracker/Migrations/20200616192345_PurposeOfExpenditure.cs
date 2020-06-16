using Microsoft.EntityFrameworkCore.Migrations;

namespace InvestmentTracker.Migrations
{
    public partial class PurposeOfExpenditure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PurposeOfExpenditure",
                table: "Expenditures",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PurposeOfExpenditure",
                table: "Expenditures");
        }
    }
}
