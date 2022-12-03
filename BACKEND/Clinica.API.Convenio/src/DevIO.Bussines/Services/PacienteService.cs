using DevIO.Bussines.Interface;
using DevIO.Bussines.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Bussines.Services
{
    public class PacienteService : BaseService, IPacienteService
    {
        public PacienteService(INotificador notificador) : base(notificador)
        {
        }

        public Task Adicionar(Paciente paciente)
        {
            throw new NotImplementedException();
        }

        public Task Atualizar(Paciente paciente)
        {
            throw new NotImplementedException();
        }

        public Task AtualizarPaciente(Paciente paciente)
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
