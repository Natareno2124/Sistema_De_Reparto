using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;  // Para MySQL
using System.Data;            


// Referencia: https://www.youtube.com/watch?v=Mu1KfXldZCc
//logica del crud

namespace WinFormsApp1.Clases
{
    public class PilotosDAO
    {
        private CConexion conexion = new CConexion();

        // mostrar
        public DataTable ObtenerPilotos()
        {
            using (MySqlConnection conn = conexion.establecerConexion())
            {
                string query = "SELECT id, nombres, apellidos, fechaNaci, sexo, tipoLicencia, idSucursal FROM Conductores";
                MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conn);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                return tabla;
            }
        }

        // agregar
        public void InsertarPiloto(string nombres, string apellidos, DateTime fechaNaci, string sexo, string tipoLicencia, int idSucursal){
            if (string.IsNullOrWhiteSpace(nombres) || string.IsNullOrWhiteSpace(apellidos))
                throw new ArgumentException("Nombres y apellidos son obligatorios.");

            if (fechaNaci > DateTime.Now)
                throw new ArgumentException("La fecha de nacimiento no puede ser en el futuro.");

            if (sexo != "M" && sexo != "F")
                throw new ArgumentException("Sexo inválido.");

            if (string.IsNullOrWhiteSpace(tipoLicencia))
                throw new ArgumentException("El tipo de licencia es obligatorio.");

            if (idSucursal <= 0)
                throw new ArgumentException("Sucursal inválida.");

            using (MySqlConnection conn = conexion.establecerConexion()) {
                if (conn == null)
                    return;

                string query = @"INSERT INTO Conductores 
            (nombres, apellidos, fechaNaci, sexo, tipoLicencia, idSucursal) 
            VALUES (@nombres, @apellidos, @fechaNaci, @sexo, @tipoLicencia, @idSucursal)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombres", nombres);
                    cmd.Parameters.AddWithValue("@apellidos", apellidos);
                    cmd.Parameters.AddWithValue("@fechaNaci", fechaNaci);
                    cmd.Parameters.AddWithValue("@sexo", sexo);
                    cmd.Parameters.AddWithValue("@tipoLicencia", tipoLicencia);
                    cmd.Parameters.AddWithValue("@idSucursal", idSucursal);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        // modificar
        public void ModificarPiloto(int id, string nombres, string apellidos, DateTime fechaNaci, string sexo, string tipoLicencia, int idSucursal)
        {
            using (MySqlConnection conn = conexion.establecerConexion())
            {
                string query = "UPDATE Conductores SET nombres=@nombres, apellidos=@apellidos, fechaNaci=@fechaNaci, sexo=@sexo, tipoLicencia=@tipoLicencia, idSucursal=@idSucursal WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nombres", nombres);
                cmd.Parameters.AddWithValue("@apellidos", apellidos);
                cmd.Parameters.AddWithValue("@fechaNaci", fechaNaci);
                cmd.Parameters.AddWithValue("@sexo", sexo);
                cmd.Parameters.AddWithValue("@tipoLicencia", tipoLicencia);
                cmd.Parameters.AddWithValue("@idSucursal", idSucursal);
                cmd.ExecuteNonQuery();
            }
        }

        // eliminar
        public void EliminarPiloto(int id)
        {
            using (MySqlConnection conn = conexion.establecerConexion())
            {
                string query = "DELETE FROM Conductores WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
