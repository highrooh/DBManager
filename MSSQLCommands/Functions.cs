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
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }



    }
}
