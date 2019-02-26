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
    public partial class FPackageInfo : Form
    {
        public FPackageInfo()
        {
            InitializeComponent();
        }

        FHome fHome;
        public FPackageInfo(FHome fHome)
        {
            InitializeComponent();
            this.fHome = fHome;
            GridVieUpdate();
        }

        private void FPackageInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BBackHome3_Click(object sender, EventArgs e)
        {
            FHome fHome = new FHome();
            this.Hide();
            fHome.Show();
        }

        private void BBackHome_Click(object sender, EventArgs e)
        {
            FHome fHome = new FHome();
            this.Hide();
            fHome.Show();
        }

        private void BAddNewPackage_Click(object sender, EventArgs e)
        {
            FAddNewPackage fAddNewPackage = new FAddNewPackage();
            this.Hide();
            fAddNewPackage.Show();
        }

        FNewEntry fNewEntry = new FNewEntry();

        private void FPackageInfo_Load(object sender, EventArgs e)
        {
            DBML.AdminDBMLDataContext myDataContext = new DBML.AdminDBMLDataContext(fNewEntry.DBLocation);
            comboBox1.DataSource = (from a in myDataContext.Packagetables select a).ToList();
            comboBox1.DisplayMember = "CustomerPackageName";
            GridVieUpdate();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DBML.AdminDBMLDataContext myDataContext = new DBML.AdminDBMLDataContext(fNewEntry.DBLocation);

                var record = from a in myDataContext.Packagetables where a.CustomerPackageName == comboBox1.Text select a;

                DBML.Packagetable r = record.First();

                r.CustomerPackageName = Pname.Text;
                r.PackagePrice = Convert.ToDouble(Pprice.Text);
                r.PackageSpeed = Pspeed.Text;

                myDataContext.SubmitChanges();

                MessageBox.Show("Data Changed");
                GridVieUpdate();
            }
            catch
            {
                MessageBox.Show("Something is wrong !!");
            }
            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                DBML.AdminDBMLDataContext myDataContext = new DBML.AdminDBMLDataContext(fNewEntry.DBLocation);

                var record = from a in myDataContext.Packagetables where a.CustomerPackageName == comboBox1.Text select a;

                Pname.Text = record.First().CustomerPackageName;
                Pprice.Text = record.First().PackagePrice.ToString();
                Pspeed.Text = record.First().PackageSpeed;

                dataGridView1.DataSource = record;
                GridVieUpdate();
            }
            catch
            {
                MessageBox.Show("Something is wrong !!");
            }
            
        }

        public void GridVieUpdate()
        {
            DBML.AdminDBMLDataContext expenditureDBMLDataContext = new DBML.AdminDBMLDataContext(fNewEntry.DBLocation);
            var list = from a in expenditureDBMLDataContext.Packagetables select a;
            dataGridView1.DataSource = list;
        }
    }
}
