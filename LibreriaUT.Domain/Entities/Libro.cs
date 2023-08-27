using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUT.Domain.Entities
{
    public class Libro
    {
        public int LibroId { get; set; }
        public string Titulo { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaDePublicacion { get; set; }

        //establecer la relacion       
        public Autor Autor { get; set; } // propiedad de navegación
        public int AutorId { get; set; } //FK

        //establecer relacion 1 a 1 con Portada, Libro sera el Padre
        public Portada Portada { get; set; }
    }
}
