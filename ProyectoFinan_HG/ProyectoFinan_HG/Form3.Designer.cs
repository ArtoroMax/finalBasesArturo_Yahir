namespace ProyectoFinan_HG
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.tbpRegistro = new System.Windows.Forms.TabPage();
            this.pnlRegistro = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNit = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbNit = new System.Windows.Forms.Label();
            this.lbMensaje = new System.Windows.Forms.Label();
            this.tbcGestionarCamara = new System.Windows.Forms.TabControl();
            this.tbpConsultar = new System.Windows.Forms.TabPage();
            this.pnlConsultar = new System.Windows.Forms.Panel();
            this.btnConsultarCamara = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.tbpRegistro.SuspendLayout();
            this.pnlRegistro.SuspendLayout();
            this.tbcGestionarCamara.SuspendLayout();
            this.tbpConsultar.SuspendLayout();
            this.pnlConsultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // tbpRegistro
            // 
            this.tbpRegistro.Controls.Add(this.pnlRegistro);
            this.tbpRegistro.Location = new System.Drawing.Point(4, 22);
            this.tbpRegistro.Name = "tbpRegistro";
            this.tbpRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRegistro.Size = new System.Drawing.Size(458, 318);
            this.tbpRegistro.TabIndex = 0;
            this.tbpRegistro.Text = "Registrar Camara de comercio";
            this.tbpRegistro.UseVisualStyleBackColor = true;
            // 
            // pnlRegistro
            // 
            this.pnlRegistro.Controls.Add(this.btnGuardar);
            this.pnlRegistro.Controls.Add(this.txtNombre);
            this.pnlRegistro.Controls.Add(this.txtNit);
            this.pnlRegistro.Controls.Add(this.lbNombre);
            this.pnlRegistro.Controls.Add(this.lbNit);
            this.pnlRegistro.Controls.Add(this.lbMensaje);
            this.pnlRegistro.Location = new System.Drawing.Point(20, 21);
            this.pnlRegistro.Name = "pnlRegistro";
            this.pnlRegistro.Size = new System.Drawing.Size(415, 264);
            this.pnlRegistro.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(297, 207);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(120, 136);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtNit
            // 
            this.txtNit.Location = new System.Drawing.Point(120, 82);
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(100, 20);
            this.txtNit.TabIndex = 3;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(42, 143);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(50, 13);
            this.lbNombre.TabIndex = 2;
            this.lbNombre.Text = "Nombre :";
            // 
            // lbNit
            // 
            this.lbNit.AutoSize = true;
            this.lbNit.Location = new System.Drawing.Point(42, 89);
            this.lbNit.Name = "lbNit";
            this.lbNit.Size = new System.Drawing.Size(26, 13);
            this.lbNit.TabIndex = 1;
            this.lbNit.Text = "Nit :";
            // 
            // lbMensaje
            // 
            this.lbMensaje.AutoSize = true;
            this.lbMensaje.Location = new System.Drawing.Point(42, 40);
            this.lbMensaje.Name = "lbMensaje";
            this.lbMensaje.Size = new System.Drawing.Size(212, 13);
            this.lbMensaje.TabIndex = 0;
            this.lbMensaje.Text = "Ingrese los datos de la cámara de comercio";
            // 
            // tbcGestionarCamara
            // 
            this.tbcGestionarCamara.Controls.Add(this.tbpRegistro);
            this.tbcGestionarCamara.Controls.Add(this.tbpConsultar);
            this.tbcGestionarCamara.Location = new System.Drawing.Point(12, 23);
            this.tbcGestionarCamara.Name = "tbcGestionarCamara";
            this.tbcGestionarCamara.SelectedIndex = 0;
            this.tbcGestionarCamara.Size = new System.Drawing.Size(466, 344);
            this.tbcGestionarCamara.TabIndex = 1;
            // 
            // tbpConsultar
            // 
            this.tbpConsultar.Controls.Add(this.pnlConsultar);
            this.tbpConsultar.Location = new System.Drawing.Point(4, 22);
            this.tbpConsultar.Name = "tbpConsultar";
            this.tbpConsultar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpConsultar.Size = new System.Drawing.Size(458, 318);
            this.tbpConsultar.TabIndex = 1;
            this.tbpConsultar.Text = "Consultar cámara de comercio";
            this.tbpConsultar.UseVisualStyleBackColor = true;
            // 
            // pnlConsultar
            // 
            this.pnlConsultar.Controls.Add(this.btnConsultarCamara);
            this.pnlConsultar.Controls.Add(this.dgvDatos);
            this.pnlConsultar.Location = new System.Drawing.Point(22, 29);
            this.pnlConsultar.Name = "pnlConsultar";
            this.pnlConsultar.Size = new System.Drawing.Size(408, 264);
            this.pnlConsultar.TabIndex = 0;
            // 
            // btnConsultarCamara
            // 
            this.btnConsultarCamara.Location = new System.Drawing.Point(25, 37);
            this.btnConsultarCamara.Name = "btnConsultarCamara";
            this.btnConsultarCamara.Size = new System.Drawing.Size(176, 23);
            this.btnConsultarCamara.TabIndex = 1;
            this.btnConsultarCamara.Text = "Consultar Cámaras de comercio";
            this.btnConsultarCamara.UseVisualStyleBackColor = true;
            this.btnConsultarCamara.Click += new System.EventHandler(this.btnConsultarCamara_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(25, 79);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(357, 167);
            this.dgvDatos.TabIndex = 0;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(314, 369);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(157, 23);
            this.btnRegresar.TabIndex = 4;
            this.btnRegresar.Text = "Regresar al menu principal";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinan_HG.Properties.Resources.istockphoto_923699806_170667a;
            this.ClientSize = new System.Drawing.Size(500, 406);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.tbcGestionarCamara);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Camara de Comercio";
            this.tbpRegistro.ResumeLayout(false);
            this.pnlRegistro.ResumeLayout(false);
            this.pnlRegistro.PerformLayout();
            this.tbcGestionarCamara.ResumeLayout(false);
            this.tbpConsultar.ResumeLayout(false);
            this.pnlConsultar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tbpRegistro;
        private System.Windows.Forms.Panel pnlRegistro;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbNit;
        private System.Windows.Forms.Label lbMensaje;
        private System.Windows.Forms.TabControl tbcGestionarCamara;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TabPage tbpConsultar;
        private System.Windows.Forms.Panel pnlConsultar;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button btnConsultarCamara;
        private System.Windows.Forms.Button btnRegresar;
    }
}