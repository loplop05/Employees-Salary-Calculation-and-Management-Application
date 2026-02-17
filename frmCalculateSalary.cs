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

        private void frmCalculateSalary_Load(object sender, EventArgs e)
        {
            txtEmpID.Focus();
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

        private void txtEmpID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.Focus();
                e.SuppressKeyPress = true;
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchForEmployee();
            txtOvertime.Focus();
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

        private void txtDeduction_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCalcuate.Focus();
                e.SuppressKeyPress = true;
            }
        }






        double CalculateOverTime()
        {
            double BaseSalary = Convert.ToDouble(textBoxBaseSalary.Text);
            double overtime = Convert.ToDouble(txtOvertime.Text);
            // Hourly rate: salary / month days / holidays (2 per week)
            double HourlyRate = (BaseSalary / 30) / 8;

            return (HourlyRate * overtime * 1.25);
        }

        double CalculateAbscnceDays()
        {
            double BaseSalary = Convert.ToDouble(textBoxBaseSalary.Text);
            double DailyRate = BaseSalary / 30;
            double Abscense = Convert.ToDouble(txtAbsence.Text);

            return (DailyRate * Abscense);
        }

        double CalculateBonus()
        {
            double BaseSalary = Convert.ToDouble(textBoxBaseSalary.Text);
            double percentage = Convert.ToDouble(txtBonus.Text) / 100;

            return BaseSalary * percentage;
        }

        double CalculateDeduction()
        {
            double BaseSalary = Convert.ToDouble(textBoxBaseSalary.Text);

            double fixedDeduction = 0;
            double percentDeduction = 0;

            if (!string.IsNullOrWhiteSpace(txtDeduction.Text))
                fixedDeduction = Convert.ToDouble(txtDeduction.Text);

            if (!string.IsNullOrWhiteSpace(txtDeduction.Text))
                percentDeduction = Convert.ToDouble(txtDeduction.Text) / 100;

            double percentAmount = BaseSalary * percentDeduction;

            return fixedDeduction + percentAmount;
        }

        double CalculateNetSalary()
        {
            double baseSalary = Convert.ToDouble(textBoxBaseSalary.Text);

            double overtime = CalculateOverTime();
            double bonus = CalculateBonus();
            double absence = CalculateAbscnceDays();
            double deduction = CalculateDeduction();

            return Math.Round(baseSalary + overtime + bonus - absence - deduction);
        }






        private void btnCalcuate_Click(object sender, EventArgs e)
        {
            double Salary = CalculateNetSalary();
            lblNetSalary.Text = Convert.ToString(Salary) + "JOD";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }




        void ShowRecipt(System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            Font titleFont = new Font("Arial", 16, FontStyle.Bold);
            Font normalFont = new Font("Arial", 11);
            Font boldFont = new Font("Arial", 11, FontStyle.Bold);

            int startX = 50;
            int startY = 50;
            int offset = 30;

            // ===== Header =====
            g.DrawString("Amman Mega Stores", titleFont, Brushes.Black, startX, startY);
            startY += offset;
            g.DrawString("Salary Payment Receipt", boldFont, Brushes.Black, startX, startY);
            startY += offset * 2;

            // ===== Employee Info =====
            g.DrawString("Employee ID: " + txtEmpID.Text, normalFont, Brushes.Black, startX, startY);
            startY += offset;
            g.DrawString("Employee Name: " + textBoxFullName.Text, normalFont, Brushes.Black, startX, startY);
            startY += offset;
            g.DrawString("Department: " + txtBoxDepartment.Text, normalFont, Brushes.Black, startX, startY);
            startY += offset;
            g.DrawString("Position: " + textBoxPosition.Text, normalFont, Brushes.Black, startX, startY);
            startY += offset * 2;

            // ===== Earnings =====
            g.DrawString("EARNINGS", boldFont, Brushes.Black, startX, startY);
            startY += offset;

            double baseSalary = Convert.ToDouble(textBoxBaseSalary.Text);
            double overtime = CalculateOverTime();
            double bonus = CalculateBonus();
            double totalEarnings = baseSalary + overtime + bonus;

            g.DrawString("Base Salary: " + baseSalary.ToString("F2"), normalFont, Brushes.Black, startX, startY);
            startY += offset;
            g.DrawString("Overtime: " + overtime.ToString("F2"), normalFont, Brushes.Black, startX, startY);
            startY += offset;
            g.DrawString("Bonus: " + bonus.ToString("F2"), normalFont, Brushes.Black, startX, startY);
            startY += offset;
            g.DrawString("Total Earnings: " + totalEarnings.ToString("F2"), boldFont, Brushes.Black, startX, startY);
            startY += offset * 2;

            // ===== Deductions =====
            g.DrawString("DEDUCTIONS", boldFont, Brushes.Black, startX, startY);
            startY += offset;

            double absence = CalculateAbscnceDays();
            double deduction = CalculateDeduction();
            double totalDeductions = absence + deduction;

            g.DrawString("Absence: " + absence.ToString("F2"), normalFont, Brushes.Black, startX, startY);
            startY += offset;
            g.DrawString("Other Deductions: " + deduction.ToString("F2"), normalFont, Brushes.Black, startX, startY);
            startY += offset;
            g.DrawString("Total Deductions: " + totalDeductions.ToString("F2"), boldFont, Brushes.Black, startX, startY);
            startY += offset * 2;

            // ===== Net Salary =====
            double netSalary = totalEarnings - totalDeductions;

            g.DrawString("NET SALARY: " + netSalary.ToString("F2") + " JOD", titleFont, Brushes.Black, startX, startY);
            startY += offset * 2;

            // Footer
            g.DrawString("Signature: ____________________", normalFont, Brushes.Black, startX, startY);
            startY += offset;
            g.DrawString("Date: " + DateTime.Now.ToShortDateString(), normalFont, Brushes.Black, startX, startY);
        }

        private void printDocumentSalary_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            ShowRecipt(e);
        }

        private void btnSalaryRecipt_Click(object sender, EventArgs e)
        {
            printPreviewDialogSalary.Document = printDocumentSalary;
            printPreviewDialogSalary.ShowDialog();
        }

    }
}
