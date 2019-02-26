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
    public partial class FTotalCost : Form
    {
        public FTotalCost()
        {
            InitializeComponent();
        }

        FFinance fFinance;
        public FTotalCost(FFinance fFinance)
        {
            InitializeComponent();
            this.fFinance = fFinance;
        }

        private void FTotalCost_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BBack2Finance_Click(object sender, EventArgs e)
        {
            FFinance fFinance = new FFinance();
            this.Hide();
            fFinance.Show();
        }

        private void FTotalCost_Load(object sender, EventArgs e)
        {
            GridVieUpdate();

        }

        // grid view update
        FNewEntry fNewEntry = new FNewEntry();
        public void GridVieUpdate()
        {
            DBML.AdminDBMLDataContext expenditureDBMLDataContext = new DBML.AdminDBMLDataContext(fNewEntry.DBLocation);
            var list = from a in expenditureDBMLDataContext.ExpenTables select a;
            dataGridView1.DataSource = list;
        }

        private void BExpenseSearch_Click(object sender, EventArgs e)
        {
            DBML.AdminDBMLDataContext dataContext = new DBML.AdminDBMLDataContext(fNewEntry.DBLocation);

            var record = from a in dataContext.ExpenTables where a.ExpenditureType == cBoxExtype.Text select a;

            dataGridView1.DataSource = record;

        }

        // search by year
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                DBML.AdminDBMLDataContext dataContext = new DBML.AdminDBMLDataContext(fNewEntry.DBLocation);

                var record = from a in dataContext.ExpenTables where a.Year == Convert.ToInt32(CboxYear.Text) select a;

                dataGridView1.DataSource = record;
            }
            catch
            {
                MessageBox.Show("Something is wrong !!");
            }
            
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            try
            {
                DBML.AdminDBMLDataContext dataContext = new DBML.AdminDBMLDataContext(fNewEntry.DBLocation);

                var record = from a in dataContext.ExpenTables where a.Month == cBoxMonth.Text && a.Year == Convert.ToInt32(CboxYear.Text) select a;

                dataGridView1.DataSource = record;
            }
            catch
            {
                MessageBox.Show("Something is wrong !!");
            }
            
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            GridVieUpdate();
            cBoxExtype.Text = "";
            cBoxMonth.Text = "";
            CboxYear.Text = "";
        }
    }
}
