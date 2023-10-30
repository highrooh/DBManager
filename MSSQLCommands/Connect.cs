using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using DBManager.ClassConfig;

namespace DBManager.MSSQLCommands
{
    public class Connect
    {

        public SqlConnection connection = new SqlConnection("Database=" + SQLConfig.DatabaseSQL + ";Server=" + SQLConfig.ServerSQL + ";user=" + SQLConfig.LoginSQL + ";password=" + SQLConfig.PassSQL + "");




        public bool TestConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
                return true;
            }
            else
            {
                return false;
            }
        }


        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
                System.Windows.Forms.MessageBox.Show("Connection made successfully!!");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Connection was not established!!");
            }
        }

        // create a function to close the connection
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
            else
            {
                //     System.Windows.Forms.MessageBox.Show("Conexão não foi estabelecida!!");
            }
        }

        // create a function to return the connection
        public SqlConnection GetConnection()
        {
            return connection;
        }
    }
}
