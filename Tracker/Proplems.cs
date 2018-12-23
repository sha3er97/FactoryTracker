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

            departement_cmbBox.DataSource = controllerObj.GetDeparments();
            departement_cmbBox.DisplayMember = "name";
            departement_cmbBox.ValueMember = "id";

            category_cmbBox.Items.Add("Electric");
            category_cmbBox.Items.Add("Mechanical");
            category_cmbBox.Items.Add("Maintenance");
            int category = controllerObj.getCategory(Convert.ToInt32(departement_cmbBox.SelectedValue));
            //show machines based on department

        }

        private void addProplem_btn_Click(object sender, EventArgs e)
        {
            AddNewProplem f = new AddNewProplem(_privilege, _ID);
            f.Show();
        }

        private void departement_cmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (controllerObj.getCategory(Convert.ToInt32(departement_cmbBox.SelectedValue)) == 0)
            {
                machine_cmbBox.DataSource = controllerObj.SelectUtilitiesMachinesInDepartment(Convert.ToInt32(departement_cmbBox.SelectedValue));
                machine_cmbBox.DisplayMember = "name";
                machine_cmbBox.ValueMember = "id";
            }
            else if (controllerObj.getCategory(Convert.ToInt32(departement_cmbBox.SelectedValue)) == 1)
            {
                machine_cmbBox.DataSource = controllerObj.SelectProductionMachinesInDepartment(Convert.ToInt32(departement_cmbBox.SelectedValue));
                machine_cmbBox.DisplayMember = "name";
                machine_cmbBox.ValueMember = "id";
            }

        }
    }
}
