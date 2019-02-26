namespace Presentation_Layer
{
    partial class FTotalCost
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FTotalCost));
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cBoxMonth = new System.Windows.Forms.ComboBox();
            this.CboxYear = new System.Windows.Forms.ComboBox();
            this.cBoxExtype = new System.Windows.Forms.ComboBox();
            this.BExpenseSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BBack2Finance = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenditureNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenditureTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenditureNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ispDBDataSet6 = new Presentation_Layer.IspDBDataSet6();
            this.expenTableTableAdapter = new Presentation_Layer.IspDBDataSet6TableAdapters.ExpenTableTableAdapter();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ispDBDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.SeaGreen;
            this.bunifuCards1.Controls.Add(this.label4);
            this.bunifuCards1.Controls.Add(this.bunifuFlatButton3);
            this.bunifuCards1.Controls.Add(this.bunifuFlatButton2);
            this.bunifuCards1.Controls.Add(this.bunifuFlatButton1);
            this.bunifuCards1.Controls.Add(this.cBoxMonth);
            this.bunifuCards1.Controls.Add(this.CboxYear);
            this.bunifuCards1.Controls.Add(this.cBoxExtype);
            this.bunifuCards1.Controls.Add(this.BExpenseSearch);
            this.bunifuCards1.Controls.Add(this.label3);
            this.bunifuCards1.Controls.Add(this.label2);
            this.bunifuCards1.Controls.Add(this.label1);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(12, 79);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(407, 305);
            this.bunifuCards1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(52, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 18);
            this.label4.TabIndex = 29;
            this.label4.Text = "[To Search Month you must select Year]";
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "Clear";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(291, 254);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(106, 30);
            this.bunifuFlatButton3.TabIndex = 13;
            this.bunifuFlatButton3.Text = "Clear";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Search";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(291, 125);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(106, 30);
            this.bunifuFlatButton2.TabIndex = 12;
            this.bunifuFlatButton2.Text = "Search";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Search";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(291, 72);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(106, 30);
            this.bunifuFlatButton1.TabIndex = 11;
            this.bunifuFlatButton1.Text = "Search";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // cBoxMonth
            // 
            this.cBoxMonth.FormattingEnabled = true;
            this.cBoxMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cBoxMonth.Location = new System.Drawing.Point(159, 130);
            this.cBoxMonth.Name = "cBoxMonth";
            this.cBoxMonth.Size = new System.Drawing.Size(118, 21);
            this.cBoxMonth.TabIndex = 10;
            // 
            // CboxYear
            // 
            this.CboxYear.FormattingEnabled = true;
            this.CboxYear.Items.AddRange(new object[] {
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.CboxYear.Location = new System.Drawing.Point(159, 78);
            this.CboxYear.Name = "CboxYear";
            this.CboxYear.Size = new System.Drawing.Size(118, 21);
            this.CboxYear.TabIndex = 9;
            // 
            // cBoxExtype
            // 
            this.cBoxExtype.FormattingEnabled = true;
            this.cBoxExtype.Items.AddRange(new object[] {
            "Employee Salary",
            "Food",
            "Travel Cost",
            "Buy Item"});
            this.cBoxExtype.Location = new System.Drawing.Point(158, 25);
            this.cBoxExtype.Name = "cBoxExtype";
            this.cBoxExtype.Size = new System.Drawing.Size(118, 21);
            this.cBoxExtype.TabIndex = 8;
            // 
            // BExpenseSearch
            // 
            this.BExpenseSearch.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BExpenseSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BExpenseSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BExpenseSearch.BorderRadius = 0;
            this.BExpenseSearch.ButtonText = "Search";
            this.BExpenseSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BExpenseSearch.DisabledColor = System.Drawing.Color.Gray;
            this.BExpenseSearch.Iconcolor = System.Drawing.Color.Transparent;
            this.BExpenseSearch.Iconimage = ((System.Drawing.Image)(resources.GetObject("BExpenseSearch.Iconimage")));
            this.BExpenseSearch.Iconimage_right = null;
            this.BExpenseSearch.Iconimage_right_Selected = null;
            this.BExpenseSearch.Iconimage_Selected = null;
            this.BExpenseSearch.IconMarginLeft = 0;
            this.BExpenseSearch.IconMarginRight = 0;
            this.BExpenseSearch.IconRightVisible = true;
            this.BExpenseSearch.IconRightZoom = 0D;
            this.BExpenseSearch.IconVisible = true;
            this.BExpenseSearch.IconZoom = 90D;
            this.BExpenseSearch.IsTab = false;
            this.BExpenseSearch.Location = new System.Drawing.Point(291, 21);
            this.BExpenseSearch.Name = "BExpenseSearch";
            this.BExpenseSearch.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BExpenseSearch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BExpenseSearch.OnHoverTextColor = System.Drawing.Color.White;
            this.BExpenseSearch.selected = false;
            this.BExpenseSearch.Size = new System.Drawing.Size(106, 30);
            this.BExpenseSearch.TabIndex = 7;
            this.BExpenseSearch.Text = "Search";
            this.BExpenseSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BExpenseSearch.Textcolor = System.Drawing.Color.White;
            this.BExpenseSearch.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BExpenseSearch.Click += new System.EventHandler(this.BExpenseSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Select Month";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Year";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Expenditure Type";
            // 
            // BBack2Finance
            // 
            this.BBack2Finance.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BBack2Finance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.BBack2Finance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BBack2Finance.BorderRadius = 0;
            this.BBack2Finance.ButtonText = "Back";
            this.BBack2Finance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BBack2Finance.DisabledColor = System.Drawing.Color.Gray;
            this.BBack2Finance.Iconcolor = System.Drawing.Color.Transparent;
            this.BBack2Finance.Iconimage = ((System.Drawing.Image)(resources.GetObject("BBack2Finance.Iconimage")));
            this.BBack2Finance.Iconimage_right = null;
            this.BBack2Finance.Iconimage_right_Selected = null;
            this.BBack2Finance.Iconimage_Selected = null;
            this.BBack2Finance.IconMarginLeft = 0;
            this.BBack2Finance.IconMarginRight = 0;
            this.BBack2Finance.IconRightVisible = true;
            this.BBack2Finance.IconRightZoom = 0D;
            this.BBack2Finance.IconVisible = true;
            this.BBack2Finance.IconZoom = 90D;
            this.BBack2Finance.IsTab = false;
            this.BBack2Finance.Location = new System.Drawing.Point(15, 12);
            this.BBack2Finance.Name = "BBack2Finance";
            this.BBack2Finance.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.BBack2Finance.OnHovercolor = System.Drawing.Color.Teal;
            this.BBack2Finance.OnHoverTextColor = System.Drawing.Color.White;
            this.BBack2Finance.selected = false;
            this.BBack2Finance.Size = new System.Drawing.Size(102, 55);
            this.BBack2Finance.TabIndex = 12;
            this.BBack2Finance.Text = "Back";
            this.BBack2Finance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BBack2Finance.Textcolor = System.Drawing.Color.White;
            this.BBack2Finance.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBack2Finance.Click += new System.EventHandler(this.BBack2Finance_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.expenditureNumberDataGridViewTextBoxColumn,
            this.expenditureTypeDataGridViewTextBoxColumn,
            this.expenditureNameDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.monthDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.expenTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(425, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(590, 405);
            this.dataGridView1.TabIndex = 13;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // expenditureNumberDataGridViewTextBoxColumn
            // 
            this.expenditureNumberDataGridViewTextBoxColumn.DataPropertyName = "ExpenditureNumber";
            this.expenditureNumberDataGridViewTextBoxColumn.HeaderText = "ExpenditureNumber";
            this.expenditureNumberDataGridViewTextBoxColumn.Name = "expenditureNumberDataGridViewTextBoxColumn";
            this.expenditureNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expenditureTypeDataGridViewTextBoxColumn
            // 
            this.expenditureTypeDataGridViewTextBoxColumn.DataPropertyName = "ExpenditureType";
            this.expenditureTypeDataGridViewTextBoxColumn.HeaderText = "ExpenditureType";
            this.expenditureTypeDataGridViewTextBoxColumn.Name = "expenditureTypeDataGridViewTextBoxColumn";
            this.expenditureTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expenditureNameDataGridViewTextBoxColumn
            // 
            this.expenditureNameDataGridViewTextBoxColumn.DataPropertyName = "ExpenditureName";
            this.expenditureNameDataGridViewTextBoxColumn.HeaderText = "ExpenditureName";
            this.expenditureNameDataGridViewTextBoxColumn.Name = "expenditureNameDataGridViewTextBoxColumn";
            this.expenditureNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // monthDataGridViewTextBoxColumn
            // 
            this.monthDataGridViewTextBoxColumn.DataPropertyName = "Month";
            this.monthDataGridViewTextBoxColumn.HeaderText = "Month";
            this.monthDataGridViewTextBoxColumn.Name = "monthDataGridViewTextBoxColumn";
            this.monthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expenTableBindingSource
            // 
            this.expenTableBindingSource.DataMember = "ExpenTable";
            this.expenTableBindingSource.DataSource = this.ispDBDataSet6;
            // 
            // ispDBDataSet6
            // 
            this.ispDBDataSet6.DataSetName = "IspDBDataSet6";
            this.ispDBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // expenTableTableAdapter
            // 
            this.expenTableTableAdapter.ClearBeforeFill = true;
            // 
            // FTotalCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1027, 510);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BBack2Finance);
            this.Controls.Add(this.bunifuCards1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FTotalCost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Total Cost";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FTotalCost_FormClosing);
            this.Load += new System.EventHandler(this.FTotalCost_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ispDBDataSet6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuFlatButton BBack2Finance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton BExpenseSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private IspDBDataSet6 ispDBDataSet6;
        private System.Windows.Forms.BindingSource expenTableBindingSource;
        private IspDBDataSet6TableAdapters.ExpenTableTableAdapter expenTableTableAdapter;
        private System.Windows.Forms.ComboBox cBoxMonth;
        private System.Windows.Forms.ComboBox CboxYear;
        private System.Windows.Forms.ComboBox cBoxExtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expenditureNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expenditureTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expenditureNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private System.Windows.Forms.Label label4;
    }
}