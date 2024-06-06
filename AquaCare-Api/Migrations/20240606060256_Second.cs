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

            migrationBuilder.DropIndex(
                name: "IX_Locais_CodigoCidade",
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

            migrationBuilder.RenameColumn(
                name: "Senha",
                table: "AQUACARE_USUARIO",
                newName: "SENHA");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "AQUACARE_USUARIO",
                newName: "NOME");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "AQUACARE_USUARIO",
                newName: "EMAIL");

            migrationBuilder.RenameColumn(
                name: "CodigoUsuario",
                table: "AQUACARE_USUARIO",
                newName: "CODIGO_USUARIO");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "AQUACARE_LOCAL",
                newName: "NOME");

            migrationBuilder.RenameColumn(
                name: "Longitude",
                table: "AQUACARE_LOCAL",
                newName: "LONGITUDE");

            migrationBuilder.RenameColumn(
                name: "Latitude",
                table: "AQUACARE_LOCAL",
                newName: "LATITUDE");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "AQUACARE_LOCAL",
                newName: "DESCRICAO");

            migrationBuilder.RenameColumn(
                name: "CodigoCidade",
                table: "AQUACARE_LOCAL",
                newName: "CODIGO_CIDADE");

            migrationBuilder.RenameColumn(
                name: "CodigoLocal",
                table: "AQUACARE_LOCAL",
                newName: "CODIGO_LOCAL");

            migrationBuilder.RenameColumn(
                name: "NivelTurbidez",
                table: "AQUACARE_INDICADOR",
                newName: "NIVEL_TURBIDEZ");

            migrationBuilder.RenameColumn(
                name: "NivelTemperatura",
                table: "AQUACARE_INDICADOR",
                newName: "NIVEL_TEMPERATURA");

            migrationBuilder.RenameColumn(
                name: "NivelPH",
                table: "AQUACARE_INDICADOR",
                newName: "NIVEL_PH");

            migrationBuilder.RenameColumn(
                name: "NivelOxigenioDissolvido",
                table: "AQUACARE_INDICADOR",
                newName: "NIVEL_OXIGENIO_DISSOLVIDO");

            migrationBuilder.RenameColumn(
                name: "NivelColiformes",
                table: "AQUACARE_INDICADOR",
                newName: "NIVEL_COLIFORMES");

            migrationBuilder.RenameColumn(
                name: "DataHoraMedicao",
                table: "AQUACARE_INDICADOR",
                newName: "DATA_HORA_MEDICAO");

            migrationBuilder.RenameColumn(
                name: "CodigoLocal",
                table: "AQUACARE_INDICADOR",
                newName: "CODIGO_LOCAL");

            migrationBuilder.RenameColumn(
                name: "CodigoIndicador",
                table: "AQUACARE_INDICADOR",
                newName: "CODIGO_INDICADOR");

            migrationBuilder.RenameIndex(
                name: "IX_Indicadores_CodigoLocal",
                table: "AQUACARE_INDICADOR",
                newName: "IX_AQUACARE_INDICADOR_CODIGO_LOCAL");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "AQUACARE_CIDADE",
                newName: "NOME");

            migrationBuilder.RenameColumn(
                name: "Estado",
                table: "AQUACARE_CIDADE",
                newName: "ESTADO");

            migrationBuilder.RenameColumn(
                name: "CodigoCidade",
                table: "AQUACARE_CIDADE",
                newName: "CODIGO_CIDADE");

            migrationBuilder.AlterColumn<string>(
                name: "DESCRICAO",
                table: "AQUACARE_LOCAL",
                type: "NVARCHAR2(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AlterColumn<decimal>(
                name: "NIVEL_TURBIDEZ",
                table: "AQUACARE_INDICADOR",
                type: "DECIMAL(18, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "NIVEL_TEMPERATURA",
                table: "AQUACARE_INDICADOR",
                type: "DECIMAL(18, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "NIVEL_PH",
                table: "AQUACARE_INDICADOR",
                type: "DECIMAL(18, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "NIVEL_OXIGENIO_DISSOLVIDO",
                table: "AQUACARE_INDICADOR",
                type: "DECIMAL(18, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(18,2)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AQUACARE_USUARIO",
                table: "AQUACARE_USUARIO",
                column: "CODIGO_USUARIO");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AQUACARE_LOCAL",
                table: "AQUACARE_LOCAL",
                column: "CODIGO_LOCAL");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AQUACARE_INDICADOR",
                table: "AQUACARE_INDICADOR",
                column: "CODIGO_INDICADOR");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AQUACARE_CIDADE",
                table: "AQUACARE_CIDADE",
                column: "CODIGO_CIDADE");

            migrationBuilder.AddForeignKey(
                name: "FK_AQUACARE_INDICADOR_AQUACARE_LOCAL_CODIGO_LOCAL",
                table: "AQUACARE_INDICADOR",
                column: "CODIGO_LOCAL",
                principalTable: "AQUACARE_LOCAL",
                principalColumn: "CODIGO_LOCAL",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AQUACARE_INDICADOR_AQUACARE_LOCAL_CODIGO_LOCAL",
                table: "AQUACARE_INDICADOR");

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

            migrationBuilder.RenameColumn(
                name: "SENHA",
                table: "Usuarios",
                newName: "Senha");

            migrationBuilder.RenameColumn(
                name: "NOME",
                table: "Usuarios",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "EMAIL",
                table: "Usuarios",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "CODIGO_USUARIO",
                table: "Usuarios",
                newName: "CodigoUsuario");

            migrationBuilder.RenameColumn(
                name: "NOME",
                table: "Locais",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "LONGITUDE",
                table: "Locais",
                newName: "Longitude");

            migrationBuilder.RenameColumn(
                name: "LATITUDE",
                table: "Locais",
                newName: "Latitude");

            migrationBuilder.RenameColumn(
                name: "DESCRICAO",
                table: "Locais",
                newName: "Descricao");

            migrationBuilder.RenameColumn(
                name: "CODIGO_CIDADE",
                table: "Locais",
                newName: "CodigoCidade");

            migrationBuilder.RenameColumn(
                name: "CODIGO_LOCAL",
                table: "Locais",
                newName: "CodigoLocal");

            migrationBuilder.RenameColumn(
                name: "NIVEL_TURBIDEZ",
                table: "Indicadores",
                newName: "NivelTurbidez");

            migrationBuilder.RenameColumn(
                name: "NIVEL_TEMPERATURA",
                table: "Indicadores",
                newName: "NivelTemperatura");

            migrationBuilder.RenameColumn(
                name: "NIVEL_PH",
                table: "Indicadores",
                newName: "NivelPH");

            migrationBuilder.RenameColumn(
                name: "NIVEL_OXIGENIO_DISSOLVIDO",
                table: "Indicadores",
                newName: "NivelOxigenioDissolvido");

            migrationBuilder.RenameColumn(
                name: "NIVEL_COLIFORMES",
                table: "Indicadores",
                newName: "NivelColiformes");

            migrationBuilder.RenameColumn(
                name: "DATA_HORA_MEDICAO",
                table: "Indicadores",
                newName: "DataHoraMedicao");

            migrationBuilder.RenameColumn(
                name: "CODIGO_LOCAL",
                table: "Indicadores",
                newName: "CodigoLocal");

            migrationBuilder.RenameColumn(
                name: "CODIGO_INDICADOR",
                table: "Indicadores",
                newName: "CodigoIndicador");

            migrationBuilder.RenameIndex(
                name: "IX_AQUACARE_INDICADOR_CODIGO_LOCAL",
                table: "Indicadores",
                newName: "IX_Indicadores_CodigoLocal");

            migrationBuilder.RenameColumn(
                name: "NOME",
                table: "Cidades",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "ESTADO",
                table: "Cidades",
                newName: "Estado");

            migrationBuilder.RenameColumn(
                name: "CODIGO_CIDADE",
                table: "Cidades",
                newName: "CodigoCidade");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Locais",
                type: "NVARCHAR2(2000)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(250)",
                oldMaxLength: 250);

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

            migrationBuilder.CreateIndex(
                name: "IX_Locais_CodigoCidade",
                table: "Locais",
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
