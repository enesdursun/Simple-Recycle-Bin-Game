
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecycleBin_Game
{
    public partial class Form1 : Form
    {
        string[] resimler = new string[8]
        {
            "domates.jpg","salatalik.jpg","gazete.jpg","dergi.jpg","sise.jpg","bardak.jpg","kola.jpg","salca.jpg"
        };

        public void ResimDegistir()
        {
            Random rast = new Random();
            pictureBox1.ImageLocation = resimler[rast.Next(0, resimler.Length)];
        }

        // Objelerimiz
        OrganikAtikKutusu organikAtikKutusu = new OrganikAtikKutusu(700);
        Organik domat = new Organik(150);
        Organik salata = new Organik(120);

        KagitKutusu kagitKutusu = new KagitKutusu(1200);
        Kagit gazete = new Kagit(250);
        Kagit dergi = new Kagit(200);

        CamKutusu camKutusu = new CamKutusu(2200);
        Cam sise = new Cam(600);
        Cam bardak = new Cam(250);

        MetalKutusu metalKutusu = new MetalKutusu(2300);
        Metal kola = new Metal(350);
        Metal salca = new Metal(550);

        public void ButonlarAcik()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
        }

        public void ButonlarKapali()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
        }

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            ButonlarKapali();
        }

        private void button9_Click(object sender, EventArgs e)    // Yeni Oyun Butonu
        {
            _puan = 0;
            label4.Text = "60";
            label5.Text = "";
            organikAtikKutusu.Temizle();
            kagitKutusu.Temizle();
            camKutusu.Temizle();
            metalKutusu.Temizle();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            progressBar1.Value = organikAtikKutusu.DolulukOrani;
            progressBar2.Value = kagitKutusu.DolulukOrani;
            progressBar3.Value = camKutusu.DolulukOrani;
            progressBar4.Value = metalKutusu.DolulukOrani;
            button9.Enabled = false;
            ButonlarAcik();
            ResimDegistir();
            _timeLeft = 60;
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)  // Organik Atık butonu
        {
            if (pictureBox1.ImageLocation == resimler[0])
            {
                if (organikAtikKutusu.Ekle(domat))
                {
                    organikAtikKutusu.Ekle2(domat);
                    listBox1.Items.Add("Domates (150)");
                    progressBar1.Value = organikAtikKutusu.DolulukOrani;
                    _puan += domat.Hacim;
                    label5.Text = Convert.ToString(_puan);
                    ResimDegistir();
                }
            }

            if (pictureBox1.ImageLocation == resimler[1])
            {
                if (organikAtikKutusu.Ekle(salata))
                {
                    organikAtikKutusu.Ekle2(salata);
                    listBox1.Items.Add("Salatalık (120)");
                    progressBar1.Value = organikAtikKutusu.DolulukOrani;
                    _puan += salata.Hacim;
                    label5.Text = Convert.ToString(_puan);
                    ResimDegistir();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)  // Kağıt butonu
        {
            if (pictureBox1.ImageLocation == resimler[2])
            {
                if (kagitKutusu.Ekle(gazete))
                {
                    kagitKutusu.Ekle2(gazete);
                    listBox2.Items.Add("Gazete (250)");
                    progressBar2.Value = kagitKutusu.DolulukOrani;
                    _puan += gazete.Hacim;
                    label5.Text = Convert.ToString(_puan);
                    ResimDegistir();
                }
            }

            if (pictureBox1.ImageLocation == resimler[3])
            {
                if (kagitKutusu.Ekle(dergi))
                {
                    kagitKutusu.Ekle2(dergi);
                    listBox2.Items.Add("Dergi (200)");
                    progressBar2.Value = kagitKutusu.DolulukOrani;
                    _puan += dergi.Hacim;
                    label5.Text = Convert.ToString(_puan);
                    ResimDegistir();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)  // Cam butonu
        {
            if (pictureBox1.ImageLocation == resimler[4])
            {
                if (camKutusu.Ekle(sise))
                {
                    camKutusu.Ekle2(sise);
                    listBox3.Items.Add("Cam Şişe (600)");
                    progressBar3.Value = camKutusu.DolulukOrani;
                    _puan += sise.Hacim;
                    label5.Text = Convert.ToString(_puan);
                    ResimDegistir();
                }
            }

            if (pictureBox1.ImageLocation == resimler[5])
            {
                if (camKutusu.Ekle(bardak))
                {
                    camKutusu.Ekle2(bardak);
                    listBox3.Items.Add("Bardak (250)");
                    progressBar3.Value = camKutusu.DolulukOrani;
                    _puan += bardak.Hacim;
                    label5.Text = Convert.ToString(_puan);
                    ResimDegistir();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)  // Metal butonu
        {
            if (pictureBox1.ImageLocation == resimler[6])
            {
                if (metalKutusu.Ekle(kola))
                {
                    metalKutusu.Ekle2(kola);
                    listBox4.Items.Add("Kola Kutusu (350)");
                    progressBar4.Value = metalKutusu.DolulukOrani;
                    _puan += kola.Hacim;
                    label5.Text = Convert.ToString(_puan);
                    ResimDegistir();
                }
            }

            if (pictureBox1.ImageLocation == resimler[7])
            {
                if (metalKutusu.Ekle(salca))
                {
                    metalKutusu.Ekle2(salca);
                    listBox4.Items.Add("Salça Kutusu (550)");
                    progressBar4.Value = metalKutusu.DolulukOrani;
                    _puan += salca.Hacim;
                    label5.Text = Convert.ToString(_puan);
                    ResimDegistir();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e) // Organik Boşalt
        {
            if (organikAtikKutusu.Bosalt())
            {
                listBox1.Items.Clear();
                organikAtikKutusu.Bosalt2();
                _timeLeft += 3;
                progressBar1.Value = organikAtikKutusu.DolulukOrani;
            }
        }

        private void button6_Click(object sender, EventArgs e) // Kağıt Boşalt
        {
            if (kagitKutusu.Bosalt())
            {
                listBox2.Items.Clear();
                kagitKutusu.Bosalt2();
                _timeLeft += 3;
                _puan += 1000;
                label5.Text = Convert.ToString(_puan);
                progressBar2.Value = kagitKutusu.DolulukOrani;
            }
        }

        private void button7_Click(object sender, EventArgs e) // Cam Boşalt
        {
            if (camKutusu.Bosalt())
            {
                listBox3.Items.Clear();
                camKutusu.Bosalt2();
                _timeLeft += 3;
                _puan += 600;
                label5.Text = Convert.ToString(_puan);
                progressBar3.Value = camKutusu.DolulukOrani;
            }
        }

        private void button8_Click(object sender, EventArgs e) // Metal Boşalt
        {
            if (metalKutusu.Bosalt())
            {
                listBox4.Items.Clear();
                metalKutusu.Bosalt2();
                _timeLeft += 3;
                _puan += 800;
                label5.Text = Convert.ToString(_puan);
                progressBar4.Value = metalKutusu.DolulukOrani;
            }
        }

        private void button10_Click(object sender, EventArgs e)     // Çıkış Butonu
        {
            this.Close();
        }

        private int _timeLeft;
        private int _puan;
        private void timer1_Tick(object sender, EventArgs e)    // Süre hesaplar
        {
            if (_timeLeft > 0)
            {
                _timeLeft--;
                label4.Text = Convert.ToString(_timeLeft);
            }
            else
            {
                button9.Enabled = true;
                timer1.Stop();
                ButonlarKapali();
            }
        }
    }
}