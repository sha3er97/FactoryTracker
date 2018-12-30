namespace Tracker
{
    partial class compose_message
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.departement_cmbBox = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.TO_cmbBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.send_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.checkBox1.Location = new System.Drawing.Point(12, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(99, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "To Manager";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Departement :";
            // 
            // departement_cmbBox
            // 
            this.departement_cmbBox.FormattingEnabled = true;
            this.departement_cmbBox.Location = new System.Drawing.Point(130, 60);
            this.departement_cmbBox.Name = "departement_cmbBox";
            this.departement_cmbBox.Size = new System.Drawing.Size(148, 21);
            this.departement_cmbBox.TabIndex = 2;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 114);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(67, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "operator";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(116, 114);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(86, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "adminstrator";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // TO_cmbBox
            // 
            this.TO_cmbBox.FormattingEnabled = true;
            this.TO_cmbBox.Location = new System.Drawing.Point(71, 157);
            this.TO_cmbBox.Name = "TO_cmbBox";
            this.TO_cmbBox.Size = new System.Drawing.Size(207, 21);
            this.TO_cmbBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(12, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "To :";
            // 
            // messageBox
            // 
            this.messageBox.Font = new System.Drawing.Font("Tahoma", 10F);
            this.messageBox.Location = new System.Drawing.Point(12, 203);
            this.messageBox.Multiline = true;
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(266, 82);
            this.messageBox.TabIndex = 10;
            // 
            // send_btn
            // 
            this.send_btn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.send_btn.Location = new System.Drawing.Point(89, 303);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(94, 27);
            this.send_btn.TabIndex = 12;
            this.send_btn.Text = "Submit";
            this.send_btn.UseVisualStyleBackColor = true;
            // 
            // compose_message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 342);
            this.Controls.Add(this.send_btn);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.TO_cmbBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.departement_cmbBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Name = "compose_message";
            this.Text = "compose_message";
            this.Load += new System.EventHandler(this.compose_message_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox departement_cmbBox;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ComboBox TO_cmbBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.Button send_btn;
    }
}