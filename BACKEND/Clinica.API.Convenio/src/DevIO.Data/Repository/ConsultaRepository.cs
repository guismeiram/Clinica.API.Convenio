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
    public class ConsultaRepository : Repository<Consulta>, IConsultaRepository
    {
        public ConsultaRepository(ClinicaDbContext db) : base(db)
        {
        }

        public async Task<Consulta> obterConsultaClinica(string id)
        {
            return await Db.Consulta.AsNoTracking()
                .Include(c => c.Clinica)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<Consulta> obterConsultaClinicaPaciente(string id)
        {
            return await Db.Consulta.AsNoTracking()
                .Include(c => c.Clinica)
                .Include(c => c.Paciente)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<Consulta> ObterConsultaPaciente(string id)
        {
            return await Db.Consulta.AsNoTracking()
                .Include(c => c.Paciente)
                .FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
