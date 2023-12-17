using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using MySql.Data.MySqlClient;
using System.Windows;
using Google.Protobuf.WellKnownTypes;

namespace DBManager.MSSQLCommands
{
    public class PanelFormView
    {

        public static int CountTables()
        {
            var db = new MSSQLCommands.Connect();
            var connection = new SqlConnection(db.conexaosql);
            int value = 0;


            try
            {
                SqlCommand query = new SqlCommand("Select COUNT(*) AS CountTables FROM sys.Tables", connection);
                connection.Open();
                DataTable dataTable = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(query);
                da.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    foreach (DataRow list in dataTable.Rows)
                    {
                        for (int i = 0; i < list.ItemArray.Length; i++)
                        {
                            value = int.Parse(list[i].ToString());
                        }
                    }
                }
                connection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return value;
        }







        public static double MemorySqlServerUse()
        {
            var db = new MSSQLCommands.Connect();
            var connection = new SqlConnection(db.conexaosql);
            double value = 0.0f;


            try
            {
                SqlCommand query = new SqlCommand("SELECT\r\nsqlserver_start_time,\r\n(committed_kb/1024) AS Total_Server_Memory_MB,\r\n(committed_target_kb/1024)  AS Target_Server_Memory_MB\r\nFROM sys.dm_os_sys_info;", connection);
                connection.Open();
                DataTable dataTable = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(query);
                da.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    foreach (DataRow list in dataTable.Rows)
                    {

                        string valuex = list[1].ToString().Replace("MB", "");
                        value = double.Parse(valuex, System.Globalization.CultureInfo.InvariantCulture);
                    }
                }
                connection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return value;
        }





        public static double DiskUsage()
        {
            var db = new MSSQLCommands.Connect();
            var connection = new SqlConnection(db.conexaosql);
            double value = 0.0f;


            try
            {
                SqlCommand query = new SqlCommand("Exec SP_SpaceUsed", connection);
                connection.Open();
                DataTable dataTable = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(query);
                da.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    foreach (DataRow list in dataTable.Rows)
                    {

                        string valuex = list[1].ToString().Replace("MB","");
                        value = double.Parse(valuex, System.Globalization.CultureInfo.InvariantCulture);
                    }
                }
                connection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return value;
        }





    }
}
