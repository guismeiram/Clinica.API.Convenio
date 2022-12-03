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
    public class PacienteRepository : Repository<Paciente>, IPacienteRepository
    {
        public PacienteRepository(ClinicaDbContext db) : base(db)
        {
        }

        public Task<Paciente> ObterPacienteTipoPagamento(string id)
        {
            throw new NotImplementedException();
        }
    }
}
