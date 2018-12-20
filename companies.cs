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
    public partial class companies : Form
    {
        private Privileges _privilege;
        public companies(Privileges privilege,int ID)
        {
            InitializeComponent();
            addCompany_btn.Enabled = false;
            delete_btn.Enabled = false;
            departement_cmbBox.Enabled = false;
            _privilege = privilege;
            if (privilege == Privileges.Manager || privilege == Privileges.Admin)
            {
                delete_btn.Enabled = true;
                addCompany_btn.Enabled = true;
            }
            if (privilege == Privileges.Manager)
            {
                departement_cmbBox.Enabled = true;

            }


        }
    }
}
