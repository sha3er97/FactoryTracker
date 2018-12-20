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
        public operator_main(Privileges privilege, int ID)
        {
            InitializeComponent();
            _privilege = privilege;
            safety_gauges_btn.Enabled = false;
            final_tracker_btn.Enabled = false;
            if (true /*chief operator*/)
            {
                safety_gauges_btn.Enabled = true;
                final_tracker_btn.Enabled = true;
            }
        }
    }
}
