using MITIENDA.Blazor.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MITIENDA.Blazor.Data.Services
{
    public class RolesServices
    {
        private readonly MiTiendaDbContext _context;

        public RolesServices(MiTiendaDbContext context)
        {
            _context = context;
        }

        public List<Rol> ListaRoles()
        {
            var lista = _context.Roles.ToList();
            return lista;
        }
    }
}
