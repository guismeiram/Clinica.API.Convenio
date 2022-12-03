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
    public class PacienteMapping : IEntityTypeConfiguration<Paciente>
    {
        public void Configure(EntityTypeBuilder<Paciente> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(c => c.Telefone)
            .IsRequired()
            .HasColumnType("varchar(200)");

            builder.Property(c => c.Ddd)
                .IsRequired()
                .HasColumnType("varchar(200)");
            //1 : 1 Endereco : Medico
            builder.HasOne(e => e.Consulta)
                .WithOne(m => m.Paciente);

            //1 : N Convenio : Paciente
            builder.HasMany(e => e.PacienteTipoPagamentos)
                .WithOne(m => m.Paciente)
                .HasForeignKey(m => m.PacienteId);
        }
    }
}
