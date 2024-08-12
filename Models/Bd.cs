using System.Data.SqlClient;
using Dapper;
public class Bd
{
    private static string _connectionString = @"Server=localhost;DataBase=JuegosOlimpicos;Trusted_Connection=True;";

    Using (SqlConnection Bd = new SqlConnection(_connectionString));

    public static void AgregarDeportista(Deportista dep)
    {
        string sql = "INSERT INTO Deportistas (Apellido,Nombre,FechaNacimiento,Foto,IdPais,IdDeporte) VALUES(@Apellido, @Nombre, @FechaNacimiento, @Foto, @IdPais, @IdDeporte)";
        using (SqlConnection Bd = new SqlConnection(_connectionString));
        {
            Bd.Execute(sql, new {apellido = dep.Apellido, nombre = dep.Nombre, FechaNacimiento = dep.FechaNacimiento, foto = dep.Foto, Idpais = dep.IdPais, IdDeporte = dep.IdDeporte});
        }

    }

    public static int EliminarDeportista (int idDeportista)
    {
        int RegistrosEliminados = 0;
        string sql = "DELETE *FROM Deportistas WHERE idDeportista = @idDeportistaEliminar";
        using (SqlConnection Bd = new SqlConnection(_connectionString));
        {
            RegistrosEliminados = Bd.Execute(sql, new {idDeportistaEliminar = idDeportista});
        }
        return RegistrosEliminados;

    }

    public static Deporte VerInfoDeporte (int idDeporte)
    {
        string sql = "SELECT * FROM Deportes WHERE IdDeporte = @idNueva";
        Deporte devolucion;
        using (SqlConnection Bd = new SqlConnection(_connectionString));
        {
            devolucion = Bd.Query<Deporte> (sql, new {idNueva = idDeporte});
        }
        return devolucion;
    }
    public static Pais VerInfoPais (int idPais)
    {
        string sql = "SELECT * FROM Paises WHERE IdPais = @idNueva";
        Pais devolucion;
       using (SqlConnection Bd = new SqlConnection(_connectionString));
        {
            devolucion = Bd.Query<Pais> (sql, new {idNueva = idPais});
        }
        return devolucion;
    }

     public static Deportista VerInfoDeportista (int idDeportista)
    {
        string sql = "SELECT * FROM Deportistas WHERE IdDeportista = @idNueva";
        Deportista devolucion;
       using (SqlConnection Bd = new SqlConnection(_connectionString));
        {
            devolucion = Bd.Query<Deportista> (sql, new {idNueva = idDeportista});
        }
        return devolucion;
    }
public List<Pais> ListarPaises()
{
     string sql = "SELECT * FROM Paises";
    List<Pais> devolucion;
       using (SqlConnection Bd = new SqlConnection(_connectionString));
        {
            devolucion = Bd.Query<Pais> (sql).ToList();
        }
        return devolucion;

}
public List<Deporte> ListarDeportes()
{
     string sql = "SELECT * FROM Deportes";
    List<Deporte> devolucion;
       using (SqlConnection Bd = new SqlConnection(_connectionString));
        {
            devolucion = Bd.Query<Deporte> (sql).ToList();
        }
        return devolucion;

}
public List<Deportista> ListarDeportistas()
{
     string sql = "SELECT * FROM Deportistas";
    List<Deportista> devolucion;
       using (SqlConnection Bd = new SqlConnection(_connectionString));
        {
            devolucion = Bd.Query<Deportista> (sql).ToList();
        }
        return devolucion;

}



}