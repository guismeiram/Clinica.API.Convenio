using AutoMapper;
using DevIO.App.ViewModels;
using DevIO.Bussines.Models;

namespace DevIO.Api.Configuration
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        { 
            CreateMap<Convenio, ConvenioViewModel>().ReverseMap();
        }
    }
}