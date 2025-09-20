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
    public partial class FrmDoktorBilgiDuzenle : Form
    {
        public FrmDoktorBilgiDuzenle()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        public string TC;
        private void FrmDoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            MskTC.Text = TC;
            SqlCommand komut = new SqlCommand("select * from Tbl_Doktorlar where DoktorTC =@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtAd.Text = dr[1].ToString();
                TxtSoyad.Text = dr[2].ToString();
                CmbBrans.Text = dr[3].ToString();
                TxtSifre.Text = dr[5].ToString();
            }
            bgl.baglanti().Close();


        }

        private void BtnBilgiGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Doktorlar set DoktorAd = @b1,DoktorSoyad = @b2,DoktorSifre = @b3 where DoktorTC=@b4",bgl.baglanti());
            komut.Parameters.AddWithValue("@b1",TxtAd.Text);  
            komut.Parameters.AddWithValue("@b2",TxtSoyad.Text);  
            komut.Parameters.AddWithValue("@b3",TxtSifre.Text);  
            komut.Parameters.AddWithValue("@b4",MskTC.Text);  
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi","Başarılı",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
        }
    }
}
