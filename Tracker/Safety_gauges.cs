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
        private Controller controllerObj;
        private Privileges _privilege;
        private int _ID;
        public Safety_gauges(Privileges privilege, int ID)
        {
            InitializeComponent();
            controllerObj = new Controller();
            _privilege = privilege;
            _ID = ID;
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
            if (privilege == Privileges.Operators)
            {
                update_btn.Enabled = true;
            }
            type_cmbBox.Items.Add("Co2");
            type_cmbBox.Items.Add("Fumes ");
            type_cmbBox.Items.Add("Fire Alert");
        }
        
        
        
        
        private void Safety_gauges_Load(object sender, EventArgs e)
        {

        }

        private void addGauge_btn_Click(object sender, EventArgs e)
        {
            AddNewGauge f = new AddNewGauge(_privilege,_ID);
            f.Show();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            UpdateGaugeReading f = new UpdateGaugeReading(_privilege, _ID);
            f.Show();
        }

        private void search_btn_Click_1(object sender, EventArgs e)
        {
            int ind=1;
            if(departement_cmbBox.Enabled==false)
            {
                try
                {
                    dataGridView1.DataSource = controllerObj.GetGauges(controllerObj.getDepByAdminID(_ID), type_cmbBox.SelectedValue.ToString());
                }
                catch (Exception)
                {
                    MessageBox.Show("no thing found at this part in database");
                    ind = 0;
                }
            }
            else
            {
                dataGridView1.DataSource = controllerObj.GetGauges(Convert.ToInt32(departement_cmbBox.SelectedValue), type_cmbBox.SelectedValue.ToString());
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow R in dataGridView1.Rows)
                {
                    if (R.Selected)
                        controllerObj.DeleteGauge(Convert.ToInt32(departement_cmbBox.SelectedValue), Convert.ToInt32(R.Cells[1].Value));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("nothing in database to be deleted");
            }
        }
    }
}
