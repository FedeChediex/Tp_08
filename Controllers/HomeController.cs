using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Tp_08_Federico_Joaquin.Models;

namespace Tp_08_Federico_Joaquin.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    public IActionResult Registrarse()
    {

        return View();
    }
    public IActionResult InicioSesion(Usuario usuario)
    {

        return View();
    }
    public IActionResult GuardarUsuario(string Nombre, string Contrasenia)
    {
        Usuario usuario = new Usuario(Nombre,Contrasenia);
        BD.IngresarUsuario(usuario);

        return RedirectToAction("InicioSesion");
    }
    public IActionResult ValidarUsuario(string Nombre, string Contrasenia)
    {
        
        foreach(Usuario user in BD.ObtenerUsuarios())
        {
            if (user.Nombre == Nombre)
            {
                if(user.Contrasenia == Contrasenia){
                    return RedirectToAction("Index", new{IdUsuario = user.IdUsuario});
                } 
            }
        }
        return View("InicioSesion");
        
    }

        
    
    
    public IActionResult Index(int IdUsuario)
    {
        ViewBag.categorias = BD.ObtenerCategorias();
        ViewBag.Usuario = BD.ObtenerUsuario(IdUsuario);
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult Posts(int IdCategoria)
    {
        ViewBag.posts = BD.ObtenerPosts(IdCategoria);
        return View();
    }
     public IActionResult VerPost(int IdPost)
    {
        ViewBag.posts = BD.ObtenerComentarios(IdPost);
        return View();
    }

    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
