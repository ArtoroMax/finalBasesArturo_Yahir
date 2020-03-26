namespace ProyectoFinan_HG
{
    partial class Form5
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
            this.tbpRegistrar = new System.Windows.Forms.TabPage();
            this.tbcTrabaja = new System.Windows.Forms.TabControl();
            this.pnlVinculacion = new System.Windows.Forms.Panel();
            this.lbMensaje = new System.Windows.Forms.Label();
            this.lbNit = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.lbFechaIn = new System.Windows.Forms.Label();
            this.lbFechaFin = new System.Windows.Forms.Label();
            this.txtNit = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.dtpFechaIn = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tbpRegistrar.SuspendLayout();
            this.tbcTrabaja.SuspendLayout();
            this.pnlVinculacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbpRegistrar
            // 
            this.tbpRegistrar.Controls.Add(this.pnlVinculacion);
            this.tbpRegistrar.Location = new System.Drawing.Point(4, 22);
            this.tbpRegistrar.Name = "tbpRegistrar";
            this.tbpRegistrar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRegistrar.Size = new System.Drawing.Size(452, 325);
            this.tbpRegistrar.TabIndex = 0;
            this.tbpRegistrar.Text = "Registrar vinculación";
            this.tbpRegistrar.UseVisualStyleBackColor = true;
            // 
            // tbcTrabaja
            // 
            this.tbcTrabaja.Controls.Add(this.tbpRegistrar);
            this.tbcTrabaja.Location = new System.Drawing.Point(22, 21);
            this.tbcTrabaja.Name = "tbcTrabaja";
            this.tbcTrabaja.SelectedIndex = 0;
            this.tbcTrabaja.Size = new System.Drawing.Size(460, 351);
            this.tbcTrabaja.TabIndex = 0;
            // 
            // pnlVinculacion
            // 
            this.pnlVinculacion.Controls.Add(this.btnGuardar);
            this.pnlVinculacion.Controls.Add(this.dtpFechaFin);
            this.pnlVinculacion.Controls.Add(this.dtpFechaIn);
            this.pnlVinculacion.Controls.Add(this.txtId);
            this.pnlVinculacion.Controls.Add(this.txtNit);
            this.pnlVinculacion.Controls.Add(this.lbFechaFin);
            this.pnlVinculacion.Controls.Add(this.lbFechaIn);
            this.pnlVinculacion.Controls.Add(this.lbId);
            this.pnlVinculacion.Controls.Add(this.lbNit);
            this.pnlVinculacion.Controls.Add(this.lbMensaje);
            this.pnlVinculacion.Location = new System.Drawing.Point(34, 29);
            this.pnlVinculacion.Name = "pnlVinculacion";
            this.pnlVinculacion.Size = new System.Drawing.Size(397, 258);
            this.pnlVinculacion.TabIndex = 0;
            // 
            // lbMensaje
            // 
            this.lbMensaje.AutoSize = true;
            this.lbMensaje.Location = new System.Drawing.Point(29, 27);
            this.lbMensaje.Name = "lbMensaje";
            this.lbMensaje.Size = new System.Drawing.Size(175, 13);
            this.lbMensaje.TabIndex = 0;
            this.lbMensaje.Text = "Registrar vinculación de domiciliario";
            // 
            // lbNit
            // 
            this.lbNit.AutoSize = true;
            this.lbNit.Location = new System.Drawing.Point(32, 59);
            this.lbNit.Name = "lbNit";
            this.lbNit.Size = new System.Drawing.Size(95, 13);
            this.lbNit.TabIndex = 1;
            this.lbNit.Text = "Nit de la empresa :";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(32, 94);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(93, 13);
            this.lbId.TabIndex = 2;
            this.lbId.Text = "Id del domiciliario :";
            // 
            // lbFechaIn
            // 
            this.lbFechaIn.AutoSize = true;
            this.lbFechaIn.Location = new System.Drawing.Point(32, 133);
            this.lbFechaIn.Name = "lbFechaIn";
            this.lbFechaIn.Size = new System.Drawing.Size(85, 13);
            this.lbFechaIn.TabIndex = 3;
            this.lbFechaIn.Text = "Fecha de inicio :";
            // 
            // lbFechaFin
            // 
            this.lbFechaFin.AutoSize = true;
            this.lbFechaFin.Location = new System.Drawing.Point(32, 170);
            this.lbFechaFin.Name = "lbFechaFin";
            this.lbFechaFin.Size = new System.Drawing.Size(60, 13);
            this.lbFechaFin.TabIndex = 4;
            this.lbFechaFin.Text = "Fecha Fin :";
            // 
            // txtNit
            // 
            this.txtNit.Location = new System.Drawing.Point(167, 51);
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(100, 20);
            this.txtNit.TabIndex = 5;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(167, 87);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 6;
            // 
            // dtpFechaIn
            // 
            this.dtpFechaIn.Location = new System.Drawing.Point(167, 125);
            this.dtpFechaIn.Name = "dtpFechaIn";
            this.dtpFechaIn.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaIn.TabIndex = 7;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(167, 162);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFin.TabIndex = 8;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(299, 217);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 407);
            this.Controls.Add(this.tbcTrabaja);
            this.Name = "Form5";
            this.Text = "Form5";
            this.tbpRegistrar.ResumeLayout(false);
            this.tbcTrabaja.ResumeLayout(false);
            this.pnlVinculacion.ResumeLayout(false);
            this.pnlVinculacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tbpRegistrar;
        private System.Windows.Forms.Panel pnlVinculacion;
        private System.Windows.Forms.Label lbFechaFin;
        private System.Windows.Forms.Label lbFechaIn;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbNit;
        private System.Windows.Forms.Label lbMensaje;
        private System.Windows.Forms.TabControl tbcTrabaja;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaIn;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNit;
    }
}