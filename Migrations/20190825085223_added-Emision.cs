using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Green_for_the_Earth.Migrations
{
    public partial class addedEmision : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Casa",
                table: "Uses",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Comida",
                table: "Uses",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Transporte",
                table: "Uses",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Casa",
                table: "Uses");

            migrationBuilder.DropColumn(
                name: "Comida",
                table: "Uses");

            migrationBuilder.DropColumn(
                name: "Transporte",
                table: "Uses");
        }
    }
}
