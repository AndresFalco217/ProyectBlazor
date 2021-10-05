using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MITIENDA.Blazor.Data.Entities
{
    public class Factura
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public DateTime Fecha { get; set; }
        public int IdCliente { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual ICollection<DetallesFactura> DetallesFacturas { get; set; }
    }
}
