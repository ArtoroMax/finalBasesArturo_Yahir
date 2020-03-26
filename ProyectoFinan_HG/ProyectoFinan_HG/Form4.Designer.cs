namespace ProyectoFinan_HG
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbpFecha = new System.Windows.Forms.TabPage();
            this.pnlFecha = new System.Windows.Forms.Panel();
            this.lbMensaje = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnActivos = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tbcConsultas = new System.Windows.Forms.TabControl();
            this.pnlInformacion = new System.Windows.Forms.Panel();
            this.dgvInformacion = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.tbpInformacion = new System.Windows.Forms.TabPage();
            this.txtRes = new System.Windows.Forms.TextBox();
            this.lbDatos = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.Label();
            this.tbpFecha.SuspendLayout();
            this.pnlFecha.SuspendLayout();
            this.tbcConsultas.SuspendLayout();
            this.pnlInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformacion)).BeginInit();
            this.tbpInformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbpFecha
            // 
            this.tbpFecha.Controls.Add(this.pnlFecha);
            this.tbpFecha.Location = new System.Drawing.Point(4, 22);
            this.tbpFecha.Name = "tbpFecha";
            this.tbpFecha.Padding = new System.Windows.Forms.Padding(3);
            this.tbpFecha.Size = new System.Drawing.Size(552, 345);
            this.tbpFecha.TabIndex = 2;
            this.tbpFecha.Text = "Consultar por fecha";
            this.tbpFecha.UseVisualStyleBackColor = true;
            // 
            // pnlFecha
            // 
            this.pnlFecha.Controls.Add(this.lbResultado);
            this.pnlFecha.Controls.Add(this.lbDatos);
            this.pnlFecha.Controls.Add(this.txtRes);
            this.pnlFecha.Controls.Add(this.btnBuscar);
            this.pnlFecha.Controls.Add(this.btnActivos);
            this.pnlFecha.Controls.Add(this.dtpFecha);
            this.pnlFecha.Controls.Add(this.lbMensaje);
            this.pnlFecha.Location = new System.Drawing.Point(39, 27);
            this.pnlFecha.Name = "pnlFecha";
            this.pnlFecha.Size = new System.Drawing.Size(448, 279);
            this.pnlFecha.TabIndex = 0;
            // 
            // lbMensaje
            // 
            this.lbMensaje.AutoSize = true;
            this.lbMensaje.Location = new System.Drawing.Point(19, 35);
            this.lbMensaje.Name = "lbMensaje";
            this.lbMensaje.Size = new System.Drawing.Size(281, 13);
            this.lbMensaje.TabIndex = 0;
            this.lbMensaje.Text = "Seleccione la fecha de inicio de trabajo que desea buscar";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(22, 64);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 1;
            // 
            // btnActivos
            // 
            this.btnActivos.Location = new System.Drawing.Point(22, 199);
            this.btnActivos.Name = "btnActivos";
            this.btnActivos.Size = new System.Drawing.Size(193, 23);
            this.btnActivos.TabIndex = 0;
            this.btnActivos.Text = "Consultar domiciliarios activos";
            this.btnActivos.UseVisualStyleBackColor = true;
            this.btnActivos.Click += new System.EventHandler(this.btnActivos_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(22, 90);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tbcConsultas
            // 
            this.tbcConsultas.Controls.Add(this.tbpInformacion);
            this.tbcConsultas.Controls.Add(this.tbpFecha);
            this.tbcConsultas.Location = new System.Drawing.Point(12, 12);
            this.tbcConsultas.Name = "tbcConsultas";
            this.tbcConsultas.SelectedIndex = 0;
            this.tbcConsultas.Size = new System.Drawing.Size(560, 371);
            this.tbcConsultas.TabIndex = 0;
            // 
            // pnlInformacion
            // 
            this.pnlInformacion.Controls.Add(this.btnConsultar);
            this.pnlInformacion.Controls.Add(this.dgvInformacion);
            this.pnlInformacion.Location = new System.Drawing.Point(22, 17);
            this.pnlInformacion.Name = "pnlInformacion";
            this.pnlInformacion.Size = new System.Drawing.Size(372, 245);
            this.pnlInformacion.TabIndex = 0;
            // 
            // dgvInformacion
            // 
            this.dgvInformacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInformacion.Location = new System.Drawing.Point(68, 70);
            this.dgvInformacion.Name = "dgvInformacion";
            this.dgvInformacion.Size = new System.Drawing.Size(240, 150);
            this.dgvInformacion.TabIndex = 0;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(68, 25);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(195, 23);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar toda la información";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // tbpInformacion
            // 
            this.tbpInformacion.Controls.Add(this.pnlInformacion);
            this.tbpInformacion.Location = new System.Drawing.Point(4, 22);
            this.tbpInformacion.Name = "tbpInformacion";
            this.tbpInformacion.Padding = new System.Windows.Forms.Padding(3);
            this.tbpInformacion.Size = new System.Drawing.Size(552, 345);
            this.tbpInformacion.TabIndex = 0;
            this.tbpInformacion.Text = "Consulta general";
            this.tbpInformacion.UseVisualStyleBackColor = true;
            // 
            // txtRes
            // 
            this.txtRes.Location = new System.Drawing.Point(22, 246);
            this.txtRes.Name = "txtRes";
            this.txtRes.Size = new System.Drawing.Size(100, 20);
            this.txtRes.TabIndex = 3;
            this.txtRes.TextChanged += new System.EventHandler(this.txtRes_TextChanged);
            // 
            // lbDatos
            // 
            this.lbDatos.AutoSize = true;
            this.lbDatos.Location = new System.Drawing.Point(22, 133);
            this.lbDatos.Name = "lbDatos";
            this.lbDatos.Size = new System.Drawing.Size(41, 13);
            this.lbDatos.TabIndex = 4;
            this.lbDatos.Text = "Datos :";
            this.lbDatos.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(25, 163);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(10, 13);
            this.lbResultado.TabIndex = 5;
            this.lbResultado.Text = "-";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 402);
            this.Controls.Add(this.tbcConsultas);
            this.Name = "Form4";
            this.Text = "Form4";
            this.tbpFecha.ResumeLayout(false);
            this.pnlFecha.ResumeLayout(false);
            this.pnlFecha.PerformLayout();
            this.tbcConsultas.ResumeLayout(false);
            this.pnlInformacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformacion)).EndInit();
            this.tbpInformacion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tbpFecha;
        private System.Windows.Forms.Panel pnlFecha;
        private System.Windows.Forms.TextBox txtRes;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnActivos;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lbMensaje;
        private System.Windows.Forms.TabControl tbcConsultas;
        private System.Windows.Forms.TabPage tbpInformacion;
        private System.Windows.Forms.Panel pnlInformacion;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dgvInformacion;
        private System.Windows.Forms.Label lbDatos;
        private System.Windows.Forms.Label lbResultado;
    }
}