using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Bussines.Models
{
    public class TipoPagamento : Entity
    {
        public Pagamento Pagamentos { get; set; }
        public Convenio Convenios { get; set; }

        public virtual List<PacienteTipoPagamento> PacienteTipoPagamentos { get; set; }

    }
}
