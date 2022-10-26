namespace Tp_08_Federico_Joaquin.Models;
using System.Data.SqlClient;
using Dapper;

public class BD
{
    private static string _connectionString = @"Server=A-PHZ2-AMI-013;DataBase=Tp_08;Trusted_Connection=True";

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
}