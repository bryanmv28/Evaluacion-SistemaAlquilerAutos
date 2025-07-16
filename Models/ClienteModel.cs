using System;

namespace SistemaAlquilerAutos.Models
{
    public class ClienteModel
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string cedula { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}