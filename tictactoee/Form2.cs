using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoee
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int sonuc = 0; // Oyuncu hamle sayacı
        string x = "X";
        string o = "O";
        string yazi;
        Form1 anamenu = new Form1(); // Ana menüye dönüş için yeni form tanımlaması

        // Çıkış butonuna tıklayınca uygulamayı kapatma
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Hamleyi gerçekleştiren ana metot
        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender; // Tıklanan butonu al
            Hamle(button);                  // Hamleyi uygula
            KontrolEt();                    // Kazanan olup olmadığını kontrol et
        }

        // X ve O hamlelerini butona yazan metot
        public void Hamle(Button button)
        {
            if (button.Text == "") // Eğer buton zaten işaretlenmemişse
            {
                // Sıra hangi oyuncudaysa ilgili işareti atama
                if (sonuc % 2 == 0)
                {
                    yazi = x;
                    button.BackColor = Color.DimGray;
                }
                else
                {
                    yazi = o;
                    button.BackColor = Color.Silver;
                }
                button.ForeColor = Color.Black;
                button.Text = yazi; // Hamleyi butona yaz
                sonuc++;            // Sonraki hamle için sayacı artır
            }
        }

        // Kazanan oyuncuyu kontrol eden metot
        public void KontrolEt()
        {
            if (
                (b1.Text == x && b2.Text == x && b3.Text == x) ||
                (b4.Text == x && b5.Text == x && b6.Text == x) ||
                (b7.Text == x && b8.Text == x && b9.Text == x) ||
                (b1.Text == x && b4.Text == x && b7.Text == x) ||
                (b2.Text == x && b5.Text == x && b8.Text == x) ||
                (b3.Text == x && b6.Text == x && b9.Text == x) ||
                (b1.Text == x && b5.Text == x && b9.Text == x) ||
                (b3.Text == x && b5.Text == x && b7.Text == x))
            {
                label1.Text = "1. Oyuncu (X) Kazandı";
            }
            else if (
                (b1.Text == o && b2.Text == o && b3.Text == o) ||
                (b4.Text == o && b5.Text == o && b6.Text == o) ||
                (b7.Text == o && b8.Text == o && b9.Text == o) ||
                (b1.Text == o && b4.Text == o && b7.Text == o) ||
                (b2.Text == o && b5.Text == o && b8.Text == o) ||
                (b3.Text == o && b6.Text == o && b9.Text == o) ||
                (b1.Text == o && b5.Text == o && b9.Text == o) ||
                (b3.Text == o && b5.Text == o && b7.Text == o))
            {
                label1.Text = "2. Oyuncu (O) Kazandı";
            }
        }

        // Oyunu baştan başlatan buton
        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent(); // Tüm bileşenleri yeniden yükleyerek oyunu sıfırla
        }

        // Tüm butonların Click olayına aynı metodu bağlama
        private void b1_Click(object sender, EventArgs e) => button_Click(sender, e);
        private void b2_Click(object sender, EventArgs e) => button_Click(sender, e);
        private void b3_Click(object sender, EventArgs e) => button_Click(sender, e);
        private void b4_Click(object sender, EventArgs e) => button_Click(sender, e);
        private void b5_Click(object sender, EventArgs e) => button_Click(sender, e);
        private void b6_Click(object sender, EventArgs e) => button_Click(sender, e);
        private void b7_Click(object sender, EventArgs e) => button_Click(sender, e);
        private void b8_Click(object sender, EventArgs e) => button_Click(sender, e);
        private void b9_Click(object sender, EventArgs e) => button_Click(sender, e);

        // Ana menüye dönmek için close işlemi
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();    // Mevcut formu kapat
            anamenu.Show();  // Ana menüyü göster
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
