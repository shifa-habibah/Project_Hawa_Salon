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
    public partial class UbahPaketPengantin : Form
    {
        public UbahPaketPengantin()
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
                        using (SqlCommand sqlCmd = new SqlCommand("sp_CariPktPengantin", sqlConn))
                        {
                            sqlConn.Open();
                            sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                            sqlCmd.Parameters.AddWithValue("Id_pkt_pengantin", txtID.Text.Trim());

                            SqlDataReader reader = sqlCmd.ExecuteReader();
                            if (reader.HasRows)
                            {
                                reader.Read();
                                txtNama.SelectedText = Convert.ToString(reader["nama_paket"]);
                                txtDeskripsi.SelectedText = Convert.ToString(reader["deskripsi"]);
                                JmlBaju.SelectedIndex = Convert.ToInt32(reader["jml_baju"]);
                                txtHarga.SelectedText = Convert.ToString(reader["harga"]);

                                txtID.Enabled = false;
                                txtNama.Enabled = true;
                                txtDeskripsi.Enabled = true;
                                JmlBaju.Enabled = true;
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

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtNama.Text == "" || txtDeskripsi.Text == "" || JmlBaju.Text == "" || txtHarga.Text == "")
            {
                MessageBox.Show("Isi seluruh data terlebih dahulu!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string connectionstring = "integrated security = true; data source =.; initial catalog = db_HawaSalon";
                SqlConnection connection = new SqlConnection(connectionstring);

                SqlCommand update = new SqlCommand("sp_UpdatePktPengantin", connection);
                update.CommandType = CommandType.StoredProcedure;

                update.Parameters.AddWithValue("Id_pkt_pengantin", txtID.Text);
                update.Parameters.AddWithValue("nama_paket", txtNama.Text);
                update.Parameters.AddWithValue("deskripsi", txtDeskripsi.Text);
                update.Parameters.AddWithValue("harga", txtHarga.Text);
                update.Parameters.AddWithValue("jml_baju", JmlBaju.Text);

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

        private void clear()
        {
            txtID.Clear();
            txtNama.Clear();
            txtDeskripsi.Clear();
            txtHarga.Clear();
            JmlBaju.Text = "";

        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();
            txtID.Enabled = true;
            txtNama.Enabled = false;
            txtDeskripsi.Enabled = false;
            JmlBaju.Enabled = false;
            txtHarga.Enabled = false;

            btnUbah.Enabled = false;
            btnHapus.Enabled = false;
            btnBatal.Enabled = false;
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            string connectionstring = "integrated security = true; data source =.; initial catalog = db_HawaSalon";
            SqlConnection connection = new SqlConnection(connectionstring);

            SqlCommand delete = new SqlCommand("sp_DeletePktPengantin", connection);
            delete.CommandType = CommandType.StoredProcedure;

            delete.Parameters.AddWithValue("Id_pkt_pengantin", txtID.Text);

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

        private void txtDeskripsi_Leave(object sender, EventArgs e)
        {
            if (txtDeskripsi.Text == "")
            {
                epCorrect.SetError(txtDeskripsi, "");
                epError.SetError(txtDeskripsi, "Kolom harus diisi!");
            }
            else
            {
                epCorrect.SetError(txtDeskripsi, "Benar");
                epError.SetError(txtDeskripsi, "");
            }
        }

        private void JmlBaju_Leave(object sender, EventArgs e)
        {
            if (JmlBaju.Text == "")
            {
                epCorrect.SetError(JmlBaju, "");
                epError.SetError(JmlBaju, "Kolom harus diisi!");
            }
            else
            {
                epCorrect.SetError(JmlBaju, "Benar");
                epError.SetError(JmlBaju, "");
            }
        }
    }
}
