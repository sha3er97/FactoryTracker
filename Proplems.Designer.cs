namespace Tracker
{
    partial class Proplems
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
            this.departement_cmbBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.category_cmbBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.machine_cmbBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addProplem_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // departement_cmbBox
            // 
            this.departement_cmbBox.FormattingEnabled = true;
            this.departement_cmbBox.Location = new System.Drawing.Point(152, 17);
            this.departement_cmbBox.Name = "departement_cmbBox";
            this.departement_cmbBox.Size = new System.Drawing.Size(170, 21);
            this.departement_cmbBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Departement :";
            // 
            // category_cmbBox
            // 
            this.category_cmbBox.FormattingEnabled = true;
            this.category_cmbBox.Location = new System.Drawing.Point(152, 84);
            this.category_cmbBox.Name = "category_cmbBox";
            this.category_cmbBox.Size = new System.Drawing.Size(170, 21);
            this.category_cmbBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(8, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "proplem category :";
            // 
            // machine_cmbBox
            // 
            this.machine_cmbBox.FormattingEnabled = true;
            this.machine_cmbBox.Location = new System.Drawing.Point(152, 50);
            this.machine_cmbBox.Name = "machine_cmbBox";
            this.machine_cmbBox.Size = new System.Drawing.Size(166, 21);
            this.machine_cmbBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(8, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "choose machine :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(303, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // addProplem_btn
            // 
            this.addProplem_btn.Location = new System.Drawing.Point(36, 328);
            this.addProplem_btn.Name = "addProplem_btn";
            this.addProplem_btn.Size = new System.Drawing.Size(260, 23);
            this.addProplem_btn.TabIndex = 13;
            this.addProplem_btn.Text = "add new proplem";
            this.addProplem_btn.UseVisualStyleBackColor = true;
            // 
            // delete_btn
            // 
            this.delete_btn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.delete_btn.Location = new System.Drawing.Point(175, 124);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(139, 27);
            this.delete_btn.TabIndex = 26;
            this.delete_btn.Text = "delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            // 
            // search_btn
            // 
            this.search_btn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.search_btn.Location = new System.Drawing.Point(13, 124);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(139, 27);
            this.search_btn.TabIndex = 25;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            // 
            // Proplems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 359);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.addProplem_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.machine_cmbBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.category_cmbBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.departement_cmbBox);
            this.Controls.Add(this.label1);
            this.Name = "Proplems";
            this.Text = "Proplems";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox departement_cmbBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox category_cmbBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox machine_cmbBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addProplem_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button search_btn;
    }
}