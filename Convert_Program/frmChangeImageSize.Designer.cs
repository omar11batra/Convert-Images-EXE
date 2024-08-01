namespace Convert_Program
{
    partial class frmChangeImageSize
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangeImageSize));
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudHight = new System.Windows.Forms.NumericUpDown();
            this.lbxFiles = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHight)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 26F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(362, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change Images Size";
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSelect.Location = new System.Drawing.Point(13, 137);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(196, 78);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Select Images";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnConvert.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnConvert.Enabled = false;
            this.btnConvert.Location = new System.Drawing.Point(1032, 137);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(196, 78);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert Images";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // nudWidth
            // 
            this.nudWidth.Location = new System.Drawing.Point(908, 137);
            this.nudWidth.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.nudWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Size = new System.Drawing.Size(118, 36);
            this.nudWidth.TabIndex = 3;
            this.nudWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudWidth.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(838, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(838, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hight";
            // 
            // nudHight
            // 
            this.nudHight.Location = new System.Drawing.Point(908, 179);
            this.nudHight.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.nudHight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHight.Name = "nudHight";
            this.nudHight.Size = new System.Drawing.Size(118, 36);
            this.nudHight.TabIndex = 5;
            this.nudHight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudHight.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudHight.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // lbxFiles
            // 
            this.lbxFiles.FormattingEnabled = true;
            this.lbxFiles.ItemHeight = 28;
            this.lbxFiles.Location = new System.Drawing.Point(13, 254);
            this.lbxFiles.Name = "lbxFiles";
            this.lbxFiles.Size = new System.Drawing.Size(1215, 452);
            this.lbxFiles.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(388, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(402, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "تم تصميم هذا البرنامج بواسطة م/ عمر عبدالعزيز";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(299, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(593, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "عمل البرنامج هو ضغط الصور التي تريدها وتصغير حجمها للحجم الدي تريد";
            // 
            // frmChangeImageSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1243, 719);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbxFiles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudHight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudWidth);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmChangeImageSize";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Images Size";
            this.Load += new System.EventHandler(this.frmChangeImageSize_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.NumericUpDown nudWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudHight;
        private System.Windows.Forms.ListBox lbxFiles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

