using Autodesk.AutoCAD.DatabaseServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlocksBases
{
    public partial class Continuous : Form
    {
        public double distance = 0;
        public List<(double, double)> insertedPositions = new List<(double, double)>();
        public Continuous()
        {
            InitializeComponent();
            BothSides.Checked = true;
            Next_Distance.Text = "0";
        }

        private void Main_Block_TextChanged(object sender, EventArgs e)
        {

        }

        private void Browse_Main_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog file = new OpenFileDialog())
            {
                file.Filter = "Drawing Files | *.dwg";
                file.Title = "Select block bases";

                if (file.ShowDialog() == DialogResult.OK)
                {
                    Main_Block.Text = file.FileName;
                }
            }

        }

        private void Open_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Main_Block.Text))
            {
                MessageBox.Show("Main Block base not selected, re-try again with Main block");
                return;

            }

            if (!double.TryParse(Next_Distance.Text, out distance))
            {
                MessageBox.Show("Offset not given, Give an offset to continue");
                return;

            }

            if (BothSides.Checked)
            {
                OneSide.Checked = false;
                Triplet.Checked = false;
            }
            else if (OneSide.Checked)
            {
                BothSides.Checked = false;
                Triplet.Checked = false;
            }
            else if (Triplet.Checked)
            {
                BothSides.Checked = false;
                OneSide.Checked = false;
            }
            double Xmain = 0, YMain = 0;
            if (BothSides.Checked)
            {
                for (int i = 0; i <= 1; i++)
                {
                    Xmain = insertedPositions.Last().Item1;
                    YMain = insertedPositions.Last().Item2;
                    insertedPositions.RemoveAt(insertedPositions.Count - 1);
                    try
                    {
                        InsertBlocks.Placing(Main_Block.Text, Xmain + distance, YMain);
                       
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show($"exception occured {ex}");
                        return;
                    }
                }
                MessageBox.Show("All Bases inserted succesfully");
            }
            else if (Triplet.Checked)
            {
                for (int i = 0; i <= 2; i++)
                {
                    Xmain = insertedPositions.Last().Item1;
                    YMain = insertedPositions.Last().Item2;
                    insertedPositions.RemoveAt(insertedPositions.Count - 1);
                    try
                    {
                        InsertBlocks.Placing(Main_Block.Text, Xmain + distance, YMain);
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show($"exception occured {ex}");
                        return;
                    }
                }
                MessageBox.Show("All Bases inserted succesfully");
            }
            else
            {
                Xmain = insertedPositions.Last().Item1;
                YMain = insertedPositions.Last().Item2;
                //insertedPositions.RemoveAt(insertedPositions.Count - 1);

                try
                {
                    InsertBlocks.Placing(Main_Block.Text, Xmain + distance, YMain);
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show($"exception occured {ex}");
                    return;
                }
                MessageBox.Show("All Bases inserted succesfully");
            }
            Close();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Main_Block.Text))
            {
                MessageBox.Show("Main Block base not selected, re-try again with Main block");
                return;

            }

            if (!double.TryParse(Next_Distance.Text, out distance))
            {
                MessageBox.Show("Offset not given, Give an offset to continue");
                return;
            }
            if (BothSides.Checked)
            {
                OneSide.Checked = false;
                Triplet.Checked = false;
            }
            else if (OneSide.Checked)
            {
                BothSides.Checked = false;
                Triplet.Checked = false;
            }
            else if (Triplet.Checked)
            {
                BothSides.Checked = false;
                OneSide.Checked = false;
            }
            double currentX = 0, currentY = 0, x1 = 0, y1 = 0;
            List<(double, double)> temp = new List<(double, double)>();
            if (BothSides.Checked)
            {
                for (int i = 0; i <= 1; i++)
                {
                    currentX = insertedPositions.Last().Item1;
                    currentY = insertedPositions.Last().Item2;
                    insertedPositions.RemoveAt(insertedPositions.Count - 1);
                    x1 = currentX + distance; y1 = currentY;
                    temp.Add((x1, y1));
                    try
                    {
                        InsertBlocks.Placing(Main_Block.Text, currentX + distance, currentY);

                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show($"exception occured {ex}");
                        return;
                    }
                }
                while (temp.Count != 0)
                {
                    insertedPositions.Add(temp.Last());
                    temp.RemoveAt(temp.Count - 1);
                }
                MessageBox.Show("All Bases inserted succesfully");
            }
            else if (Triplet.Checked)
            {
                for (int i = 0; i <= 2; i++)
                {
                    currentX = insertedPositions.Last().Item1;
                    currentY = insertedPositions.Last().Item2;
                    insertedPositions.RemoveAt(insertedPositions.Count - 1);
                    x1 = currentX + distance; y1 = currentY;
                    temp.Add((x1, y1));
                    try
                    {
                        InsertBlocks.Placing(Main_Block.Text, currentX + distance, currentY);

                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show($"exception occured {ex}");
                        return;
                    }
                }
                while (temp.Count != 0)
                {
                    insertedPositions.Add(temp.Last());
                    temp.RemoveAt(temp.Count - 1);
                }
                MessageBox.Show("All Bases inserted succesfully");
            }
            else
            {
                currentX = insertedPositions.Last().Item1;
                currentY = insertedPositions.Last().Item2;
                x1 = currentX + distance; y1 = currentY;
                insertedPositions.Add((x1, y1));
                try
                {
                    InsertBlocks.Placing(Main_Block.Text, currentX + distance, currentY);
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show($"exception occured {ex}");
                    return;
                }
                MessageBox.Show("All Bases inserted succesfully");
            }
            Next_Distance.Clear(); 
            Next_Distance.Text = "0";
            Main_Block.Clear();
        }


        private void Next_Distance_TextChanged(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OneSide_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BothSides_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void SetInitialPosition(double x, double y)
        {
            insertedPositions.Add((x, y));
        }
    }
}
