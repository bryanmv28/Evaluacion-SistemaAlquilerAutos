using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using SistemaAlquilerAutos.Config;
using SistemaAlquilerAutos.Models;

namespace SistemaAlquilerAutos.Controllers
{
    public class ContratoController
    {
        private readonly Conexion _conexion;

        public ContratoController()
        {
            _conexion = new Conexion();
        }

        public List<ContratoModel> Listar()
        {
            var lista = new List<ContratoModel>();
            try
            {
                using (MySqlConnection cn = (MySqlConnection)_conexion.AbrirConexion())
                {
                    string query = "SELECT * FROM contratos";
                    using (MySqlCommand cmd = new MySqlCommand(query, cn))
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new ContratoModel
                            {
                                ContratoId = Convert.ToInt32(dr["contrato_id"]),
                                ClienteId = Convert.ToInt32(dr["cliente_id"]),
                                VehiculoId = Convert.ToInt32(dr["vehiculo_id"]),
                                FechaInicio = Convert.ToDateTime(dr["fecha_inicio"]),
                                FechaFin = Convert.ToDateTime(dr["fecha_fin"]),
                                CostoTotal = Convert.ToDecimal(dr["costo_total"]),
                                Estado = dr["estado"].ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar contratos: " + ex.Message);
            }
            return lista;
        }

        public string Insertar(ContratoModel contrato)
        {
            try
            {
                using (MySqlConnection cn = (MySqlConnection)_conexion.AbrirConexion())
                {
                    string query = @"INSERT INTO contratos (cliente_id, vehiculo_id, fecha_inicio, fecha_fin, costo_total, estado)
                                    VALUES (@cliente, @vehiculo, @inicio, @fin, @costo, @estado)";
                    using (MySqlCommand cmd = new MySqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@cliente", contrato.ClienteId);
                        cmd.Parameters.AddWithValue("@vehiculo", contrato.VehiculoId);
                        cmd.Parameters.AddWithValue("@inicio", contrato.FechaInicio);
                        cmd.Parameters.AddWithValue("@fin", contrato.FechaFin);
                        cmd.Parameters.AddWithValue("@costo", contrato.CostoTotal);
                        cmd.Parameters.AddWithValue("@estado", contrato.Estado);
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

        public string Actualizar(ContratoModel contrato)
        {
            try
            {
                using (MySqlConnection cn = (MySqlConnection)_conexion.AbrirConexion())
                {
                    string query = @"UPDATE contratos SET 
                                    cliente_id = @cliente,
                                    vehiculo_id = @vehiculo,
                                    fecha_inicio = @inicio,
                                    fecha_fin = @fin,
                                    costo_total = @costo,
                                    estado = @estado
                                    WHERE contrato_id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@cliente", contrato.ClienteId);
                        cmd.Parameters.AddWithValue("@vehiculo", contrato.VehiculoId);
                        cmd.Parameters.AddWithValue("@inicio", contrato.FechaInicio);
                        cmd.Parameters.AddWithValue("@fin", contrato.FechaFin);
                        cmd.Parameters.AddWithValue("@costo", contrato.CostoTotal);
                        cmd.Parameters.AddWithValue("@estado", contrato.Estado);
                        cmd.Parameters.AddWithValue("@id", contrato.ContratoId);
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

        public string Eliminar(int contratoId)
        {
            try
            {
                using (MySqlConnection cn = (MySqlConnection)_conexion.AbrirConexion())
                {
                    string query = "DELETE FROM contratos WHERE contrato_id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@id", contratoId);
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