using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUT.Domain.Entities
{
    public  class Portada
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public bool IsSoloDigital { get; set; }

        //establecer relacion con Artista
        public List<Artista> Artistas { get; set; } = new();

        //establecer relacion 1 a 1 con su papá Libro 
        public Libro Libro { get; set; }
        public int LibroId { get; set; }
    }
}
