using MySqlX.XDevAPI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace DBManager.PanelForm.MSSQLForm.ViewTables
{
    public partial class ViewTables : Form
    {
        string query = "";
        DataSet ds = new DataSet();
        public ViewTables()
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

      

        public  void ViewItemTable(string Query)
        {
            var db = new MSSQLCommands.Connect();
            var connection = new SqlConnection(db.conexaosql);
            try
            {
                connection.Open();
                
                SqlCommand query = new SqlCommand(Query, connection);
                SqlDataAdapter da = new SqlDataAdapter(query);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ds.Tables.Add(dt);
                dataGridView1.DataSource = dt;
                MSSQLCommands.Functions.FixBinaryColumnsForDisplay(dt);
                connection.Close();
                
             
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void vTables_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= cbTables.Items.Count; i++)

            {
                if (cbTables.Items.Count != i)
                {
                    if (cbTables.Items[i].Checked)
                    {
                        string nametable = cbTables.Items[i].Text;
                        query = @"SELECT * FROM "+ nametable +"";
                        ViewItemTable(query);
                    }
                }
            }
        }

        private void ViewTables_Load(object sender, EventArgs e)
        {
            CompleteTable();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {

                    String header = dataGridView1.Columns[i].HeaderText;
                    String cellText = row.Cells[i].Value.ToString();
                    var dadosfiltrados = cellText.Contains(materialTextBox1.Text);
                    if (dadosfiltrados)
                    {

                        DataView dv = ds.Tables[0].DefaultView;
                        dv.RowFilter = string.Format(" "+ header+" LIKE '%{0}%'", materialTextBox1.Text);
                        dataGridView1.DataSource = dv;
                        return;
                    }

                }
            }
        }
    }
}
