using System;

namespace SistemaAlquilerAutos.Models
{
    public class ContratoModel
    {
        public int ContratoId { get; set; }
        public int ClienteId { get; set; }
        public int VehiculoId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public decimal CostoTotal { get; set; }
        public string Estado { get; set; }
    }
}