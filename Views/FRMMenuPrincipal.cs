using System;
using System.Windows.Forms;

namespace SistemaAlquilerAutos.Views.Manager
{
    public partial class FRMMenuPrincipal : Form
    {
        public FRMMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            var frmClientes = new FRMClientes();
            frmClientes.Show();
        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            var frmVehiculos = new FRMVehiculos();
            frmVehiculos.Show();
        }

        private void btnContratos_Click(object sender, EventArgs e)
        {
            var frmContratos = new FRMContratos();
            frmContratos.Show();
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            var frmPagos = new FRMPagos();
            frmPagos.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}