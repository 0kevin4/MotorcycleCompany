using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MotorcycleCompany.Migrations
{
    public partial class ForeingKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdCity",
                table: "Motocicleta",
                newName: "IdGarage");

            migrationBuilder.CreateIndex(
                name: "IX_Motocicleta_IdAgency",
                table: "Motocicleta",
                column: "IdAgency");

            migrationBuilder.CreateIndex(
                name: "IX_Motocicleta_IdGarage",
                table: "Motocicleta",
                column: "IdGarage");

            migrationBuilder.CreateIndex(
                name: "IX_Garaje_IdCity",
                table: "Garaje",
                column: "IdCity");

            migrationBuilder.CreateIndex(
                name: "IX_Celular_IdAgency",
                table: "Celular",
                column: "IdAgency");

            migrationBuilder.AddForeignKey(
                name: "FK_Celular_Agencias_IdAgency",
                table: "Celular",
                column: "IdAgency",
                principalTable: "Agencias",
                principalColumn: "AgencyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Garaje_Ciudad_IdCity",
                table: "Garaje",
                column: "IdCity",
                principalTable: "Ciudad",
                principalColumn: "CityId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Motocicleta_Agencias_IdAgency",
                table: "Motocicleta",
                column: "IdAgency",
                principalTable: "Agencias",
                principalColumn: "AgencyId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Motocicleta_Garaje_IdGarage",
                table: "Motocicleta",
                column: "IdGarage",
                principalTable: "Garaje",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Celular_Agencias_IdAgency",
                table: "Celular");

            migrationBuilder.DropForeignKey(
                name: "FK_Garaje_Ciudad_IdCity",
                table: "Garaje");

            migrationBuilder.DropForeignKey(
                name: "FK_Motocicleta_Agencias_IdAgency",
                table: "Motocicleta");

            migrationBuilder.DropForeignKey(
                name: "FK_Motocicleta_Garaje_IdGarage",
                table: "Motocicleta");

            migrationBuilder.DropIndex(
                name: "IX_Motocicleta_IdAgency",
                table: "Motocicleta");

            migrationBuilder.DropIndex(
                name: "IX_Motocicleta_IdGarage",
                table: "Motocicleta");

            migrationBuilder.DropIndex(
                name: "IX_Garaje_IdCity",
                table: "Garaje");

            migrationBuilder.DropIndex(
                name: "IX_Celular_IdAgency",
                table: "Celular");

            migrationBuilder.RenameColumn(
                name: "IdGarage",
                table: "Motocicleta",
                newName: "IdCity");
        }
    }
}
