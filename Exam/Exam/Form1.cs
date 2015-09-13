using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLayer;
using Property;
namespace Exam
{
    public partial class Form1 : Form
    {
       
        
        public Form1()
        {
            InitializeComponent();
            label11.Visible = false;
            basicSal.Visible = false;
            label8.Visible = false;
            label12.Visible = false;
            
        }

        

        private void Add_Click_1(object sender, EventArgs e)
        {
            if (id.Text == "" || (name.Text == "") || address.Text == "" || age.Text == "" || contactNo.Text == "" || noOfHours.Text == "" ||  type.Text == "" )
            {
                MessageBox.Show("Please Fill All Textboxes");
            }
            else
            {
                try
                {

                    Bussiness bs = new Bussiness();
                    Employee emp = new Employee();
                    emp.employeeId = Convert.ToInt32(id.Text);
                    emp.employeeName = name.Text;
                    emp.employeeAddress = address.Text;
                    emp.employeeAge = Convert.ToInt32(age.Text);
                    emp.employeeContactNumber = Convert.ToInt32(contactNo.Text);
                    emp.employeeNoOfHours = Convert.ToInt32(noOfHours.Text);
                    emp.employeeType= type.Text;
                  

                    bs.insert_details(emp);
                    MessageBox.Show("Successfully Added");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in Add");
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                Bussiness bs = new Bussiness();
                Employee emp = new Employee();
                int ID = Convert.ToInt32(id.Text);
                bs.delete_details(ID);
                MessageBox.Show("Successfully Deleted");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error in Delete");
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (id.Text == "" || (name.Text == "") || address.Text == "" ||age.Text == "" || contactNo.Text == "" || noOfHours.Text == "" || type.Text == "" )
            {
                MessageBox.Show("Please Fill All Textboxes");
            }
            else
            {
                try
                {
                    Bussiness bs = new Bussiness();
                    Employee emp = new Employee();
                    emp.employeeId = Convert.ToInt32(id.Text);
                    emp.employeeName = name.Text;
                    emp.employeeAddress = address.Text;
                    emp.employeeAge = Convert.ToInt32(age.Text);
                    emp.employeeContactNumber = Convert.ToInt32(contactNo.Text);
                    emp.employeeNoOfHours = Convert.ToInt32(noOfHours.Text);
                    emp.employeeType = type.Text;


                    bs.update_details(emp);
                    MessageBox.Show("Successfully Updated");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error in Update");
                }
            }
        }

        private void CalculateSalary_Click(object sender, EventArgs e)
        {
            try
            {

                Bussiness bs = new Bussiness();

                if (type.Text == "Internal")
                {
                    InternalEmployee emp = new InternalEmployee();
                    float otPayment = emp.CalcOverTimePayment(Convert.ToInt32(noOfHours.Text), float.Parse(otHourRate.Text));

                    salary.Text = (emp.CalcNetSalary(float.Parse(basicSal.Text), otPayment)).ToString();
                    
                }
                else if (type.Text == "External")
                {
                    ExternalEmployee exEmp = new ExternalEmployee();
                    salary.Text = (exEmp.CalcNetSalary(float.Parse(otHourRate.Text), Convert.ToInt32(noOfHours.Text))).ToString();
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("invalid calculation");
            }
        }

        private void contactNo_TextChanged(object sender, EventArgs e)
        {
         

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (type.Text == "Internal")
            {
                label9.Text = "OT HourlyRate";
                basicSal.Visible = true;
                label8.Visible = true;

            }
            else if (type.Text == "External")
            {

                label9.Text = "HourlyRate";
                basicSal.Visible = false;
                label8.Visible = false;
            
            }
        }

        private void contactNo_MouseLeave(object sender, EventArgs e)
        {
          

        }

        private void contactNo_Leave(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Bussiness bs = new Bussiness();
                Employee emp = new Employee();
                DataSet ds = new DataSet();
                ds = bs.read_details(Convert.ToInt32(id.Text));

                name.Text = ds.Tables[0].Rows[0]["Name"].ToString();
                address.Text = ds.Tables[0].Rows[0]["Address"].ToString();
                age.Text = ds.Tables[0].Rows[0]["Age"].ToString();
                contactNo.Text = ds.Tables[0].Rows[0]["ContactNumber"].ToString();
                noOfHours.Text = ds.Tables[0].Rows[0]["NoOfHours"].ToString();
                type.Text = ds.Tables[0].Rows[0]["EmpType"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("invalid Search");
            }
        }

        private void contactNo_Validating(object sender, CancelEventArgs e)
        {
            if (contactNo.TextLength != 10)
            {
                label11.Visible = true;
            }
            else
            {
                label11.Visible = false;
            }
        }

        private void age_Validated(object sender, EventArgs e)
        {

        }

        private void age_Validating(object sender, CancelEventArgs e)
        {
            foreach (var a in (age.Text))
            {
                if (char.IsDigit(a) == true)
                {

                    label12.Visible = false;
                }
                else
                {
                    label12.Visible =true;
                }
            }
        }

    }
}
