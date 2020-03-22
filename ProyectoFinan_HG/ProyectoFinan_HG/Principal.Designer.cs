namespace ProyectoFinan_HG
{
    partial class Principal
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
            this.b = new System.Windows.Forms.Panel();
            this.btnCamarasDeComercio = new System.Windows.Forms.Button();
            this.btnDomiciliarios = new System.Windows.Forms.Button();
            this.btnEmpresas = new System.Windows.Forms.Button();
            this.btnTodaInfo = new System.Windows.Forms.Button();
            this.b.SuspendLayout();
            this.SuspendLayout();
            // 
            // b
            // 
            this.b.Controls.Add(this.btnTodaInfo);
            this.b.Controls.Add(this.btnCamarasDeComercio);
            this.b.Controls.Add(this.btnDomiciliarios);
            this.b.Controls.Add(this.btnEmpresas);
            this.b.Location = new System.Drawing.Point(67, 132);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(656, 282);
            this.b.TabIndex = 0;
            // 
            // btnCamarasDeComercio
            // 
            this.btnCamarasDeComercio.Location = new System.Drawing.Point(146, 115);
            this.btnCamarasDeComercio.Name = "btnCamarasDeComercio";
            this.btnCamarasDeComercio.Size = new System.Drawing.Size(361, 43);
            this.btnCamarasDeComercio.TabIndex = 2;
            this.btnCamarasDeComercio.Text = "Cámaras De Comercio";
            this.btnCamarasDeComercio.UseVisualStyleBackColor = true;
            this.btnCamarasDeComercio.Click += new System.EventHandler(this.btnCamarasDeComercio_Click);
            // 
            // btnDomiciliarios
            // 
            this.btnDomiciliarios.Location = new System.Drawing.Point(146, 66);
            this.btnDomiciliarios.Name = "btnDomiciliarios";
            this.btnDomiciliarios.Size = new System.Drawing.Size(361, 43);
            this.btnDomiciliarios.TabIndex = 1;
            this.btnDomiciliarios.Text = "Domiciliarios";
            this.btnDomiciliarios.UseVisualStyleBackColor = true;
            this.btnDomiciliarios.Click += new System.EventHandler(this.btnDomiciliarios_Click);
            // 
            // btnEmpresas
            // 
            this.btnEmpresas.Location = new System.Drawing.Point(146, 17);
            this.btnEmpresas.Name = "btnEmpresas";
            this.btnEmpresas.Size = new System.Drawing.Size(361, 43);
            this.btnEmpresas.TabIndex = 0;
            this.btnEmpresas.Text = "Empresas";
            this.btnEmpresas.UseVisualStyleBackColor = true;
            this.btnEmpresas.Click += new System.EventHandler(this.btnEmpresas_Click);
            // 
            // btnTodaInfo
            // 
            this.btnTodaInfo.Location = new System.Drawing.Point(146, 164);
            this.btnTodaInfo.Name = "btnTodaInfo";
            this.btnTodaInfo.Size = new System.Drawing.Size(361, 43);
            this.btnTodaInfo.TabIndex = 3;
            this.btnTodaInfo.Text = "Toda la información";
            this.btnTodaInfo.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.b);
            this.Name = "Principal";
            this.Text = "Menú Principal";
            this.b.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel b;
        private System.Windows.Forms.Button btnEmpresas;
        private System.Windows.Forms.Button btnDomiciliarios;
        private System.Windows.Forms.Button btnCamarasDeComercio;
        private System.Windows.Forms.Button btnTodaInfo;
    }
}