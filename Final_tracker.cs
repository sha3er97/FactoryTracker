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
    public partial class Final_tracker : Form
    {
        private Privileges _privilege;
        public Final_tracker(Privileges privilege, int ID)
        {
            InitializeComponent();
            _privilege = privilege;
            feedbackBox.Enabled = false;
            numericUpDown1.Enabled = false;
            if (privilege == Privileges.Manager)
            {
                feedbackBox.Enabled = true;
            }
            if (privilege == Privileges.Operators /*&& chief of production*/)
            {
                numericUpDown1.Enabled = true;
            }


        }

        private void Final_tracker_Load(object sender, EventArgs e)
        {

        }
    }
}
