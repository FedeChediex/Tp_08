namespace Tp_08_Federico_Joaquin.Models;
using System.Collections.Generic;
public class Comentario
{

    private int _idComentario;
    private string _contenido;
    private string _imagen;
    private DateTime _tiempo;
    private int _idPost;
    private int _idUsuario;
    public Comentario(string contenido, string imagen, DateTime tiempo, int idPost, int idUsuario)
    {
        _contenido = contenido;
        _imagen = imagen;
        _tiempo = tiempo;
        _idPost = idPost;
        _idUsuario = idUsuario;
    }
    public Comentario()
    {
        _contenido = "null";
        _imagen = "null";
        _tiempo = new DateTime();
        _idPost = 0;
        _idUsuario = 0;
    }


    public int IdComentario{
        
        get{
            return _idComentario;
        }
        set{
            _idComentario = value;
        }

    }
    public string Contenido{
        
        get{
            return _contenido;
        }
        set{
            _contenido = value;
        }

    }

    public string Imagen{
        
        get{
            return _imagen;
        }
        set{
            _imagen = value;
        }

    }
    public DateTime Tiempo{
        
        get{
            return _tiempo;
        }
        set{
            _tiempo = value;
        }

    }
     public int IdPost{
        
        get{
            return _idPost;
        }
        set{
            _idPost = value;
        }

    }
    public int IdUsuario{
        
        get{
            return _idUsuario;
        }
        set{
            _idUsuario= value;
        }

    }
    
   
    
}