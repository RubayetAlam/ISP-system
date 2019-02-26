using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer
{
    public partial class FEmployeeList : Form
    {
        public FEmployeeList()
        {
            InitializeComponent();
        }

        FManageEmployee fManageEmployee;
        public FEmployeeList(FManageEmployee fManageEmployee)
        {
            InitializeComponent();
            this.fManageEmployee = fManageEmployee;
        }

        private void BBack2ManageCustomer3_Click(object sender, EventArgs e)
        {
            FManageEmployee fManageEmployee = new FManageEmployee();
            this.Hide();
            fManageEmployee.Show();
        }

        private void F2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BBackHome_Click(object sender, EventArgs e)
        {
            FManageEmployee fManageEmployee = new FManageEmployee();
            this.Hide();
            fManageEmployee.Show();
        }

        // grid view update
        FNewEntry fNewEntry = new FNewEntry();
        public void GridVieUpdate()
        {
            DBML.AdminDBMLDataContext expenditureDBMLDataContext = new DBML.AdminDBMLDataContext(fNewEntry.DBLocation);
            var list = from a in expenditureDBMLDataContext.EmployeeNameTables select a;
            dataGridView1.DataSource = list;
            
        }

        private void FEmployeeList_Load(object sender, EventArgs e)
        {
             GridVieUpdate();
           
        }

        //update
        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            try
            {
                DBML.AdminDBMLDataContext expenditureDBMLDataContext = new DBML.AdminDBMLDataContext(fNewEntry.DBLocation);

                var record = from a in expenditureDBMLDataContext.EmployeeContactInfoTables where a.EmployeeID == int.Parse(Tsearch.Text) select a;
                var record1 = from a in expenditureDBMLDataContext.EmployeeJoinDateTables where a.EmployeeID == int.Parse(Tsearch.Text) select a;
                var record2 = from a in expenditureDBMLDataContext.EmployeeNameTables where a.EmployeeID == int.Parse(Tsearch.Text) select a;
                var record3 = from a in expenditureDBMLDataContext.EmployeeSalaryManages where a.EmployeeID == int.Parse(Tsearch.Text) select a;
                var record4 = from a in expenditureDBMLDataContext.EmployeeSalaryTables where a.EmployeeID == int.Parse(Tsearch.Text) select a;

                //EmpName.Text = record2.First().EmployeeName;
                //EmpEmpPass.Text = record2.First().EmployeePassword;
                //CboxModeratorAccess.Text = record2.First().EmployeeModeratorAccess;

                //EmpNID.Text = record.First().EmployeeNID;
                //EmpMobile.Text = record.First().EmployeeMobile;
                //EmpEmail.Text = record.First().EmployeeEmail;
                //EmpAddress.Text = record.First().EmployeeAddress;

                //EmpSalary.Text = record4.First().EmployeeSalary.ToString();



                DBML.EmployeeContactInfoTable r1 = record.First();
                r1.EmployeeNID = EmpNID.Text;
                r1.EmployeeMobile = EmpMobile.Text;
                r1.EmployeeEmail = EmpEmail.Text;
                r1.EmployeeAddress = EmpAddress.Text;

                DBML.EmployeeNameTable r2 = record2.First();
                r2.EmployeeName = EmpName.Text;
                r2.EmployeePassword = EmpEmpPass.Text;
                r2.EmployeeModeratorAccess = CboxModeratorAccess.Text;

                DBML.EmployeeSalaryTable r3 = record4.First();
                r3.EmployeeSalary = Convert.ToDouble(EmpSalary.Text);

                DBML.EmployeeSalaryManage r4 = record3.First();
                r4.EmployeeName = EmpName.Text;

                expenditureDBMLDataContext.SubmitChanges();
                MessageBox.Show("Data Updated");

                GridVieUpdate();
                
            }
            catch
            {
                MessageBox.Show("Something is wrong");
            }
        }

        private void BempSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DBML.AdminDBMLDataContext expenditureDBMLDataContext = new DBML.AdminDBMLDataContext(fNewEntry.DBLocation);

                var record = from a in expenditureDBMLDataContext.EmployeeContactInfoTables where a.EmployeeID == int.Parse(Tsearch.Text) select a;
                var record1 = from a in expenditureDBMLDataContext.EmployeeJoinDateTables where a.EmployeeID == int.Parse(Tsearch.Text) select a;
                var record2 = from a in expenditureDBMLDataContext.EmployeeNameTables where a.EmployeeID == int.Parse(Tsearch.Text) select a;
                var record3 = from a in expenditureDBMLDataContext.EmployeeSalaryManages where a.EmployeeID == int.Parse(Tsearch.Text) select a;
                var record4 = from a in expenditureDBMLDataContext.EmployeeSalaryTables where a.EmployeeID == int.Parse(Tsearch.Text) select a;

                EmpName.Text = record2.First().EmployeeName;
                EmpEmpPass.Text = record2.First().EmployeePassword;
                CboxModeratorAccess.Text = record2.First().EmployeeModeratorAccess;

                EmpNID.Text = record.First().EmployeeNID;
                EmpMobile.Text = record.First().EmployeeMobile;
                EmpEmail.Text = record.First().EmployeeEmail;
                EmpAddress.Text = record.First().EmployeeAddress;

                EmpSalary.Text = record4.First().EmployeeSalary.ToString();

                dataGridView1.DataSource = record2;
            }
            catch
            {
                MessageBox.Show("Something is wrong");
            }
            

        }

        private void Bclear_Click(object sender, EventArgs e)
        {
            EmpName.Text = "";
            EmpEmpPass.Text = "";
            CboxModeratorAccess.Text = "";

            EmpNID.Text = "";
            EmpMobile.Text = "";
            EmpEmail.Text = "";
            EmpAddress.Text = "";

            EmpSalary.Text = "";

            GridVieUpdate();
            
        }

        private void Bdelete_Click(object sender, EventArgs e)
        {
            try
            {
                DBML.AdminDBMLDataContext expenditureDBMLDataContext = new DBML.AdminDBMLDataContext(fNewEntry.DBLocation);

                var record = from a in expenditureDBMLDataContext.EmployeeContactInfoTables where a.EmployeeID == int.Parse(Tsearch.Text) select a;
                var record1 = from a in expenditureDBMLDataContext.EmployeeJoinDateTables where a.EmployeeID == int.Parse(Tsearch.Text) select a;
                var record2 = from a in expenditureDBMLDataContext.EmployeeNameTables where a.EmployeeID == int.Parse(Tsearch.Text) select a;
                var record3 = from a in expenditureDBMLDataContext.EmployeeSalaryManages where a.EmployeeID == int.Parse(Tsearch.Text) select a;
                var record4 = from a in expenditureDBMLDataContext.EmployeeSalaryTables where a.EmployeeID == int.Parse(Tsearch.Text) select a;

                dataGridView1.DataSource = record2;

                DBML.EmployeeContactInfoTable t1 = record.First();
                DBML.EmployeeJoinDateTable t2 = record1.First();
                DBML.EmployeeNameTable t3 = record2.First();
                DBML.EmployeeSalaryManage t4 = record3.First();
                DBML.EmployeeSalaryTable t5 = record4.First();

                expenditureDBMLDataContext.EmployeeContactInfoTables.DeleteOnSubmit(t1);
                expenditureDBMLDataContext.EmployeeJoinDateTables.DeleteOnSubmit(t2);
                expenditureDBMLDataContext.EmployeeNameTables.DeleteOnSubmit(t3);
                expenditureDBMLDataContext.EmployeeSalaryManages.DeleteOnSubmit(t4);
                expenditureDBMLDataContext.EmployeeSalaryTables.DeleteOnSubmit(t5);

                expenditureDBMLDataContext.SubmitChanges();

                MessageBox.Show("Data Deleted");

                EmpName.Text = "";
                EmpEmpPass.Text = "";
                CboxModeratorAccess.Text = "";

                EmpNID.Text = "";
                EmpMobile.Text = "";
                EmpEmail.Text = "";
                EmpAddress.Text = "";

                EmpSalary.Text = "";

                GridVieUpdate();
            }
            catch
            {
                MessageBox.Show("Something is wrong");
            }      

        }
    }
}
