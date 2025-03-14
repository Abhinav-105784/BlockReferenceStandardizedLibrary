using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;
using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
[assembly:CommandClass(typeof(ChangeBlockNames_Multiple.ChangeNames))]
namespace ChangeBlockNames_Multiple
{
    public class ChangeNames
    {
        [CommandMethod("ChangeMultipleBlockNames")]

        public void LoadForm()
        {
            Select_Excel_And_Drawings form = new Select_Excel_And_Drawings();
            form.ShowDialog();
        }

        public static void Change(string excelFiles, HashSet<string> drawingFiles)
        {
            foreach(string dwgFile in drawingFiles)
            {
                try
                {
                    using (Database database = new Database(false, true))
                    {
                        database.ReadDwgFile(dwgFile, FileOpenMode.OpenForReadAndAllShare, true, null);
                        using (Transaction transaction = database.TransactionManager.StartTransaction())
                        {
                            using (var stream = System.IO.File.Open(excelFiles, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                            {
                                using (var reader = ExcelReaderFactory.CreateReader(stream))
                                {
                                    DataSet dataSet = reader.AsDataSet(new ExcelDataSetConfiguration()
                                    {
                                        ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                                    });

                                    var dataTable = dataSet.Tables[0];
                                    string columnHeader1 = dataTable.Columns[0].ColumnName;
                                    string columnHeader2 = dataTable.Columns[1].ColumnName;

                                    if (columnHeader1 == "Block Name" && columnHeader2 == "New Name")
                                    {
                                        BlockTable bt = transaction.GetObject(database.BlockTableId, OpenMode.ForRead) as BlockTable;
                                        BlockTableRecord btr = transaction.GetObject(bt[BlockTableRecord.ModelSpace], OpenMode.ForWrite) as BlockTableRecord;
                                        string blockname = "", newName = "";
                                        for (int i = 0; i < dataTable.Rows.Count; i++)
                                        {
                                            blockname = dataTable.Rows[i][0].ToString();
                                            newName = dataTable.Rows[i][1].ToString();

                                            if (bt.Has(blockname))
                                            {
                                                foreach (ObjectId id in btr)
                                                {
                                                    Entity ent = transaction.GetObject(id, OpenMode.ForWrite) as Entity;
                                                    if (ent is BlockReference br)
                                                    {
                                                        BlockTableRecord btr1 = transaction.GetObject(br.BlockTableRecord, OpenMode.ForWrite) as BlockTableRecord;
                                                        if (btr1.Name.Equals(blockname))
                                                        {
                                                            btr1.Name = newName;
                                                        }
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show($"Block '{blockname}' not found in drawing '{dwgFile}'.");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show($"Give proper Format Excel: current 1st Header is {columnHeader1} and required is Block Name \n currrent 2nd Header is {columnHeader2} and required is Block Tag \n");
                                        return;
                                    }
                                }
                            }
                            transaction.Commit();
                            database.SaveAs(dwgFile, DwgVersion.Current);
                            Document document = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.Open(dwgFile);
                        }
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show($"Error Occured {ex}");
                    return;
                }
            }

        }
    }
}
