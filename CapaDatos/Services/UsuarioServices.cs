using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Services
{
    public class UsuarioServices
    {
        private readonly ConexionContext _context;

        public UsuarioServices(ConexionContext context)
        {
            _context = context;
        }

        public List<Usuario> Listar()
        {
            return _context.Usuarios.ToList();
        }
    }
}
