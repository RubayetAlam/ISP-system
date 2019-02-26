namespace Presentation_Layer
{
    partial class FCustomerList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCustomerList));
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuFlatButton7 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TCustomerSearch = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label15 = new System.Windows.Forms.Label();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label8 = new System.Windows.Forms.Label();
            this.TCusName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.TCusNID = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.TCusEmail = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.TCusMobile = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.TCusAmount = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cutomerNameTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ispDBDataSet2 = new Presentation_Layer.IspDBDataSet2();
            this.BBackHome = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label10 = new System.Windows.Forms.Label();
            this.cutomerNameTableTableAdapter = new Presentation_Layer.IspDBDataSet2TableAdapters.CutomerNameTableTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.customerContactTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ispDBDataSet11 = new Presentation_Layer.IspDBDataSet11();
            this.customerLocationTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ispDBDataSet7 = new Presentation_Layer.IspDBDataSet7();
            this.customerLocationTableTableAdapter = new Presentation_Layer.IspDBDataSet7TableAdapters.CustomerLocationTableTableAdapter();
            this.customerContactTableTableAdapter = new Presentation_Layer.IspDBDataSet11TableAdapters.CustomerContactTableTableAdapter();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customreNIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerMobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerLocationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cutomerNameTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ispDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerContactTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ispDBDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerLocationTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ispDBDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(352, 309);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 22);
            this.label9.TabIndex = 34;
            this.label9.Text = "Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(352, 205);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 22);
            this.label5.TabIndex = 29;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(352, 163);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 22);
            this.label6.TabIndex = 28;
            this.label6.Text = "Mobile";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(350, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 22);
            this.label3.TabIndex = 27;
            this.label3.Text = "NID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(352, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 22);
            this.label1.TabIndex = 25;
            this.label1.Text = "Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(70)))));
            this.panel2.Controls.Add(this.comboBox3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.bunifuSeparator2);
            this.panel2.Controls.Add(this.bunifuFlatButton7);
            this.panel2.Controls.Add(this.bunifuFlatButton5);
            this.panel2.Controls.Add(this.bunifuFlatButton4);
            this.panel2.Controls.Add(this.bunifuSeparator1);
            this.panel2.Controls.Add(this.bunifuFlatButton3);
            this.panel2.Controls.Add(this.TCustomerSearch);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.bunifuFlatButton2);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(11, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 491);
            this.panel2.TabIndex = 47;
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Dhanmondi",
            "Mirpur",
            "Banani",
            "Mohammadpur",
            "Baridhara",
            "Basundhara"});
            this.comboBox3.Location = new System.Drawing.Point(157, 22);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(147, 28);
            this.comboBox3.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(9, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "Enter Customer ID";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(3, 188);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(314, 35);
            this.bunifuSeparator2.TabIndex = 17;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // bunifuFlatButton7
            // 
            this.bunifuFlatButton7.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton7.BorderRadius = 0;
            this.bunifuFlatButton7.ButtonText = "Clear";
            this.bunifuFlatButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton7.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton7.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton7.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton7.Iconimage")));
            this.bunifuFlatButton7.Iconimage_right = null;
            this.bunifuFlatButton7.Iconimage_right_Selected = null;
            this.bunifuFlatButton7.Iconimage_Selected = null;
            this.bunifuFlatButton7.IconMarginLeft = 0;
            this.bunifuFlatButton7.IconMarginRight = 0;
            this.bunifuFlatButton7.IconRightVisible = true;
            this.bunifuFlatButton7.IconRightZoom = 0D;
            this.bunifuFlatButton7.IconVisible = true;
            this.bunifuFlatButton7.IconZoom = 90D;
            this.bunifuFlatButton7.IsTab = false;
            this.bunifuFlatButton7.Location = new System.Drawing.Point(159, 382);
            this.bunifuFlatButton7.Name = "bunifuFlatButton7";
            this.bunifuFlatButton7.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton7.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton7.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton7.selected = false;
            this.bunifuFlatButton7.Size = new System.Drawing.Size(134, 43);
            this.bunifuFlatButton7.TabIndex = 15;
            this.bunifuFlatButton7.Text = "Clear";
            this.bunifuFlatButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton7.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton7.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton7.Click += new System.EventHandler(this.bunifuFlatButton7_Click);
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton5.BorderRadius = 0;
            this.bunifuFlatButton5.ButtonText = "Delete";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton5.Iconimage")));
            this.bunifuFlatButton5.Iconimage_right = null;
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = null;
            this.bunifuFlatButton5.IconMarginLeft = 0;
            this.bunifuFlatButton5.IconMarginRight = 0;
            this.bunifuFlatButton5.IconRightVisible = true;
            this.bunifuFlatButton5.IconRightZoom = 0D;
            this.bunifuFlatButton5.IconVisible = true;
            this.bunifuFlatButton5.IconZoom = 90D;
            this.bunifuFlatButton5.IsTab = false;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(13, 434);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(134, 43);
            this.bunifuFlatButton5.TabIndex = 14;
            this.bunifuFlatButton5.Text = "Delete";
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton5.Click += new System.EventHandler(this.bunifuFlatButton5_Click);
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "Update";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton4.Iconimage")));
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 90D;
            this.bunifuFlatButton4.IsTab = false;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(13, 382);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(134, 43);
            this.bunifuFlatButton4.TabIndex = 13;
            this.bunifuFlatButton4.Text = "Update";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton4.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(3, 353);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(314, 35);
            this.bunifuSeparator1.TabIndex = 12;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "Search";
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
            this.bunifuFlatButton3.Location = new System.Drawing.Point(190, 310);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(117, 43);
            this.bunifuFlatButton3.TabIndex = 11;
            this.bunifuFlatButton3.Text = "Search";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // TCustomerSearch
            // 
            this.TCustomerSearch.BorderColorFocused = System.Drawing.Color.DarkCyan;
            this.TCustomerSearch.BorderColorIdle = System.Drawing.Color.Teal;
            this.TCustomerSearch.BorderColorMouseHover = System.Drawing.Color.DarkCyan;
            this.TCustomerSearch.BorderThickness = 3;
            this.TCustomerSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TCustomerSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TCustomerSearch.ForeColor = System.Drawing.Color.White;
            this.TCustomerSearch.isPassword = false;
            this.TCustomerSearch.Location = new System.Drawing.Point(190, 254);
            this.TCustomerSearch.Margin = new System.Windows.Forms.Padding(4);
            this.TCustomerSearch.Name = "TCustomerSearch";
            this.TCustomerSearch.Size = new System.Drawing.Size(116, 35);
            this.TCustomerSearch.TabIndex = 10;
            this.TCustomerSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(82, 218);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(160, 22);
            this.label15.TabIndex = 7;
            this.label15.Text = "Search Customer";
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Apply filter";
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
            this.bunifuFlatButton2.Location = new System.Drawing.Point(157, 72);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(147, 43);
            this.bunifuFlatButton2.TabIndex = 6;
            this.bunifuFlatButton2.Text = "Apply filter";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(17, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 22);
            this.label8.TabIndex = 1;
            this.label8.Text = "Area";
            // 
            // TCusName
            // 
            this.TCusName.BorderColorFocused = System.Drawing.Color.DarkCyan;
            this.TCusName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TCusName.BorderColorMouseHover = System.Drawing.Color.DarkCyan;
            this.TCusName.BorderThickness = 3;
            this.TCusName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TCusName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TCusName.ForeColor = System.Drawing.Color.White;
            this.TCusName.isPassword = false;
            this.TCusName.Location = new System.Drawing.Point(476, 65);
            this.TCusName.Margin = new System.Windows.Forms.Padding(4);
            this.TCusName.Name = "TCusName";
            this.TCusName.Size = new System.Drawing.Size(272, 35);
            this.TCusName.TabIndex = 48;
            this.TCusName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TCusNID
            // 
            this.TCusNID.BorderColorFocused = System.Drawing.Color.DarkCyan;
            this.TCusNID.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TCusNID.BorderColorMouseHover = System.Drawing.Color.DarkCyan;
            this.TCusNID.BorderThickness = 3;
            this.TCusNID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TCusNID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TCusNID.ForeColor = System.Drawing.Color.White;
            this.TCusNID.isPassword = false;
            this.TCusNID.Location = new System.Drawing.Point(476, 114);
            this.TCusNID.Margin = new System.Windows.Forms.Padding(4);
            this.TCusNID.Name = "TCusNID";
            this.TCusNID.Size = new System.Drawing.Size(272, 35);
            this.TCusNID.TabIndex = 50;
            this.TCusNID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TCusEmail
            // 
            this.TCusEmail.BorderColorFocused = System.Drawing.Color.DarkCyan;
            this.TCusEmail.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TCusEmail.BorderColorMouseHover = System.Drawing.Color.DarkCyan;
            this.TCusEmail.BorderThickness = 3;
            this.TCusEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TCusEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TCusEmail.ForeColor = System.Drawing.Color.White;
            this.TCusEmail.isPassword = false;
            this.TCusEmail.Location = new System.Drawing.Point(476, 200);
            this.TCusEmail.Margin = new System.Windows.Forms.Padding(4);
            this.TCusEmail.Name = "TCusEmail";
            this.TCusEmail.Size = new System.Drawing.Size(272, 35);
            this.TCusEmail.TabIndex = 51;
            this.TCusEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TCusMobile
            // 
            this.TCusMobile.BorderColorFocused = System.Drawing.Color.DarkCyan;
            this.TCusMobile.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TCusMobile.BorderColorMouseHover = System.Drawing.Color.DarkCyan;
            this.TCusMobile.BorderThickness = 3;
            this.TCusMobile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TCusMobile.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TCusMobile.ForeColor = System.Drawing.Color.White;
            this.TCusMobile.isPassword = false;
            this.TCusMobile.Location = new System.Drawing.Point(476, 157);
            this.TCusMobile.Margin = new System.Windows.Forms.Padding(4);
            this.TCusMobile.Name = "TCusMobile";
            this.TCusMobile.Size = new System.Drawing.Size(272, 35);
            this.TCusMobile.TabIndex = 52;
            this.TCusMobile.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TCusAmount
            // 
            this.TCusAmount.BorderColorFocused = System.Drawing.Color.DarkCyan;
            this.TCusAmount.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TCusAmount.BorderColorMouseHover = System.Drawing.Color.DarkCyan;
            this.TCusAmount.BorderThickness = 3;
            this.TCusAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TCusAmount.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TCusAmount.ForeColor = System.Drawing.Color.White;
            this.TCusAmount.isPassword = false;
            this.TCusAmount.Location = new System.Drawing.Point(476, 301);
            this.TCusAmount.Margin = new System.Windows.Forms.Padding(4);
            this.TCusAmount.Name = "TCusAmount";
            this.TCusAmount.Size = new System.Drawing.Size(272, 35);
            this.TCusAmount.TabIndex = 55;
            this.TCusAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerNameDataGridViewTextBoxColumn,
            this.customreNIDDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cutomerNameTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(772, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(404, 271);
            this.dataGridView1.TabIndex = 56;
            // 
            // cutomerNameTableBindingSource
            // 
            this.cutomerNameTableBindingSource.DataMember = "CutomerNameTable";
            this.cutomerNameTableBindingSource.DataSource = this.ispDBDataSet2;
            // 
            // ispDBDataSet2
            // 
            this.ispDBDataSet2.DataSetName = "IspDBDataSet2";
            this.ispDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.BBackHome.Location = new System.Drawing.Point(12, 7);
            this.BBackHome.Name = "BBackHome";
            this.BBackHome.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.BBackHome.OnHovercolor = System.Drawing.Color.Teal;
            this.BBackHome.OnHoverTextColor = System.Drawing.Color.White;
            this.BBackHome.selected = false;
            this.BBackHome.Size = new System.Drawing.Size(102, 55);
            this.BBackHome.TabIndex = 57;
            this.BBackHome.Text = "Back";
            this.BBackHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BBackHome.Textcolor = System.Drawing.Color.White;
            this.BBackHome.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBackHome.Click += new System.EventHandler(this.BBackHome_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(350, 258);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 22);
            this.label10.TabIndex = 58;
            this.label10.Text = "Package No";
            // 
            // cutomerNameTableTableAdapter
            // 
            this.cutomerNameTableTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(477, 257);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(271, 26);
            this.comboBox2.TabIndex = 60;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn1,
            this.customerMobileDataGridViewTextBoxColumn,
            this.customerEmailDataGridViewTextBoxColumn,
            this.customerLocationIDDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.customerContactTableBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(772, 361);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(404, 200);
            this.dataGridView2.TabIndex = 61;
            // 
            // customerContactTableBindingSource
            // 
            this.customerContactTableBindingSource.DataMember = "CustomerContactTable";
            this.customerContactTableBindingSource.DataSource = this.ispDBDataSet11;
            // 
            // ispDBDataSet11
            // 
            this.ispDBDataSet11.DataSetName = "IspDBDataSet11";
            this.ispDBDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerLocationTableBindingSource
            // 
            this.customerLocationTableBindingSource.DataMember = "CustomerLocationTable";
            this.customerLocationTableBindingSource.DataSource = this.ispDBDataSet7;
            // 
            // ispDBDataSet7
            // 
            this.ispDBDataSet7.DataSetName = "IspDBDataSet7";
            this.ispDBDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerLocationTableTableAdapter
            // 
            this.customerLocationTableTableAdapter.ClearBeforeFill = true;
            // 
            // customerContactTableTableAdapter
            // 
            this.customerContactTableTableAdapter.ClearBeforeFill = true;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerNameDataGridViewTextBoxColumn.Width = 130;
            // 
            // customreNIDDataGridViewTextBoxColumn
            // 
            this.customreNIDDataGridViewTextBoxColumn.DataPropertyName = "CustomreNID";
            this.customreNIDDataGridViewTextBoxColumn.HeaderText = "CustomreNID";
            this.customreNIDDataGridViewTextBoxColumn.Name = "customreNIDDataGridViewTextBoxColumn";
            this.customreNIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.customreNIDDataGridViewTextBoxColumn.Width = 130;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerIDDataGridViewTextBoxColumn1
            // 
            this.customerIDDataGridViewTextBoxColumn1.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn1.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn1.Name = "customerIDDataGridViewTextBoxColumn1";
            this.customerIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // customerMobileDataGridViewTextBoxColumn
            // 
            this.customerMobileDataGridViewTextBoxColumn.DataPropertyName = "CustomerMobile";
            this.customerMobileDataGridViewTextBoxColumn.HeaderText = "CustomerMobile";
            this.customerMobileDataGridViewTextBoxColumn.Name = "customerMobileDataGridViewTextBoxColumn";
            this.customerMobileDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerEmailDataGridViewTextBoxColumn
            // 
            this.customerEmailDataGridViewTextBoxColumn.DataPropertyName = "CustomerEmail";
            this.customerEmailDataGridViewTextBoxColumn.HeaderText = "CustomerEmail";
            this.customerEmailDataGridViewTextBoxColumn.Name = "customerEmailDataGridViewTextBoxColumn";
            this.customerEmailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerLocationIDDataGridViewTextBoxColumn
            // 
            this.customerLocationIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerLocationID";
            this.customerLocationIDDataGridViewTextBoxColumn.HeaderText = "CustomerLocationID";
            this.customerLocationIDDataGridViewTextBoxColumn.Name = "customerLocationIDDataGridViewTextBoxColumn";
            this.customerLocationIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FCustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1215, 582);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.BBackHome);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TCusAmount);
            this.Controls.Add(this.TCusMobile);
            this.Controls.Add(this.TCusEmail);
            this.Controls.Add(this.TCusNID);
            this.Controls.Add(this.TCusName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FCustomerList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer List";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FCustomerList_FormClosing);
            this.Load += new System.EventHandler(this.FCustomerList_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cutomerNameTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ispDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerContactTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ispDBDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerLocationTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ispDBDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label15;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuMetroTextbox TCustomerSearch;
        private Bunifu.Framework.UI.BunifuMetroTextbox TCusName;
        private Bunifu.Framework.UI.BunifuMetroTextbox TCusNID;
        private Bunifu.Framework.UI.BunifuMetroTextbox TCusEmail;
        private Bunifu.Framework.UI.BunifuMetroTextbox TCusMobile;
        private Bunifu.Framework.UI.BunifuMetroTextbox TCusAmount;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuFlatButton BBackHome;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton7;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton5;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label10;
        private IspDBDataSet2 ispDBDataSet2;
        private System.Windows.Forms.BindingSource cutomerNameTableBindingSource;
        private IspDBDataSet2TableAdapters.CutomerNameTableTableAdapter cutomerNameTableTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private IspDBDataSet7 ispDBDataSet7;
        private System.Windows.Forms.BindingSource customerLocationTableBindingSource;
        private IspDBDataSet7TableAdapters.CustomerLocationTableTableAdapter customerLocationTableTableAdapter;
        private IspDBDataSet11 ispDBDataSet11;
        private System.Windows.Forms.BindingSource customerContactTableBindingSource;
        private IspDBDataSet11TableAdapters.CustomerContactTableTableAdapter customerContactTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customreNIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerMobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerLocationIDDataGridViewTextBoxColumn;
    }
}