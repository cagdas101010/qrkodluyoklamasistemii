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
    public partial class girisegitmen : Form
    {
        public girisegitmen()
        {
            InitializeComponent();
        }
        static string baglanti = "Data Source=DESKTOP-LPT5OLI\\SQLEXPRESS;Initial Catalog = qrkodyoklama; Integrated Security = True";
        SqlConnection connect = new SqlConnection(baglanti);

        private void girisegitmen_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            giris giris = new giris();
            giris.Show();
            this.Hide();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            girisegitmen girisegitmen = new girisegitmen();
            girisegitmen.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kayitegitmen kayitegitmen = new kayitegitmen();
            kayitegitmen.Show();
            this.Hide();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            

            try
            {
                connect.Open();
                string sql = "Select * from egitmen1 where eposta=@eposta AND sifre=@sifre";
                SqlParameter prm1 = new SqlParameter("eposta", EpostaEgitmen.Text);
                SqlParameter prm2 = new SqlParameter("sifre", SifreEgitmen.Text);
                SqlCommand komut = new SqlCommand(sql, connect);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    egitmen egitmen = new egitmen();
                    egitmen.Show();
                    this.Hide();
                }


            }
            catch (Exception)
            {

                
                MessageBox.Show("Hatalı Giriş");

            }

        }
    }
}
