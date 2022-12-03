using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Bussines.Models.Validations
{
    public class EnderecoValidation : AbstractValidator<Endereco>
    {
        public EnderecoValidation()
        {
            RuleFor(c => c.Bairro)
               .NotEmpty().WithMessage("O campo {PropertyName} precisa do seu Bairro")
               .Length(2, 200).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(c => c.Cidade)
               .NotEmpty().WithMessage("O campo {PropertyName} precisa da sua Cidade")
               .Length(2, 200).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(c => c.Estado)
               .NotEmpty().WithMessage("O campo {PropertyName} precisa do seu Estado")
               .Length(2, 200).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

      

            RuleFor(c => c.Estado)
               .NotEmpty().WithMessage("O campo {PropertyName} precisa de um Estado")
               .Length(2, 200).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(c => c.Numero).NotEmpty().WithMessage("Numero da casa");
        }

        /*public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public string MedicoId { get; set; }*/
    }
}
