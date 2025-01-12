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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        int sonuc = 0; // Oyuncu hamle sayacı
        string x = "X";
        string o = "O";
        string yazi;
        Form1 anamenu = new Form1(); // Ana menüye dönüş için yeni form tanımlaması

        private void button4_Click(object sender, EventArgs e) => Application.Exit();

        private void button48_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
            KontrolEt();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();    // Mevcut formu kapat
            anamenu.Show();  // Ana menüyü göster
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent(); // Oyunu sıfırla
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
            if (button.Text == "") // Eğer buton işaretlenmemişse
            {
                yazi = (sonuc % 2 == 0) ? x : o;
                button.BackColor = (sonuc % 2 == 0) ? Color.DimGray : Color.Silver;
                button.ForeColor = Color.Black;
                button.Text = yazi;
                sonuc++;
            }
        }

        public void KontrolEt()
        {
            // 7x7'lik bir tahta dizisi (49 buton)
            Button[,] board = new Button[7, 7]
            {
        { b1, b2, b3, b4, b5, b6, b7 },
        { b8, b9, b10, b11, b12, b13, b14 },
        { b15, b16, b17, b18, b19, b20, b21 },
        { b22, b23, b24, b25, b26, b27, b28 },
        { b29, b30, b31, b32, b33, b34, b35 },
        { b36, b37, b38, b39, b40, b41, b42 },
        { b43, b44, b45, b46, b47, b48, b49 }
            };

            bool kazanmaDurumu = false;

            // Yatay ve dikey kontrol
            for (int i = 0; i < 7; i++)
            {
                if (board[i, 0].Text == board[i, 1].Text && board[i, 1].Text == board[i, 2].Text &&
                    board[i, 2].Text == board[i, 3].Text && board[i, 3].Text == board[i, 4].Text &&
                    board[i, 4].Text == board[i, 5].Text && board[i, 5].Text == board[i, 6].Text &&
                    board[i, 0].Text != "") kazanmaDurumu = true;

                if (board[0, i].Text == board[1, i].Text && board[1, i].Text == board[2, i].Text &&
                    board[2, i].Text == board[3, i].Text && board[3, i].Text == board[4, i].Text &&
                    board[4, i].Text == board[5, i].Text && board[5, i].Text == board[6, i].Text &&
                    board[0, i].Text != "") kazanmaDurumu = true;
            }

            // Çapraz kontroller
            if (board[0, 0].Text == board[1, 1].Text && board[1, 1].Text == board[2, 2].Text &&
                board[2, 2].Text == board[3, 3].Text && board[3, 3].Text == board[4, 4].Text &&
                board[4, 4].Text == board[5, 5].Text && board[5, 5].Text == board[6, 6].Text &&
                board[0, 0].Text != "") kazanmaDurumu = true;

            if (board[0, 6].Text == board[1, 5].Text && board[1, 5].Text == board[2, 4].Text &&
                board[2, 4].Text == board[3, 3].Text && board[3, 3].Text == board[4, 2].Text &&
                board[4, 2].Text == board[5, 1].Text && board[5, 1].Text == board[6, 0].Text &&
                board[0, 6].Text != "") kazanmaDurumu = true;

            // Kazanan varsa sonucu göster
            if (kazanmaDurumu)
                label1.Text = sonuc % 2 == 1 ? "1. Oyuncu (X) Kazandı" : "2. Oyuncu (O) Kazandı";
        }

        // Tüm butonlar için ortak Click olay metodu
        private void ButtonClick(object sender, EventArgs e)
        {
            button_Click(sender, e);
            KontrolEt();

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

        private void b26_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
            KontrolEt();
        }

        private void b27_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
            KontrolEt();
        }

        private void b28_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
            KontrolEt();
        }

        private void b29_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
            KontrolEt();
        }

        private void b30_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
            KontrolEt();
        }

        private void b31_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
            KontrolEt();
        }

        private void b32_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
            KontrolEt();
        }

        private void b33_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
            KontrolEt();
        }

        private void b34_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
            KontrolEt();
        }

        private void b35_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
            KontrolEt();
        }

        private void b36_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
            KontrolEt();
        }

        private void b37_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
            KontrolEt();
        }

        private void b38_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
            KontrolEt();
        }

        private void b39_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
            KontrolEt();
        }

        private void b40_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
            KontrolEt();
        }

        private void b41_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
            KontrolEt();
        }

        private void b42_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
            KontrolEt();
        }

        private void b43_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
            KontrolEt();
        }

        private void b45_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
            KontrolEt();
        }

        private void b46_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
            KontrolEt();
        }

        private void b47_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
            KontrolEt();
        }

        private void b48_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
            KontrolEt();
        }

        private void b49_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
            KontrolEt();
        }
    }
}

