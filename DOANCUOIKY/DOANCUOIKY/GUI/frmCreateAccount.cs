﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DOANCUOIKY.WCF;

namespace DOANCUOIKY.GUI
{
    public partial class frmCreateAccount : Form
    {
        public frmCreateAccount()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text == "")
            {
                MessageBox.Show("Please enter your User Name ");
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Please enter your Passwork");
            }
            else if (txtMssv.Text == "")
            {
                MessageBox.Show("Please enter your MSSV");
            }
            else if (txtHovaTen.Text == "")
            {
                MessageBox.Show("Please enter your Name");
            }
            else
            {
                Service1Client service = new Service1Client();

                CreateAccount c = new CreateAccount();
                c.UserName = txtUserName.Text;
                c.Password = txtPassword.Text;
                c.Mssv = Int32.Parse(txtMssv.Text);
                c.HovaTen = txtHovaTen.Text;
                string result = service.InsertCreateAccount(c);
                MessageBox.Show(result);
            }
        }
        
        //chi nhap so cho textbox
        private void txtMssv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }
    }
}
