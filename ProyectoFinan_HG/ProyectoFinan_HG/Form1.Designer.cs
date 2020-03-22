namespace ProyectoFinan_HG
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNit = new System.Windows.Forms.TextBox();
            this.lbMensaje = new System.Windows.Forms.Label();
            this.tbcGestionEmpresa = new System.Windows.Forms.TabControl();
            this.tbpRegistro = new System.Windows.Forms.TabPage();
            this.pnlRegistro = new System.Windows.Forms.Panel();
            this.txtNitcamara = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lbComnit = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbNit = new System.Windows.Forms.Label();
            this.tbpConsulta = new System.Windows.Forms.TabPage();
            this.pnlConsulta = new System.Windows.Forms.Panel();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.btnConsultarEmpresas = new System.Windows.Forms.Button();
            this.tbcGestionEmpresa.SuspendLayout();
            this.tbpRegistro.SuspendLayout();
            this.pnlRegistro.SuspendLayout();
            this.tbpConsulta.SuspendLayout();
            this.pnlConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNit
            // 
            this.txtNit.Location = new System.Drawing.Point(210, 56);
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(138, 20);
            this.txtNit.TabIndex = 0;
            // 
            // lbMensaje
            // 
            this.lbMensaje.AutoSize = true;
            this.lbMensaje.Location = new System.Drawing.Point(25, 30);
            this.lbMensaje.Name = "lbMensaje";
            this.lbMensaje.Size = new System.Drawing.Size(197, 13);
            this.lbMensaje.TabIndex = 1;
            this.lbMensaje.Text = "Ingrese datos de la Empresa Domiciliaria";
            this.lbMensaje.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbcGestionEmpresa
            // 
            this.tbcGestionEmpresa.Controls.Add(this.tbpRegistro);
            this.tbcGestionEmpresa.Controls.Add(this.tbpConsulta);
            this.tbcGestionEmpresa.Location = new System.Drawing.Point(12, 24);
            this.tbcGestionEmpresa.Name = "tbcGestionEmpresa";
            this.tbcGestionEmpresa.SelectedIndex = 0;
            this.tbcGestionEmpresa.Size = new System.Drawing.Size(483, 361);
            this.tbcGestionEmpresa.TabIndex = 2;
            // 
            // tbpRegistro
            // 
            this.tbpRegistro.Controls.Add(this.pnlRegistro);
            this.tbpRegistro.Location = new System.Drawing.Point(4, 22);
            this.tbpRegistro.Name = "tbpRegistro";
            this.tbpRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRegistro.Size = new System.Drawing.Size(496, 335);
            this.tbpRegistro.TabIndex = 0;
            this.tbpRegistro.Text = "Registra Empresa Domiciliaria";
            this.tbpRegistro.UseVisualStyleBackColor = true;
            // 
            // pnlRegistro
            // 
            this.pnlRegistro.Controls.Add(this.txtNitcamara);
            this.pnlRegistro.Controls.Add(this.dtpFecha);
            this.pnlRegistro.Controls.Add(this.txtNombre);
            this.pnlRegistro.Controls.Add(this.btnGuardar);
            this.pnlRegistro.Controls.Add(this.lbComnit);
            this.pnlRegistro.Controls.Add(this.lbFecha);
            this.pnlRegistro.Controls.Add(this.lbNombre);
            this.pnlRegistro.Controls.Add(this.lbNit);
            this.pnlRegistro.Controls.Add(this.lbMensaje);
            this.pnlRegistro.Controls.Add(this.txtNit);
            this.pnlRegistro.Location = new System.Drawing.Point(30, 23);
            this.pnlRegistro.Name = "pnlRegistro";
            this.pnlRegistro.Size = new System.Drawing.Size(434, 283);
            this.pnlRegistro.TabIndex = 0;
            // 
            // txtNitcamara
            // 
            this.txtNitcamara.Location = new System.Drawing.Point(210, 181);
            this.txtNitcamara.Name = "txtNitcamara";
            this.txtNitcamara.Size = new System.Drawing.Size(138, 20);
            this.txtNitcamara.TabIndex = 9;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(210, 143);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(210, 95);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(138, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(290, 234);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lbComnit
            // 
            this.lbComnit.AutoSize = true;
            this.lbComnit.Location = new System.Drawing.Point(25, 188);
            this.lbComnit.Name = "lbComnit";
            this.lbComnit.Size = new System.Drawing.Size(134, 13);
            this.lbComnit.TabIndex = 5;
            this.lbComnit.Text = "Nit de cámara de comercio";
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Location = new System.Drawing.Point(25, 143);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(102, 13);
            this.lbFecha.TabIndex = 4;
            this.lbFecha.Text = "Fecha de operación";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(25, 102);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(50, 13);
            this.lbNombre.TabIndex = 3;
            this.lbNombre.Text = "Nombre :";
            // 
            // lbNit
            // 
            this.lbNit.AutoSize = true;
            this.lbNit.Location = new System.Drawing.Point(25, 63);
            this.lbNit.Name = "lbNit";
            this.lbNit.Size = new System.Drawing.Size(26, 13);
            this.lbNit.TabIndex = 2;
            this.lbNit.Text = "Nit :";
            // 
            // tbpConsulta
            // 
            this.tbpConsulta.Controls.Add(this.pnlConsulta);
            this.tbpConsulta.Location = new System.Drawing.Point(4, 22);
            this.tbpConsulta.Name = "tbpConsulta";
            this.tbpConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tbpConsulta.Size = new System.Drawing.Size(475, 335);
            this.tbpConsulta.TabIndex = 1;
            this.tbpConsulta.Text = "Consultar Empresas";
            this.tbpConsulta.UseVisualStyleBackColor = true;
            // 
            // pnlConsulta
            // 
            this.pnlConsulta.Controls.Add(this.btnConsultarEmpresas);
            this.pnlConsulta.Controls.Add(this.dgvDatos);
            this.pnlConsulta.Location = new System.Drawing.Point(32, 27);
            this.pnlConsulta.Name = "pnlConsulta";
            this.pnlConsulta.Size = new System.Drawing.Size(415, 271);
            this.pnlConsulta.TabIndex = 0;
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(17, 57);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(374, 185);
            this.dgvDatos.TabIndex = 0;
            // 
            // btnConsultarEmpresas
            // 
            this.btnConsultarEmpresas.Location = new System.Drawing.Point(17, 20);
            this.btnConsultarEmpresas.Name = "btnConsultarEmpresas";
            this.btnConsultarEmpresas.Size = new System.Drawing.Size(136, 23);
            this.btnConsultarEmpresas.TabIndex = 1;
            this.btnConsultarEmpresas.Text = "Consultar Empresas";
            this.btnConsultarEmpresas.UseVisualStyleBackColor = true;
            this.btnConsultarEmpresas.Click += new System.EventHandler(this.btnConsultarEmpresas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 419);
            this.Controls.Add(this.tbcGestionEmpresa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tbcGestionEmpresa.ResumeLayout(false);
            this.tbpRegistro.ResumeLayout(false);
            this.pnlRegistro.ResumeLayout(false);
            this.pnlRegistro.PerformLayout();
            this.tbpConsulta.ResumeLayout(false);
            this.pnlConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.Label lbMensaje;
        private System.Windows.Forms.TabControl tbcGestionEmpresa;
        private System.Windows.Forms.TabPage tbpRegistro;
        private System.Windows.Forms.Panel pnlRegistro;
        private System.Windows.Forms.TabPage tbpConsulta;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lbComnit;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbNit;
        private System.Windows.Forms.TextBox txtNitcamara;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Panel pnlConsulta;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button btnConsultarEmpresas;
    }
}

