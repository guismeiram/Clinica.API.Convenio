using DevIO.Bussines.Models.Validations.Documentos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Bussines.Models.Validations
{
    public class ClinicaValidation : AbstractValidator<Clinica>
    {
        public ClinicaValidation()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa de um Nome")
                .Length(2, 200).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");
            
        }
        /* // relacionamentos
        public virtual List<Consulta> Consultas { get; set; }

        public virtual List<TelefoneClinica> TelefoneClinicas { get; set; }

        public virtual Endereco Endereco { get; set; }*/
    }
}
