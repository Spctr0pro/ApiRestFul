using Microsoft.AspNetCore.Mvc;
using PeliculasWeb.Models;
using PeliculasWeb.Repositorio.IRepositorio;
using PeliculasWeb.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeliculasWeb.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly IUsuarioRepositorio _repoUsuario;

        public UsuariosController(IUsuarioRepositorio repoUsuario)
        {
            _repoUsuario = repoUsuario;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new UsuarioU() { });
        }

        [HttpGet]
        public async Task<IActionResult> GetTodosUsuarios()
        {
            return Json(new { data = await _repoUsuario.GetTodoAsync(CT.RutaUsuariosApi)});
        }
        
    }
}
