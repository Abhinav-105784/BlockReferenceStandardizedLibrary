using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Runtime;
using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeBlockNames_Excel
{
    public class ChangNames
    {
        [CommandMethod("ChangeBlockName")]

        public void ShowForm()
        {
            Select_Blocks_Excel select = new Select_Blocks_Excel();
            select.ShowDialog();
        }

        public static void Change(string excelFile)
        {
            Document document = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument;
            Database database = document.Database;
            Editor editor = document.Editor;

            using (Transaction transaction = database.TransactionManager.StartTransaction())
            {
                using (var stream = File.Open(excelFile, FileMode.Open, FileAccess.Read))
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

                        if (columnHeader1 == "Current Name" && columnHeader2 == "New Name")
                        {
                            document.LockDocument();
                            BlockTable bt = transaction.GetObject(database.BlockTableId, OpenMode.ForRead) as BlockTable;
                            BlockTableRecord btr = transaction.GetObject(database.CurrentSpaceId, OpenMode.ForWrite) as BlockTableRecord;
                            string blockName = "", newName = "";
                            for (int i = 0; i < dataTable.Rows.Count; i++)
                            {
                                blockName = dataTable.Rows[i][0].ToString();
                                newName = dataTable.Rows[i][1].ToString();
                                ;
                                if (bt.Has(blockName))
                                {
                                    foreach (ObjectId id in btr)
                                    {
                                        Entity ent = transaction.GetObject(id, OpenMode.ForWrite) as Entity;
                                        if (ent is BlockReference br)
                                        {
                                            BlockTableRecord btr1 = transaction.GetObject(br.BlockTableRecord, OpenMode.ForWrite) as BlockTableRecord;
                                            if (btr1.Name.Equals(blockName))
                                            {
                                                btr1.Name = newName;
                                            }
                                        }
                                    }
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
            }
        }
    }
}
