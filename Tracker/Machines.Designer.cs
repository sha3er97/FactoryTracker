namespace Tracker
{
    partial class Machines
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
            this.delete_btn = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.type_cmbBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addMachine_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.departement_cmbBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // delete_btn
            // 
            this.delete_btn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.delete_btn.Location = new System.Drawing.Point(173, 83);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(139, 27);
            this.delete_btn.TabIndex = 35;
            this.delete_btn.Text = "delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click_1);
            // 
            // search_btn
            // 
            this.search_btn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.search_btn.Location = new System.Drawing.Point(11, 83);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(139, 27);
            this.search_btn.TabIndex = 34;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click_1);
            // 
            // type_cmbBox
            // 
            this.type_cmbBox.FormattingEnabled = true;
            this.type_cmbBox.Location = new System.Drawing.Point(127, 46);
            this.type_cmbBox.Name = "type_cmbBox";
            this.type_cmbBox.Size = new System.Drawing.Size(170, 21);
            this.type_cmbBox.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(15, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "type :";
            // 
            // addMachine_btn
            // 
            this.addMachine_btn.Location = new System.Drawing.Point(31, 287);
            this.addMachine_btn.Name = "addMachine_btn";
            this.addMachine_btn.Size = new System.Drawing.Size(260, 23);
            this.addMachine_btn.TabIndex = 31;
            this.addMachine_btn.Text = "add new machine";
            this.addMachine_btn.UseVisualStyleBackColor = true;
            this.addMachine_btn.Click += new System.EventHandler(this.addMachine_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(303, 150);
            this.dataGridView1.TabIndex = 30;
            // 
            // departement_cmbBox
            // 
            this.departement_cmbBox.FormattingEnabled = true;
            this.departement_cmbBox.Location = new System.Drawing.Point(127, 12);
            this.departement_cmbBox.Name = "departement_cmbBox";
            this.departement_cmbBox.Size = new System.Drawing.Size(170, 21);
            this.departement_cmbBox.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Departement :";
            // 
            // Machines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 323);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.type_cmbBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addMachine_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.departement_cmbBox);
            this.Controls.Add(this.label1);
            this.Name = "Machines";
            this.Text = "Machines";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.ComboBox type_cmbBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addMachine_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox departement_cmbBox;
        private System.Windows.Forms.Label label1;
    }
}