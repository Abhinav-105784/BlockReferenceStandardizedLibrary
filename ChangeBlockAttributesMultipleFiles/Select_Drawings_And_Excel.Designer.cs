namespace ChangeBlocksAttributes_MultipleDrawings
{
    partial class Select_Drawings_And_Excel
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
            this.browse_Excel = new System.Windows.Forms.Button();
            this.Sheet = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.File = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Open = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Drawing_List = new System.Windows.Forms.ListBox();
            this.Browse_Drawings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(405, 929);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "For any issues Contact abhinav.goswami@arcadis.com";
            // 
            // browse_Excel
            // 
            this.browse_Excel.Location = new System.Drawing.Point(23, 517);
            this.browse_Excel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.browse_Excel.Name = "browse_Excel";
            this.browse_Excel.Size = new System.Drawing.Size(161, 44);
            this.browse_Excel.TabIndex = 28;
            this.browse_Excel.Text = "Browse Excel";
            this.browse_Excel.UseVisualStyleBackColor = true;
            this.browse_Excel.Click += new System.EventHandler(this.browse_Excel_Click);
            // 
            // Sheet
            // 
            this.Sheet.AutoSize = true;
            this.Sheet.Location = new System.Drawing.Point(-43, 487);
            this.Sheet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Sheet.Name = "Sheet";
            this.Sheet.Size = new System.Drawing.Size(48, 16);
            this.Sheet.TabIndex = 27;
            this.Sheet.Text = "Sheet :";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(84, 471);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(269, 24);
            this.comboBox2.TabIndex = 26;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // File
            // 
            this.File.AutoSize = true;
            this.File.Location = new System.Drawing.Point(-43, 423);
            this.File.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(35, 16);
            this.File.TabIndex = 25;
            this.File.Text = "File :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(84, 416);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(825, 22);
            this.textBox2.TabIndex = 24;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(23, 903);
            this.Open.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(100, 42);
            this.Open.TabIndex = 23;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(997, 903);
            this.Close.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(96, 41);
            this.Close.TabIndex = 22;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 3);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1116, 351);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 474);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Sheet :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "File :";
            // 
            // Drawing_List
            // 
            this.Drawing_List.FormattingEnabled = true;
            this.Drawing_List.ItemHeight = 16;
            this.Drawing_List.Location = new System.Drawing.Point(272, 517);
            this.Drawing_List.Name = "Drawing_List";
            this.Drawing_List.Size = new System.Drawing.Size(606, 372);
            this.Drawing_List.TabIndex = 32;
            this.Drawing_List.SelectedIndexChanged += new System.EventHandler(this.Drawing_List_SelectedIndexChanged);
            // 
            // Browse_Drawings
            // 
            this.Browse_Drawings.Location = new System.Drawing.Point(932, 517);
            this.Browse_Drawings.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Browse_Drawings.Name = "Browse_Drawings";
            this.Browse_Drawings.Size = new System.Drawing.Size(161, 44);
            this.Browse_Drawings.TabIndex = 33;
            this.Browse_Drawings.Text = "Browse Drawings";
            this.Browse_Drawings.UseVisualStyleBackColor = true;
            this.Browse_Drawings.Click += new System.EventHandler(this.Browse_Drawings_Click);
            // 
            // Select_Drawings_And_Excel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 956);
            this.Controls.Add(this.Browse_Drawings);
            this.Controls.Add(this.Drawing_List);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.browse_Excel);
            this.Controls.Add(this.Sheet);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.File);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Select_Drawings_And_Excel";
            this.Text = "Select_Drawings_And_Excel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button browse_Excel;
        private System.Windows.Forms.Label Sheet;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label File;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox Drawing_List;
        private System.Windows.Forms.Button Browse_Drawings;
    }
}