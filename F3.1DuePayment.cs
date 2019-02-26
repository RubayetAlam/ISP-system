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
    public partial class FDuePayment : Form
    {
        public FDuePayment()
        {
            InitializeComponent();
        }

        FManagePayment fManagePayment;
        public FDuePayment(FManagePayment fManagePayment)
        {
            InitializeComponent();
            this.fManagePayment = fManagePayment;
        }

        private void BBackHome_Click(object sender, EventArgs e)
        {
            FManagePayment fManagePayment = new FManagePayment();
            this.Hide();
            fManagePayment.Show();
        }

        private void FDuePayment_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        FNewEntry fNewEntry = new FNewEntry();
        // grid view update
        public void GridVieUpdate()
        {
            DBML.AdminDBMLDataContext expenditureDBMLDataContext = new DBML.AdminDBMLDataContext(fNewEntry.DBLocation);
            var list = from a in expenditureDBMLDataContext.CustomerPaidTables select a;
            dataGridView1.DataSource = list;
        }

        private void FDuePayment_Load(object sender, EventArgs e)
        {
 
            DBML.AdminDBMLDataContext myDataContext = new DBML.AdminDBMLDataContext(fNewEntry.DBLocation);
            empList.DataSource = (from a in myDataContext.CutomerNameTables select a).ToList();
            empList.DisplayMember = "CustomerID";

            GridVieUpdate();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            try
            {
                DBML.AdminDBMLDataContext myDataContext = new DBML.AdminDBMLDataContext(fNewEntry.DBLocation);

                DBML.CustomerPaidTable employeeSalaryUpdateTable = new DBML.CustomerPaidTable();

                employeeSalaryUpdateTable.CustomerID = Convert.ToInt32(empList.Text);
                employeeSalaryUpdateTable.CustomerYear = empYear.Text;
                employeeSalaryUpdateTable.CustomerMonth = empMonth.Text;
                employeeSalaryUpdateTable.PaidStatus = "Paid";

                myDataContext.CustomerPaidTables.InsertOnSubmit(employeeSalaryUpdateTable);

                myDataContext.SubmitChanges();

                MessageBox.Show("Data Updated");

                GridVieUpdate();

                empList.Text = "";
                empYear.Text = "";
                empMonth.Text = "";
            }
            catch
            {
                MessageBox.Show("Something is wrong");
            }
            
        }
    }
}
