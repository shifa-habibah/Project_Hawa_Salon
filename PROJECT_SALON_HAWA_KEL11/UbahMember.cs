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
    public partial class UbahMember : Form
    {
        public UbahMember()
        {
            InitializeComponent();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtID.Text.Trim()))
                {
                    using (SqlConnection sqlConn = new SqlConnection("integrated security = true; data source =.; initial catalog = db_HawaSalon"))
                    {
                        using (SqlCommand sqlCmd = new SqlCommand("sp_CariMember", sqlConn))
                        {
                            sqlConn.Open();
                            sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                            sqlCmd.Parameters.AddWithValue("Id_Member", txtID.Text.Trim());

                            SqlDataReader reader = sqlCmd.ExecuteReader();
                            if (reader.HasRows)
                            {
                                reader.Read();
                                txtNama.SelectedText = Convert.ToString(reader["Nama"]);
                                txtAlamat.SelectedText = Convert.ToString(reader["alamat"]);
                                txtTelepon.SelectedText = Convert.ToString(reader["no_hp"]);
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
                                rbLaki.Enabled = true;
                                rbPerempuan.Enabled = true;

                                btnUbah.Enabled = true;
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
            string jenis = "";

            if (txtID.Text == "" || txtNama.Text == "" || txtTelepon.Text == "" || txtAlamat.Text == "" || (rbLaki.Checked == false && rbPerempuan.Checked == false))
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

                SqlCommand update = new SqlCommand("sp_UpdateMember", connection);
                update.CommandType = CommandType.StoredProcedure;

                update.Parameters.AddWithValue("Id_Member", txtID.Text);
                update.Parameters.AddWithValue("Nama", txtNama.Text);
                update.Parameters.AddWithValue("jns_kelamin", jenis);
                update.Parameters.AddWithValue("alamat", txtAlamat.Text);
                update.Parameters.AddWithValue("no_hp", txtTelepon.Text);

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

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i != -1; i = Application.OpenForms.Count - 1)
            {
                Application.OpenForms[i].Close();
            }
        }

        private void clear()
        {
            txtID.Clear();
            txtNama.Clear();
            txtAlamat.Clear();
            txtTelepon.Clear();
            rbLaki.Checked = false;
            rbPerempuan.Checked = false;

        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();
            txtID.Enabled = true;
            txtNama.Enabled = false;
            txtAlamat.Enabled = false;
            txtTelepon.Enabled = false;

            btnUbah.Enabled = false;
            btnBatal.Enabled = false;
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
    }
}
