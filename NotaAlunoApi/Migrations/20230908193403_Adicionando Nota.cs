using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NotaAlunoApi.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoNota : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NotaId",
                table: "Alunos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Notas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Portugues = table.Column<int>(type: "int", nullable: false),
                    Matematica = table.Column<int>(type: "int", nullable: false),
                    Historia = table.Column<int>(type: "int", nullable: false),
                    Geografia = table.Column<int>(type: "int", nullable: false),
                    Ingles = table.Column<int>(type: "int", nullable: false),
                    Ciencias = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notas", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_NotaId",
                table: "Alunos",
                column: "NotaId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Alunos_Notas_NotaId",
                table: "Alunos",
                column: "NotaId",
                principalTable: "Notas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_Notas_NotaId",
                table: "Alunos");

            migrationBuilder.DropTable(
                name: "Notas");

            migrationBuilder.DropIndex(
                name: "IX_Alunos_NotaId",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "NotaId",
                table: "Alunos");
        }
    }
}
