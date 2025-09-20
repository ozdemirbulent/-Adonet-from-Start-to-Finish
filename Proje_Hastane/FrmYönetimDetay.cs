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
    public partial class FrmYönetimDetay : Form
    {
        public FrmYönetimDetay()
        {
            InitializeComponent();
        }


        public string TCnumara;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            LblTC.Text = TCnumara;

            // ad-soyad

            SqlCommand komut1 = new SqlCommand("select SekreterAdSoyad from Tbl_Sekreter where SekreterTC = @p1",bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1",LblTC.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                LblAdSoyad.Text = dr1[0].ToString();
            }

            bgl.baglanti().Close();

            // Branşları datagrid yapısına aktarma

            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Branslar",bgl.baglanti());
            da.Fill(dt1);
            dataGridView2.DataSource = dt1;




            // Doktorları listeye aktarma 

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select (DoktorAd + ' ' +DoktorSoyad) as 'Doktorlar',DoktorBrans as 'Branş' from Tbl_Doktorlar", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView3.DataSource = dt2;



            // Bransları combobaxa atama

            SqlCommand komut2 = new SqlCommand("select BransAd from Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();

            while (dr2.Read())
            {
                CmbBrans.Items.Add(dr2[0]);
            }

            bgl.baglanti().Close();






        }


        // randevu bilgilerini kaydetme
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@r1,@r2,@r3,@r4)",bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@r1",MskTarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2",MskSaat.Text);
            komutkaydet.Parameters.AddWithValue("@r3",CmbBrans.Text);
            komutkaydet.Parameters.AddWithValue("@r4",CmbDoktor.Text);

            komutkaydet.ExecuteNonQuery();

            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu","Tebrikler",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);



        }

        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorBrans = @p1",bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", CmbBrans.Text);
            SqlDataReader dr4 = komut3.ExecuteReader();

           while (dr4.Read()) 
            {
                CmbDoktor.Items.Add(dr4[0] + " " + dr4[1]);
            }



           bgl.baglanti().Close();
        }



        // duyurular bölümünü veritabanına kaydetme

        private void BtnDuyuruOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut4 = new SqlCommand("insert into Tbl_Duyurular (Duyuru) values (@d1)",bgl.baglanti());
            komut4.Parameters.AddWithValue("@d1",RchDuyuru.Text);
            komut4.ExecuteNonQuery();
            bgl.baglanti().Close();


            MessageBox.Show("Duyuru Oluşturuldu","Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }

        private void BtnDoktorPaneli_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli frs = new FrmDoktorPaneli();
            frs.Show();
          
        }

        private void BtnBransPaneli_Click(object sender, EventArgs e)
        {
            FrmBrans frm = new FrmBrans();
            frm.Show();
           
        }

        private void BtnRandevuListesi_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi fr = new FrmRandevuListesi();
            fr.Show();
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr = new FrmDuyurular();
            fr.Show();
        }
    }
}
