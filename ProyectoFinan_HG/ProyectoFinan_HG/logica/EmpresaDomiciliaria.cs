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
    class EmpresaDomiciliaria
    {
        Datos dt = new Datos();
        public int ingresarEmpresa(int nit, string nombre, string fecha, int nitCcom)
        {
            int result = 0;
            string consulta;
            consulta = "insert into EmpresaDomiciliaria(edomNit, edomNombre, edomFechaOp, ccomNit) values(" + nit + ",'" + nombre + "','" + fecha + "','" + nitCcom + "')";
            result = dt.ejecutarDML(consulta);
            return result;
        }

        public DataSet consultarEmpresa()
        {
            string consulta;
            DataSet miDS = new DataSet();
            consulta = "select * from EmpresaDomiciliaria";
            miDS = dt.ejecutarSELECT(consulta);
            return miDS;
        }

        public int eliminarEmpresa(string nit)
        {
            int result = 0;
            string consulta;
            consulta = "delete set null from EmpresaDomiciliaria where empNit = " + nit;
            result = dt.ejecutarDML(consulta);
            return result;
        }
    }
}
