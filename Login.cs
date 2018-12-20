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
    public enum Privileges
    {
        Manager =0,
        Admin = 1,
        Operators = 2
    }

    public partial class Login : Form
    {
        private bool _loggedin = false;
        private Controller controllerObj; // A Reference of type Controller 
                                          // (Initially NULL; NO Controller Object is created yet)

        public Login()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            int privlg = controllerObj.CheckPassword_Basic(TxtBx_username.Text, TxtBx_pass.Text);
            int id = 0;
            if (privlg >= 0) // Successful Login
            {
                _loggedin = true;

                // Create an Object of "Provided_Functionalities" Form and Show it
                if (privlg == 0)
                {
                    operator_main func; func = new operator_main((Privileges)privlg, id);
                    func.Show(this);
                }
                else if (privlg == 2)
                {
                    manager_main func = new manager_main();
                    func.Show(this);
                }
                else if (privlg == 1)
                {
                    admin_main func = new admin_main((Privileges)privlg, id);
                    func.Show(this);
                }
            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }
                TxtBx_pass.Clear();
                TxtBx_username.Clear();
                // Hide the Login Form 
                // Don't close it because it's the startup form and the application will exit
                this.Hide();
            }
            
        }
    }

