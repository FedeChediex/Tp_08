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
    ///////////////////////////////////////////////////////////////////////////////////////////////
    //INICIO DE SESION Y REGISTRO
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
        
        foreach(Usuario user in BD.ListarUsuarios())
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

    ///////////////////////////////////////////////////////////////////////////////////////////////

    //PAGINA PRINCIPAL
    public IActionResult Index(int IdUsuario)
    {
        ViewBag.categorias = BD.ListarCategorias();
        ViewBag.IdUsuario = IdUsuario;
        
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    //PAGINA PUBLICACIONES
    public IActionResult Publicaciones(int IdCategoria, int IdUsuario)
    {
        ViewBag.IdCategoria = IdCategoria;
        ViewBag.IdUsuario = IdUsuario;
        ViewBag.posts = BD.ListarPosts(IdCategoria);
        return View("VerPublicaciones");
    }
     public IActionResult VerPost(int IdPost)
    {
        ViewBag.posts = BD.ListarComentarios(IdPost);
        return View("Publicacion");
    }
     public IActionResult VerCategoria(int IdCategoria)
    {
        
        return RedirectToAction("Publicaciones");
    }

     public IActionResult CrearPost(int IdCategoria, int IdUsuario)
    {
        ViewBag.IdCategoria = IdCategoria;
        ViewBag.IdUsuario = IdUsuario;
        return View("AgregarPost");
    }
    public IActionResult GuardarPost(string Titulo, string Imagen, string Contenido, int IdCategoria, int IdUsuario)
    {
        System.Console.WriteLine(IdCategoria);
        Post post = new Post (Titulo, Imagen, Contenido, IdCategoria, IdUsuario);
        BD.AgregarPost(post);
        
        return RedirectToAction("Publicaciones");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
