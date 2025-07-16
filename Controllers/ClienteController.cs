using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using SistemaAlquilerAutos.Config;
using SistemaAlquilerAutos.Models;

namespace SistemaAlquilerAutos.Controllers
{
    public class ClienteController
    {
        private readonly Conexion _conexion;

        public ClienteController()
        {
            _conexion = new Conexion();
        }

        public List<ClienteModel> Listar()
        {
            var lista = new List<ClienteModel>();
            try
            {
                using (MySqlConnection cn = (MySqlConnection)_conexion.AbrirConexion())
                {
                    string query = "SELECT * FROM clientes";
                    using (MySqlCommand cmd = new MySqlCommand(query, cn))
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new ClienteModel
                            {
                                ClienteId = Convert.ToInt32(dr["cliente_id"]),
                                Nombre = dr["nombre"].ToString(),
                                Apellido = dr["apellido"].ToString(),
                                cedula = dr["cedula"].ToString(),
                                Telefono = dr["telefono"]?.ToString(),
                                Email = dr["email"]?.ToString(),
                                Direccion = dr["direccion"]?.ToString(),
                                FechaRegistro = Convert.ToDateTime(dr["fecha_registro"])
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar clientes: " + ex.Message);
            }
            return lista;
        }

        public string Insertar(ClienteModel cliente)
        {
            try
            {
                using (MySqlConnection cn = (MySqlConnection)_conexion.AbrirConexion())
                {
                    string query = @"INSERT INTO clientes (nombre, apellido, cedula, telefono, email, direccion)
                                    VALUES (@nombre, @apellido, @cedula, @telefono, @email, @direccion)";
                    using (MySqlCommand cmd = new MySqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", cliente.Nombre);
                        cmd.Parameters.AddWithValue("@apellido", cliente.Apellido);
                        cmd.Parameters.AddWithValue("@cedula", cliente.cedula);
                        cmd.Parameters.AddWithValue("@telefono", cliente.Telefono);
                        cmd.Parameters.AddWithValue("@email", cliente.Email);
                        cmd.Parameters.AddWithValue("@direccion", cliente.Direccion);
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

        public string Actualizar(ClienteModel cliente)
        {
            try
            {
                using (MySqlConnection cn = (MySqlConnection)_conexion.AbrirConexion())
                {
                    string query = @"UPDATE clientes SET 
                                    nombre = @nombre,
                                    apellido = @apellido,
                                    cedula = @cedula,
                                    telefono = @telefono,
                                    email = @email,
                                    direccion = @direccion
                                    WHERE cliente_id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", cliente.Nombre);
                        cmd.Parameters.AddWithValue("@apellido", cliente.Apellido);
                        cmd.Parameters.AddWithValue("@cedula", cliente.cedula);
                        cmd.Parameters.AddWithValue("@telefono", cliente.Telefono);
                        cmd.Parameters.AddWithValue("@email", cliente.Email);
                        cmd.Parameters.AddWithValue("@direccion", cliente.Direccion);
                        cmd.Parameters.AddWithValue("@id", cliente.ClienteId);
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

        public string Eliminar(int clienteId)
        {
            try
            {
                using (MySqlConnection cn = (MySqlConnection)_conexion.AbrirConexion())
                {
                    string query = "DELETE FROM clientes WHERE cliente_id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@id", clienteId);
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