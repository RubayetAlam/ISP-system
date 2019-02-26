using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer
{
    public partial class FAddNewEmployee : Form
    {
        public FAddNewEmployee()
        {
            InitializeComponent();
        }

        FManageEmployee fManageEmployee;
        public FAddNewEmployee(FManageEmployee fManageEmployee)
        {
            InitializeComponent();
            this.fManageEmployee = fManageEmployee;
        }

        private void FAddNewEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BBack2ManageEmployee_Click(object sender, EventArgs e)
        {
            FManageEmployee fManageEmployee = new FManageEmployee();
            this.Hide();
            fManageEmployee.Show();
        }

        private void BBackHome_Click(object sender, EventArgs e)
        {
            FManageEmployee fManageEmployee = new FManageEmployee();
            this.Hide();
            fManageEmployee.Show();
        }

        FNewEntry fNewEntry = new FNewEntry();

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            DBML.AdminDBMLDataContext expenditureDBMLDataContext = new DBML.AdminDBMLDataContext(fNewEntry.DBLocation);

            var getAccount = from x in expenditureDBMLDataContext.EmployeeNameTables
                             where x.EmployeeID == Convert.ToInt32(TempID.Text) 
                             select x;

            if (getAccount.Count() != 1)
            {
                try
                {
                    DBML.EmployeeContactInfoTable employeeContactInfoTable = new DBML.EmployeeContactInfoTable();
                    DBML.EmployeeJoinDateTable employeeJoinDateTable = new DBML.EmployeeJoinDateTable();
                    DBML.EmployeeNameTable employeeNameTable = new DBML.EmployeeNameTable();
                    DBML.EmployeeSalaryTable employeeSalaryTable = new DBML.EmployeeSalaryTable();
                    DBML.EmployeeSalaryManage employeeSalaryManage = new DBML.EmployeeSalaryManage();

                    employeeContactInfoTable.EmployeeNID = txtEmployeeNID.Text;
                    employeeContactInfoTable.EmployeeMobile = txtEmployeeMobile.Text;
                    employeeContactInfoTable.EmployeeEmail = txtEmployeeEmail.Text;
                    employeeContactInfoTable.EmployeeAddress = txtEmployeeAddress.Text;
                    employeeContactInfoTable.EmployeeID = Convert.ToInt32(TempID.Text);

                    employeeSalaryManage.EmployeeID = Convert.ToInt32(TempID.Text);
                    employeeSalaryManage.EmployeeName = txtEmployeeName.Text;

                    employeeSalaryTable.EmployeeSalary = Convert.ToDouble(txtEmployeeSalary.Text);
                    employeeSalaryTable.EmployeeID = Convert.ToInt32(TempID.Text);

                    employeeJoinDateTable.EmployeeJoinDate = DatepickerEmployeeJoinDate.Value;
                    employeeJoinDateTable.EmployeeID = Convert.ToInt32(TempID.Text); ;

                    employeeNameTable.EmployeeName = txtEmployeeName.Text;
                    employeeNameTable.EmployeePassword = txtEmployeePassword.Text;
                    employeeNameTable.EmployeeModeratorAccess = cmBoxModeAcc.Text;
                    employeeNameTable.EmployeeID = Convert.ToInt32(TempID.Text);

                    expenditureDBMLDataContext.EmployeeContactInfoTables.InsertOnSubmit(employeeContactInfoTable);
                    expenditureDBMLDataContext.EmployeeJoinDateTables.InsertOnSubmit(employeeJoinDateTable);
                    expenditureDBMLDataContext.EmployeeSalaryTables.InsertOnSubmit(employeeSalaryTable);
                    expenditureDBMLDataContext.EmployeeSalaryManages.InsertOnSubmit(employeeSalaryManage);

                    expenditureDBMLDataContext.EmployeeNameTables.InsertOnSubmit(employeeNameTable);

                    expenditureDBMLDataContext.SubmitChanges();
                    MessageBox.Show("Employee Added Successfully!");

                    var client = new SmtpClient("smtp.gmail.com", 587)
                    {
                        Credentials = new NetworkCredential("ispbd123@gmail.com", "valoaso?"),
                        EnableSsl = true
                    };

                    client.Send("ispbd123@gmail.com", txtEmployeeEmail.Text.TrimStart().TrimEnd(), "Registration Succcessfull", txtEmployeeName.Text + " your registration is successful!\n");

                    MessageBox.Show("Mail sent!");
                }
                catch
                {
                    MessageBox.Show("Something is wrong !!");
                }              
            }
            else
            {
                MessageBox.Show("Can not insert same Employee ID");
            }


        }
           
    }
}
