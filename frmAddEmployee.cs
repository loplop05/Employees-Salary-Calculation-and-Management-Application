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
            Dictionary<string, (string salary, string dept)> positions =
       new Dictionary<string, (string, string)>()
   {
    {"senior sales supervisor", ("500","Operations")},
    {"junior sales supervisor", ("400","Operations")},
    {"sales", ("300","Operations")},
    {"customer service", ("300","Operations")},
    {"call center", ("300","Operations")},
    {"cashier", ("300","Operations")},
    {"accountant", ("600","HQ Office")},
    {"showroom manager", ("1000","Operations")}
   };

            string selected = cbPosition.SelectedItem.ToString().Trim().ToLower();

            if (positions.ContainsKey(selected))
            {
                txtBoxBaseSalary.Text = positions[selected].salary;
                textBoxDepartment.Text = positions[selected].dept;
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
    }
}
