using ProjetoRapido.Infra.Data.Entities.Interfaces.Repositories;
using System;

namespace ProjetoRapido.Infra.Data.Uow
{
    public interface IUnitOfWork : IDisposable
    {
        IClienteRepository Clientes { get; }
        IEnderecoRepository Endereco { get; }

        int Commit();
    }
}
