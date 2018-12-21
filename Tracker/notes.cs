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
        private Controller controllerObj;
        public notes(Privileges privilege, int ID)
        {
            InitializeComponent();
            controllerObj = new Controller();
            _privilege = privilege;
            _ID = ID;
        }

        private void viewSent_btn_Click(object sender, EventArgs e)
        {
            if (_privilege == Privileges.Operators)
                dataGridView1.DataSource = controllerObj.GetNotesSentOperaor(_ID);
            else
                dataGridView1.DataSource = controllerObj.GetNotesSentAdmin(_ID);
            dataGridView1.Columns.Add("Is_Received", "Is_Received");
            dataGridView1.Columns.Add("From", "From");

            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Cells["Is_Received"].Value = controllerObj.getisreceived(Convert.ToInt32(r.Cells["id"].Value));
                r.Cells["From"].Value = controllerObj.getFrom(Convert.ToInt32(r.Cells["id"]));
            }

        }

        private void viewRecieved_btn_Click(object sender, EventArgs e)
        {
            if (_privilege == Privileges.Operators)
                controllerObj.GetNotesReceivedOperator(_ID);
            else
                controllerObj.GetNotesReceivedAdmin(_ID);

        }

        private void compose_btn_Click(object sender, EventArgs e)
        {
            compose_message f = new compose_message(_privilege, _ID);
            f.Show();
        }
    }
}
