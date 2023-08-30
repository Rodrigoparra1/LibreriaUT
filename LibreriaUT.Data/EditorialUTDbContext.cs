using LibreriaUT.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUT.Data
{
    public class EditorialUTDbContext :DbContext
    {
        //los dbsets
        public DbSet<Libro> Libros { get; set; }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Artista> Artistas { get; set; }
        public DbSet<Portada> Portadas { get; set; }


      
        public EditorialUTDbContext(DbContextOptions<EditorialUTDbContext> options) : base(options)
        {
                
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                //.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LibreriaUT")
                .LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, LogLevel.Information)
                .EnableSensitiveDataLogging(); //activando un log
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Autor>().HasData(
            //        new Autor { Id = 1, Nombre = "Roberto J", Apellidos = "Estrada Benavides" },
            //        new Autor { Id = 2, Nombre = "Andres G", Apellidos = "Estrada Benavides" },
            //        new Autor { Id = 3, Nombre = "Mario", Apellidos = "Puzo" },
            //        new Autor { Id = 4, Nombre = "Stephen", Apellidos = "King" },
            //        new Autor { Id = 5, Nombre = "Hugo", Apellidos = "Sanchez" },
            //        new Autor { Id = 6, Nombre = "Miguel", Apellidos = "de Cervantes" },
            //        new Autor { Id = 7, Nombre = "John Ronald", Apellidos = "Reuel Tolkien" },
            //        new Autor { Id = 8, Nombre = "Masashi", Apellidos = "Kishimoto" },
            //        new Autor { Id = 9, Nombre = "Antoine", Apellidos = "de Saint-Exupéry" },
            //        new Autor { Id = 10, Nombre = "Sun", Apellidos = "Tzu" }
            //    );

            //modelBuilder.Entity<Libro>().HasData(
            //        new Libro { LibroId = 1, Titulo = "Entity Framework Core 6", FechaDePublicacion = new DateTime(2000, 06, 07), Precio = 749.99m, AutorId = 1 },
            //        new Libro { LibroId = 2, Titulo = "Mi Historia en Real Madrid", FechaDePublicacion = new DateTime(2000, 01, 10), Precio = 850, AutorId = 5 },
            //        new Libro { LibroId = 3, Titulo = "Don Quijote de la Mancha", FechaDePublicacion = new DateTime(1605, 01, 16), Precio = 547.27m, AutorId = 6 },
            //        new Libro { LibroId = 4, Titulo = "La Galatea", FechaDePublicacion = new DateTime(2006, 01, 19), Precio = 369.75m, AutorId = 6 },
            //        new Libro { LibroId = 5, Titulo = "El Arte de la guerra", FechaDePublicacion = new DateTime(2019, 06, 10), Precio = 240, AutorId = 10 },
            //        new Libro { LibroId = 6, Titulo = "El principito", FechaDePublicacion = new DateTime(1943, 04, 06), Precio = 184, AutorId = 9 },
            //        new Libro { LibroId = 7, Titulo = "Vuelo nocturno", FechaDePublicacion = new DateTime(2017, 01, 03), Precio = 250, AutorId = 9 },
            //        new Libro { LibroId = 8, Titulo = "Naruto, Vol. 1: Volume 1", FechaDePublicacion = new DateTime(2003, 08, 16), Precio = 239.79m, AutorId = 8 },
            //        new Libro { LibroId = 9, Titulo = "It: A Novel", FechaDePublicacion = new DateTime(2016, 01, 05), Precio = 695.64m, AutorId = 4 },
            //        new Libro { LibroId = 10, Titulo = "Carrie", FechaDePublicacion = new DateTime(2023, 02, 21), Precio = 668.79m, AutorId = 4 },
            //        new Libro { LibroId = 11, Titulo = "El Señor de los Anillos I La Comunidad del Anillo", FechaDePublicacion = new DateTime(2022, 09, 16), Precio = 726.37m, AutorId = 7 },
            //        new Libro { LibroId = 12, Titulo = "El Señor de los Anillos II Las Dos Torres", FechaDePublicacion = new DateTime(2022, 09, 16), Precio = 894.00m, AutorId = 7 },
            //        new Libro { LibroId = 13, Titulo = "El Señor de los Anillos III El Retorno del Rey", FechaDePublicacion = new DateTime(2014, 01, 01), Precio = 561, AutorId = 7 }
            //    );


            //modelBuilder.Entity<Artista>().HasData(
            //        new Artista { Id = 1, Nombre = "Pablo", Apellidos = "Picasso" },
            //        new Artista { Id = 2, Nombre = "Eungenio Salvador", Apellidos = "Dalí" },
            //        new Artista { Id = 3, Nombre = "Frida", Apellidos = "Kahlo" }
            //);

            //modelBuilder.Entity<Portada>().HasData(
            //        new Portada { Id = 1, Descripcion = "Hombre a caballo a la media noche", LibroId = 13 },
            //        new Portada { Id = 2, Descripcion = "Globo Rojo frente a la sombra de un niño", LibroId = 9 },
            //        new Portada { Id = 3, Descripcion = "Dragón Negro incendiando un pueblo", IsSoloDigital = true, LibroId = 11 },
            //        new Portada { Id = 4, Descripcion = "Hombre pasando frente a unos Molinos", LibroId = 3 },
            //        new Portada { Id = 5, Descripcion = "Corona gigante con fondo de fuego", IsSoloDigital = true, LibroId = 12 }
            //);
        }

    }
}
