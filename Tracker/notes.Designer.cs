namespace Tracker
{
    partial class notes
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
            this.viewRecieved_btn = new System.Windows.Forms.Button();
            this.viewSent_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.compose_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // viewRecieved_btn
            // 
            this.viewRecieved_btn.Location = new System.Drawing.Point(12, 62);
            this.viewRecieved_btn.Name = "viewRecieved_btn";
            this.viewRecieved_btn.Size = new System.Drawing.Size(260, 23);
            this.viewRecieved_btn.TabIndex = 3;
            this.viewRecieved_btn.Text = "view recieved";
            this.viewRecieved_btn.UseVisualStyleBackColor = true;
            // 
            // viewSent_btn
            // 
            this.viewSent_btn.Location = new System.Drawing.Point(12, 24);
            this.viewSent_btn.Name = "viewSent_btn";
            this.viewSent_btn.Size = new System.Drawing.Size(260, 23);
            this.viewSent_btn.TabIndex = 2;
            this.viewSent_btn.Text = "view sent";
            this.viewSent_btn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(260, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // compose_btn
            // 
            this.compose_btn.Location = new System.Drawing.Point(12, 266);
            this.compose_btn.Name = "compose_btn";
            this.compose_btn.Size = new System.Drawing.Size(260, 23);
            this.compose_btn.TabIndex = 5;
            this.compose_btn.Text = "compose new message";
            this.compose_btn.UseVisualStyleBackColor = true;
            // 
            // notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 301);
            this.Controls.Add(this.compose_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.viewRecieved_btn);
            this.Controls.Add(this.viewSent_btn);
            this.Name = "notes";
            this.Text = "notes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button viewRecieved_btn;
        private System.Windows.Forms.Button viewSent_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button compose_btn;
    }
}