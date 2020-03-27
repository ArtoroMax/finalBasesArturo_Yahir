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
    class Trabaja
    {
        /*Paso 0: creo un objeto para comunicarme con la capa de accesoDatos y la clase Datos*/
        Datos dt = new Datos();
        public int ingresarTrabaja(int edomNit, int domId, string fechain, string fechafin)
        {
            int result = 0;
            string consulta;
            /* se arma la consulta*/
            consulta = "insert into Trabaja(edomNit, domId, traFechaInicio, traFechaFin) values(" + edomNit + ",'" + domId + "','" + fechain + "','" + fechafin + "')";
            /* se envía la consulta a la capa de accesoDatos PARA SER EJECUTADA*/
            result = dt.ejecutarDML(consulta);
            return result;
        }

        public DataSet consultarTrabaja()
        {
            string consulta;
            DataSet miDS = new DataSet();
            consulta = "select * from EmpresaDomiciliaria natural join Domiciliario inner join Trabaja on Domiciliario.domId = Trabaja.domId";
            miDS = dt.ejecutarSELECT(consulta);
            return miDS;
        }

        public DataSet consultarPorfecha(string fecha)
        {
            string consulta;
            DataSet miDS = new DataSet();
            consulta = "select ccomNombre, e.edomNit, edomNombre, d.domId, domNombre, domApellido " +
                "from Trabaja t inner join Domiciliario d  on t.domId = d.domId " +
                "inner join EmpresaDomiciliaria e on t.edomNit = e.edomNit " +
                "inner join CamaraComercio c on c.ccomNit = e.ccomNit ";
            miDS = dt.ejecutarSELECT(consulta);
            return miDS;
        }
    }
}
