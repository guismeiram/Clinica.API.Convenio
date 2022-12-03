using DevIO.Bussines.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Bussines.Interface
{
    public interface ITipoPagamentoService : IDisposable
    {
        Task Adicionar(TipoPagamento tipoPagamento);
        Task Atualizar(TipoPagamento tipoPagamento);
        Task Remover(String id);
        Task AtualizarTipoPagamento(TipoPagamento tipoPagamento);
    }
}
