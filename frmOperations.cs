using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Employees_Salary_Calculation_and_Management_Application
{
    public partial class frmOperations : Form
    {
        private string _userName;
        public frmOperations(string userName)
        {
            InitializeComponent();
            _userName = userName;
        }

        private void lblWelcomeMessage_Click(object sender, EventArgs e)
        {


        }

        private void frmOperations_Load(object sender, EventArgs e)
        {
            lblWelcomeMessage.Text = "Welcome " + _userName;
        }




        // Log Out Button
        private void btnLogOut_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are You Sure For Logout ?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnEmployeeManagement_Click(object sender, EventArgs e)
        {
            Form EmployeesForm = new frmEmployeeManagement();
            EmployeesForm.ShowDialog();
        }

        private void btnSalaryCalculation_Click(object sender, EventArgs e)
        {

        }
    }
}
