using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using ProyectoFinan_HG.logica;

namespace ProyectoFinan_HG
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        CamaraComercio ccom = new CamaraComercio();
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int nit, resultado;
            string nombre;
            nit = int.Parse(txtNit.Text);

            nombre = txtNombre.Text;
            /*paso 2
            *enviar las variables a la capa de la lógica*/

            resultado = ccom.ingresarCamaraCom(nit, nombre);
            if (resultado > 0)
            {
                MessageBox.Show("Empresa Domiciliaria Registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Empresa Domiciliaria  no Registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultarCamara_Click(object sender, EventArgs e)
        {
            DataSet dsResultado = new DataSet();
            dsResultado = ccom.consultarCamara();
            dgvDatos.DataSource = dsResultado;
            dgvDatos.DataMember = "ResultadoDatos";
        }
    }
}
