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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPosition.SelectedItem == null) return;

            string selected = cbPosition.SelectedItem.ToString().ToLower();

            switch (selected)
            {
                case "senior sales supervisor":
                    txtBoxBaseSalary.Text = "500";
                    textBoxDepartment.Text = "Operations";
                    break;

                case "junior sales supervisor":
                    txtBoxBaseSalary.Text = "400";
                    textBoxDepartment.Text = "Operations";
                    break;

                case "sales":
                case "customer service":
                case "Call Center":
                case "cashier":
                    txtBoxBaseSalary.Text = "300";
                    textBoxDepartment.Text = "Operations";
                    break;


                case "acountant":
                    txtBoxBaseSalary.Text = "600";
                    textBoxDepartment.Text = "HQ Office";
                    break;


                case "showroom manager":
                    txtBoxBaseSalary.Text = "1000";
                    textBoxDepartment.Text = "Operations";
                    break;


                default:
                    MessageBox.Show("Other position selected!");
                    break;
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
    }
}
