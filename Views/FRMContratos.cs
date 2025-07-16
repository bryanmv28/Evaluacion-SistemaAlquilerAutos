using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SistemaAlquilerAutos.Config;
using SistemaAlquilerAutos.Controllers;

namespace SistemaAlquilerAutos.Views.Manager
{
    public partial class FRMContratos : Form
    {
        private int contratoSeleccionadoId = -1;

        public FRMContratos()
        {
            InitializeComponent();
            dgvContratos.CellClick += dgvContratos_CellClick;
        }

        private void FRMContratos_Load(object sender, EventArgs e)
        {
            CargarContratos();
            CargarClientes();
            CargarVehiculos();
            CargarEstados();
        }

        private void CargarContratos()
        {
            try
            {
                Conexion conexion = new Conexion();
                using (var cn = conexion.AbrirConexion())
                {
                    string query = @"SELECT c.contrato_id, c.cliente_id, cl.nombre AS cliente_nombre, c.vehiculo_id, v.placa, 
                                    c.fecha_inicio, c.fecha_fin, c.costo_total, c.estado
                                    FROM contratos c
                                    JOIN clientes cl ON c.cliente_id = cl.cliente_id
                                    JOIN vehiculos v ON c.vehiculo_id = v.vehiculo_id";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, (MySqlConnection)cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvContratos.DataSource = dt;
                    dgvContratos.Columns["contrato_id"].Visible = false;
                    dgvContratos.Columns["cliente_id"].Visible = false;
                    dgvContratos.Columns["vehiculo_id"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar contratos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarClientes()
        {
            try
            {
                Conexion conexion = new Conexion();
                using (var cn = conexion.AbrirConexion())
                {
                    string query = "SELECT cliente_id, CONCAT(nombre, ' ', apellido) AS nombre_completo FROM clientes";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, (MySqlConnection)cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbCliente.DataSource = dt;
                    cmbCliente.DisplayMember = "nombre_completo";
                    cmbCliente.ValueMember = "cliente_id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarVehiculos()
        {
            try
            {
                Conexion conexion = new Conexion();
                using (var cn = conexion.AbrirConexion())
                {
                    string query = "SELECT vehiculo_id, placa FROM vehiculos WHERE estado = 'disponible'";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, (MySqlConnection)cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbVehiculo.DataSource = dt;
                    cmbVehiculo.DisplayMember = "placa";
                    cmbVehiculo.ValueMember = "vehiculo_id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar vehículos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarEstados()
        {
            cmbEstado.Items.Clear();
            cmbEstado.Items.AddRange(new string[] { "activo", "finalizado", "cancelado" });
            cmbEstado.SelectedIndex = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            try
            {
                var controller = new ContratoController();
                var contrato = new Models.ContratoModel
                {
                    ClienteId = Convert.ToInt32(cmbCliente.SelectedValue),
                    VehiculoId = Convert.ToInt32(cmbVehiculo.SelectedValue),
                    FechaInicio = dtpFechaInicio.Value,
                    FechaFin = dtpFechaFin.Value,
                    CostoTotal = Convert.ToDecimal(txtCostoTotal.Text.Trim()),
                    Estado = cmbEstado.Text
                };
                string resultado = controller.Insertar(contrato);
                if (resultado == "ok")
                {
                    // Actualizar estado del vehículo a 'alquilado'
                    ActualizarEstadoVehiculo(contrato.VehiculoId, "alquilado");
                    MessageBox.Show("Contrato agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarContratos();
                    CargarVehiculos();
                }
                else
                {
                    MessageBox.Show("Error al agregar contrato: " + resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar contrato: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (contratoSeleccionadoId == -1)
            {
                MessageBox.Show("Selecciona un contrato para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarCampos()) return;

            try
            {
                var controller = new ContratoController();
                var contrato = new Models.ContratoModel
                {
                    ContratoId = contratoSeleccionadoId,
                    ClienteId = Convert.ToInt32(cmbCliente.SelectedValue),
                    VehiculoId = Convert.ToInt32(cmbVehiculo.SelectedValue),
                    FechaInicio = dtpFechaInicio.Value,
                    FechaFin = dtpFechaFin.Value,
                    CostoTotal = Convert.ToDecimal(txtCostoTotal.Text.Trim()),
                    Estado = cmbEstado.Text
                };
                string resultado = controller.Actualizar(contrato);
                if (resultado == "ok")
                {
                    // Actualizar estado del vehículo según el estado del contrato
                    ActualizarEstadoVehiculo(contrato.VehiculoId, contrato.Estado == "activo" ? "alquilado" : "disponible");
                    MessageBox.Show("Contrato actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarContratos();
                    CargarVehiculos();
                }
                else
                {
                    MessageBox.Show("Error al actualizar contrato: " + resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar contrato: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (contratoSeleccionadoId == -1)
            {
                MessageBox.Show("Selecciona un contrato para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("¿Estás seguro de eliminar este contrato?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                var controller = new ContratoController();
                string resultado = controller.Eliminar(contratoSeleccionadoId);
                if (resultado == "ok")
                {
                    // Actualizar estado del vehículo a 'disponible'
                    int vehiculoId = Convert.ToInt32(dgvContratos.Rows[dgvContratos.CurrentRow.Index].Cells["vehiculo_id"].Value);
                    ActualizarEstadoVehiculo(vehiculoId, "disponible");
                    MessageBox.Show("Contrato eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarContratos();
                    CargarVehiculos();
                }
                else
                {
                    MessageBox.Show("Error al eliminar contrato: " + resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar contrato: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvContratos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvContratos.Rows[e.RowIndex];
                contratoSeleccionadoId = Convert.ToInt32(fila.Cells["contrato_id"].Value);
                cmbCliente.SelectedValue = fila.Cells["cliente_id"].Value;
                cmbVehiculo.SelectedValue = fila.Cells["vehiculo_id"].Value;
                dtpFechaInicio.Value = Convert.ToDateTime(fila.Cells["fecha_inicio"].Value);
                dtpFechaFin.Value = Convert.ToDateTime(fila.Cells["fecha_fin"].Value);
                txtCostoTotal.Text = fila.Cells["costo_total"].Value.ToString();
                cmbEstado.Text = fila.Cells["estado"].Value.ToString();
            }
        }

        private bool ValidarCampos()
        {
            if (cmbCliente.SelectedIndex == -1 || cmbVehiculo.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtCostoTotal.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!decimal.TryParse(txtCostoTotal.Text, out _))
            {
                MessageBox.Show("Costo total inválido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (dtpFechaInicio.Value >= dtpFechaFin.Value)
            {
                MessageBox.Show("La fecha de inicio debe ser menor que la fecha de fin.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void LimpiarCampos()
        {
            cmbCliente.SelectedIndex = -1;
            cmbVehiculo.SelectedIndex = -1;
            dtpFechaInicio.Value = DateTime.Now;
            dtpFechaFin.Value = DateTime.Now;
            txtCostoTotal.Clear();
            cmbEstado.SelectedIndex = 0;
            contratoSeleccionadoId = -1;
        }

        private void ActualizarEstadoVehiculo(int vehiculoId, string estado)
        {
            try
            {
                using (MySqlConnection cn = (MySqlConnection)new Conexion().AbrirConexion())
                {
                    string query = "UPDATE vehiculos SET estado = @estado WHERE vehiculo_id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@estado", estado);
                        cmd.Parameters.AddWithValue("@id", vehiculoId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar estado del vehículo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}