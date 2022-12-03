using DevIO.Bussines.Interface;
using DevIO.Bussines.Models;
using DevIO.Bussines.Models.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Bussines.Services
{
    public class ClinicaService : BaseService, IClinicaService
    {
        private readonly IConsultaRepository _consultaRepository;
        private readonly IEnderecoRepository _enderecoRepository;
        private readonly IClinicaRepository _clinicaRepository;

        public ClinicaService(INotificador notificador, IConsultaRepository consultaRepository, IEnderecoRepository enderecoRepository, IClinicaRepository clinicaRepository) : base(notificador)
        {
            _consultaRepository = consultaRepository;
            _enderecoRepository = enderecoRepository;   
            _clinicaRepository = clinicaRepository;
        }

        public async Task Adicionar(Clinica clinica)
        {
            if (   !ExecutarValidacao(new ClinicaValidation(), clinica)
                || !ExecutarValidacao(new EnderecoValidation(), clinica.Endereco)
               ) return;

            if (_clinicaRepository.Buscar(f => f.Nome == clinica.Nome).Result.Any())
            {
                Notificar("Já existe um fornecedor com este documento infomado.");
                return;
            }

            await _clinicaRepository.Adicionar(clinica);
        }

        public Task AtualizaClinica(Clinica clinica)
        {
            throw new NotImplementedException();
        }

        public Task Atualizar(Clinica clinica)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task Remover(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
