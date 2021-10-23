using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PIMHotelaria.Migrations
{
    public partial class CriaçãoInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome_Cliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cpf = table.Column<int>(type: "int", nullable: false),
                    telefone = table.Column<int>(type: "int", nullable: false),
                    apelido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    senha = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Contas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    agencia = table.Column<int>(type: "int", nullable: false),
                    titular = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    num_Conta = table.Column<int>(type: "int", nullable: false),
                    tp_Cartão = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    num_Cartão = table.Column<int>(type: "int", nullable: false),
                    cvc = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Reservas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dt_Entrada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dt_Saida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    num_Pessoas = table.Column<int>(type: "int", nullable: false),
                    mtd_Acesso = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservas", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Contas");

            migrationBuilder.DropTable(
                name: "Reservas");
        }
    }
}
