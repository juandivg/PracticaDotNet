using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entities;
    public class Jugador: BaseEntity
    {
        public int dorsal { get; set; }
        public int idPos { get; set; }
        public Posicion? posicion { get; set; }
        
        public int idPersonaFK { get; set; }
        public Persona ? persona { get; set; }
    }
