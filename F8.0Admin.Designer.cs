namespace Presentation_Layer
{
    partial class FAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAdmin));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TAdminUsername = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.TAdminPassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.BUpdateAdminInfo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BBackLoginA = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.ispDBDataSet15 = new Presentation_Layer.IspDBDataSet15();
            this.adminTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminTableTableAdapter = new Presentation_Layer.IspDBDataSet15TableAdapters.AdminTableTableAdapter();
            this.adminNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminUserNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminDOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ispDBDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(33, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(33, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // TAdminUsername
            // 
            this.TAdminUsername.BorderColorFocused = System.Drawing.Color.SpringGreen;
            this.TAdminUsername.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TAdminUsername.BorderColorMouseHover = System.Drawing.Color.SpringGreen;
            this.TAdminUsername.BorderThickness = 3;
            this.TAdminUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TAdminUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TAdminUsername.ForeColor = System.Drawing.Color.White;
            this.TAdminUsername.isPassword = false;
            this.TAdminUsername.Location = new System.Drawing.Point(185, 180);
            this.TAdminUsername.Margin = new System.Windows.Forms.Padding(4);
            this.TAdminUsername.Name = "TAdminUsername";
            this.TAdminUsername.Size = new System.Drawing.Size(224, 33);
            this.TAdminUsername.TabIndex = 7;
            this.TAdminUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TAdminPassword
            // 
            this.TAdminPassword.BorderColorFocused = System.Drawing.Color.SpringGreen;
            this.TAdminPassword.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TAdminPassword.BorderColorMouseHover = System.Drawing.Color.SpringGreen;
            this.TAdminPassword.BorderThickness = 3;
            this.TAdminPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TAdminPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TAdminPassword.ForeColor = System.Drawing.Color.White;
            this.TAdminPassword.isPassword = false;
            this.TAdminPassword.Location = new System.Drawing.Point(186, 224);
            this.TAdminPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TAdminPassword.Name = "TAdminPassword";
            this.TAdminPassword.Size = new System.Drawing.Size(224, 33);
            this.TAdminPassword.TabIndex = 8;
            this.TAdminPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BUpdateAdminInfo
            // 
            this.BUpdateAdminInfo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BUpdateAdminInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BUpdateAdminInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BUpdateAdminInfo.BorderRadius = 0;
            this.BUpdateAdminInfo.ButtonText = "Update Information";
            this.BUpdateAdminInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BUpdateAdminInfo.DisabledColor = System.Drawing.Color.Gray;
            this.BUpdateAdminInfo.Iconcolor = System.Drawing.Color.Transparent;
            this.BUpdateAdminInfo.Iconimage = ((System.Drawing.Image)(resources.GetObject("BUpdateAdminInfo.Iconimage")));
            this.BUpdateAdminInfo.Iconimage_right = null;
            this.BUpdateAdminInfo.Iconimage_right_Selected = null;
            this.BUpdateAdminInfo.Iconimage_Selected = null;
            this.BUpdateAdminInfo.IconMarginLeft = 0;
            this.BUpdateAdminInfo.IconMarginRight = 0;
            this.BUpdateAdminInfo.IconRightVisible = true;
            this.BUpdateAdminInfo.IconRightZoom = 0D;
            this.BUpdateAdminInfo.IconVisible = true;
            this.BUpdateAdminInfo.IconZoom = 90D;
            this.BUpdateAdminInfo.IsTab = false;
            this.BUpdateAdminInfo.Location = new System.Drawing.Point(187, 293);
            this.BUpdateAdminInfo.Name = "BUpdateAdminInfo";
            this.BUpdateAdminInfo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BUpdateAdminInfo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BUpdateAdminInfo.OnHoverTextColor = System.Drawing.Color.White;
            this.BUpdateAdminInfo.selected = false;
            this.BUpdateAdminInfo.Size = new System.Drawing.Size(223, 40);
            this.BUpdateAdminInfo.TabIndex = 10;
            this.BUpdateAdminInfo.Text = "Update Information";
            this.BUpdateAdminInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BUpdateAdminInfo.Textcolor = System.Drawing.Color.White;
            this.BUpdateAdminInfo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUpdateAdminInfo.Click += new System.EventHandler(this.BUpdateAdminInfo_Click);
            // 
            // BBackLoginA
            // 
            this.BBackLoginA.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.BBackLoginA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.BBackLoginA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BBackLoginA.BorderRadius = 0;
            this.BBackLoginA.ButtonText = "Back";
            this.BBackLoginA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BBackLoginA.DisabledColor = System.Drawing.Color.Gray;
            this.BBackLoginA.Iconcolor = System.Drawing.Color.Transparent;
            this.BBackLoginA.Iconimage = ((System.Drawing.Image)(resources.GetObject("BBackLoginA.Iconimage")));
            this.BBackLoginA.Iconimage_right = null;
            this.BBackLoginA.Iconimage_right_Selected = null;
            this.BBackLoginA.Iconimage_Selected = null;
            this.BBackLoginA.IconMarginLeft = 0;
            this.BBackLoginA.IconMarginRight = 0;
            this.BBackLoginA.IconRightVisible = true;
            this.BBackLoginA.IconRightZoom = 0D;
            this.BBackLoginA.IconVisible = true;
            this.BBackLoginA.IconZoom = 90D;
            this.BBackLoginA.IsTab = false;
            this.BBackLoginA.Location = new System.Drawing.Point(37, 16);
            this.BBackLoginA.Name = "BBackLoginA";
            this.BBackLoginA.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.BBackLoginA.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(56)))));
            this.BBackLoginA.OnHoverTextColor = System.Drawing.Color.White;
            this.BBackLoginA.Padding = new System.Windows.Forms.Padding(0, 5, 0, 20);
            this.BBackLoginA.selected = false;
            this.BBackLoginA.Size = new System.Drawing.Size(101, 47);
            this.BBackLoginA.TabIndex = 11;
            this.BBackLoginA.Text = "Back";
            this.BBackLoginA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BBackLoginA.Textcolor = System.Drawing.Color.White;
            this.BBackLoginA.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBackLoginA.Click += new System.EventHandler(this.BBackLoginA_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(33, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Admin List";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(186, 90);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(223, 27);
            this.comboBox1.TabIndex = 13;
            // 
            // bunifuCustomDataGrid1
            // 
            this.bunifuCustomDataGrid1.AllowUserToAddRows = false;
            this.bunifuCustomDataGrid1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.AutoGenerateColumns = false;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adminNameDataGridViewTextBoxColumn,
            this.adminUserNameDataGridViewTextBoxColumn,
            this.adminPasswordDataGridViewTextBoxColumn,
            this.adminDOBDataGridViewTextBoxColumn});
            this.bunifuCustomDataGrid1.DataSource = this.adminTableBindingSource;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.Black;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(437, 90);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.ReadOnly = true;
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(410, 150);
            this.bunifuCustomDataGrid1.TabIndex = 14;
            // 
            // ispDBDataSet15
            // 
            this.ispDBDataSet15.DataSetName = "IspDBDataSet15";
            this.ispDBDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminTableBindingSource
            // 
            this.adminTableBindingSource.DataMember = "AdminTable";
            this.adminTableBindingSource.DataSource = this.ispDBDataSet15;
            // 
            // adminTableTableAdapter
            // 
            this.adminTableTableAdapter.ClearBeforeFill = true;
            // 
            // adminNameDataGridViewTextBoxColumn
            // 
            this.adminNameDataGridViewTextBoxColumn.DataPropertyName = "AdminName";
            this.adminNameDataGridViewTextBoxColumn.HeaderText = "AdminName";
            this.adminNameDataGridViewTextBoxColumn.Name = "adminNameDataGridViewTextBoxColumn";
            this.adminNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adminUserNameDataGridViewTextBoxColumn
            // 
            this.adminUserNameDataGridViewTextBoxColumn.DataPropertyName = "AdminUserName";
            this.adminUserNameDataGridViewTextBoxColumn.HeaderText = "AdminUserName";
            this.adminUserNameDataGridViewTextBoxColumn.Name = "adminUserNameDataGridViewTextBoxColumn";
            this.adminUserNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adminPasswordDataGridViewTextBoxColumn
            // 
            this.adminPasswordDataGridViewTextBoxColumn.DataPropertyName = "AdminPassword";
            this.adminPasswordDataGridViewTextBoxColumn.HeaderText = "AdminPassword";
            this.adminPasswordDataGridViewTextBoxColumn.Name = "adminPasswordDataGridViewTextBoxColumn";
            this.adminPasswordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adminDOBDataGridViewTextBoxColumn
            // 
            this.adminDOBDataGridViewTextBoxColumn.DataPropertyName = "AdminDOB";
            this.adminDOBDataGridViewTextBoxColumn.HeaderText = "AdminDOB";
            this.adminDOBDataGridViewTextBoxColumn.Name = "adminDOBDataGridViewTextBoxColumn";
            this.adminDOBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(953, 375);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BBackLoginA);
            this.Controls.Add(this.BUpdateAdminInfo);
            this.Controls.Add(this.TAdminPassword);
            this.Controls.Add(this.TAdminUsername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Information";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FAdmin_FormClosing);
            this.Load += new System.EventHandler(this.FAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ispDBDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox TAdminUsername;
        private Bunifu.Framework.UI.BunifuMetroTextbox TAdminPassword;
        private Bunifu.Framework.UI.BunifuFlatButton BUpdateAdminInfo;
        private Bunifu.Framework.UI.BunifuFlatButton BBackLoginA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private IspDBDataSet15 ispDBDataSet15;
        private System.Windows.Forms.BindingSource adminTableBindingSource;
        private IspDBDataSet15TableAdapters.AdminTableTableAdapter adminTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminUserNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminDOBDataGridViewTextBoxColumn;
    }
}