using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DBManager.PanelForm.MSSQLForm.TruncateTable
{
    public partial class TruncateTable : Form
    {
        string query = "";
        public TruncateTable()
        {
            InitializeComponent();
        }

        public void CompleteTable()
        {
            var db = new MSSQLCommands.Connect();
            var connection = new SqlConnection(db.conexaosql);
            try
            {
                SqlCommand query = new SqlCommand("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' ORDER     BY TABLE_TYPE", connection);
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
                            cbTables.Items.Add(list[i].ToString());
                        }
                    }
                }
                connection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void TruncateTable_Load(object sender, EventArgs e)
        {
            CompleteTable();
        }

        private void bTruncateOneTable_Click(object sender, EventArgs e)
        {

            for (int i = 0; i <= cbTables.Items.Count; i++)

            {
                if (cbTables.Items.Count != i)
                {
                    if (cbTables.Items[i].Checked)
                    {
                        string nametable = cbTables.Items[i].Text;
                        query = @" USE "+ ClassConfig.SQLConfig.DatabaseSQL +""+
                            "\n\r"+
                            " EXEC sp_MSforeachtable 'TRUNCATE TABLE "+ nametable +"'";

                        MSSQLCommands.Functions.QueryExec(query);
                    }
                }
            }
            
        }

        private void bTruncateAll_Click(object sender, EventArgs e)
        {
            query = @" USE " + ClassConfig.SQLConfig.DatabaseSQL + "" +
                     "\n\r" +
                   " EXEC sp_MSforeachtable 'TRUNCATE TABLE ?'";

            MSSQLCommands.Functions.QueryExec(query);

        }
    }
}
