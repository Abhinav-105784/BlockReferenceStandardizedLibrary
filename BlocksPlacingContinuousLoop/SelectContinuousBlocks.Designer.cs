namespace BlocksPlacingContinuousLoop
{
    partial class SelectContinuousBlocks
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
            this.Main_Block = new System.Windows.Forms.TextBox();
            this.Left_Block = new System.Windows.Forms.TextBox();
            this.Right_Block = new System.Windows.Forms.TextBox();
            this.Next_Distance = new System.Windows.Forms.TextBox();
            this.Browse_Main = new System.Windows.Forms.Button();
            this.Browse_Left = new System.Windows.Forms.Button();
            this.Browse_right = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.LeftCheck = new System.Windows.Forms.CheckBox();
            this.RightCheck = new System.Windows.Forms.CheckBox();
            this.Distance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Vertical_Distance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Down_Check = new System.Windows.Forms.CheckBox();
            this.Up_Check = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Main_Block
            // 
            this.Main_Block.Location = new System.Drawing.Point(12, 32);
            this.Main_Block.Name = "Main_Block";
            this.Main_Block.Size = new System.Drawing.Size(302, 22);
            this.Main_Block.TabIndex = 18;
            this.Main_Block.TextChanged += new System.EventHandler(this.Main_Block_TextChanged);
            // 
            // Left_Block
            // 
            this.Left_Block.Location = new System.Drawing.Point(12, 92);
            this.Left_Block.Name = "Left_Block";
            this.Left_Block.Size = new System.Drawing.Size(302, 22);
            this.Left_Block.TabIndex = 19;
            this.Left_Block.TextChanged += new System.EventHandler(this.Left_Block_TextChanged);
            // 
            // Right_Block
            // 
            this.Right_Block.Location = new System.Drawing.Point(12, 153);
            this.Right_Block.Name = "Right_Block";
            this.Right_Block.Size = new System.Drawing.Size(302, 22);
            this.Right_Block.TabIndex = 20;
            this.Right_Block.TextChanged += new System.EventHandler(this.Right_Block_TextChanged);
            // 
            // Next_Distance
            // 
            this.Next_Distance.Location = new System.Drawing.Point(124, 282);
            this.Next_Distance.Name = "Next_Distance";
            this.Next_Distance.Size = new System.Drawing.Size(75, 22);
            this.Next_Distance.TabIndex = 21;
            this.Next_Distance.TextChanged += new System.EventHandler(this.Next_Distance_TextChanged);
            // 
            // Browse_Main
            // 
            this.Browse_Main.Location = new System.Drawing.Point(124, 63);
            this.Browse_Main.Name = "Browse_Main";
            this.Browse_Main.Size = new System.Drawing.Size(75, 23);
            this.Browse_Main.TabIndex = 22;
            this.Browse_Main.Text = "Browse";
            this.Browse_Main.UseVisualStyleBackColor = true;
            this.Browse_Main.Click += new System.EventHandler(this.Browse_Main_Click);
            // 
            // Browse_Left
            // 
            this.Browse_Left.Location = new System.Drawing.Point(124, 124);
            this.Browse_Left.Name = "Browse_Left";
            this.Browse_Left.Size = new System.Drawing.Size(75, 23);
            this.Browse_Left.TabIndex = 23;
            this.Browse_Left.Text = "Browse";
            this.Browse_Left.UseVisualStyleBackColor = true;
            this.Browse_Left.Click += new System.EventHandler(this.Browse_Left_Click);
            // 
            // Browse_right
            // 
            this.Browse_right.Location = new System.Drawing.Point(124, 181);
            this.Browse_right.Name = "Browse_right";
            this.Browse_right.Size = new System.Drawing.Size(75, 23);
            this.Browse_right.TabIndex = 24;
            this.Browse_right.Text = "Browse";
            this.Browse_right.UseVisualStyleBackColor = true;
            this.Browse_right.Click += new System.EventHandler(this.Browse_right_Click);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(216, 237);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 25;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(29, 237);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(75, 23);
            this.Open.TabIndex = 26;
            this.Open.Text = "Run";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(124, 428);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 27;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // LeftCheck
            // 
            this.LeftCheck.AutoSize = true;
            this.LeftCheck.Location = new System.Drawing.Point(73, 321);
            this.LeftCheck.Name = "LeftCheck";
            this.LeftCheck.Size = new System.Drawing.Size(68, 20);
            this.LeftCheck.TabIndex = 28;
            this.LeftCheck.Text = "Left <--";
            this.LeftCheck.UseVisualStyleBackColor = true;
            this.LeftCheck.CheckedChanged += new System.EventHandler(this.LeftCheck_CheckedChanged);
            // 
            // RightCheck
            // 
            this.RightCheck.AutoSize = true;
            this.RightCheck.Location = new System.Drawing.Point(184, 321);
            this.RightCheck.Name = "RightCheck";
            this.RightCheck.Size = new System.Drawing.Size(78, 20);
            this.RightCheck.TabIndex = 29;
            this.RightCheck.Text = "Right -->";
            this.RightCheck.UseVisualStyleBackColor = true;
            this.RightCheck.CheckedChanged += new System.EventHandler(this.RightCheck_CheckedChanged);
            // 
            // Distance
            // 
            this.Distance.AutoSize = true;
            this.Distance.Location = new System.Drawing.Point(99, 263);
            this.Distance.Name = "Distance";
            this.Distance.Size = new System.Drawing.Size(123, 16);
            this.Distance.TabIndex = 30;
            this.Distance.Text = "Horizontal Distance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Main Block";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Left Block";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Right Block";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(39, 465);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(252, 32);
            this.label6.TabIndex = 34;
            this.label6.Text = "for any queries \r\ncontact : abhinav.goswami@arcadis.com";
            // 
            // Vertical_Distance
            // 
            this.Vertical_Distance.Location = new System.Drawing.Point(124, 372);
            this.Vertical_Distance.Name = "Vertical_Distance";
            this.Vertical_Distance.Size = new System.Drawing.Size(75, 22);
            this.Vertical_Distance.TabIndex = 35;
            this.Vertical_Distance.TextChanged += new System.EventHandler(this.Vertical_Distance_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "Vertical Distance";
            // 
            // Down_Check
            // 
            this.Down_Check.AutoSize = true;
            this.Down_Check.Location = new System.Drawing.Point(73, 402);
            this.Down_Check.Name = "Down_Check";
            this.Down_Check.Size = new System.Drawing.Size(66, 20);
            this.Down_Check.TabIndex = 37;
            this.Down_Check.Text = "Down ";
            this.Down_Check.UseVisualStyleBackColor = true;
            // 
            // Up_Check
            // 
            this.Up_Check.AutoSize = true;
            this.Up_Check.Location = new System.Drawing.Point(184, 402);
            this.Up_Check.Name = "Up_Check";
            this.Up_Check.Size = new System.Drawing.Size(47, 20);
            this.Up_Check.TabIndex = 38;
            this.Up_Check.Text = "Up";
            this.Up_Check.UseVisualStyleBackColor = true;
            // 
            // SelectContinuousBlocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 506);
            this.Controls.Add(this.Up_Check);
            this.Controls.Add(this.Down_Check);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Vertical_Distance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Distance);
            this.Controls.Add(this.RightCheck);
            this.Controls.Add(this.LeftCheck);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Browse_right);
            this.Controls.Add(this.Browse_Left);
            this.Controls.Add(this.Browse_Main);
            this.Controls.Add(this.Next_Distance);
            this.Controls.Add(this.Right_Block);
            this.Controls.Add(this.Left_Block);
            this.Controls.Add(this.Main_Block);
            this.Name = "SelectContinuousBlocks";
            this.Text = "SelectContinuousBlocks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Main_Block;
        private System.Windows.Forms.TextBox Left_Block;
        private System.Windows.Forms.TextBox Right_Block;
        private System.Windows.Forms.TextBox Next_Distance;
        private System.Windows.Forms.Button Browse_Main;
        private System.Windows.Forms.Button Browse_Left;
        private System.Windows.Forms.Button Browse_right;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.CheckBox LeftCheck;
        private System.Windows.Forms.CheckBox RightCheck;
        private System.Windows.Forms.Label Distance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Vertical_Distance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox Down_Check;
        private System.Windows.Forms.CheckBox Up_Check;
    }
}