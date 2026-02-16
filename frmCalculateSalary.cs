using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Employees_Salary_Calculation_and_Management_Application
{
    public partial class frmCalculateSalary : Form
    {
        public frmEmployeeManagement _emp;

        public frmCalculateSalary(frmEmployeeManagement emp)
        {
            InitializeComponent();
            _emp = emp;
            _emp.LoadEmployees();
        }



        void SearchForEmployee()
        {
            string id = txtEmpID.Text.Trim();

            foreach (ListViewItem item in _emp.lvEmployees.Items)
            {
                if (item.Text == id)
                {
                    textBoxFullName.Text = item.SubItems[1].Text;
                    textBoxPosition.Text = item.SubItems[2].Text;
                    textBoxBaseSalary.Text = item.SubItems[3].Text;
                    txtBoxDepartment.Text = item.SubItems[4].Text;
                    BoxEmployeeInfoBox.Enabled = false;
                    return;
                }
            }

            MessageBox.Show("Employee not found!");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchForEmployee();
            txtOvertime.Focus();
        }


        private void frmCalculateSalary_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAbsence.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtAbsence_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBonus.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtBonus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDeduction.Focus();
                e.SuppressKeyPress = true;
            }
        }







    }
}
