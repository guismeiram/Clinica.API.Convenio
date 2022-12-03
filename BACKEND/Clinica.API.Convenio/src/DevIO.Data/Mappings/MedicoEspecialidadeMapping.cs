﻿using DevIO.Bussines.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Data.Mappings
{
    public class MedicoEspecialidadeMapping : IEntityTypeConfiguration<MedicoEspecialidade>
    {
        public void Configure(EntityTypeBuilder<MedicoEspecialidade> builder)
        {
            builder.HasKey(prop => prop.Id);
        }
    }
}
