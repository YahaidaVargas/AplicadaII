using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;



namespace DAL
{
   public class ConexYaha
    {



        public ConexYaha() {

        }


        #region variables privadas
        private SqlConnection _sncon = new SqlConnection("Data Source=localhost;Initial Catalog=Aplicada2;Integrated Security=True");
        #endregion



        #region METODOS
        
        ///<summary>
        ///Funcion para ejecutar un SQL
        ///</summary>       
        public bool EjecutarDB(string ComandoSql)
        {
            bool Realizado = false;
            SqlCommand Comando = new SqlCommand();

            try
            {
                _sncon.Open(); // abrimos la conexion

                Comando.Connection = _sncon; //asignamos la conexion
                Comando.CommandText = ComandoSql;     //asignamos el comando
                Comando.ExecuteNonQuery(); // ejecutamos el comando

                Realizado = true;
            }
            catch (SqlException ex)
            {
                //Realizado = ex.Message;
                throw new Exception();
            }
            finally
            {
                _sncon.Close(); //cerramos la conexion
            }

            return Realizado;
        }

        /// <summary>
        /// Permite obtener un valor escalar de la base de datos.
        /// </summary>
        /// <param name="ComandoSql">El comando que permite extaer el valor de la base de datos</param>
        /// <returns>Un objeto con el valor encontrado</returns>
        public Object ObtenerValorDb(string ComandoSql)
        {
            SqlCommand Command;
            Object objeto;

            try
            {

                _sncon.Open();
                Command = new SqlCommand(ComandoSql, _sncon);

                objeto = Command.ExecuteScalar();

            }
            catch (Exception e)
            {
               

                throw new Exception();
            }
            finally
            {
                _sncon.Close(); //cerramos la conexion

            }

            return objeto;
        }

        //buscar

        /// <summary>
        /// Ejecutar comandos que retornan algun resultset
        /// </summary>
        /// <param name="ComandoSql"></param>
        /// <returns></returns>
        public DataTable BuscarDb(string ComandoSql)
        {
            SqlDataAdapter Adapter;
            DataTable dt = new DataTable();

            try
            {
                _sncon.Open(); // abrimos la conexion
                Adapter = new SqlDataAdapter(ComandoSql, _sncon);

                Adapter.Fill(dt);
            }
           /* catch (Exception e)
            {

               // Console.WriteLine("######error#######: {0}", e.Message);

                throw;
            }*/
            finally
            {
                _sncon.Close(); //cerramos la conexion

            }
            return dt;
        }


        #endregion



        

    }
}
