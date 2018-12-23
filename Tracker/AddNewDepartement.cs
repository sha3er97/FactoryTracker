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
    public partial class AddNewDepartement : Form
    {
        Controller controllobj;
        public AddNewDepartement()
        {
            InitializeComponent();
            controllobj = new Controller();
            category_cmbBox.Items.Add("utility");
            category_cmbBox.Items.Add("production");
        }

        private void AddNewDepartement_Load(object sender, EventArgs e)
        {

        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            int y;
            if (category_cmbBox.Text == "utility")
                y = 1;
            else
                y = 0;
            int u = controllobj.Getmaxidofadmin();
            int s = controllobj.NewDepartment(textBox1.Text, y, (int)buildingNo_numeric.Value, (int)partitionNo_numeric.Value, u);
            if (s > 0)
                MessageBox.Show("successfully added");
            else
            {
                MessageBox.Show("failed");
            }
        }
    }
}
