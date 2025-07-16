using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using SistemaAlquilerAutos.Config;
using SistemaAlquilerAutos.Models;

namespace SistemaAlquilerAutos.Controllers
{
    public class VehiculoController
    {
        private readonly Conexion _conexion;

        public VehiculoController()
        {
            _conexion = new Conexion();
        }

        public List<VehiculoModel> Listar()
        {
            var lista = new List<VehiculoModel>();
            try
            {
                using (MySqlConnection cn = (MySqlConnection)_conexion.AbrirConexion())
                {
                    string query = "SELECT * FROM vehiculos";
                    using (MySqlCommand cmd = new MySqlCommand(query, cn))
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new VehiculoModel
                            {
                                VehiculoId = Convert.ToInt32(dr["vehiculo_id"]),
                                Marca = dr["marca"].ToString(),
                                Modelo = dr["modelo"].ToString(),
                                Placa = dr["placa"].ToString(),
                                Anio = Convert.ToInt32(dr["anio"]),
                                TipoVehiculo = dr["tipo_vehiculo"]?.ToString(),
                                Estado = dr["estado"].ToString(),
                                PrecioDiario = Convert.ToDecimal(dr["precio_diario"])
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar vehículos: " + ex.Message);
            }
            return lista;
        }

        public string Insertar(VehiculoModel vehiculo)
        {
            try
            {
                using (MySqlConnection cn = (MySqlConnection)_conexion.AbrirConexion())
                {
                    string query = @"INSERT INTO vehiculos (marca, modelo, placa, anio, tipo_vehiculo, estado, precio_diario)
                                    VALUES (@marca, @modelo, @placa, @anio, @tipo, @estado, @precio)";
                    using (MySqlCommand cmd = new MySqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@marca", vehiculo.Marca);
                        cmd.Parameters.AddWithValue("@modelo", vehiculo.Modelo);
                        cmd.Parameters.AddWithValue("@placa", vehiculo.Placa);
                        cmd.Parameters.AddWithValue("@anio", vehiculo.Anio);
                        cmd.Parameters.AddWithValue("@tipo", vehiculo.TipoVehiculo);
                        cmd.Parameters.AddWithValue("@estado", vehiculo.Estado);
                        cmd.Parameters.AddWithValue("@precio", vehiculo.PrecioDiario);
                        int filas = cmd.ExecuteNonQuery();
                        return filas > 0 ? "ok" : "error";
                    }
                }
            }
            catch (Exception ex)
            {
                return "error: " + ex.Message;
            }
        }

        public string Actualizar(VehiculoModel vehiculo)
        {
            try
            {
                using (MySqlConnection cn = (MySqlConnection)_conexion.AbrirConexion())
                {
                    string query = @"UPDATE vehiculos SET 
                                    marca = @marca,
                                    modelo = @modelo,
                                    placa = @placa,
                                    anio = @anio,
                                    tipo_vehiculo = @tipo,
                                    estado = @estado,
                                    precio_diario = @precio
                                    WHERE vehiculo_id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@marca", vehiculo.Marca);
                        cmd.Parameters.AddWithValue("@modelo", vehiculo.Modelo);
                        cmd.Parameters.AddWithValue("@placa", vehiculo.Placa);
                        cmd.Parameters.AddWithValue("@anio", vehiculo.Anio);
                        cmd.Parameters.AddWithValue("@tipo", vehiculo.TipoVehiculo);
                        cmd.Parameters.AddWithValue("@estado", vehiculo.Estado);
                        cmd.Parameters.AddWithValue("@precio", vehiculo.PrecioDiario);
                        cmd.Parameters.AddWithValue("@id", vehiculo.VehiculoId);
                        int filas = cmd.ExecuteNonQuery();
                        return filas > 0 ? "ok" : "error";
                    }
                }
            }
            catch (Exception ex)
            {
                return "error: " + ex.Message;
            }
        }

        public string Eliminar(int vehiculoId)
        {
            try
            {
                using (MySqlConnection cn = (MySqlConnection)_conexion.AbrirConexion())
                {
                    string query = "DELETE FROM vehiculos WHERE vehiculo_id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@id", vehiculoId);
                        int filas = cmd.ExecuteNonQuery();
                        return filas > 0 ? "ok" : "error";
                    }
                }
            }
            catch (Exception ex)
            {
                return "error: " + ex.Message;
            }
        }
    }
}