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
    public partial class AddNewProplem : Form
    {
        private Controller controllerObj;
        private Privileges _privilege;
        private int _ID;
        public AddNewProplem(Privileges privilege, int ID)
        {
            InitializeComponent();
            controllerObj = new Controller();
            _privilege = privilege;
            _ID = ID;
            category_cmbBox.Items.Add("Electric");
            category_cmbBox.Items.Add("Mechanical");
            category_cmbBox.Items.Add("Maintainance");

            type_cmbBox.Items.Add("Utility");
            type_cmbBox.Items.Add("Production");
            
        }

        private void feedbackBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            int s;
            if (type_cmbBox.Text == "Utility"/*checkbox1.checked*/)
            {
                s = controllerObj.InsertNewUtilityProblem((int)machine_cmbBox.SelectedValue, category_cmbBox.Text, descriptionBox.Text, causeBox.Text, solutionBox.Text, _ID);
            }
            else
            {
                s = controllerObj.InsertNewProductionProblem((int)machine_cmbBox.SelectedValue, category_cmbBox.Text, descriptionBox.Text, causeBox.Text, solutionBox.Text, _ID);
            }
            if (s > 0)
            {
                MessageBox.Show("successfully inserted");
            }
            else
            {
                MessageBox.Show("failed to insert");
            }
        }
        
        private void AddNewProplem_Load(object sender, EventArgs e)
        {
            
        }

        private void type_cmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataTable dt;
            if (type_cmbBox.Text == "Utility" /*CheckBox1.checked*/)
            {
                dt = controllerObj.GetUtilitiesMachines();
            }
            else
            {
                dt = controllerObj.GetProductionMachines();
            }
            machine_cmbBox.DataSource = dt;
            machine_cmbBox.DisplayMember = "name";
            machine_cmbBox.ValueMember = "id";
        }
    }
}
