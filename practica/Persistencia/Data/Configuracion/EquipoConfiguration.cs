using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuracion
{
    public class EquipoConfiguration : IEntityTypeConfiguration<Equipo>
    {
        public void Configure(EntityTypeBuilder<Equipo> builder)
        {
            builder.ToTable("Equipo");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
            .HasMaxLength(3);

            builder.Property(x => x.nombreEquipo)
            .IsRequired()
            .HasMaxLength(30);

            builder.HasOne(e => e.Pais)
            .WithMany(p => p.Equipos)
            .HasForeignKey(f => f.idPaisFK);

        }
    }
}