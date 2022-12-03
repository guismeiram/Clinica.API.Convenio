using DevIO.Bussines.Interface;
using DevIO.Bussines.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Bussines.Services
{
    public class EspecialidadeService : BaseService, IEspecialidadeService
    {
        public EspecialidadeService(INotificador notificador) : base(notificador)
        {
        }

        public Task Adicionar(Especialidade especialidade)
        {
            throw new NotImplementedException();
        }

        public Task Atualizar(Especialidade especialidade)
        {
            throw new NotImplementedException();
        }

        public Task AtualizarEspecialidade(Especialidade especialidade)
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
