using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Tarea3_Hotel
{
    class SQLquery
    {
        public static string connectionString = @"data source=(LocalDB)\MSSQLLocalDB;attachdbfilename=|DataDirectory|\Hotel.mdf;integrated security=True;connect timeout=30;MultipleActiveResultSets=True;";



        public static DataTable getTable(string Sql)
        {
            SqlConnection conexionSQL = new SqlConnection(connectionString);
            SqlCommand sqlCommand = null;
            SqlDataReader sqlDataReader = null;
            try
            {
                conexionSQL.Open();
                sqlCommand = new SqlCommand(Sql, conexionSQL);
                sqlDataReader = sqlCommand.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sqlDataReader);
                return dt;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                if (sqlDataReader != null)
                    sqlDataReader.Close();
                if (conexionSQL.State == ConnectionState.Open)
                    conexionSQL.Close();
            }
            return null;
        }

        public static int execute(string Sql)
        {
            SqlConnection conexionSQL = new SqlConnection(connectionString);
            SqlCommand sqlCommand = null;
            try
            {
                conexionSQL.Open();
                sqlCommand = new SqlCommand(Sql, conexionSQL);
                return sqlCommand.ExecuteNonQuery(); 
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                if (conexionSQL.State == ConnectionState.Open)
                    conexionSQL.Close();
            }
            return 0; 
        }

    }
}
