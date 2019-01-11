using Microsoft.EntityFrameworkCore;
using ProjetoRapido.Infra.Data.Entities;
using ProjetoRapido.Infra.Data.Entities.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoRapido.Infra.Data.Context.Repositorie
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(DbContext context) : base(context)
        {
        }
    }
}
