namespace Proje_Hastane
{
    partial class FrmSifreGuncelleDoktor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSifreGuncelleDoktor));
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.gunaTC1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaSifre2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.DarkCyan;
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.BorderThickness = 2;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Yellow;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.HoverState.BorderColor = System.Drawing.Color.DarkRed;
            this.guna2Button1.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.SpringGreen;
            this.guna2Button1.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.World, ((byte)(162)));
            this.guna2Button1.HoverState.ForeColor = System.Drawing.Color.Navy;
            this.guna2Button1.Location = new System.Drawing.Point(225, 228);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(15, 3, 3, 10);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Padding = new System.Windows.Forms.Padding(5, 15, 5, 5);
            this.guna2Button1.Size = new System.Drawing.Size(192, 71);
            this.guna2Button1.TabIndex = 5;
            this.guna2Button1.Text = "Güncelle";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // gunaTC1
            // 
            this.gunaTC1.BackColor = System.Drawing.Color.Transparent;
            this.gunaTC1.BorderColor = System.Drawing.Color.Transparent;
            this.gunaTC1.BorderRadius = 15;
            this.gunaTC1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTC1.DefaultText = "";
            this.gunaTC1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gunaTC1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gunaTC1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunaTC1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunaTC1.FillColor = System.Drawing.Color.SeaShell;
            this.gunaTC1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaTC1.Font = new System.Drawing.Font("Snap ITC", 7.8F);
            this.gunaTC1.ForeColor = System.Drawing.Color.Black;
            this.gunaTC1.HoverState.BorderColor = System.Drawing.Color.Black;
            this.gunaTC1.HoverState.FillColor = System.Drawing.Color.Red;
            this.gunaTC1.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gunaTC1.Location = new System.Drawing.Point(140, 87);
            this.gunaTC1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.gunaTC1.Name = "gunaTC1";
            this.gunaTC1.PlaceholderText = "Tc No Giriniz...";
            this.gunaTC1.SelectedText = "";
            this.gunaTC1.Size = new System.Drawing.Size(363, 53);
            this.gunaTC1.TabIndex = 7;
            // 
            // gunaSifre2
            // 
            this.gunaSifre2.BackColor = System.Drawing.Color.Transparent;
            this.gunaSifre2.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.gunaSifre2.BorderRadius = 15;
            this.gunaSifre2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.gunaSifre2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaSifre2.DefaultText = "";
            this.gunaSifre2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gunaSifre2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gunaSifre2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunaSifre2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunaSifre2.FillColor = System.Drawing.Color.SeaShell;
            this.gunaSifre2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaSifre2.Font = new System.Drawing.Font("Snap ITC", 7.8F);
            this.gunaSifre2.ForeColor = System.Drawing.Color.Maroon;
            this.gunaSifre2.HoverState.BorderColor = System.Drawing.Color.Black;
            this.gunaSifre2.HoverState.FillColor = System.Drawing.Color.Red;
            this.gunaSifre2.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gunaSifre2.Location = new System.Drawing.Point(140, 154);
            this.gunaSifre2.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.gunaSifre2.Name = "gunaSifre2";
            this.gunaSifre2.PlaceholderText = "Şifre Giriniz.";
            this.gunaSifre2.SelectedText = "";
            this.gunaSifre2.Size = new System.Drawing.Size(363, 53);
            this.gunaSifre2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 49);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tc No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 49);
            this.label2.TabIndex = 10;
            this.label2.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(98, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(446, 48);
            this.label3.TabIndex = 11;
            this.label3.Text = "Şifre Güncelleme Alanı";
            // 
            // FrmSifreGuncelleDoktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 392);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gunaSifre2);
            this.Controls.Add(this.gunaTC1);
            this.Controls.Add(this.guna2Button1);
            this.DoubleBuffered = true;
            this.Name = "FrmSifreGuncelleDoktor";
            this.Text = "Doktor Şifre Güncelleme Alanı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox gunaTC1;
        private Guna.UI2.WinForms.Guna2TextBox gunaSifre2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}