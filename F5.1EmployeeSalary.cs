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
    public partial class FEmployeeSalary : Form
    {
        public FEmployeeSalary()
        {
            InitializeComponent();
        }

        FFinance fFinance;
        public FEmployeeSalary(FFinance fFinance)
        {
            InitializeComponent();
            this.fFinance = fFinance;
        }

        private void FEmployeeSalary_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BBack2ManageEmployee_Click(object sender, EventArgs e)
        {
            FFinance fFinance = new FFinance();
            this.Hide();
            fFinance.Show();
        }


        FNewEntry fNewEntry = new FNewEntry();
        // grid view update
        public void GridVieUpdate()
        {
            DBML.AdminDBMLDataContext expenditureDBMLDataContext = new DBML.AdminDBMLDataContext(fNewEntry.DBLocation);
            var list = from a in expenditureDBMLDataContext.EmployeeSalaryUpdateTables select a;
            dataGridView1.DataSource = list;
        }

        private void FEmployeeSalary_Load(object sender, EventArgs e)
        {

            GridVieUpdate();


        }

        private void submit_Click(object sender, EventArgs e)
        {
            try
            {
                DBML.AdminDBMLDataContext myDataContext = new DBML.AdminDBMLDataContext(fNewEntry.DBLocation);

                DBML.EmployeeSalaryUpdateTable employeeSalaryUpdateTable = new DBML.EmployeeSalaryUpdateTable();

                employeeSalaryUpdateTable.EmployeeID = Convert.ToInt32(empList.Text);
                employeeSalaryUpdateTable.Year = empYear.Text;
                employeeSalaryUpdateTable.Month = empMonth.Text;
                employeeSalaryUpdateTable.PaidStatus = "Paid";

                myDataContext.EmployeeSalaryUpdateTables.InsertOnSubmit(employeeSalaryUpdateTable);

                myDataContext.SubmitChanges();

                MessageBox.Show("Data Updated");

                GridVieUpdate();

                empList.Text = "";
                empYear.Text = "";
                empMonth.Text = "";

            }
            catch
            {
                MessageBox.Show("Something is wrong !!");
            }
            
        }


    }
}
