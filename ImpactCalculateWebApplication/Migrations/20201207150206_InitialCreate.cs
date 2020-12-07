using Microsoft.EntityFrameworkCore.Migrations;

namespace ImpactCalculateWebApplication.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "A_AV_VW",
                columns: table => new
                {
                    Key = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    A = table.Column<double>(type: "REAL", nullable: false),
                    V_Alpha = table.Column<double>(type: "REAL", nullable: false),
                    V_Waste = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_A_AV_VW", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "Inputs",
                columns: table => new
                {
                    Key = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Air_Spend = table.Column<double>(type: "REAL", nullable: false),
                    Air_Pressure = table.Column<double>(type: "REAL", nullable: false),
                    Air_Temperature = table.Column<double>(type: "REAL", nullable: false),
                    Smoke_Temperature = table.Column<double>(type: "REAL", nullable: false),
                    Viscosity = table.Column<double>(type: "REAL", nullable: false),
                    Melt_Temperature = table.Column<double>(type: "REAL", nullable: false),
                    CO_Percentage = table.Column<double>(type: "REAL", nullable: false),
                    CO2_Percentage = table.Column<double>(type: "REAL", nullable: false),
                    N2_Percentage = table.Column<double>(type: "REAL", nullable: false),
                    O2_Percentage = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inputs", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "Sources",
                columns: table => new
                {
                    SourceDataId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Air_Spend = table.Column<double>(type: "REAL", nullable: true),
                    Air_Pressure = table.Column<double>(type: "REAL", nullable: true),
                    Air_Temperature = table.Column<double>(type: "REAL", nullable: true),
                    Smoke_Temperature = table.Column<double>(type: "REAL", nullable: true),
                    Viscosity = table.Column<double>(type: "REAL", nullable: true),
                    Melt_Temperature = table.Column<double>(type: "REAL", nullable: true),
                    CO_Percentage = table.Column<double>(type: "REAL", nullable: true),
                    CO2_Percentage = table.Column<double>(type: "REAL", nullable: true),
                    O2_Percentage = table.Column<double>(type: "REAL", nullable: true),
                    N2_Percentage = table.Column<double>(type: "REAL", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sources", x => x.SourceDataId);
                });

            migrationBuilder.CreateTable(
                name: "Result",
                columns: table => new
                {
                    Key = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GasKey = table.Column<int>(type: "INTEGER", nullable: true),
                    DeviceKey = table.Column<int>(type: "INTEGER", nullable: true),
                    Waste_Difference = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Result", x => x.Key);
                    table.ForeignKey(
                        name: "FK_Result_A_AV_VW_DeviceKey",
                        column: x => x.DeviceKey,
                        principalTable: "A_AV_VW",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Result_A_AV_VW_GasKey",
                        column: x => x.GasKey,
                        principalTable: "A_AV_VW",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Result_DeviceKey",
                table: "Result",
                column: "DeviceKey");

            migrationBuilder.CreateIndex(
                name: "IX_Result_GasKey",
                table: "Result",
                column: "GasKey");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inputs");

            migrationBuilder.DropTable(
                name: "Result");

            migrationBuilder.DropTable(
                name: "Sources");

            migrationBuilder.DropTable(
                name: "A_AV_VW");
        }
    }
}
