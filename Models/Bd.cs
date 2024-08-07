using System.Data.SqlClient;
using Dapper;
public class Bd
{
    private static string _connectionString = @"Server=localhost;DataBase=JuegosOlimpicos;Trusted_Connection=True;";

    Using (SqlConnection Bd = new SqlConnection(_connectionString));

    public static void AgregarDeportista(Deportista dep)
    {
        string sql = "INSERT INTO Deportistas (BApellido,BNombre,BFechaNacimiento,BFoto) VALUES(@Apellido, @Nombre, @FechaNacimiento, @Foto)";
        dep = Bd.Execute<Deportista>(sql).ToList();

    }
}