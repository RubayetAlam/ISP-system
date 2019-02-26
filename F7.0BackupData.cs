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
    public partial class FBackupData : Form
    {
        public FBackupData()
        {
            InitializeComponent();
        }


        private void BBackHome_Click(object sender, EventArgs e)
        {
            if (FLogin.type == "employee") {
                FHome f2home = new FHome();
                f2home.BManageCustomer.Enabled = false;
                f2home.BManageEmployee.Enabled = false;
                f2home.BPackageInformation.Enabled = false;
                f2home.BAdminInfo.Enabled = false;
                f2home.BFinance.Enabled = false;
                f2home.BReports.Enabled = false;

                f2home.BManageCustomer.BackColor = Color.Gray;
                f2home.BManageEmployee.BackColor = Color.Gray;
                f2home.BPackageInformation.BackColor = Color.Gray;
                f2home.BAdminInfo.BackColor = Color.Gray;
                f2home.BFinance.BackColor = Color.Gray;
                f2home.BReports.BackColor = Color.Gray;
                this.Hide();
                f2home.Show();

            }
            else
            {
                FHome fHome = new FHome();
                this.Hide();
                fHome.Show();
            }

           
        }

        private void FBackupData_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FBackupData_Load(object sender, EventArgs e)
        {

        }



        private void BBackupData_Click(object sender, EventArgs e)
        {
            string fileName = "IspDB.mdf";
            string sourcePath = @"E:\C# Codes\Pro\Presentation Layer\DB";
            string targetPath = @"D:\Temp";
         
            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string destFile = System.IO.Path.Combine(targetPath, fileName);

          
            if (!System.IO.Directory.Exists(targetPath))
            {
                System.IO.Directory.CreateDirectory(targetPath);
            }
       
            System.IO.File.Copy(sourceFile, destFile, true);

            if (System.IO.Directory.Exists(sourcePath))
            {
                string[] files = System.IO.Directory.GetFiles(sourcePath);

                foreach (string s in files)
                {
                    fileName = System.IO.Path.GetFileName(s);
                    destFile = System.IO.Path.Combine(targetPath, fileName);
                    System.IO.File.Copy(s, destFile, true);
                }
            }
            MessageBox.Show("Backup successfull!");


        }
    }
}
