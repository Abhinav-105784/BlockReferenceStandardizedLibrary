namespace ChangeBlockNames_Excel
{
    partial class Select_Blocks_Excel
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
            this.Grid = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.File = new System.Windows.Forms.Label();
            this.Sheet = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Open = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.Browse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(12, 2);
            this.Grid.Name = "Grid";
            this.Grid.RowHeadersWidth = 51;
            this.Grid.RowTemplate.Height = 24;
            this.Grid.Size = new System.Drawing.Size(983, 325);
            this.Grid.TabIndex = 3;
            this.Grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 376);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(620, 22);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // File
            // 
            this.File.AutoSize = true;
            this.File.Location = new System.Drawing.Point(9, 382);
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(35, 16);
            this.File.TabIndex = 17;
            this.File.Text = "File :";
            // 
            // Sheet
            // 
            this.Sheet.AutoSize = true;
            this.Sheet.Location = new System.Drawing.Point(12, 429);
            this.Sheet.Name = "Sheet";
            this.Sheet.Size = new System.Drawing.Size(48, 16);
            this.Sheet.TabIndex = 19;
            this.Sheet.Text = "Sheet :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(66, 429);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(203, 24);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(907, 370);
            this.Open.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(75, 34);
            this.Open.TabIndex = 22;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(907, 433);
            this.Close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(72, 33);
            this.Close.TabIndex = 21;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(66, 490);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(75, 23);
            this.Browse.TabIndex = 23;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(359, 510);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "For any issues Contact abhinav.goswami@arcadis.com";
            // 
            // Select_Blocks_Excel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 535);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Sheet);
            this.Controls.Add(this.File);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Grid);
            this.Name = "Select_Blocks_Excel";
            this.Text = "Select_Blocks_Excel";
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label File;
        private System.Windows.Forms.Label Sheet;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.Label label1;
    }
}