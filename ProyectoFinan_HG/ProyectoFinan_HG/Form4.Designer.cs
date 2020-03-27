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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.tbpFecha = new System.Windows.Forms.TabPage();
            this.pnlFecha = new System.Windows.Forms.Panel();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnActivos = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lbMensaje = new System.Windows.Forms.Label();
            this.tbcConsultas = new System.Windows.Forms.TabControl();
            this.tbpInformacion = new System.Windows.Forms.TabPage();
            this.pnlInformacion = new System.Windows.Forms.Panel();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvInformacion = new System.Windows.Forms.DataGridView();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.dgvInformacion2 = new System.Windows.Forms.DataGridView();
            this.tbpFecha.SuspendLayout();
            this.pnlFecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.tbcConsultas.SuspendLayout();
            this.tbpInformacion.SuspendLayout();
            this.pnlInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformacion2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbpFecha
            // 
            this.tbpFecha.Controls.Add(this.pnlFecha);
            this.tbpFecha.Location = new System.Drawing.Point(4, 22);
            this.tbpFecha.Name = "tbpFecha";
            this.tbpFecha.Padding = new System.Windows.Forms.Padding(3);
            this.tbpFecha.Size = new System.Drawing.Size(527, 395);
            this.tbpFecha.TabIndex = 2;
            this.tbpFecha.Text = "Consultar por fecha";
            this.tbpFecha.UseVisualStyleBackColor = true;
            // 
            // pnlFecha
            // 
            this.pnlFecha.Controls.Add(this.dgvInformacion2);
            this.pnlFecha.Controls.Add(this.dgvResultado);
            this.pnlFecha.Controls.Add(this.btnBuscar);
            this.pnlFecha.Controls.Add(this.btnActivos);
            this.pnlFecha.Controls.Add(this.dtpFecha);
            this.pnlFecha.Controls.Add(this.lbMensaje);
            this.pnlFecha.Location = new System.Drawing.Point(39, 27);
            this.pnlFecha.Name = "pnlFecha";
            this.pnlFecha.Size = new System.Drawing.Size(448, 350);
            this.pnlFecha.TabIndex = 0;
            // 
            // dgvResultado
            // 
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Location = new System.Drawing.Point(22, 130);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.Size = new System.Drawing.Size(402, 81);
            this.dgvResultado.TabIndex = 4;
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
            // btnActivos
            // 
            this.btnActivos.Location = new System.Drawing.Point(22, 217);
            this.btnActivos.Name = "btnActivos";
            this.btnActivos.Size = new System.Drawing.Size(193, 23);
            this.btnActivos.TabIndex = 0;
            this.btnActivos.Text = "Consultar domiciliarios activos";
            this.btnActivos.UseVisualStyleBackColor = true;
            this.btnActivos.Click += new System.EventHandler(this.btnActivos_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(22, 64);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 1;
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
            // tbcConsultas
            // 
            this.tbcConsultas.Controls.Add(this.tbpInformacion);
            this.tbcConsultas.Controls.Add(this.tbpFecha);
            this.tbcConsultas.Location = new System.Drawing.Point(12, 12);
            this.tbcConsultas.Name = "tbcConsultas";
            this.tbcConsultas.SelectedIndex = 0;
            this.tbcConsultas.Size = new System.Drawing.Size(535, 421);
            this.tbcConsultas.TabIndex = 0;
            // 
            // tbpInformacion
            // 
            this.tbpInformacion.Controls.Add(this.pnlInformacion);
            this.tbpInformacion.Location = new System.Drawing.Point(4, 22);
            this.tbpInformacion.Name = "tbpInformacion";
            this.tbpInformacion.Padding = new System.Windows.Forms.Padding(3);
            this.tbpInformacion.Size = new System.Drawing.Size(527, 313);
            this.tbpInformacion.TabIndex = 0;
            this.tbpInformacion.Text = "Consulta general";
            this.tbpInformacion.UseVisualStyleBackColor = true;
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
            // dgvInformacion
            // 
            this.dgvInformacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInformacion.Location = new System.Drawing.Point(68, 70);
            this.dgvInformacion.Name = "dgvInformacion";
            this.dgvInformacion.Size = new System.Drawing.Size(240, 150);
            this.dgvInformacion.TabIndex = 0;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(390, 439);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(157, 23);
            this.btnRegresar.TabIndex = 4;
            this.btnRegresar.Text = "Regresar al menu principal";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // dgvInformacion2
            // 
            this.dgvInformacion2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInformacion2.Location = new System.Drawing.Point(22, 246);
            this.dgvInformacion2.Name = "dgvInformacion2";
            this.dgvInformacion2.Size = new System.Drawing.Size(402, 79);
            this.dgvInformacion2.TabIndex = 5;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinan_HG.Properties.Resources.istockphoto_923699806_170667a;
            this.ClientSize = new System.Drawing.Size(593, 524);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.tbcConsultas);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Consulta General";
            this.tbpFecha.ResumeLayout(false);
            this.pnlFecha.ResumeLayout(false);
            this.pnlFecha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.tbcConsultas.ResumeLayout(false);
            this.tbpInformacion.ResumeLayout(false);
            this.pnlInformacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformacion2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tbpFecha;
        private System.Windows.Forms.Panel pnlFecha;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnActivos;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lbMensaje;
        private System.Windows.Forms.TabControl tbcConsultas;
        private System.Windows.Forms.TabPage tbpInformacion;
        private System.Windows.Forms.Panel pnlInformacion;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dgvInformacion;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.DataGridView dgvInformacion2;
    }
}