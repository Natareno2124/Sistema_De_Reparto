using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Clases
{
    internal class CConexion
    {
        MySqlConnection conexion = new MySqlConnection(); //Estos datos cambian según la base de datos de cada uno
        static string servidor = "localhost";
        static string database = "sistemareparto";
        static string usuario = "root";
        static string password = "Infantes2124";
        static string puerto = "3306";

        string cadenaConexion = "server=" + servidor + ";database=" + database + ";user=" + usuario + ";password=" + password + ";port=" + puerto + ";SslMode=none;";

        public MySqlConnection establecerConexion(){



            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                MessageBox.Show("Conexión con la base de datos exitosa");
                return conexion;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);

            }
            return conexion;

        }

        public void cerrarConexion()
        {
            try
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                    MessageBox.Show("Conexión cerrada exitosamente");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cerrar la conexión: " + ex.Message);
            } 
            
        }
        

    }
}
 