using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.DataAccess.Client;


namespace ProyectoFinan_HG.logica
{
    class EmpresaDomiciliaria
    {
        /*Paso 0: creo un objeto para comunicarme con la capa de accesoDatos y la clase Datos*/
        Datos dt = new Datos();
        public int ingresarEmpresa(int nit, string nombre, string fecha, int nitCcom)
        {
            int result = 0;
            string consulta;
            /* se arma la consulta*/
            consulta = "insert into EmpresaDomiciliaria(edomNit, edomNombre, edomFechaOp, ccomNit) values(" + nit + ",'" + nombre + "','" + fecha + "','" + nitCcom + "')";
            /* se envía la consulta a la capa de accesoDatos PARA SER EJECUTADA*/
            result = dt.ejecutarDML(consulta);
            return result;
        }

        public DataSet consultarEmpresa()
        {
            string consulta;
            DataSet miDS = new DataSet();
            /* se arma la consulta*/
            consulta = "select * from EmpresaDomiciliaria";
            /* se envía la consulta a la capa de accesoDatos PARA SER EJECUTADA*/
            miDS = dt.ejecutarSELECT(consulta);
            return miDS;
        }
    }
}
