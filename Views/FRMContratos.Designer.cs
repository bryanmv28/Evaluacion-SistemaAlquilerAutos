namespace SistemaAlquilerAutos.Views.Manager
{
    partial class FRMContratos
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
            dgvContratos = new DataGridView();
            cmbCliente = new ComboBox();
            cmbVehiculo = new ComboBox();
            dtpFechaInicio = new DateTimePicker();
            dtpFechaFin = new DateTimePicker();
            txtCostoTotal = new TextBox();
            cmbEstado = new ComboBox();
            lblCliente = new Label();
            lblVehiculo = new Label();
            lblFechaInicio = new Label();
            lblFechaFin = new Label();
            lblCostoTotal = new Label();
            lblEstado = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvContratos).BeginInit();
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
            // dgvContratos
            // 
            dgvContratos.AllowUserToAddRows = false;
            dgvContratos.AllowUserToDeleteRows = false;
            dgvContratos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContratos.Location = new Point(593, 112);
            dgvContratos.Margin = new Padding(5, 6, 5, 6);
            dgvContratos.Name = "dgvContratos";
            dgvContratos.ReadOnly = true;
            dgvContratos.RowHeadersWidth = 62;
            dgvContratos.Size = new Size(635, 492);
            dgvContratos.TabIndex = 4;
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(93, 142);
            cmbCliente.Margin = new Padding(5, 6, 5, 6);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(406, 33);
            cmbCliente.TabIndex = 5;
            // 
            // cmbVehiculo
            // 
            cmbVehiculo.FormattingEnabled = true;
            cmbVehiculo.Location = new Point(93, 233);
            cmbVehiculo.Margin = new Padding(5, 6, 5, 6);
            cmbVehiculo.Name = "cmbVehiculo";
            cmbVehiculo.Size = new Size(406, 33);
            cmbVehiculo.TabIndex = 6;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(93, 323);
            dtpFechaInicio.Margin = new Padding(5, 6, 5, 6);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(406, 31);
            dtpFechaInicio.TabIndex = 7;
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(93, 413);
            dtpFechaFin.Margin = new Padding(5, 6, 5, 6);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(406, 31);
            dtpFechaFin.TabIndex = 8;
            // 
            // txtCostoTotal
            // 
            txtCostoTotal.Location = new Point(93, 504);
            txtCostoTotal.Margin = new Padding(5, 6, 5, 6);
            txtCostoTotal.Name = "txtCostoTotal";
            txtCostoTotal.Size = new Size(406, 31);
            txtCostoTotal.TabIndex = 9;
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
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(88, 112);
            lblCliente.Margin = new Padding(5, 0, 5, 0);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(65, 25);
            lblCliente.TabIndex = 11;
            lblCliente.Text = "Cliente";
            // 
            // lblVehiculo
            // 
            lblVehiculo.AutoSize = true;
            lblVehiculo.Location = new Point(88, 202);
            lblVehiculo.Margin = new Padding(5, 0, 5, 0);
            lblVehiculo.Name = "lblVehiculo";
            lblVehiculo.Size = new Size(78, 25);
            lblVehiculo.TabIndex = 12;
            lblVehiculo.Text = "Vehículo";
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Location = new Point(88, 292);
            lblFechaInicio.Margin = new Padding(5, 0, 5, 0);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(104, 25);
            lblFechaInicio.TabIndex = 13;
            lblFechaInicio.Text = "Fecha Inicio";
            // 
            // lblFechaFin
            // 
            lblFechaFin.AutoSize = true;
            lblFechaFin.Location = new Point(88, 383);
            lblFechaFin.Margin = new Padding(5, 0, 5, 0);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(85, 25);
            lblFechaFin.TabIndex = 14;
            lblFechaFin.Text = "Fecha Fin";
            // 
            // lblCostoTotal
            // 
            lblCostoTotal.AutoSize = true;
            lblCostoTotal.Location = new Point(88, 473);
            lblCostoTotal.Margin = new Padding(5, 0, 5, 0);
            lblCostoTotal.Name = "lblCostoTotal";
            lblCostoTotal.Size = new Size(101, 25);
            lblCostoTotal.TabIndex = 15;
            lblCostoTotal.Text = "Costo Total";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(88, 563);
            lblEstado.Margin = new Padding(5, 0, 5, 0);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(66, 25);
            lblEstado.TabIndex = 16;
            lblEstado.Text = "Estado";
            // 
            // FRMContratos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1333, 865);
            Controls.Add(lblEstado);
            Controls.Add(lblCostoTotal);
            Controls.Add(lblFechaFin);
            Controls.Add(lblFechaInicio);
            Controls.Add(lblVehiculo);
            Controls.Add(lblCliente);
            Controls.Add(cmbEstado);
            Controls.Add(txtCostoTotal);
            Controls.Add(dtpFechaFin);
            Controls.Add(dtpFechaInicio);
            Controls.Add(cmbVehiculo);
            Controls.Add(cmbCliente);
            Controls.Add(dgvContratos);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "FRMContratos";
            Text = "Gestión de Contratos";
            Load += FRMContratos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvContratos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvContratos;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.ComboBox cmbVehiculo;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.TextBox txtCostoTotal;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblVehiculo;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Label lblCostoTotal;
        private System.Windows.Forms.Label lblEstado;
    }
}