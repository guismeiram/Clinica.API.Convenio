using DevIO.Bussines.Interface;
using DevIO.Bussines.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Bussines.Services
{
    public class EnderecoService : BaseService, IEnderecoService
    {
        public EnderecoService(INotificador notificador) : base(notificador)
        {
        }

        public Task Adicionar(Endereco endereco)
        {
            throw new NotImplementedException();
        }

        public Task Atualizar(Endereco endereco)
        {
            throw new NotImplementedException();
        }

        public Task AtualizarEndereco(Endereco endereco)
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
