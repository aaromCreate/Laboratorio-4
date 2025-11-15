using Npgsql;
using System;

public class Conexion
{
    private static string connectionString =
        "Host=localhost;Port=5432;Username=postgres;Password= USEN SUS CONTRASEÑAS;Database=farmacia_db;";

    public static NpgsqlConnection ObtenerConexion()
    {
        NpgsqlConnection con = new NpgsqlConnection(connectionString);
        con.Open();
        return con;
    }
}