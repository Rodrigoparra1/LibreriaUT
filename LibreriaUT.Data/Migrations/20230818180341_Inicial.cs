using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibreriaUT.Data.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artistas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artistas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Autores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Libros",
                columns: table => new
                {
                    LibroId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FechaDePublicacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AutorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libros", x => x.LibroId);
                    table.ForeignKey(
                        name: "FK_Libros_Autores_AutorId",
                        column: x => x.AutorId,
                        principalTable: "Autores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Portadas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsSoloDigital = table.Column<bool>(type: "bit", nullable: false),
                    LibroId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Portadas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Portadas_Libros_LibroId",
                        column: x => x.LibroId,
                        principalTable: "Libros",
                        principalColumn: "LibroId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArtistaPortada",
                columns: table => new
                {
                    ArtistasId = table.Column<int>(type: "int", nullable: false),
                    PortadasId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtistaPortada", x => new { x.ArtistasId, x.PortadasId });
                    table.ForeignKey(
                        name: "FK_ArtistaPortada_Artistas_ArtistasId",
                        column: x => x.ArtistasId,
                        principalTable: "Artistas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtistaPortada_Portadas_PortadasId",
                        column: x => x.PortadasId,
                        principalTable: "Portadas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Artistas",
                columns: new[] { "Id", "Apellidos", "Nombre" },
                values: new object[,]
                {
                    { 1, "Picasso", "Pablo" },
                    { 2, "Dalí", "Eungenio Salvador" },
                    { 3, "Kahlo", "Frida" }
                });

            migrationBuilder.InsertData(
                table: "Autores",
                columns: new[] { "Id", "Apellidos", "Nombre" },
                values: new object[,]
                {
                    { 1, "Estrada Benavides", "Roberto J" },
                    { 2, "Estrada Benavides", "Andres G" },
                    { 3, "Puzo", "Mario" },
                    { 4, "King", "Stephen" },
                    { 5, "Sanchez", "Hugo" },
                    { 6, "de Cervantes", "Miguel" },
                    { 7, "Reuel Tolkien", "John Ronald" },
                    { 8, "Kishimoto", "Masashi" },
                    { 9, "de Saint-Exupéry", "Antoine" },
                    { 10, "Tzu", "Sun" }
                });

            migrationBuilder.InsertData(
                table: "Libros",
                columns: new[] { "LibroId", "AutorId", "FechaDePublicacion", "Precio", "Titulo" },
                values: new object[,]
                {
                    { 3, 6, new DateTime(1605, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 547.27m, "Don Quijote de la Mancha" },
                    { 9, 4, new DateTime(2016, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 695.64m, "It: A Novel" },
                    { 11, 7, new DateTime(2022, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 726.37m, "El Señor de los Anillos I La Comunidad del Anillo" },
                    { 12, 7, new DateTime(2022, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 894.00m, "El Señor de los Anillos II Las Dos Torres" },
                    { 13, 7, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 561m, "El Señor de los Anillos III El Retorno del Rey" }
                });

            migrationBuilder.InsertData(
                table: "Portadas",
                columns: new[] { "Id", "Descripcion", "IsSoloDigital", "LibroId" },
                values: new object[,]
                {
                    { 1, "Hombre a caballo a la media noche", false, 13 },
                    { 2, "Globo Rojo frente a la sombra de un niño", false, 9 },
                    { 3, "Dragón Negro incendiando un pueblo", true, 11 },
                    { 4, "Hombre pasando frente a unos Molinos", false, 3 },
                    { 5, "Corona gigante con fondo de fuego", true, 12 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArtistaPortada_PortadasId",
                table: "ArtistaPortada",
                column: "PortadasId");

            migrationBuilder.CreateIndex(
                name: "IX_Libros_AutorId",
                table: "Libros",
                column: "AutorId");

            migrationBuilder.CreateIndex(
                name: "IX_Portadas_LibroId",
                table: "Portadas",
                column: "LibroId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArtistaPortada");

            migrationBuilder.DropTable(
                name: "Artistas");

            migrationBuilder.DropTable(
                name: "Portadas");

            migrationBuilder.DropTable(
                name: "Libros");

            migrationBuilder.DropTable(
                name: "Autores");
        }
    }
}
