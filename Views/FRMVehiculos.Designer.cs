namespace SistemaAlquilerAutos.Views.Manager
{
    partial class FRMVehiculos
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
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnSalir = new Button();
            dgvVehiculos = new DataGridView();
            txtMarca = new TextBox();
            txtModelo = new TextBox();
            txtPlaca = new TextBox();
            txtAnio = new TextBox();
            cmbTipoVehiculo = new ComboBox();
            cmbEstado = new ComboBox();
            txtPrecioDiario = new TextBox();
            lblMarca = new Label();
            lblModelo = new Label();
            lblPlaca = new Label();
            lblAnio = new Label();
            lblTipoVehiculo = new Label();
            lblEstado = new Label();
            lblPrecioDiario = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvVehiculos).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.InactiveCaption;
            btnAgregar.Location = new Point(111, 723);
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
            btnEditar.Location = new Point(406, 723);
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
            btnEliminar.Location = new Point(698, 723);
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
            btnSalir.Location = new Point(990, 723);
            btnSalir.Margin = new Padding(5, 6, 5, 6);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(253, 115);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // dgvVehiculos
            // 
            dgvVehiculos.AllowUserToAddRows = false;
            dgvVehiculos.AllowUserToDeleteRows = false;
            dgvVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehiculos.Location = new Point(593, 112);
            dgvVehiculos.Margin = new Padding(5, 6, 5, 6);
            dgvVehiculos.Name = "dgvVehiculos";
            dgvVehiculos.ReadOnly = true;
            dgvVehiculos.RowHeadersWidth = 62;
            dgvVehiculos.Size = new Size(635, 492);
            dgvVehiculos.TabIndex = 4;
            // 
            // txtMarca
            // 
            txtMarca.Font = new Font("Segoe UI", 9F);
            txtMarca.Location = new Point(93, 142);
            txtMarca.Margin = new Padding(5, 6, 5, 6);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(406, 31);
            txtMarca.TabIndex = 5;
            // 
            // txtModelo
            // 
            txtModelo.Font = new Font("Segoe UI", 9F);
            txtModelo.Location = new Point(93, 233);
            txtModelo.Margin = new Padding(5, 6, 5, 6);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(406, 31);
            txtModelo.TabIndex = 6;
            // 
            // txtPlaca
            // 
            txtPlaca.Font = new Font("Segoe UI", 9F);
            txtPlaca.Location = new Point(93, 323);
            txtPlaca.Margin = new Padding(5, 6, 5, 6);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(406, 31);
            txtPlaca.TabIndex = 7;
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(93, 413);
            txtAnio.Margin = new Padding(5, 6, 5, 6);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(406, 31);
            txtAnio.TabIndex = 8;
            // 
            // cmbTipoVehiculo
            // 
            cmbTipoVehiculo.FormattingEnabled = true;
            cmbTipoVehiculo.Location = new Point(93, 504);
            cmbTipoVehiculo.Margin = new Padding(5, 6, 5, 6);
            cmbTipoVehiculo.Name = "cmbTipoVehiculo";
            cmbTipoVehiculo.Size = new Size(406, 33);
            cmbTipoVehiculo.TabIndex = 9;
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(93, 594);
            cmbEstado.Margin = new Padding(5, 6, 5, 6);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(406, 33);
            cmbEstado.TabIndex = 10;
            // 
            // txtPrecioDiario
            // 
            txtPrecioDiario.Location = new Point(93, 685);
            txtPrecioDiario.Margin = new Padding(5, 6, 5, 6);
            txtPrecioDiario.Name = "txtPrecioDiario";
            txtPrecioDiario.Size = new Size(406, 31);
            txtPrecioDiario.TabIndex = 11;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Segoe UI", 9F);
            lblMarca.Location = new Point(88, 112);
            lblMarca.Margin = new Padding(5, 0, 5, 0);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(60, 25);
            lblMarca.TabIndex = 12;
            lblMarca.Text = "Marca";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Font = new Font("Segoe UI", 9F);
            lblModelo.Location = new Point(88, 202);
            lblModelo.Margin = new Padding(5, 0, 5, 0);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(74, 25);
            lblModelo.TabIndex = 13;
            lblModelo.Text = "Modelo";
            // 
            // lblPlaca
            // 
            lblPlaca.AutoSize = true;
            lblPlaca.Font = new Font("Segoe UI", 9F);
            lblPlaca.Location = new Point(88, 292);
            lblPlaca.Margin = new Padding(5, 0, 5, 0);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(52, 25);
            lblPlaca.TabIndex = 14;
            lblPlaca.Text = "Placa";
            // 
            // lblAnio
            // 
            lblAnio.AutoSize = true;
            lblAnio.Font = new Font("Segoe UI", 9F);
            lblAnio.Location = new Point(88, 383);
            lblAnio.Margin = new Padding(5, 0, 5, 0);
            lblAnio.Name = "lblAnio";
            lblAnio.Size = new Size(45, 25);
            lblAnio.TabIndex = 15;
            lblAnio.Text = "Año";
            // 
            // lblTipoVehiculo
            // 
            lblTipoVehiculo.AutoSize = true;
            lblTipoVehiculo.Location = new Point(88, 473);
            lblTipoVehiculo.Margin = new Padding(5, 0, 5, 0);
            lblTipoVehiculo.Name = "lblTipoVehiculo";
            lblTipoVehiculo.Size = new Size(118, 25);
            lblTipoVehiculo.TabIndex = 16;
            lblTipoVehiculo.Text = "Tipo Vehículo";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(88, 563);
            lblEstado.Margin = new Padding(5, 0, 5, 0);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(66, 25);
            lblEstado.TabIndex = 17;
            lblEstado.Text = "Estado";
            // 
            // lblPrecioDiario
            // 
            lblPrecioDiario.AutoSize = true;
            lblPrecioDiario.Location = new Point(88, 654);
            lblPrecioDiario.Margin = new Padding(5, 0, 5, 0);
            lblPrecioDiario.Name = "lblPrecioDiario";
            lblPrecioDiario.Size = new Size(112, 25);
            lblPrecioDiario.TabIndex = 18;
            lblPrecioDiario.Text = "Precio Diario";
            // 
            // FRMVehiculos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1333, 865);
            Controls.Add(lblPrecioDiario);
            Controls.Add(lblEstado);
            Controls.Add(lblTipoVehiculo);
            Controls.Add(lblAnio);
            Controls.Add(lblPlaca);
            Controls.Add(lblModelo);
            Controls.Add(lblMarca);
            Controls.Add(txtPrecioDiario);
            Controls.Add(cmbEstado);
            Controls.Add(cmbTipoVehiculo);
            Controls.Add(txtAnio);
            Controls.Add(txtPlaca);
            Controls.Add(txtModelo);
            Controls.Add(txtMarca);
            Controls.Add(dgvVehiculos);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "FRMVehiculos";
            Text = "Gestión de Vehículos";
            Load += FRMVehiculos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVehiculos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvVehiculos;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.ComboBox cmbTipoVehiculo;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.TextBox txtPrecioDiario;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblTipoVehiculo;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblPrecioDiario;
    }
}