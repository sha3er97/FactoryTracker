﻿using System;
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
    public partial class AddNewStop_Go : Form
    {
        Controller controlobj;
        private Privileges _privilege;
        private int _ID;
        public AddNewStop_Go(Privileges privilege, int ID)
        {
            InitializeComponent();
            _privilege = privilege;
            _ID = ID;
            controlobj = new Controller();
            DataTable dt = controlobj.GetAdministrators();
            toAdmin_cmbBox.DataSource = dt;
            toAdmin_cmbBox.DisplayMember = "name";
            toAdmin_cmbBox.ValueMember = "id";
        }

        private void send_btn_Click(object sender, EventArgs e)
        {
            int x = 1;
            if (radioButton1.Checked)
            {
                x = 0;
            }
            int s = controlobj.InsertNewstopandgo(x, causeBox.Text, solutionBox.Text, _ID);
            if (s > 0)
            {
                MessageBox.Show("suucessfully inserted");
            }
            else
            {
                MessageBox.Show("failed to be inserted");
            }
        }

        private void AddNewStop_Go_Load(object sender, EventArgs e)
        {

        }
    }
}
