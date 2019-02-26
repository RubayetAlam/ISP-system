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
    public partial class FExpenditure : Form
    {
        //public string DBLocation = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = F:\CSharp\FinalProject\FP_V2\Presentation Layer\DB\IspDB.mdf; Integrated Security = True";

        FNewEntry fNewEntry = new FNewEntry();

        public FExpenditure()
        {
            InitializeComponent();
        }

        FFinance fFinance;
        public FExpenditure(FFinance fFinance)
        {
            InitializeComponent();
            this.fFinance = fFinance;
        }

        private void BBack2Finance_Click(object sender, EventArgs e)
        {
            FFinance fFinance = new FFinance();
            this.Hide();
            fFinance.Show();
        }

        private void FExpenditure_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        // grid view update
        public void GridVieUpdate()
        {
            DBML.AdminDBMLDataContext expenditureDBMLDataContext = new DBML.AdminDBMLDataContext(fNewEntry.DBLocation);
            var list = from a in expenditureDBMLDataContext.ExpenTables select a;
            dataGridView1.DataSource = list;
        }
        

        private void BAddExpenditure_Click(object sender, EventArgs e)
        {
            try
            {
                
                DBML.AdminDBMLDataContext expenditureDBMLDataContext = new DBML.AdminDBMLDataContext(fNewEntry.DBLocation);

                DBML.ExpenTable expenditure = new DBML.ExpenTable();

                expenditure.ExpenditureNumber = TExNo.Text;
                expenditure.ExpenditureType = DropExpenditureType.Text;
                expenditure.ExpenditureName = TExName.Text;
                expenditure.Year = Convert.ToUInt16(DYear.Text);
                expenditure.Month = DropMonth.Text;
                expenditure.Amount = Convert.ToInt16(TExAmount.Text);

                expenditureDBMLDataContext.ExpenTables.InsertOnSubmit(expenditure);
                expenditureDBMLDataContext.SubmitChanges();
                MessageBox.Show("Expenditure added");
                GridVieUpdate();
            }
            catch
            {
                MessageBox.Show("Enter all field");
            }


        }

        private void FExpenditure_Load(object sender, EventArgs e)
        {
            GridVieUpdate();

        }

        private void BsearchEx_Click(object sender, EventArgs e)
        {
            try
            {
                DBML.AdminDBMLDataContext expenditureDBMLDataContext = new DBML.AdminDBMLDataContext(fNewEntry.DBLocation);
                var record = from a in expenditureDBMLDataContext.ExpenTables where a.Id == int.Parse(TExSearch.Text) select a;

                TExNo.Text = record.First().ExpenditureNumber;
                DropExpenditureType.Text = record.First().ExpenditureType;
                TExName.Text = record.First().ExpenditureName;
                DYear.Text = Convert.ToString(record.First().Year);
                DropMonth.Text = record.First().Month;
                TExAmount.Text = Convert.ToString(record.First().Amount);

                dataGridView1.DataSource = record;
            }
            catch
            {
                MessageBox.Show("Something is wrong");
            }
            

        }

        public void FieldClear()
        {
            TExNo.Text = "";
            DropExpenditureType.Text = "";
            TExName.Text = "";
            DYear.Text = "";
            DropMonth.Text = "";
            TExAmount.Text = "";

            GridVieUpdate();
        }

        private void BExUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DBML.AdminDBMLDataContext expenditureDBMLDataContext = new DBML.AdminDBMLDataContext(fNewEntry.DBLocation);
                var record = from a in expenditureDBMLDataContext.ExpenTables where a.Id == int.Parse(TExSearch.Text) select a;

                DBML.ExpenTable rc = record.First();

                rc.ExpenditureNumber = TExNo.Text;
                rc.ExpenditureType = DropExpenditureType.Text;
                rc.ExpenditureName = TExName.Text;
                rc.Year = Convert.ToInt32(DYear.Text);
                rc.Month = DropMonth.Text;
                rc.Amount = Convert.ToDouble(TExAmount.Text);
                expenditureDBMLDataContext.SubmitChanges();
                MessageBox.Show("Data Updated");
                GridVieUpdate();
            }
            catch
            {
                MessageBox.Show("Something is wrong");
            }
            
        }

        private void BClear_Click(object sender, EventArgs e)
        {
            FieldClear();
        }

        // delete data
        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            try
            {
                DBML.AdminDBMLDataContext expenditureDBMLDataContext = new DBML.AdminDBMLDataContext(fNewEntry.DBLocation);
                var record = from a in expenditureDBMLDataContext.ExpenTables where a.Id == int.Parse(TExSearch.Text) select a;

                dataGridView1.DataSource = record;
                DBML.ExpenTable expenTable = record.First();
                expenditureDBMLDataContext.ExpenTables.DeleteOnSubmit(expenTable);
                expenditureDBMLDataContext.SubmitChanges();
                MessageBox.Show("Data deleted");

                FieldClear();
                GridVieUpdate();
            }
            catch
            {
                MessageBox.Show("Something is wrong");
            }       

        }
    }
}
