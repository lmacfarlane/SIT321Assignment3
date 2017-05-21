﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SARMS
{
    public partial class LecturerForm : Form
    {
        private Lecturer login;

        public LecturerForm(User Loggedin)
        {
            login = (Lecturer)Loggedin;
            InitializeComponent();
        }

        private void LecturerForm_Load(object sender, EventArgs e)
        {
            lstUnits.SelectedIndex = lstUnits.Items.IndexOf(0);
            foreach (Unit i in login.AllocatedUnits) {
                lstUnits.Items.Add(i.UnitID);
            }
        }

        private void lstUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
            lststuinuni.Items.Clear();
            foreach (Student stu in DB.ToUnit(lstUnits.SelectedItem.ToString()).StudentList) {
                lststuinuni.Items.Add(stu.Username);
            }
        }
    }
}
