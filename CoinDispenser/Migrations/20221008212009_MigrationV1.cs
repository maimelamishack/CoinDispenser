using Microsoft.EntityFrameworkCore.Migrations;

namespace CoinDispenser.Migrations
{
    public partial class MigrationV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CoinDispense",
                columns: table => new
                {
                    CoinDenominationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    V1 = table.Column<int>(type: "int", nullable: false),
                    V2 = table.Column<int>(type: "int", nullable: false),
                    V3 = table.Column<int>(type: "int", nullable: false),
                    V4 = table.Column<int>(type: "int", nullable: false),
                    V5 = table.Column<int>(type: "int", nullable: false),
                    V6 = table.Column<int>(type: "int", nullable: false),
                    V7 = table.Column<int>(type: "int", nullable: false),
                    V8 = table.Column<int>(type: "int", nullable: false),
                    V9 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoinDispense", x => x.CoinDenominationId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CoinDispense");
        }
    }
}
