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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int sonuc = 0; // Hamle sırası
        string x = "X";
        string o = "O";
        string yazi;
        Form1 anamenu = new Form1(); // Ana menüye dönüş için form tanımı
        // Çıkış butonuna tıklayınca uygulamayı kapatma
        private void buttonExit_Click(object sender, EventArgs e)
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
            // Tüm butonları bir diziye ekleyelim (5x5 olduğu için 25 adet buton)
            Button[,] board = new Button[5, 5] { { b1, b2, b3, b4, b5 },
                                         { b6, b7, b8, b9, b10 },
                                         { b11, b12, b13, b14, b15 },
                                         { b16, b17, b18, b19, b20 },
                                         { b21, b22, b23, b24, b25 } };
            // 5'li bir sıra tamamlanıp tamamlanmadığını kontrol etmek
            bool kazanmaDurumu = false;
            // Yatay ve dikey kontrol
            for (int i = 0; i < 5; i++)
            {
                // Yatay kontrol
                if (board[i, 0].Text == board[i, 1].Text && board[i, 1].Text == board[i, 2].Text &&
                    board[i, 2].Text == board[i, 3].Text && board[i, 3].Text == board[i, 4].Text &&
                    board[i, 0].Text != "")
                {
                    kazanmaDurumu = true;
                }
                // Dikey kontrol
                if (board[0, i].Text == board[1, i].Text && board[1, i].Text == board[2, i].Text &&
                    board[2, i].Text == board[3, i].Text && board[3, i].Text == board[4, i].Text &&
                    board[0, i].Text != "")
                {
                    kazanmaDurumu = true;
                }
            }
            // Çapraz kontroller (sol üstten sağ alta ve sağ üstten sol alta)
            if (board[0, 0].Text == board[1, 1].Text && board[1, 1].Text == board[2, 2].Text &&
                board[2, 2].Text == board[3, 3].Text && board[3, 3].Text == board[4, 4].Text &&
                board[0, 0].Text != "")
            {
                kazanmaDurumu = true;
            }
            if (board[0, 4].Text == board[1, 3].Text && board[1, 3].Text == board[2, 2].Text &&
                board[2, 2].Text == board[3, 1].Text && board[3, 1].Text == board[4, 0].Text &&
                board[0, 4].Text != "")
            {
                kazanmaDurumu = true;
            }
            // Kazanan varsa sonucu göster
            if (kazanmaDurumu)
            {
                label1.Text = sonuc % 2 == 1 ? "1. Oyuncu (X) Kazandı" : "2. Oyuncu (O) Kazandı";
            }
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void b1_Click_1(object sender, EventArgs e)
        {
            button_Click(sender, e);
            KontrolEt();
        }
        // Oyunu baştan başlatan buton
        private void button27_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent(); // Tüm bileşenleri yeniden yükleyerek oyunu sıfırla
        }
        private void button26_Click(object sender, EventArgs e)
        {
            this.Close();    // Mevcut formu kapat
            anamenu.Show();  // Ana menüyü göster
        }

        private void b1_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
            KontrolEt();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
            KontrolEt();
        }

        private void b3_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
            KontrolEt();
        }

        private void b4_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
            KontrolEt();
        }

        private void b5_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
            KontrolEt();
        }

        private void b6_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
            KontrolEt();
        }

        private void b7_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
            KontrolEt();
        }

        private void b8_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
            KontrolEt();
        }

        private void b9_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
            KontrolEt();
        }

        private void b10_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
            KontrolEt();
        }

        private void b11_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
            KontrolEt();
        }

        private void b12_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
            KontrolEt();
        }

        private void b13_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
            KontrolEt();
        }

        private void b14_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
            KontrolEt();
        }

        private void b15_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
            KontrolEt();
        }

        private void b16_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
            KontrolEt();
        }

        private void b17_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
            KontrolEt();
        }

        private void b18_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
            KontrolEt();
        }

        private void b19_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
            KontrolEt();
        }

        private void b20_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
            KontrolEt();
        }

        private void b21_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
            KontrolEt();
        }

        private void b22_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
            KontrolEt();
        }

        private void b23_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
            KontrolEt();
        }

        private void b24_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
            KontrolEt();
        }

        private void b25_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
            KontrolEt();
        }
    }
}



