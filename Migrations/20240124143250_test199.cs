using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test_Examen.Migrations
{
    public partial class test199 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Autori",
                columns: table => new
                {
                    AutorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autori", x => x.AutorId);
                });

            migrationBuilder.CreateTable(
                name: "Edituri",
                columns: table => new
                {
                    EdituraId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Edituri", x => x.EdituraId);
                });

            migrationBuilder.CreateTable(
                name: "Carti",
                columns: table => new
                {
                    CarteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titlu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AutorId = table.Column<int>(type: "int", nullable: false),
                    EdituraId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carti", x => x.CarteId);
                    table.ForeignKey(
                        name: "FK_Carti_Autori_AutorId",
                        column: x => x.AutorId,
                        principalTable: "Autori",
                        principalColumn: "AutorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Carti_Edituri_EdituraId",
                        column: x => x.EdituraId,
                        principalTable: "Edituri",
                        principalColumn: "EdituraId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carti_AutorId",
                table: "Carti",
                column: "AutorId");

            migrationBuilder.CreateIndex(
                name: "IX_Carti_EdituraId",
                table: "Carti",
                column: "EdituraId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carti");

            migrationBuilder.DropTable(
                name: "Autori");

            migrationBuilder.DropTable(
                name: "Edituri");
        }
    }
}
