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
            if (privilege == Privileges.Operators /* && is chief*/)
            {
                update_btn.Enabled = true;
            }
            type_cmbBox.DataSource = new string[] { "Fumes,CO2,Fire Alert" };
        }
        private void search_btn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controllerObj.GetGauges(Convert.ToInt32(departement_cmbBox.SelectedValue), type_cmbBox.SelectedValue.ToString());
        }
        private void delete_btn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow R in dataGridView1.Rows)
            {
                if (R.Selected)
                    controllerObj.DeleteGauge(Convert.ToInt32(departement_cmbBox.SelectedValue), Convert.ToInt32(R.Cells[1].Value));
            }
        }
        
        private void Safety_gauges_Load(object sender, EventArgs e)
        {

        }
    }
}
