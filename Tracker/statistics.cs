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
    public partial class statistics : Form
    {
        private Controller controllerObj;
        public statistics()
        {
            InitializeComponent();
            controllerObj = new Controller();
            adminsNO.Text=(controllerObj.numberofAdministrators()-1).ToString();
            OpsNo.Text = controllerObj.numberofoperators().ToString();
        }
    }
}
