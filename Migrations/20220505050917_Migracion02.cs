using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrabajoFinalProem_GalanFlorencia.Migrations
{
    public partial class Migracion02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_Factura_Facturanumero",
                table: "Cliente");

            migrationBuilder.DropTable(
                name: "Factura");

            migrationBuilder.DropTable(
                name: "Pagos");

            migrationBuilder.DropIndex(
                name: "IX_Cliente_Facturanumero",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "Facturanumero",
                table: "Cliente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Facturanumero",
                table: "Cliente",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Factura",
                columns: table => new
                {
                    numero = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IDCliente = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factura", x => x.numero);
                });

            migrationBuilder.CreateTable(
                name: "Pagos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IDCliente = table.Column<int>(type: "int", nullable: false),
                    importe = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagos", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_Facturanumero",
                table: "Cliente",
                column: "Facturanumero");

            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_Factura_Facturanumero",
                table: "Cliente",
                column: "Facturanumero",
                principalTable: "Factura",
                principalColumn: "numero");
        }
    }
}
