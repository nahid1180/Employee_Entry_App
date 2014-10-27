using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryApp
{
    class Salary
    {
        public double Basic { set; get; }
        public double MedicalPercentage { set; get; }
        public double ConveyancePercentage { set; get; }
        public double NoOfIncrements { private set; get; }

        public void IncreaseIncrement(double percentOfBasic)
        {
            double amountToBeIncreased = (Basic*percentOfBasic)/100;
            Basic += amountToBeIncreased;
            NoOfIncrements++;
        }

        public double GetMedicalAmount()
        {
            return (Basic*MedicalPercentage)/100;
        }

        public double GetConveyanceAmount()
        {
            return (Basic*ConveyancePercentage)/100;
        }

        public double GetTotalAmount()
        {
            return Basic + GetMedicalAmount() + GetConveyanceAmount();
        }
    }
}
