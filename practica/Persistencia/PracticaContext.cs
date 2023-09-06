using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistencia;

    public class PracticaContext : DbContext
    {
        public PracticaContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<Posicion> Posiciones { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<TipoNomina> TipoNominas { get; set; }
        public DbSet<Jugador> Jugadores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<Persona>()
            .HasOne(p=>p.jugador)
            .WithOne(j=>j.persona)
            .HasForeignKey<Jugador>(j=>j.idPersonaFK);
        }

    }
