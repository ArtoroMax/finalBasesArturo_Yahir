using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.DataAccess.Client;

namespace ProyectoFinan_HG.accesoDatos
{
    class Datos
    {
        /*Paso 0: adicionar en Referencias la dll de oracle  oracle.DataAccess*/
        /*Paso 0.1: incluir las librerías de data y de oracle*/


        /*Paso1: creo la cadena de conexion a la base de datos*/
        string cadenaConexion = "Data Source = localhost; User ID = system; Password = oracle";

        /*Paso 2: creo el metodo que ejecuta yuna consulta DML(insert , update, delete )*/
        public int ejecutarDML(string consulta)
        {
            int filasAfectadas = 0;
            /*Paso 1: creo una conexión*/
            OracleConnection miConexion = new OracleConnection(cadenaConexion);
            /*Paso 2: creo un comando */
            OracleCommand comando = new OracleCommand(consulta, miConexion);
            /*Paso 3: habro la conexión*/
            miConexion.Open();
            /*Paso 4: ejecuto el comando, este devuelve el numero de filas que se afectaron ya sea con un insert, update o delte que llega en la consulta*/
            filasAfectadas = comando.ExecuteNonQuery();
            /*Paso 5: cerrar la conexión"*/
            miConexion.Close();
            return filasAfectadas;
        }

        /*Paso 3: creo el metodo que ejecuta una consulta SELECT*/
        public DataSet ejecutarSELECT(string consulta)
        {
            // Paso 1: Creo un DataSet vacío
            DataSet ds = new DataSet();
            //Paso 2: creo un apadtador
            OracleDataAdapter adaptador = new OracleDataAdapter(consulta, cadenaConexion);
            //Paso 3: lleno el DataSeta través del apadtador
            adaptador.Fill(ds, "ResultadoDatos");
            return ds;
        }
    }
}
