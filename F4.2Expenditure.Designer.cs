namespace Presentation_Layer
{
    partial class FExpenditure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FExpenditure));
            this.label1 = new System.Windows.Forms.Label();
            this.TExNo = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.TExAmount = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.TExName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.BAddExpenditure = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenditureNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenditureTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenditureNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ispDBDataSet1 = new Presentation_Layer.IspDBDataSet1();
            this.expenTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ispDBDataSet = new Presentation_Layer.IspDBDataSet();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.BsearchEx = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TExSearch = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.BClear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BExUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BBack2Finance = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.expenTableTableAdapter = new Presentation_Layer.IspDBDataSetTableAdapters.ExpenTableTableAdapter();
            this.expenTableTableAdapter1 = new Presentation_Layer.IspDBDataSet1TableAdapters.ExpenTableTableAdapter();
            this.DropExpenditureType = new System.Windows.Forms.ComboBox();
            this.DYear = new System.Windows.Forms.ComboBox();
            this.DropMonth = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ispDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ispDBDataSet)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(21, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Expenditure No";
            // 
            // TExNo
            // 
            this.TExNo.BorderColorFocused = System.Drawing.Color.Blue;
            this.TExNo.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TExNo.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.TExNo.BorderThickness = 3;
            this.TExNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TExNo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TExNo.ForeColor = System.Drawing.Color.White;
            this.TExNo.isPassword = false;
            this.TExNo.Location = new System.Drawing.Point(162, 70);
            this.TExNo.Margin = new System.Windows.Forms.Padding(4);
            this.TExNo.Name = "TExNo";
            this.TExNo.Size = new System.Drawing.Size(167, 34);
            this.TExNo.TabIndex = 1;
            this.TExNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(21, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Expenditure Type";
            // 
            // TExAmount
            // 
            this.TExAmount.BorderColorFocused = System.Drawing.Color.Blue;
            this.TExAmount.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TExAmount.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.TExAmount.BorderThickness = 3;
            this.TExAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TExAmount.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TExAmount.ForeColor = System.Drawing.Color.White;
            this.TExAmount.isPassword = false;
            this.TExAmount.Location = new System.Drawing.Point(162, 319);
            this.TExAmount.Margin = new System.Windows.Forms.Padding(4);
            this.TExAmount.Name = "TExAmount";
            this.TExAmount.Size = new System.Drawing.Size(167, 34);
            this.TExAmount.TabIndex = 7;
            this.TExAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(21, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Amount";
            // 
            // TExName
            // 
            this.TExName.BorderColorFocused = System.Drawing.Color.Blue;
            this.TExName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TExName.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.TExName.BorderThickness = 3;
            this.TExName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TExName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TExName.ForeColor = System.Drawing.Color.White;
            this.TExName.isPassword = false;
            this.TExName.Location = new System.Drawing.Point(162, 172);
            this.TExName.Margin = new System.Windows.Forms.Padding(4);
            this.TExName.Name = "TExName";
            this.TExName.Size = new System.Drawing.Size(167, 34);
            this.TExName.TabIndex = 5;
            this.TExName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(21, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Expenditure Name";
            // 
            // BAddExpenditure
            // 
            this.BAddExpenditure.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BAddExpenditure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BAddExpenditure.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BAddExpenditure.BorderRadius = 0;
            this.BAddExpenditure.ButtonText = "Add Expenditure";
            this.BAddExpenditure.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BAddExpenditure.DisabledColor = System.Drawing.Color.Gray;
            this.BAddExpenditure.Iconcolor = System.Drawing.Color.Transparent;
            this.BAddExpenditure.Iconimage = ((System.Drawing.Image)(resources.GetObject("BAddExpenditure.Iconimage")));
            this.BAddExpenditure.Iconimage_right = null;
            this.BAddExpenditure.Iconimage_right_Selected = null;
            this.BAddExpenditure.Iconimage_Selected = null;
            this.BAddExpenditure.IconMarginLeft = 0;
            this.BAddExpenditure.IconMarginRight = 0;
            this.BAddExpenditure.IconRightVisible = true;
            this.BAddExpenditure.IconRightZoom = 0D;
            this.BAddExpenditure.IconVisible = true;
            this.BAddExpenditure.IconZoom = 90D;
            this.BAddExpenditure.IsTab = false;
            this.BAddExpenditure.Location = new System.Drawing.Point(162, 370);
            this.BAddExpenditure.Name = "BAddExpenditure";
            this.BAddExpenditure.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BAddExpenditure.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BAddExpenditure.OnHoverTextColor = System.Drawing.Color.White;
            this.BAddExpenditure.selected = false;
            this.BAddExpenditure.Size = new System.Drawing.Size(167, 48);
            this.BAddExpenditure.TabIndex = 8;
            this.BAddExpenditure.Text = "Add Expenditure";
            this.BAddExpenditure.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BAddExpenditure.Textcolor = System.Drawing.Color.White;
            this.BAddExpenditure.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAddExpenditure.Click += new System.EventHandler(this.BAddExpenditure_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.expenditureNumberDataGridViewTextBoxColumn,
            this.expenditureTypeDataGridViewTextBoxColumn,
            this.expenditureNameDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.monthDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.expenTableBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(352, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(509, 249);
            this.dataGridView1.TabIndex = 9;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // expenditureNumberDataGridViewTextBoxColumn
            // 
            this.expenditureNumberDataGridViewTextBoxColumn.DataPropertyName = "ExpenditureNumber";
            this.expenditureNumberDataGridViewTextBoxColumn.HeaderText = "ExpenditureNumber";
            this.expenditureNumberDataGridViewTextBoxColumn.Name = "expenditureNumberDataGridViewTextBoxColumn";
            // 
            // expenditureTypeDataGridViewTextBoxColumn
            // 
            this.expenditureTypeDataGridViewTextBoxColumn.DataPropertyName = "ExpenditureType";
            this.expenditureTypeDataGridViewTextBoxColumn.HeaderText = "ExpenditureType";
            this.expenditureTypeDataGridViewTextBoxColumn.Name = "expenditureTypeDataGridViewTextBoxColumn";
            // 
            // expenditureNameDataGridViewTextBoxColumn
            // 
            this.expenditureNameDataGridViewTextBoxColumn.DataPropertyName = "ExpenditureName";
            this.expenditureNameDataGridViewTextBoxColumn.HeaderText = "ExpenditureName";
            this.expenditureNameDataGridViewTextBoxColumn.Name = "expenditureNameDataGridViewTextBoxColumn";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.Width = 50;
            // 
            // monthDataGridViewTextBoxColumn
            // 
            this.monthDataGridViewTextBoxColumn.DataPropertyName = "Month";
            this.monthDataGridViewTextBoxColumn.HeaderText = "Month";
            this.monthDataGridViewTextBoxColumn.Name = "monthDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // expenTableBindingSource1
            // 
            this.expenTableBindingSource1.DataMember = "ExpenTable";
            this.expenTableBindingSource1.DataSource = this.ispDBDataSet1;
            // 
            // ispDBDataSet1
            // 
            this.ispDBDataSet1.DataSetName = "IspDBDataSet1";
            this.ispDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // expenTableBindingSource
            // 
            this.expenTableBindingSource.DataMember = "ExpenTable";
            this.expenTableBindingSource.DataSource = this.ispDBDataSet;
            // 
            // ispDBDataSet
            // 
            this.ispDBDataSet.DataSetName = "IspDBDataSet";
            this.ispDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.Controls.Add(this.bunifuSeparator1);
            this.bunifuCards1.Controls.Add(this.BsearchEx);
            this.bunifuCards1.Controls.Add(this.TExSearch);
            this.bunifuCards1.Controls.Add(this.label5);
            this.bunifuCards1.Controls.Add(this.BClear);
            this.bunifuCards1.Controls.Add(this.bunifuFlatButton3);
            this.bunifuCards1.Controls.Add(this.BExUpdate);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(352, 346);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(381, 232);
            this.bunifuCards1.TabIndex = 10;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(17, 105);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(338, 8);
            this.bunifuSeparator1.TabIndex = 16;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // BsearchEx
            // 
            this.BsearchEx.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BsearchEx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BsearchEx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BsearchEx.BorderRadius = 0;
            this.BsearchEx.ButtonText = "Search";
            this.BsearchEx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BsearchEx.DisabledColor = System.Drawing.Color.Gray;
            this.BsearchEx.Iconcolor = System.Drawing.Color.Transparent;
            this.BsearchEx.Iconimage = ((System.Drawing.Image)(resources.GetObject("BsearchEx.Iconimage")));
            this.BsearchEx.Iconimage_right = null;
            this.BsearchEx.Iconimage_right_Selected = null;
            this.BsearchEx.Iconimage_Selected = null;
            this.BsearchEx.IconMarginLeft = 0;
            this.BsearchEx.IconMarginRight = 0;
            this.BsearchEx.IconRightVisible = true;
            this.BsearchEx.IconRightZoom = 0D;
            this.BsearchEx.IconVisible = true;
            this.BsearchEx.IconZoom = 90D;
            this.BsearchEx.IsTab = false;
            this.BsearchEx.Location = new System.Drawing.Point(192, 57);
            this.BsearchEx.Name = "BsearchEx";
            this.BsearchEx.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BsearchEx.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BsearchEx.OnHoverTextColor = System.Drawing.Color.White;
            this.BsearchEx.selected = false;
            this.BsearchEx.Size = new System.Drawing.Size(163, 37);
            this.BsearchEx.TabIndex = 15;
            this.BsearchEx.Text = "Search";
            this.BsearchEx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BsearchEx.Textcolor = System.Drawing.Color.White;
            this.BsearchEx.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BsearchEx.Click += new System.EventHandler(this.BsearchEx_Click);
            // 
            // TExSearch
            // 
            this.TExSearch.BorderColorFocused = System.Drawing.Color.Blue;
            this.TExSearch.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TExSearch.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.TExSearch.BorderThickness = 3;
            this.TExSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TExSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TExSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TExSearch.isPassword = false;
            this.TExSearch.Location = new System.Drawing.Point(192, 15);
            this.TExSearch.Margin = new System.Windows.Forms.Padding(4);
            this.TExSearch.Name = "TExSearch";
            this.TExSearch.Size = new System.Drawing.Size(165, 35);
            this.TExSearch.TabIndex = 14;
            this.TExSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Search Entry [Enter ID]";
            // 
            // BClear
            // 
            this.BClear.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BClear.BorderRadius = 0;
            this.BClear.ButtonText = "Clear Field";
            this.BClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BClear.DisabledColor = System.Drawing.Color.Gray;
            this.BClear.Iconcolor = System.Drawing.Color.Transparent;
            this.BClear.Iconimage = ((System.Drawing.Image)(resources.GetObject("BClear.Iconimage")));
            this.BClear.Iconimage_right = null;
            this.BClear.Iconimage_right_Selected = null;
            this.BClear.Iconimage_Selected = null;
            this.BClear.IconMarginLeft = 0;
            this.BClear.IconMarginRight = 0;
            this.BClear.IconRightVisible = true;
            this.BClear.IconRightZoom = 0D;
            this.BClear.IconVisible = true;
            this.BClear.IconZoom = 90D;
            this.BClear.IsTab = false;
            this.BClear.Location = new System.Drawing.Point(17, 172);
            this.BClear.Name = "BClear";
            this.BClear.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BClear.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BClear.OnHoverTextColor = System.Drawing.Color.White;
            this.BClear.selected = false;
            this.BClear.Size = new System.Drawing.Size(167, 48);
            this.BClear.TabIndex = 11;
            this.BClear.Text = "Clear Field";
            this.BClear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BClear.Textcolor = System.Drawing.Color.White;
            this.BClear.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BClear.Click += new System.EventHandler(this.BClear_Click);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "Delete Entry";
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
            this.bunifuFlatButton3.Location = new System.Drawing.Point(17, 119);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(167, 48);
            this.bunifuFlatButton3.TabIndex = 10;
            this.bunifuFlatButton3.Text = "Delete Entry";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // BExUpdate
            // 
            this.BExUpdate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BExUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BExUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BExUpdate.BorderRadius = 0;
            this.BExUpdate.ButtonText = "Update Entry";
            this.BExUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BExUpdate.DisabledColor = System.Drawing.Color.Gray;
            this.BExUpdate.Iconcolor = System.Drawing.Color.Transparent;
            this.BExUpdate.Iconimage = ((System.Drawing.Image)(resources.GetObject("BExUpdate.Iconimage")));
            this.BExUpdate.Iconimage_right = null;
            this.BExUpdate.Iconimage_right_Selected = null;
            this.BExUpdate.Iconimage_Selected = null;
            this.BExUpdate.IconMarginLeft = 0;
            this.BExUpdate.IconMarginRight = 0;
            this.BExUpdate.IconRightVisible = true;
            this.BExUpdate.IconRightZoom = 0D;
            this.BExUpdate.IconVisible = true;
            this.BExUpdate.IconZoom = 90D;
            this.BExUpdate.IsTab = false;
            this.BExUpdate.Location = new System.Drawing.Point(190, 172);
            this.BExUpdate.Name = "BExUpdate";
            this.BExUpdate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BExUpdate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BExUpdate.OnHoverTextColor = System.Drawing.Color.White;
            this.BExUpdate.selected = false;
            this.BExUpdate.Size = new System.Drawing.Size(167, 48);
            this.BExUpdate.TabIndex = 9;
            this.BExUpdate.Text = "Update Entry";
            this.BExUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BExUpdate.Textcolor = System.Drawing.Color.White;
            this.BExUpdate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BExUpdate.Click += new System.EventHandler(this.BExUpdate_Click);
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
            this.BBack2Finance.Location = new System.Drawing.Point(25, 12);
            this.BBack2Finance.Name = "BBack2Finance";
            this.BBack2Finance.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.BBack2Finance.OnHovercolor = System.Drawing.Color.Teal;
            this.BBack2Finance.OnHoverTextColor = System.Drawing.Color.White;
            this.BBack2Finance.selected = false;
            this.BBack2Finance.Size = new System.Drawing.Size(102, 55);
            this.BBack2Finance.TabIndex = 11;
            this.BBack2Finance.Text = "Back";
            this.BBack2Finance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BBack2Finance.Textcolor = System.Drawing.Color.White;
            this.BBack2Finance.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBack2Finance.Click += new System.EventHandler(this.BBack2Finance_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(21, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Year";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(21, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Month";
            // 
            // expenTableTableAdapter
            // 
            this.expenTableTableAdapter.ClearBeforeFill = true;
            // 
            // expenTableTableAdapter1
            // 
            this.expenTableTableAdapter1.ClearBeforeFill = true;
            // 
            // DropExpenditureType
            // 
            this.DropExpenditureType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DropExpenditureType.FormattingEnabled = true;
            this.DropExpenditureType.Items.AddRange(new object[] {
            "Employee Salary",
            "Food",
            "Travel Cost",
            "Buy Item"});
            this.DropExpenditureType.Location = new System.Drawing.Point(162, 129);
            this.DropExpenditureType.Name = "DropExpenditureType";
            this.DropExpenditureType.Size = new System.Drawing.Size(167, 26);
            this.DropExpenditureType.TabIndex = 19;
            // 
            // DYear
            // 
            this.DYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DYear.FormattingEnabled = true;
            this.DYear.Items.AddRange(new object[] {
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
            this.DYear.Location = new System.Drawing.Point(162, 226);
            this.DYear.Name = "DYear";
            this.DYear.Size = new System.Drawing.Size(167, 26);
            this.DYear.TabIndex = 20;
            // 
            // DropMonth
            // 
            this.DropMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DropMonth.FormattingEnabled = true;
            this.DropMonth.Items.AddRange(new object[] {
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
            this.DropMonth.Location = new System.Drawing.Point(162, 274);
            this.DropMonth.Name = "DropMonth";
            this.DropMonth.Size = new System.Drawing.Size(167, 26);
            this.DropMonth.TabIndex = 21;
            // 
            // FExpenditure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(873, 599);
            this.Controls.Add(this.DropMonth);
            this.Controls.Add(this.DYear);
            this.Controls.Add(this.DropExpenditureType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BBack2Finance);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BAddExpenditure);
            this.Controls.Add(this.TExAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TExName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TExNo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FExpenditure";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expenditure";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FExpenditure_FormClosing);
            this.Load += new System.EventHandler(this.FExpenditure_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ispDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ispDBDataSet)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox TExNo;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox TExAmount;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox TExName;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuFlatButton BAddExpenditure;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuFlatButton BClear;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton BExUpdate;
        private Bunifu.Framework.UI.BunifuFlatButton BBack2Finance;
        private Bunifu.Framework.UI.BunifuFlatButton BsearchEx;
        private Bunifu.Framework.UI.BunifuMetroTextbox TExSearch;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private IspDBDataSet ispDBDataSet;
        private System.Windows.Forms.BindingSource expenTableBindingSource;
        private IspDBDataSetTableAdapters.ExpenTableTableAdapter expenTableTableAdapter;
        private IspDBDataSet1 ispDBDataSet1;
        private System.Windows.Forms.BindingSource expenTableBindingSource1;
        private IspDBDataSet1TableAdapters.ExpenTableTableAdapter expenTableTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn expenditureNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expenditureTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expenditureNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox DropExpenditureType;
        private System.Windows.Forms.ComboBox DYear;
        private System.Windows.Forms.ComboBox DropMonth;
    }
}