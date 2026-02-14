using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Employees_Salary_Calculation_and_Management_Application
{
    public partial class frmEmployeeManagement : Form
    {
        public frmEmployeeManagement()
        {
            InitializeComponent();

        }

        private void frmEmployeeManagement_Load(object sender, EventArgs e)
        {

        }
        private void FillListView()
        {
            for (int i = 0; i < lvEmployees.Items.Count; i++)
            {
                if (i % 2 == 0)
                    lvEmployees.Items[i].BackColor = Color.White;
                else
                    lvEmployees.Items[i].BackColor = Color.LightGray;
            }

        }








        bool IsIDExist(string id)
        {
            foreach (ListViewItem item in lvEmployees.Items)
            {
                if (item.Text == id)   // Text = first column (ID)
                    return true;
            }
            return false;
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            frmAddEmployee addForm = new frmAddEmployee();

            if (addForm.ShowDialog() == DialogResult.OK)
            {
                if (IsIDExist(addForm.textBoxID.Text.Trim()))
                {
                    MessageBox.Show("ID ALREADY EXISITS", "Error");
                    return;
                }

                ListViewItem item = new ListViewItem(addForm.textBoxID.Text);
                item.SubItems.Add(addForm.textBoxName.Text);
                item.SubItems.Add(addForm.cbPosition.Text);
                item.SubItems.Add(addForm.txtBoxBaseSalary.Text);
                item.SubItems.Add(addForm.textBoxDepartment.Text);
                item.SubItems.Add(DateTime.Now.ToShortDateString());

                lvEmployees.Items.Add(item);

                FillListView();
            }
        }





        private void FillRandomEmployees(int count)
        {
            string[] names = { "John", "Jane", "Ali", "Sara", "Mike", "Lina" };
            string[] positions = { "Cashier", "Sales", "Call Center", "Accountant", "Showroom Manager" };
            string[] departments = { "Operations", "HQ Office", "Floor" };
            Random rnd = new Random();

            for (int i = 0; i < count; i++)
            {
                ListViewItem item = new ListViewItem((100 + i).ToString()); // Random ID
                item.SubItems.Add(names[rnd.Next(names.Length)]);
                string pos = positions[rnd.Next(positions.Length)];
                item.SubItems.Add(pos);

                // Set base salary and department according to position
                string salary = "300";
                string dept = "Operations";
                switch (pos.ToLower())
                {
                    case "cashier":
                    case "call center":
                    case "sales":
                        salary = "300"; dept = "Operations"; break;
                    case "accountant":
                        salary = "600"; dept = "HQ Office"; break;
                    case "showroom manager":
                        salary = "1000"; dept = "Operations"; break;
                }
                item.SubItems.Add(salary);
                item.SubItems.Add(dept);
                item.SubItems.Add(DateTime.Now.AddDays(-rnd.Next(1000)).ToShortDateString()); // Random hiring date

                lvEmployees.Items.Add(item);
            }

            FillListView(); // Optional: apply alternating row colors
        }

        private void fillEmps_Click(object sender, EventArgs e)
        {
            FillRandomEmployees(10);
        }

        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmDeleteEmployee(lvEmployees);
            frm1.ShowDialog();

        }

        private void btnSearchEmployee_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmSearchEmployee(lvEmployees);
            frm1.ShowDialog();


        }

    }
}

