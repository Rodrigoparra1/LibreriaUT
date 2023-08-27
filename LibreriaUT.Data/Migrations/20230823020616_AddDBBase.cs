using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibreriaUT.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDBBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Libros",
                columns: new[] { "LibroId", "AutorId", "FechaDePublicacion", "Precio", "Titulo" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2000, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 749.99m, "Entity Framework Core 6" },
                    { 2, 5, new DateTime(2000, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 850m, "Mi Historia en Real Madrid" },
                    { 4, 6, new DateTime(2006, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 369.75m, "La Galatea" },
                    { 5, 10, new DateTime(2019, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 240m, "El Arte de la guerra" },
                    { 6, 9, new DateTime(1943, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 184m, "El principito" },
                    { 7, 9, new DateTime(2017, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 250m, "Vuelo nocturno" },
                    { 8, 8, new DateTime(2003, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 239.79m, "Naruto, Vol. 1: Volume 1" },
                    { 10, 4, new DateTime(2023, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 668.79m, "Carrie" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "LibroId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "LibroId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "LibroId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "LibroId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "LibroId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "LibroId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "LibroId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "LibroId",
                keyValue: 10);
        }
    }
}
