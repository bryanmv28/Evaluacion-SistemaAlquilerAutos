using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using SistemaAlquilerAutos.Config;
using SistemaAlquilerAutos.Models;

namespace SistemaAlquilerAutos.Controllers
{
    public class PagoController
    {
        private readonly Conexion _conexion;

        public PagoController()
        {
            _conexion = new Conexion();
        }

        public List<PagoModel> Listar()
        {
            var lista = new List<PagoModel>();
            try
            {
                using (MySqlConnection cn = (MySqlConnection)_conexion.AbrirConexion())
                {
                    string query = "SELECT * FROM pagos";
                    using (MySqlCommand cmd = new MySqlCommand(query, cn))
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new PagoModel
                            {
                                PagoId = Convert.ToInt32(dr["pago_id"]),
                                ContratoId = Convert.ToInt32(dr["contrato_id"]),
                                Monto = Convert.ToDecimal(dr["monto"]),
                                FechaPago = Convert.ToDateTime(dr["fecha_pago"]),
                                MetodoPago = dr["metodo_pago"]?.ToString(),
                                Estado = dr["estado"].ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar pagos: " + ex.Message);
            }
            return lista;
        }

        public string Insertar(PagoModel pago)
        {
            try
            {
                using (MySqlConnection cn = (MySqlConnection)_conexion.AbrirConexion())
                {
                    string query = @"INSERT INTO pagos (contrato_id, monto, fecha_pago, metodo_pago, estado)
                                    VALUES (@contrato, @monto, @fecha, @metodo, @estado)";
                    using (MySqlCommand cmd = new MySqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@contrato", pago.ContratoId);
                        cmd.Parameters.AddWithValue("@monto", pago.Monto);
                        cmd.Parameters.AddWithValue("@fecha", pago.FechaPago);
                        cmd.Parameters.AddWithValue("@metodo", pago.MetodoPago);
                        cmd.Parameters.AddWithValue("@estado", pago.Estado);
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

        public string Actualizar(PagoModel pago)
        {
            try
            {
                using (MySqlConnection cn = (MySqlConnection)_conexion.AbrirConexion())
                {
                    string query = @"UPDATE pagos SET 
                                    contrato_id = @contrato,
                                    monto = @monto,
                                    fecha_pago = @fecha,
                                    metodo_pago = @metodo,
                                    estado = @estado
                                    WHERE pago_id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@contrato", pago.ContratoId);
                        cmd.Parameters.AddWithValue("@monto", pago.Monto);
                        cmd.Parameters.AddWithValue("@fecha", pago.FechaPago);
                        cmd.Parameters.AddWithValue("@metodo", pago.MetodoPago);
                        cmd.Parameters.AddWithValue("@estado", pago.Estado);
                        cmd.Parameters.AddWithValue("@id", pago.PagoId);
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

        public string Eliminar(int pagoId)
        {
            try
            {
                using (MySqlConnection cn = (MySqlConnection)_conexion.AbrirConexion())
                {
                    string query = "DELETE FROM pagos WHERE pago_id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@id", pagoId);
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