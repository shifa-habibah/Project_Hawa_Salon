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
    public partial class UbahPaketLengkap : Form
    {
        public UbahPaketLengkap()
        {
            InitializeComponent();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i != -1; i = Application.OpenForms.Count - 1)
            {
                Application.OpenForms[i].Close();
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtID.Text.Trim()))
                {
                    using (SqlConnection sqlConn = new SqlConnection("integrated security = true; data source =.; initial catalog = db_HawaSalon"))
                    {
                        using (SqlCommand sqlCmd = new SqlCommand("sp_CariPktLengkap", sqlConn))
                        {
                            sqlConn.Open();
                            sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                            sqlCmd.Parameters.AddWithValue("Id_pkt_lengkap", txtID.Text.Trim());

                            SqlDataReader reader = sqlCmd.ExecuteReader();
                            if (reader.HasRows)
                            {
                                cmbRambut.Text = "";
                                cmbWajah.Text = "";

                                reader.Read();
                                txtNama.SelectedText = Convert.ToString(reader["nama_paket"]);
                                cmbRambut.SelectedText = Convert.ToString(reader["Id_prwt_rambut"]);
                                cmbWajah.SelectedText = Convert.ToString(reader["Id_prwt_wajah"]);
                                txtHarga.SelectedText = Convert.ToString(reader["harga"]);

                                txtID.Enabled = false;
                                txtNama.Enabled = true;
                                cmbRambut.Enabled = true;
                                cmbWajah.Enabled = true;
                                txtHarga.Enabled = true;

                                btnUbah.Enabled = true;
                                btnHapus.Enabled = true;
                                btnBatal.Enabled = true;

                            }
                            else
                            {
                                MessageBox.Show("Data dengan ID tersebut tidak ditemukan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            sqlConn.Close();
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();
            txtID.Enabled = true;
            txtNama.Enabled = false;
            cmbRambut.Enabled = false;
            cmbWajah.Enabled = false;
            txtHarga.Enabled = false;

            btnUbah.Enabled = false;
            btnHapus.Enabled = false;
            btnBatal.Enabled = false;
        }

        private void clear()
        {
            txtID.Clear();
            txtNama.Clear();
            txtHarga.Clear();
            cmbRambut.Text = "";
            cmbWajah.Text = "";
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            string connectionstring = "integrated security = true; data source =.; initial catalog = db_HawaSalon";
            SqlConnection connection = new SqlConnection(connectionstring);

            SqlCommand delete = new SqlCommand("sp_DeletePktLengkap", connection);
            delete.CommandType = CommandType.StoredProcedure;

            delete.Parameters.AddWithValue("Id_pkt_lengkap", txtID.Text);

            try
            {
                connection.Open();
                delete.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Dihapus", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data tidak dapat dihapus: " + ex.Message);
            }
        }

        private void UbahPaketLengkap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetHawaSalon.Perawatan_Wajah' table. You can move, or remove it, as needed.
            this.perawatan_WajahTableAdapter.Fill(this.dataSetHawaSalon.Perawatan_Wajah);
            // TODO: This line of code loads data into the 'dataSetHawaSalon.Perawatan_Rambut' table. You can move, or remove it, as needed.
            this.perawatan_RambutTableAdapter.Fill(this.dataSetHawaSalon.Perawatan_Rambut);

        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtNama.Text == "" || cmbRambut.Text == "" || cmbWajah.Text == "" || txtHarga.Text == "")
            {
                MessageBox.Show("Isi seluruh data terlebih dahulu!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string connectionstring = "integrated security = true; data source =.; initial catalog = db_HawaSalon";
                SqlConnection connection = new SqlConnection(connectionstring);

                SqlCommand update = new SqlCommand("sp_UpdatePktLengkap", connection);
                update.CommandType = CommandType.StoredProcedure;

                update.Parameters.AddWithValue("Id_pkt_lengkap", txtID.Text);
                update.Parameters.AddWithValue("nama_paket", txtNama.Text);
                update.Parameters.AddWithValue("Id_prwt_rambut", cmbRambut.Text);
                update.Parameters.AddWithValue("Id_prwt_wajah", cmbWajah.Text);
                update.Parameters.AddWithValue("harga", txtHarga.Text);

                try
                {
                    connection.Open();
                    update.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil disimpan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Data tidak dapat disimpan: " + ex.Message);
                }
            }
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
