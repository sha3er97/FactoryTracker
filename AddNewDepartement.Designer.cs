namespace Tracker
{
    partial class AddNewDepartement
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.category_cmbBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buildingNo_numeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.partitionNo_numeric = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.save_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.buildingNo_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partitionNo_numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textBox1.Location = new System.Drawing.Point(148, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 24);
            this.textBox1.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(22, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "name :";
            // 
            // category_cmbBox
            // 
            this.category_cmbBox.FormattingEnabled = true;
            this.category_cmbBox.Location = new System.Drawing.Point(148, 61);
            this.category_cmbBox.Name = "category_cmbBox";
            this.category_cmbBox.Size = new System.Drawing.Size(203, 21);
            this.category_cmbBox.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(16, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "category :";
            // 
            // buildingNo_numeric
            // 
            this.buildingNo_numeric.Font = new System.Drawing.Font("Tahoma", 10F);
            this.buildingNo_numeric.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.buildingNo_numeric.Location = new System.Drawing.Point(148, 99);
            this.buildingNo_numeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.buildingNo_numeric.Name = "buildingNo_numeric";
            this.buildingNo_numeric.Size = new System.Drawing.Size(204, 24);
            this.buildingNo_numeric.TabIndex = 21;
            this.buildingNo_numeric.ThousandsSeparator = true;
            this.buildingNo_numeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(16, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Building NO. :";
            // 
            // partitionNo_numeric
            // 
            this.partitionNo_numeric.Font = new System.Drawing.Font("Tahoma", 10F);
            this.partitionNo_numeric.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.partitionNo_numeric.Location = new System.Drawing.Point(148, 142);
            this.partitionNo_numeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.partitionNo_numeric.Name = "partitionNo_numeric";
            this.partitionNo_numeric.Size = new System.Drawing.Size(204, 24);
            this.partitionNo_numeric.TabIndex = 23;
            this.partitionNo_numeric.ThousandsSeparator = true;
            this.partitionNo_numeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(16, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Partition NO. :";
            // 
            // save_btn
            // 
            this.save_btn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.save_btn.Location = new System.Drawing.Point(122, 208);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(94, 27);
            this.save_btn.TabIndex = 26;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            // 
            // AddNewDepartement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 249);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.partitionNo_numeric);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buildingNo_numeric);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.category_cmbBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Name = "AddNewDepartement";
            this.Text = "AddNewDepartement";
            ((System.ComponentModel.ISupportInitialize)(this.buildingNo_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partitionNo_numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox category_cmbBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown buildingNo_numeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown partitionNo_numeric;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button save_btn;
    }
}