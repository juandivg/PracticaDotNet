using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entities;
    public class Pais: BaseEntity
    {
        public string ? nombrePais { get; set; }
        public ICollection<Equipo> ? Equipos { get; set; }

        
    }
