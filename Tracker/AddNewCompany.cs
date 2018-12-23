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
    public partial class AddNewCompany : Form
    {
        Controller controllerobj;
        public AddNewCompany()
        {
            InitializeComponent();
            controllerobj = new Controller();


        }



        private void save_btn_Click(object sender, EventArgs e)
        {
            int y = controllerobj.InsertCompany(textBox1.Text, textBox3.Text, textBox2.Text, textBox4.Text, textBox5.Text, Convert.ToInt32(textBox6.Text));
            if (y > 0)
                MessageBox.Show("inserting finished");
            else
                MessageBox.Show("inserting error");
        }
    }
}
