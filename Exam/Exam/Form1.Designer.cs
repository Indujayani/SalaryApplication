namespace Exam
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.id = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.contactNo = new System.Windows.Forms.TextBox();
            this.noOfHours = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.ComboBox();
            this.basicSal = new System.Windows.Forms.TextBox();
            this.otHourRate = new System.Windows.Forms.TextBox();
            this.salary = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.CalculateSalary = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.searchbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(171, 40);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(134, 20);
            this.id.TabIndex = 0;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(171, 92);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(134, 20);
            this.name.TabIndex = 1;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(171, 144);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(134, 20);
            this.address.TabIndex = 2;
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(171, 191);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(134, 20);
            this.age.TabIndex = 3;
            this.age.Validating += new System.ComponentModel.CancelEventHandler(this.age_Validating);
            this.age.Validated += new System.EventHandler(this.age_Validated);
            // 
            // contactNo
            // 
            this.contactNo.BackColor = System.Drawing.Color.White;
            this.contactNo.Location = new System.Drawing.Point(171, 247);
            this.contactNo.Name = "contactNo";
            this.contactNo.Size = new System.Drawing.Size(134, 20);
            this.contactNo.TabIndex = 4;
            this.contactNo.Leave += new System.EventHandler(this.contactNo_Leave);
            this.contactNo.MouseLeave += new System.EventHandler(this.contactNo_MouseLeave);
            this.contactNo.Validating += new System.ComponentModel.CancelEventHandler(this.contactNo_Validating);
            // 
            // noOfHours
            // 
            this.noOfHours.Location = new System.Drawing.Point(653, 89);
            this.noOfHours.Name = "noOfHours";
            this.noOfHours.Size = new System.Drawing.Size(133, 20);
            this.noOfHours.TabIndex = 5;
            // 
            // type
            // 
            this.type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type.FormattingEnabled = true;
            this.type.Items.AddRange(new object[] {
            "Internal",
            "External"});
            this.type.Location = new System.Drawing.Point(653, 40);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(133, 21);
            this.type.TabIndex = 6;
            this.type.SelectedIndexChanged += new System.EventHandler(this.type_SelectedIndexChanged);
            // 
            // basicSal
            // 
            this.basicSal.Location = new System.Drawing.Point(653, 191);
            this.basicSal.Name = "basicSal";
            this.basicSal.Size = new System.Drawing.Size(133, 20);
            this.basicSal.TabIndex = 7;
            // 
            // otHourRate
            // 
            this.otHourRate.Location = new System.Drawing.Point(653, 144);
            this.otHourRate.Name = "otHourRate";
            this.otHourRate.Size = new System.Drawing.Size(133, 20);
            this.otHourRate.TabIndex = 8;
            // 
            // salary
            // 
            this.salary.Location = new System.Drawing.Point(653, 335);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(133, 20);
            this.salary.TabIndex = 9;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(85, 361);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 10;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click_1);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(181, 361);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 11;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(285, 361);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 12;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // CalculateSalary
            // 
            this.CalculateSalary.Location = new System.Drawing.Point(581, 237);
            this.CalculateSalary.Name = "CalculateSalary";
            this.CalculateSalary.Size = new System.Drawing.Size(113, 23);
            this.CalculateSalary.TabIndex = 13;
            this.CalculateSalary.Text = "CalculateSalary";
            this.CalculateSalary.UseVisualStyleBackColor = true;
            this.CalculateSalary.Click += new System.EventHandler(this.CalculateSalary_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Contact Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(488, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "No Of Hours";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(486, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Employee Type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(488, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "BasicSal";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(488, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "OT Hours Rate";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(500, 338);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Salary";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(331, 247);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Error";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(334, 191);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Error";
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(334, 40);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(75, 23);
            this.searchbtn.TabIndex = 26;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(874, 441);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalculateSalary);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.otHourRate);
            this.Controls.Add(this.basicSal);
            this.Controls.Add(this.type);
            this.Controls.Add(this.noOfHours);
            this.Controls.Add(this.contactNo);
            this.Controls.Add(this.age);
            this.Controls.Add(this.address);
            this.Controls.Add(this.name);
            this.Controls.Add(this.id);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.TextBox contactNo;
        private System.Windows.Forms.TextBox noOfHours;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.TextBox basicSal;
        private System.Windows.Forms.TextBox otHourRate;
        private System.Windows.Forms.TextBox salary;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button CalculateSalary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button searchbtn;
    }
}

