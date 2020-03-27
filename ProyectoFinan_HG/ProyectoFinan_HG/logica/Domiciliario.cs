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
    class Domiciliario
    {
        /*Paso 0: creo un objeto para comunicarme con la capa de accesoDatos y la clase Datos*/
        Datos dt = new Datos();
        public int ingresarDomiciliario(int id, string nombre, string apellido, string aniosexp, string estado)
        {
            int result = 0;
            string consulta;
            /* se arma la consulta*/
            consulta = "insert into Domiciliario(domId, domNombre, domApellido, domAniosexp, domEstado) values(" + id + ",'" + nombre + "','" + apellido + "','" + aniosexp + "','" + estado + "')";
            /* se envía la consulta a la capa de accesoDatos PARA SER EJECUTADA*/
            result = dt.ejecutarDML(consulta);
            return result;
        }

        public DataSet consultarDomiciliario()
        {
            string consulta;
            DataSet miDS = new DataSet();
            /* se arma la consulta*/
            consulta = "select * from Domiciliario";
            /* se envía la consulta a la capa de accesoDatos PARA SER EJECUTADA*/
            miDS = dt.ejecutarSELECT(consulta);
            return miDS;
        }

        public DataSet consultarDomActivos()
        {
            string consulta;
            DataSet miDs = new DataSet();
            consulta = "select count(*) from Trabaja natural join Domiciliario where domEstado = 'activo'";
            miDs = dt.ejecutarSELECT(consulta);
            return miDs;
        }

        public int eliminarDomiciliario(string id)
        {
            int result = 0;
            string consulta;
            consulta = "on delete set null from Domiciliario where domId = " + id;
            result = dt.ejecutarDML(consulta);
            return result;
        }

    }
}
