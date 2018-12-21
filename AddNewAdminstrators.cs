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
    public partial class AddNewAdminstrators : Form
    {
        DataTable dt;
        Controller controllerobj;
        public AddNewAdminstrators()
        {
            InitializeComponent();
            controllerobj = new Controller();
            dt = controllerobj.GetDeparments();
            departement_cmbBox.DataSource = dt;
            departement_cmbBox.DisplayMember = "name";
            departement_cmbBox.ValueMember = "id";

        }

        private void AddNewAdminstrators_Load(object sender, EventArgs e)
        {

        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (dt != null)
            {
                int s = controllerobj.NewAdministrator(textBox2.Text, textBox1.Text, textBox3.Text);
                if (s > 0)
                {
                    int p = controllerobj.Getmaxidofadmin();
                    p++;
                    int q = controllerobj.updatedepadmin(p, departement_cmbBox.Text);
                    if (q > 0)
                    {
                        MessageBox.Show("successfully added the admin");
                    }
                    else
                    {
                        MessageBox.Show("error in updating the department admin");
                    }

                }
                else
                {
                    MessageBox.Show("error in adding a new admin");
                }
            }
            else
            {
                MessageBox.Show("please insert a department first");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
