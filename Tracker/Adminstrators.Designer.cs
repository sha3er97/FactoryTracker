namespace Tracker
{
    partial class Adminstrators
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addAdmin_btn = new System.Windows.Forms.Button();
            this.departement_cmbBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.delete_btn = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(301, 158);
            this.dataGridView1.TabIndex = 19;
            // 
            // addAdmin_btn
            // 
            this.addAdmin_btn.Location = new System.Drawing.Point(27, 291);
            this.addAdmin_btn.Name = "addAdmin_btn";
            this.addAdmin_btn.Size = new System.Drawing.Size(260, 23);
            this.addAdmin_btn.TabIndex = 18;
            this.addAdmin_btn.Text = "add new adminstrator";
            this.addAdmin_btn.UseVisualStyleBackColor = true;
            this.addAdmin_btn.Click += new System.EventHandler(this.addAdmin_btn_Click);
            // 
            // departement_cmbBox
            // 
            this.departement_cmbBox.FormattingEnabled = true;
            this.departement_cmbBox.Location = new System.Drawing.Point(81, 21);
            this.departement_cmbBox.Name = "departement_cmbBox";
            this.departement_cmbBox.Size = new System.Drawing.Size(232, 21);
            this.departement_cmbBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Name :";
            // 
            // delete_btn
            // 
            this.delete_btn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.delete_btn.Location = new System.Drawing.Point(174, 64);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(139, 27);
            this.delete_btn.TabIndex = 37;
            this.delete_btn.Text = "delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            // 
            // search_btn
            // 
            this.search_btn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.search_btn.Location = new System.Drawing.Point(12, 64);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(139, 27);
            this.search_btn.TabIndex = 36;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            // 
            // Adminstrators
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 322);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addAdmin_btn);
            this.Controls.Add(this.departement_cmbBox);
            this.Controls.Add(this.label1);
            this.Name = "Adminstrators";
            this.Text = "Adminstrators";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addAdmin_btn;
        private System.Windows.Forms.ComboBox departement_cmbBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button search_btn;
    }
}