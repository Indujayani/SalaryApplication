using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    public class ExternalEmployee : Employee
    {
        private float hourlyRate;

        public float employeeHourlyRate
        {
            get { return hourlyRate; }
            set { hourlyRate = value; }
        }

        public float CalcNetSalary(float hourlyRate, int noOfHours)
        {
            float netSalary=(hourlyRate*noOfHours);
            return netSalary;
        }
    }
}
