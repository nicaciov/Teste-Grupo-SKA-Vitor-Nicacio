using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Teste_Grupo_SKA_Vitor_Nicacio.Migrations
{
    /// <inheritdoc />
    public partial class SKAVitor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tabelaBlocoNotas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOTA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    STATUS = table.Column<int>(type: "int", nullable: false),
                    DATA_INCLUSAO = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tabelaBlocoNotas", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tabelaBlocoNotas");
        }
    }
}
