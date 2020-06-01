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
    public partial class UbahPerawatanWajah : Form
    {
        public UbahPerawatanWajah()
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
                        using (SqlCommand sqlCmd = new SqlCommand("sp_CariPrWajah", sqlConn))
                        {
                            sqlConn.Open();
                            sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                            sqlCmd.Parameters.AddWithValue("Id_prwt_wajah", txtID.Text.Trim());

                            SqlDataReader reader = sqlCmd.ExecuteReader();
                            if (reader.HasRows)
                            {
                                reader.Read();
                                txtJenis.SelectedText = Convert.ToString(reader["jns_perawatan"]);
                                txtDeskripsi.SelectedText = Convert.ToString(reader["deskripsi"]);
                                txtHarga.SelectedText = Convert.ToString(reader["harga"]);

                                txtID.Enabled = false;
                                txtJenis.Enabled = true;
                                txtHarga.Enabled = true;
                                txtDeskripsi.Enabled = true;

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
            if (txtID.Text == "" || txtJenis.Text == "" || txtHarga.Text == "" || txtDeskripsi.Text == "")
            {
                MessageBox.Show("Isi seluruh data terlebih dahulu!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                string connectionstring = "integrated security = true; data source =.; initial catalog = db_HawaSalon";
                SqlConnection connection = new SqlConnection(connectionstring);

                SqlCommand update = new SqlCommand("sp_UpdatePrwtRambut", connection);
                update.CommandType = CommandType.StoredProcedure;

                update.Parameters.AddWithValue("Id_prwt_rambut", txtID.Text);
                update.Parameters.AddWithValue("jns_perawatan", txtJenis.Text);
                update.Parameters.AddWithValue("harga", txtHarga.Text);
                update.Parameters.AddWithValue("deskripsi", txtDeskripsi.Text);


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
            txtJenis.Clear();
            txtHarga.Clear();
            txtDeskripsi.Clear();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();
            txtID.Enabled = true;
            txtJenis.Enabled = false;
            txtHarga.Enabled = false;
            txtDeskripsi.Enabled = false;

            btnUbah.Enabled = false;
            btnBatal.Enabled = false;
        }

        private void txtJenis_Leave(object sender, EventArgs e)
        {
            if (txtJenis.Text == "")
            {
                epCorrect.SetError(txtJenis, "");
                epError.SetError(txtJenis, "Kolom harus diisi!");
            }
            else
            {
                epCorrect.SetError(txtJenis, "Benar");
                epError.SetError(txtJenis, "");
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
