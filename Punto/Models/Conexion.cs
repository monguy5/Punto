using System;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace Punto { 
public class Conexion
{
        MySqlConnectionStringBuilder builder;

        MySqlConnection conn ;
        MySqlCommand cmd;
        MySqlDataAdapter da;
        List<DataRow> list;
        DataTable dt;
        string mensaje;
	public Conexion()
	{
	}
        public MySqlConnection conectar()
        {
            builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "refa";
            builder.Password = "refa";
            builder.Database = "punto";
           
            conn = new MySqlConnection(builder.ToString());
            return conn;
           

        }
        public string crud(string query)
        {
            try {
                conectar();
                cmd = conn.CreateCommand();
                cmd.CommandText = query;
                conn.Open();
                cmd.ExecuteNonQuery();
                mensaje = "Agregado Satisfactoriamente";
            } catch(MySqlException me) {
                mensaje = "Fallo: " + me.Message;

            } finally { conn.Close(); }
            return mensaje;
          

        }
        public void insertarventa()
        {
            try {

               

            }
            catch(MySqlException me)
            {

            }
            finally
            {
                conn.Close();
            }

        }
        public DataTable tablas(string query)
        {
            try
            {
                conectar();
                cmd = conn.CreateCommand();
                cmd.CommandText = query;
                //conn.Open();
               // cmd.ExecuteNonQuery();
               da = new MySqlDataAdapter(query, conectar());
                dt = new DataTable();

                da.Fill(dt);
                mensaje = "Agregado Satisfactoriamente";
               list = dt.AsEnumerable().ToList();

            }
            catch (MySqlException me)
            {
                mensaje = "Fallo: " + me.Message;

            }
            finally { conn.Close(); }
            return dt;


        }
    }
}
