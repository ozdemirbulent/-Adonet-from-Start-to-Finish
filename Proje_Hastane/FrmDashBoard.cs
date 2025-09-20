using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class FrmDashBoard : Form
    {
        public FrmDashBoard()
        {
            InitializeComponent();
        }

        private void BtnHastaGirisi_Click(object sender, EventArgs e)
        {
            FrmHastaGiris fr = new FrmHastaGiris();
            MessageBox.Show("Hasta Giriş Paneline Yönlendiriliyorsunuz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fr.Show();
            this.Hide();
        }

        private void BtnDoktorGirisi_Click(object sender, EventArgs e)
        {
            FrmDoktorGiris fr = new FrmDoktorGiris();
            MessageBox.Show("Doktor Giriş Paneline Yönlendiriliyorsunuz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fr.Show();
            this.Hide();
        }

        private void BtnSekreterGirisi_Click(object sender, EventArgs e)
        {
            FrmYönetimGiris fr = new FrmYönetimGiris();
            MessageBox.Show("Sekreter Giriş Paneline Yönlendiriliyorsunuz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fr.Show();
            this.Hide();
        }

    
    }
}
