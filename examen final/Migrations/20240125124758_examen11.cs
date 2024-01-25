using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test_Examen.Migrations
{
    public partial class examen11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MateriiProfesori_Materii_MaterieId",
                table: "MateriiProfesori");

            migrationBuilder.DropForeignKey(
                name: "FK_MateriiProfesori_Profesori_ProfesorId",
                table: "MateriiProfesori");

            migrationBuilder.DropIndex(
                name: "IX_MateriiProfesori_ProfesorId",
                table: "MateriiProfesori");

            migrationBuilder.AddColumn<int>(
                name: "Credite",
                table: "Materii",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Credite",
                table: "Materii");

            migrationBuilder.CreateIndex(
                name: "IX_MateriiProfesori_ProfesorId",
                table: "MateriiProfesori",
                column: "ProfesorId");

            migrationBuilder.AddForeignKey(
                name: "FK_MateriiProfesori_Materii_MaterieId",
                table: "MateriiProfesori",
                column: "MaterieId",
                principalTable: "Materii",
                principalColumn: "MaterieId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MateriiProfesori_Profesori_ProfesorId",
                table: "MateriiProfesori",
                column: "ProfesorId",
                principalTable: "Profesori",
                principalColumn: "ProfesorId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
