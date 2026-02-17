using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Employees_Salary_Calculation_and_Management_Application
{
    public partial class frmAddEmployee : Form
    {
        public frmAddEmployee()
        {
            InitializeComponent();
        }

        private void frmAddEmployee_Load(object sender, EventArgs e)
        {
            textBoxID.Focus();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPosition.SelectedItem == null) return;

            string position = cbPosition.SelectedItem.ToString().Trim().ToLower();

            if (position == "senior sales supervisor")
            {
                txtBoxBaseSalary.Text = "500";
                textBoxDepartment.Text = "Operations";
            }
            else if (position == "junior sales supervisor")
            {
                txtBoxBaseSalary.Text = "400";
                textBoxDepartment.Text = "Operations";
            }
            else if (position == "sales" || position == "customer service"
                     || position == "call center" || position == "cashier")
            {
                txtBoxBaseSalary.Text = "300";
                textBoxDepartment.Text = "Operations";
            }
            else if (position == "accountant")
            {
                txtBoxBaseSalary.Text = "600";
                textBoxDepartment.Text = "HQ Office";
            }
            else if (position == "showroom manager")
            {
                txtBoxBaseSalary.Text = "1000";
                textBoxDepartment.Text = "Operations";
            }
            else
            {
                MessageBox.Show("Other position selected!");
            }
        }


        private void btnSaveEmployeeInfo_Click(object sender, EventArgs e)
        {
            // validate inputs
            if (string.IsNullOrEmpty(textBoxID.Text) || string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("ID and Name are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            this.DialogResult = DialogResult.OK; // signals parent
            this.Close(); // close AddEmployee form
        }




        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxName.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void textBoxName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbPosition.Focus();
                e.SuppressKeyPress = true;
            }
        }

    }
}
