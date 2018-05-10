using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noriam.SOLID.Services.DTO
{
    public class PrecioDTO
    {
        public int IdCatPrecio { get; set; }
        public decimal PrecioCompra { get; set; }
        public DateTime FechaInicio { get; set; }
        public bool Activo { get; set; }
        public decimal PrecioVenta { get; set; }
        public DateTime FechaFin { get; set; }
    }
}
