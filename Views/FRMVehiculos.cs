using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SistemaAlquilerAutos.Config;
using SistemaAlquilerAutos.Controllers;

namespace SistemaAlquilerAutos.Views.Manager
{
    public partial class FRMVehiculos : Form
    {
        private int vehiculoSeleccionadoId = -1;

        public FRMVehiculos()
        {
            InitializeComponent();
            dgvVehiculos.CellClick += dgvVehiculos_CellClick;
        }

        private void FRMVehiculos_Load(object sender, EventArgs e)
        {
            CargarVehiculos();
            CargarTiposVehiculo();
            CargarEstados();
        }

        private void CargarVehiculos()
        {
            try
            {
                Conexion conexion = new Conexion();
                using (var cn = conexion.AbrirConexion())
                {
                    string query = "SELECT vehiculo_id, marca, modelo, placa, anio, tipo_vehiculo, estado, precio_diario FROM vehiculos";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, (MySqlConnection)cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvVehiculos.DataSource = dt;
                    dgvVehiculos.Columns["vehiculo_id"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar vehículos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarTiposVehiculo()
        {
            cmbTipoVehiculo.Items.Clear();
            cmbTipoVehiculo.Items.AddRange(new string[] { "Sedán", "SUV", "Camioneta", "Deportivo", "Furgoneta" });
            cmbTipoVehiculo.SelectedIndex = 0;
        }

        private void CargarEstados()
        {
            cmbEstado.Items.Clear();
            cmbEstado.Items.AddRange(new string[] { "disponible", "alquilado", "mantenimiento" });
            cmbEstado.SelectedIndex = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            try
            {
                var controller = new VehiculoController();
                var vehiculo = new Models.VehiculoModel
                {
                    Marca = txtMarca.Text.Trim(),
                    Modelo = txtModelo.Text.Trim(),
                    Placa = txtPlaca.Text.Trim(),
                    Anio = Convert.ToInt32(txtAnio.Text.Trim()),
                    TipoVehiculo = cmbTipoVehiculo.Text,
                    Estado = cmbEstado.Text,
                    PrecioDiario = Convert.ToDecimal(txtPrecioDiario.Text.Trim())
                };
                string resultado = controller.Insertar(vehiculo);
                if (resultado == "ok")
                {
                    MessageBox.Show("Vehículo agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarVehiculos();
                }
                else
                {
                    MessageBox.Show("Error al agregar vehículo: " + resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar vehículo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (vehiculoSeleccionadoId == -1)
            {
                MessageBox.Show("Selecciona un vehículo para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarCampos()) return;

            try
            {
                var controller = new VehiculoController();
                var vehiculo = new Models.VehiculoModel
                {
                    VehiculoId = vehiculoSeleccionadoId,
                    Marca = txtMarca.Text.Trim(),
                    Modelo = txtModelo.Text.Trim(),
                    Placa = txtPlaca.Text.Trim(),
                    Anio = Convert.ToInt32(txtAnio.Text.Trim()),
                    TipoVehiculo = cmbTipoVehiculo.Text,
                    Estado = cmbEstado.Text,
                    PrecioDiario = Convert.ToDecimal(txtPrecioDiario.Text.Trim())
                };
                string resultado = controller.Actualizar(vehiculo);
                if (resultado == "ok")
                {
                    MessageBox.Show("Vehículo actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarVehiculos();
                }
                else
                {
                    MessageBox.Show("Error al actualizar vehículo: " + resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar vehículo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (vehiculoSeleccionadoId == -1)
            {
                MessageBox.Show("Selecciona un vehículo para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("¿Estás seguro de eliminar este vehículo?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                var controller = new VehiculoController();
                string resultado = controller.Eliminar(vehiculoSeleccionadoId);
                if (resultado == "ok")
                {
                    MessageBox.Show("Vehículo eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarVehiculos();
                }
                else
                {
                    MessageBox.Show("Error al eliminar vehículo: " + resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar vehículo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvVehiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvVehiculos.Rows[e.RowIndex];
                vehiculoSeleccionadoId = Convert.ToInt32(fila.Cells["vehiculo_id"].Value);
                txtMarca.Text = fila.Cells["marca"].Value.ToString();
                txtModelo.Text = fila.Cells["modelo"].Value.ToString();
                txtPlaca.Text = fila.Cells["placa"].Value.ToString();
                txtAnio.Text = fila.Cells["anio"].Value.ToString();
                cmbTipoVehiculo.Text = fila.Cells["tipo_vehiculo"].Value.ToString();
                cmbEstado.Text = fila.Cells["estado"].Value.ToString();
                txtPrecioDiario.Text = fila.Cells["precio_diario"].Value.ToString();
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtMarca.Text) ||
                string.IsNullOrWhiteSpace(txtModelo.Text) ||
                string.IsNullOrWhiteSpace(txtPlaca.Text) ||
                string.IsNullOrWhiteSpace(txtAnio.Text) ||
                string.IsNullOrWhiteSpace(txtPrecioDiario.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!int.TryParse(txtAnio.Text, out _))
            {
                MessageBox.Show("Año inválido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!decimal.TryParse(txtPrecioDiario.Text, out _))
            {
                MessageBox.Show("Precio diario inválido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void LimpiarCampos()
        {
            txtMarca.Clear();
            txtModelo.Clear();
            txtPlaca.Clear();
            txtAnio.Clear();
            txtPrecioDiario.Clear();
            cmbTipoVehiculo.SelectedIndex = 0;
            cmbEstado.SelectedIndex = 0;
            vehiculoSeleccionadoId = -1;
        }
    }
}