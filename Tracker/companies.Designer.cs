namespace Tracker
{
    partial class companies
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
            this.addCompany_btn = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.machine_cmbBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.departement_cmbBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.delete_btn = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(318, 180);
            this.dataGridView1.TabIndex = 13;
            // 
            // addCompany_btn
            // 
            this.addCompany_btn.Location = new System.Drawing.Point(43, 349);
            this.addCompany_btn.Name = "addCompany_btn";
            this.addCompany_btn.Size = new System.Drawing.Size(260, 24);
            this.addCompany_btn.TabIndex = 14;
            this.addCompany_btn.Text = "add new company";
            this.addCompany_btn.UseVisualStyleBackColor = true;
            this.addCompany_btn.Click += new System.EventHandler(this.addCompany_btn_Click);
            // 
            // search_btn
            // 
            this.search_btn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.search_btn.Location = new System.Drawing.Point(21, 116);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(139, 27);
            this.search_btn.TabIndex = 17;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // machine_cmbBox
            // 
            this.machine_cmbBox.FormattingEnabled = true;
            this.machine_cmbBox.Location = new System.Drawing.Point(168, 77);
            this.machine_cmbBox.Name = "machine_cmbBox";
            this.machine_cmbBox.Size = new System.Drawing.Size(148, 21);
            this.machine_cmbBox.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(28, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "choose machine :";
            // 
            // departement_cmbBox
            // 
            this.departement_cmbBox.FormattingEnabled = true;
            this.departement_cmbBox.Location = new System.Drawing.Point(147, 12);
            this.departement_cmbBox.Name = "departement_cmbBox";
            this.departement_cmbBox.Size = new System.Drawing.Size(170, 21);
            this.departement_cmbBox.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(29, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Departement :";
            // 
            // delete_btn
            // 
            this.delete_btn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.delete_btn.Location = new System.Drawing.Point(183, 116);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(139, 27);
            this.delete_btn.TabIndex = 24;
            this.delete_btn.Text = "delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.radioButton2.Location = new System.Drawing.Point(189, 47);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(58, 21);
            this.radioButton2.TabIndex = 42;
            this.radioButton2.Text = "utility";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AllowDrop = true;
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.radioButton1.Location = new System.Drawing.Point(57, 46);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(93, 21);
            this.radioButton1.TabIndex = 41;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "production";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // companies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 380);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.machine_cmbBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.departement_cmbBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.addCompany_btn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "companies";
            this.Text = "companies";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addCompany_btn;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.ComboBox machine_cmbBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox departement_cmbBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}