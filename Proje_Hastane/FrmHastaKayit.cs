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
    public partial class FrmHastaKayit : Form
    {
        public FrmHastaKayit()
        {
            InitializeComponent();
        }


        sqlbaglantisi bgl = new sqlbaglantisi();
     
       
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {


            if (GunaAd.Text == "" || GunaSoyad.Text == "" || GunaSifre.Text == "")
            {
                MessageBox.Show("Uygulama Sonlanıyor", "Hatalı Kullanım Tespit Edildi.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
            try
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Hastalar (HastaAd,HastaSoyad,HastaTC,HastaTelefon,HastaSifre,HastaCinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", GunaAd.Text);
                komut.Parameters.AddWithValue("@p2", GunaSoyad.Text);
                komut.Parameters.AddWithValue("@p3", MskTC.Text);
                komut.Parameters.AddWithValue("@p4", MskTelefon.Text);
                komut.Parameters.AddWithValue("@p5", GunaSifre.Text);
                komut.Parameters.AddWithValue("@p6", gunacmb.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kaydınız Başarılı Bir Şekilde Gerçekleşmiştir Şifreniz:" + GunaSifre.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bgl.baglanti().Close();
            }
    
           
        }

        private void FrmHastaKayit_Load(object sender, EventArgs e)
        {
            gunacmb.ValueMember = "HastaCinsiyet";
            gunacmb.DisplayMember = "Hastaid";
            gunacmb.Items.Add("Erkek");
            gunacmb.Items.Add("Kadın");
          

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            FrmDashBoard frmDashBoard = new FrmDashBoard();
            frmDashBoard.Show();
            this.Hide();
        }
    }
}
