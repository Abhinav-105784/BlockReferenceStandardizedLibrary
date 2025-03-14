using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Runtime;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
[assembly: CommandClass(typeof(BlocksBases.InsertBlocks))]
namespace BlocksBases
{
    public class InsertBlocks
    {
        [CommandMethod("AssembleBases")]

        public void LoadForm()
        {
            Select_Blocks form1 = new Select_Blocks();
            form1.ShowDialog();
        }

        public static void Placing(string file, double xMain, double yMain)
        {
            Document document = Autodesk.AutoCAD.ApplicationServices.Core.Application.DocumentManager.MdiActiveDocument;
            Database database = document.Database;
            Editor editor = document.Editor;
            using (Transaction transaction = database.TransactionManager.StartTransaction())
            {


                try
                {
                    Database dbMain = new Database(false, true);
                    dbMain.ReadDwgFile(file, FileOpenMode.OpenForReadAndAllShare, false, null);
                    ObjectId blockId = ObjectId.Null;

                    using (Transaction dbtransaction = dbMain.TransactionManager.StartTransaction())
                    {
                        BlockTable btMain = dbtransaction.GetObject(dbMain.BlockTableId, OpenMode.ForRead) as BlockTable;
                        blockId = database.Insert(System.IO.Path.GetFileNameWithoutExtension(file), dbMain.Wblock(btMain[System.IO.Path.GetFileNameWithoutExtension(file)]), true);
                        dbtransaction.Commit();
                    }

                    BlockTableRecord currentSpace = transaction.GetObject(database.CurrentSpaceId, OpenMode.ForWrite) as BlockTableRecord;

                    BlockReference mainBr = new BlockReference(new Autodesk.AutoCAD.Geometry.Point3d(xMain, yMain, 0), blockId)
                    {
                        ScaleFactors = new Autodesk.AutoCAD.Geometry.Scale3d(1, 1, 1)
                    };

                    currentSpace.AppendEntity(mainBr);
                    transaction.AddNewlyCreatedDBObject(mainBr, true);
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show($"Error occured : {ex}");
                    return;
                }
                transaction.Commit();
            }

        }
    }
}