using DevIO.Bussines.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Data.Mappings
{
    public class TipoPagamentoMapping : IEntityTypeConfiguration<TipoPagamento>
    {
        public void Configure(EntityTypeBuilder<TipoPagamento> builder)
        {
            builder.HasKey(p => p.Id);


            //1 : N Convenio : Paciente
            builder.HasMany(e => e.PacienteTipoPagamentos)
                .WithOne(m => m.TipoPagamento)
                .HasForeignKey(m => m.TipoPagamentoId);
        }
    }
}
