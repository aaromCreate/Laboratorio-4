using Npgsql;
using System;

public class Conexion
{
    private static string connectionString =
        "Host=localhost;Port=5432;Username=postgres;Password= 1234;Database=Laboratorio4";

    public static NpgsqlConnection ObtenerConexion()
    {
        NpgsqlConnection con = new NpgsqlConnection(connectionString);
        con.Open();
        return con;
    }
}