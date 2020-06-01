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

namespace PROJECT_SALON_HAWA_KEL11
{
    public partial class TambahPaketLengkap : Form
    {
        public TambahPaketLengkap()
        {
            InitializeComponent();
            string query = "select top 1 Id_pkt_lengkap from Paket_Lengkap order by Id_pkt_lengkap desc";
            txtID.Text = autogenerateID("PL", query);
        }
        SqlCommand sqlCmd;
        SqlConnection sqlCon;
        static string connectionString = "integrated security = true; data source =.; initial catalog = db_HawaSalon";

        public string autogenerateID(string firstText, string query)
        {
            string result = "";
            int num = 0;
            try
            {
                sqlCon = new SqlConnection(connectionString);
                sqlCon.Open();
                sqlCmd = new SqlCommand(query, sqlCon);
                SqlDataReader reader = sqlCmd.ExecuteReader();
                if (reader.Read())
                {
                    string last = reader[0].ToString();
                    num = Convert.ToInt32(last.Remove(0, firstText.Length)) + 1;
                }
                else
                {
                    num = 1;
                }
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            result = firstText + num.ToString().PadLeft(2, '0');
            return result;
        }

        private void clear()
        {
            txtNama.Clear();
            txtHarga.Clear();
            cmbRambut.Text = "";
            cmbWajah.Text = "";
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void TambahPaketJasaLengkap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetHawaSalon.Perawatan_Wajah' table. You can move, or remove it, as needed.
            this.perawatan_WajahTableAdapter.Fill(this.dataSetHawaSalon.Perawatan_Wajah);
            // TODO: This line of code loads data into the 'dataSetHawaSalon.Perawatan_Rambut' table. You can move, or remove it, as needed.
            this.perawatan_RambutTableAdapter.Fill(this.dataSetHawaSalon.Perawatan_Rambut);

        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i != -1; i = Application.OpenForms.Count - 1)
            {
                Application.OpenForms[i].Close();
            }
        }

        private void txtNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSimpan_Click_1(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtNama.Text == "" || txtHarga.Text == "" || cmbRambut.Text == "" || cmbWajah.Text == "")
            {
                MessageBox.Show("Isi seluruh data terlebih dahulu!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                string connectionstring = "integrated security = true; data source =.; initial catalog = db_HawaSalon";
                SqlConnection connection = new SqlConnection(connectionstring);

                SqlCommand insert = new SqlCommand("sp_InsertPktLengkap", connection);
                insert.CommandType = CommandType.StoredProcedure;

                insert.Parameters.AddWithValue("Id_pkt_lengkap", txtID.Text);
                insert.Parameters.AddWithValue("Id_prwt_rambut", cmbRambut.Text);
                insert.Parameters.AddWithValue("Id_prwt_wajah", cmbWajah.Text);
                insert.Parameters.AddWithValue("nama_paket", txtNama.Text);
                insert.Parameters.AddWithValue("harga", txtHarga.Text);

                try
                {
                    connection.Open();
                    insert.ExecuteNonQuery();
                    MessageBox.Show("Data saved succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to saved: " + ex.Message);
                }
            }
        }

        private void btnBatal_Click_1(object sender, EventArgs e)
        {
            clear();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNama_Leave(object sender, EventArgs e)
        {
            if (txtNama.Text == "")
            {
                epCorrect.SetError(txtNama, "");
                epError.SetError(txtNama, "Kolom harus diisi!");
            }
            else
            {
                epCorrect.SetError(txtNama, "Benar");
                epError.SetError(txtNama, "");
            }
        }

        private void cmbRambut_Leave(object sender, EventArgs e)
        {
            if (cmbRambut.Text == "")
            {
                epCorrect.SetError(cmbRambut, "");
                epError.SetError(cmbRambut, "Kolom harus diisi!");
            }
            else
            {
                epCorrect.SetError(cmbRambut, "Benar");
                epError.SetError(cmbRambut, "");
            }
        }

        private void cmbWajah_Leave(object sender, EventArgs e)
        {
            if (cmbWajah.Text == "")
            {
                epCorrect.SetError(cmbWajah, "");
                epError.SetError(cmbWajah, "Kolom harus diisi!");
            }
            else
            {
                epCorrect.SetError(cmbWajah, "Benar");
                epError.SetError(cmbWajah, "");
            }
        }

        private void txtHarga_Leave(object sender, EventArgs e)
        {
            if (txtHarga.Text == "")
            {
                epCorrect.SetError(txtHarga, "");
                epError.SetError(txtHarga, "Kolom harus diisi!");
            }
            else
            {
                epCorrect.SetError(txtHarga, "Benar");
                epError.SetError(txtHarga, "");
            }
        }
    }
}
