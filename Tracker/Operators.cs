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
    public partial class Operators : Form
    {
        private Controller controllerObj;
        private Privileges _privilege;
        private int _ID;
        public Operators(Privileges privilege, int ID)
        {
            InitializeComponent();
            controllerObj = new Controller();
            _privilege = privilege;
            _ID = ID;
            addOP_btn.Enabled = false;
            departement_cmbBox.Enabled = false;
            if (privilege == Privileges.Manager)
            {
                addOP_btn.Enabled = true;
                departement_cmbBox.Enabled = true;
            }
            departement_cmbBox.DataSource = controllerObj.GetDeparments();
            departement_cmbBox.DisplayMember = "name";
            departement_cmbBox.ValueMember = "id";

        }
        private void departement_cmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.DataSource = controllerObj.GetNamesOfOperators(Convert.ToInt32(departement_cmbBox.SelectedValue));
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "id";
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            controllerObj.getDetailsOperatorByID(Convert.ToInt32(comboBox1.SelectedValue));
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow R in dataGridView1.Rows)
            {
                if (R.Selected)
                    controllerObj.DeleteOperator(Convert.ToInt32(comboBox1.SelectedValue));
            }

        }

        private void addOP_btn_Click(object sender, EventArgs e)
        {
            AddNewOperator f = new AddNewOperator();
            f.Show();
        }
    }
    }
