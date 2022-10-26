public class Categoria
{

    private int _idUsuario;
    private string _nombre;
    private string _contraseña;


    public int IdUsuario{
        
        get{
            return _idUsuario;
        }
        set{
            _idUsuario = value;
        }

    }
    public string Nombre{
        
        get{
            return _nombre;
        }
        set{
            _nombre = value;
        }

    }
    public string Contraseña{
        
        get{
            return _contraseña;
        }
        set{
            _contraseña = value;
        }

    }
    
}
