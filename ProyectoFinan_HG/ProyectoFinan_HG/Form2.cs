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


            resultado = domi.ingresarDomiciliario(id, nombre, apellido, anios, estado);
            if (resultado > 0)
            {
                MessageBox.Show("Domiciliario Registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Domiciliario  no Registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string cod = txtIdEliminar.Text;
            int resultado;
            resultado = domi.eliminarDomiciliario(cod);
            if (resultado > 0)
            {
                MessageBox.Show("Domiciliario eliminado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Id no encontrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal form4 = new Principal();
            form4.ShowDialog();
        }
    }
}
