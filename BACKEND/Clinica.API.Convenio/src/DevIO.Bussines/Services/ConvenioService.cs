using DevIO.Bussines.Interface;
using DevIO.Bussines.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Bussines.Services
{
    public class ConvenioService : BaseService, IConvenioService
    {
        public ConvenioService(INotificador notificador) : base(notificador)
        {

        }

        public Task Adicionar(Convenio convenio)
        {
            throw new NotImplementedException();
        }

        public Task Atualizar(Convenio convenio)
        {
            throw new NotImplementedException();
        }

        public Task AtualizarConvenio(Convenio convenio)
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
