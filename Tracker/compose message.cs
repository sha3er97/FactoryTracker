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
    public partial class compose_message : Form
    {
        int to;
        private Privileges _privilege;
        Controller ControllerObj;
        private int _ID;
        public compose_message(Privileges privilege, int ID)
        {
            InitializeComponent();
            _privilege = privilege;
            _ID = ID;
            to = 0;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                departement_cmbBox.Enabled = false;
                TO_cmbBox.Enabled = false;
            }
            else
            {
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                departement_cmbBox.Enabled = true;
                TO_cmbBox.Enabled = true;
                departement_cmbBox.DataSource = ControllerObj.GetDeparments();
                departement_cmbBox.DisplayMember = "name";
                departement_cmbBox.ValueMember = "id";

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                TO_cmbBox.DataSource = ControllerObj.getnamesoperators(Convert.ToInt32(departement_cmbBox.SelectedValue));
                TO_cmbBox.DisplayMember = "name";
                TO_cmbBox.ValueMember = "id";
            }
            else if (radioButton2.Checked)
            {
                TO_cmbBox.Text = ControllerObj.getnameAdminOfDep(Convert.ToInt32(departement_cmbBox.SelectedValue));
                to = ControllerObj.getIDAdminBydep(Convert.ToInt32(departement_cmbBox.SelectedValue));

            }
        }

        private void send_btn_Click(object sender, EventArgs e)
        {

            if (radioButton2.Checked)
            {
                if (_privilege == Privileges.Operators)
                    ControllerObj.InsertNotefromOperatorToOperator(messageBox.Text, _ID, Convert.ToInt32(TO_cmbBox.SelectedValue));
                else
                    ControllerObj.InsertNotefromAdminToOperator(messageBox.Text, _ID, Convert.ToInt32(TO_cmbBox.SelectedValue));

            }
            else if (radioButton1.Checked)
                if (_privilege == Privileges.Operators)
                    ControllerObj.InsertNotefromOperatorToAdmin(messageBox.Text, _ID, to);
                 else 
                    ControllerObj.InsertNotefromAdminToAdmin(messageBox.Text, _ID, to);


        }

        private void compose_message_Load(object sender, EventArgs e)
        {

        }
    }
}