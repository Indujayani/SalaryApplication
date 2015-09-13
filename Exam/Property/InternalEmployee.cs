using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    public class InternalEmployee:Employee
    {
        private float basicSalary ;
        private float otHourlyRate;

        public float employeeBasicSalary
        {
            get { return basicSalary; }
            set { basicSalary = value; }
        }
        public float employeeOTHourlyRate
        {
            get { return otHourlyRate; }
            set { otHourlyRate = value; }
        }

        public float CalcOverTimePayment(int noOfHours,float otHourlyRate )
        {
            float otPayment=(otHourlyRate* noOfHours);
            return otPayment;
        
        }
        public float CalcNetSalary(float basicSalary,float ovetTimePayment)
        {
            float netSalary = basicSalary + ovetTimePayment;
            return netSalary;
        }

    }
}
