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
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }
        static string baglanti = "Data Source=DESKTOP-LPT5OLI\\SQLEXPRESS;Initial Catalog = qrkodyoklama; Integrated Security = True";
        SqlConnection connect = new SqlConnection(baglanti);

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void giris_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            kayitogr kayitogr = new kayitogr();
            kayitogr.Show();
            this.Hide();

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                string sql = "Select * from ogrenci where eposta=@eposta AND sifre=@sifre";
                SqlParameter prm1 = new SqlParameter("eposta", Epostaogr.Text);
                SqlParameter prm2 = new SqlParameter("sifre", Sifreogr.Text);
                SqlCommand komut = new SqlCommand(sql, connect);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    ögrenci ögrenci = new ögrenci();
                    ögrenci.Show();
                    this.Hide();
                }


            }
            catch (Exception)
            {


                MessageBox.Show("Hatalı Giriş");

            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            girisegitmen girisegitmen = new girisegitmen();
            girisegitmen.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            giris giris = new giris();
            giris.Show();
            this.Hide();

        }
    }
}
