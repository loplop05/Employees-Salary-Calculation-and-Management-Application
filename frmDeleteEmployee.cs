using System;
using System.Windows.Forms;

namespace Employees_Salary_Calculation_and_Management_Application
{
    public partial class frmDeleteEmployee : Form
    {
        private ListView lvEmployees;

        // Constructor to receive the ListView
        public frmDeleteEmployee(ListView list)
        {
            InitializeComponent();
            lvEmployees = list;
        }

        private void frmDeleteEmployee_Load(object sender, EventArgs e)
        {
            textBoxIDforDelete.Focus();
        }

        // Delete method
        void DeleteEmployee()
        {
            string id = textBoxIDforDelete.Text.Trim();

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Enter ID first!",
                                "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            foreach (ListViewItem item in lvEmployees.Items)
            {
                if (item.Text == id)
                {
                    // Confirmation
                    DialogResult result = MessageBox.Show(
                        "Are you sure you want to delete this employee?",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        lvEmployees.Items.Remove(item);

                        MessageBox.Show("Employee deleted successfully!",
                                        "Done",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                        textBoxIDforDelete.Clear();
                    }

                    return;
                }
            }

            MessageBox.Show("Employee not found!",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

        private void textBoxIDforDelete_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchForDelete_Click(object sender, EventArgs e)
        {
            DeleteEmployee();
        }
    }
}
