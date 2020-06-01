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
    public partial class MENU : Form
    {
        public MENU()
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

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            MENUADMIN admin = new MENUADMIN();
            admin.Show();
        }

        private void btnKasir_Click(object sender, EventArgs e)
        {
            MENUKASIR kasir = new MENUKASIR();
            kasir.Show();
        }

        private void btnManajer_Click(object sender, EventArgs e)
        {
            MENUMANAJER manajer = new MENUMANAJER();
            manajer.Show();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
