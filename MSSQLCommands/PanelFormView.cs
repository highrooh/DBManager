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

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return value;
        }





    }
}
