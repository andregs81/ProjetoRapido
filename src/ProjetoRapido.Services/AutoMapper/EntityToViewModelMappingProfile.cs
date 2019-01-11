using AutoMapper;
using ProjetoRapido.Infra.Data.Entities;
using ProjetoRapido.Services.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoRapido.Services.AutoMapper
{
    public class EntityToViewModelMappingProfile : Profile
    {
        public EntityToViewModelMappingProfile()
        {
            CreateMap<Cliente, ClienteViewModel>()
                .ForMember(c => c.Cep, opt => opt.MapFrom(e => e.Endereco.Cep))
                .ForMember(c => c.Logradouro, opt => opt.MapFrom(e => e.Endereco.Logradouro))
                .ForMember(c => c.Numero, opt => opt.MapFrom(e => e.Endereco.Numero))
                .ForMember(c => c.Bairro, opt => opt.MapFrom(e => e.Endereco.Bairro))
                .ForMember(c => c.Cidade, opt => opt.MapFrom(e => e.Endereco.Cidade))
                .ForMember(c => c.Estado, opt => opt.MapFrom(e => e.Endereco.Estado));
                

            CreateMap<Endereco, EnderecoViewModel>();
        }
    }
}
