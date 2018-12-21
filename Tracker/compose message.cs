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
    public partial class compose_message : Form
    {
        private Privileges _privilege;
        private int _ID;
        public compose_message(Privileges privilege, int ID)
        {
            InitializeComponent();
            _privilege = privilege;
            _ID = ID;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                departement_cmbBox.Enabled = false;
                TO_cmbBox.Enabled = false;
            }
        }
    }
}
