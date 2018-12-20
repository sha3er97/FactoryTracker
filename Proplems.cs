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
    public partial class Proplems : Form
    {
        private Privileges _privilege;
        public Proplems(Privileges privilege, int ID)
        {
            InitializeComponent();
            _privilege = privilege;
            addProplem_btn.Enabled = false;
            departement_cmbBox.Enabled = false;
            if (privilege == Privileges.Admin)
            {
                addProplem_btn.Enabled = true;
            }
            if (privilege == Privileges.Manager)
            {
                departement_cmbBox.Enabled = true;
            }
        }
    }
}
