using DevIO.Bussines.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Bussines.Interface
{
    public interface IMedicoRepository : IRepository<Medico>
    {
        Task<Medico> ObterMedicoConsultasEspecialidades(String id);
        Task<Medico> ObterMedicoConsultas(String id);
        Task<Medico> ObterMedicoEspecialidades(String id);


    }
}
