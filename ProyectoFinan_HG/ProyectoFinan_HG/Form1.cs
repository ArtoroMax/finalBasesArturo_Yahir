using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinan_HG.logica;

namespace ProyectoFinan_HG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        EmpresaDomiciliaria empresa = new EmpresaDomiciliaria();

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int nit, ccomnit, resultado;
            string nombre, fecha;
            nit = int.Parse(txtNit.Text);
            ccomnit = int.Parse(txtNitcamara.Text);
                
            nombre = txtNombre.Text;
            fecha = string.Format("yyyy-mm-dd",dtpFecha);

            /*paso 2
            *enviar las variables a la capa de la lógica*/

            resultado = empresa.ingresarEmpresa(nit, nombre, fecha, ccomnit);
            if (resultado > 0)
            {
                MessageBox.Show("Empresa Domiciliaria Registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Empresa Domiciliaria  no Registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
