using Microsoft.EntityFrameworkCore;
using ProjetoRapido.Infra.Data.Entities;
using ProjetoRapido.Infra.Data.Entities.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoRapido.Infra.Data.Context.Repositorie
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public ClienteRepository(DbContext context) : base(context)
        {
        }
    }
}
