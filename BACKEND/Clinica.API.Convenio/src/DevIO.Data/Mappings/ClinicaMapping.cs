using DevIO.Bussines.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Data.Mappings
{
    public class ClinicaMapping : IEntityTypeConfiguration<Clinica>
    {
        public void Configure(EntityTypeBuilder<Clinica> builder)
        {
            builder.HasKey(prop => prop.Id);

            builder.Property(c => c.Telefone)
            .IsRequired()
            .HasColumnType("varchar(200)");

            builder.Property(c => c.Ddd)
                .IsRequired()
                .HasColumnType("varchar(200)");

            //1 : N Clinica : Consultas
            builder.HasMany(e => e.Consultas)
                .WithOne(m => m.Clinica)
                .HasForeignKey(m => m.ClinicaId)
                .OnDelete(DeleteBehavior.Restrict);

            //1 : 1 Clinica : Endereco
            builder.HasOne(e => e.Endereco)
                .WithOne(m => m.Clinica)
                .HasForeignKey<Endereco>(c => c.EnderecoId);
        }
    }
}
