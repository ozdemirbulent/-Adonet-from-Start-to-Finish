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
    public partial class FrmSifreGuncelleDoktor : Form
    {
        public FrmSifreGuncelleDoktor()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();



        private void guna2Button1_Click(object sender, EventArgs e)
        {

            if (gunaTC1.Text.Length == 11)
            {
                if (gunaSifre2.Text.Length > 0)
                {

                    try
                    {

                        SqlCommand komut = new SqlCommand("update Tbl_Hastalar set HastaSifre = @p1 where HastaTC = @p2", bgl.baglanti());
                        komut.Parameters.AddWithValue("@p1", gunaSifre2.Text);
                        komut.Parameters.AddWithValue("@p2", gunaTC1.Text);
                        komut.ExecuteNonQuery();

                        MessageBox.Show("Doktor Bilgileri Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.None);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        bgl.baglanti().Close();
                    }

                }
                else
                {
                    MessageBox.Show("Hatalı Kullanım mevcuttur.", "Uygun TC Giriniz.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

            else
            {
                MessageBox.Show("Hatalı Kullanım mevcuttur.", "Uygun TC Giriniz.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

