using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUT.Domain.Entities
{
    public  class Artista
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        //establecer la relacion con Portadas
        public List<Portada> Portadas { get; set; } = new();

    }
}
