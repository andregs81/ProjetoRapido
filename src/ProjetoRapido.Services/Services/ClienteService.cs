using AutoMapper;
using ProjetoRapido.Infra.Data.Entities;
using ProjetoRapido.Infra.Data.Uow;
using ProjetoRapido.Services.Interfaces;
using ProjetoRapido.Services.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoRapido.Services.Services
{
    public class ClienteService : ServiceBase, IClienteService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public ClienteService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public int Add(ClienteViewModel cliente)
        {
            var _cliente = _mapper.Map<ClienteViewModel, Cliente>(cliente);
            var endereco = _mapper.Map<ClienteViewModel, Endereco>(cliente);

            _cliente.Endereco = endereco;

            _uow.Clientes.Add(_cliente);
            return _uow.Commit();
        }

        public void Delete(ClienteViewModel cliente)
        {
            var clienteExcluir = _mapper.Map<ClienteViewModel, Cliente>(cliente);
            _uow.Clientes.Delete(clienteExcluir);
            _uow.Commit();
        }

        public void Delete(int id)
        {            
            _uow.Clientes.Delete(id);
            _uow.Commit();
        }

        public IEnumerable<ClienteViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(_uow.Clientes.GetAll());
        }

        public ClienteViewModel GetById(int id)
        {
            var cliente = _uow.Clientes.GetById(id);

            return  _mapper.Map<Cliente, ClienteViewModel>(cliente);

        }

        public void Update(ClienteViewModel cliente)
        {
            var _cliente = _mapper.Map<ClienteViewModel, Cliente>(cliente);
            var endereco = _mapper.Map<ClienteViewModel, Endereco>(cliente);

            _cliente.Endereco = endereco;

            _uow.Clientes.Update(_cliente);
            _uow.Commit();
        }

        public void Dispose()
        {
            _uow.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
