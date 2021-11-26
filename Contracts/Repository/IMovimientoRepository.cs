using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IMovimientoRepository
    {
        Task<IEnumerable<Movimiento>> GetMovimientosAsync(int cuentaId, bool trackChanges);
        Task<Movimiento> GetMovimientoAsync(int cuentaId, int movimientoId, bool trackChanges);
        void CreateMovimiento(int cuentaId, Movimiento movimiento);
        void DeleteMovimiento(Movimiento movimiento);
    }
}
