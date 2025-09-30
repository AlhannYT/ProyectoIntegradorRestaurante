public static class ConexionBD
{
    public static string Servidor = "ALHANNYT-LAPTOP\\ALHANNLAPTOPSQL";
    public static string BaseDeDatos = "RestauranteDB";
    public static string Usuario = "sa";
    public static string Contrasena = "1234";

    public static string ConexionSQL()
    {
        return $"Server={Servidor};Database={BaseDeDatos};User Id={Usuario};Password={Contrasena};";
    }
}
