using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Bussines.Models.Validations
{
    public class ConvenioMapping : AbstractValidator<Convenio>
    {
        public ConvenioMapping()
        {
            RuleFor(c => c.Nome)
               .NotEmpty().WithMessage("O campo {PropertyName} precisa de Nome")
               .Length(2, 200).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(c => c.NCarteira)
               .NotEmpty().WithMessage("O campo {PropertyName} precisado Numero da Carteira")
               .Length(2, 200).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(c => c.Vencimento).NotEmpty().WithMessage("Data required");


        }

        /*public String Nome { get; set; }
        public String NCarteira { get; set; }
        public DateTime Vencimento { get; set; }*/
    }
}
