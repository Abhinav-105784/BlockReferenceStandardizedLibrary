namespace BlocksBases
{
    partial class Select_Blocks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.MainBlock = new System.Windows.Forms.TextBox();
            this.Browse_Main = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.X = new System.Windows.Forms.TextBox();
            this.Y = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Offset = new System.Windows.Forms.TextBox();
            this.Run = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.OneSide = new System.Windows.Forms.CheckBox();
            this.BothSides = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Triplet = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Main Block";
            // 
            // MainBlock
            // 
            this.MainBlock.Location = new System.Drawing.Point(12, 28);
            this.MainBlock.Name = "MainBlock";
            this.MainBlock.Size = new System.Drawing.Size(402, 22);
            this.MainBlock.TabIndex = 14;
            this.MainBlock.TextChanged += new System.EventHandler(this.MainBlock_TextChanged);
            // 
            // Browse_Main
            // 
            this.Browse_Main.Location = new System.Drawing.Point(162, 56);
            this.Browse_Main.Name = "Browse_Main";
            this.Browse_Main.Size = new System.Drawing.Size(75, 23);
            this.Browse_Main.TabIndex = 15;
            this.Browse_Main.Text = "Browse";
            this.Browse_Main.UseVisualStyleBackColor = true;
            this.Browse_Main.Click += new System.EventHandler(this.Browse_Main_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Y:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "X:";
            // 
            // X
            // 
            this.X.Location = new System.Drawing.Point(55, 106);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(79, 22);
            this.X.TabIndex = 16;
            this.X.TextChanged += new System.EventHandler(this.X_TextChanged);
            // 
            // Y
            // 
            this.Y.Location = new System.Drawing.Point(318, 103);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(79, 22);
            this.Y.TabIndex = 19;
            this.Y.TextChanged += new System.EventHandler(this.Y_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Centerline start";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Offset";
            // 
            // Offset
            // 
            this.Offset.Location = new System.Drawing.Point(162, 144);
            this.Offset.Name = "Offset";
            this.Offset.Size = new System.Drawing.Size(75, 22);
            this.Offset.TabIndex = 21;
            this.Offset.TextChanged += new System.EventHandler(this.Offset_TextChanged);
            // 
            // Run
            // 
            this.Run.Location = new System.Drawing.Point(15, 275);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(75, 23);
            this.Run.TabIndex = 23;
            this.Run.Text = "Run";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(162, 275);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 24;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(310, 275);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 25;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // OneSide
            // 
            this.OneSide.AutoSize = true;
            this.OneSide.Location = new System.Drawing.Point(34, 223);
            this.OneSide.Name = "OneSide";
            this.OneSide.Size = new System.Drawing.Size(85, 20);
            this.OneSide.TabIndex = 26;
            this.OneSide.Text = "One Side";
            this.OneSide.UseVisualStyleBackColor = true;
            this.OneSide.CheckedChanged += new System.EventHandler(this.OneSide_CheckedChanged);
            // 
            // BothSides
            // 
            this.BothSides.AutoSize = true;
            this.BothSides.Location = new System.Drawing.Point(160, 223);
            this.BothSides.Name = "BothSides";
            this.BothSides.Size = new System.Drawing.Size(94, 20);
            this.BothSides.TabIndex = 27;
            this.BothSides.Text = "Both Sides";
            this.BothSides.UseVisualStyleBackColor = true;
            this.BothSides.CheckedChanged += new System.EventHandler(this.BothSides_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(85, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(252, 32);
            this.label6.TabIndex = 35;
            this.label6.Text = "for any queries \r\ncontact : abhinav.goswami@arcadis.com";
            // 
            // Triplet
            // 
            this.Triplet.AutoSize = true;
            this.Triplet.Location = new System.Drawing.Point(318, 223);
            this.Triplet.Name = "Triplet";
            this.Triplet.Size = new System.Drawing.Size(67, 20);
            this.Triplet.TabIndex = 44;
            this.Triplet.Text = "Triplet";
            this.Triplet.UseVisualStyleBackColor = true;
            // 
            // Select_Blocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 366);
            this.Controls.Add(this.Triplet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BothSides);
            this.Controls.Add(this.OneSide);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Offset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.X);
            this.Controls.Add(this.Browse_Main);
            this.Controls.Add(this.MainBlock);
            this.Controls.Add(this.label1);
            this.Name = "Select_Blocks";
            this.Text = "SelectBlocks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MainBlock;
        private System.Windows.Forms.Button Browse_Main;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox X;
        private System.Windows.Forms.TextBox Y;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Offset;
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.CheckBox OneSide;
        private System.Windows.Forms.CheckBox BothSides;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox Triplet;
    }
}