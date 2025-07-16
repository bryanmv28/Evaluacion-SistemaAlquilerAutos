namespace SistemaAlquilerAutos.Views.Manager
{
    partial class FRMMenuPrincipal
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
            btnClientes = new Button();
            btnVehiculos = new Button();
            btnContratos = new Button();
            btnPagos = new Button();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // btnClientes
            // 
            btnClientes.BackColor = SystemColors.InactiveCaption;
            btnClientes.Location = new Point(86, 97);
            btnClientes.Margin = new Padding(4, 6, 4, 6);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(306, 119);
            btnClientes.TabIndex = 1;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnVehiculos
            // 
            btnVehiculos.BackColor = SystemColors.InactiveCaption;
            btnVehiculos.Location = new Point(453, 97);
            btnVehiculos.Margin = new Padding(4, 6, 4, 6);
            btnVehiculos.Name = "btnVehiculos";
            btnVehiculos.Size = new Size(306, 119);
            btnVehiculos.TabIndex = 2;
            btnVehiculos.Text = "Vehículos";
            btnVehiculos.UseVisualStyleBackColor = false;
            btnVehiculos.Click += btnVehiculos_Click;
            // 
            // btnContratos
            // 
            btnContratos.BackColor = SystemColors.InactiveCaption;
            btnContratos.Location = new Point(86, 271);
            btnContratos.Margin = new Padding(4, 6, 4, 6);
            btnContratos.Name = "btnContratos";
            btnContratos.Size = new Size(306, 119);
            btnContratos.TabIndex = 3;
            btnContratos.Text = "Contratos";
            btnContratos.UseVisualStyleBackColor = false;
            btnContratos.Click += btnContratos_Click;
            // 
            // btnPagos
            // 
            btnPagos.BackColor = SystemColors.InactiveCaption;
            btnPagos.Location = new Point(453, 271);
            btnPagos.Margin = new Padding(4, 6, 4, 6);
            btnPagos.Name = "btnPagos";
            btnPagos.Size = new Size(306, 119);
            btnPagos.TabIndex = 4;
            btnPagos.Text = "Pagos";
            btnPagos.UseVisualStyleBackColor = false;
            btnPagos.Click += btnPagos_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = SystemColors.InactiveCaption;
            btnCerrar.Location = new Point(86, 442);
            btnCerrar.Margin = new Padding(4, 6, 4, 6);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(675, 119);
            btnCerrar.TabIndex = 5;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FRMMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(846, 666);
            Controls.Add(btnCerrar);
            Controls.Add(btnPagos);
            Controls.Add(btnContratos);
            Controls.Add(btnVehiculos);
            Controls.Add(btnClientes);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(4, 6, 4, 6);
            Name = "FRMMenuPrincipal";
            Text = "Menú Principal";
            ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnVehiculos;
        private System.Windows.Forms.Button btnContratos;
        private System.Windows.Forms.Button btnPagos;
        private System.Windows.Forms.Button btnCerrar;
    }
}