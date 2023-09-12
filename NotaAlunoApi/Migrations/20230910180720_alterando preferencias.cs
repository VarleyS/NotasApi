using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NotaAlunoApi.Migrations
{
    /// <inheritdoc />
    public partial class alterandopreferencias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_Notas_NotaId",
                table: "Alunos");

            migrationBuilder.DropIndex(
                name: "IX_Alunos_NotaId",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "NotaId",
                table: "Alunos");

            migrationBuilder.AddColumn<int>(
                name: "AlunoId",
                table: "Notas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Notas_AlunoId",
                table: "Notas",
                column: "AlunoId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Notas_Alunos_AlunoId",
                table: "Notas",
                column: "AlunoId",
                principalTable: "Alunos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notas_Alunos_AlunoId",
                table: "Notas");

            migrationBuilder.DropIndex(
                name: "IX_Notas_AlunoId",
                table: "Notas");

            migrationBuilder.DropColumn(
                name: "AlunoId",
                table: "Notas");

            migrationBuilder.AddColumn<int>(
                name: "NotaId",
                table: "Alunos",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}
