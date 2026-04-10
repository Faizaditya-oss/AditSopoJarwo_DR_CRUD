using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CRUDMahasiswaADO
{
    public partial class Form1 : Form
    {
        private readonly SqlConnection conn;
        private readonly connectionString =
             "LAPTOP-4UOCIEQ0\\FAIZADITYA;Initial Catalog=DBAkademikADO;Integrated Security=True";
        public FormMahasiswa()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
        }

        private void ConnectDatabase()
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                MessageBox.Show("Koneksi berhasil!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi gagal: " + ex.Message);
            }
        }


        


        public Form1()
        {

            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void txtNIM_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbJK_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtAlamat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKodeProdi_TextChanged(object sender, EventArgs e)
        {

        }







        private void btnInsert_Click_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click_Click(object sender, EventArgs e)
        {

        }
    }
}