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
    public partial class AddNewGauge : Form
    {
        DataTable dt;
        Controller controllerobj;
        public AddNewGauge()
        {
            InitializeComponent();
            controllerobj = new Controller();
            dt = controllerobj.GetDeparments();
            departement_cmbBox.DataSource = dt;
            departement_cmbBox.DisplayMember = "name";
            departement_cmbBox.ValueMember = "id";

            type_cmbBox.Items.Add("Co2");
            type_cmbBox.Items.Add("Fumes ");
            type_cmbBox.Items.Add("Fire Alert");

        }

        private void AddNewGauge_Load(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void save_btn_Click_1(object sender, EventArgs e)
        {
            int indic = 1;
            int r = 0;
            try
            {
                r = controllerobj.Getmaxnofromsafetygauges((int)departement_cmbBox.SelectedValue);
            }
            catch (Exception)
            {
                MessageBox.Show("no department added yet yet");
                indic = 0;
            }
            if (indic == 1)
            {
                if (r == 0)
                {
                    r = 1;
                }
                else
                {
                    r++;
                }
                int s = controllerobj.InsertNewGauge((int)departement_cmbBox.SelectedValue, r, (int)numericUpDown1.Value, type_cmbBox.Text);
                if (s > 0)
                {
                    MessageBox.Show("successfully inserted");
                }
                else
                {
                    MessageBox.Show("sorry, there's a failure");
                }
            }
        }
    }
}
