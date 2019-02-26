using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Presentation_Layer
{
    public partial class FForgotPassword : Form
    {
        public FForgotPassword()
        {
            InitializeComponent();
        }

        private void BBack2Login_Click(object sender, EventArgs e)
        {
            FLogin fLogin = new FLogin();
            this.Hide();
            fLogin.Show();
        }

        private void FForgotPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        FNewEntry fNewEntry = new FNewEntry();

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            try
            {
                DBML.AdminDBMLDataContext data = new DBML.AdminDBMLDataContext(fNewEntry.DBLocation);

                var r = from a in data.EmployeeContactInfoTables where a.EmployeeEmail == txtMail.Text select a;

                var r1 = from a in data.EmployeeNameTables join b in data.EmployeeContactInfoTables on a.EmployeeID equals b.EmployeeID select a;

                string username = r.First().EmployeeEmail;
                string password = r1.First().EmployeePassword;

                string subject = "Password send";

                var client = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential("arabikabir@gmail.com", "kabir01718292256"),
                    EnableSsl = true
                };

                client.Send("arabikabir@gmail.com", username.TrimStart().TrimEnd(), subject, password);
                MessageBox.Show("Mail Sent");
            }
            catch
            {
                MessageBox.Show("Something is wrong !!");
            }

            

        }
    }
}
