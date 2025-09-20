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
using System.Diagnostics;

namespace Proje_Hastane
{
    public partial class FrmHastaGiris : Form
    {
        public FrmHastaGiris()
        {
            InitializeComponent();
        }


        sqlbaglantisi bgl = new sqlbaglantisi();

        private void LnkUyeOL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaKayit fr = new FrmHastaKayit();
            MessageBox.Show("Daha Önce Kayıt Yaptırmamış Hastalarımız İçindir Eğer Kaydınız Varsa Lütfen Giriş Yapınız", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            fr.Show();


        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            FrmSifreGuncelleHasta fr = new FrmSifreGuncelleHasta();
            fr.Show();
            this.Hide();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

            if (gtc.Text.Length == 11)
            {
                SqlCommand komut = new SqlCommand("select * from Tbl_Hastalar where HastaTC = @p1 and HastaSifre = @p2", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", gtc.Text);
                komut.Parameters.AddWithValue("@p2", gsifre.Text);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    if (checkBox1.Checked)
                    {

                        MessageBox.Show("Tebrikler Bilgileri Doğru Girdiniz Giriş Başarılı!", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        FrmHastaDetay fr = new FrmHastaDetay();
                        fr.tc = gtc.Text;
                        fr.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("KVKK Aydınlatma Metnini Okumadınız Lütfen Okuyup Onaylayınız", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Hatalı Giriş Yaptınız Tekrar Deneyiniz!!!", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                bgl.baglanti().Close();
            }

            else
            {
                MessageBox.Show("Lütfen 11 Haneli TC Kimlik Numaranızı Giriniz", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            try
            {
                MessageBox.Show("KVKK Aydınlatma Metni İçin Lütfen Tıklayınız", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = "https://www.kvkk.gov.tr/Icerik/7137/2021-761",
                    UseShellExecute = true

                });

                checkBox1.Checked = true;
            }
            catch
            {
                MessageBox.Show("Hata Oluştu suncucuyla bağlantı kesildi", "Bağlantınızı Kontrol edniniz", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void FrmHastaGiris_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            FrmDashBoard frmDashBoard = new FrmDashBoard();
            frmDashBoard.Show();
            this.Hide();
        }
    }

}

