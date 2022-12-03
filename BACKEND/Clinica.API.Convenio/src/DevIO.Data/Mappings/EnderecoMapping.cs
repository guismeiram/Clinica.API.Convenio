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
    public class EnderecoMapping : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(prop => prop.Id);

            //1 : 1 Endereco : Medico
            builder.HasOne(e => e.Medico)
                .WithOne(m => m.Endereco);

            //1 : 1 Clinica : Endereco
            builder.HasOne(e => e.Clinica)
                .WithOne(m => m.Endereco)
                .HasForeignKey<Clinica>(c => c.ClinicaId);
        }
    }
}
