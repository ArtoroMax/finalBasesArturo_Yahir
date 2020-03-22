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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Domiciliario domi = new Domiciliario();
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int id, resultado;
            string nombre, apellido, anios, estado="";
            id = int.Parse(txtId.Text);
            nombre = txtNombre.Text;
            apellido = txtApellido.Text;

            if (rbActivo.Checked)
            {
                estado = "activo";
            }
            else if (rbInactivo.Checked)
            {
                estado = "inactivo";
            }
            anios = cbxAnios.SelectedItem.ToString();


            /*paso 2
            *enviar las variables a la capa de la lógica*/

            resultado = domi.ingresarDomiciliario(id, nombre, apellido, anios, estado);
            if (resultado > 0)
            {
                MessageBox.Show("Empresa Domiciliaria Registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Empresa Domiciliaria  no Registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbMensaje_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultarDomiciliarios_Click(object sender, EventArgs e)
        {
            DataSet dsResultado = new DataSet();
            dsResultado = domi.consultarDomiciliario();
            dgvDatos.DataSource = dsResultado;
            dgvDatos.DataMember = "ResultadoDatos";
            //g
        }
    }
}
