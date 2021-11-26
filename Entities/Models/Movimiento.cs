using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Movimiento
    {
        [Key]
        public int Id { get; set; }
        public string Tipo { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Valor { get; set; }
        [ForeignKey(nameof(Cuenta))]
        public int CuentaId { get; set; }
        public Cuenta Cuenta { get; set; }

    }
}
