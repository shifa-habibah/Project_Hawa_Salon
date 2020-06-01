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
    public partial class UbahPakaian : Form
    {
        public UbahPakaian()
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
                        using (SqlCommand sqlCmd = new SqlCommand("sp_CariPakaian", sqlConn))
                        {
                            sqlConn.Open();
                            sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                            sqlCmd.Parameters.AddWithValue("Id_baju", txtID.Text.Trim());

                            SqlDataReader reader = sqlCmd.ExecuteReader();
                            if (reader.HasRows)
                            {
                                reader.Read();
                                txtNama.SelectedText = Convert.ToString(reader["nama"]);
                                txtDeskripsi.SelectedText = Convert.ToString(reader["deskripsi"]);
                                UkuranS.SelectedIndex = Convert.ToInt32(reader["kuantitas_s"]);
                                UkuranM.SelectedIndex = Convert.ToInt32(reader["kuantitas_m"]);
                                UkuranL.SelectedIndex = Convert.ToInt32(reader["kuantitas_l"]);
                                UkuranXL.SelectedIndex = Convert.ToInt32(reader["kuantitas_xl"]);
                                txtHarga.SelectedText = Convert.ToString(reader["harga"]);

                                txtID.Enabled = false;
                                txtNama.Enabled = true;
                                txtDeskripsi.Enabled = true;
                                UkuranS.Enabled = true;
                                UkuranM.Enabled = true;
                                UkuranL.Enabled = true;
                                UkuranXL.Enabled = true;
                                txtHarga.Enabled = true;

                                btnBatal.Enabled = true;
                                btnHapus.Enabled = true;
                                btnUbah.Enabled = true;

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
            if (txtID.Text == "" || txtNama.Text == "" || txtDeskripsi.Text == "" || UkuranS.Text == "" || UkuranL.Text == "" || UkuranM.Text == "" || UkuranXL.Text == "" || txtHarga.Text == "" )
            {
                MessageBox.Show("Isi seluruh data terlebih dahulu!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string connectionstring = "integrated security = true; data source =.; initial catalog = db_HawaSalon";
                SqlConnection connection = new SqlConnection(connectionstring);

                SqlCommand update = new SqlCommand("sp_UpdatePakaian", connection);
                update.CommandType = CommandType.StoredProcedure;

                update.Parameters.AddWithValue("Id_Baju", txtID.Text);
                update.Parameters.AddWithValue("nama", txtNama.Text);
                update.Parameters.AddWithValue("deskripsi", txtDeskripsi.Text);
                update.Parameters.AddWithValue("kuantitas_s", UkuranS.Text);
                update.Parameters.AddWithValue("kuantitas_m", UkuranM.Text);
                update.Parameters.AddWithValue("kuantitas_l", UkuranL.Text);
                update.Parameters.AddWithValue("kuantitas_xl", UkuranXL.Text);
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

        private void clear()
        {
            txtID.Clear();
            txtNama.Clear();
            txtHarga.Clear();
            txtDeskripsi.Clear();
            UkuranS.Text = "";
            UkuranM.Text = "";
            UkuranL.Text = "";
            UkuranXL.Text = "";

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            string connectionstring = "integrated security = true; data source =.; initial catalog = db_HawaSalon";
            SqlConnection connection = new SqlConnection(connectionstring);

            SqlCommand delete = new SqlCommand("sp_DeletePakaian", connection);
            delete.CommandType = CommandType.StoredProcedure;

            delete.Parameters.AddWithValue("Id_baju", txtID.Text);

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

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();
            txtID.Enabled = true;
            txtNama.Enabled = false;
            txtDeskripsi.Enabled = false;
            UkuranS.Enabled = false;
            UkuranM.Enabled = false;
            UkuranL.Enabled = false;
            UkuranXL.Enabled = false;
            txtHarga.Enabled = false;

            btnBatal.Enabled = false;
            btnHapus.Enabled = false;
            btnUbah.Enabled = false;
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
    }
}
