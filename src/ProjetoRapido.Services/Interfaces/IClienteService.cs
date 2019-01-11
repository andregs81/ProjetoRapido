using ProjetoRapido.Services.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoRapido.Services.Interfaces
{
    public interface IClienteService : IServiceBase, IDisposable
    {
        int Add(ClienteViewModel cliente);
        void Update(ClienteViewModel cliente);
        void Delete(ClienteViewModel cliente);
        void Delete(int id);
        ClienteViewModel GetById(int id);
        IEnumerable<ClienteViewModel> GetAll();        
    }
}
