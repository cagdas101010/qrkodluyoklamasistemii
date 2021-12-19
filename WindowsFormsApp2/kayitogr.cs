using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class kayitogr : Form
    {
        public kayitogr()
        {
            InitializeComponent();
        }
        static string constring = "Data Source=DESKTOP-LPT5OLI\\SQLEXPRESS;Initial Catalog = qrkodyoklama; Integrated Security = True";
        SqlConnection connect = new SqlConnection(constring);

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            giris giris = new giris();
            giris.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            kayitegitmen egitmen = new kayitegitmen();
            egitmen.Show();
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();
                string kayitogrenci = "insert into ogrenci(eposta,sifre,ad,soyad,okulnumarasi) values(@eposta,@sifre,@ad,@soyad,@okulnumarasi)";
                
                SqlCommand komut = new SqlCommand(kayitogrenci, connect);
                komut.Parameters.AddWithValue("@eposta", ogreposta.Text);
                komut.Parameters.AddWithValue("@sifre", ogrsifre.Text);
                komut.Parameters.AddWithValue("@ad", ograd.Text);
                komut.Parameters.AddWithValue("@soyad", ogrsoyad.Text);
                komut.Parameters.AddWithValue("@okulnumarasi", ogrno.Text);
                komut.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Kayıt Başarıyla Tamamlandı.");

            }
            catch (Exception hata)
            {
                MessageBox.Show("Kayıt Olurken Hata" + hata.Message);
            }
        }
    }
}
