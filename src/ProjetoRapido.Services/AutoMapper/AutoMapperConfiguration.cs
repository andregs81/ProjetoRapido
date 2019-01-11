using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoRapido.Services.AutoMapper
{
    public class AutoMapperConfiguration
    {
        public static MapperConfiguration RegistrerMappings()
        {
            return new MapperConfiguration(ps =>
            {
                ps.AddProfile(new EntityToViewModelMappingProfile());
                ps.AddProfile(new ViewModelToEntityMappingProfile());
            });
        }
    }
}
