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
    public class ConvenioRepository : Repository<Convenio>, IConvenioRepository
    {
        public ConvenioRepository(ClinicaDbContext db) : base(db)
        {
        }

        public Task<Endereco> ObterConvenio(string convenioId)
        {
            throw new NotImplementedException();
        }
    }
}
