namespace Presentation_Layer
{
    partial class FDuePayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDuePayment));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BBackHome = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerMonthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPaidTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ispDBDataSet13 = new Presentation_Layer.IspDBDataSet13();
            this.empYear = new System.Windows.Forms.ComboBox();
            this.empMonth = new System.Windows.Forms.ComboBox();
            this.empList = new System.Windows.Forms.ComboBox();
            this.submit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.customerPaidTableTableAdapter = new Presentation_Layer.IspDBDataSet13TableAdapters.CustomerPaidTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerPaidTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ispDBDataSet13)).BeginInit();
            this.SuspendLayout();
            // 
            // BBackHome
            // 
            this.BBackHome.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BBackHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.BBackHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BBackHome.BorderRadius = 0;
            this.BBackHome.ButtonText = "Back";
            this.BBackHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BBackHome.DisabledColor = System.Drawing.Color.Gray;
            this.BBackHome.Iconcolor = System.Drawing.Color.Transparent;
            this.BBackHome.Iconimage = ((System.Drawing.Image)(resources.GetObject("BBackHome.Iconimage")));
            this.BBackHome.Iconimage_right = null;
            this.BBackHome.Iconimage_right_Selected = null;
            this.BBackHome.Iconimage_Selected = null;
            this.BBackHome.IconMarginLeft = 0;
            this.BBackHome.IconMarginRight = 0;
            this.BBackHome.IconRightVisible = true;
            this.BBackHome.IconRightZoom = 0D;
            this.BBackHome.IconVisible = true;
            this.BBackHome.IconZoom = 90D;
            this.BBackHome.IsTab = false;
            this.BBackHome.Location = new System.Drawing.Point(12, 12);
            this.BBackHome.Name = "BBackHome";
            this.BBackHome.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.BBackHome.OnHovercolor = System.Drawing.Color.Teal;
            this.BBackHome.OnHoverTextColor = System.Drawing.Color.White;
            this.BBackHome.selected = false;
            this.BBackHome.Size = new System.Drawing.Size(102, 55);
            this.BBackHome.TabIndex = 5;
            this.BBackHome.Text = "Back";
            this.BBackHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BBackHome.Textcolor = System.Drawing.Color.White;
            this.BBackHome.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBackHome.Click += new System.EventHandler(this.BBackHome_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.customerYearDataGridViewTextBoxColumn,
            this.customerMonthDataGridViewTextBoxColumn,
            this.paidStatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customerPaidTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(375, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Size = new System.Drawing.Size(437, 401);
            this.dataGridView1.TabIndex = 10;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerYearDataGridViewTextBoxColumn
            // 
            this.customerYearDataGridViewTextBoxColumn.DataPropertyName = "CustomerYear";
            this.customerYearDataGridViewTextBoxColumn.HeaderText = "CustomerYear";
            this.customerYearDataGridViewTextBoxColumn.Name = "customerYearDataGridViewTextBoxColumn";
            this.customerYearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerMonthDataGridViewTextBoxColumn
            // 
            this.customerMonthDataGridViewTextBoxColumn.DataPropertyName = "CustomerMonth";
            this.customerMonthDataGridViewTextBoxColumn.HeaderText = "CustomerMonth";
            this.customerMonthDataGridViewTextBoxColumn.Name = "customerMonthDataGridViewTextBoxColumn";
            this.customerMonthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paidStatusDataGridViewTextBoxColumn
            // 
            this.paidStatusDataGridViewTextBoxColumn.DataPropertyName = "PaidStatus";
            this.paidStatusDataGridViewTextBoxColumn.HeaderText = "PaidStatus";
            this.paidStatusDataGridViewTextBoxColumn.Name = "paidStatusDataGridViewTextBoxColumn";
            this.paidStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerPaidTableBindingSource
            // 
            this.customerPaidTableBindingSource.DataMember = "CustomerPaidTable";
            this.customerPaidTableBindingSource.DataSource = this.ispDBDataSet13;
            // 
            // ispDBDataSet13
            // 
            this.ispDBDataSet13.DataSetName = "IspDBDataSet13";
            this.ispDBDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empYear
            // 
            this.empYear.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empYear.FormattingEnabled = true;
            this.empYear.Items.AddRange(new object[] {
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
            this.empYear.Location = new System.Drawing.Point(160, 125);
            this.empYear.Name = "empYear";
            this.empYear.Size = new System.Drawing.Size(188, 27);
            this.empYear.TabIndex = 19;
            // 
            // empMonth
            // 
            this.empMonth.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empMonth.FormattingEnabled = true;
            this.empMonth.Items.AddRange(new object[] {
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
            this.empMonth.Location = new System.Drawing.Point(160, 166);
            this.empMonth.Name = "empMonth";
            this.empMonth.Size = new System.Drawing.Size(188, 27);
            this.empMonth.TabIndex = 18;
            // 
            // empList
            // 
            this.empList.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empList.FormattingEnabled = true;
            this.empList.Location = new System.Drawing.Point(160, 83);
            this.empList.Name = "empList";
            this.empList.Size = new System.Drawing.Size(188, 27);
            this.empList.TabIndex = 17;
            // 
            // submit
            // 
            this.submit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.submit.BorderRadius = 0;
            this.submit.ButtonText = "Submit";
            this.submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submit.DisabledColor = System.Drawing.Color.Gray;
            this.submit.Iconcolor = System.Drawing.Color.Transparent;
            this.submit.Iconimage = ((System.Drawing.Image)(resources.GetObject("submit.Iconimage")));
            this.submit.Iconimage_right = null;
            this.submit.Iconimage_right_Selected = null;
            this.submit.Iconimage_Selected = null;
            this.submit.IconMarginLeft = 0;
            this.submit.IconMarginRight = 0;
            this.submit.IconRightVisible = true;
            this.submit.IconRightZoom = 0D;
            this.submit.IconVisible = true;
            this.submit.IconZoom = 90D;
            this.submit.IsTab = false;
            this.submit.Location = new System.Drawing.Point(220, 228);
            this.submit.Name = "submit";
            this.submit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.submit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.submit.OnHoverTextColor = System.Drawing.Color.White;
            this.submit.selected = false;
            this.submit.Size = new System.Drawing.Size(128, 48);
            this.submit.TabIndex = 16;
            this.submit.Text = "Submit";
            this.submit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.submit.Textcolor = System.Drawing.Color.White;
            this.submit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Customer List";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Month";
            // 
            // customerPaidTableTableAdapter
            // 
            this.customerPaidTableTableAdapter.ClearBeforeFill = true;
            // 
            // FDuePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(841, 517);
            this.Controls.Add(this.empYear);
            this.Controls.Add(this.empMonth);
            this.Controls.Add(this.empList);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BBackHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FDuePayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Due Payments";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FDuePayment_FormClosing);
            this.Load += new System.EventHandler(this.FDuePayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerPaidTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ispDBDataSet13)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton BBackHome;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox empYear;
        private System.Windows.Forms.ComboBox empMonth;
        private System.Windows.Forms.ComboBox empList;
        private Bunifu.Framework.UI.BunifuFlatButton submit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private IspDBDataSet13 ispDBDataSet13;
        private System.Windows.Forms.BindingSource customerPaidTableBindingSource;
        private IspDBDataSet13TableAdapters.CustomerPaidTableTableAdapter customerPaidTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerMonthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidStatusDataGridViewTextBoxColumn;
    }
}