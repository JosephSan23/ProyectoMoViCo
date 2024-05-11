using CapaDatos;
using CapaDatos.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CapaAdmin.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly ConexionContext _context;

        public UsuarioController(ConexionContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ListarUsuariosJson()
        {
            var usuarios = _context.Usuarios.ToList();
            return Json(usuarios);
        }
        //{
        //    private readonly UsuarioServices _usuarioService;

        //    public UsuarioController(UsuarioServices usuarioService)
        //    {
        //        _usuarioService = usuarioService;
        //    }

        //    public IActionResult Index()
        //    {
        //        var usuarios = _usuarioService.Listar();
        //        return View(usuarios);
        //    }
        //}
    }

}
