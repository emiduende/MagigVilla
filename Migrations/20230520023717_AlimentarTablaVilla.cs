using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AlimentarTablaVilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenidad", "Detalle", "FechaActualizacion", "FechaCreacion", "ImagenUrl", "MetrosCuadrados", "Nombre", "Ocupantes", "Tarifa" },
                values: new object[,]
                {
                    { 1, "", "Detalle de la Villa", new DateTime(2023, 5, 19, 21, 37, 17, 379, DateTimeKind.Local).AddTicks(6465), new DateTime(2023, 5, 19, 21, 37, 17, 379, DateTimeKind.Local).AddTicks(6453), "", 50, "Villa Real", 5, "200" },
                    { 2, "", "Detalle de la Villa", new DateTime(2023, 5, 19, 21, 37, 17, 379, DateTimeKind.Local).AddTicks(6467), new DateTime(2023, 5, 19, 21, 37, 17, 379, DateTimeKind.Local).AddTicks(6466), "", 40, "Premium vista a la piscina", 4, "150" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
