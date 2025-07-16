using System;

namespace SistemaAlquilerAutos.Models
{
    public class PagoModel
    {
        public int PagoId { get; set; }
        public int ContratoId { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaPago { get; set; }
        public string MetodoPago { get; set; }
        public string Estado { get; set; }
    }
}