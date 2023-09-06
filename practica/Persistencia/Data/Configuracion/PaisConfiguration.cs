using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Persistencia.Data.Configuracion
{
    public class PaisConfiguration : IEntityTypeConfiguration<Pais>
    {
        public void Configure(EntityTypeBuilder<Pais> builder)
        {
            builder.ToTable("Pais");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
            .HasMaxLength(3);

            builder.Property(x => x.nombrePais)
            .IsRequired()
            .HasMaxLength(30);

        }
    }
}