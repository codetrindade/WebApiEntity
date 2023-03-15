using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApiEntity.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    cliente = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomeFiscal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalDeb = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.cliente);
                });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "cliente", "DataCriacao", "Nome", "NomeFiscal", "TotalDeb" },
                values: new object[,]
                {
                    { "02555", new DateTime(2015, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aaaa J.K. Rowling", "F.K. Nothing", "" },
                    { "1", new DateTime(2015, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "J.K. Rowling", "J.K. Rowling", "" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
