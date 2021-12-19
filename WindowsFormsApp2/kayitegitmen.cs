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
    public partial class kayitegitmen : Form
    {
        public kayitegitmen()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kayitogr kayitogr1 = new kayitogr();
            kayitogr1.Show();
            this.Hide();
        }
        static string constring = "Data Source=DESKTOP-LPT5OLI\\SQLEXPRESS;Initial Catalog = qrkodyoklama; Integrated Security = True";
        SqlConnection connect = new SqlConnection(constring);
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();
                string kayitegitmen = "insert into egitmen1(eposta,sifre,ad,soyad) values(@eposta,@sifre,@ad,@soyad)";
                SqlCommand komut = new SqlCommand(kayitegitmen, connect);
                komut.Parameters.AddWithValue("@eposta", egitmeneposta.Text);
                komut.Parameters.AddWithValue("@sifre", egitmensifre.Text);
                komut.Parameters.AddWithValue("@ad", egitmenad.Text);
                komut.Parameters.AddWithValue("@soyad", egitmensoyad.Text);
                komut.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Kayıt Başarıyla Tamamlandı.");

            }
            catch(Exception hata)
            {
                MessageBox.Show("Kayıt Olurken Hata"+hata.Message);
            }
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            girisegitmen girisegitmen = new girisegitmen();
            girisegitmen.Show();
            this.Hide();


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kayitegitmen_Load(object sender, EventArgs e)
        {

        }
    }
}
