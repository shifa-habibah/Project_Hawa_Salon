using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;
using System.Security.Principal;
using System.Threading;
using System.Data.SqlClient;


namespace PROJECT_SALON_HAWA_KEL11
{
    public partial class MAINPROJEK : Form
    {
        public MAINPROJEK()
        {
            InitializeComponent();
        }

        private bool IsAuthentic(string nama_akun, string kata_sandi)
        {
            bool autentik = false;

            try
            {
                string connectionString = "integrated security = true; data source =.; initial catalog = db_HawaSalon";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                SqlCommand command = new SqlCommand
                    ("SELECT kata_sandi FROM Pegawai WHERE nama_akun = '" + nama_akun + "'", connection);

                // eksekuai command
                var obj = command.ExecuteScalar();

                if (kata_sandi == obj.ToString())
                {
                    autentik = true;
                }

                connection.Close();
            }
            catch (Exception xcp)
            {
                MessageBox.Show(xcp.ToString());
            }
            return autentik;
        }

        private DataSet GetRoles(string nama_akun)
        {
            DataSet ds = new DataSet();

            try
            {
                string connectionString = "integrated security = true; data source =.; initial catalog = db_HawaSalon";
                SqlConnection connection = new SqlConnection(connectionString);

                SqlDataAdapter adapter = new SqlDataAdapter
                    ("SELECT id_role FROM truserrole WHERE nama_akun = '" + nama_akun + "'", connection);
                adapter.Fill(ds);
            }
            catch (Exception xcp)
            {
                MessageBox.Show(xcp.ToString());
            }
            return ds;
        }
        private void btnMasuk_Click(object sender, EventArgs e)
        {
            if (IsAuthentic(txtNamaAkun.Text, txtKataSandi.Text))
            {
                // membuat GenericIdentity
                GenericIdentity myIdentity = new GenericIdentity(txtNamaAkun.Text);

                // ambil role dan simpan dalam array string
                DataSet dsRole = new DataSet();
                dsRole = GetRoles(txtNamaAkun.Text);
                string[] myRole = new string[dsRole.Tables[0].Rows.Count];

                for (int i = 0; i < dsRole.Tables[0].Rows.Count; i++)
                {
                    myRole[i] = dsRole.Tables[0].Rows[i][0].ToString();
                }

                // membuat Generic Principa
                GenericPrincipal myPrincipal = new GenericPrincipal(myIdentity, myRole);

                // simpan dalam thread principal
                Thread.CurrentPrincipal = myPrincipal;

                // mengeluarkan form Login
                //this.Close();

                // membuka form utama
                MENU menu = new MENU();
                menu.Show();
                

            }
            else
            {
                MessageBox.Show("Username atau Password Salah!");
            }
            
        }
    }
}
