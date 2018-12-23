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
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (_privilege == Privileges.Operators)
                controllerObj.UpdateProfileOperator(textBox1.Text, textBox2.Text, textBox3.Text, _ID);
            else
                controllerObj.UpdateProfileAdmin(textBox1.Text, textBox2.Text, textBox3.Text, _ID);

        }

        private void profile_Load(object sender, EventArgs e)
        {
            if (_privilege == Privileges.Manager)
            {
                employee_name.Text = controllerObj.getNameAdminByID(_ID);
                textBox1.Text = controllerObj.getNameAdminByID(_ID);
                textBox2.Text = controllerObj.getpasswordAdminByID(_ID);
                textBox3.Text = controllerObj.getemailAdminByID(_ID);
                departement_label.Text = "-";
            }
            else if (_privilege == Privileges.Operators)
            {
                employee_name.Text = controllerObj.getNameOperatorByID(_ID);
                textBox1.Text = controllerObj.getuserNameOperatorByID(_ID);
                textBox2.Text = controllerObj.getpasswordOperatorByID(_ID);
                textBox3.Text = controllerObj.getemailOperatorByID(_ID);
                departement_label.Text = controllerObj.getDepOperatorByID(_ID);
            }
            else if (_privilege == Privileges.Admin)
            {
                employee_name.Text = controllerObj.getNameAdminByID(_ID);
                textBox1.Text = controllerObj.getNameAdminByID(_ID);
                textBox2.Text = controllerObj.getpasswordAdminByID(_ID);
                textBox3.Text = controllerObj.getemailAdminByID(_ID);
                departement_label.Text = controllerObj.getDepAdminByID(_ID);
            }
        }
    }
    
}
