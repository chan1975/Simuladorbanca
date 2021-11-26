using Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private RepositoryContext _repositoryContext;
        private IClienteRepository _clienteRepository;
        private ICuentaRepository _cuentaRepository;
        private IMovimientoRepository _movimientoRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public IClienteRepository Cliente
        {
            get
            {
                if (_clienteRepository == null)
                    _clienteRepository = new ClienteRepository(_repositoryContext);

                return _clienteRepository;

            }
        }
        public ICuentaRepository Cuenta
        {
            get
            {
                if (_cuentaRepository == null)
                    _cuentaRepository = new CuentaRepository(_repositoryContext);

                return _cuentaRepository;

            }
        }
        public IMovimientoRepository Movimiento
        {
            get
            {
                if (_movimientoRepository == null)
                    _movimientoRepository = new MovimientoRepository(_repositoryContext);

                return _movimientoRepository;

            }
        }

        public Task SaveAsync() => _repositoryContext.SaveChangesAsync();
    }
}
