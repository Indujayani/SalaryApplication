using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    public  class Employee
    {
        private int id;
        private string name;
        private string address;
        private int age;
        private int contactNumber;
        private int noOfHours;
        private string type;
       

        public int employeeId
        {
            get { return id; }
            set { id = value; }
        }
        public string employeeName
        {
            get { return name; }
            set { name = value; }
        }
        public string employeeAddress
        {
            get { return address; }
            set { address = value; }
        }
        public int employeeAge
        {
            get { return age; }
            set { age = value; }
        }
        public int employeeContactNumber
        {
            get { return contactNumber; }
            set { contactNumber = value; }
        }
        public int employeeNoOfHours
        {
            get { return noOfHours; }
            set { noOfHours = value; }
        }
        public string employeeType
        {
            get { return type; }
            set { type = value; }
        }
        public float CalcNetSalary() 
        { 
            
            return CalcNetSalary(); 
        
        }
        
        
          
    }
}
