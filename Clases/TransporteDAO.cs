using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace WinFormsApp1.Clases
{
    public class VehiculosDAO
    {
        private CConexion conexion = new CConexion();

        // mostrar
        public DataTable ObtenerVehiculos() {
            using (MySqlConnection conn = conexion.establecerConexion()){
                string query = @"
            SELECT 
                v.iD_Placa,
                v.marca,
                v.modelo,
                v.color,
                v.capacidad,
                v.id_Sucursal,
                v.id_tipo,          
                v.id_estado,        
                tv.nombreTipo   AS tipoVehiculo,
                ev.estadoVehiculo AS estadoVehiculo
            FROM Vehiculos v
            INNER JOIN tipoVehiculo tv ON v.id_tipo = tv.idTipo
            INNER JOIN estadoVehiculo ev ON v.id_estado = ev.idEstado";

                MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conn);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                return tabla;
            }
        }

        // agregar
        public void InsertarVehiculo(int placa, string marca, string modelo, string color, string capacidad, int idSucursal, int idTipo, int idEstado){
            if (placa <= 0)
                throw new ArgumentException("La placa debe ser un número positivo.");
            if (string.IsNullOrWhiteSpace(marca))
                throw new ArgumentException("La marca es obligatoria.");
            if (string.IsNullOrWhiteSpace(modelo))
                throw new ArgumentException("El modelo es obligatorio.");
            if (string.IsNullOrWhiteSpace(color))
                throw new ArgumentException("El color es obligatorio.");
            if (string.IsNullOrWhiteSpace(capacidad))
                throw new ArgumentException("La capacidad es obligatoria.");
            if (idSucursal <= 0)
                throw new ArgumentException("El ID de la sucursal debe ser válido.");
            if (idTipo <= 0)
                throw new ArgumentException("El ID del tipo debe ser válido.");
            if (idEstado <= 0)
                throw new ArgumentException("El ID del estado debe ser válido.");

            using (MySqlConnection conn = conexion.establecerConexion()) {
                if (conn == null)
                    throw new Exception("No se pudo establecer conexión con la base de datos.");

                string checkQuery = "SELECT COUNT(*) FROM Vehiculos WHERE iD_Placa = @placa";
                using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@placa", placa);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count > 0)
                        throw new ArgumentException("La placa ya existe en la base de datos.");
                }

                string query = @"INSERT INTO Vehiculos (iD_Placa, marca, modelo, color, capacidad, id_Sucursal, id_tipo, id_estado)
                         VALUES (@placa, @marca, @modelo, @color, @capacidad, @idSucursal, @idTipo, @idEstado)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn)){
                    cmd.Parameters.AddWithValue("@placa", placa);
                    cmd.Parameters.AddWithValue("@marca", marca);
                    cmd.Parameters.AddWithValue("@modelo", modelo);
                    cmd.Parameters.AddWithValue("@color", color);
                    cmd.Parameters.AddWithValue("@capacidad", capacidad);
                    cmd.Parameters.AddWithValue("@idSucursal", idSucursal);
                    cmd.Parameters.AddWithValue("@idTipo", idTipo);
                    cmd.Parameters.AddWithValue("@idEstado", idEstado);

                    cmd.ExecuteNonQuery();
                }
            }
        }


        // editar
        public void ModificarVehiculo(int placa, string marca, string modelo, string color, string capacidad, int idSucursal, int idTipo, int idEstado){
            try{
                using (MySqlConnection conn = conexion.establecerConexion()){
                    string query = @"UPDATE Vehiculos 
                             SET marca=@marca, modelo=@modelo, color=@color, capacidad=@capacidad, 
                                 id_Sucursal=@idSucursal, id_tipo=@idTipo, id_estado=@idEstado
                             WHERE iD_Placa=@placa";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn)){
                        cmd.Parameters.AddWithValue("@placa", placa);
                        cmd.Parameters.AddWithValue("@marca", marca);
                        cmd.Parameters.AddWithValue("@modelo", modelo);
                        cmd.Parameters.AddWithValue("@color", color);
                        cmd.Parameters.AddWithValue("@capacidad", capacidad);
                        cmd.Parameters.AddWithValue("@idSucursal", idSucursal);
                        cmd.Parameters.AddWithValue("@idTipo", idTipo);
                        cmd.Parameters.AddWithValue("@idEstado", idEstado);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al actualizar el vehículo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // eliminar
        public void EliminarVehiculo(int placa){
            using (MySqlConnection conn = conexion.establecerConexion()){
                string query = "DELETE FROM Vehiculos WHERE iD_Placa=@placa";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@placa", placa);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
