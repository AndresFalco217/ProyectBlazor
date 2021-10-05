using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MITIENDA.Blazor.Data.Entities
{
    public class DetallesFactura
    {
        public int Id { get; set; }
        public int IdFactura { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public int Precio { get; set; }
        public virtual Producto Producto { get; set; }
        public virtual Factura Factura { get; set; }
    }
}
