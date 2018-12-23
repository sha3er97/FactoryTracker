namespace Tracker
{
    partial class statistics
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.adminsNO = new System.Windows.Forms.Label();
            this.OpsNo = new System.Windows.Forms.Label();
            this.productionAVG = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(37, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "production average";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(23, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "total no of adminstrators";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(37, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "total no of operators";
            // 
            // adminsNO
            // 
            this.adminsNO.AutoSize = true;
            this.adminsNO.Font = new System.Drawing.Font("Tahoma", 10F);
            this.adminsNO.Location = new System.Drawing.Point(238, 40);
            this.adminsNO.Name = "adminsNO";
            this.adminsNO.Size = new System.Drawing.Size(16, 17);
            this.adminsNO.TabIndex = 4;
            this.adminsNO.Text = "0";
            // 
            // OpsNo
            // 
            this.OpsNo.AutoSize = true;
            this.OpsNo.Font = new System.Drawing.Font("Tahoma", 10F);
            this.OpsNo.Location = new System.Drawing.Point(238, 102);
            this.OpsNo.Name = "OpsNo";
            this.OpsNo.Size = new System.Drawing.Size(16, 17);
            this.OpsNo.TabIndex = 5;
            this.OpsNo.Text = "0";
            // 
            // productionAVG
            // 
            this.productionAVG.AutoSize = true;
            this.productionAVG.Font = new System.Drawing.Font("Tahoma", 10F);
            this.productionAVG.Location = new System.Drawing.Point(238, 251);
            this.productionAVG.Name = "productionAVG";
            this.productionAVG.Size = new System.Drawing.Size(16, 17);
            this.productionAVG.TabIndex = 6;
            this.productionAVG.Text = "0";
            // 
            // statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 333);
            this.Controls.Add(this.productionAVG);
            this.Controls.Add(this.OpsNo);
            this.Controls.Add(this.adminsNO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "statistics";
            this.Text = "statistics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label adminsNO;
        private System.Windows.Forms.Label OpsNo;
        private System.Windows.Forms.Label productionAVG;
    }
}