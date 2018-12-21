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
    public partial class Operators : Form
    {
        private Privileges _privilege;
        public Operators(Privileges privilege, int ID)
        {
            InitializeComponent();
            _privilege = privilege;
            addOP_btn.Enabled = false;
            departement_cmbBox.Enabled = false;
            if (privilege == Privileges.Manager)
            {
                addOP_btn.Enabled = true;
                departement_cmbBox.Enabled = true;
            }
        }
    }
}
