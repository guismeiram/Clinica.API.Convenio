using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Bussines.Models
{
    public class Endereco : Entity
    {
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public string MedicoId { get; set; }
        public string EnderecoId { get; set; }

        // relacionamentos
        public virtual Medico Medico { get; set; }

        public virtual Clinica Clinica { get; set; }


    }
}
