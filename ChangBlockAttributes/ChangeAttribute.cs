using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Runtime;
using ExcelDataReader;
using ExcelDataReader.Exceptions;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeAttributeValue
{
    public class ChangeAttribute
    {
        [CommandMethod("ChangeBlockAttributes")]
        public void ShowForm()
        {
            SelectExcel select = new SelectExcel();
            select.ShowDialog();
        }

        public static void Change(string excelFile)
        {
            Document document = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument;
            Database database = document.Database;
            Editor editor = document.Editor;

            using(Transaction transaction = database.TransactionManager.StartTransaction())
            {
                using(var stream = File.Open(excelFile, FileMode.Open, FileAccess.Read))
                {
                    using(var reader = ExcelReaderFactory.CreateReader(stream))
                    {
                        DataSet dataSet = reader.AsDataSet(new ExcelDataSetConfiguration()
                        {
                               ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true}
                        });

                        var dataTable = dataSet.Tables[0];
                        string columnHeader1 = dataTable.Columns[0].ColumnName;
                        string columnHeader2 = dataTable.Columns[1].ColumnName;
                        string columnHeader3 = dataTable.Columns[2].ColumnName;
                        
                        if (columnHeader1 == "Block Name" && columnHeader2 == "Block Tag" && columnHeader3 == "Value")
                        {
                            document.LockDocument();
                            BlockTable bt = transaction.GetObject(database.BlockTableId, OpenMode.ForRead) as BlockTable;
                            BlockTableRecord btr = transaction.GetObject(database.CurrentSpaceId, OpenMode.ForWrite) as BlockTableRecord;
                            string blockName = "", blockTag = "", newVal = "";
                            for (int i = 0; i < dataTable.Rows.Count; i++)
                            {
                                blockName = dataTable.Rows[i][0].ToString();
                                blockTag = dataTable.Rows[i][1].ToString();
                                newVal = dataTable.Rows[i][2].ToString();

                                if (bt.Has(blockName))
                                {
                                    foreach (ObjectId id in btr)
                                    {
                                        BlockReference br = transaction.GetObject(id, OpenMode.ForWrite) as BlockReference;
                                        if (br != null && br.Name == blockName)
                                        {
                                            foreach(ObjectId ob in br.AttributeCollection)
                                            {
                                                AttributeReference attRef = (AttributeReference)transaction.GetObject(ob, OpenMode.ForWrite);
                                                if (attRef.Tag == blockTag)
                                                {
                                                    attRef.TextString = newVal;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Give proper Format Excel: current 1st Header is {columnHeader1} and required is Block Name \n currrent 2nd Header is {columnHeader2} and required is Block Tag \n current 3rd Header is {columnHeader3} and required is Value");
                            return;
                        }
                    }
                }
                transaction.Commit();
            }
        }
    }
}
