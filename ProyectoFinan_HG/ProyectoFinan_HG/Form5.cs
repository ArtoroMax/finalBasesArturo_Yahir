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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        Trabaja tra = new Trabaja();
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int id, nit, resultado;
            string fechain, fechafin;
            nit = int.Parse(txtNit.Text);

            id = int.Parse(txtId.Text);
            nit = int.Parse(txtNit.Text);
            fechain = dtpFechaIn.Text;
            fechafin = dtpFechaFin.Text;

            resultado = tra.ingresarTrabaja(nit, id, fechain, fechafin);
            if (resultado > 0)
            {
                MessageBox.Show("Vinculación de trabajo Registrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cámara de comercio  no Registrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
