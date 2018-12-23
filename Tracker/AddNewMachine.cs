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
    public partial class AddNewMachine : Form
    {

        DataTable dt;
        Controller controllerobj;
        public AddNewMachine()
        {
            InitializeComponent();
            controllerobj = new Controller();
            dt = controllerobj.GetDeparments();
            departement_cmbBox.DataSource = dt;
            departement_cmbBox.DisplayMember = "name";
            departement_cmbBox.ValueMember = "id";

            dt = controllerobj.GetALLCompaniesNames();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "id";

        }
        private void AddNewMachine_Load(object sender, EventArgs e)
        {

        }


        private void save_btn_Click(object sender, EventArgs e)
        {
            int r;
            if (radioButton1.Checked)
            {
                r = controllerobj.InsertNewProductionMachine((int)departement_cmbBox.SelectedValue, textBox1.Text, (int)monthsCounter.Value, (int)comboBox1.SelectedValue, catalog_linkBox.Text, solutionBox.Text);
            }
            else
            {
                r = controllerobj.InsertNewUtilityMachine((int)departement_cmbBox.SelectedValue, textBox1.Text, (int)monthsCounter.Value, (int)comboBox1.SelectedValue, catalog_linkBox.Text, solutionBox.Text);


            }
            if (r > 0)
            {
                MessageBox.Show("successfully inserted");
            }
            else
            {
                MessageBox.Show("filed to insert");
            }
        }
    }
}
