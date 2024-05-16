using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace migration_relacao_atual.Migrations
{
    /// <inheritdoc />
    public partial class primeiraMigracao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarteirasMotorista",
                columns: table => new
                {
                    CarteiraMotoristaId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    DataValidade = table.Column<DateTime>(type: "DATE", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarteirasMotorista", x => x.CarteiraMotoristaId);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nome = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    CarteiraMotoristaId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteId);
                    table.ForeignKey(
                        name: "FK_Clientes_CarteirasMotorista_CarteiraMotoristaId",
                        column: x => x.CarteiraMotoristaId,
                        principalTable: "CarteirasMotorista",
                        principalColumn: "CarteiraMotoristaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_CarteiraMotoristaId",
                table: "Clientes",
                column: "CarteiraMotoristaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "CarteirasMotorista");
        }
    }
}
