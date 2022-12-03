using DevIO.Bussines.Interface;
using DevIO.Bussines.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Bussines.Services
{
    public class ConsultaService : BaseService, IConsultaService
    {
        public ConsultaService(INotificador notificador) : base(notificador)
        {
        }

        public Task Adicionar(Consulta consulta)
        {
            throw new NotImplementedException();
        }

        public Task Atualizar(Consulta consulta)
        {
            throw new NotImplementedException();
        }

        public Task AtualizarEndereco(Consulta consulta)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task Remover(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
