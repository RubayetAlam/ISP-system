namespace Presentation_Layer
{
    partial class FAllPaymentList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAllPaymentList));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerMonthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPaidTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ispDBDataSet14 = new Presentation_Layer.IspDBDataSet14();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BBackManagePayment12 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.comboBoxCustomer = new System.Windows.Forms.ComboBox();
            this.customerPaidTableTableAdapter = new Presentation_Layer.IspDBDataSet14TableAdapters.CustomerPaidTableTableAdapter();
            this.btnYear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMonth = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCustomer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerPaidTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ispDBDataSet14)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(344, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Size = new System.Drawing.Size(441, 401);
            this.dataGridView1.TabIndex = 16;
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
            this.customerPaidTableBindingSource.DataSource = this.ispDBDataSet14;
            // 
            // ispDBDataSet14
            // 
            this.ispDBDataSet14.DataSetName = "IspDBDataSet14";
            this.ispDBDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(16, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Select Month";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(16, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Select Year";
            // 
            // BBackManagePayment12
            // 
            this.BBackManagePayment12.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BBackManagePayment12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.BBackManagePayment12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BBackManagePayment12.BorderRadius = 0;
            this.BBackManagePayment12.ButtonText = "Back";
            this.BBackManagePayment12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BBackManagePayment12.DisabledColor = System.Drawing.Color.Gray;
            this.BBackManagePayment12.Iconcolor = System.Drawing.Color.Transparent;
            this.BBackManagePayment12.Iconimage = ((System.Drawing.Image)(resources.GetObject("BBackManagePayment12.Iconimage")));
            this.BBackManagePayment12.Iconimage_right = null;
            this.BBackManagePayment12.Iconimage_right_Selected = null;
            this.BBackManagePayment12.Iconimage_Selected = null;
            this.BBackManagePayment12.IconMarginLeft = 0;
            this.BBackManagePayment12.IconMarginRight = 0;
            this.BBackManagePayment12.IconRightVisible = true;
            this.BBackManagePayment12.IconRightZoom = 0D;
            this.BBackManagePayment12.IconVisible = true;
            this.BBackManagePayment12.IconZoom = 90D;
            this.BBackManagePayment12.IsTab = false;
            this.BBackManagePayment12.Location = new System.Drawing.Point(16, 12);
            this.BBackManagePayment12.Name = "BBackManagePayment12";
            this.BBackManagePayment12.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.BBackManagePayment12.OnHovercolor = System.Drawing.Color.Teal;
            this.BBackManagePayment12.OnHoverTextColor = System.Drawing.Color.White;
            this.BBackManagePayment12.selected = false;
            this.BBackManagePayment12.Size = new System.Drawing.Size(102, 55);
            this.BBackManagePayment12.TabIndex = 11;
            this.BBackManagePayment12.Text = "Back";
            this.BBackManagePayment12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BBackManagePayment12.Textcolor = System.Drawing.Color.White;
            this.BBackManagePayment12.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBackManagePayment12.Click += new System.EventHandler(this.BBackManagePayment12_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(20, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "Customer";
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Items.AddRange(new object[] {
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
            this.comboBoxYear.Location = new System.Drawing.Point(20, 124);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(161, 21);
            this.comboBoxYear.TabIndex = 21;
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Items.AddRange(new object[] {
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
            this.comboBoxMonth.Location = new System.Drawing.Point(20, 219);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(161, 21);
            this.comboBoxMonth.TabIndex = 22;
            // 
            // comboBoxCustomer
            // 
            this.comboBoxCustomer.FormattingEnabled = true;
            this.comboBoxCustomer.Location = new System.Drawing.Point(20, 370);
            this.comboBoxCustomer.Name = "comboBoxCustomer";
            this.comboBoxCustomer.Size = new System.Drawing.Size(161, 21);
            this.comboBoxCustomer.TabIndex = 23;
            // 
            // customerPaidTableTableAdapter
            // 
            this.customerPaidTableTableAdapter.ClearBeforeFill = true;
            // 
            // btnYear
            // 
            this.btnYear.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnYear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYear.BorderRadius = 0;
            this.btnYear.ButtonText = "Search";
            this.btnYear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYear.DisabledColor = System.Drawing.Color.Gray;
            this.btnYear.Iconcolor = System.Drawing.Color.Transparent;
            this.btnYear.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnYear.Iconimage")));
            this.btnYear.Iconimage_right = null;
            this.btnYear.Iconimage_right_Selected = null;
            this.btnYear.Iconimage_Selected = null;
            this.btnYear.IconMarginLeft = 0;
            this.btnYear.IconMarginRight = 0;
            this.btnYear.IconRightVisible = true;
            this.btnYear.IconRightZoom = 0D;
            this.btnYear.IconVisible = true;
            this.btnYear.IconZoom = 90D;
            this.btnYear.IsTab = false;
            this.btnYear.Location = new System.Drawing.Point(210, 118);
            this.btnYear.Name = "btnYear";
            this.btnYear.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnYear.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnYear.OnHoverTextColor = System.Drawing.Color.White;
            this.btnYear.selected = false;
            this.btnYear.Size = new System.Drawing.Size(128, 35);
            this.btnYear.TabIndex = 25;
            this.btnYear.Text = "Search";
            this.btnYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYear.Textcolor = System.Drawing.Color.White;
            this.btnYear.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYear.Click += new System.EventHandler(this.btnYear_Click);
            // 
            // btnMonth
            // 
            this.btnMonth.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnMonth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMonth.BorderRadius = 0;
            this.btnMonth.ButtonText = "Search";
            this.btnMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMonth.DisabledColor = System.Drawing.Color.Gray;
            this.btnMonth.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMonth.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMonth.Iconimage")));
            this.btnMonth.Iconimage_right = null;
            this.btnMonth.Iconimage_right_Selected = null;
            this.btnMonth.Iconimage_Selected = null;
            this.btnMonth.IconMarginLeft = 0;
            this.btnMonth.IconMarginRight = 0;
            this.btnMonth.IconRightVisible = true;
            this.btnMonth.IconRightZoom = 0D;
            this.btnMonth.IconVisible = true;
            this.btnMonth.IconZoom = 90D;
            this.btnMonth.IsTab = false;
            this.btnMonth.Location = new System.Drawing.Point(210, 212);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnMonth.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnMonth.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMonth.selected = false;
            this.btnMonth.Size = new System.Drawing.Size(128, 35);
            this.btnMonth.TabIndex = 26;
            this.btnMonth.Text = "Search";
            this.btnMonth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonth.Textcolor = System.Drawing.Color.White;
            this.btnMonth.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonth.Click += new System.EventHandler(this.btnMonth_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCustomer.BorderRadius = 0;
            this.btnCustomer.ButtonText = "Search";
            this.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomer.DisabledColor = System.Drawing.Color.Gray;
            this.btnCustomer.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCustomer.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCustomer.Iconimage")));
            this.btnCustomer.Iconimage_right = null;
            this.btnCustomer.Iconimage_right_Selected = null;
            this.btnCustomer.Iconimage_Selected = null;
            this.btnCustomer.IconMarginLeft = 0;
            this.btnCustomer.IconMarginRight = 0;
            this.btnCustomer.IconRightVisible = true;
            this.btnCustomer.IconRightZoom = 0D;
            this.btnCustomer.IconVisible = true;
            this.btnCustomer.IconZoom = 90D;
            this.btnCustomer.IsTab = false;
            this.btnCustomer.Location = new System.Drawing.Point(210, 361);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCustomer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCustomer.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCustomer.selected = false;
            this.btnCustomer.Size = new System.Drawing.Size(128, 35);
            this.btnCustomer.TabIndex = 27;
            this.btnCustomer.Text = "Search";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.Textcolor = System.Drawing.Color.White;
            this.btnCustomer.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(28, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "[To Search Customer you must select Year]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(28, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(273, 18);
            this.label5.TabIndex = 29;
            this.label5.Text = "[To Search Month you must select Year]";
            // 
            // FAllPaymentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(842, 500);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.btnMonth);
            this.Controls.Add(this.btnYear);
            this.Controls.Add(this.comboBoxCustomer);
            this.Controls.Add(this.comboBoxMonth);
            this.Controls.Add(this.comboBoxYear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BBackManagePayment12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FAllPaymentList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All Payment Information";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FAllPaymentList_FormClosing);
            this.Load += new System.EventHandler(this.FAllPaymentList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerPaidTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ispDBDataSet14)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton BBackManagePayment12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.ComboBox comboBoxCustomer;
        private IspDBDataSet14 ispDBDataSet14;
        private System.Windows.Forms.BindingSource customerPaidTableBindingSource;
        private IspDBDataSet14TableAdapters.CustomerPaidTableTableAdapter customerPaidTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerMonthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidStatusDataGridViewTextBoxColumn;
        private Bunifu.Framework.UI.BunifuFlatButton btnYear;
        private Bunifu.Framework.UI.BunifuFlatButton btnMonth;
        private Bunifu.Framework.UI.BunifuFlatButton btnCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}