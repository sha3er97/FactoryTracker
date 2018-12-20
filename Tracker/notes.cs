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
    public partial class notes : Form
    {
        private Privileges _privilege;
        private int _ID;
        public notes(Privileges privilege, int ID)
        {
            InitializeComponent();
            _privilege = privilege;
            _ID = ID;
        }
    }
}
