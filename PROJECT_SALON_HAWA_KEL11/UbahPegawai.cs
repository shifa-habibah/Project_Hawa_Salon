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
    public partial class UbahPegawai : Form
    {
        public UbahPegawai()
        {
            InitializeComponent();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKeluar_Click_1(object sender, EventArgs e)
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
                        using (SqlCommand sqlCmd = new SqlCommand("sp_CariPegawai", sqlConn))
                        {
                            sqlConn.Open();
                            sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                            sqlCmd.Parameters.AddWithValue("Id_Pegawai", txtID.Text.Trim());

                            SqlDataReader reader = sqlCmd.ExecuteReader();
                            if (reader.HasRows)
                            {
                                reader.Read();
                                txtNama.SelectedText = Convert.ToString(reader["Nama"]);
                                txtAlamat.SelectedText = Convert.ToString(reader["alamat"]);
                                txtTelepon.SelectedText = Convert.ToString(reader["no_hp"]);
                                txtNamaAkun.SelectedText = Convert.ToString(reader["nama_akun"]);
                                txtKataSandi.SelectedText = Convert.ToString(reader["kata_sandi"]);
                                dtTglLahir.Text = Convert.ToString(reader["tgl_lahir"]);
                                string jenis = Convert.ToString(reader["jns_kelamin"]);
                                if (jenis == "Perempuan")
                                {
                                    rbPerempuan.Checked = true;
                                }
                                else
                                {
                                    rbLaki.Checked = true;
                                }

                                txtID.Enabled = false;
                                txtNama.Enabled = true;
                                txtAlamat.Enabled = true;
                                txtTelepon.Enabled = true;
                                txtNamaAkun.Enabled = true;
                                txtKataSandi.Enabled = true;
                                dtTglLahir.Enabled = true;
                                rbLaki.Enabled = true;
                                rbPerempuan.Enabled = true;

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
            string jenis = "";

            if (txtID.Text == "" || txtNama.Text == "" || dtTglLahir.Text == "" || txtTelepon.Text == "" || txtAlamat.Text == "" || txtNamaAkun.Text == "" || txtKataSandi.Text == "")
            {
                MessageBox.Show("Isi seluruh data terlebih dahulu!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                if (rbLaki.Checked == true)
                {
                    jenis = "Laki-Laki";
                }
                else if (rbPerempuan.Checked == true)
                {
                    jenis = "Perempuan";
                }

                string connectionstring = "integrated security = true; data source =.; initial catalog = db_HawaSalon";
                SqlConnection connection = new SqlConnection(connectionstring);

                SqlCommand update = new SqlCommand("sp_UpdatePegawai", connection);
                update.CommandType = CommandType.StoredProcedure;

                update.Parameters.AddWithValue("Id_Pegawai", txtID.Text);
                update.Parameters.AddWithValue("Nama", txtNama.Text);
                update.Parameters.AddWithValue("jns_kelamin", jenis);
                update.Parameters.AddWithValue("tgl_lahir", dtTglLahir.Value.ToString("yyyy-MM-dd"));
                update.Parameters.AddWithValue("alamat", txtAlamat.Text);
                update.Parameters.AddWithValue("no_hp", txtTelepon.Text);
                update.Parameters.AddWithValue("nama_akun", txtNamaAkun.Text);
                update.Parameters.AddWithValue("kata_sandi", txtKataSandi.Text);

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
            txtAlamat.Clear();
            txtNamaAkun.Clear();
            txtKataSandi.Clear();
            txtTelepon.Clear();
            rbLaki.Checked = false;
            rbPerempuan.Checked = false;

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            string connectionstring = "integrated security = true; data source =.; initial catalog = db_HawaSalon";
            SqlConnection connection = new SqlConnection(connectionstring);

            SqlCommand delete = new SqlCommand("sp_DeletePegawai", connection);
            delete.CommandType = CommandType.StoredProcedure;

            delete.Parameters.AddWithValue("Id_Pegawai", txtID.Text);

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
            txtAlamat.Enabled = false;
            txtTelepon.Enabled = false;
            txtNamaAkun.Enabled = false;
            txtKataSandi.Enabled = false;
            dtTglLahir.Enabled = false;
            rbLaki.Enabled = false;
            rbPerempuan.Enabled = false;

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

        private void dtTglLahir_Leave(object sender, EventArgs e)
        {
            if (dtTglLahir.Text == "")
            {
                epCorrect.SetError(dtTglLahir, "");
                epError.SetError(dtTglLahir, "Kolom harus diisi!");
            }
            else
            {
                epCorrect.SetError(dtTglLahir, "Benar");
                epError.SetError(dtTglLahir, "");
            }
        }

        private void txtTelepon_Leave(object sender, EventArgs e)
        {
            if (txtTelepon.Text == "")
            {
                epCorrect.SetError(txtTelepon, "");
                epError.SetError(txtTelepon, "Kolom harus diisi!");
            }
            else
            {
                epCorrect.SetError(txtTelepon, "Benar");
                epError.SetError(txtTelepon, "");
            }
        }

        private void txtAlamat_Leave(object sender, EventArgs e)
        {
            if (txtAlamat.Text == "")
            {
                epCorrect.SetError(txtAlamat, "");
                epError.SetError(txtAlamat, "Kolom harus diisi!");
            }
            else
            {
                epCorrect.SetError(txtAlamat, "Benar");
                epError.SetError(txtAlamat, "");
            }
        }

        private void txtNamaAkun_Leave(object sender, EventArgs e)
        {
            if (txtNamaAkun.Text == "")
            {
                epCorrect.SetError(txtNamaAkun, "");
                epError.SetError(txtNamaAkun, "Kolom harus diisi!");
            }
            else
            {
                epCorrect.SetError(txtNamaAkun, "Benar");
                epError.SetError(txtNamaAkun, "");
            }
        }

        private void txtKataSandi_Leave(object sender, EventArgs e)
        {
            if (txtKataSandi.Text == "")
            {
                epCorrect.SetError(txtKataSandi, "");
                epError.SetError(txtKataSandi, "Kolom harus diisi!");
            }
            else
            {
                epCorrect.SetError(txtKataSandi, "Benar");
                epError.SetError(txtKataSandi, "");
            }
        }
    }
}
