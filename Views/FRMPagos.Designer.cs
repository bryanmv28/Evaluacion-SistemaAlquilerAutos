namespace SistemaAlquilerAutos.Views.Manager
{
    partial class FRMPagos
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
            dgvPagos = new DataGridView();
            cmbContrato = new ComboBox();
            txtMonto = new TextBox();
            dtpFechaPago = new DateTimePicker();
            cmbMetodoPago = new ComboBox();
            cmbEstado = new ComboBox();
            lblContrato = new Label();
            lblMonto = new Label();
            lblFechaPago = new Label();
            lblMetodoPago = new Label();
            lblEstado = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPagos).BeginInit();
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
            // dgvPagos
            // 
            dgvPagos.AllowUserToAddRows = false;
            dgvPagos.AllowUserToDeleteRows = false;
            dgvPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPagos.Location = new Point(593, 112);
            dgvPagos.Margin = new Padding(5, 6, 5, 6);
            dgvPagos.Name = "dgvPagos";
            dgvPagos.ReadOnly = true;
            dgvPagos.RowHeadersWidth = 62;
            dgvPagos.Size = new Size(635, 492);
            dgvPagos.TabIndex = 4;
            // 
            // cmbContrato
            // 
            cmbContrato.FormattingEnabled = true;
            cmbContrato.Location = new Point(93, 142);
            cmbContrato.Margin = new Padding(5, 6, 5, 6);
            cmbContrato.Name = "cmbContrato";
            cmbContrato.Size = new Size(406, 33);
            cmbContrato.TabIndex = 5;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(93, 233);
            txtMonto.Margin = new Padding(5, 6, 5, 6);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(406, 31);
            txtMonto.TabIndex = 6;
            // 
            // dtpFechaPago
            // 
            dtpFechaPago.Format = DateTimePickerFormat.Short;
            dtpFechaPago.Location = new Point(93, 323);
            dtpFechaPago.Margin = new Padding(5, 6, 5, 6);
            dtpFechaPago.Name = "dtpFechaPago";
            dtpFechaPago.Size = new Size(406, 31);
            dtpFechaPago.TabIndex = 7;
            // 
            // cmbMetodoPago
            // 
            cmbMetodoPago.FormattingEnabled = true;
            cmbMetodoPago.Location = new Point(93, 413);
            cmbMetodoPago.Margin = new Padding(5, 6, 5, 6);
            cmbMetodoPago.Name = "cmbMetodoPago";
            cmbMetodoPago.Size = new Size(406, 33);
            cmbMetodoPago.TabIndex = 8;
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(93, 504);
            cmbEstado.Margin = new Padding(5, 6, 5, 6);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(406, 33);
            cmbEstado.TabIndex = 9;
            // 
            // lblContrato
            // 
            lblContrato.AutoSize = true;
            lblContrato.Location = new Point(88, 112);
            lblContrato.Margin = new Padding(5, 0, 5, 0);
            lblContrato.Name = "lblContrato";
            lblContrato.Size = new Size(82, 25);
            lblContrato.TabIndex = 10;
            lblContrato.Text = "Contrato";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(88, 202);
            lblMonto.Margin = new Padding(5, 0, 5, 0);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(66, 25);
            lblMonto.TabIndex = 11;
            lblMonto.Text = "Monto";
            // 
            // lblFechaPago
            // 
            lblFechaPago.AutoSize = true;
            lblFechaPago.Location = new Point(88, 292);
            lblFechaPago.Margin = new Padding(5, 0, 5, 0);
            lblFechaPago.Name = "lblFechaPago";
            lblFechaPago.Size = new Size(102, 25);
            lblFechaPago.TabIndex = 12;
            lblFechaPago.Text = "Fecha Pago";
            // 
            // lblMetodoPago
            // 
            lblMetodoPago.AutoSize = true;
            lblMetodoPago.Location = new Point(88, 383);
            lblMetodoPago.Margin = new Padding(5, 0, 5, 0);
            lblMetodoPago.Name = "lblMetodoPago";
            lblMetodoPago.Size = new Size(121, 25);
            lblMetodoPago.TabIndex = 13;
            lblMetodoPago.Text = "Método Pago";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(88, 473);
            lblEstado.Margin = new Padding(5, 0, 5, 0);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(66, 25);
            lblEstado.TabIndex = 14;
            lblEstado.Text = "Estado";
            // 
            // FRMPagos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1333, 865);
            Controls.Add(lblEstado);
            Controls.Add(lblMetodoPago);
            Controls.Add(lblFechaPago);
            Controls.Add(lblMonto);
            Controls.Add(lblContrato);
            Controls.Add(cmbEstado);
            Controls.Add(cmbMetodoPago);
            Controls.Add(dtpFechaPago);
            Controls.Add(txtMonto);
            Controls.Add(cmbContrato);
            Controls.Add(dgvPagos);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "FRMPagos";
            Text = "Gestión de Pagos";
            Load += FRMPagos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPagos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvPagos;
        private System.Windows.Forms.ComboBox cmbContrato;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.DateTimePicker dtpFechaPago;
        private System.Windows.Forms.ComboBox cmbMetodoPago;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblContrato;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblFechaPago;
        private System.Windows.Forms.Label lblMetodoPago;
        private System.Windows.Forms.Label lblEstado;
    }
}