public class Usuario
{

    private int _idUsuario;
    private string _nombre;
    private string _contrasenia;

    public Usuario(string nombre, string contrasenia)
    {

        _contrasenia = contrasenia;
        _nombre = nombre;
        

    }
    public Usuario()
        {
            _nombre = "Todavia no hay un nombre ingresado";
            _contrasenia = "Todavia no hay un contraseña ingresado";

        }
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
    public string Contrasenia{
        
        get{
            return _contrasenia;
        }
        set{
            _contrasenia = value;
        }

    }
    
}
