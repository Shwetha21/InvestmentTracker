using Microsoft.EntityFrameworkCore.Migrations;

namespace InvestmentTracker.Migrations
{
    public partial class changefloat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "ExpenseAmount",
                table: "Expenditures",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ExpenseAmount",
                table: "Expenditures",
                type: "int",
                nullable: false,
                oldClrType: typeof(float));
        }
    }
}
