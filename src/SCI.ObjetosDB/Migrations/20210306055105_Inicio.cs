using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SCI.ObjetosDB.Migrations
{
    public partial class Inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categ",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<bool>(type: "BIT", nullable: false, defaultValueSql: "1"),
                    Marca = table.Column<bool>(type: "BIT", nullable: false, defaultValueSql: "1"),
                    Data_Inc = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    Data_Alt = table.Column<DateTime>(nullable: true),
                    Data_Hab = table.Column<DateTime>(nullable: true),
                    Nome = table.Column<string>(type: "VARCHAR(25)", nullable: false),
                    Grupo = table.Column<string>(type: "VARCHAR(25)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categ", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Livros",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<bool>(type: "BIT", nullable: false, defaultValueSql: "1"),
                    Marca = table.Column<bool>(type: "BIT", nullable: false, defaultValueSql: "1"),
                    Data_Inc = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    Data_Alt = table.Column<DateTime>(nullable: true),
                    Data_Hab = table.Column<DateTime>(nullable: true),
                    ISBN = table.Column<string>(type: "VARCHAR(13)", nullable: false),
                    Titulo = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    CategoriaId = table.Column<int>(nullable: false),
                    P_Venda = table.Column<decimal>(type: "DECIMAL(16,2)", nullable: true),
                    P_Custo = table.Column<decimal>(type: "DECIMAL(16,2)", nullable: true),
                    Base_Calc = table.Column<decimal>(type: "DECIMAL(16,2)", nullable: true),
                    Formatado = table.Column<string>(type: "VARCHAR(15)", nullable: true),
                    NPaginas = table.Column<short>(type: "SMALLINT", nullable: true),
                    Edicao = table.Column<short>(type: "SMALLINT", nullable: true),
                    Ano = table.Column<short>(type: "SMALLINT", nullable: true),
                    Peso = table.Column<decimal>(type: "DECIMAL(16,2)", nullable: true),
                    Loc = table.Column<string>(type: "VARCHAR(10)", nullable: true),
                    Resenha = table.Column<string>(type: "VARCHAR(1000)", nullable: true),
                    Capa = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    Promo = table.Column<bool>(type: "BIT", nullable: false, defaultValueSql: "0"),
                    Est_Min = table.Column<int>(type: "INT", nullable: true),
                    Est_Disp = table.Column<int>(type: "INT", nullable: true),
                    QtDoac = table.Column<int>(type: "INT", nullable: true),
                    QtCons = table.Column<int>(type: "INT", nullable: true),
                    QtVend = table.Column<int>(type: "INT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Livros_Categ_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categ",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Livros_CategoriaId",
                table: "Livros",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "titulo_Livros",
                table: "Livros",
                column: "Titulo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Livros");

            migrationBuilder.DropTable(
                name: "Categ");
        }
    }
}
