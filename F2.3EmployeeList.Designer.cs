namespace Presentation_Layer
{
    partial class FEmployeeList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FEmployeeList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.employeeNameTableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.BempSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Tsearch = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.Bclear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Bdelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BempUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label15 = new System.Windows.Forms.Label();
            this.EmpAddress = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.EmpEmail = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.EmpMobile = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.EmpNID = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.EmpName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.EmpSalary = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BBackHome = new Bunifu.Framework.UI.BunifuFlatButton();
            this.EmpEmpPass = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.CboxModeratorAccess = new System.Windows.Forms.ComboBox();
            this.employeeNameTableTableAdapter2 = new Presentation_Layer.IspDBDataSet8TableAdapters.EmployeeNameTableTableAdapter();
            this.employeeNameTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ispDBDataSet9 = new Presentation_Layer.IspDBDataSet9();
            this.employeeNameTableTableAdapter = new Presentation_Layer.IspDBDataSet9TableAdapters.EmployeeNameTableTableAdapter();
            this.dataGridView1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeePasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeModeratorAccessDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.employeeNameTableBindingSource2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeNameTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ispDBDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BempSearch
            // 
            this.BempSearch.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BempSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BempSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BempSearch.BorderRadius = 0;
            this.BempSearch.ButtonText = "Search";
            this.BempSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BempSearch.DisabledColor = System.Drawing.Color.Gray;
            this.BempSearch.Iconcolor = System.Drawing.Color.Transparent;
            this.BempSearch.Iconimage = ((System.Drawing.Image)(resources.GetObject("BempSearch.Iconimage")));
            this.BempSearch.Iconimage_right = null;
            this.BempSearch.Iconimage_right_Selected = null;
            this.BempSearch.Iconimage_Selected = null;
            this.BempSearch.IconMarginLeft = 0;
            this.BempSearch.IconMarginRight = 0;
            this.BempSearch.IconRightVisible = true;
            this.BempSearch.IconRightZoom = 0D;
            this.BempSearch.IconVisible = true;
            this.BempSearch.IconZoom = 90D;
            this.BempSearch.IsTab = false;
            this.BempSearch.Location = new System.Drawing.Point(158, 110);
            this.BempSearch.Name = "BempSearch";
            this.BempSearch.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BempSearch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BempSearch.OnHoverTextColor = System.Drawing.Color.White;
            this.BempSearch.selected = false;
            this.BempSearch.Size = new System.Drawing.Size(147, 43);
            this.BempSearch.TabIndex = 11;
            this.BempSearch.Text = "Search";
            this.BempSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BempSearch.Textcolor = System.Drawing.Color.White;
            this.BempSearch.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BempSearch.Click += new System.EventHandler(this.BempSearch_Click);
            // 
            // Tsearch
            // 
            this.Tsearch.BorderColorFocused = System.Drawing.Color.DarkCyan;
            this.Tsearch.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Tsearch.BorderColorMouseHover = System.Drawing.Color.DarkCyan;
            this.Tsearch.BorderThickness = 3;
            this.Tsearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Tsearch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Tsearch.ForeColor = System.Drawing.Color.White;
            this.Tsearch.isPassword = false;
            this.Tsearch.Location = new System.Drawing.Point(157, 49);
            this.Tsearch.Margin = new System.Windows.Forms.Padding(4);
            this.Tsearch.Name = "Tsearch";
            this.Tsearch.Size = new System.Drawing.Size(147, 35);
            this.Tsearch.TabIndex = 10;
            this.Tsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(70)))));
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.Bclear);
            this.panel2.Controls.Add(this.Bdelete);
            this.panel2.Controls.Add(this.BempUpdate);
            this.panel2.Controls.Add(this.bunifuSeparator1);
            this.panel2.Controls.Add(this.BempSearch);
            this.panel2.Controls.Add(this.Tsearch);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Location = new System.Drawing.Point(11, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 469);
            this.panel2.TabIndex = 72;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(6, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "Enter Employee ID";
            // 
            // Bclear
            // 
            this.Bclear.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Bclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Bclear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bclear.BorderRadius = 0;
            this.Bclear.ButtonText = "Clear";
            this.Bclear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bclear.DisabledColor = System.Drawing.Color.Gray;
            this.Bclear.Iconcolor = System.Drawing.Color.Transparent;
            this.Bclear.Iconimage = ((System.Drawing.Image)(resources.GetObject("Bclear.Iconimage")));
            this.Bclear.Iconimage_right = null;
            this.Bclear.Iconimage_right_Selected = null;
            this.Bclear.Iconimage_Selected = null;
            this.Bclear.IconMarginLeft = 0;
            this.Bclear.IconMarginRight = 0;
            this.Bclear.IconRightVisible = true;
            this.Bclear.IconRightZoom = 0D;
            this.Bclear.IconVisible = true;
            this.Bclear.IconZoom = 90D;
            this.Bclear.IsTab = false;
            this.Bclear.Location = new System.Drawing.Point(159, 201);
            this.Bclear.Name = "Bclear";
            this.Bclear.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Bclear.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Bclear.OnHoverTextColor = System.Drawing.Color.White;
            this.Bclear.selected = false;
            this.Bclear.Size = new System.Drawing.Size(134, 43);
            this.Bclear.TabIndex = 19;
            this.Bclear.Text = "Clear";
            this.Bclear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bclear.Textcolor = System.Drawing.Color.White;
            this.Bclear.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bclear.Click += new System.EventHandler(this.Bclear_Click);
            // 
            // Bdelete
            // 
            this.Bdelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Bdelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Bdelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bdelete.BorderRadius = 0;
            this.Bdelete.ButtonText = "Delete";
            this.Bdelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bdelete.DisabledColor = System.Drawing.Color.Gray;
            this.Bdelete.Iconcolor = System.Drawing.Color.Transparent;
            this.Bdelete.Iconimage = ((System.Drawing.Image)(resources.GetObject("Bdelete.Iconimage")));
            this.Bdelete.Iconimage_right = null;
            this.Bdelete.Iconimage_right_Selected = null;
            this.Bdelete.Iconimage_Selected = null;
            this.Bdelete.IconMarginLeft = 0;
            this.Bdelete.IconMarginRight = 0;
            this.Bdelete.IconRightVisible = true;
            this.Bdelete.IconRightZoom = 0D;
            this.Bdelete.IconVisible = true;
            this.Bdelete.IconZoom = 90D;
            this.Bdelete.IsTab = false;
            this.Bdelete.Location = new System.Drawing.Point(13, 253);
            this.Bdelete.Name = "Bdelete";
            this.Bdelete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Bdelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Bdelete.OnHoverTextColor = System.Drawing.Color.White;
            this.Bdelete.selected = false;
            this.Bdelete.Size = new System.Drawing.Size(134, 43);
            this.Bdelete.TabIndex = 18;
            this.Bdelete.Text = "Delete";
            this.Bdelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bdelete.Textcolor = System.Drawing.Color.White;
            this.Bdelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bdelete.Click += new System.EventHandler(this.Bdelete_Click);
            // 
            // BempUpdate
            // 
            this.BempUpdate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BempUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BempUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BempUpdate.BorderRadius = 0;
            this.BempUpdate.ButtonText = "Update";
            this.BempUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BempUpdate.DisabledColor = System.Drawing.Color.Gray;
            this.BempUpdate.Iconcolor = System.Drawing.Color.Transparent;
            this.BempUpdate.Iconimage = ((System.Drawing.Image)(resources.GetObject("BempUpdate.Iconimage")));
            this.BempUpdate.Iconimage_right = null;
            this.BempUpdate.Iconimage_right_Selected = null;
            this.BempUpdate.Iconimage_Selected = null;
            this.BempUpdate.IconMarginLeft = 0;
            this.BempUpdate.IconMarginRight = 0;
            this.BempUpdate.IconRightVisible = true;
            this.BempUpdate.IconRightZoom = 0D;
            this.BempUpdate.IconVisible = true;
            this.BempUpdate.IconZoom = 90D;
            this.BempUpdate.IsTab = false;
            this.BempUpdate.Location = new System.Drawing.Point(13, 201);
            this.BempUpdate.Name = "BempUpdate";
            this.BempUpdate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BempUpdate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BempUpdate.OnHoverTextColor = System.Drawing.Color.White;
            this.BempUpdate.selected = false;
            this.BempUpdate.Size = new System.Drawing.Size(134, 43);
            this.BempUpdate.TabIndex = 17;
            this.BempUpdate.Text = "Update";
            this.BempUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BempUpdate.Textcolor = System.Drawing.Color.White;
            this.BempUpdate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BempUpdate.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(3, 172);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(314, 35);
            this.bunifuSeparator1.TabIndex = 16;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(78, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(160, 22);
            this.label15.TabIndex = 7;
            this.label15.Text = "Search Employee";
            // 
            // EmpAddress
            // 
            this.EmpAddress.BorderColorFocused = System.Drawing.Color.DarkCyan;
            this.EmpAddress.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EmpAddress.BorderColorMouseHover = System.Drawing.Color.DarkCyan;
            this.EmpAddress.BorderThickness = 3;
            this.EmpAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpAddress.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.EmpAddress.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EmpAddress.isPassword = false;
            this.EmpAddress.Location = new System.Drawing.Point(484, 246);
            this.EmpAddress.Margin = new System.Windows.Forms.Padding(4);
            this.EmpAddress.Name = "EmpAddress";
            this.EmpAddress.Size = new System.Drawing.Size(268, 35);
            this.EmpAddress.TabIndex = 99;
            this.EmpAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // EmpEmail
            // 
            this.EmpEmail.BorderColorFocused = System.Drawing.Color.DarkCyan;
            this.EmpEmail.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EmpEmail.BorderColorMouseHover = System.Drawing.Color.DarkCyan;
            this.EmpEmail.BorderThickness = 3;
            this.EmpEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.EmpEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EmpEmail.isPassword = false;
            this.EmpEmail.Location = new System.Drawing.Point(484, 203);
            this.EmpEmail.Margin = new System.Windows.Forms.Padding(4);
            this.EmpEmail.Name = "EmpEmail";
            this.EmpEmail.Size = new System.Drawing.Size(268, 35);
            this.EmpEmail.TabIndex = 98;
            this.EmpEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // EmpMobile
            // 
            this.EmpMobile.BorderColorFocused = System.Drawing.Color.DarkCyan;
            this.EmpMobile.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EmpMobile.BorderColorMouseHover = System.Drawing.Color.DarkCyan;
            this.EmpMobile.BorderThickness = 3;
            this.EmpMobile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpMobile.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.EmpMobile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EmpMobile.isPassword = false;
            this.EmpMobile.Location = new System.Drawing.Point(484, 160);
            this.EmpMobile.Margin = new System.Windows.Forms.Padding(4);
            this.EmpMobile.Name = "EmpMobile";
            this.EmpMobile.Size = new System.Drawing.Size(268, 35);
            this.EmpMobile.TabIndex = 97;
            this.EmpMobile.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // EmpNID
            // 
            this.EmpNID.BorderColorFocused = System.Drawing.Color.DarkCyan;
            this.EmpNID.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EmpNID.BorderColorMouseHover = System.Drawing.Color.DarkCyan;
            this.EmpNID.BorderThickness = 3;
            this.EmpNID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpNID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.EmpNID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EmpNID.isPassword = false;
            this.EmpNID.Location = new System.Drawing.Point(484, 117);
            this.EmpNID.Margin = new System.Windows.Forms.Padding(4);
            this.EmpNID.Name = "EmpNID";
            this.EmpNID.Size = new System.Drawing.Size(268, 35);
            this.EmpNID.TabIndex = 96;
            this.EmpNID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // EmpName
            // 
            this.EmpName.BorderColorFocused = System.Drawing.Color.DarkCyan;
            this.EmpName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EmpName.BorderColorMouseHover = System.Drawing.Color.DarkCyan;
            this.EmpName.BorderThickness = 3;
            this.EmpName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.EmpName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EmpName.isPassword = false;
            this.EmpName.Location = new System.Drawing.Point(484, 70);
            this.EmpName.Margin = new System.Windows.Forms.Padding(4);
            this.EmpName.Name = "EmpName";
            this.EmpName.Size = new System.Drawing.Size(268, 35);
            this.EmpName.TabIndex = 94;
            this.EmpName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // EmpSalary
            // 
            this.EmpSalary.BorderColorFocused = System.Drawing.Color.DarkCyan;
            this.EmpSalary.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EmpSalary.BorderColorMouseHover = System.Drawing.Color.DarkCyan;
            this.EmpSalary.BorderThickness = 3;
            this.EmpSalary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpSalary.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.EmpSalary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EmpSalary.isPassword = false;
            this.EmpSalary.Location = new System.Drawing.Point(484, 341);
            this.EmpSalary.Margin = new System.Windows.Forms.Padding(4);
            this.EmpSalary.Name = "EmpSalary";
            this.EmpSalary.Size = new System.Drawing.Size(268, 35);
            this.EmpSalary.TabIndex = 100;
            this.EmpSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(360, 348);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 22);
            this.label10.TabIndex = 91;
            this.label10.Text = "Salary";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(360, 250);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 22);
            this.label12.TabIndex = 89;
            this.label12.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(360, 210);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 22);
            this.label5.TabIndex = 88;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(360, 169);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 22);
            this.label6.TabIndex = 87;
            this.label6.Text = "Mobile";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(358, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 22);
            this.label3.TabIndex = 86;
            this.label3.Text = "NID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(358, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 22);
            this.label1.TabIndex = 84;
            this.label1.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(358, 402);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 22);
            this.label4.TabIndex = 101;
            this.label4.Text = "Moderator Access";
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
            this.BBackHome.Location = new System.Drawing.Point(11, 9);
            this.BBackHome.Name = "BBackHome";
            this.BBackHome.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.BBackHome.OnHovercolor = System.Drawing.Color.Teal;
            this.BBackHome.OnHoverTextColor = System.Drawing.Color.White;
            this.BBackHome.selected = false;
            this.BBackHome.Size = new System.Drawing.Size(102, 55);
            this.BBackHome.TabIndex = 103;
            this.BBackHome.Text = "Back";
            this.BBackHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BBackHome.Textcolor = System.Drawing.Color.White;
            this.BBackHome.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBackHome.Click += new System.EventHandler(this.BBackHome_Click);
            // 
            // EmpEmpPass
            // 
            this.EmpEmpPass.BorderColorFocused = System.Drawing.Color.DarkCyan;
            this.EmpEmpPass.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EmpEmpPass.BorderColorMouseHover = System.Drawing.Color.DarkCyan;
            this.EmpEmpPass.BorderThickness = 3;
            this.EmpEmpPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpEmpPass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.EmpEmpPass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EmpEmpPass.isPassword = false;
            this.EmpEmpPass.Location = new System.Drawing.Point(529, 292);
            this.EmpEmpPass.Margin = new System.Windows.Forms.Padding(4);
            this.EmpEmpPass.Name = "EmpEmpPass";
            this.EmpEmpPass.Size = new System.Drawing.Size(223, 35);
            this.EmpEmpPass.TabIndex = 105;
            this.EmpEmpPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(360, 303);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 19);
            this.label8.TabIndex = 104;
            this.label8.Text = "Employee Password";
            // 
            // CboxModeratorAccess
            // 
            this.CboxModeratorAccess.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboxModeratorAccess.FormattingEnabled = true;
            this.CboxModeratorAccess.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.CboxModeratorAccess.Location = new System.Drawing.Point(550, 400);
            this.CboxModeratorAccess.Name = "CboxModeratorAccess";
            this.CboxModeratorAccess.Size = new System.Drawing.Size(202, 27);
            this.CboxModeratorAccess.TabIndex = 106;
            // 
            // employeeNameTableTableAdapter2
            // 
            this.employeeNameTableTableAdapter2.ClearBeforeFill = true;
            // 
            // employeeNameTableBindingSource
            // 
            this.employeeNameTableBindingSource.DataMember = "EmployeeNameTable";
            this.employeeNameTableBindingSource.DataSource = this.ispDBDataSet9;
            // 
            // ispDBDataSet9
            // 
            this.ispDBDataSet9.DataSetName = "IspDBDataSet9";
            this.ispDBDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeNameTableTableAdapter
            // 
            this.employeeNameTableTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.employeeNameDataGridViewTextBoxColumn,
            this.employeePasswordDataGridViewTextBoxColumn,
            this.employeeModeratorAccessDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeeNameTableBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.DoubleBuffered = true;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dataGridView1.HeaderForeColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(776, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Size = new System.Drawing.Size(530, 355);
            this.dataGridView1.TabIndex = 107;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeNameDataGridViewTextBoxColumn
            // 
            this.employeeNameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeName";
            this.employeeNameDataGridViewTextBoxColumn.HeaderText = "EmployeeName";
            this.employeeNameDataGridViewTextBoxColumn.Name = "employeeNameDataGridViewTextBoxColumn";
            this.employeeNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // employeePasswordDataGridViewTextBoxColumn
            // 
            this.employeePasswordDataGridViewTextBoxColumn.DataPropertyName = "EmployeePassword";
            this.employeePasswordDataGridViewTextBoxColumn.HeaderText = "EmployeePassword";
            this.employeePasswordDataGridViewTextBoxColumn.Name = "employeePasswordDataGridViewTextBoxColumn";
            this.employeePasswordDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeePasswordDataGridViewTextBoxColumn.Width = 120;
            // 
            // employeeModeratorAccessDataGridViewTextBoxColumn
            // 
            this.employeeModeratorAccessDataGridViewTextBoxColumn.DataPropertyName = "EmployeeModeratorAccess";
            this.employeeModeratorAccessDataGridViewTextBoxColumn.HeaderText = "EmployeeModeratorAccess";
            this.employeeModeratorAccessDataGridViewTextBoxColumn.Name = "employeeModeratorAccessDataGridViewTextBoxColumn";
            this.employeeModeratorAccessDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // FEmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1329, 604);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CboxModeratorAccess);
            this.Controls.Add(this.EmpEmpPass);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BBackHome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EmpAddress);
            this.Controls.Add(this.EmpEmail);
            this.Controls.Add(this.EmpMobile);
            this.Controls.Add(this.EmpNID);
            this.Controls.Add(this.EmpName);
            this.Controls.Add(this.EmpSalary);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FEmployeeList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee List";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.F2_FormClosing);
            this.Load += new System.EventHandler(this.FEmployeeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeNameTableBindingSource2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeNameTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ispDBDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton BempSearch;
        private Bunifu.Framework.UI.BunifuMetroTextbox Tsearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label15;
        private Bunifu.Framework.UI.BunifuMetroTextbox EmpAddress;
        private Bunifu.Framework.UI.BunifuMetroTextbox EmpEmail;
        private Bunifu.Framework.UI.BunifuMetroTextbox EmpMobile;
        private Bunifu.Framework.UI.BunifuMetroTextbox EmpNID;
        private Bunifu.Framework.UI.BunifuMetroTextbox EmpName;
        private Bunifu.Framework.UI.BunifuMetroTextbox EmpSalary;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuFlatButton BBackHome;
        private Bunifu.Framework.UI.BunifuFlatButton Bclear;
        private Bunifu.Framework.UI.BunifuFlatButton Bdelete;
        private Bunifu.Framework.UI.BunifuFlatButton BempUpdate;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuMetroTextbox EmpEmpPass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CboxModeratorAccess;
        private System.Windows.Forms.BindingSource employeeNameTableBindingSource2;
        private IspDBDataSet8TableAdapters.EmployeeNameTableTableAdapter employeeNameTableTableAdapter2;
        private IspDBDataSet9 ispDBDataSet9;
        private System.Windows.Forms.BindingSource employeeNameTableBindingSource;
        private IspDBDataSet9TableAdapters.EmployeeNameTableTableAdapter employeeNameTableTableAdapter;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeePasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeModeratorAccessDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    }
}