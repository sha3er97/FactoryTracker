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
        private int u;
        private Privileges _privilege;
        private int _ID;
        private Controller controllerObj;
        public companies(Privileges privilege, int ID)
        {
            InitializeComponent();
            addCompany_btn.Enabled = false;
            delete_btn.Enabled = false;
            departement_cmbBox.Enabled = false;
            _privilege = privilege;
            _ID = ID;
            controllerObj = new Controller();
            if (privilege == Privileges.Manager || privilege == Privileges.Admin)
            {
                delete_btn.Enabled = true;
                addCompany_btn.Enabled = true;
            }
            if (privilege == Privileges.Manager)
            {
                departement_cmbBox.Enabled = true;
                DataTable dt = controllerObj.GetDeparments();
                departement_cmbBox.DataSource = dt;
                departement_cmbBox.DisplayMember = "name";
                departement_cmbBox.ValueMember = "id";


                DataTable dt1;
                if (radioButton1.Checked)
                {
                    u = 1;
                    dt1 = controllerObj.SelectUtilitiesMachinesInDepartment((int)departement_cmbBox.SelectedValue);
                }
                else
                {
                    u = 0;
                    dt1 = controllerObj.SelectProductionMachinesInDepartment((int)departement_cmbBox.SelectedValue);
                }

                machine_cmbBox.DataSource = dt1;
                machine_cmbBox.DisplayMember = "name";
                machine_cmbBox.ValueMember = "id";

            }
        }

        private void addCompany_btn_Click(object sender, EventArgs e)
        {
            AddNewCompany f = new AddNewCompany();
            f.Show();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            if (departement_cmbBox.Enabled == false)
            {

                DataTable dt;
                if (u == 1)
                {
                    dt = controllerObj.SelectUtilitiesMachinescompanies(controllerObj.getDepByAdminID(_ID));
                }
                else
                {
                    dt = controllerObj.SelectProductionMachinesIcompanies(controllerObj.getDepByAdminID(_ID));
                }
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            else
            {
                DataTable dt;
                if (u == 1)
                {
                    dt = controllerObj.SelectUtilitiesMachinescompanies((int)machine_cmbBox.SelectedValue);
                }
                else
                {
                    dt = controllerObj.SelectProductionMachinesIcompanies((int)machine_cmbBox.SelectedValue);
                }
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            int r;
            if (u == 1)
            {
                r = controllerObj.getidofutilitymachinecom((int)machine_cmbBox.SelectedValue);


            }
            else
            {
                r = controllerObj.getidofproductionmachinecom((int)machine_cmbBox.SelectedValue);

            }
            if (r == -1)
            {
                MessageBox.Show("error in machine's company");
            }
            else
            {
                int result = controllerObj.DeleteCompany(r);
                if (result > 0)
                {
                    MessageBox.Show("Delete Succeeded");
                }
                else
                    MessageBox.Show("Delete Failed");
            }
        }
    }
}
