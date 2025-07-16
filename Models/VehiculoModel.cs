using System;

namespace SistemaAlquilerAutos.Models
{
    public class VehiculoModel
    {
        public int VehiculoId { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public int Anio { get; set; }
        public string TipoVehiculo { get; set; }
        public string Estado { get; set; }
        public decimal PrecioDiario { get; set; }
    }
}