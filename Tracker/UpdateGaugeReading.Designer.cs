namespace Tracker
{
    partial class UpdateGaugeReading
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
            this.type_cmbBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.update_btn = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // type_cmbBox
            // 
            this.type_cmbBox.FormattingEnabled = true;
            this.type_cmbBox.Location = new System.Drawing.Point(99, 34);
            this.type_cmbBox.Name = "type_cmbBox";
            this.type_cmbBox.Size = new System.Drawing.Size(196, 21);
            this.type_cmbBox.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(13, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "gauge :";
            // 
            // update_btn
            // 
            this.update_btn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.update_btn.Location = new System.Drawing.Point(78, 147);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(139, 27);
            this.update_btn.TabIndex = 30;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.numericUpDown1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(143, 87);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(152, 24);
            this.numericUpDown1.TabIndex = 31;
            this.numericUpDown1.ThousandsSeparator = true;
            this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "current reading :";
            // 
            // UpdateGaugeReading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 192);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.type_cmbBox);
            this.Controls.Add(this.label2);
            this.Name = "UpdateGaugeReading";
            this.Text = "UpdateGaugeReading";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox type_cmbBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
    }
}