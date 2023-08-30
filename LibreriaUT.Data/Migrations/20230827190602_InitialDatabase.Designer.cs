﻿// <auto-generated />
using System;
using LibreriaUT.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LibreriaUT.Data.Migrations
{
    [DbContext(typeof(EditorialUTDbContext))]
    [Migration("20230827190602_InitialDatabase")]
    partial class InitialDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ArtistaPortada", b =>
                {
                    b.Property<int>("ArtistasId")
                        .HasColumnType("int");

                    b.Property<int>("PortadasId")
                        .HasColumnType("int");

                    b.HasKey("ArtistasId", "PortadasId");

                    b.HasIndex("PortadasId");

                    b.ToTable("ArtistaPortada");
                });

            modelBuilder.Entity("LibreriaUT.Domain.Entities.Artista", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Artistas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Apellidos = "Picasso",
                            Nombre = "Pablo"
                        },
                        new
                        {
                            Id = 2,
                            Apellidos = "Dalí",
                            Nombre = "Eungenio Salvador"
                        },
                        new
                        {
                            Id = 3,
                            Apellidos = "Kahlo",
                            Nombre = "Frida"
                        });
                });

            modelBuilder.Entity("LibreriaUT.Domain.Entities.Autor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Autores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Apellidos = "Estrada Benavides",
                            Nombre = "Roberto J"
                        },
                        new
                        {
                            Id = 2,
                            Apellidos = "Estrada Benavides",
                            Nombre = "Andres G"
                        },
                        new
                        {
                            Id = 3,
                            Apellidos = "Puzo",
                            Nombre = "Mario"
                        },
                        new
                        {
                            Id = 4,
                            Apellidos = "King",
                            Nombre = "Stephen"
                        },
                        new
                        {
                            Id = 5,
                            Apellidos = "Sanchez",
                            Nombre = "Hugo"
                        },
                        new
                        {
                            Id = 6,
                            Apellidos = "de Cervantes",
                            Nombre = "Miguel"
                        },
                        new
                        {
                            Id = 7,
                            Apellidos = "Reuel Tolkien",
                            Nombre = "John Ronald"
                        },
                        new
                        {
                            Id = 8,
                            Apellidos = "Kishimoto",
                            Nombre = "Masashi"
                        },
                        new
                        {
                            Id = 9,
                            Apellidos = "de Saint-Exupéry",
                            Nombre = "Antoine"
                        },
                        new
                        {
                            Id = 10,
                            Apellidos = "Tzu",
                            Nombre = "Sun"
                        });
                });

            modelBuilder.Entity("LibreriaUT.Domain.Entities.Libro", b =>
                {
                    b.Property<int>("LibroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LibroId"));

                    b.Property<int>("AutorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaDePublicacion")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LibroId");

                    b.HasIndex("AutorId");

                    b.ToTable("Libros");

                    b.HasData(
                        new
                        {
                            LibroId = 1,
                            AutorId = 1,
                            FechaDePublicacion = new DateTime(2000, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Precio = 749.99m,
                            Titulo = "Entity Framework Core 6"
                        },
                        new
                        {
                            LibroId = 2,
                            AutorId = 5,
                            FechaDePublicacion = new DateTime(2000, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Precio = 850m,
                            Titulo = "Mi Historia en Real Madrid"
                        },
                        new
                        {
                            LibroId = 3,
                            AutorId = 6,
                            FechaDePublicacion = new DateTime(1605, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Precio = 547.27m,
                            Titulo = "Don Quijote de la Mancha"
                        },
                        new
                        {
                            LibroId = 4,
                            AutorId = 6,
                            FechaDePublicacion = new DateTime(2006, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Precio = 369.75m,
                            Titulo = "La Galatea"
                        },
                        new
                        {
                            LibroId = 5,
                            AutorId = 10,
                            FechaDePublicacion = new DateTime(2019, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Precio = 240m,
                            Titulo = "El Arte de la guerra"
                        },
                        new
                        {
                            LibroId = 6,
                            AutorId = 9,
                            FechaDePublicacion = new DateTime(1943, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Precio = 184m,
                            Titulo = "El principito"
                        },
                        new
                        {
                            LibroId = 7,
                            AutorId = 9,
                            FechaDePublicacion = new DateTime(2017, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Precio = 250m,
                            Titulo = "Vuelo nocturno"
                        },
                        new
                        {
                            LibroId = 8,
                            AutorId = 8,
                            FechaDePublicacion = new DateTime(2003, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Precio = 239.79m,
                            Titulo = "Naruto, Vol. 1: Volume 1"
                        },
                        new
                        {
                            LibroId = 9,
                            AutorId = 4,
                            FechaDePublicacion = new DateTime(2016, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Precio = 695.64m,
                            Titulo = "It: A Novel"
                        },
                        new
                        {
                            LibroId = 10,
                            AutorId = 4,
                            FechaDePublicacion = new DateTime(2023, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Precio = 668.79m,
                            Titulo = "Carrie"
                        },
                        new
                        {
                            LibroId = 11,
                            AutorId = 7,
                            FechaDePublicacion = new DateTime(2022, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Precio = 726.37m,
                            Titulo = "El Señor de los Anillos I La Comunidad del Anillo"
                        },
                        new
                        {
                            LibroId = 12,
                            AutorId = 7,
                            FechaDePublicacion = new DateTime(2022, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Precio = 894.00m,
                            Titulo = "El Señor de los Anillos II Las Dos Torres"
                        },
                        new
                        {
                            LibroId = 13,
                            AutorId = 7,
                            FechaDePublicacion = new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Precio = 561m,
                            Titulo = "El Señor de los Anillos III El Retorno del Rey"
                        });
                });

            modelBuilder.Entity("LibreriaUT.Domain.Entities.Portada", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsSoloDigital")
                        .HasColumnType("bit");

                    b.Property<int>("LibroId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LibroId")
                        .IsUnique();

                    b.ToTable("Portadas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descripcion = "Hombre a caballo a la media noche",
                            IsSoloDigital = false,
                            LibroId = 13
                        },
                        new
                        {
                            Id = 2,
                            Descripcion = "Globo Rojo frente a la sombra de un niño",
                            IsSoloDigital = false,
                            LibroId = 9
                        },
                        new
                        {
                            Id = 3,
                            Descripcion = "Dragón Negro incendiando un pueblo",
                            IsSoloDigital = true,
                            LibroId = 11
                        },
                        new
                        {
                            Id = 4,
                            Descripcion = "Hombre pasando frente a unos Molinos",
                            IsSoloDigital = false,
                            LibroId = 3
                        },
                        new
                        {
                            Id = 5,
                            Descripcion = "Corona gigante con fondo de fuego",
                            IsSoloDigital = true,
                            LibroId = 12
                        });
                });

            modelBuilder.Entity("ArtistaPortada", b =>
                {
                    b.HasOne("LibreriaUT.Domain.Entities.Artista", null)
                        .WithMany()
                        .HasForeignKey("ArtistasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibreriaUT.Domain.Entities.Portada", null)
                        .WithMany()
                        .HasForeignKey("PortadasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LibreriaUT.Domain.Entities.Libro", b =>
                {
                    b.HasOne("LibreriaUT.Domain.Entities.Autor", "Autor")
                        .WithMany("Libros")
                        .HasForeignKey("AutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Autor");
                });

            modelBuilder.Entity("LibreriaUT.Domain.Entities.Portada", b =>
                {
                    b.HasOne("LibreriaUT.Domain.Entities.Libro", "Libro")
                        .WithOne("Portada")
                        .HasForeignKey("LibreriaUT.Domain.Entities.Portada", "LibroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Libro");
                });

            modelBuilder.Entity("LibreriaUT.Domain.Entities.Autor", b =>
                {
                    b.Navigation("Libros");
                });

            modelBuilder.Entity("LibreriaUT.Domain.Entities.Libro", b =>
                {
                    b.Navigation("Portada")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
