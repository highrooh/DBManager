using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Sdk.Sfc;
using Microsoft.SqlServer.Management.Common;
using System.Collections.Specialized;
using System.IO;
using System.Data;
using Microsoft.SqlServer.Management;
using System.Data.SqlClient;
using DBManager.ClassConfig;
using System.Windows;
using System.Reflection;
using System.Windows.Shapes;

namespace DBManager.MSSQLCommands
{
    public class Functions
    {
        const int maxBinaryDisplayString = 8000;

        public static void BackupTables(string TableName)
        {
            var server = new Server(new ServerConnection { ConnectionString = new SqlConnectionStringBuilder { DataSource = @"" + SQLConfig.ServerSQL + "", UserID = "" + SQLConfig.LoginSQL + "", Password = "" + SQLConfig.PassSQL + "", TrustServerCertificate = true }.ToString() });
            server.ConnectionContext.Connect();
            var database = server.Databases["" + SQLConfig.DatabaseSQL + ""];
            var file = new FileInfo(System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)));
            using (FileStream fs = new FileStream(@""+ file +"\\Backups\\"+ TableName +".sql", FileMode.Append, FileAccess.Write))
            using (StreamWriter sw = new StreamWriter(fs))
            {
                foreach(Table table in database.Tables)
                {
                    if (table.Name == ""+ TableName +"")
                    {
                        var scripter = new Scripter(server) { Options = { ScriptData = true } };
                        var script = scripter.EnumScript(new SqlSmoObject[] { table });
                        foreach(string line in script)
                        {

                            sw.WriteLine(line);                        
                        }
                    }
                }
            }

        }


        public static void QueryExec(string Query)
        {
            var db = new MSSQLCommands.Connect();
            var connection = new SqlConnection(db.conexaosql);
            try
            {
                SqlCommand query = new SqlCommand(Query, connection);
                connection.Open();
                query.ExecuteNonQuery();




                MessageBox.Show("Query Exec");
                connection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public static DataTable FixBinaryColumnsForDisplay(DataTable t)
        {
            List<string> binaryColumnNames = t.Columns.Cast<DataColumn>().Where(col => col.DataType.Equals(typeof(byte[]))).Select(col => col.ColumnName).ToList();
            foreach (string binaryColumnName in binaryColumnNames)
            {
                string tempColumnName = "C" + Guid.NewGuid().ToString();
                t.Columns.Add(new DataColumn(tempColumnName, typeof(string)));
                t.Columns[tempColumnName].SetOrdinal(t.Columns[binaryColumnName].Ordinal);

                StringBuilder hexBuilder = new StringBuilder(maxBinaryDisplayString * 2 + 2);
                foreach (DataRow r in t.Rows)
                {
                    r[tempColumnName] = BinaryDataColumnToString(hexBuilder, r[binaryColumnName]);
                }

                t.Columns.Remove(binaryColumnName);
                t.Columns[tempColumnName].ColumnName = binaryColumnName;
            }
            return t;
        }


        private static string BinaryDataColumnToString(StringBuilder hexBuilder, object columnValue)
        {
            const string hexChars = "0123456789ABCDEF";
            if (columnValue == DBNull.Value)
            {
                return "(null)";
            }
            else
            {
                byte[] byteArray = (byte[])columnValue;
                int displayLength = (byteArray.Length > maxBinaryDisplayString) ? maxBinaryDisplayString : byteArray.Length;
                hexBuilder.Length = 0;
                hexBuilder.Append("0x");
                for (int i = 0; i < displayLength; i++)
                {
                    hexBuilder.Append(hexChars[(int)byteArray[i] >> 4]);
                    hexBuilder.Append(hexChars[(int)byteArray[i] % 0x10]);
                }
                return hexBuilder.ToString();
            }
        }



        public static void BackupAllDatabase()
        {
            string query = "";


            var file = new FileInfo(System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)));

            query = @" BACKUP DATABASE " + SQLConfig.DatabaseSQL + "" +
              " TO DISK = '"+ file + "\\Backups\\" + SQLConfig.DatabaseSQL + ".bak'" +
              " WITH FORMAT," +
              " MEDIANAME = 'SQLServerBackups'," +
              " NAME = 'Full Backup of SQLTestDB'; ";

            var db = new MSSQLCommands.Connect();
            var connection = new SqlConnection(db.conexaosql);


            try
            {
                SqlCommand go = new SqlCommand(query, connection);
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(go);
                go.ExecuteNonQuery();

                MessageBox.Show("Backup Database Generated successfully!");
                connection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }



    }
}
