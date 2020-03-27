namespace ProyectoFinan_HG
{
    partial class Form2
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
            this.tbcGestionDomiciliario = new System.Windows.Forms.TabControl();
            this.tbpRegistro = new System.Windows.Forms.TabPage();
            this.pnlRegistro = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.rbInactivo = new System.Windows.Forms.RadioButton();
            this.rbActivo = new System.Windows.Forms.RadioButton();
            this.cbxAnios = new System.Windows.Forms.ComboBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lbEstado = new System.Windows.Forms.Label();
            this.lbAnioexp = new System.Windows.Forms.Label();
            this.lbApellido = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.lbMensaje = new System.Windows.Forms.Label();
            this.tbpConsulta = new System.Windows.Forms.TabPage();
            this.pnlConsulta = new System.Windows.Forms.Panel();
            this.btnConsultarDomiciliarios = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.tbpEliminar = new System.Windows.Forms.TabPage();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtIdEliminar = new System.Windows.Forms.TextBox();
            this.lbEliminar = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.tbcGestionDomiciliario.SuspendLayout();
            this.tbpRegistro.SuspendLayout();
            this.pnlRegistro.SuspendLayout();
            this.tbpConsulta.SuspendLayout();
            this.pnlConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.tbpEliminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcGestionDomiciliario
            // 
            this.tbcGestionDomiciliario.Controls.Add(this.tbpRegistro);
            this.tbcGestionDomiciliario.Controls.Add(this.tbpConsulta);
            this.tbcGestionDomiciliario.Controls.Add(this.tbpEliminar);
            this.tbcGestionDomiciliario.Location = new System.Drawing.Point(12, 24);
            this.tbcGestionDomiciliario.Name = "tbcGestionDomiciliario";
            this.tbcGestionDomiciliario.SelectedIndex = 0;
            this.tbcGestionDomiciliario.Size = new System.Drawing.Size(498, 386);
            this.tbcGestionDomiciliario.TabIndex = 0;
            // 
            // tbpRegistro
            // 
            this.tbpRegistro.Controls.Add(this.pnlRegistro);
            this.tbpRegistro.Location = new System.Drawing.Point(4, 22);
            this.tbpRegistro.Name = "tbpRegistro";
            this.tbpRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRegistro.Size = new System.Drawing.Size(490, 360);
            this.tbpRegistro.TabIndex = 0;
            this.tbpRegistro.Text = "Registrar Domiciliario";
            this.tbpRegistro.UseVisualStyleBackColor = true;
            // 
            // pnlRegistro
            // 
            this.pnlRegistro.Controls.Add(this.btnGuardar);
            this.pnlRegistro.Controls.Add(this.rbInactivo);
            this.pnlRegistro.Controls.Add(this.rbActivo);
            this.pnlRegistro.Controls.Add(this.cbxAnios);
            this.pnlRegistro.Controls.Add(this.txtApellido);
            this.pnlRegistro.Controls.Add(this.txtNombre);
            this.pnlRegistro.Controls.Add(this.txtId);
            this.pnlRegistro.Controls.Add(this.lbEstado);
            this.pnlRegistro.Controls.Add(this.lbAnioexp);
            this.pnlRegistro.Controls.Add(this.lbApellido);
            this.pnlRegistro.Controls.Add(this.lbNombre);
            this.pnlRegistro.Controls.Add(this.lbId);
            this.pnlRegistro.Controls.Add(this.lbMensaje);
            this.pnlRegistro.Location = new System.Drawing.Point(15, 17);
            this.pnlRegistro.Name = "pnlRegistro";
            this.pnlRegistro.Size = new System.Drawing.Size(458, 315);
            this.pnlRegistro.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(363, 272);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // rbInactivo
            // 
            this.rbInactivo.AutoSize = true;
            this.rbInactivo.Location = new System.Drawing.Point(259, 227);
            this.rbInactivo.Name = "rbInactivo";
            this.rbInactivo.Size = new System.Drawing.Size(63, 17);
            this.rbInactivo.TabIndex = 11;
            this.rbInactivo.TabStop = true;
            this.rbInactivo.Text = "Inactivo";
            this.rbInactivo.UseVisualStyleBackColor = true;
            // 
            // rbActivo
            // 
            this.rbActivo.AutoSize = true;
            this.rbActivo.Location = new System.Drawing.Point(180, 227);
            this.rbActivo.Name = "rbActivo";
            this.rbActivo.Size = new System.Drawing.Size(55, 17);
            this.rbActivo.TabIndex = 10;
            this.rbActivo.TabStop = true;
            this.rbActivo.Text = "Activo";
            this.rbActivo.UseVisualStyleBackColor = true;
            // 
            // cbxAnios
            // 
            this.cbxAnios.FormattingEnabled = true;
            this.cbxAnios.Items.AddRange(new object[] {
            "menos de 5",
            "entre 5 y 10",
            "de 11 a 20",
            "mas de 20"});
            this.cbxAnios.Location = new System.Drawing.Point(180, 187);
            this.cbxAnios.Name = "cbxAnios";
            this.cbxAnios.Size = new System.Drawing.Size(121, 21);
            this.cbxAnios.TabIndex = 9;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(180, 151);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(180, 109);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(180, 73);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 6;
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Location = new System.Drawing.Point(28, 231);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(46, 13);
            this.lbEstado.TabIndex = 5;
            this.lbEstado.Text = "Estado :";
            // 
            // lbAnioexp
            // 
            this.lbAnioexp.AutoSize = true;
            this.lbAnioexp.Location = new System.Drawing.Point(28, 195);
            this.lbAnioexp.Name = "lbAnioexp";
            this.lbAnioexp.Size = new System.Drawing.Size(109, 13);
            this.lbAnioexp.TabIndex = 4;
            this.lbAnioexp.Text = "Años de experiencia :";
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Location = new System.Drawing.Point(28, 158);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(58, 13);
            this.lbApellido.TabIndex = 3;
            this.lbApellido.Text = "Apellidos : ";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(28, 116);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(55, 13);
            this.lbNombre.TabIndex = 2;
            this.lbNombre.Text = "Nombres :";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(28, 80);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(79, 13);
            this.lbId.TabIndex = 1;
            this.lbId.Text = "Identificación : ";
            // 
            // lbMensaje
            // 
            this.lbMensaje.AutoSize = true;
            this.lbMensaje.Location = new System.Drawing.Point(28, 22);
            this.lbMensaje.Name = "lbMensaje";
            this.lbMensaje.Size = new System.Drawing.Size(158, 13);
            this.lbMensaje.TabIndex = 0;
            this.lbMensaje.Text = "Ingrese los datos del domiciliario";
            this.lbMensaje.Click += new System.EventHandler(this.lbMensaje_Click);
            // 
            // tbpConsulta
            // 
            this.tbpConsulta.Controls.Add(this.pnlConsulta);
            this.tbpConsulta.Location = new System.Drawing.Point(4, 22);
            this.tbpConsulta.Name = "tbpConsulta";
            this.tbpConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tbpConsulta.Size = new System.Drawing.Size(490, 360);
            this.tbpConsulta.TabIndex = 1;
            this.tbpConsulta.Text = "Consultar Domiciliarios";
            this.tbpConsulta.UseVisualStyleBackColor = true;
            // 
            // pnlConsulta
            // 
            this.pnlConsulta.Controls.Add(this.btnConsultarDomiciliarios);
            this.pnlConsulta.Controls.Add(this.dgvDatos);
            this.pnlConsulta.Location = new System.Drawing.Point(17, 22);
            this.pnlConsulta.Name = "pnlConsulta";
            this.pnlConsulta.Size = new System.Drawing.Size(453, 317);
            this.pnlConsulta.TabIndex = 0;
            // 
            // btnConsultarDomiciliarios
            // 
            this.btnConsultarDomiciliarios.Location = new System.Drawing.Point(19, 34);
            this.btnConsultarDomiciliarios.Name = "btnConsultarDomiciliarios";
            this.btnConsultarDomiciliarios.Size = new System.Drawing.Size(148, 23);
            this.btnConsultarDomiciliarios.TabIndex = 1;
            this.btnConsultarDomiciliarios.Text = "Consultar Domiciliarios";
            this.btnConsultarDomiciliarios.UseVisualStyleBackColor = true;
            this.btnConsultarDomiciliarios.Click += new System.EventHandler(this.btnConsultarDomiciliarios_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(19, 71);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(413, 209);
            this.dgvDatos.TabIndex = 0;
            // 
            // tbpEliminar
            // 
            this.tbpEliminar.Controls.Add(this.btnEliminar);
            this.tbpEliminar.Controls.Add(this.txtIdEliminar);
            this.tbpEliminar.Controls.Add(this.lbEliminar);
            this.tbpEliminar.Location = new System.Drawing.Point(4, 22);
            this.tbpEliminar.Name = "tbpEliminar";
            this.tbpEliminar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpEliminar.Size = new System.Drawing.Size(490, 360);
            this.tbpEliminar.TabIndex = 2;
            this.tbpEliminar.Text = "Eliminar Domiciliario";
            this.tbpEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(259, 110);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(119, 20);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtIdEliminar
            // 
            this.txtIdEliminar.Location = new System.Drawing.Point(259, 46);
            this.txtIdEliminar.Name = "txtIdEliminar";
            this.txtIdEliminar.Size = new System.Drawing.Size(129, 20);
            this.txtIdEliminar.TabIndex = 1;
            // 
            // lbEliminar
            // 
            this.lbEliminar.AutoSize = true;
            this.lbEliminar.Location = new System.Drawing.Point(28, 53);
            this.lbEliminar.Name = "lbEliminar";
            this.lbEliminar.Size = new System.Drawing.Size(177, 13);
            this.lbEliminar.TabIndex = 0;
            this.lbEliminar.Text = "Ingrese id del domiciliario a eliminar :";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(353, 412);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(157, 23);
            this.btnRegresar.TabIndex = 4;
            this.btnRegresar.Text = "Regresar al menu principal";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 442);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.tbcGestionDomiciliario);
            this.Name = "Form2";
            this.Text = "Form2";
            this.tbcGestionDomiciliario.ResumeLayout(false);
            this.tbpRegistro.ResumeLayout(false);
            this.pnlRegistro.ResumeLayout(false);
            this.pnlRegistro.PerformLayout();
            this.tbpConsulta.ResumeLayout(false);
            this.pnlConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.tbpEliminar.ResumeLayout(false);
            this.tbpEliminar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcGestionDomiciliario;
        private System.Windows.Forms.TabPage tbpRegistro;
        private System.Windows.Forms.TabPage tbpConsulta;
        private System.Windows.Forms.Panel pnlRegistro;
        private System.Windows.Forms.RadioButton rbInactivo;
        private System.Windows.Forms.RadioButton rbActivo;
        private System.Windows.Forms.ComboBox cbxAnios;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.Label lbAnioexp;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbMensaje;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel pnlConsulta;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button btnConsultarDomiciliarios;
        private System.Windows.Forms.TabPage tbpEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtIdEliminar;
        private System.Windows.Forms.Label lbEliminar;
        private System.Windows.Forms.Button btnRegresar;
    }
}