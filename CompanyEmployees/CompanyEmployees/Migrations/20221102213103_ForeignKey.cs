using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyEmployees.Migrations
{
    public partial class ForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Renta_IdAgency",
                table: "Renta",
                column: "IdAgency");

            migrationBuilder.CreateIndex(
                name: "IX_Renta_IdMotorcycle",
                table: "Renta",
                column: "IdMotorcycle");

            migrationBuilder.AddForeignKey(
                name: "FK_Renta_Agencias_IdAgency",
                table: "Renta",
                column: "IdAgency",
                principalTable: "Agencias",
                principalColumn: "AgencyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Renta_Motocicleta_IdMotorcycle",
                table: "Renta",
                column: "IdMotorcycle",
                principalTable: "Motocicleta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Renta_Agencias_IdAgency",
                table: "Renta");

            migrationBuilder.DropForeignKey(
                name: "FK_Renta_Motocicleta_IdMotorcycle",
                table: "Renta");

            migrationBuilder.DropIndex(
                name: "IX_Renta_IdAgency",
                table: "Renta");

            migrationBuilder.DropIndex(
                name: "IX_Renta_IdMotorcycle",
                table: "Renta");
        }
    }
}
