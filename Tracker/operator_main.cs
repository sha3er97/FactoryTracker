using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tracker
{
    public partial class operator_main : Form
    {
        private Privileges _privilege;
        private int _ID;
        private Controller controllerObj;
        public operator_main(Privileges privilege, int ID)
        {
            InitializeComponent();
            controllerObj = new Controller();
            _privilege = privilege;
            _ID = ID;
            safety_gauges_btn.Enabled = false;
            final_tracker_btn.Enabled = false;
            if (controllerObj.getIS_Chief(_ID) == 1)
            {
                safety_gauges_btn.Enabled = true;
                final_tracker_btn.Enabled = true;
            }
        }

        private void profile_btn_Click(object sender, EventArgs e)
        {
            profile f = new profile(_privilege, _ID);
            f.Show();
        }

        private void machines_btn_Click(object sender, EventArgs e)
        {
            Machines f = new Machines(_privilege, _ID);
            f.Show();
        }

        private void proplems_btn_Click(object sender, EventArgs e)
        {
            Proplems f = new Proplems(_privilege, _ID);
            f.Show();
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            Stop_and_Go f = new Stop_and_Go(_privilege, _ID);
            f.Show();
        }

        private void notes_btn_Click(object sender, EventArgs e)
        {
            notes f = new notes(_privilege, _ID);
            f.Show();
        }

        private void safety_gauges_btn_Click(object sender, EventArgs e)
        {
            Safety_gauges f = new Safety_gauges(_privilege, _ID);
            f.Show();
        }

        private void final_tracker_btn_Click(object sender, EventArgs e)
        {
            Final_tracker f = new Final_tracker(_privilege, _ID);
            f.Show();
        }
    }
}
