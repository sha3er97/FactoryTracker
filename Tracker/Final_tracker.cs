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
        private int _ID;
        private Controller controllerObj;
        public Final_tracker(Privileges privilege, int ID)
        {
            InitializeComponent();
            controllerObj = new Controller();
            _privilege = privilege;
            _ID = ID;
            feedbackBox.Enabled = false;
            numericUpDown1.Enabled = false;
            if (privilege == Privileges.Manager)
            {
                feedbackBox.Enabled = true;
            }
            if (privilege == Privileges.Operators 
                && controllerObj.getIS_Chief(_ID) == 1 
                &&  controllerObj.getDepOperatorByID(_ID)=="production")
            {
                numericUpDown1.Enabled = true;
            }


        }
        private void save_btn_Click(object sender, EventArgs e)
        {
            controllerObj.Updatetracker(Convert.ToInt32(numericUpDown1.Value), feedbackBox.Text, dateTimePicker1.Value);
        }
        private void Final_tracker_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = controllerObj.getQTY(dateTimePicker1.Value);
            feedbackBox.Text = controllerObj.getfeed(dateTimePicker1.Value);
        }
    }
}
