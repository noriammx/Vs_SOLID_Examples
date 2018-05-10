using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noriam.SOLID.Services.DTO
{
    public class ProductoDTO
    {
        public int IdCatProduco { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public int Existencia { get; set; }
        public PrecioDTO Precio { get; set; }

    }
}
