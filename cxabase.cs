// Cxabase.cs
using System;
using System.Data.SqlClient;
using System.Data;

namespace CUENTAS_POR_PAGAR_JABES_23EIST6015
{
    internal class Cxabase
    {
        private string cadenaConexion;

        // Constructor que recibe la cadena de conexión
        public Cxabase(string cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
        }

        // Método para ejecutar una consulta SQL y devolver los resultados
        public void EjecutarConsulta()
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();
                    Console.WriteLine("Conexión abierta correctamente.");

                    string consultaSql = "SELECT * FROM tu_tabla";
                    using (SqlCommand comando = new SqlCommand(consultaSql, conexion))
                    {
                        using (SqlDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                Console.WriteLine($"Columna1: {lector["Columna1"]}, Columna2: {lector["Columna2"]}");
                            }
                        }
                    }
                }
                catch (SqlException sqlEx)
                {
                    Console.WriteLine($"Error de SQL: {sqlEx.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ocurrió un error: {ex.Message}");
                }
                finally
                {
                    if (conexion.State == ConnectionState.Open)
                    {
                        conexion.Close();
                        Console.WriteLine("Conexión cerrada.");
                    }
                }
            }
        }
    }
}
