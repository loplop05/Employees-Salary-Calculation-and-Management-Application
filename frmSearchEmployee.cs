using System;
using System.Windows.Forms;

namespace Employees_Salary_Calculation_and_Management_Application
{
    public partial class frmSearchEmployee : Form
    {
        private ListView lvEmployees;

        // Constructor to receive ListView from main form
        public frmSearchEmployee(ListView list)
        {
            InitializeComponent();
            lvEmployees = list;
            textBoxIDforSearch.Focus();
        }

        //Search Employee
        private void frmSearchEmployee_Load(object sender, EventArgs e)
        {
        }

        // Search method
        void SearchEmployee()
        {
            string id = textBoxIDforSearch.Text.Trim();

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Enter ID first!",
                                "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            bool found = false;

            foreach (ListViewItem item in lvEmployees.Items)
            {
                if (item.Text == id)
                {
                    // Highlight the employee in main ListView
                    item.Selected = true;
                    item.Focused = true;
                    item.EnsureVisible();

                    // Show employee data
                    string info =
                        "ID: " + item.Text +
                        "\nName: " + item.SubItems[1].Text +
                        "\nPosition: " + item.SubItems[2].Text +
                        "\nSalary: " + item.SubItems[3].Text +
                        "\nDepartment: " + item.SubItems[4].Text +
                        "\nHiring Date: " + item.SubItems[5].Text;

                    MessageBox.Show(info,
                                    "Employee Found",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    found = true;
                    break;
                }
            }

            if (!found)
            {
                MessageBox.Show("Employee not found!",
                                "Result",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchEmployee();
        }

        // Press Enter to search
        private void textBoxIDforSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SearchEmployee();
        }

        private void frmSearchEmployee_Shown(object sender, EventArgs e)
        {
            textBoxIDforSearch.Focus();
        }

        private void textBoxIDforSearch_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxIDforSearch_KeyDown_1(object sender, KeyEventArgs e)
        {
          
                if (e.KeyCode == Keys.Enter)
                {
                    btnSearch.Focus();
                    e.SuppressKeyPress = true;
                }
        }
    }
}
