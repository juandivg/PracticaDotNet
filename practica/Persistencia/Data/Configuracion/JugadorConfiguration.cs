using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuracion
{
    public class JugadorConfiguration : IEntityTypeConfiguration<Jugador>
    {
        public void Configure(EntityTypeBuilder<Jugador> builder)
        {
            builder.ToTable("Jugador");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasMaxLength(3);

            builder.Property(x => x.dorsal).HasMaxLength(2);

            builder.HasOne(x=>x.posicion)
            .WithMany(p=>p.jugadores)
            .HasForeignKey(j=>j.idPos);
        }
    }
}