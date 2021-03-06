﻿using System;
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
    public partial class TambahPegawai : Form
    {
        public TambahPegawai()
        {
            InitializeComponent();
            string query = "select top 1 Id_Pegawai from Pegawai order by Id_Pegawai desc";
            txtID.Text = autogenerateID("PGW", query);
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
            txtAlamat.Clear();
            txtNamaAkun.Clear();
            txtKataSandi.Clear();
            txtTelepon.Clear();
            rbLaki.Checked = false;
            rbPerempuan.Checked = false;

        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i != -1; i = Application.OpenForms.Count - 1)
            {
                Application.OpenForms[i].Close();
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string jenis = "";

            if (txtID.Text == "" || txtNama.Text == "" || dtTglLahir.Text == "" || txtTelepon.Text == "" || txtAlamat.Text == "" || txtNamaAkun.Text == "" || txtKataSandi.Text == "" || (rbLaki.Checked == false && rbPerempuan.Checked == false))
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

                SqlCommand insert = new SqlCommand("sp_InsertPegawai", connection);
                insert.CommandType = CommandType.StoredProcedure;

                insert.Parameters.AddWithValue("Id_Pegawai", txtID.Text);
                insert.Parameters.AddWithValue("Nama", txtNama.Text);
                insert.Parameters.AddWithValue("jns_kelamin", jenis);
                insert.Parameters.AddWithValue("tgl_lahir", dtTglLahir.Value);
                insert.Parameters.AddWithValue("alamat", txtAlamat.Text);
                insert.Parameters.AddWithValue("no_hp", txtTelepon.Text);
                insert.Parameters.AddWithValue("nama_akun", txtNamaAkun.Text);
                insert.Parameters.AddWithValue("kata_sandi", txtKataSandi.Text);

                try
                {
                    connection.Open();
                    insert.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil disimpan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Data gagal disimpan : " + ex.Message);
                }
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelepon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
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
