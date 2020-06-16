using Microsoft.EntityFrameworkCore.Migrations;

namespace InvestmentTracker.Migrations
{
    public partial class SourceOfIncome : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SourceOfIncome",
                table: "Incomes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SourceOfIncome",
                table: "Incomes");
        }
    }
}
