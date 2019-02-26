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
    public partial class FAdmin : Form
    {
        DBML.AdminDBMLDataContext adminDBMLDataContext = new DBML.AdminDBMLDataContext();

        public FAdmin()
        {
            InitializeComponent();
        }

        FHome fHome;
        public FAdmin(FHome fHome)
        {
            InitializeComponent();
            this.fHome = fHome;

        }

        private void BBackLoginA_Click(object sender, EventArgs e)
        {
            FHome fHome = new FHome();
            this.Hide();
            fHome.Show();
        }

        private void FAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BUpdateAdminInfo_Click(object sender, EventArgs e)
        {
            try
            {
                DBML.AdminDBMLDataContext adminDBMLDataContext = new DBML.AdminDBMLDataContext(fNewEntry.DBLocation);

                var record = from a in adminDBMLDataContext.AdminTables where a.AdminName == comboBox1.Text select a;

                DBML.AdminTable r = record.First();
                r.AdminUserName = TAdminUsername.Text;
                r.AdminPassword = TAdminPassword.Text;
                adminDBMLDataContext.SubmitChanges();
                MessageBox.Show("Admin Data Updated");

                TAdminUsername.Text = "";
                TAdminPassword.Text = "";

                updateGridview();
            }
            catch
            {
                MessageBox.Show("SOmething is wrong !!");
            }
            

        }

        public void updateGridview()
        {
            DBML.AdminDBMLDataContext expenditureDBMLDataContext = new DBML.AdminDBMLDataContext(fNewEntry.DBLocation);
            var list = from a in expenditureDBMLDataContext.AdminTables select a;
            bunifuCustomDataGrid1.DataSource = list;
        }

        FNewEntry fNewEntry = new FNewEntry();

        private void FAdmin_Load(object sender, EventArgs e)
        {
            updateGridview();

            DBML.AdminDBMLDataContext myDataContext = new DBML.AdminDBMLDataContext(fNewEntry.DBLocation);
            comboBox1.DataSource = (from a in myDataContext.AdminTables select a).ToList();
            comboBox1.DisplayMember = "AdminName";
        }
    }
}
