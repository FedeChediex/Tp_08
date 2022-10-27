namespace Tp_08_Federico_Joaquin.Models;
using System.Data.SqlClient;
using Dapper;

public class BD
{
    private static string _connectionString = @"Server=DESKTOP-ODKGGP8\SQLEXPRESS;DataBase=Tp_08;Trusted_Connection=True";

    public static List<Categoria> ObtenerCategorias()
    {
        List<Categoria> lista = new List<Categoria>();
        string sql = "SELECT * FROM Categoria";
        using (SqlConnection bd = new SqlConnection(_connectionString))
        {

            lista = bd.Query<Categoria>(sql).ToList();
        }
        return lista;
    }

    public static List<Post> ObtenerPosts(int IdCategoria)
    {
        List<Post> ListaPosts = new List<Post>();
        string sql = "SELECT * FROM post WHERE IdPost = @uIdCategoria";
        using (SqlConnection bd = new SqlConnection(_connectionString))
        {
            ListaPosts = bd.Query<Post>(sql, new { uIdCategoria =  IdCategoria }).ToList();
        }
        return ListaPosts;
    }
   public static List<Comentario> ObtenerComentarios(int IdPost)
    {
        List<Comentario> ListaComentarios = new List<Comentario>();
        string sql = "SELECT * FROM post WHERE IdPost = @uIdPost";
        using (SqlConnection bd = new SqlConnection(_connectionString))
        {
            ListaComentarios= bd.Query<Comentario>(sql, new { uIdPost =  IdPost }).ToList();
        }
        return ListaComentarios;
    }

    //INGRESO USUARIO
    public static Usuario ObtenerUsuario(int IdUsuario)
        {
            Usuario user;
            string SQL = "SELECT * FROM Usuario WHERE IdUsuario = @pIdUsuario ";
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                user= db.QueryFirstOrDefault<Usuario>(SQL, new{pIdUsuario = IdUsuario});
            }
            return user;
        }

    public static List<Usuario> ObtenerUsuarios()
    {
        List<Usuario> lista = new List<Usuario>();
        string sql = "SELECT * FROM Usuario";
        using (SqlConnection bd = new SqlConnection(_connectionString))
        {

            lista = bd.Query<Usuario>(sql).ToList();
        }
        return lista;
    }
    //REGISTRO USUARIO
    public static void IngresarUsuario(Usuario usuario)
    {
        
        string sql = "INSERT INTO Usuario(Nombre, Contrasenia) VALUES (@pNombre, @pContrasenia)";
        using (SqlConnection bd = new SqlConnection(_connectionString))
        {

            bd.Execute(sql, new{pNombre = usuario.Nombre, pContrasenia = usuario.Contrasenia});
        }
    }
}