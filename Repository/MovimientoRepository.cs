using Contracts;
using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class MovimientoRepository : RepositoryBase<Movimiento>, IMovimientoRepository
    {
        public MovimientoRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }
        public void CreateMovimiento(int cuentaId, Movimiento movimiento)
        {
            movimiento.CuentaId = cuentaId;
            Create(movimiento);
        }

        public void DeleteMovimiento(Movimiento movimiento)
        {
            Delete(movimiento);
        }

        public async Task<Movimiento> GetMovimientoAsync(int cuentaId, int movimientoId, bool trackChanges)
        {
            return await FindByCondition(m => m.CuentaId == cuentaId && m.Id == movimientoId, trackChanges).SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<Movimiento>> GetMovimientosAsync(int cuentaId, bool trackChanges)
        {
            return await FindByCondition(m => m.CuentaId == cuentaId, trackChanges).ToListAsync();
        }
    }
}
