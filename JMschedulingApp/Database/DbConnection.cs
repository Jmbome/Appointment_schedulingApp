using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JMschedulingApp.Database
{
    public class DbConnection
    {
        public static MySqlConnection conn { get; set; }

        //Start connection method
        public static void startConnection()
        {
            try
            {
                //get coonection string
                string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;

                conn = new MySqlConnection(constr);

                //open connection
                conn.Open();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //Close connection method
        public static void closeConnection()
        {
            try
            {//close connection
                if (conn != null)
                {
                    conn.Close();
                }
                conn = null;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Login validation statement lambda
      public static Func <string, string, bool> CheckLogin = ( UserName, UserPass) =>
        {
          
                string selectString =
               "SELECT username, password " +
               "FROM user " +
               "WHERE username = '" + UserName + "' AND password = '" + UserPass + "'";
                string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
                conn = new MySqlConnection(constr);
                MySqlCommand mySqlCommand = new MySqlCommand(selectString, conn);
                conn.Open();
                string strResult = (String)mySqlCommand.ExecuteScalar();
                conn.Close();

                if (string.IsNullOrEmpty(strResult))
                {
                    return false;

                }
                else
                {
                    return true;
                }
            
           
        };


       //Load grid table
        public static void LoadGridTable(string selectString, DataGridView DataGridTable)
        {
            try
            {
                string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
                conn = new MySqlConnection(constr);
                var dataAdapter = new MySqlDataAdapter(selectString, conn);
                var commandBuilder = new MySqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                DataGridTable.ReadOnly = true;
                DataGridTable.DataSource = ds.Tables[0]; //POPULATE DATA TABLE

                

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
