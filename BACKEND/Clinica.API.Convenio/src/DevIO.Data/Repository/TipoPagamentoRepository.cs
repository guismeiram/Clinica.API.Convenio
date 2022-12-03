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
    public class TipoPagamentoRepository : Repository<TipoPagamento>, ITipoPagamentoRepository
    {
        public TipoPagamentoRepository(ClinicaDbContext db) : base(db)
        {
        }

        public Task<TipoPagamento> ObterTipoPagamento(string id)
        {
            throw new NotImplementedException();
        }
    }
}
