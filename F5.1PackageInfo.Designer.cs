namespace Presentation_Layer
{
    partial class FPackageInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPackageInfo));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Pname = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.BAddNewPackage = new Bunifu.Framework.UI.BunifuTileButton();
            this.Pspeed = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Pprice = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.updateBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BBackHome = new Bunifu.Framework.UI.BunifuFlatButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customerPackageNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packageSpeedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packagePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packagetableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ispDBDataSet10 = new Presentation_Layer.IspDBDataSet10();
            this.packagetableTableAdapter = new Presentation_Layer.IspDBDataSet10TableAdapters.PackagetableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagetableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ispDBDataSet10)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(272, 78);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(4);
            this.label1.Size = new System.Drawing.Size(125, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Package Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(272, 128);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(4);
            this.label3.Size = new System.Drawing.Size(62, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Speed";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(272, 181);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(4);
            this.label4.Size = new System.Drawing.Size(62, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Price";
            // 
            // Pname
            // 
            this.Pname.BorderColorFocused = System.Drawing.Color.MediumSpringGreen;
            this.Pname.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Pname.BorderColorMouseHover = System.Drawing.Color.MediumSpringGreen;
            this.Pname.BorderThickness = 3;
            this.Pname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Pname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Pname.ForeColor = System.Drawing.Color.White;
            this.Pname.isPassword = false;
            this.Pname.Location = new System.Drawing.Point(417, 74);
            this.Pname.Margin = new System.Windows.Forms.Padding(4);
            this.Pname.Name = "Pname";
            this.Pname.Size = new System.Drawing.Size(191, 35);
            this.Pname.TabIndex = 6;
            this.Pname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BAddNewPackage
            // 
            this.BAddNewPackage.BackColor = System.Drawing.Color.SeaGreen;
            this.BAddNewPackage.color = System.Drawing.Color.SeaGreen;
            this.BAddNewPackage.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.BAddNewPackage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BAddNewPackage.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAddNewPackage.ForeColor = System.Drawing.Color.White;
            this.BAddNewPackage.Image = ((System.Drawing.Image)(resources.GetObject("BAddNewPackage.Image")));
            this.BAddNewPackage.ImagePosition = 13;
            this.BAddNewPackage.ImageZoom = 50;
            this.BAddNewPackage.LabelPosition = 27;
            this.BAddNewPackage.LabelText = "Add New Package";
            this.BAddNewPackage.Location = new System.Drawing.Point(15, 131);
            this.BAddNewPackage.Margin = new System.Windows.Forms.Padding(6);
            this.BAddNewPackage.Name = "BAddNewPackage";
            this.BAddNewPackage.Size = new System.Drawing.Size(128, 114);
            this.BAddNewPackage.TabIndex = 9;
            this.BAddNewPackage.Click += new System.EventHandler(this.BAddNewPackage_Click);
            // 
            // Pspeed
            // 
            this.Pspeed.BorderColorFocused = System.Drawing.Color.MediumSpringGreen;
            this.Pspeed.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Pspeed.BorderColorMouseHover = System.Drawing.Color.MediumSpringGreen;
            this.Pspeed.BorderThickness = 3;
            this.Pspeed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Pspeed.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Pspeed.ForeColor = System.Drawing.Color.White;
            this.Pspeed.isPassword = false;
            this.Pspeed.Location = new System.Drawing.Point(417, 124);
            this.Pspeed.Margin = new System.Windows.Forms.Padding(4);
            this.Pspeed.Name = "Pspeed";
            this.Pspeed.Size = new System.Drawing.Size(191, 35);
            this.Pspeed.TabIndex = 10;
            this.Pspeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Pprice
            // 
            this.Pprice.BorderColorFocused = System.Drawing.Color.MediumSpringGreen;
            this.Pprice.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Pprice.BorderColorMouseHover = System.Drawing.Color.MediumSpringGreen;
            this.Pprice.BorderThickness = 3;
            this.Pprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Pprice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Pprice.ForeColor = System.Drawing.Color.White;
            this.Pprice.isPassword = false;
            this.Pprice.Location = new System.Drawing.Point(417, 176);
            this.Pprice.Margin = new System.Windows.Forms.Padding(4);
            this.Pprice.Name = "Pprice";
            this.Pprice.Size = new System.Drawing.Size(191, 35);
            this.Pprice.TabIndex = 11;
            this.Pprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // updateBtn
            // 
            this.updateBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.updateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateBtn.BorderRadius = 0;
            this.updateBtn.ButtonText = "Update Information";
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.DisabledColor = System.Drawing.Color.Gray;
            this.updateBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.updateBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("updateBtn.Iconimage")));
            this.updateBtn.Iconimage_right = null;
            this.updateBtn.Iconimage_right_Selected = null;
            this.updateBtn.Iconimage_Selected = null;
            this.updateBtn.IconMarginLeft = 0;
            this.updateBtn.IconMarginRight = 0;
            this.updateBtn.IconRightVisible = true;
            this.updateBtn.IconRightZoom = 0D;
            this.updateBtn.IconVisible = true;
            this.updateBtn.IconZoom = 90D;
            this.updateBtn.IsTab = false;
            this.updateBtn.Location = new System.Drawing.Point(417, 236);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.updateBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.updateBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.updateBtn.selected = false;
            this.updateBtn.Size = new System.Drawing.Size(191, 48);
            this.updateBtn.TabIndex = 12;
            this.updateBtn.Text = "Update Information";
            this.updateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateBtn.Textcolor = System.Drawing.Color.White;
            this.updateBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
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
            this.BBackHome.Size = new System.Drawing.Size(100, 55);
            this.BBackHome.TabIndex = 13;
            this.BBackHome.Text = "Back";
            this.BBackHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BBackHome.Textcolor = System.Drawing.Color.White;
            this.BBackHome.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBackHome.Click += new System.EventHandler(this.BBackHome_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 81);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(128, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Show";
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(149, 77);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(113, 29);
            this.bunifuFlatButton1.TabIndex = 15;
            this.bunifuFlatButton1.Text = "Show";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerPackageNameDataGridViewTextBoxColumn,
            this.packageSpeedDataGridViewTextBoxColumn,
            this.packagePriceDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.packagetableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 271);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(382, 186);
            this.dataGridView1.TabIndex = 16;
            // 
            // customerPackageNameDataGridViewTextBoxColumn
            // 
            this.customerPackageNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerPackageName";
            this.customerPackageNameDataGridViewTextBoxColumn.HeaderText = "CustomerPackageName";
            this.customerPackageNameDataGridViewTextBoxColumn.Name = "customerPackageNameDataGridViewTextBoxColumn";
            // 
            // packageSpeedDataGridViewTextBoxColumn
            // 
            this.packageSpeedDataGridViewTextBoxColumn.DataPropertyName = "PackageSpeed";
            this.packageSpeedDataGridViewTextBoxColumn.HeaderText = "PackageSpeed";
            this.packageSpeedDataGridViewTextBoxColumn.Name = "packageSpeedDataGridViewTextBoxColumn";
            // 
            // packagePriceDataGridViewTextBoxColumn
            // 
            this.packagePriceDataGridViewTextBoxColumn.DataPropertyName = "PackagePrice";
            this.packagePriceDataGridViewTextBoxColumn.HeaderText = "PackagePrice";
            this.packagePriceDataGridViewTextBoxColumn.Name = "packagePriceDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // packagetableBindingSource
            // 
            this.packagetableBindingSource.DataMember = "Packagetable";
            this.packagetableBindingSource.DataSource = this.ispDBDataSet10;
            // 
            // ispDBDataSet10
            // 
            this.ispDBDataSet10.DataSetName = "IspDBDataSet10";
            this.ispDBDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // packagetableTableAdapter
            // 
            this.packagetableTableAdapter.ClearBeforeFill = true;
            // 
            // FPackageInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(618, 469);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BBackHome);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.Pprice);
            this.Controls.Add(this.Pspeed);
            this.Controls.Add(this.BAddNewPackage);
            this.Controls.Add(this.Pname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FPackageInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Package Information";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FPackageInfo_FormClosing);
            this.Load += new System.EventHandler(this.FPackageInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagetableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ispDBDataSet10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox Pname;
        private Bunifu.Framework.UI.BunifuTileButton BAddNewPackage;
        private Bunifu.Framework.UI.BunifuMetroTextbox Pspeed;
        private Bunifu.Framework.UI.BunifuMetroTextbox Pprice;
        private Bunifu.Framework.UI.BunifuFlatButton updateBtn;
        private Bunifu.Framework.UI.BunifuFlatButton BBackHome;
        private System.Windows.Forms.ComboBox comboBox1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private IspDBDataSet10 ispDBDataSet10;
        private System.Windows.Forms.BindingSource packagetableBindingSource;
        private IspDBDataSet10TableAdapters.PackagetableTableAdapter packagetableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPackageNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packageSpeedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packagePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    }
}