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
    public partial class profile : Form
    {
        private Privileges _privilege;
        private int _ID;
        private Controller controllerObj;
        public profile(Privileges privilege, int ID)
        {
            InitializeComponent();
            controllerObj = new Controller();
            _privilege = privilege;
            _ID = ID;
            if (_privilege == Privileges.Manager)
                departement_label.Text = "-";
            else if (_privilege == Privileges.Operators)
                employee_name.Text = controllerObj.getNameOperatorByID(ID);
            else if (_privilege == Privileges.Admin)
                employee_name.Text = controllerObj.getNameAdminByID(ID);

        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (_privilege == Privileges.Operators)
                controllerObj.UpdateProfileOperator(textBox1.Text, textBox2.Text, textBox3.Text, _ID);
            else
                controllerObj.UpdateProfileAdmin(textBox1.Text, textBox2.Text, textBox3.Text, _ID);

        }
    }
}
