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
    public partial class FLogin : Form
    {
        public static string type;
        public FLogin()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(32, 35, 44);

           
        }




        private void BLogin_Click(object sender, EventArgs e)
        {           
            


            DBML.AdminDBMLDataContext adminDBMLDataContext = new DBML.AdminDBMLDataContext();
            // data from textbox
            string newUsername = TUsername.Text;
            string newPassword = TPassword.Text;

            #region admin login

            if (newUsername=="" || newPassword == "")
            {
                MessageBox.Show("Enter username and password");
            }
            else
            {
                var getAccount = from x in adminDBMLDataContext.AdminTables
                                 where x.AdminUserName == newUsername && x.AdminPassword == newPassword
                                 select x;
                if(getAccount.Count()!=1)
                {
                    // Moderator check
                    var getAccount2 = from x in adminDBMLDataContext.EmployeeNameTables
                                     where x.EmployeeName == newUsername && x.EmployeePassword == newPassword
                                     select x;
                    if(getAccount2.Count() != 1)
                    {
                        MessageBox.Show("Account not found");
                    }
                    else
                    {
                        type = "employee";
                        FHome f2home = new FHome(this);
                        this.Hide();
                        f2home.Show();

                    
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



                    }
                }
                else
                {
                    FHome f2home = new FHome(this);
                    this.Hide();
                    f2home.Show();
                }
            }
            #endregion

        }

        private void F1Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BForgotPassword_Click(object sender, EventArgs e)
        {
            FForgotPassword fForgotPassword = new FForgotPassword();
            this.Hide();
            fForgotPassword.Show();
        }

        private void FLogin_Load(object sender, EventArgs e)
        {

        }

        
       
    }
}
