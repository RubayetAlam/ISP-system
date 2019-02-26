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
    public partial class FAddNewPackage : Form
    {
        public FAddNewPackage()
        {
            InitializeComponent();
        }

        private void FAddNewPackage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BBack4_Click(object sender, EventArgs e)
        {
            FPackageInfo fPackageInfo = new FPackageInfo();
            this.Hide();
            fPackageInfo.Show();
        }

        FNewEntry fNewEntry = new FNewEntry();

        private void AddPackage_Click(object sender, EventArgs e)
        {
            try
            {
                DBML.AdminDBMLDataContext expenditureDBMLDataContext = new DBML.AdminDBMLDataContext(fNewEntry.DBLocation);

                DBML.Packagetable packagetable = new DBML.Packagetable();

                packagetable.PackagePrice = Convert.ToDouble(tprice.Text);
                packagetable.CustomerPackageName = tname.Text;
                packagetable.PackageSpeed = tspeed.Text;

                expenditureDBMLDataContext.Packagetables.InsertOnSubmit(packagetable);

                expenditureDBMLDataContext.SubmitChanges();

                MessageBox.Show("Package Added");

                tprice.Text = "";
                tname.Text = "";
                tspeed.Text = "";
            }
            catch
            {
                MessageBox.Show("Something is wrong !!");
            }
            


        }


    }
}
