using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SistemaAlquilerAutos.Config;
using SistemaAlquilerAutos.Controllers;

namespace SistemaAlquilerAutos.Views.Manager
{
    public partial class FRMPagos : Form
    {
        private int pagoSeleccionadoId = -1;

        public FRMPagos()
        {
            InitializeComponent();
            dgvPagos.CellClick += dgvPagos_CellClick;
        }

        private void FRMPagos_Load(object sender, EventArgs e)
        {
            CargarPagos();
            CargarContratos();
            CargarMetodosPago();
            CargarEstados();
        }

        private void CargarPagos()
        {
            try
            {
                Conexion conexion = new Conexion();
                using (var cn = conexion.AbrirConexion())
                {
                    string query = @"SELECT p.pago_id, p.contrato_id, c.cliente_id, cl.nombre AS cliente_nombre, p.monto, 
                                    p.fecha_pago, p.metodo_pago, p.estado
                                    FROM pagos p
                                    JOIN contratos c ON p.contrato_id = c.contrato_id
                                    JOIN clientes cl ON c.cliente_id = cl.cliente_id";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, (MySqlConnection)cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvPagos.DataSource = dt;
                    dgvPagos.Columns["pago_id"].Visible = false;
                    dgvPagos.Columns["contrato_id"].Visible = false;
                    dgvPagos.Columns["cliente_id"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar pagos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarContratos()
        {
            try
            {
                Conexion conexion = new Conexion();
                using (var cn = conexion.AbrirConexion())
                {
                    string query = @"SELECT c.contrato_id, CONCAT(cl.nombre, ' ', cl.apellido, ' - ', v.placa) AS contrato_info
                                    FROM contratos c
                                    JOIN clientes cl ON c.cliente_id = cl.cliente_id
                                    JOIN vehiculos v ON c.vehiculo_id = v.vehiculo_id";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, (MySqlConnection)cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbContrato.DataSource = dt;
                    cmbContrato.DisplayMember = "contrato_info";
                    cmbContrato.ValueMember = "contrato_id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar contratos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarMetodosPago()
        {
            cmbMetodoPago.Items.Clear();
            cmbMetodoPago.Items.AddRange(new string[] { "Efectivo", "Tarjeta de Crédito", "Transferencia", "Cheque" });
            cmbMetodoPago.SelectedIndex = 0;
        }

        private void CargarEstados()
        {
            cmbEstado.Items.Clear();
            cmbEstado.Items.AddRange(new string[] { "completado", "pendiente", "cancelado" });
            cmbEstado.SelectedIndex = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            try
            {
                var controller = new PagoController();
                var pago = new Models.PagoModel
                {
                    ContratoId = Convert.ToInt32(cmbContrato.SelectedValue),
                    Monto = Convert.ToDecimal(txtMonto.Text.Trim()),
                    FechaPago = dtpFechaPago.Value,
                    MetodoPago = cmbMetodoPago.Text,
                    Estado = cmbEstado.Text
                };
                string resultado = controller.Insertar(pago);
                if (resultado == "ok")
                {
                    MessageBox.Show("Pago agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarPagos();
                }
                else
                {
                    MessageBox.Show("Error al agregar pago: " + resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (pagoSeleccionadoId == -1)
            {
                MessageBox.Show("Selecciona un pago para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarCampos()) return;

            try
            {
                var controller = new PagoController();
                var pago = new Models.PagoModel
                {
                    PagoId = pagoSeleccionadoId,
                    ContratoId = Convert.ToInt32(cmbContrato.SelectedValue),
                    Monto = Convert.ToDecimal(txtMonto.Text.Trim()),
                    FechaPago = dtpFechaPago.Value,
                    MetodoPago = cmbMetodoPago.Text,
                    Estado = cmbEstado.Text
                };
                string resultado = controller.Actualizar(pago);
                if (resultado == "ok")
                {
                    MessageBox.Show("Pago actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarPagos();
                }
                else
                {
                    MessageBox.Show("Error al actualizar pago: " + resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (pagoSeleccionadoId == -1)
            {
                MessageBox.Show("Selecciona un pago para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("¿Estás seguro de eliminar este pago?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                var controller = new PagoController();
                string resultado = controller.Eliminar(pagoSeleccionadoId);
                if (resultado == "ok")
                {
                    MessageBox.Show("Pago eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarPagos();
                }
                else
                {
                    MessageBox.Show("Error al eliminar pago: " + resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPagos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvPagos.Rows[e.RowIndex];
                pagoSeleccionadoId = Convert.ToInt32(fila.Cells["pago_id"].Value);
                cmbContrato.SelectedValue = fila.Cells["contrato_id"].Value;
                txtMonto.Text = fila.Cells["monto"].Value.ToString();
                dtpFechaPago.Value = Convert.ToDateTime(fila.Cells["fecha_pago"].Value);
                cmbMetodoPago.Text = fila.Cells["metodo_pago"].Value.ToString();
                cmbEstado.Text = fila.Cells["estado"].Value.ToString();
            }
        }

        private bool ValidarCampos()
        {
            if (cmbContrato.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtMonto.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!decimal.TryParse(txtMonto.Text, out _))
            {
                MessageBox.Show("Monto inválido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void LimpiarCampos()
        {
            cmbContrato.SelectedIndex = -1;
            txtMonto.Clear();
            dtpFechaPago.Value = DateTime.Now;
            cmbMetodoPago.SelectedIndex = 0;
            cmbEstado.SelectedIndex = 0;
            pagoSeleccionadoId = -1;
        }
    }
}