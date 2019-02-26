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
    public partial class FCustomerList : Form
    {
        public FCustomerList()
        {
            InitializeComponent();
        }


        FManageCustomer fManageCustomer;

        public FCustomerList(FManageCustomer fManageCustomer)
        {
            InitializeComponent();
            this.fManageCustomer = fManageCustomer;
            this.BackColor = Color.FromArgb(32, 35, 44);
        }

        private void FCustomerList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BBack2ManageCustomer2_Click(object sender, EventArgs e)
        {
            
        }

        private void BBackHome_Click(object sender, EventArgs e)
        {
            FManageCustomer fManageCustomer = new FManageCustomer();
            fManageCustomer.Show();
            this.Hide();
        }

        FNewEntry fNewEntry = new FNewEntry();

        public void GridVieUpdate()
        {
            DBML.AdminDBMLDataContext expenditureDBMLDataContext = new DBML.AdminDBMLDataContext(fNewEntry.DBLocation);
            var list = from a in expenditureDBMLDataContext.CutomerNameTables select a;
            dataGridView1.DataSource = list;
        }

        private void FCustomerList_Load(object sender, EventArgs e)
        {
            GridVieUpdate();
            // Display Package from DB
            DBML.AdminDBMLDataContext myDataContext = new DBML.AdminDBMLDataContext(fNewEntry.DBLocation);
            comboBox2.DataSource = (from a in myDataContext.Packagetables select a).ToList();
            comboBox2.DisplayMember = "CustomerPackageName";
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            try
            {
                DBML.AdminDBMLDataContext expenditureDBMLDataContext = new DBML.AdminDBMLDataContext(fNewEntry.DBLocation);

                var record = from a in expenditureDBMLDataContext.CustomerAmountTables where a.CustomerID == int.Parse(TCustomerSearch.Text) select a;
                var record1 = from a in expenditureDBMLDataContext.CustomerContactTables where a.CustomerID == int.Parse(TCustomerSearch.Text) select a;
                var record3 = from a in expenditureDBMLDataContext.CustomerNetInfoTAbles where a.CustomerID == int.Parse(TCustomerSearch.Text) select a;
                var record4 = from a in expenditureDBMLDataContext.CutomerNameTables where a.CustomerID == int.Parse(TCustomerSearch.Text) select a;

                TCusAmount.Text = Convert.ToString(record.First().CustomerAmount);
                TCusName.Text = record4.First().CustomerName;
                TCusNID.Text = record4.First().CustomreNID;
                TCusMobile.Text = record1.First().CustomerMobile;
                TCusEmail.Text = record1.First().CustomerEmail;
                comboBox2.Text = record3.First().CustomerPackageName;

                dataGridView1.DataSource = record4;
            }
            catch
            {
                MessageBox.Show("something is wrong");
            }                    

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            TCusAmount.Text = "";

            TCusName.Text = "";
            TCusNID.Text = "";
            TCusMobile.Text = "";
            TCusEmail.Text = "";
            comboBox2.Text = "";

            GridVieUpdate();
        }

        // update info
        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            try
            {
                DBML.AdminDBMLDataContext expenditureDBMLDataContext = new DBML.AdminDBMLDataContext(fNewEntry.DBLocation);

                var record = from a in expenditureDBMLDataContext.CustomerAmountTables where a.CustomerID == int.Parse(TCustomerSearch.Text) select a;
                var record1 = from a in expenditureDBMLDataContext.CustomerContactTables where a.CustomerID == int.Parse(TCustomerSearch.Text) select a;
                var record3 = from a in expenditureDBMLDataContext.CustomerNetInfoTAbles where a.CustomerID == int.Parse(TCustomerSearch.Text) select a;
                var record4 = from a in expenditureDBMLDataContext.CutomerNameTables where a.CustomerID == int.Parse(TCustomerSearch.Text) select a;

                DBML.CustomerAmountTable rc1 = record.First();
                rc1.CustomerAmount = Convert.ToDouble(TCusAmount.Text);


                DBML.CustomerContactTable rc2 = record1.First();
                rc2.CustomerMobile = TCusMobile.Text;
                rc2.CustomerEmail = TCusEmail.Text;


                DBML.CutomerNameTable rc3 = record4.First();
                rc3.CustomerName = TCusName.Text;
                rc3.CustomreNID = TCusNID.Text;


                DBML.CustomerNetInfoTAble rc4 = record3.First();
                rc4.CustomerPackageName = comboBox2.Text;


                expenditureDBMLDataContext.SubmitChanges();
                MessageBox.Show("Information Updated");
            }
            catch
            {
                MessageBox.Show("something is wrong");
            }
            
            
        }

        // delete data
        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            try
            {
                DBML.AdminDBMLDataContext expenditureDBMLDataContext = new DBML.AdminDBMLDataContext(fNewEntry.DBLocation);

                var record = from a in expenditureDBMLDataContext.CustomerAmountTables where a.CustomerID == int.Parse(TCustomerSearch.Text) select a;
                var record1 = from a in expenditureDBMLDataContext.CustomerContactTables where a.CustomerID == int.Parse(TCustomerSearch.Text) select a;
                var r1 = from a in expenditureDBMLDataContext.CustomerLocationTables join b in expenditureDBMLDataContext.CustomerContactTables on a.CustomerLocationID equals b.CustomerLocationID select a;
                var record3 = from a in expenditureDBMLDataContext.CustomerNetInfoTAbles where a.CustomerID == int.Parse(TCustomerSearch.Text) select a;
                var record4 = from a in expenditureDBMLDataContext.CutomerNameTables where a.CustomerID == int.Parse(TCustomerSearch.Text) select a;

                dataGridView1.DataSource = record4;

                DBML.CustomerAmountTable t1 = record.First();
                DBML.CustomerContactTable t2 = record1.First();
                DBML.CustomerLocationTable t3 = r1.First();
                DBML.CustomerNetInfoTAble t4 = record3.First();
                DBML.CutomerNameTable t5 = record4.First();

                expenditureDBMLDataContext.CustomerAmountTables.DeleteOnSubmit(t1);
                expenditureDBMLDataContext.CustomerContactTables.DeleteOnSubmit(t2);
                expenditureDBMLDataContext.CustomerLocationTables.DeleteOnSubmit(t3);
                expenditureDBMLDataContext.CustomerNetInfoTAbles.DeleteOnSubmit(t4);
                expenditureDBMLDataContext.CutomerNameTables.DeleteOnSubmit(t5);

                expenditureDBMLDataContext.SubmitChanges();
            }
            catch
            {
                MessageBox.Show("Something is wrong !!");
            }
            
        }


        // search by area
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            try
            {
                DBML.AdminDBMLDataContext dataContext = new DBML.AdminDBMLDataContext(fNewEntry.DBLocation);

                var record = from a in dataContext.CustomerLocationTables join b in dataContext.CustomerContactTables on a.CustomerLocationID equals b.CustomerLocationID where comboBox3.Text == a.CustomerArea select b;

                dataGridView2.DataSource = record;
            }
            catch
            {
                MessageBox.Show("Something is wrong !!");
            }
            
            
        }
    }
}
