using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckersGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int n,sayac = 0;
        int Kordinat_x, Kordinat_y;
        int geciciKirmizi_x, geciciKirmizi_y, geciciYesil_x, geciciYesil_y;
        PictureBox[,] P;
        Random rnd = new Random();
        string color = "g", k = " ", B1 = " ", B2 = " ", B3 = " ", B4 = " ";
        int level = 1;
        int anaTas = 0, yesilTas = 0, duvar = 0;

        private void btnAnaTas_Click(object sender, EventArgs e)
        {
            Kordinat_x = rnd.Next(2, 7);
            Kordinat_y = rnd.Next(2, 7);

            if ((P[Kordinat_x, Kordinat_y].Image == null) && (anaTas > 0))
            {
                P[Kordinat_x, Kordinat_y].Image = Properties.Resources.r;
                P[Kordinat_x, Kordinat_y].Name += " r";
                geciciKirmizi_x = Kordinat_x;
                geciciKirmizi_y = Kordinat_y;
                anaTas -= 1;

                if (anaTas == 0) { btnAnaTas.Enabled = false; }
            }

            lblAnaTasSayisi.Text = anaTas.ToString();
        }

        private void btnYesilTas_Click(object sender, EventArgs e)
        {
            Kordinat_x = rnd.Next(1, 8);
            Kordinat_y = rnd.Next(1, 8);

            if ((P[Kordinat_x, Kordinat_y].Image == null) && (yesilTas > 0))
            {
                P[Kordinat_x, Kordinat_y].Image = Properties.Resources.g;
                P[Kordinat_x, Kordinat_y].Name += " g";
                yesilTas -= 1;

                if (yesilTas == 0) { btnYesilTas.Enabled = false; }
            }

            lblYesilTasSayisi.Text = yesilTas.ToString();
        }

        private void btnDuvarEkle_Click(object sender, EventArgs e)
        {
            Kordinat_x = rnd.Next(1, 8);
            Kordinat_y = rnd.Next(1, 8);

            if ((P[Kordinat_x, Kordinat_y].Image == null) && (duvar > 0))
            {
                P[Kordinat_x, Kordinat_y].Image = Properties.Resources.d;
                P[Kordinat_x, Kordinat_y].Name += " d";
                duvar -= 1;

                if (duvar == 0) { btnDuvarEkle.Enabled = false; }
            }
            lblDuvarSayisi.Text = duvar.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Oyun();
        }
        private void Oyun()
        {
            switch (level)
            {
                case 1:
                    lblLevel.Text = "Level 1";
                    anaTas = 1; yesilTas = 7; duvar = 5;
                    break;

                case 2:
                    lblLevel.Text = "Level 2";
                    anaTas = 1; yesilTas = 8; duvar = 5;
                    break;

                default:
                    break;
            }

            lblAnaTasSayisi.Text = anaTas.ToString();
            lblYesilTasSayisi.Text = yesilTas.ToString();
            lblDuvarSayisi.Text = duvar.ToString();

            // Tahtayı oluşturduğumuz alan.

            n = 8;
            P = new PictureBox[n, n];
            int left = 2, top = 2;
            Color[] colors = new Color[] { Color.White, Color.Black };
            for (int i = 0; i < n; i++)
            {
                left = 2;
                if (i % 2 == 0) { colors[0] = Color.White; colors[1] = Color.Black; }
                else { colors[0] = Color.Black; colors[1] = Color.White; }

                for (int j = 0; j < n; j++)
                {
                    P[i, j] = new PictureBox();
                    P[i, j].BackColor = colors[(j % 2 == 0) ? 1 : 0];
                    P[i, j].Location = new Point(left, top);
                    P[i, j].Size = new Size(60, 60);
                    left += 60;

                    // Her bir Kare'ye konumlandırmak için adlarını i + j olarak verdik.

                    P[i, j].Name = i + " " + j;

                    P[i, j].SizeMode = PictureBoxSizeMode.CenterImage;

                    P[i, j].Click += (sender3, e3) =>
                    {

                        PictureBox p = sender3 as PictureBox;
                        if (p.Image != null)
                        {
                            int c = 0, x, y;

                            #region Taşları sürüklemek için burayı kullandık.
                            F();

                            // Mavi taşa tıklanırsa olucaklar (Yeşil taşları sürükleme olayı) : 
                            if (p.Name.Split(' ')[2] == "b")
                            {
                                if (color == "r") color = "g";
                                else color = "g";
                                x = Convert.ToInt32(k.Split(' ')[0]);
                                y = Convert.ToInt32(k.Split(' ')[1]);
                                B1 = " ";
                                B2 = " ";
                                B3 = " ";
                                B4 = " ";
                                if (k.Split(' ')[2] == "r")
                                {
                                    p.Image = Properties.Resources.r;
                                    p.Name = p.Name.Replace("b", "r");
                                }
                                if (k.Split(' ')[2] == "g")
                                {
                                    p.Image = Properties.Resources.g;
                                    p.Name = p.Name.Replace("b", "g");
                                }
                                P[x, y].Image = null;
                            }
                            // Kırmızı taşa tıklanırsa olucaklar :
                            if (p.Name.Split(' ')[2] == "r")
                            {
                                x = Convert.ToInt32(k.Split(' ')[0]);
                                y = Convert.ToInt32(k.Split(' ')[1]);

                                if ((P[x + c, y + 1].Name.Split(' ')[2] == "r") || (P[x, y - 1].Name.Split(' ')[2] == "r") || (P[x + 1, y].Name.Split(' ')[2] == "r") || (P[x - 1, y].Name.Split(' ')[2] == "r"))
                                {
                                    P[x, y].Image = null;
                                    sayac += 1;

                                    // Level'lere göre olucak işlemler.
                                    if (sayac == 8)
                                    {
                                        MessageBox.Show("Tebrikler oyunu bitirdiniz.");
                                        this.Close();
                                    }
                                    else if ((sayac == 7) && (level == 1))
                                    {
                                        level += 1;
                                        MessageBox.Show("Tebrikler kazandınız. Şimdi Level 2'den devam edin..");
                                        btnAnaTas.Enabled = true;
                                        btnYesilTas.Enabled = true;
                                        btnDuvarEkle.Enabled = true;

                                        for (int k = 0; k < 8; k++)
                                        {
                                            for (int l = 0; l < 8; l++)
                                            {
                                                P[k, l].Image = null;
                                            }
                                        }
                                        G.Controls.Clear();
                                        sayac = 0;
                                        Oyun();
                                    }
                                }
                            }

                            #endregion

                            #region Tıklanılan taşın 4 tarafında mavi alan çıkarttık.
                            if (p.Name.Split(' ')[2] == color)
                            {
                                
                                x = Convert.ToInt32(p.Name.Split(' ')[0]);
                                y = Convert.ToInt32(p.Name.Split(' ')[1]);
                                k = p.Name;

                                geciciYesil_x = x;
                                geciciYesil_y = y;

                                int tasUstundekiSayi = (Math.Abs(geciciYesil_x - geciciKirmizi_x) + Math.Abs(geciciYesil_y - geciciKirmizi_y)) - 1;
                                label1.Text = Math.Abs(tasUstundekiSayi).ToString();

                                if (p.Name.Split(' ')[2] == "r") c = 0;

                                try
                                {
                                    if (P[x + c, y + 1].Image == null)
                                    {
                                        P[x + c, y + 1].Image = Properties.Resources.b;
                                        P[x + c, y + 1].Name = (x + c) + " " + (y + 1) + " b";
                                        B1 = (x + c) + " " + (y + 1);
                                    }
                                }
                                catch { }

                                try
                                {
                                    if (P[x + c, y - 1].Image == null)
                                    {
                                        P[x + c, y - 1].Image = Properties.Resources.b;
                                        P[x + c, y - 1].Name = (x + c) + " " + (y - 1) + " b";
                                        B2 = (x + c) + " " + (y - 1);
                                    }
                                }
                                catch { }

                                try
                                {
                                    if (P[x + 1, y].Image == null)
                                    {
                                        P[x + 1, y].Image = Properties.Resources.b;
                                        P[x + 1, y].Name = (x + 1) + " " + (y) + " b";
                                        B3 = (x + 1) + " " + (y);
                                    }
                                }
                                catch { }

                                try
                                {
                                    if (P[x - 1, y].Image == null)
                                    {
                                        P[x - 1, y].Image = Properties.Resources.b;
                                        P[x - 1, y].Name = (x - 1) + " " + (y) + " b";
                                        B4 = (x - 1) + " " + (y);
                                    }
                                }
                                catch { }
                            }
                            #endregion
                        }
                    };
                    G.Controls.Add(P[i, j]);
                }
                top += 60;
            }
        }
        public void F()
        {
            // B1, B2, B3 ve B4 olarak adlandırılan taşa tıklandıktan sonra etrafında çıkan gidilebilir alanlar.
            if (B1 != " ")
            {
                int x, y;
                x = Convert.ToInt32(B1.Split(' ')[0]);
                y = Convert.ToInt32(B1.Split(' ')[1]);
                P[x, y].Image = null;
            }

            if (B2 != " ")
            {
                int x, y;
                x = Convert.ToInt32(B2.Split(' ')[0]);
                y = Convert.ToInt32(B2.Split(' ')[1]);
                P[x, y].Image = null;
            }

            if (B3 != " ")
            {
                int x, y;
                x = Convert.ToInt32(B3.Split(' ')[0]);
                y = Convert.ToInt32(B3.Split(' ')[1]);
                P[x, y].Image = null;
            }

            if (B4 != " ")
            {
                int x, y;
                x = Convert.ToInt32(B4.Split(' ')[0]);
                y = Convert.ToInt32(B4.Split(' ')[1]);
                P[x, y].Image = null;
            }
        }
    }
}
