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
    public partial class Select_Blocks : Form
    {
        public Select_Blocks()
        {
            InitializeComponent();
            X.Text = "0";
            Y.Text = "0";
            Offset.Text = "0";
            BothSides.Checked = true;
        }

        private void MainBlock_TextChanged(object sender, EventArgs e)
        {

        }

        private void Browse_Main_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog file = new OpenFileDialog())
            {
                file.Filter = "Drawing Files | *.dwg";
                file.Title = "Select block bases";

                if (file.ShowDialog() == DialogResult.OK)
                {
                    MainBlock.Text = file.FileName;
                }
            }
        }

        private void X_TextChanged(object sender, EventArgs e)
        {

        }

        private void Y_TextChanged(object sender, EventArgs e)
        {

        }

        private void Offset_TextChanged(object sender, EventArgs e)
        {

        }

        private void Run_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MainBlock.Text))
            {
                MessageBox.Show("Main Block base not selected, re-try again with Main block");
               
            }

            if(!double.TryParse(Offset.Text, out double offset))
            {
                MessageBox.Show("Offset not given, Give an offset to continue");
                
            }

            if(!double.TryParse(X.Text,out double Xmain))
            {
                MessageBox.Show("Centerline X not given, Give an Centerline X");
            }

            if(!double.TryParse(Y.Text,out double YMain))
            {
                MessageBox.Show("Centerline Y not given, Give an Centerline Y");
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
                OneSide.Checked = false;
                BothSides.Checked = false;
            }

            try
            {
                if (Triplet.Checked)
                {
                    InsertBlocks.Placing(MainBlock.Text, Xmain, YMain);
                    InsertBlocks.Placing(MainBlock.Text, Xmain, YMain - offset);
                    InsertBlocks.Placing(MainBlock.Text, Xmain, YMain + offset);    
                }
                else if (BothSides.Checked)
                {
                    InsertBlocks.Placing(MainBlock.Text, Xmain, YMain - offset);
                    InsertBlocks.Placing(MainBlock.Text, Xmain, YMain + offset);
                }
                else
                {
                    InsertBlocks.Placing(MainBlock.Text, Xmain, YMain - offset);
                }
                MessageBox.Show("All Bases inserted succesfully");
            }
            catch(System.Exception ex)
            {
                MessageBox.Show($"exception occured {ex}");
                return;
            }

            Close();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MainBlock.Text))
            {
                MessageBox.Show("Main Block base not selected, re-try again with Main block");
                return;
            }

            if (!double.TryParse(Offset.Text, out double offset))
            {
                MessageBox.Show("Offset not given, Give an offset to continue");
                return;
            }

            if (!double.TryParse(X.Text, out double Xmain))
            {
                MessageBox.Show("Centerline X not given, Give an Centerline X");
                return;
            }

            if (!double.TryParse(Y.Text, out double YMain))
            {
                MessageBox.Show("Centerline Y not given, Give an Centerline Y");
                return;
            }
            double yPosition1 = YMain - offset;
            double yPosition2 = YMain + offset;
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
                OneSide.Checked = false;
                BothSides.Checked = false;
            }
            try
            {
                if (BothSides.Checked)
                {
                    InsertBlocks.Placing(MainBlock.Text, Xmain, YMain - offset);
                    InsertBlocks.Placing(MainBlock.Text, Xmain, YMain + offset);
                }
                else if (Triplet.Checked)
                {
                    InsertBlocks.Placing(MainBlock.Text, Xmain, YMain);
                    InsertBlocks.Placing(MainBlock.Text, Xmain, YMain - offset);
                    InsertBlocks.Placing(MainBlock.Text, Xmain, YMain + offset);
                }
                else
                {
                    InsertBlocks.Placing(MainBlock.Text, Xmain, YMain - offset);
                }
                    MessageBox.Show("All Bases inserted succesfully");
                
            }
            catch (System.Exception ex)
            {
                MessageBox.Show($"exception occured {ex}");
                return;
            }

            Hide();
            Close();

            Continuous nextform = new Continuous();
            if (BothSides.Checked)
            {
                nextform.SetInitialPosition(Xmain, yPosition1);
                nextform.SetInitialPosition(Xmain, yPosition2);
            }
            else if (Triplet.Checked)
            {
                nextform.SetInitialPosition(Xmain, YMain);
                nextform.SetInitialPosition(Xmain, yPosition1);
                nextform.SetInitialPosition(Xmain, yPosition2);
            }
            else
            {
                nextform.SetInitialPosition(Xmain, yPosition1);
            }
            nextform.ShowDialog();
        }

        private void OneSide_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BothSides_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
