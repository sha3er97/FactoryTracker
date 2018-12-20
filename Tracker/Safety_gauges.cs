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
    public partial class Safety_gauges : Form
    {
        private Privileges _privilege;
        public Safety_gauges(Privileges privilege, int ID)
        {
            InitializeComponent();
            _privilege = privilege;
            update_btn.Enabled = false;
            addGauge_btn.Enabled = false;
            delete_btn.Enabled = false;
            departement_cmbBox.Enabled = false;
            if (privilege == Privileges.Admin)
            {
                addGauge_btn.Enabled = true;
                delete_btn.Enabled = true;
            }
            if (privilege == Privileges.Manager)
            {
                departement_cmbBox.Enabled = true;

            }
            if (privilege == Privileges.Operators /* && is chief*/)
            {
                update_btn.Enabled = true;
            }
            
        }

        private void Safety_gauges_Load(object sender, EventArgs e)
        {

        }
    }
}
