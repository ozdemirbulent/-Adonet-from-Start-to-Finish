using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class FrmSifreGuncelleHasta : Form
    {
        public FrmSifreGuncelleHasta()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {


            if (gunaTC.Text.Length == 11)
            {
                if (gunaSifre.Text.Length > 0)
                {
                    if (gunakontrol.Text == gunaSifre.Text)
                    {
                        try
                        {
                            SqlCommand komut = new SqlCommand("update Tbl_Hastalar set HastaSifre = @p1 where HastaTC = @p2", bgl.baglanti());
                            komut.Parameters.AddWithValue("@p1", gunaSifre.Text);
                            komut.Parameters.AddWithValue("@p2", gunaTC.Text);
                            komut.ExecuteNonQuery();

                            MessageBox.Show("Şifre Güncelleme İşlemi Başarıyla Gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        finally
                        {

                            bgl.baglanti().Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Şifreler Eşleşmiyor Lütfen Tekrar Deneyiniz.", "Hatalı Kullanım", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                
                }

                else
                {
                    MessageBox.Show("Hatalı Kullanım mevcuttur.", "Uygun Şifre Giriniz.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                MessageBox.Show("Hatalı Kullanım Mevcuttur.", "Tc No Uygun Kullanılmamıştır.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}