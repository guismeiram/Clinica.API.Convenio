using DevIO.Bussines.Interface;
using DevIO.Bussines.Models;
using DevIO.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Data.Repository
{
    public class ClinicaRepository : Repository<Clinica>, IClinicaRepository
    {
        public ClinicaRepository(ClinicaDbContext db) : base(db)
        {
        }

        public async Task<Clinica> ObterClinicaConsultaEndereco(string id)
        {
            return await Db.Clinica.AsNoTracking()
               .Include(c => c.Consultas)
               .Include(c => c.Endereco)
               .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<Clinica> ObterClinicaEndereco(string id)
        {
            return await Db.Clinica.AsNoTracking()
               .Include(c => c.Endereco)
               .FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
