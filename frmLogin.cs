using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Employees_Salary_Calculation_and_Management_Application
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.AcceptButton = LoginBtn;
        }






        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtbxUserName.Text) || string.IsNullOrEmpty(txtbxPassWord.Text)))
            {

                MessageBox.Show("User Name Or Password should be Entered", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (txtbxUserName.Text == txtbxUserName.Tag.ToString() && txtbxPassWord.Text == txtbxPassWord.Tag.ToString())
            {
                Form frm1 = new frmOperations();
                frm1.ShowDialog();
            }
            else
            {
                errorProvider1.SetError(txtbxUserName, "Invalid User Name");
                errorProvider1.SetError(txtbxPassWord, "Invalid Password");
            }



        }




























    }
}
