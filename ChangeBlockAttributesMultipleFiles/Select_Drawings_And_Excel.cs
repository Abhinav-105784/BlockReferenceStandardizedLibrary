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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ChangeBlocksAttributes_MultipleDrawings
{
    public partial class Select_Drawings_And_Excel : Form
    {
        public Select_Drawings_And_Excel()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Data.DataTable dt = dataTable[comboBox2.SelectedItem.ToString()];
            dataGridView1.DataSource = dt;
        }
        DataTableCollection dataTable;
        private void browse_Excel_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog opd = new OpenFileDialog())
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

        private void Browse_Drawings_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog opd = new OpenFileDialog())
            {
                opd.Filter = "Drawing Files |*.dwg";
                opd.Title = "Select the drawing files";
                opd.Multiselect = true;

                if (opd.ShowDialog() == DialogResult.OK)
                {
                    foreach(var file in opd.FileNames)
                    {
                        Drawing_List.Items.Add(file);
                    }
                }
            }
        }

        private void Drawing_List_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Open_Click(object sender, EventArgs e)
        {
            string excelFile = textBox2.Text;

            if(!string.IsNullOrEmpty(excelFile) && Drawing_List.Items.Count > 0)
            {
                HashSet<string> drawingFiles = new HashSet<string>(Drawing_List.Items.Cast<string>());
                ChangeMultiple.ChangeAttributes(excelFile, drawingFiles);
                MessageBox.Show("Attributes updated in all Drawings successfully");
            }
            else
            {
                MessageBox.Show("Select atleast 1 drawing file and/or a excel in proper format");
                return;
            }
            Close();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
