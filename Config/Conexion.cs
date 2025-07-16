using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace SistemaAlquilerAutos.Config
{
    public class Conexion
    {
        private readonly string _csMySql = "server=localhost;database=sistema_de_alquiler_autos;uid=root;pwd=;";

        public IDbConnection AbrirConexion()
        {
            IDbConnection cn = new MySqlConnection(_csMySql);
            cn.Open();
            return cn;
        }
    }
}