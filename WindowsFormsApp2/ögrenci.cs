using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class ögrenci : Form
    {
        public ögrenci()
        {
            InitializeComponent();
        }

        private void qrolustur_Click(object sender, EventArgs e)
        {
            string numara = qrtext.Text;
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(numara, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            pictureBox1.Image = qrCodeImage;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            giris giris = new giris();
            giris.Show();
            this.Hide();
        }

        private void qrtext_TextChanged(object sender, EventArgs e)
        {

        }

        private void ögrenci_Load(object sender, EventArgs e)
        {

        }
    }
}
