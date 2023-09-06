using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entities
{
    public class Persona: BaseEntity
    {
        public string ? nombrePersona { get; set; }
        public string? apellido { get; set; }
        public int edad { get; set;}
        public int idTipo { get; set; }
        public TipoNomina ? tipoNomina { get; set; }
        public int idEquipo { get; set; }
        public Equipo? equipo { get; set; }
        public Jugador? jugador { get; set; }


    }
}