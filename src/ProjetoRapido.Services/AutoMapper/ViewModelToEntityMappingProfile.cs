using AutoMapper;
using ProjetoRapido.Infra.Data.Entities;
using ProjetoRapido.Services.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoRapido.Services.AutoMapper
{
    public class ViewModelToEntityMappingProfile : Profile
    {
        public ViewModelToEntityMappingProfile()
        {
            CreateMap<ClienteViewModel, Cliente>();
            CreateMap<EnderecoViewModel, Endereco>();
        }
    }
}
