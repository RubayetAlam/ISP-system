﻿using System;
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
    public partial class FProfitPerMonth : Form
    {
        public FProfitPerMonth()
        {
            InitializeComponent();
        }

        FReports fReports;
        public FProfitPerMonth(FReports fReports)
        {
            InitializeComponent();
            this.fReports = fReports;
        }

        private void FProfitPerMonth_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BBack2Report5_Click(object sender, EventArgs e)
        {
            FReports fReports = new FReports();
            this.Hide();
            fReports.Show();
        }
    }
}
