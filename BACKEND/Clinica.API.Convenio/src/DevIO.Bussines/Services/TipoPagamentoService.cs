using DevIO.Bussines.Interface;
using DevIO.Bussines.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Bussines.Services
{
    public class TipoPagamentoService : BaseService, ITipoPagamentoService
    {
        public TipoPagamentoService(INotificador notificador) : base(notificador)
        {

        }

        public Task Adicionar(TipoPagamento tipoPagamento)
        {
            throw new NotImplementedException();
        }

        public Task Atualizar(TipoPagamento tipoPagamento)
        {
            throw new NotImplementedException();
        }

        public Task AtualizarTipoPagamento(TipoPagamento tipoPagamento)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task Remover(string id)
        {
            throw new NotImplementedException();
        }
    }
}
