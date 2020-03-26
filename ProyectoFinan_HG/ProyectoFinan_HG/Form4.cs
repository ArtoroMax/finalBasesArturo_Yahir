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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        Domiciliario dom = new Domiciliario();
        private void btnActivos_Click(object sender, EventArgs e)
        {
            DataSet dsResultado = new DataSet();
            dsResultado = dom.consultarDomActivos();
            if (dsResultado.Tables[0].Rows.Count > 0)
            {
                txtRes.Text = dsResultado.Tables[0].Rows[0].ToString();
            }
            else
            {
                MessageBox.Show("Ningun domiciliario activo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        Trabaja tra = new Trabaja();
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            DataSet dsResultado = new DataSet();
            dsResultado = tra.consultarTrabaja();
            dgvInformacion.DataSource = dsResultado;
            dgvInformacion.DataMember = "ResultadoDatos";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string cod = dtpFecha.Text;
            DataSet dsResultado = new DataSet();
            dsResultado = tra.consultarPorfecha(cod);
            if (dsResultado.Tables[0].Rows.Count > 0)
            {
                lbResultado.Text = dsResultado.Tables[0].Rows[0]["aniNombre"].ToString();
            }
            else
            {
                MessageBox.Show("Fecha no encontrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtRes_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
