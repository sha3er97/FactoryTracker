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
    public partial class Machines : Form
    {
        private Privileges _privilege;
        Controller controllerobj;
        public Machines(Privileges privilege, int ID)
        {
            InitializeComponent();
            _privilege = privilege;
            addMachine_btn.Enabled = false;
            delete_btn.Enabled = false;
            departement_cmbBox.Enabled = false;
            if (privilege == Privileges.Admin)
            {
                delete_btn.Enabled = true;
                addMachine_btn.Enabled = true;
            }
            if (privilege == Privileges.Manager)
            {
                departement_cmbBox.Enabled = true;

            }
            controllerobj = new Controller();
            DataTable dt = controllerobj.GetDeparments();
            departement_cmbBox.DataSource = dt;
            departement_cmbBox.DisplayMember = "name";
            departement_cmbBox.ValueMember = "id";
            type_cmbBox.Items.Add("Utility");
            type_cmbBox.Items.Add("Production");

        }

        private void addMachine_btn_Click(object sender, EventArgs e)
        {
            AddNewMachine f = new AddNewMachine();
            f.Show();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            DataTable dt;
            if (type_cmbBox.Text == "Utility")
            {
                dt = controllerobj.SelectUtilitiesMachinesDetails((int)departement_cmbBox.SelectedValue);
            }
            else
            {
                dt = controllerobj.SelectProductionMachinesDetails((int)departement_cmbBox.SelectedValue);
            }
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            int s;
            if (type_cmbBox.Text == "Utility")
            {
                s = controllerobj.DeleteUtilitiesMachinesDetails((int)departement_cmbBox.SelectedValue);
            }
            else
            {
                s = controllerobj.DeleteProductionMachinesDetails((int)departement_cmbBox.SelectedValue);
            }
            if (s > 0)
            {
                MessageBox.Show("successfully deleted");
            }
            else
            {
                MessageBox.Show("fail to delete");
            }
        }

        private void Machines_Load(object sender, EventArgs e)
        {

        }
    }
}
