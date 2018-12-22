namespace Tracker
{
    partial class Stop_and_Go
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
            this.compose_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.viewRecieved_btn = new System.Windows.Forms.Button();
            this.viewSent_btn = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // compose_btn
            // 
            this.compose_btn.Location = new System.Drawing.Point(12, 287);
            this.compose_btn.Name = "compose_btn";
            this.compose_btn.Size = new System.Drawing.Size(260, 23);
            this.compose_btn.TabIndex = 9;
            this.compose_btn.Text = "compose new card";
            this.compose_btn.UseVisualStyleBackColor = true;
            this.compose_btn.Click += new System.EventHandler(this.compose_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(260, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // viewRecieved_btn
            // 
            this.viewRecieved_btn.Location = new System.Drawing.Point(12, 60);
            this.viewRecieved_btn.Name = "viewRecieved_btn";
            this.viewRecieved_btn.Size = new System.Drawing.Size(260, 23);
            this.viewRecieved_btn.TabIndex = 7;
            this.viewRecieved_btn.Text = "view recieved";
            this.viewRecieved_btn.UseVisualStyleBackColor = true;
            this.viewRecieved_btn.Click += new System.EventHandler(this.viewRecieved_btn_Click_1);
            // 
            // viewSent_btn
            // 
            this.viewSent_btn.Location = new System.Drawing.Point(12, 22);
            this.viewSent_btn.Name = "viewSent_btn";
            this.viewSent_btn.Size = new System.Drawing.Size(260, 23);
            this.viewSent_btn.TabIndex = 6;
            this.viewSent_btn.Text = "view sent";
            this.viewSent_btn.UseVisualStyleBackColor = true;
            this.viewSent_btn.Click += new System.EventHandler(this.viewSent_btn_Click_1);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(120, 95);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(38, 17);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.Text = "Go";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AllowDrop = true;
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(16, 95);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 17);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Stop";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Stop_and_Go
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 323);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.compose_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.viewRecieved_btn);
            this.Controls.Add(this.viewSent_btn);
            this.Name = "Stop_and_Go";
            this.Text = "Stop_and_Go";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button compose_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button viewRecieved_btn;
        private System.Windows.Forms.Button viewSent_btn;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}