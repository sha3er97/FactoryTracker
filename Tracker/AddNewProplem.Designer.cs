namespace Tracker
{
    partial class AddNewProplem
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
            this.machine_cmbBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.category_cmbBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.causeBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.solutionBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.save_btn = new System.Windows.Forms.Button();
            this.type_cmbBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // machine_cmbBox
            // 
            this.machine_cmbBox.FormattingEnabled = true;
            this.machine_cmbBox.Location = new System.Drawing.Point(148, 70);
            this.machine_cmbBox.Name = "machine_cmbBox";
            this.machine_cmbBox.Size = new System.Drawing.Size(203, 21);
            this.machine_cmbBox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(13, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "choose machine :";
            // 
            // category_cmbBox
            // 
            this.category_cmbBox.FormattingEnabled = true;
            this.category_cmbBox.Location = new System.Drawing.Point(148, 15);
            this.category_cmbBox.Name = "category_cmbBox";
            this.category_cmbBox.Size = new System.Drawing.Size(203, 21);
            this.category_cmbBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(11, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "proplem category :";
            // 
            // descriptionBox
            // 
            this.descriptionBox.Font = new System.Drawing.Font("Tahoma", 10F);
            this.descriptionBox.Location = new System.Drawing.Point(148, 105);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(203, 82);
            this.descriptionBox.TabIndex = 14;
            this.descriptionBox.TextChanged += new System.EventHandler(this.feedbackBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(14, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Description :";
            // 
            // causeBox
            // 
            this.causeBox.Font = new System.Drawing.Font("Tahoma", 10F);
            this.causeBox.Location = new System.Drawing.Point(148, 204);
            this.causeBox.Multiline = true;
            this.causeBox.Name = "causeBox";
            this.causeBox.Size = new System.Drawing.Size(203, 40);
            this.causeBox.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.Location = new System.Drawing.Point(14, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "cause :";
            // 
            // solutionBox
            // 
            this.solutionBox.Font = new System.Drawing.Font("Tahoma", 10F);
            this.solutionBox.Location = new System.Drawing.Point(148, 261);
            this.solutionBox.Multiline = true;
            this.solutionBox.Name = "solutionBox";
            this.solutionBox.Size = new System.Drawing.Size(203, 40);
            this.solutionBox.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label6.Location = new System.Drawing.Point(12, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "solution :";
            // 
            // save_btn
            // 
            this.save_btn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.save_btn.Location = new System.Drawing.Point(131, 322);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(94, 27);
            this.save_btn.TabIndex = 19;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            // 
            // type_cmbBox
            // 
            this.type_cmbBox.FormattingEnabled = true;
            this.type_cmbBox.Location = new System.Drawing.Point(148, 43);
            this.type_cmbBox.Name = "type_cmbBox";
            this.type_cmbBox.Size = new System.Drawing.Size(203, 21);
            this.type_cmbBox.TabIndex = 35;
            this.type_cmbBox.SelectedIndexChanged += new System.EventHandler(this.type_cmbBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(14, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "machine type :";
            // 
            // AddNewProplem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 357);
            this.Controls.Add(this.type_cmbBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.solutionBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.causeBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.machine_cmbBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.category_cmbBox);
            this.Controls.Add(this.label2);
            this.Name = "AddNewProplem";
            this.Text = "AddNewProplem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox machine_cmbBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox category_cmbBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox causeBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox solutionBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.ComboBox type_cmbBox;
        private System.Windows.Forms.Label label1;
    }
}