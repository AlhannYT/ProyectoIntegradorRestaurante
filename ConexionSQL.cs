public static class ConexionBD
{
    public static string Servidor = "ISASOPORTE02\\SQLSERVER2022";
    public static string BaseDeDatos = "RestauranteDB";
    public static string Usuario = "usuario";
    public static string Contrasena = "PGalliance99";

    public static string ConexionSQL()
    {
        return $"Server={Servidor};Database={BaseDeDatos};User Id={Usuario};Password={Contrasena};";
    }
}
