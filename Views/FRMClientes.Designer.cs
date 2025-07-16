namespace SistemaAlquilerAutos.Views.Manager
{
    partial class FRMClientes
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnSalir = new Button();
            dgvClientes = new DataGridView();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDni = new TextBox();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            txtDireccion = new TextBox();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDni = new Label();
            lblTelefono = new Label();
            lblEmail = new Label();
            lblDireccion = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.InactiveCaption;
            btnAgregar.Location = new Point(93, 671);
            btnAgregar.Margin = new Padding(5, 6, 5, 6);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(253, 115);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = SystemColors.InactiveCaption;
            btnEditar.Location = new Point(388, 671);
            btnEditar.Margin = new Padding(5, 6, 5, 6);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(253, 115);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.InactiveCaption;
            btnEliminar.Location = new Point(680, 671);
            btnEliminar.Margin = new Padding(5, 6, 5, 6);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(253, 115);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.InactiveCaption;
            btnSalir.Location = new Point(972, 671);
            btnSalir.Margin = new Padding(5, 6, 5, 6);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(253, 115);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvClientes.DefaultCellStyle = dataGridViewCellStyle2;
            dgvClientes.Location = new Point(593, 112);
            dgvClientes.Margin = new Padding(5, 6, 5, 6);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersWidth = 62;
            dgvClientes.Size = new Size(635, 492);
            dgvClientes.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(93, 142);
            txtNombre.Margin = new Padding(5, 6, 5, 6);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(406, 31);
            txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(93, 233);
            txtApellido.Margin = new Padding(5, 6, 5, 6);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(406, 31);
            txtApellido.TabIndex = 6;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(93, 323);
            txtDni.Margin = new Padding(5, 6, 5, 6);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(406, 31);
            txtDni.TabIndex = 7;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(93, 413);
            txtTelefono.Margin = new Padding(5, 6, 5, 6);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(406, 31);
            txtTelefono.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(93, 504);
            txtEmail.Margin = new Padding(5, 6, 5, 6);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(406, 31);
            txtEmail.TabIndex = 9;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(93, 594);
            txtDireccion.Margin = new Padding(5, 6, 5, 6);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(406, 31);
            txtDireccion.TabIndex = 10;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(88, 112);
            lblNombre.Margin = new Padding(5, 0, 5, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(78, 25);
            lblNombre.TabIndex = 11;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(88, 202);
            lblApellido.Margin = new Padding(5, 0, 5, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(78, 25);
            lblApellido.TabIndex = 12;
            lblApellido.Text = "Apellido";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(88, 292);
            lblDni.Margin = new Padding(5, 0, 5, 0);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(66, 25);
            lblDni.TabIndex = 13;
            lblDni.Text = "Cedula";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(88, 383);
            lblTelefono.Margin = new Padding(5, 0, 5, 0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(79, 25);
            lblTelefono.TabIndex = 14;
            lblTelefono.Text = "Teléfono";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(88, 473);
            lblEmail.Margin = new Padding(5, 0, 5, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 25);
            lblEmail.TabIndex = 15;
            lblEmail.Text = "Email";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(88, 563);
            lblDireccion.Margin = new Padding(5, 0, 5, 0);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(85, 25);
            lblDireccion.TabIndex = 16;
            lblDireccion.Text = "Dirección";
            // 
            // FRMClientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1333, 865);
            Controls.Add(lblDireccion);
            Controls.Add(lblEmail);
            Controls.Add(lblTelefono);
            Controls.Add(lblDni);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(txtDireccion);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(txtDni);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(dgvClientes);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "FRMClientes";
            Text = "Gestión de Clientes";
            Load += FRMClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDireccion;
    }
}