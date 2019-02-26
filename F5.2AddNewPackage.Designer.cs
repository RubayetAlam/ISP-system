namespace Presentation_Layer
{
    partial class FAddNewPackage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAddNewPackage));
            this.AddPackage = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tprice = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tspeed = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tname = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BBack4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // AddPackage
            // 
            this.AddPackage.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.AddPackage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.AddPackage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddPackage.BorderRadius = 0;
            this.AddPackage.ButtonText = "Add Package";
            this.AddPackage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddPackage.DisabledColor = System.Drawing.Color.Gray;
            this.AddPackage.Iconcolor = System.Drawing.Color.Transparent;
            this.AddPackage.Iconimage = ((System.Drawing.Image)(resources.GetObject("AddPackage.Iconimage")));
            this.AddPackage.Iconimage_right = null;
            this.AddPackage.Iconimage_right_Selected = null;
            this.AddPackage.Iconimage_Selected = null;
            this.AddPackage.IconMarginLeft = 0;
            this.AddPackage.IconMarginRight = 0;
            this.AddPackage.IconRightVisible = true;
            this.AddPackage.IconRightZoom = 0D;
            this.AddPackage.IconVisible = true;
            this.AddPackage.IconZoom = 90D;
            this.AddPackage.IsTab = false;
            this.AddPackage.Location = new System.Drawing.Point(163, 251);
            this.AddPackage.Name = "AddPackage";
            this.AddPackage.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.AddPackage.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.AddPackage.OnHoverTextColor = System.Drawing.Color.White;
            this.AddPackage.selected = false;
            this.AddPackage.Size = new System.Drawing.Size(191, 48);
            this.AddPackage.TabIndex = 21;
            this.AddPackage.Text = "Add Package";
            this.AddPackage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddPackage.Textcolor = System.Drawing.Color.White;
            this.AddPackage.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPackage.Click += new System.EventHandler(this.AddPackage_Click);
            // 
            // tprice
            // 
            this.tprice.BorderColorFocused = System.Drawing.Color.MediumSpringGreen;
            this.tprice.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tprice.BorderColorMouseHover = System.Drawing.Color.MediumSpringGreen;
            this.tprice.BorderThickness = 3;
            this.tprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tprice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tprice.ForeColor = System.Drawing.Color.White;
            this.tprice.isPassword = false;
            this.tprice.Location = new System.Drawing.Point(163, 191);
            this.tprice.Margin = new System.Windows.Forms.Padding(4);
            this.tprice.Name = "tprice";
            this.tprice.Size = new System.Drawing.Size(191, 35);
            this.tprice.TabIndex = 20;
            this.tprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tspeed
            // 
            this.tspeed.BorderColorFocused = System.Drawing.Color.MediumSpringGreen;
            this.tspeed.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tspeed.BorderColorMouseHover = System.Drawing.Color.MediumSpringGreen;
            this.tspeed.BorderThickness = 3;
            this.tspeed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tspeed.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tspeed.ForeColor = System.Drawing.Color.White;
            this.tspeed.isPassword = false;
            this.tspeed.Location = new System.Drawing.Point(163, 139);
            this.tspeed.Margin = new System.Windows.Forms.Padding(4);
            this.tspeed.Name = "tspeed";
            this.tspeed.Size = new System.Drawing.Size(191, 35);
            this.tspeed.TabIndex = 19;
            this.tspeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tname
            // 
            this.tname.BorderColorFocused = System.Drawing.Color.MediumSpringGreen;
            this.tname.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tname.BorderColorMouseHover = System.Drawing.Color.MediumSpringGreen;
            this.tname.BorderThickness = 3;
            this.tname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tname.ForeColor = System.Drawing.Color.White;
            this.tname.isPassword = false;
            this.tname.Location = new System.Drawing.Point(163, 84);
            this.tname.Margin = new System.Windows.Forms.Padding(4);
            this.tname.Name = "tname";
            this.tname.Size = new System.Drawing.Size(191, 35);
            this.tname.TabIndex = 17;
            this.tname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 190);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(4);
            this.label4.Size = new System.Drawing.Size(62, 27);
            this.label4.TabIndex = 16;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 137);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(4);
            this.label3.Size = new System.Drawing.Size(62, 27);
            this.label3.TabIndex = 15;
            this.label3.Text = "Speed";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 88);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(4);
            this.label1.Size = new System.Drawing.Size(125, 27);
            this.label1.TabIndex = 13;
            this.label1.Text = "Package Name";
            // 
            // BBack4
            // 
            this.BBack4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BBack4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.BBack4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BBack4.BorderRadius = 0;
            this.BBack4.ButtonText = "Back";
            this.BBack4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BBack4.DisabledColor = System.Drawing.Color.Gray;
            this.BBack4.Iconcolor = System.Drawing.Color.Transparent;
            this.BBack4.Iconimage = ((System.Drawing.Image)(resources.GetObject("BBack4.Iconimage")));
            this.BBack4.Iconimage_right = null;
            this.BBack4.Iconimage_right_Selected = null;
            this.BBack4.Iconimage_Selected = null;
            this.BBack4.IconMarginLeft = 0;
            this.BBack4.IconMarginRight = 0;
            this.BBack4.IconRightVisible = true;
            this.BBack4.IconRightZoom = 0D;
            this.BBack4.IconVisible = true;
            this.BBack4.IconZoom = 90D;
            this.BBack4.IsTab = false;
            this.BBack4.Location = new System.Drawing.Point(18, 12);
            this.BBack4.Name = "BBack4";
            this.BBack4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.BBack4.OnHovercolor = System.Drawing.Color.Teal;
            this.BBack4.OnHoverTextColor = System.Drawing.Color.White;
            this.BBack4.selected = false;
            this.BBack4.Size = new System.Drawing.Size(100, 55);
            this.BBack4.TabIndex = 22;
            this.BBack4.Text = "Back";
            this.BBack4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BBack4.Textcolor = System.Drawing.Color.White;
            this.BBack4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBack4.Click += new System.EventHandler(this.BBack4_Click);
            // 
            // FAddNewPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(376, 362);
            this.Controls.Add(this.BBack4);
            this.Controls.Add(this.AddPackage);
            this.Controls.Add(this.tprice);
            this.Controls.Add(this.tspeed);
            this.Controls.Add(this.tname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FAddNewPackage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Package";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FAddNewPackage_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton AddPackage;
        private Bunifu.Framework.UI.BunifuMetroTextbox tprice;
        private Bunifu.Framework.UI.BunifuMetroTextbox tspeed;
        private Bunifu.Framework.UI.BunifuMetroTextbox tname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton BBack4;
    }
}