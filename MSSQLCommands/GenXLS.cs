using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;
using System.Windows;
using System.IO;
using System.Reflection;

namespace DBManager.MSSQLCommands
{
	public class GenXLS
	{
		public static void GetXLS(string TableName)
		{
			DataTable dataTable = new DataTable();
			var db = new MSSQLCommands.Connect();
			using (SqlConnection connection = new SqlConnection(db.conexaosql))
			{
				connection.Open();

				SqlCommand command = new SqlCommand("select * from "+ TableName +"", connection);

				SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

				dataAdapter.Fill(dataTable);

                MSSQLCommands.Functions.FixBinaryColumnsForDisplay(dataTable);

                var excelApplication = new Excel.Application();

				var excelWorkBook = excelApplication.Application.Workbooks.Add(Type.Missing);

				DataColumnCollection dataColumnCollection = dataTable.Columns;

				for (int i = 1; i <= dataTable.Rows.Count + 1; i++)
				{
					for (int j = 1; j <= dataTable.Columns.Count; j++)
					{
						if (i == 1)
							excelApplication.Cells[i, j] = dataColumnCollection[j - 1].ToString();
						else
							excelApplication.Cells[i, j] = dataTable.Rows[i - 2][j - 1].ToString();
					}
				}


				var file = new FileInfo(System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)));

				
				excelApplication.ActiveWorkbook.SaveCopyAs(@""+ file + "\\XLSX\\" + TableName +".xlsx");

				excelApplication.ActiveWorkbook.Saved = true;

			
				excelApplication.Quit();

				connection.Close();

		
				releaseObject(excelWorkBook);
				releaseObject(excelApplication);

			}
		}




		private static void releaseObject(object obj)
		{
			try
			{
				System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
				obj = null;
			}
			catch (Exception ex)
			{
				obj = null;
				MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
			}
			finally
			{
				GC.Collect();
			}
		}
	}
}