using Microsoft.EntityFrameworkCore.Migrations;

namespace InvestmentTracker.Migrations
{
    public partial class ChangingSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Peoples_Expenditures_ExpenditureId",
                table: "Peoples");

            migrationBuilder.DropForeignKey(
                name: "FK_Peoples_Incomes_IncomeId",
                table: "Peoples");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Peoples",
                table: "Peoples");

            migrationBuilder.DropIndex(
                name: "IX_Peoples_ExpenditureId",
                table: "Peoples");

            migrationBuilder.DropIndex(
                name: "IX_Peoples_IncomeId",
                table: "Peoples");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Peoples");

            migrationBuilder.DropColumn(
                name: "ExpenditureId",
                table: "Peoples");

            migrationBuilder.DropColumn(
                name: "IncomeId",
                table: "Peoples");

            migrationBuilder.AddColumn<int>(
                name: "PeopleId",
                table: "Peoples",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "PeopleId",
                table: "Incomes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PeopleId",
                table: "Expenditures",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Peoples",
                table: "Peoples",
                column: "PeopleId");

            migrationBuilder.CreateIndex(
                name: "IX_Incomes_PeopleId",
                table: "Incomes",
                column: "PeopleId");

            migrationBuilder.CreateIndex(
                name: "IX_Expenditures_PeopleId",
                table: "Expenditures",
                column: "PeopleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Expenditures_Peoples_PeopleId",
                table: "Expenditures",
                column: "PeopleId",
                principalTable: "Peoples",
                principalColumn: "PeopleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Incomes_Peoples_PeopleId",
                table: "Incomes",
                column: "PeopleId",
                principalTable: "Peoples",
                principalColumn: "PeopleId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expenditures_Peoples_PeopleId",
                table: "Expenditures");

            migrationBuilder.DropForeignKey(
                name: "FK_Incomes_Peoples_PeopleId",
                table: "Incomes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Peoples",
                table: "Peoples");

            migrationBuilder.DropIndex(
                name: "IX_Incomes_PeopleId",
                table: "Incomes");

            migrationBuilder.DropIndex(
                name: "IX_Expenditures_PeopleId",
                table: "Expenditures");

            migrationBuilder.DropColumn(
                name: "PeopleId",
                table: "Peoples");

            migrationBuilder.DropColumn(
                name: "PeopleId",
                table: "Incomes");

            migrationBuilder.DropColumn(
                name: "PeopleId",
                table: "Expenditures");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Peoples",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ExpenditureId",
                table: "Peoples",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IncomeId",
                table: "Peoples",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Peoples",
                table: "Peoples",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_Peoples_ExpenditureId",
                table: "Peoples",
                column: "ExpenditureId");

            migrationBuilder.CreateIndex(
                name: "IX_Peoples_IncomeId",
                table: "Peoples",
                column: "IncomeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Peoples_Expenditures_ExpenditureId",
                table: "Peoples",
                column: "ExpenditureId",
                principalTable: "Expenditures",
                principalColumn: "ExpenditureId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Peoples_Incomes_IncomeId",
                table: "Peoples",
                column: "IncomeId",
                principalTable: "Incomes",
                principalColumn: "IncomeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
