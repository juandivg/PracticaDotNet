using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistencia.Data.Configuracion
{
    public class TipoNominaConfiguration : IEntityTypeConfiguration<TipoNomina>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<TipoNomina> builder)
        {
            builder.ToTable("TipoNomina");
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Id).HasMaxLength(3);
            builder.Property(x => x.nombreNomina).IsRequired();

            
        }
    }
}