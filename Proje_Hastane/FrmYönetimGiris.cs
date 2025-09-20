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
    public partial class FrmYönetimGiris : Form
    {

        public FrmYönetimGiris()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();


        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

            if (MskTC1.Text != null)
            {

                SqlCommand komut = new SqlCommand("Select * From Tbl_Sekreter Where SekreterTC = @p1 and SekreterSifre = @p2", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", MskTC1.Text);
                komut.Parameters.AddWithValue("@p2", TxtSifre1.Text);
                SqlDataReader dr = komut.ExecuteReader();


                if (dr.Read())
                {
                    FrmYönetimDetay frs = new FrmYönetimDetay();
                    frs.TCnumara = MskTC1.Text;
                    frs.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı İşlem veritabanı ile ilişki kurulamadı");
                }


            }

            else
            {
                MessageBox.Show("Lütfen TC Kimlik Numarasını Giriniz", "Hatalı Kullanım Mevcuttur", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            bgl.baglanti().Close();

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            FrmDashBoard frmDashBoard = new FrmDashBoard();
            frmDashBoard.Show();
            this.Hide();
        }
    }
}
