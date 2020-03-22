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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlRegistro = new System.Windows.Forms.Panel();
            this.lbMensaje = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbApellido = new System.Windows.Forms.Label();
            this.lbAnioexp = new System.Windows.Forms.Label();
            this.lbEstado = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.cbxAnios = new System.Windows.Forms.ComboBox();
            this.rbActivo = new System.Windows.Forms.RadioButton();
            this.rbInactivo = new System.Windows.Forms.RadioButton();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tbcGestionDomiciliario.SuspendLayout();
            this.tbpRegistro.SuspendLayout();
            this.pnlRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcGestionDomiciliario
            // 
            this.tbcGestionDomiciliario.Controls.Add(this.tbpRegistro);
            this.tbcGestionDomiciliario.Controls.Add(this.tabPage2);
            this.tbcGestionDomiciliario.Location = new System.Drawing.Point(12, 24);
            this.tbcGestionDomiciliario.Name = "tbcGestionDomiciliario";
            this.tbcGestionDomiciliario.SelectedIndex = 0;
            this.tbcGestionDomiciliario.Size = new System.Drawing.Size(598, 418);
            this.tbcGestionDomiciliario.TabIndex = 0;
            // 
            // tbpRegistro
            // 
            this.tbpRegistro.Controls.Add(this.pnlRegistro);
            this.tbpRegistro.Location = new System.Drawing.Point(4, 22);
            this.tbpRegistro.Name = "tbpRegistro";
            this.tbpRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRegistro.Size = new System.Drawing.Size(590, 392);
            this.tbpRegistro.TabIndex = 0;
            this.tbpRegistro.Text = "Registrar Domiciliario";
            this.tbpRegistro.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.pnlRegistro.Location = new System.Drawing.Point(34, 38);
            this.pnlRegistro.Name = "pnlRegistro";
            this.pnlRegistro.Size = new System.Drawing.Size(520, 315);
            this.pnlRegistro.TabIndex = 0;
            // 
            // lbMensaje
            // 
            this.lbMensaje.AutoSize = true;
            this.lbMensaje.Location = new System.Drawing.Point(77, 46);
            this.lbMensaje.Name = "lbMensaje";
            this.lbMensaje.Size = new System.Drawing.Size(158, 13);
            this.lbMensaje.TabIndex = 0;
            this.lbMensaje.Text = "Ingrese los datos del domiciliario";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(77, 104);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(79, 13);
            this.lbId.TabIndex = 1;
            this.lbId.Text = "Identificación : ";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(77, 137);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(55, 13);
            this.lbNombre.TabIndex = 2;
            this.lbNombre.Text = "Nombres :";
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Location = new System.Drawing.Point(77, 174);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(58, 13);
            this.lbApellido.TabIndex = 3;
            this.lbApellido.Text = "Apellidos : ";
            // 
            // lbAnioexp
            // 
            this.lbAnioexp.AutoSize = true;
            this.lbAnioexp.Location = new System.Drawing.Point(77, 206);
            this.lbAnioexp.Name = "lbAnioexp";
            this.lbAnioexp.Size = new System.Drawing.Size(109, 13);
            this.lbAnioexp.TabIndex = 4;
            this.lbAnioexp.Text = "Años de experiencia :";
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Location = new System.Drawing.Point(77, 241);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(46, 13);
            this.lbEstado.TabIndex = 5;
            this.lbEstado.Text = "Estado :";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(216, 97);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(216, 130);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(216, 167);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 8;
            // 
            // cbxAnios
            // 
            this.cbxAnios.FormattingEnabled = true;
            this.cbxAnios.Items.AddRange(new object[] {
            "menos de 5",
            "entre 5 y 10",
            "entre 11 y 20",
            "más de 20"});
            this.cbxAnios.Location = new System.Drawing.Point(216, 203);
            this.cbxAnios.Name = "cbxAnios";
            this.cbxAnios.Size = new System.Drawing.Size(121, 21);
            this.cbxAnios.TabIndex = 9;
            // 
            // rbActivo
            // 
            this.rbActivo.AutoSize = true;
            this.rbActivo.Location = new System.Drawing.Point(216, 241);
            this.rbActivo.Name = "rbActivo";
            this.rbActivo.Size = new System.Drawing.Size(55, 17);
            this.rbActivo.TabIndex = 10;
            this.rbActivo.TabStop = true;
            this.rbActivo.Text = "Activo";
            this.rbActivo.UseVisualStyleBackColor = true;
            // 
            // rbInactivo
            // 
            this.rbInactivo.AutoSize = true;
            this.rbInactivo.Location = new System.Drawing.Point(341, 241);
            this.rbInactivo.Name = "rbInactivo";
            this.rbInactivo.Size = new System.Drawing.Size(63, 17);
            this.rbInactivo.TabIndex = 11;
            this.rbInactivo.TabStop = true;
            this.rbInactivo.Text = "Inactivo";
            this.rbInactivo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(416, 277);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 481);
            this.Controls.Add(this.tbcGestionDomiciliario);
            this.Name = "Form2";
            this.Text = "Form2";
            this.tbcGestionDomiciliario.ResumeLayout(false);
            this.tbpRegistro.ResumeLayout(false);
            this.pnlRegistro.ResumeLayout(false);
            this.pnlRegistro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcGestionDomiciliario;
        private System.Windows.Forms.TabPage tbpRegistro;
        private System.Windows.Forms.TabPage tabPage2;
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
    }
}