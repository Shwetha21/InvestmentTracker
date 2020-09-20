using Microsoft.EntityFrameworkCore.Migrations;

namespace InvestmentTracker.Migrations
{
    public partial class AddingNewTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Peoples",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IncomeId = table.Column<int>(nullable: false),
                    ExpenditureId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peoples", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Peoples_Expenditures_ExpenditureId",
                        column: x => x.ExpenditureId,
                        principalTable: "Expenditures",
                        principalColumn: "ExpenditureId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Peoples_Incomes_IncomeId",
                        column: x => x.IncomeId,
                        principalTable: "Incomes",
                        principalColumn: "IncomeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Peoples_ExpenditureId",
                table: "Peoples",
                column: "ExpenditureId");

            migrationBuilder.CreateIndex(
                name: "IX_Peoples_IncomeId",
                table: "Peoples",
                column: "IncomeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Peoples");
        }
    }
}
