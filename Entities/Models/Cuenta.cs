using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Cuenta
    {
        [Key]
        public int Id { get; set; }
        public int Numero { get; set; }
        public decimal Saldo { get; set; }
        [ForeignKey(nameof(Cliente))]
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public ICollection<Movimiento> Movimientos{ get; set; }
    }
}
