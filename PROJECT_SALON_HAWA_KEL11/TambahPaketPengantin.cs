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
    public partial class TambahPaketPengantin : Form
    {
        public TambahPaketPengantin()
        {
            InitializeComponent();
            string query = "select top 1 Id_pkt_pengantin from Paket_Pengantin order by Id_pkt_pengantin desc";
            txtID.Text = autogenerateID("PP", query);
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

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i != -1; i = Application.OpenForms.Count - 1)
            {
                Application.OpenForms[i].Close();
            }
        }

        private void clear()
        {
            txtNama.Clear();
            txtHarga.Clear();
            txtDeskripsi.Clear();
            JmlBaju.Text = "";
        }
        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtNama.Text == "" || txtHarga.Text == "" || txtDeskripsi.Text == "" || JmlBaju.Text == "")
            {
                MessageBox.Show("Isi seluruh data terlebih dahulu!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                string connectionstring = "integrated security = true; data source =.; initial catalog = db_HawaSalon";
                SqlConnection connection = new SqlConnection(connectionstring);

                SqlCommand insert = new SqlCommand("sp_InsertPktPengantin", connection);
                insert.CommandType = CommandType.StoredProcedure;

                insert.Parameters.AddWithValue("Id_pkt_pengantin", txtID.Text);
                insert.Parameters.AddWithValue("nama_paket", txtNama.Text);
                insert.Parameters.AddWithValue("deskripsi", txtDeskripsi.Text);
                insert.Parameters.AddWithValue("harga", txtHarga.Text);
                insert.Parameters.AddWithValue("jml_baju", JmlBaju.Text);

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

        private void txtHarga_KeyPress(object sender, KeyPressEventArgs e)
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
