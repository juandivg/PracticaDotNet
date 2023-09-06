using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entities
{
    public class Posicion: BaseEntity
    {
        public string ? nombrePosicion { get; set; }
        public ICollection<Jugador>? jugadores { get; set; }
    }
}