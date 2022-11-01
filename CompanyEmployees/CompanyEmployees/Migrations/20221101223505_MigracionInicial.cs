using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyEmployees.Migrations
{
    public partial class MigracionInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agencias",
                columns: table => new
                {
                    AgencyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Direction = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    Poblation = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agencias", x => x.AgencyId);
                });

            migrationBuilder.InsertData(
                table: "Agencias",
                columns: new[] { "AgencyId", "Direction", "Name", "Poblation" },
                values: new object[] { 1, "Calle del recuerdo", "Kevin", "Santa Barbara" });

            migrationBuilder.InsertData(
                table: "Agencias",
                columns: new[] { "AgencyId", "Direction", "Name", "Poblation" },
                values: new object[] { 2, "Calle de la soledad", "Jose", "Santa Ana" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agencias");
        }
    }
}
