using MITIENDA.Blazor.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MITIENDA.Blazor.Data.Services
{
    public class UsuariosServices
    {
        private readonly MiTiendaDbContext _context;

        public UsuariosServices(MiTiendaDbContext context)
        {
            _context = context;
        }
        public MsgResult Registrar(RegistroUsuarioModel usuario)
        {
            var res = new MsgResult();
            _context.Usuarios.Add(usuario);

            try
            {
                _context.SaveChanges();

                res.IsSuccess = true;
                res.Message = "Usuario registrado correctamente";
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = "Error al registrar el usuario";
                res.Error = ex;
            }
            return res;
        }
    }
}
