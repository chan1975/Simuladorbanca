using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRepositoryManager
    {
        IClienteRepository Cliente { get; }
        ICuentaRepository Cuenta { get; }
        IMovimientoRepository Movimiento { get; }
        Task SaveAsync();
    }
}
