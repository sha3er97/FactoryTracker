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
    public partial class AddNewOperator : Form
    {
        int s;
        Controller controllerobj;
        DataTable dt;
        public AddNewOperator()
        {
            InitializeComponent();
            controllerobj = new Controller();
            dt = controllerobj.GetDeparments();
            departement_cmbBox.DataSource = dt;
            departement_cmbBox.DisplayMember = "name";
            departement_cmbBox.ValueMember = "id";
            s = controllerobj.getCategory((int)departement_cmbBox.SelectedValue);
            if (s == 1)
            {
                machines_checkedListBox.DataSource = controllerobj.SelectUtilitiesMachinesInDepartment((int)departement_cmbBox.SelectedValue);
                machines_checkedListBox.DisplayMember = "name";
                machines_checkedListBox.Refresh();
            }
            else if (s == 0)
            {
                machines_checkedListBox.DataSource = controllerobj.SelectProductionMachinesInDepartment((int)departement_cmbBox.SelectedValue);
                machines_checkedListBox.DisplayMember = "name";
                machines_checkedListBox.Refresh();
            }
            if (s == -1)
            {
                MessageBox.Show("no categories");
            }
        }

        private void AddNewOperator_Load(object sender, EventArgs e)
        {

        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void save_btn_Click_1(object sender, EventArgs e)
        {
            int o;
            if (dt != null)
            {
                int s = controllerobj.NewOperator(textBox2.Text, textBox1.Text, textBox3.Text, departement_cmbBox.Text, checkBox1.Checked ? (int)1 : 0);
                if (s > 0)
                //3ayez adeef wa7ed wa7ed
                {
                    int p = controllerobj.Getmaxidofadmin();
                    if (s == 1)
                    {
                        foreach (DataRowView dept in machines_checkedListBox.CheckedItems)
                            o = controllerobj.InsertOperates(p, (int)dept.Row["id"], 0);
                    }
                    else if (s == 0)
                    {
                        foreach (DataRowView dept in machines_checkedListBox.CheckedItems)
                            o = controllerobj.InsertOperates(p, 0, (int)dept.Row["id"]);
                    }
                }
                else
                {
                    MessageBox.Show("error in adding a new admin");
                }
            }
        }
    }
}