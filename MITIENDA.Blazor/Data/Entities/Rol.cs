using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MITIENDA.Blazor.Data.Entities
{
    public class Rol
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; } //Metodo virtual es sobre escribir
    }
}
