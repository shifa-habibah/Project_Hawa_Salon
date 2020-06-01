using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_SALON_HAWA_KEL11
{
    public partial class MENUADMIN : Form
    {
        public MENUADMIN()
        {
            InitializeComponent();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i != -1; i = Application.OpenForms.Count - 1)
            {
                Application.OpenForms[i].Close();
            }
        }

        private void btnTambahPgw_Click(object sender, EventArgs e)
        {
            TambahPegawai tambahPegawai = new TambahPegawai();
            tambahPegawai.Show();
        }

        private void btnTambahMbr_Click(object sender, EventArgs e)
        {
            TambahMember tambahMember = new TambahMember();
            tambahMember.Show();
        }

        private void btnTambahPRambut_Click(object sender, EventArgs e)
        {
            TambahPerawatanRambut tambahperawatanrambut = new TambahPerawatanRambut();
            tambahperawatanrambut.Show();
        }

        private void btnTambahPWajah_Click(object sender, EventArgs e)
        {
            TambahPerawatanWajah tambahperawatanWajah = new TambahPerawatanWajah();
            tambahperawatanWajah.Show();
        }

        private void btnTambahPLengkap_Click(object sender, EventArgs e)
        {
            TambahPaketLengkap tambahPaketJasaLengkap = new TambahPaketLengkap();
            tambahPaketJasaLengkap.Show();
        }

        private void btnTambahPMakeup_Click(object sender, EventArgs e)
        {
            TambahPaketMakeUp tambahpaketMakeUp = new TambahPaketMakeUp();
            tambahpaketMakeUp.Show();
        }

        private void btnTambahDSewa_Click(object sender, EventArgs e)
        {
            TambahPakaian tambahpakaian = new TambahPakaian();
            tambahpakaian.Show();
        }

        private void btnTambahPPengantin_Click(object sender, EventArgs e)
        {
            TambahPaketPengantin tambahpaketpengantin = new TambahPaketPengantin();
            tambahpaketpengantin.Show();
        }

        private void btnLihatPgw_Click(object sender, EventArgs e)
        {
            LihatPegawai lihatpegawai = new LihatPegawai();
            lihatpegawai.Show();
        }

        private void btnLihatMbr_Click(object sender, EventArgs e)
        {
            LihatMember lihatmember = new LihatMember();
            lihatmember.Show();
        }

        private void btnLihatPRambut_Click(object sender, EventArgs e)
        {
            LihatPerawatanRambut lihatPerawatanRambut = new LihatPerawatanRambut();
            lihatPerawatanRambut.Show();
        }

        private void btnLihatPWajah_Click(object sender, EventArgs e)
        {
            LihatPerawatanWajah lihatPerawatanWajah = new LihatPerawatanWajah();
            lihatPerawatanWajah.Show();
        }

        private void btnLihatPLengkap_Click(object sender, EventArgs e)
        {
            LihatPaketLengkap lihatPaketLengkap = new LihatPaketLengkap();
            lihatPaketLengkap.Show();
        }

        private void btnLihatDSewa_Click(object sender, EventArgs e)
        {
            LihatPakaian lihatPakaian = new LihatPakaian();
            lihatPakaian.Show();
        }

        private void btnLihatPMakeup_Click(object sender, EventArgs e)
        {
            LihatPaketMakeUp lihatPaketMakeUp = new LihatPaketMakeUp();
            lihatPaketMakeUp.Show();
        }

        private void btnLihatPPengantin_Click(object sender, EventArgs e)
        {
            LihatPaketPengantin lihatPaketPengantin = new LihatPaketPengantin();
            lihatPaketPengantin.Show();
        }

        private void btnUbahPgw_Click(object sender, EventArgs e)
        {
            UbahPegawai ubahPegawai = new UbahPegawai();
            ubahPegawai.Show();
        }

        private void btnUbahMbr_Click(object sender, EventArgs e)
        {
            UbahMember ubahMember = new UbahMember();
            ubahMember.Show();
        }

        private void btnUbahPRambut_Click(object sender, EventArgs e)
        {
            UbahPerawatanRambut ubahPerawatanRambut = new UbahPerawatanRambut();
            ubahPerawatanRambut.Show();
        }

        private void btnUbahPWajah_Click(object sender, EventArgs e)
        {
            UbahPerawatanWajah ubahPerawatanWajah = new UbahPerawatanWajah();
            ubahPerawatanWajah.Show();
        }

        private void btnUbahPLengkap_Click(object sender, EventArgs e)
        {
            UbahPaketLengkap ubahPaketLengkap = new UbahPaketLengkap();
            ubahPaketLengkap.Show();
        }

        private void btnUbahDSewa_Click(object sender, EventArgs e)
        {
            UbahPakaian ubahPakaian = new UbahPakaian();
            ubahPakaian.Show();
        }

        private void btnUbahPMakeup_Click(object sender, EventArgs e)
        {
            UbahPaketMakeUp ubahPaketMakeUp = new UbahPaketMakeUp();
            ubahPaketMakeUp.Show();
        }

        private void btnUbahPPengantin_Click(object sender, EventArgs e)
        {
            UbahPaketPengantin ubahPaketPengantin = new UbahPaketPengantin();
            ubahPaketPengantin.Show();
        }
    }
}
