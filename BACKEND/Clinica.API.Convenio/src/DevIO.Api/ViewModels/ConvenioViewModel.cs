using System.ComponentModel.DataAnnotations;

namespace DevIO.App.ViewModels
{
    public class ConvenioViewModel 
    {
        public string id { get; set; }
        public string Nome { get; set; }
        public string NCarteira { get; set; }
        public DateTime Vencimento { get; set; }
    }
}