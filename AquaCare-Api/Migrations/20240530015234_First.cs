using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AquaCare_Api.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cidades",
                columns: table => new
                {
                    CodigoCidade = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nome = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    Estado = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidades", x => x.CodigoCidade);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    CodigoUsuario = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nome = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    Senha = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.CodigoUsuario);
                });

            migrationBuilder.CreateTable(
                name: "Locais",
                columns: table => new
                {
                    CodigoLocal = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    CodigoCidade = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Nome = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    Descricao = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Latitude = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    Longitude = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locais", x => x.CodigoLocal);
                    table.ForeignKey(
                        name: "FK_Locais_Cidades_CodigoCidade",
                        column: x => x.CodigoCidade,
                        principalTable: "Cidades",
                        principalColumn: "CodigoCidade",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Indicadores",
                columns: table => new
                {
                    CodigoIndicador = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    CodigoLocal = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    DataHoraMedicao = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    NivelColiformes = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    NivelPH = table.Column<decimal>(type: "DECIMAL(18, 2)", nullable: false),
                    NivelOxigenioDissolvido = table.Column<decimal>(type: "DECIMAL(18, 2)", nullable: false),
                    NivelTurbidez = table.Column<decimal>(type: "DECIMAL(18, 2)", nullable: false),
                    NivelTemperatura = table.Column<decimal>(type: "DECIMAL(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Indicadores", x => x.CodigoIndicador);
                    table.ForeignKey(
                        name: "FK_Indicadores_Locais_CodigoLocal",
                        column: x => x.CodigoLocal,
                        principalTable: "Locais",
                        principalColumn: "CodigoLocal",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Indicadores_CodigoLocal",
                table: "Indicadores",
                column: "CodigoLocal");

            migrationBuilder.CreateIndex(
                name: "IX_Locais_CodigoCidade",
                table: "Locais",
                column: "CodigoCidade");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Indicadores");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Locais");

            migrationBuilder.DropTable(
                name: "Cidades");
        }
    }
}
