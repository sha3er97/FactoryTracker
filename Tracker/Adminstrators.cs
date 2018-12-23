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
    public partial class Adminstrators : Form
    {
        Controller controlobj;
        public Adminstrators()
        {
            InitializeComponent();
            controlobj = new Controller();
            DataTable dt = controlobj.GetAdministrators();
            departement_cmbBox.DataSource = dt;
            departement_cmbBox.DisplayMember = "name";
            departement_cmbBox.ValueMember = "id";

        }

        private void Adminstrators_Load(object sender, EventArgs e)
        {

        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            DataTable dt = controlobj.getAdminDetails(departement_cmbBox.Text);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void addAdmin_btn_Click(object sender, EventArgs e)
        {
            AddNewAdminstrators pp = new AddNewAdminstrators();
            pp.Show();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            int result = controlobj.DeleteAdmin(departement_cmbBox.Text);
            if (result > 0)
            {
                MessageBox.Show("Delete Succeeded");
            }
            else
                MessageBox.Show("Delete Failed");
        }
    }
}
