using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Green_for_the_Earth.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Carne = table.Column<int>(nullable: false),
                    Co2Total = table.Column<double>(nullable: false),
                    Co2Vuelos = table.Column<double>(nullable: false),
                    Co2semanal = table.Column<double>(nullable: false),
                    Electricidad = table.Column<double>(nullable: false),
                    EmisionCarro = table.Column<double>(nullable: false),
                    EmisionGas = table.Column<double>(nullable: false),
                    EmisionGasTotal = table.Column<double>(nullable: false),
                    KmCamion = table.Column<double>(nullable: false),
                    KmCamionTotal = table.Column<double>(nullable: false),
                    KmCarro = table.Column<double>(nullable: false),
                    KmCarroTotal = table.Column<double>(nullable: false),
                    KmTaxi = table.Column<double>(nullable: false),
                    KmTaxiTotal = table.Column<double>(nullable: false),
                    KmVuelos = table.Column<double>(nullable: false),
                    KwhTotal = table.Column<double>(nullable: false),
                    ModeloCarro = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: true),
                    Pais = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Pescado = table.Column<int>(nullable: false),
                    Pollo = table.Column<int>(nullable: false),
                    Puerco = table.Column<int>(nullable: false),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
