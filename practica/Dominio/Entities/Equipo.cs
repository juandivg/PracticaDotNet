using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entities;
    public class Equipo: BaseEntity
    {
        public string ? nombreEquipo { get; set; }
        public int idPaisFK { get; set; }
        public Pais ? Pais { get; set; }
        public ICollection<Persona>? personas { get; set; }

    }
