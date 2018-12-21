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
    public partial class Adminstrators : Form
    {
        public Adminstrators()
        {
            InitializeComponent();
        }

        private void addAdmin_btn_Click(object sender, EventArgs e)
        {
            AddNewAdminstrators f = new AddNewAdminstrators();
            f.Show();
        }
    }
}
