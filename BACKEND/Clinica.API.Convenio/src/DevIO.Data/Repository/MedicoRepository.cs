using DevIO.Bussines.Interface;
using DevIO.Bussines.Models;
using DevIO.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Data.Repository
{
    public class MedicoRepository : Repository<Medico>, IMedicoRepository
    {
        public MedicoRepository(ClinicaDbContext db) : base(db)
        {
        }

        public Task<Medico> ObterMedicoConsultas(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Medico> ObterMedicoConsultasEspecialidades(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Medico> ObterMedicoEspecialidades(string id)
        {
            throw new NotImplementedException();
        }
    }
}
