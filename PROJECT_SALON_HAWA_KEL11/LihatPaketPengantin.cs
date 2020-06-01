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
    public partial class LihatPaketPengantin : Form
    {
        public LihatPaketPengantin()
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

        private void LihatPaketPengantin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetHawaSalon.Paket_Pengantin' table. You can move, or remove it, as needed.
            this.paket_PengantinTableAdapter.Fill(this.dataSetHawaSalon.Paket_Pengantin);

        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
