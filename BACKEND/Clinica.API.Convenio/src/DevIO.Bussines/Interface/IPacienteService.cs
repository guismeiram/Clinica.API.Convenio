using DevIO.Bussines.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Bussines.Interface
{
    public interface IPacienteService : IDisposable
    {
        Task Adicionar(Paciente paciente);
        Task Atualizar(Paciente paciente);
        Task Remover(String id);
        Task AtualizarPaciente(Paciente paciente);
    }
}
