namespace Tracker
{
    partial class AddNewStop_Go
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
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.solutionBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.causeBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.send_btn = new System.Windows.Forms.Button();
            this.toAdmin_cmbBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(204, 20);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(38, 17);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.Text = "Go";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AllowDrop = true;
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(100, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 17);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Stop";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // solutionBox
            // 
            this.solutionBox.Font = new System.Drawing.Font("Tahoma", 10F);
            this.solutionBox.Location = new System.Drawing.Point(145, 136);
            this.solutionBox.Multiline = true;
            this.solutionBox.Name = "solutionBox";
            this.solutionBox.Size = new System.Drawing.Size(203, 40);
            this.solutionBox.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label6.Location = new System.Drawing.Point(9, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Comment :";
            // 
            // causeBox
            // 
            this.causeBox.Font = new System.Drawing.Font("Tahoma", 10F);
            this.causeBox.Location = new System.Drawing.Point(145, 79);
            this.causeBox.Multiline = true;
            this.causeBox.Name = "causeBox";
            this.causeBox.Size = new System.Drawing.Size(203, 40);
            this.causeBox.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.Location = new System.Drawing.Point(11, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Observation :";
            // 
            // send_btn
            // 
            this.send_btn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.send_btn.Location = new System.Drawing.Point(134, 195);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(94, 27);
            this.send_btn.TabIndex = 23;
            this.send_btn.Text = "Send";
            this.send_btn.UseVisualStyleBackColor = true;
            this.send_btn.Click += new System.EventHandler(this.send_btn_Click_1);
            // 
            // toAdmin_cmbBox
            // 
            this.toAdmin_cmbBox.FormattingEnabled = true;
            this.toAdmin_cmbBox.Location = new System.Drawing.Point(145, 52);
            this.toAdmin_cmbBox.Name = "toAdmin_cmbBox";
            this.toAdmin_cmbBox.Size = new System.Drawing.Size(203, 21);
            this.toAdmin_cmbBox.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "To :";
            // 
            // AddNewStop_Go
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 240);
            this.Controls.Add(this.toAdmin_cmbBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.send_btn);
            this.Controls.Add(this.solutionBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.causeBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Name = "AddNewStop_Go";
            this.Text = "AddNewStop_Go";
            this.Load += new System.EventHandler(this.AddNewStop_Go_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox solutionBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox causeBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button send_btn;
        private System.Windows.Forms.ComboBox toAdmin_cmbBox;
        private System.Windows.Forms.Label label2;
    }
}