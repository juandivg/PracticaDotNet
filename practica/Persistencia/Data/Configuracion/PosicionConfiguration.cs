using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuracion
{
    public class PosicionConfiguration : IEntityTypeConfiguration<Posicion>
    {
        public void Configure(EntityTypeBuilder<Posicion> builder)
        {
            builder.ToTable("Posicion");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasMaxLength(3);
            builder.Property(x => x.nombrePosicion).IsRequired();
        }
    }
}