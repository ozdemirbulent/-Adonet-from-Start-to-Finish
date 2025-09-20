namespace Proje_Hastane
{
    partial class FrmHastaKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaKayit));
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GunaAd = new Guna.UI2.WinForms.Guna2TextBox();
            this.GunaSoyad = new Guna.UI2.WinForms.Guna2TextBox();
            this.GunaSifre = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.gunacmb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MskTC
            // 
            this.MskTC.BackColor = System.Drawing.Color.Black;
            this.MskTC.ForeColor = System.Drawing.SystemColors.Info;
            this.MskTC.Location = new System.Drawing.Point(207, 127);
            this.MskTC.Margin = new System.Windows.Forms.Padding(4);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(321, 40);
            this.MskTC.TabIndex = 3;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 236);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 35);
            this.label3.TabIndex = 7;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 35);
            this.label2.TabIndex = 6;
            this.label2.Text = "TC Kimlik No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(151, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 35);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(110, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 35);
            this.label4.TabIndex = 12;
            this.label4.Text = "Soyad:";
            // 
            // MskTelefon
            // 
            this.MskTelefon.BackColor = System.Drawing.Color.Black;
            this.MskTelefon.ForeColor = System.Drawing.SystemColors.Info;
            this.MskTelefon.Location = new System.Drawing.Point(207, 175);
            this.MskTelefon.Margin = new System.Windows.Forms.Padding(4);
            this.MskTelefon.Mask = "(999) 000-0000";
            this.MskTelefon.Name = "MskTelefon";
            this.MskTelefon.Size = new System.Drawing.Size(321, 40);
            this.MskTelefon.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 178);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 35);
            this.label5.TabIndex = 15;
            this.label5.Text = "Telefon:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 285);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 35);
            this.label6.TabIndex = 17;
            this.label6.Text = "Cinsiyet:";
            // 
            // GunaAd
            // 
            this.GunaAd.BackColor = System.Drawing.Color.Transparent;
            this.GunaAd.BorderColor = System.Drawing.Color.White;
            this.GunaAd.BorderRadius = 10;
            this.GunaAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.GunaAd.DefaultText = "";
            this.GunaAd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.GunaAd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.GunaAd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.GunaAd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.GunaAd.FillColor = System.Drawing.Color.Black;
            this.GunaAd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GunaAd.Font = new System.Drawing.Font("Ravie", 10.8F);
            this.GunaAd.ForeColor = System.Drawing.Color.Maroon;
            this.GunaAd.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.GunaAd.HoverState.FillColor = System.Drawing.Color.Yellow;
            this.GunaAd.HoverState.ForeColor = System.Drawing.Color.Navy;
            this.GunaAd.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.GunaAd.Location = new System.Drawing.Point(207, 14);
            this.GunaAd.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.GunaAd.Name = "GunaAd";
            this.GunaAd.PlaceholderForeColor = System.Drawing.Color.White;
            this.GunaAd.PlaceholderText = "Adınızı Giriniz...";
            this.GunaAd.SelectedText = "";
            this.GunaAd.Size = new System.Drawing.Size(321, 47);
            this.GunaAd.TabIndex = 19;
            // 
            // GunaSoyad
            // 
            this.GunaSoyad.BackColor = System.Drawing.Color.Transparent;
            this.GunaSoyad.BorderColor = System.Drawing.Color.White;
            this.GunaSoyad.BorderRadius = 10;
            this.GunaSoyad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.GunaSoyad.DefaultText = "";
            this.GunaSoyad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.GunaSoyad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.GunaSoyad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.GunaSoyad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.GunaSoyad.FillColor = System.Drawing.Color.Black;
            this.GunaSoyad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GunaSoyad.Font = new System.Drawing.Font("Ravie", 10.8F);
            this.GunaSoyad.ForeColor = System.Drawing.Color.Maroon;
            this.GunaSoyad.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.GunaSoyad.HoverState.FillColor = System.Drawing.Color.Yellow;
            this.GunaSoyad.HoverState.ForeColor = System.Drawing.Color.Navy;
            this.GunaSoyad.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.GunaSoyad.Location = new System.Drawing.Point(207, 71);
            this.GunaSoyad.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.GunaSoyad.Name = "GunaSoyad";
            this.GunaSoyad.PlaceholderForeColor = System.Drawing.Color.White;
            this.GunaSoyad.PlaceholderText = "Soyadınızı Giriniz...";
            this.GunaSoyad.SelectedText = "";
            this.GunaSoyad.Size = new System.Drawing.Size(321, 47);
            this.GunaSoyad.TabIndex = 20;
            // 
            // GunaSifre
            // 
            this.GunaSifre.BackColor = System.Drawing.Color.Transparent;
            this.GunaSifre.BorderColor = System.Drawing.Color.White;
            this.GunaSifre.BorderRadius = 10;
            this.GunaSifre.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.GunaSifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.GunaSifre.DefaultText = "";
            this.GunaSifre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.GunaSifre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.GunaSifre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.GunaSifre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.GunaSifre.FillColor = System.Drawing.Color.Black;
            this.GunaSifre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GunaSifre.Font = new System.Drawing.Font("Ravie", 10.8F);
            this.GunaSifre.ForeColor = System.Drawing.Color.Maroon;
            this.GunaSifre.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.GunaSifre.HoverState.FillColor = System.Drawing.Color.Yellow;
            this.GunaSifre.HoverState.ForeColor = System.Drawing.Color.Navy;
            this.GunaSifre.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.GunaSifre.Location = new System.Drawing.Point(207, 224);
            this.GunaSifre.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.GunaSifre.Name = "GunaSifre";
            this.GunaSifre.PlaceholderForeColor = System.Drawing.Color.White;
            this.GunaSifre.PlaceholderText = "Şifrenizi Giriniz...";
            this.GunaSifre.SelectedText = "";
            this.GunaSifre.Size = new System.Drawing.Size(321, 47);
            this.GunaSifre.TabIndex = 21;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.Animated = true;
            this.guna2GradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.BorderColor = System.Drawing.Color.IndianRed;
            this.guna2GradientButton1.BorderRadius = 15;
            this.guna2GradientButton1.BorderThickness = 1;
            this.guna2GradientButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.FillColor = System.Drawing.Color.Black;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.BorderColor = System.Drawing.Color.Red;
            this.guna2GradientButton1.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.guna2GradientButton1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.guna2GradientButton1.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2GradientButton1.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2GradientButton1.HoverState.ForeColor = System.Drawing.Color.Yellow;
            this.guna2GradientButton1.Location = new System.Drawing.Point(207, 339);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(134, 56);
            this.guna2GradientButton1.TabIndex = 22;
            this.guna2GradientButton1.Text = "Kayıt Ol";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.FillColor = System.Drawing.Color.DimGray;
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 50F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(794, 22);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(264, 145);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 23;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // gunacmb
            // 
            this.gunacmb.BackColor = System.Drawing.Color.Transparent;
            this.gunacmb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gunacmb.BorderRadius = 15;
            this.gunacmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunacmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunacmb.FillColor = System.Drawing.Color.Black;
            this.gunacmb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunacmb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunacmb.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunacmb.ForeColor = System.Drawing.Color.Snow;
            this.gunacmb.ItemHeight = 30;
            this.gunacmb.Location = new System.Drawing.Point(207, 283);
            this.gunacmb.Name = "gunacmb";
            this.gunacmb.Size = new System.Drawing.Size(321, 36);
            this.gunacmb.TabIndex = 24;
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.Animated = true;
            this.guna2GradientButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton2.BorderColor = System.Drawing.Color.IndianRed;
            this.guna2GradientButton2.BorderRadius = 15;
            this.guna2GradientButton2.BorderThickness = 1;
            this.guna2GradientButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2GradientButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton2.FillColor = System.Drawing.Color.Black;
            this.guna2GradientButton2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.guna2GradientButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton2.HoverState.BorderColor = System.Drawing.Color.Red;
            this.guna2GradientButton2.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.guna2GradientButton2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.guna2GradientButton2.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2GradientButton2.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2GradientButton2.HoverState.ForeColor = System.Drawing.Color.Yellow;
            this.guna2GradientButton2.Location = new System.Drawing.Point(367, 339);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.Size = new System.Drawing.Size(134, 56);
            this.guna2GradientButton2.TabIndex = 25;
            this.guna2GradientButton2.Text = "Geri Dön";
            this.guna2GradientButton2.Click += new System.EventHandler(this.guna2GradientButton2_Click);
            // 
            // FrmHastaKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(1084, 452);
            this.Controls.Add(this.guna2GradientButton2);
            this.Controls.Add(this.gunacmb);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.GunaSifre);
            this.Controls.Add(this.GunaSoyad);
            this.Controls.Add(this.GunaAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MskTelefon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MinimizeBox = false;
            this.Name = "FrmHastaKayit";
            this.Text = "Hasta Kayıt";
            this.Load += new System.EventHandler(this.FrmHastaKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox MskTelefon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox GunaAd;
        private Guna.UI2.WinForms.Guna2TextBox GunaSoyad;
        private Guna.UI2.WinForms.Guna2TextBox GunaSifre;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2ComboBox gunacmb;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
    }
}