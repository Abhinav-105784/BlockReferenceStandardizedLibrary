using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeBlockNames_Multiple
{
    public partial class Select_Excel_And_Drawings : Form
    {
        public Select_Excel_And_Drawings()
        {
            InitializeComponent();
        }

        private void Select_Excel_And_Drawings_Load(object sender, EventArgs e)
        {

        }

        private void Open_Click(object sender, EventArgs e)
        {
            string excelFile = textBox2.Text;

            if(!string.IsNullOrEmpty(excelFile) && Drawing_List.Items.Count > 0)
            {
                HashSet<string> drawingFiles = new HashSet<string>(Drawing_List.Items.Cast<string>());
                ChangeNames.Change(excelFile, drawingFiles);
                MessageBox.Show("All BlockNames updated in each Drawing successfully");
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

        private void Drawing_List_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Browse_Drawings_Click(object sender, EventArgs e)
        {
            using( OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Drawing files | *.dwg";
                ofd.Title = "Select the drawing files";
                ofd.Multiselect = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    foreach(var file in ofd.FileNames)
                    {
                        Drawing_List.Items.Add(file);
                    }
                }
            }
        }
        DataTableCollection dataSet;
        private void browse_Excel_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog excelFile = new OpenFileDialog())
            {
                excelFile.Filter = "Excel Files | *.xls, *.xlsx, *.xlsm";
                excelFile.Title = "Select the excel File";

                if (excelFile.ShowDialog() == DialogResult.OK)
                {
                    textBox2.Text = excelFile.FileName;
                    using(var stream = System.IO.File.Open(excelFile.FileName,System.IO.FileMode.Open,System.IO.FileAccess.Read))
                    {
                        using(IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true}
                            });

                            dataSet = result.Tables;
                            comboBox2.Items.Clear();
                            foreach(System.Data.DataTable table in dataSet)
                            {
                                comboBox2.Items.Add(table.TableName);
                            }
                        }
                    }
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = dataSet[comboBox2.SelectedItem.ToString()];
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
