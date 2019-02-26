namespace Presentation_Layer
{
    partial class FEmployeeSalary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FEmployeeSalary));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeSalaryUpdateTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ispDBDataSet12 = new Presentation_Layer.IspDBDataSet12();
            this.submit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BBack2Finance1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.empList = new System.Windows.Forms.ComboBox();
            this.empMonth = new System.Windows.Forms.ComboBox();
            this.empYear = new System.Windows.Forms.ComboBox();
            this.employeeSalaryUpdateTableTableAdapter = new Presentation_Layer.IspDBDataSet12TableAdapters.EmployeeSalaryUpdateTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalaryUpdateTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ispDBDataSet12)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(8, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Month";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(8, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Employee List";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(8, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Year";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.monthDataGridViewTextBoxColumn,
            this.paidStatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeeSalaryUpdateTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(380, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(410, 312);
            this.dataGridView1.TabIndex = 7;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.ReadOnly = true;
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
            // paidStatusDataGridViewTextBoxColumn
            // 
            this.paidStatusDataGridViewTextBoxColumn.DataPropertyName = "PaidStatus";
            this.paidStatusDataGridViewTextBoxColumn.HeaderText = "PaidStatus";
            this.paidStatusDataGridViewTextBoxColumn.Name = "paidStatusDataGridViewTextBoxColumn";
            this.paidStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeSalaryUpdateTableBindingSource
            // 
            this.employeeSalaryUpdateTableBindingSource.DataMember = "EmployeeSalaryUpdateTable";
            this.employeeSalaryUpdateTableBindingSource.DataSource = this.ispDBDataSet12;
            // 
            // ispDBDataSet12
            // 
            this.ispDBDataSet12.DataSetName = "IspDBDataSet12";
            this.ispDBDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.submit.Location = new System.Drawing.Point(231, 338);
            this.submit.Name = "submit";
            this.submit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.submit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.submit.OnHoverTextColor = System.Drawing.Color.White;
            this.submit.selected = false;
            this.submit.Size = new System.Drawing.Size(128, 48);
            this.submit.TabIndex = 8;
            this.submit.Text = "Submit";
            this.submit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.submit.Textcolor = System.Drawing.Color.White;
            this.submit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // BBack2Finance1
            // 
            this.BBack2Finance1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BBack2Finance1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.BBack2Finance1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BBack2Finance1.BorderRadius = 0;
            this.BBack2Finance1.ButtonText = "Back";
            this.BBack2Finance1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BBack2Finance1.DisabledColor = System.Drawing.Color.Gray;
            this.BBack2Finance1.Iconcolor = System.Drawing.Color.Transparent;
            this.BBack2Finance1.Iconimage = ((System.Drawing.Image)(resources.GetObject("BBack2Finance1.Iconimage")));
            this.BBack2Finance1.Iconimage_right = null;
            this.BBack2Finance1.Iconimage_right_Selected = null;
            this.BBack2Finance1.Iconimage_Selected = null;
            this.BBack2Finance1.IconMarginLeft = 0;
            this.BBack2Finance1.IconMarginRight = 0;
            this.BBack2Finance1.IconRightVisible = true;
            this.BBack2Finance1.IconRightZoom = 0D;
            this.BBack2Finance1.IconVisible = true;
            this.BBack2Finance1.IconZoom = 90D;
            this.BBack2Finance1.IsTab = false;
            this.BBack2Finance1.Location = new System.Drawing.Point(12, 12);
            this.BBack2Finance1.Name = "BBack2Finance1";
            this.BBack2Finance1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.BBack2Finance1.OnHovercolor = System.Drawing.Color.Teal;
            this.BBack2Finance1.OnHoverTextColor = System.Drawing.Color.White;
            this.BBack2Finance1.selected = false;
            this.BBack2Finance1.Size = new System.Drawing.Size(102, 55);
            this.BBack2Finance1.TabIndex = 9;
            this.BBack2Finance1.Text = "Back";
            this.BBack2Finance1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BBack2Finance1.Textcolor = System.Drawing.Color.White;
            this.BBack2Finance1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBack2Finance1.Click += new System.EventHandler(this.BBack2ManageEmployee_Click);
            // 
            // empList
            // 
            this.empList.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empList.FormattingEnabled = true;
            this.empList.Location = new System.Drawing.Point(156, 75);
            this.empList.Name = "empList";
            this.empList.Size = new System.Drawing.Size(188, 27);
            this.empList.TabIndex = 10;
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
            this.empMonth.Location = new System.Drawing.Point(156, 158);
            this.empMonth.Name = "empMonth";
            this.empMonth.Size = new System.Drawing.Size(188, 27);
            this.empMonth.TabIndex = 11;
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
            this.empYear.Location = new System.Drawing.Point(156, 117);
            this.empYear.Name = "empYear";
            this.empYear.Size = new System.Drawing.Size(188, 27);
            this.empYear.TabIndex = 12;
            // 
            // employeeSalaryUpdateTableTableAdapter
            // 
            this.employeeSalaryUpdateTableTableAdapter.ClearBeforeFill = true;
            // 
            // FEmployeeSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(817, 398);
            this.Controls.Add(this.empYear);
            this.Controls.Add(this.empMonth);
            this.Controls.Add(this.empList);
            this.Controls.Add(this.BBack2Finance1);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FEmployeeSalary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Salary";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FEmployeeSalary_FormClosing);
            this.Load += new System.EventHandler(this.FEmployeeSalary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalaryUpdateTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ispDBDataSet12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuFlatButton submit;
        private Bunifu.Framework.UI.BunifuFlatButton BBack2Finance1;
        private System.Windows.Forms.ComboBox empList;
        private System.Windows.Forms.ComboBox empMonth;
        private System.Windows.Forms.ComboBox empYear;
        private IspDBDataSet12 ispDBDataSet12;
        private System.Windows.Forms.BindingSource employeeSalaryUpdateTableBindingSource;
        private IspDBDataSet12TableAdapters.EmployeeSalaryUpdateTableTableAdapter employeeSalaryUpdateTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidStatusDataGridViewTextBoxColumn;
    }
}