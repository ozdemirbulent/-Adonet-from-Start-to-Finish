using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Proje_Hastane
{
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSifreGuncelleDoktor fr = new FrmSifreGuncelleDoktor();
            MessageBox.Show("Şifre Güncelleme Alanına Giriş Yapılıyor", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            fr.Show();
            this.Hide();
        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("Select * from Tbl_Doktorlar where DoktorTC = @p1 and DoktorSifre = @p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTC.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmDoktorDetay frs = new FrmDoktorDetay();
                frs.tc = MskTC.Text;
                frs.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Giriş Hatalı", "Tekrar Deneyiniz", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            bgl.baglanti().Close();
        }
    }
}
