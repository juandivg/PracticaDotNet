using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuracion
{
    public class PersonaConfiguration : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {
            builder.ToTable("Persona");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasMaxLength(3);

            builder.Property(x => x.nombrePersona).IsRequired().HasMaxLength(30);
            builder.Property(x => x.apellido).IsRequired().HasMaxLength(30);
            builder.Property(x => x.edad).IsRequired().HasMaxLength(10);
            builder.HasOne(x=>x.equipo)
            .WithMany(e=>e.personas)
            .HasForeignKey(p=>p.idEquipo);
            builder.HasOne(x=>x.tipoNomina)
            .WithMany(t=>t.personas)
            .HasForeignKey(p=>p.idTipo);
        }
    }
}