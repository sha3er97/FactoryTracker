namespace Tracker
{
    partial class operator_main
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
            this.notes_btn = new System.Windows.Forms.Button();
            this.stop_btn = new System.Windows.Forms.Button();
            this.proplems_btn = new System.Windows.Forms.Button();
            this.safety_gauges_btn = new System.Windows.Forms.Button();
            this.machines_btn = new System.Windows.Forms.Button();
            this.final_tracker_btn = new System.Windows.Forms.Button();
            this.profile_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // notes_btn
            // 
            this.notes_btn.Location = new System.Drawing.Point(12, 155);
            this.notes_btn.Name = "notes_btn";
            this.notes_btn.Size = new System.Drawing.Size(260, 23);
            this.notes_btn.TabIndex = 17;
            this.notes_btn.Text = "notes";
            this.notes_btn.UseVisualStyleBackColor = true;
            this.notes_btn.Click += new System.EventHandler(this.notes_btn_Click);
            // 
            // stop_btn
            // 
            this.stop_btn.Location = new System.Drawing.Point(12, 120);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(260, 23);
            this.stop_btn.TabIndex = 16;
            this.stop_btn.Text = "stop & go cards";
            this.stop_btn.UseVisualStyleBackColor = true;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // proplems_btn
            // 
            this.proplems_btn.Location = new System.Drawing.Point(12, 86);
            this.proplems_btn.Name = "proplems_btn";
            this.proplems_btn.Size = new System.Drawing.Size(260, 23);
            this.proplems_btn.TabIndex = 15;
            this.proplems_btn.Text = "documented proplems";
            this.proplems_btn.UseVisualStyleBackColor = true;
            this.proplems_btn.Click += new System.EventHandler(this.proplems_btn_Click);
            // 
            // safety_gauges_btn
            // 
            this.safety_gauges_btn.Location = new System.Drawing.Point(12, 192);
            this.safety_gauges_btn.Name = "safety_gauges_btn";
            this.safety_gauges_btn.Size = new System.Drawing.Size(260, 23);
            this.safety_gauges_btn.TabIndex = 13;
            this.safety_gauges_btn.Text = "safety gauges";
            this.safety_gauges_btn.UseVisualStyleBackColor = true;
            this.safety_gauges_btn.Click += new System.EventHandler(this.safety_gauges_btn_Click);
            // 
            // machines_btn
            // 
            this.machines_btn.Location = new System.Drawing.Point(12, 48);
            this.machines_btn.Name = "machines_btn";
            this.machines_btn.Size = new System.Drawing.Size(260, 23);
            this.machines_btn.TabIndex = 12;
            this.machines_btn.Text = "machines";
            this.machines_btn.UseVisualStyleBackColor = true;
            this.machines_btn.Click += new System.EventHandler(this.machines_btn_Click);
            // 
            // final_tracker_btn
            // 
            this.final_tracker_btn.Location = new System.Drawing.Point(12, 227);
            this.final_tracker_btn.Name = "final_tracker_btn";
            this.final_tracker_btn.Size = new System.Drawing.Size(260, 23);
            this.final_tracker_btn.TabIndex = 10;
            this.final_tracker_btn.Text = "final tracker";
            this.final_tracker_btn.UseVisualStyleBackColor = true;
            this.final_tracker_btn.Click += new System.EventHandler(this.final_tracker_btn_Click);
            // 
            // profile_btn
            // 
            this.profile_btn.Location = new System.Drawing.Point(12, 10);
            this.profile_btn.Name = "profile_btn";
            this.profile_btn.Size = new System.Drawing.Size(260, 23);
            this.profile_btn.TabIndex = 9;
            this.profile_btn.Text = "profile";
            this.profile_btn.UseVisualStyleBackColor = true;
            this.profile_btn.Click += new System.EventHandler(this.profile_btn_Click);
            // 
            // operator_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.notes_btn);
            this.Controls.Add(this.stop_btn);
            this.Controls.Add(this.proplems_btn);
            this.Controls.Add(this.safety_gauges_btn);
            this.Controls.Add(this.machines_btn);
            this.Controls.Add(this.final_tracker_btn);
            this.Controls.Add(this.profile_btn);
            this.Name = "operator_main";
            this.Text = "operator_main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button notes_btn;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.Button proplems_btn;
        private System.Windows.Forms.Button safety_gauges_btn;
        private System.Windows.Forms.Button machines_btn;
        private System.Windows.Forms.Button final_tracker_btn;
        private System.Windows.Forms.Button profile_btn;
    }
}