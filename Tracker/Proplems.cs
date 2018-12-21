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
        private Controller controllerObj;
        private Privileges _privilege;
        private int _ID;
        public Proplems(Privileges privilege, int ID)
        {
            InitializeComponent();
            controllerObj = new Controller();
            _privilege = privilege;
            _ID = ID;
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
        private void Proplems_Load(object sender, EventArgs e)
        {
            
            //Show Departments
            category_cmbBox.DataSource = "Electric,Mechanical,Maintenance";
            int category = controllerObj.getCategory(Convert.ToInt32(departement_cmbBox.SelectedValue));
            //show machines based on department//show machines based on department

        }

    }
}
