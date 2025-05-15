using Autodesk.AutoCAD.DatabaseServices;
using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeAttributeValue
{
    public partial class SelectExcel : Form
    {
        public SelectExcel()
        {
            InitializeComponent();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            string fileName = textBox2.Text;

            if (!string.IsNullOrEmpty(fileName))
            {
                ChangeAttribute.Change(fileName);
                MessageBox.Show("Attributes Changed successfully");
            }
            else
            {
                MessageBox.Show("Please select the excel file");
                return;
            }
            Close();

        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        DataTableCollection dataTable;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Data.DataTable dt = dataTable[comboBox2.SelectedItem.ToString()];
            dataGridView1.DataSource = dt;
        }

        private void browse_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog opd = new OpenFileDialog())
            {
                opd.Filter = "Excel Files |*.xls;*.xlsm;*.xlsx";
                opd.Title = "Select the excel file";

                if (opd.ShowDialog() == DialogResult.OK)
                {
                    textBox2.Text = opd.FileName;
                    using (var stream = System.IO.File.Open(opd.FileName, System.IO.FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }

                            });

                            dataTable = result.Tables;
                            comboBox2.Items.Clear();
                            foreach (System.Data.DataTable table in dataTable)
                            {
                                comboBox2.Items.Add(table.TableName);
                            }

                        }

                    }
                }
            }
        }

        private void Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
