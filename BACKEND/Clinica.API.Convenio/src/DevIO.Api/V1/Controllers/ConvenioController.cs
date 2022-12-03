using AutoMapper;
using DevIO.Api.Controllers;
using DevIO.App.ViewModels;
using DevIO.Bussines.Interface;
using DevIO.Bussines.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevIO.Api.V1.Controllers
{
    [Route("api/clinica/convenio")]
    public class ConvenioController : MainController
    {
        private readonly IConvenioRepository _convenioRepository;
        private readonly IConvenioService _convenioService;
        private readonly IMapper _mapper;

        public ConvenioController(INotificador notificador, 
                                  IMapper mapper, 
                                  IConvenioRepository convenioRepository, 
                                  IConvenioService convenioService) : base(notificador)
        {
            _mapper = mapper;
            _convenioRepository = convenioRepository;
            _convenioService = convenioService;
        }

        [HttpGet]
        public async Task<IEnumerable<ConvenioViewModel>> ObterTodos()
        {
            return _mapper.Map<IEnumerable<ConvenioViewModel>>(await _convenioRepository.ObterTodos());
        }
        
        [HttpGet]
        [Route("ObterEnderecoPorId", Name = "ObterEnderecoPorId")]
        public async Task<ConvenioViewModel> ObterEnderecoPorId(string id)
        {
            var convenio = await ObterConvenio(id);

            //if (convenio == null) return NotFound();

            return convenio;
        }

        [HttpPost]
        public async Task<ActionResult<ConvenioViewModel>> Adicionar(ConvenioViewModel convenioViewModel)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            await _convenioService.Adicionar(_mapper.Map<Convenio>(convenioViewModel));

            return CustomResponse(convenioViewModel);
        }

        [HttpPut]
        [Route("ObterEnderecoPorId", Name = "ObterEnderecoPorId")]
        public async Task<ActionResult<ConvenioViewModel>> Atualizar(string id, ConvenioViewModel convenioViewModel)
        {
            if (id != convenioViewModel.id)
            {
                NotificarErro("O id informado não é o mesmo que foi passado na query");
                return CustomResponse(convenioViewModel);
            }

            var convenioAtualizacao = await ObterConvenio(id);

            if (!ModelState.IsValid) return CustomResponse(ModelState);

            convenioAtualizacao.id = convenioViewModel.id;
            convenioAtualizacao.Nome = convenioViewModel.Nome;
            convenioAtualizacao.Vencimento = convenioViewModel.Vencimento;
            convenioAtualizacao.NCarteira = convenioViewModel.NCarteira;

            await _convenioService.Atualizar(_mapper.Map<Convenio>(convenioViewModel));

            return CustomResponse(convenioViewModel);
        }

        [HttpDelete]
        [Route("ObterEnderecoPorId", Name = "ObterEnderecoPorId")]
        public async Task<ActionResult<ConvenioViewModel>> Excluir(string id)
         {
             var convenioViewModel = await ObterConvenio(id);

            // if (convenioViewModel == null) return NotFound();

             await _convenioService.Remover(id);

             return CustomResponse(convenioViewModel);
         }
        

        private async Task<ConvenioViewModel> ObterConvenio(string id)
        {
            return _mapper.Map<ConvenioViewModel>(await _convenioRepository.ObterPorId(id));
        }
    }
}
