using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProyectoFinan_HG.accesoDatos;
using Oracle.DataAccess.Client;

namespace ProyectoFinan_HG.logica
{
    class CamaraComercio
    {
        /*Paso 0: creo un objeto para comunicarme con la capa de accesoDatos y la clase Datos*/
        Datos dt = new Datos();
        public int ingresarCamaraCom(int nit, string nombre)
        {
            int result = 0;
            string consulta;
            /* se arma la consulta*/
            consulta = "insert into CamaraComercio(ccomNit, ccomNombre) values(" + nit + ",'" + nombre +"')";
            /* se envía la consulta a la capa de accesoDatos PARA SER EJECUTADA*/
            result = dt.ejecutarDML(consulta);
            return result;
        }

        public DataSet consultarCamara()
        {
            string consulta;
            DataSet miDS = new DataSet();
            /* se arma la consulta*/
            consulta = "select * from CamaraComercio";
            /* se envía la consulta a la capa de accesoDatos PARA SER EJECUTADA*/
            miDS = dt.ejecutarSELECT(consulta);
            return miDS;
        }
    }
}
