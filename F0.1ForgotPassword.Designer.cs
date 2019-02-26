namespace Presentation_Layer
{
    partial class FForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FForgotPassword));
            this.ButtonSend = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMail = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.BBack2Login = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // ButtonSend
            // 
            this.ButtonSend.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ButtonSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ButtonSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonSend.BorderRadius = 0;
            this.ButtonSend.ButtonText = "Send Password";
            this.ButtonSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSend.DisabledColor = System.Drawing.Color.Gray;
            this.ButtonSend.Iconcolor = System.Drawing.Color.Transparent;
            this.ButtonSend.Iconimage = ((System.Drawing.Image)(resources.GetObject("ButtonSend.Iconimage")));
            this.ButtonSend.Iconimage_right = null;
            this.ButtonSend.Iconimage_right_Selected = null;
            this.ButtonSend.Iconimage_Selected = null;
            this.ButtonSend.IconMarginLeft = 0;
            this.ButtonSend.IconMarginRight = 0;
            this.ButtonSend.IconRightVisible = true;
            this.ButtonSend.IconRightZoom = 0D;
            this.ButtonSend.IconVisible = true;
            this.ButtonSend.IconZoom = 90D;
            this.ButtonSend.IsTab = false;
            this.ButtonSend.Location = new System.Drawing.Point(197, 253);
            this.ButtonSend.Name = "ButtonSend";
            this.ButtonSend.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ButtonSend.OnHovercolor = System.Drawing.Color.DarkGray;
            this.ButtonSend.OnHoverTextColor = System.Drawing.Color.White;
            this.ButtonSend.selected = false;
            this.ButtonSend.Size = new System.Drawing.Size(165, 48);
            this.ButtonSend.TabIndex = 0;
            this.ButtonSend.Text = "Send Password";
            this.ButtonSend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonSend.Textcolor = System.Drawing.Color.White;
            this.ButtonSend.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 183);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label1.Size = new System.Drawing.Size(77, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email";
            // 
            // txtMail
            // 
            this.txtMail.BorderColorFocused = System.Drawing.Color.SpringGreen;
            this.txtMail.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMail.BorderColorMouseHover = System.Drawing.Color.SpringGreen;
            this.txtMail.BorderThickness = 3;
            this.txtMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMail.ForeColor = System.Drawing.Color.White;
            this.txtMail.isPassword = false;
            this.txtMail.Location = new System.Drawing.Point(160, 182);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(202, 39);
            this.txtMail.TabIndex = 2;
            this.txtMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(59, 90);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(303, 58);
            this.label2.TabIndex = 3;
            this.label2.Text = "If you forgotten your password then fill up your\r\nE-mail address and we will send" +
    " your password \r\nto your mail.";
            // 
            // BBack2Login
            // 
            this.BBack2Login.ActiveBorderThickness = 1;
            this.BBack2Login.ActiveCornerRadius = 20;
            this.BBack2Login.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.BBack2Login.ActiveForecolor = System.Drawing.Color.White;
            this.BBack2Login.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.BBack2Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.BBack2Login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BBack2Login.BackgroundImage")));
            this.BBack2Login.ButtonText = "Back";
            this.BBack2Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BBack2Login.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBack2Login.ForeColor = System.Drawing.Color.SeaGreen;
            this.BBack2Login.IdleBorderThickness = 1;
            this.BBack2Login.IdleCornerRadius = 20;
            this.BBack2Login.IdleFillColor = System.Drawing.Color.White;
            this.BBack2Login.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.BBack2Login.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BBack2Login.Location = new System.Drawing.Point(15, 16);
            this.BBack2Login.Margin = new System.Windows.Forms.Padding(5);
            this.BBack2Login.Name = "BBack2Login";
            this.BBack2Login.Size = new System.Drawing.Size(88, 45);
            this.BBack2Login.TabIndex = 4;
            this.BBack2Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BBack2Login.Click += new System.EventHandler(this.BBack2Login_Click);
            // 
            // FForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(444, 344);
            this.Controls.Add(this.BBack2Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonSend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recover Your Password";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FForgotPassword_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton ButtonSend;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtMail;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 BBack2Login;
    }
}