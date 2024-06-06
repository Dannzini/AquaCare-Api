using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AquaCare_Api.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Indicadores_Locais_CodigoLocal",
                table: "Indicadores");

            migrationBuilder.DropForeignKey(
                name: "FK_Locais_Cidades_CodigoCidade",
                table: "Locais");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Locais",
                table: "Locais");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Indicadores",
                table: "Indicadores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cidades",
                table: "Cidades");

            migrationBuilder.RenameTable(
                name: "Usuarios",
                newName: "AQUACARE_USUARIO");

            migrationBuilder.RenameTable(
                name: "Locais",
                newName: "AQUACARE_LOCAL");

            migrationBuilder.RenameTable(
                name: "Indicadores",
                newName: "AQUACARE_INDICADOR");

            migrationBuilder.RenameTable(
                name: "Cidades",
                newName: "AQUACARE_CIDADE");

            migrationBuilder.RenameIndex(
                name: "IX_Locais_CodigoCidade",
                table: "AQUACARE_LOCAL",
                newName: "IX_AQUACARE_LOCAL_CodigoCidade");

            migrationBuilder.RenameIndex(
                name: "IX_Indicadores_CodigoLocal",
                table: "AQUACARE_INDICADOR",
                newName: "IX_AQUACARE_INDICADOR_CodigoLocal");

            migrationBuilder.AlterColumn<decimal>(
                name: "NivelTurbidez",
                table: "AQUACARE_INDICADOR",
                type: "DECIMAL(18, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "NivelTemperatura",
                table: "AQUACARE_INDICADOR",
                type: "DECIMAL(18, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "NivelPH",
                table: "AQUACARE_INDICADOR",
                type: "DECIMAL(18, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "NivelOxigenioDissolvido",
                table: "AQUACARE_INDICADOR",
                type: "DECIMAL(18, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(18,2)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AQUACARE_USUARIO",
                table: "AQUACARE_USUARIO",
                column: "CodigoUsuario");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AQUACARE_LOCAL",
                table: "AQUACARE_LOCAL",
                column: "CodigoLocal");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AQUACARE_INDICADOR",
                table: "AQUACARE_INDICADOR",
                column: "CodigoIndicador");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AQUACARE_CIDADE",
                table: "AQUACARE_CIDADE",
                column: "CodigoCidade");

            migrationBuilder.AddForeignKey(
                name: "FK_AQUACARE_INDICADOR_AQUACARE_LOCAL_CodigoLocal",
                table: "AQUACARE_INDICADOR",
                column: "CodigoLocal",
                principalTable: "AQUACARE_LOCAL",
                principalColumn: "CodigoLocal",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AQUACARE_LOCAL_AQUACARE_CIDADE_CodigoCidade",
                table: "AQUACARE_LOCAL",
                column: "CodigoCidade",
                principalTable: "AQUACARE_CIDADE",
                principalColumn: "CodigoCidade",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AQUACARE_INDICADOR_AQUACARE_LOCAL_CodigoLocal",
                table: "AQUACARE_INDICADOR");

            migrationBuilder.DropForeignKey(
                name: "FK_AQUACARE_LOCAL_AQUACARE_CIDADE_CodigoCidade",
                table: "AQUACARE_LOCAL");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AQUACARE_USUARIO",
                table: "AQUACARE_USUARIO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AQUACARE_LOCAL",
                table: "AQUACARE_LOCAL");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AQUACARE_INDICADOR",
                table: "AQUACARE_INDICADOR");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AQUACARE_CIDADE",
                table: "AQUACARE_CIDADE");

            migrationBuilder.RenameTable(
                name: "AQUACARE_USUARIO",
                newName: "Usuarios");

            migrationBuilder.RenameTable(
                name: "AQUACARE_LOCAL",
                newName: "Locais");

            migrationBuilder.RenameTable(
                name: "AQUACARE_INDICADOR",
                newName: "Indicadores");

            migrationBuilder.RenameTable(
                name: "AQUACARE_CIDADE",
                newName: "Cidades");

            migrationBuilder.RenameIndex(
                name: "IX_AQUACARE_LOCAL_CodigoCidade",
                table: "Locais",
                newName: "IX_Locais_CodigoCidade");

            migrationBuilder.RenameIndex(
                name: "IX_AQUACARE_INDICADOR_CodigoLocal",
                table: "Indicadores",
                newName: "IX_Indicadores_CodigoLocal");

            migrationBuilder.AlterColumn<decimal>(
                name: "NivelTurbidez",
                table: "Indicadores",
                type: "DECIMAL(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(18, 2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "NivelTemperatura",
                table: "Indicadores",
                type: "DECIMAL(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(18, 2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "NivelPH",
                table: "Indicadores",
                type: "DECIMAL(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(18, 2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "NivelOxigenioDissolvido",
                table: "Indicadores",
                type: "DECIMAL(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(18, 2)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "CodigoUsuario");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Locais",
                table: "Locais",
                column: "CodigoLocal");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Indicadores",
                table: "Indicadores",
                column: "CodigoIndicador");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cidades",
                table: "Cidades",
                column: "CodigoCidade");

            migrationBuilder.AddForeignKey(
                name: "FK_Indicadores_Locais_CodigoLocal",
                table: "Indicadores",
                column: "CodigoLocal",
                principalTable: "Locais",
                principalColumn: "CodigoLocal",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Locais_Cidades_CodigoCidade",
                table: "Locais",
                column: "CodigoCidade",
                principalTable: "Cidades",
                principalColumn: "CodigoCidade",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
