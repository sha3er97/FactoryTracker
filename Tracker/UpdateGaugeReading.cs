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
    public partial class UpdateGaugeReading : Form
    {
        private Controller controllerObj;
        private int dep;
        public UpdateGaugeReading(Privileges privilege, int ID)
        {
            InitializeComponent();
            controllerObj = new Controller();
            dep = controllerObj.getDepByID(ID);
            type_cmbBox.DataSource = controllerObj.GetGaugesByID(ID);
        }
        private void update_btn_Click(object sender, EventArgs e)
        {
            int result = controllerObj.UpdateGauge(Convert.ToInt32(numericUpDown1.Value), dep, Convert.ToInt32(type_cmbBox.SelectedValue));
            if (result > 0)
            {
                MessageBox.Show("Successfully Updated");
            }
            else
                MessageBox.Show("Failed!! Try Again");
        }

    }
}
