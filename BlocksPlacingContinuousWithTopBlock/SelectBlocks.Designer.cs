namespace BlocksPlacingContinuousLoop
{
    partial class SelectBlocks
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
            this.MainBlock = new System.Windows.Forms.TextBox();
            this.LeftBlock = new System.Windows.Forms.MaskedTextBox();
            this.RightBlock = new System.Windows.Forms.TextBox();
            this.Browse_Main = new System.Windows.Forms.Button();
            this.Browse_Left = new System.Windows.Forms.Button();
            this.Browse_Right = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.Button();
            this.X = new System.Windows.Forms.TextBox();
            this.Y = new System.Windows.Forms.TextBox();
            this.Next = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CentreBlock = new System.Windows.Forms.TextBox();
            this.BrowseCentreBlock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainBlock
            // 
            this.MainBlock.Location = new System.Drawing.Point(22, 32);
            this.MainBlock.Name = "MainBlock";
            this.MainBlock.Size = new System.Drawing.Size(306, 22);
            this.MainBlock.TabIndex = 0;
            this.MainBlock.TextChanged += new System.EventHandler(this.MainBlock_TextChanged);
            // 
            // LeftBlock
            // 
            this.LeftBlock.Location = new System.Drawing.Point(22, 154);
            this.LeftBlock.Name = "LeftBlock";
            this.LeftBlock.Size = new System.Drawing.Size(306, 22);
            this.LeftBlock.TabIndex = 1;
            this.LeftBlock.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.LeftBlock_MaskInputRejected);
            // 
            // RightBlock
            // 
            this.RightBlock.Location = new System.Drawing.Point(22, 218);
            this.RightBlock.Name = "RightBlock";
            this.RightBlock.Size = new System.Drawing.Size(306, 22);
            this.RightBlock.TabIndex = 2;
            this.RightBlock.TextChanged += new System.EventHandler(this.RightBlock_TextChanged);
            // 
            // Browse_Main
            // 
            this.Browse_Main.Location = new System.Drawing.Point(131, 60);
            this.Browse_Main.Name = "Browse_Main";
            this.Browse_Main.Size = new System.Drawing.Size(75, 23);
            this.Browse_Main.TabIndex = 3;
            this.Browse_Main.Text = "Browse";
            this.Browse_Main.UseVisualStyleBackColor = true;
            this.Browse_Main.Click += new System.EventHandler(this.Browse_Main_Click);
            // 
            // Browse_Left
            // 
            this.Browse_Left.Location = new System.Drawing.Point(131, 182);
            this.Browse_Left.Name = "Browse_Left";
            this.Browse_Left.Size = new System.Drawing.Size(75, 23);
            this.Browse_Left.TabIndex = 4;
            this.Browse_Left.Text = "Browse";
            this.Browse_Left.UseVisualStyleBackColor = true;
            this.Browse_Left.Click += new System.EventHandler(this.Browse_Left_Click);
            // 
            // Browse_Right
            // 
            this.Browse_Right.Location = new System.Drawing.Point(131, 246);
            this.Browse_Right.Name = "Browse_Right";
            this.Browse_Right.Size = new System.Drawing.Size(75, 23);
            this.Browse_Right.TabIndex = 5;
            this.Browse_Right.Text = "Browse";
            this.Browse_Right.UseVisualStyleBackColor = true;
            this.Browse_Right.Click += new System.EventHandler(this.Browse_Right_Click);
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(22, 383);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(75, 23);
            this.Open.TabIndex = 6;
            this.Open.Text = "Run";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // X
            // 
            this.X.Location = new System.Drawing.Point(43, 96);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(79, 22);
            this.X.TabIndex = 7;
            this.X.TextChanged += new System.EventHandler(this.X_TextChanged);
            // 
            // Y
            // 
            this.Y.Location = new System.Drawing.Point(231, 99);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(75, 22);
            this.Y.TabIndex = 8;
            this.Y.TextChanged += new System.EventHandler(this.Y_TextChanged);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(244, 383);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 10;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(131, 383);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 11;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Main Block";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "X:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Y:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Left Block";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Right Block";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(40, 425);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(252, 32);
            this.label6.TabIndex = 19;
            this.label6.Text = "for any queries \r\ncontact : abhinav.goswami@arcadis.com";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Top Block";
            // 
            // CentreBlock
            // 
            this.CentreBlock.Location = new System.Drawing.Point(22, 296);
            this.CentreBlock.Name = "CentreBlock";
            this.CentreBlock.Size = new System.Drawing.Size(306, 22);
            this.CentreBlock.TabIndex = 21;
            this.CentreBlock.TextChanged += new System.EventHandler(this.CentreBlock_TextChanged);
            // 
            // BrowseCentreBlock
            // 
            this.BrowseCentreBlock.Location = new System.Drawing.Point(131, 333);
            this.BrowseCentreBlock.Name = "BrowseCentreBlock";
            this.BrowseCentreBlock.Size = new System.Drawing.Size(75, 23);
            this.BrowseCentreBlock.TabIndex = 22;
            this.BrowseCentreBlock.Text = "Browse";
            this.BrowseCentreBlock.UseVisualStyleBackColor = true;
            this.BrowseCentreBlock.Click += new System.EventHandler(this.BrowseCentreBlock_Click);
            // 
            // SelectBlocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 471);
            this.Controls.Add(this.BrowseCentreBlock);
            this.Controls.Add(this.CentreBlock);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.X);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.Browse_Right);
            this.Controls.Add(this.Browse_Left);
            this.Controls.Add(this.Browse_Main);
            this.Controls.Add(this.RightBlock);
            this.Controls.Add(this.LeftBlock);
            this.Controls.Add(this.MainBlock);
            this.Name = "SelectBlocks";
            this.Text = "SelectMain";
            this.Load += new System.EventHandler(this.SelectMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MainBlock;
        private System.Windows.Forms.MaskedTextBox LeftBlock;
        private System.Windows.Forms.TextBox RightBlock;
        private System.Windows.Forms.Button Browse_Main;
        private System.Windows.Forms.Button Browse_Left;
        private System.Windows.Forms.Button Browse_Right;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.TextBox X;
        private System.Windows.Forms.TextBox Y;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CentreBlock;
        private System.Windows.Forms.Button BrowseCentreBlock;
    }
}