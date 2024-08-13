using System.Data.SqlClient;
using Dapper;
public static class Bd
{
    private static string _connectionString = @"Server=localhost;DataBase=JJOO;Trusted_Connection=True;";

    public static void AgregarDeportista(Deportista dep)
    {
        string sql = "INSERT INTO Deportistas (Apellido,Nombre,FechaNacimiento,Foto,IdPais,IdDeporte) VALUES(@Apellido, @Nombre, @FechaNacimiento, @Foto, @IdPais, @IdDeporte)";
        using (SqlConnection db = new SqlConnection(_connectionString))
        {
            db.Execute(sql, new { apellido = dep.Apellido, nombre = dep.Nombre, FechaNacimiento = dep.FechaNacimiento, foto = dep.Foto, Idpais = dep.IdPais, IdDeporte = dep.IdDeporte });
        }

    }

    public static int EliminarDeportista(int idDeportista)
    {
        int RegistrosEliminados = 0;
        string sql = "DELETE * FROM Deportistas WHERE idDeportista = @idDeportistaEliminar";
        using (SqlConnection db = new SqlConnection(_connectionString))
        {
            RegistrosEliminados = db.Execute(sql, new { idDeportistaEliminar = idDeportista });
        }
        return RegistrosEliminados;

    }

    public static Deporte VerInfoDeporte(int idDeporte)
    {
        string sql = "SELECT * FROM Deportes WHERE IdDeporte = @idNueva";
        Deporte devolucion;
        using (SqlConnection db = new SqlConnection(_connectionString))
        {
            devolucion = db.QueryFirstOrDefault<Deporte>(sql, new { idNueva = idDeporte });
        }
        return devolucion;
    }
    public static Pais VerInfoPais(int idPais)
    {
        string sql = "SELECT * FROM Paises WHERE IdPais = @idNueva";
        Pais devolucion;
        using (SqlConnection db = new SqlConnection(_connectionString))
        {
            devolucion = db.QueryFirstOrDefault<Pais>(sql, new { idNueva = idPais });
        }
        return devolucion;
    }

    public static Deportista VerInfoDeportista(int idDeportista)
    {
        string sql = "SELECT * FROM Deportistas WHERE IdDeportista = @idNueva";
        Deportista devolucion;
        using (SqlConnection db = new SqlConnection(_connectionString))
        {
            devolucion = db.QueryFirstOrDefault<Deportista>(sql, new { idNueva = idDeportista });
        }
        return devolucion;
    }
    public static List<Pais> ListarPaises()
    {
        string sql = "SELECT * FROM Paises";
        List<Pais> devolucion;
        using (SqlConnection db = new SqlConnection(_connectionString))
        {
            devolucion = db.Query<Pais>(sql).ToList();
        }
        return devolucion;

    }
    public static List<Deporte> ListarDeportes()
    {
        string sql = "SELECT * FROM Deportes";
        List<Deporte> devolucion;
        using (SqlConnection db = new SqlConnection(_connectionString))
        {
            devolucion = db.Query<Deporte>(sql).ToList();
        }
        return devolucion;

    }
    public static List<Deportista> ListarDeportistasPorDeporte(int idDeporte)
    {
        string sql = "SELECT * FROM Deportistas WHERE idDeporte = @idNueva ";
        List<Deportista> devolucion;
        using (SqlConnection db = new SqlConnection(_connectionString))
        {
            devolucion = db.Query<Deportista>(sql, new { idNueva = idDeporte }).ToList();
        }
        return devolucion;

    }
    public static List<Deportista> ListarDeportistasPorPais(int idPais)
    {
        string sql = "SELECT * FROM Deportistas WHERE idPais = @idNueva ";
        List<Deportista> devolucion;
        using (SqlConnection db = new SqlConnection(_connectionString))
        {
            devolucion = db.Query<Deportista>(sql, new { idNueva = idPais }).ToList();
        }
        return devolucion;

    }

}