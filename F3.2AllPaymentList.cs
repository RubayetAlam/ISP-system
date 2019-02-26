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
    public partial class FAllPaymentList : Form
    {
        public FAllPaymentList()
        {
            InitializeComponent();
        }

        FManagePayment fManagePayment;
        public FAllPaymentList(FManagePayment fManagePayment)
        {
            InitializeComponent();
            this.fManagePayment = fManagePayment;
        }

        private void BBackManagePayment12_Click(object sender, EventArgs e)
        {
            FManagePayment fManagePayment = new FManagePayment();
            this.Hide();
            fManagePayment.Show();
        }

        private void FAllPaymentList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FAllPaymentList_Load(object sender, EventArgs e)
        {
            GridVieUpdate();

            DBML.AdminDBMLDataContext myDataContext = new DBML.AdminDBMLDataContext(fNewEntry.DBLocation);
            comboBoxCustomer.DataSource = (from a in myDataContext.CutomerNameTables select a).ToList();
            comboBoxCustomer.DisplayMember = "CustomerID";

        }

        // grid view update
        FNewEntry fNewEntry = new FNewEntry();
        public void GridVieUpdate()
        {
            DBML.AdminDBMLDataContext expenditureDBMLDataContext = new DBML.AdminDBMLDataContext(fNewEntry.DBLocation);
            var list = from a in expenditureDBMLDataContext.CustomerPaidTables select a;
            dataGridView1.DataSource = list;
        }


        private void btnYear_Click(object sender, EventArgs e)
        {
            try
            {
                DBML.AdminDBMLDataContext dataContext = new DBML.AdminDBMLDataContext(fNewEntry.DBLocation);

                var record = from a in dataContext.CustomerPaidTables where a.CustomerYear == comboBoxYear.Text select a;

                dataGridView1.DataSource = record;
            }
            catch
            {
                MessageBox.Show("Not found !!");
            }
            
        }

        private void btnMonth_Click(object sender, EventArgs e)
        {
            DBML.AdminDBMLDataContext dataContext = new DBML.AdminDBMLDataContext(fNewEntry.DBLocation);

            var record = from a in dataContext.CustomerPaidTables where a.CustomerMonth == comboBoxMonth.Text && a.CustomerYear == comboBoxYear.Text select a;

            dataGridView1.DataSource = record;
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            DBML.AdminDBMLDataContext dataContext = new DBML.AdminDBMLDataContext(fNewEntry.DBLocation);

            var record = from a in dataContext.CustomerPaidTables where a.CustomerID == Convert.ToInt32(comboBoxCustomer.Text) && a.CustomerYear == comboBoxYear.Text select a;

            dataGridView1.DataSource = record;
        }
    }
}
