using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalaryApp
{
    public partial class SalaryUI : Form
    {
        private Employee anEmployee;

        public SalaryUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            anEmployee = new Employee(idTextBox.Text,nameTextBox.Text,emailTextBox.Text);
            Salary aSalary = new Salary();
            aSalary.Basic = Convert.ToDouble(basicTextBox.Text);
            aSalary.MedicalPercentage = Convert.ToDouble(medicalPercentageTextBox.Text);
            aSalary.ConveyancePercentage = Convert.ToDouble(conveyancePercentageTextBox.Text);

            anEmployee.EmployeeSalary = aSalary;
            MessageBox.Show("Employee info saved");
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            noOfIncrementsTextBox.Text = anEmployee.EmployeeSalary.NoOfIncrements.ToString();
            basicShowTextBox.Text = anEmployee.EmployeeSalary.Basic.ToString();
            medicalAmountTextBox.Text = anEmployee.EmployeeSalary.GetMedicalAmount().ToString();
            conveyanceAmountTextBox.Text = anEmployee.EmployeeSalary.GetConveyanceAmount().ToString();

            totalTextBox.Text = anEmployee.EmployeeSalary.GetTotalAmount().ToString();
        }

        private void incrementButton_Click(object sender, EventArgs e)
        {
            double percentage = Convert.ToDouble(incrementPercentageTextBox.Text);
            anEmployee.EmployeeSalary.IncreaseIncrement(percentage);
        }
    }
}
