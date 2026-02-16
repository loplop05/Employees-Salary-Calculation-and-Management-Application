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

                    return;
                }
            }

            MessageBox.Show("Employee not found!");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchForEmployee();
        }
    }
}
