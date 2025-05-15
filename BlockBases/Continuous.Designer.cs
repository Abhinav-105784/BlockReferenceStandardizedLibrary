namespace BlocksBases
{
    partial class Continuous
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
            this.Distance = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.Browse_Main = new System.Windows.Forms.Button();
            this.Next_Distance = new System.Windows.Forms.TextBox();
            this.Main_Block = new System.Windows.Forms.TextBox();
            this.OneSide = new System.Windows.Forms.CheckBox();
            this.BothSides = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Triplet = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "Main Block";
            // 
            // Distance
            // 
            this.Distance.AutoSize = true;
            this.Distance.Location = new System.Drawing.Point(140, 170);
            this.Distance.Name = "Distance";
            this.Distance.Size = new System.Drawing.Size(90, 16);
            this.Distance.TabIndex = 38;
            this.Distance.Text = "Next Distance";
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(143, 284);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 37;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(41, 119);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(75, 23);
            this.Open.TabIndex = 36;
            this.Open.Text = "Run";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(235, 119);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 35;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Browse_Main
            // 
            this.Browse_Main.Location = new System.Drawing.Point(143, 56);
            this.Browse_Main.Name = "Browse_Main";
            this.Browse_Main.Size = new System.Drawing.Size(75, 23);
            this.Browse_Main.TabIndex = 34;
            this.Browse_Main.Text = "Browse";
            this.Browse_Main.UseVisualStyleBackColor = true;
            this.Browse_Main.Click += new System.EventHandler(this.Browse_Main_Click);
            // 
            // Next_Distance
            // 
            this.Next_Distance.Location = new System.Drawing.Point(143, 198);
            this.Next_Distance.Name = "Next_Distance";
            this.Next_Distance.Size = new System.Drawing.Size(75, 22);
            this.Next_Distance.TabIndex = 33;
            this.Next_Distance.TextChanged += new System.EventHandler(this.Next_Distance_TextChanged);
            // 
            // Main_Block
            // 
            this.Main_Block.Location = new System.Drawing.Point(31, 25);
            this.Main_Block.Name = "Main_Block";
            this.Main_Block.Size = new System.Drawing.Size(302, 22);
            this.Main_Block.TabIndex = 32;
            this.Main_Block.TextChanged += new System.EventHandler(this.Main_Block_TextChanged);
            // 
            // OneSide
            // 
            this.OneSide.AutoSize = true;
            this.OneSide.Location = new System.Drawing.Point(31, 240);
            this.OneSide.Name = "OneSide";
            this.OneSide.Size = new System.Drawing.Size(85, 20);
            this.OneSide.TabIndex = 40;
            this.OneSide.Text = "One Side";
            this.OneSide.UseVisualStyleBackColor = true;
            this.OneSide.CheckedChanged += new System.EventHandler(this.OneSide_CheckedChanged);
            // 
            // BothSides
            // 
            this.BothSides.AutoSize = true;
            this.BothSides.Location = new System.Drawing.Point(136, 240);
            this.BothSides.Name = "BothSides";
            this.BothSides.Size = new System.Drawing.Size(94, 20);
            this.BothSides.TabIndex = 41;
            this.BothSides.Text = "Both Sides";
            this.BothSides.UseVisualStyleBackColor = true;
            this.BothSides.CheckedChanged += new System.EventHandler(this.BothSides_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(58, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(252, 32);
            this.label6.TabIndex = 42;
            this.label6.Text = "for any queries \r\ncontact : abhinav.goswami@arcadis.com";
            // 
            // Triplet
            // 
            this.Triplet.AutoSize = true;
            this.Triplet.Location = new System.Drawing.Point(255, 240);
            this.Triplet.Name = "Triplet";
            this.Triplet.Size = new System.Drawing.Size(67, 20);
            this.Triplet.TabIndex = 43;
            this.Triplet.Text = "Triplet";
            this.Triplet.UseVisualStyleBackColor = true;
            // 
            // Continuous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 376);
            this.Controls.Add(this.Triplet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BothSides);
            this.Controls.Add(this.OneSide);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Distance);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Browse_Main);
            this.Controls.Add(this.Next_Distance);
            this.Controls.Add(this.Main_Block);
            this.Name = "Continuous";
            this.Text = "Continuous Bases";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Distance;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Browse_Main;
        private System.Windows.Forms.TextBox Next_Distance;
        private System.Windows.Forms.TextBox Main_Block;
        private System.Windows.Forms.CheckBox OneSide;
        private System.Windows.Forms.CheckBox BothSides;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox Triplet;
    }
}