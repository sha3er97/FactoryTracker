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
    public partial class Departements : Form
    {
        private Controller controllerObj;
        public Departements()
        {
            InitializeComponent();
            controllerObj = new Controller();
      
        }

        private void addDept_btn_Click(object sender, EventArgs e)
        {
            AddNewDepartement f = new AddNewDepartement();
            f.Show();
        }

        private void Departements_Load(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetDeparments();
            departement_cmbBox.DataSource = dt;
            departement_cmbBox.DisplayMember = "name";
            departement_cmbBox.ValueMember = "id";
            DataTable dt1 = controllerObj.getdepdetails((int)departement_cmbBox.SelectedValue);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
    }
}
