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
    public partial class Stop_and_Go : Form
    {
        private Privileges _privilege;
        private int _ID;
        private Controller controllerObj;
        public Stop_and_Go(Privileges privilege, int ID)
        {
            InitializeComponent();
            controllerObj = new Controller();
            _privilege = privilege;
            _ID = ID;
            //Stop has category 0     Go 1
        }
        
        private void viewSent_btn_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                dataGridView1.DataSource = controllerObj.GetCardsSent(_ID, 0);
            else if (radioButton2.Checked)
                dataGridView1.DataSource = controllerObj.GetCardsSent(_ID, 1);
        }

        private void viewRecieved_btn_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                dataGridView1.DataSource = controllerObj.GetCardsReceived(_ID, 0);
            else if (radioButton2.Checked)
                dataGridView1.DataSource = controllerObj.GetCardsReceived(_ID, 1);
        }
    }
}

    

