using ProjetoRapido.Infra.Data.Context;
using ProjetoRapido.Infra.Data.Context.Repositorie;
using ProjetoRapido.Infra.Data.Entities.Interfaces.Repositories;

namespace ProjetoRapido.Infra.Data.Uow
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ProjetoRapidoContext _context;

        public UnitOfWork(ProjetoRapidoContext context)
        {
            _context = context;
            Clientes = new ClienteRepository(_context);
            Endereco = new EnderecoRepository(_context);
        }

        public IClienteRepository Clientes { get; private set; }

        public IEnderecoRepository Endereco { get; private set; }

        public int Commit()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
