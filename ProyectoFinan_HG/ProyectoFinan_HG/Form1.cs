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

        private void btnConsultarEmpresas_Click(object sender, EventArgs e)
        {
            DataSet dsResultado = new DataSet();
            dsResultado = empresa.consultarEmpresa();
            dgvDatos.DataSource = dsResultado;
            dgvDatos.DataMember = "ResultadoDatos";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string cod = txtEliminar.Text;
            DataSet dsResultado = new DataSet();
            dsResultado = empresa.eliminarEmpresa(cod);
            if (dsResultado.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("Empresa eliminada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Nit no encontrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
