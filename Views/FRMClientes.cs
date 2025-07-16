using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SistemaAlquilerAutos.Config;
using SistemaAlquilerAutos.Controllers;

namespace SistemaAlquilerAutos.Views.Manager
{
    public partial class FRMClientes : Form
    {
        private int clienteSeleccionadoId = -1;

        public FRMClientes()
        {
            InitializeComponent();
            dgvClientes.CellClick += dgvClientes_CellClick;
        }

        private void FRMClientes_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void CargarClientes()
        {
            try
            {
                Conexion conexion = new Conexion();
                using (var cn = conexion.AbrirConexion())
                {
                    string query = "SELECT cliente_id, nombre, apellido, cedula, telefono, email, direccion, fecha_registro FROM clientes";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, (MySqlConnection)cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvClientes.DataSource = dt;
                    dgvClientes.Columns["cliente_id"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            try
            {
                var controller = new ClienteController();
                var cliente = new Models.ClienteModel
                {
                    Nombre = txtNombre.Text.Trim(),
                    Apellido = txtApellido.Text.Trim(),
                    cedula = txtDni.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Direccion = txtDireccion.Text.Trim()
                };
                string resultado = controller.Insertar(cliente);
                if (resultado == "ok")
                {
                    MessageBox.Show("Cliente agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarClientes();
                }
                else
                {
                    MessageBox.Show("Error al agregar cliente: " + resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (clienteSeleccionadoId == -1)
            {
                MessageBox.Show("Selecciona un cliente para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarCampos()) return;

            try
            {
                var controller = new ClienteController();
                var cliente = new Models.ClienteModel
                {
                    ClienteId = clienteSeleccionadoId,
                    Nombre = txtNombre.Text.Trim(),
                    Apellido = txtApellido.Text.Trim(),
                    cedula = txtDni.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Direccion = txtDireccion.Text.Trim()
                };
                string resultado = controller.Actualizar(cliente);
                if (resultado == "ok")
                {
                    MessageBox.Show("Cliente actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarClientes();
                }
                else
                {
                    MessageBox.Show("Error al actualizar cliente: " + resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (clienteSeleccionadoId == -1)
            {
                MessageBox.Show("Selecciona un cliente para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("¿Estás seguro de eliminar este cliente?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                var controller = new ClienteController();
                string resultado = controller.Eliminar(clienteSeleccionadoId);
                if (resultado == "ok")
                {
                    MessageBox.Show("Cliente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarClientes();
                }
                else
                {
                    MessageBox.Show("Error al eliminar cliente: " + resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvClientes.Rows[e.RowIndex];
                clienteSeleccionadoId = Convert.ToInt32(fila.Cells["cliente_id"].Value);
                txtNombre.Text = fila.Cells["nombre"].Value.ToString();
                txtApellido.Text = fila.Cells["apellido"].Value.ToString();
                txtDni.Text = fila.Cells["cedula"].Value.ToString();
                txtTelefono.Text = fila.Cells["telefono"].Value.ToString();
                txtEmail.Text = fila.Cells["email"].Value.ToString();
                txtDireccion.Text = fila.Cells["direccion"].Value.ToString();
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtDni.Text))
            {
                MessageBox.Show("Por favor, completa los campos obligatorios (Nombre, Apellido, DNI).", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDni.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtDireccion.Clear();
            clienteSeleccionadoId = -1;
        }
    }
}