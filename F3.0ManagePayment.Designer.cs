namespace Presentation_Layer
{
    partial class FManagePayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FManagePayment));
            this.BBackHome = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BDuePaymentList = new Bunifu.Framework.UI.BunifuTileButton();
            this.BAllPaymentList = new Bunifu.Framework.UI.BunifuTileButton();
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
            this.BBackHome.Size = new System.Drawing.Size(100, 55);
            this.BBackHome.TabIndex = 10;
            this.BBackHome.Text = "Back";
            this.BBackHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BBackHome.Textcolor = System.Drawing.Color.White;
            this.BBackHome.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBackHome.Click += new System.EventHandler(this.BBackHome_Click);
            // 
            // BDuePaymentList
            // 
            this.BDuePaymentList.BackColor = System.Drawing.Color.SeaGreen;
            this.BDuePaymentList.color = System.Drawing.Color.SeaGreen;
            this.BDuePaymentList.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.BDuePaymentList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BDuePaymentList.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BDuePaymentList.ForeColor = System.Drawing.Color.White;
            this.BDuePaymentList.Image = ((System.Drawing.Image)(resources.GetObject("BDuePaymentList.Image")));
            this.BDuePaymentList.ImagePosition = 18;
            this.BDuePaymentList.ImageZoom = 50;
            this.BDuePaymentList.LabelPosition = 36;
            this.BDuePaymentList.LabelText = "Update Payment";
            this.BDuePaymentList.Location = new System.Drawing.Point(23, 107);
            this.BDuePaymentList.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BDuePaymentList.Name = "BDuePaymentList";
            this.BDuePaymentList.Size = new System.Drawing.Size(256, 196);
            this.BDuePaymentList.TabIndex = 11;
            this.BDuePaymentList.Click += new System.EventHandler(this.BDuePaymentList_Click);
            // 
            // BAllPaymentList
            // 
            this.BAllPaymentList.BackColor = System.Drawing.Color.SeaGreen;
            this.BAllPaymentList.color = System.Drawing.Color.SeaGreen;
            this.BAllPaymentList.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.BAllPaymentList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BAllPaymentList.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAllPaymentList.ForeColor = System.Drawing.Color.White;
            this.BAllPaymentList.Image = ((System.Drawing.Image)(resources.GetObject("BAllPaymentList.Image")));
            this.BAllPaymentList.ImagePosition = 18;
            this.BAllPaymentList.ImageZoom = 50;
            this.BAllPaymentList.LabelPosition = 36;
            this.BAllPaymentList.LabelText = "All Payment List";
            this.BAllPaymentList.Location = new System.Drawing.Point(309, 107);
            this.BAllPaymentList.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BAllPaymentList.Name = "BAllPaymentList";
            this.BAllPaymentList.Size = new System.Drawing.Size(256, 196);
            this.BAllPaymentList.TabIndex = 12;
            this.BAllPaymentList.Click += new System.EventHandler(this.BAllPaymentList_Click);
            // 
            // FManagePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(606, 340);
            this.Controls.Add(this.BAllPaymentList);
            this.Controls.Add(this.BDuePaymentList);
            this.Controls.Add(this.BBackHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FManagePayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Payment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FManagePayment_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        public Bunifu.Framework.UI.BunifuFlatButton BBackHome;
        private Bunifu.Framework.UI.BunifuTileButton BDuePaymentList;
        private Bunifu.Framework.UI.BunifuTileButton BAllPaymentList;
    }
}