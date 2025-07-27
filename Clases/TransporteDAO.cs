using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace WinFormsApp1.Clases
{
    public class VehiculosDAO
    {
        private CConexion conexion = new CConexion();

        // mostrar
        public DataTable ObtenerVehiculos()
        {
            using (MySqlConnection conn = conexion.establecerConexion())
            {
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
        public void InsertarVehiculo(int placa, string marca, string modelo, string color, string capacidad, int idSucursal, int idTipo, int idEstado)
        {
            using (MySqlConnection conn = conexion.establecerConexion())
            {
                string query = @"INSERT INTO Vehiculos (iD_Placa, marca, modelo, color, capacidad, id_Sucursal, id_tipo, id_estado)
                                 VALUES (@placa, @marca, @modelo, @color, @capacidad, @idSucursal, @idTipo, @idEstado)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
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
        public void ModificarVehiculo(int placa, string marca, string modelo, string color, string capacidad, int idSucursal, int idTipo, int idEstado)
        {
            try
            {
                using (MySqlConnection conn = conexion.establecerConexion())
                {
                    string query = @"UPDATE Vehiculos 
                             SET marca=@marca, modelo=@modelo, color=@color, capacidad=@capacidad, 
                                 id_Sucursal=@idSucursal, id_tipo=@idTipo, id_estado=@idEstado
                             WHERE iD_Placa=@placa";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
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
        public void EliminarVehiculo(int placa)
        {
            using (MySqlConnection conn = conexion.establecerConexion())
            {
                string query = "DELETE FROM Vehiculos WHERE iD_Placa=@placa";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@placa", placa);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
