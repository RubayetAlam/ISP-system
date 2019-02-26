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
    public partial class FNewEntry : Form
   
    {
        public string DBLocation = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# Codes\Pro\Presentation Layer\DB\IspDB.mdf;Integrated Security=True";

        public FNewEntry()
        {
            InitializeComponent();
        }

        FManageCustomer FManageCustomer;
        public FNewEntry(FManageCustomer fManageCustomer)
        {
            InitializeComponent();
            this.FManageCustomer = fManageCustomer;
            this.BackColor = Color.FromArgb(32, 35, 44);
        }

        private void FNewEntry_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BBack2ManageCustomer_Click(object sender, EventArgs e)
        {
            
        }

        private void BBackHome_Click(object sender, EventArgs e)
        {
            FManageCustomer fManageCustomer = new FManageCustomer();
            fManageCustomer.Show();
            this.Hide();
        }

        private void BAddNewCustomer_Click(object sender, EventArgs e)
        {        
            FNewEntry fNewEntry = new FNewEntry();

            DBML.AdminDBMLDataContext expenditureDBMLDataContext = new DBML.AdminDBMLDataContext(fNewEntry.DBLocation);

            var getAccount = from x in expenditureDBMLDataContext.CutomerNameTables
                             where x.CustomerID == Convert.ToInt32(txtCustomerID.Text)
                             select x;

            if (getAccount.Count() != 1)
            {
                try
                {
                    DBML.CutomerNameTable customerNameTable = new DBML.CutomerNameTable();
                    DBML.CustomerLocationTable customerLocationTable = new DBML.CustomerLocationTable();
                    DBML.CustomerContactTable customerContactTable = new DBML.CustomerContactTable();
                    DBML.CustomerNetInfoTAble customerNetInfoTable = new DBML.CustomerNetInfoTAble();
                    DBML.CustomerAmountTable customerAmountTable = new DBML.CustomerAmountTable();

                    customerNameTable.CustomerName = txtCustomerName.Text;
                    customerNameTable.CustomerID = Convert.ToInt32(txtCustomerID.Text);
                    customerNameTable.CustomreNID = txtCustomerNID.Text;

                    customerContactTable.CustomerMobile = txtCustomerMobile.Text;
                    customerContactTable.CustomerID = Convert.ToInt32(txtCustomerID.Text);
                    customerContactTable.CustomerEmail = txtCustomerEmail.Text;


                    customerLocationTable.CustomerArea = DropdownArea.selectedValue;
                    customerLocationTable.CustomerLocation = txtCustomerLoaction.Text;

                    customerNetInfoTable.CustomerID = Convert.ToInt16(txtCustomerID.Text);
                    customerNetInfoTable.CustomerStartDate = DatepickerStartDate.Value;

                    customerNetInfoTable.CustomerPackageName = comboBox1.Text;
                    customerNetInfoTable.CustomerIPAddress = txtCustomerIPAddress.Text;

                    customerAmountTable.CustomerAmount = Convert.ToInt16(txtCustomerAmount.Text);
                    customerAmountTable.CustomerID = Convert.ToInt16(txtCustomerID.Text);

                    expenditureDBMLDataContext.CustomerAmountTables.InsertOnSubmit(customerAmountTable);
                    expenditureDBMLDataContext.CustomerContactTables.InsertOnSubmit(customerContactTable);
                    expenditureDBMLDataContext.CustomerLocationTables.InsertOnSubmit(customerLocationTable);
                    expenditureDBMLDataContext.CustomerNetInfoTAbles.InsertOnSubmit(customerNetInfoTable);
                    expenditureDBMLDataContext.CutomerNameTables.InsertOnSubmit(customerNameTable);

                    expenditureDBMLDataContext.SubmitChanges();
                    MessageBox.Show("Data Entered Successfully!");

                    

                    // send mail

                    var client = new SmtpClient("smtp.gmail.com", 587)
                    {
                        Credentials = new NetworkCredential("ispbd123@gmail.com", "valoaso?"),
                        EnableSsl = true
                    };

                    client.Send("ispbd123@gmail.com", txtCustomerEmail.Text.TrimStart().TrimEnd(), "Connection Succcessfull", "Dear customer, welcome to our service. You are successfully registered to " + comboBox1.Text + " package.");

                    MessageBox.Show("Mail Sent");

                    clearData();
                }
                catch
                {
                    MessageBox.Show("Something is wrong");
                }

                
            }
            else
            {
                MessageBox.Show("Can not insert same Customer ID");
            }

            

        }

        public void clearData()
        {
            txtCustomerName.Text = "";
            txtCustomerID.Text = "";
            txtCustomerNID.Text = "";
            txtCustomerMobile.Text = "";
            txtCustomerID.Text = "";
            txtCustomerEmail.Text = "";
            txtCustomerLoaction.Text = "";
            txtCustomerID.Text = "";
            comboBox1.Text = "";
            txtCustomerIPAddress.Text = "";
            txtCustomerAmount.Text = "";
            txtCustomerID.Text = "";
        }

        private void FNewEntry_Load(object sender, EventArgs e)
        {
            // Load ComboBox Item
            DBML.AdminDBMLDataContext myDataContext = new DBML.AdminDBMLDataContext(DBLocation);
            comboBox1.DataSource = (from a in myDataContext.Packagetables select a).ToList();
            comboBox1.DisplayMember= "CustomerPackageName";
        }
    }
}
