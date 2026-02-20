using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Employees_Salary_Calculation_and_Management_Application
{
    public partial class frmAnalytics : Form
    {
        private ListView lvEmployees;

        public frmEmployeeManagement _emp;

        public frmAnalytics(ListView list, frmEmployeeManagement emp)
        {
            InitializeComponent();
            lvEmployees = list;
            _emp = emp;
            _emp.LoadEmployees();
        }

        private void frmAnalytics_Load(object sender, EventArgs e)
        {
            CalculateAnalytics();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            CalculateAnalytics();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        void CalculateAnalytics()
        {
            if (lvEmployees.Items.Count == 0)
            {
                MessageBox.Show("No employees available!");
                return;
            }

            int totalEmployees = lvEmployees.Items.Count;

            double totalSalary = 0;
            double maxSalary = 0;
            double minSalary = double.MaxValue;

            string topEmployee = "";

            Dictionary<string, int> deptCount = new Dictionary<string, int>();
            Dictionary<string, double> deptSalary = new Dictionary<string, double>();

            Dictionary<string, int> positionCount = new Dictionary<string, int>();

            foreach (ListViewItem item in lvEmployees.Items)
            {
                double salary = Convert.ToDouble(item.SubItems[3].Text);
                string department = item.SubItems[4].Text;
                string position = item.SubItems[2].Text;
                string name = item.SubItems[1].Text;

                totalSalary += salary;

                // Highest and lowest
                if (salary > maxSalary)
                {
                    maxSalary = salary;
                    topEmployee = name;
                }

                if (salary < minSalary)
                    minSalary = salary;

                // Department stats
                if (!deptCount.ContainsKey(department))
                {
                    deptCount[department] = 0;
                    deptSalary[department] = 0;
                }

                deptCount[department]++;
                deptSalary[department] += salary;

                // Position stats
                if (!positionCount.ContainsKey(position))
                    positionCount[position] = 0;

                positionCount[position]++;
            }

            double averageSalary = totalSalary / totalEmployees;

            // 🔹 Update labels
            label1.Text = totalEmployees.ToString();
            label2.Text = totalSalary.ToString("0.00");
            label3.Text = averageSalary.ToString("0.00");
            label4.Text = maxSalary.ToString("0.00");
            label5.Text = minSalary.ToString("0.00");
          

            // 🔹 Department table
            lvDeptStats.Items.Clear();

            foreach (var dept in deptCount)
            {
                ListViewItem row = new ListViewItem(dept.Key);
                row.SubItems.Add(dept.Value.ToString());
                row.SubItems.Add(deptSalary[dept.Key].ToString("0.00"));

                lvDeptStats.Items.Add(row);
            }

            // 🔹 Position table
            lvPositionStats.Items.Clear();

            foreach (var pos in positionCount)
            {
                ListViewItem row = new ListViewItem(pos.Key);
                row.SubItems.Add(pos.Value.ToString());

                lvPositionStats.Items.Add(row);
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
