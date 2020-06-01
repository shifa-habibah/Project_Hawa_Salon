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
    public partial class LihatPegawai : Form
    {
        public LihatPegawai()
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

        private void LihatPegawai_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetHawaSalon.Pegawai' table. You can move, or remove it, as needed.
            this.pegawaiTableAdapter.Fill(this.dataSetHawaSalon.Pegawai);
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
