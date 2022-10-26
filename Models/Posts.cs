namespace Tp_08_Federico_Joaquin.Models;

public class Post
{

    private int _idPost;
    private string _titulo;
    private string _imagen;
    private string _contenido;
   
    private int _idCategoria;


    public int IdPost{
        
        get{
            return _idPost;
        }
        set{
            _idPost = value;
        }

    }
    public string Titulo{
        
        get{
            return _titulo;
        }
        set{
            _titulo = value;
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
    public string Contenido{
        
        get{
            return _contenido;
        }
        set{
            _contenido = value;
        }

    }

    
    public int IdCategoria{
        
        get{
            return _idCategoria;
        }
        set{
            _idCategoria = value;
        }

    }
   
    
}