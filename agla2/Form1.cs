using System.Windows.Media;

namespace agla2
{
    public partial class Form1 : Form
    {
        int gözyaşı = 0;
        int ağlamaGücü = 1;
        int otoağlaGücü = 1;
        int güçlendirmeFiyatı = 50;
        bool ses = true;
        public Form1()
        {
            InitializeComponent();
        }
        async void AğlamaSesiÇıkar()
        {
            MediaPlayer ses = new MediaPlayer();
            ses.Open(new Uri(Application.StartupPath + "\\Resources\\cry.wav"));
            ses.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (gözyaşı >= güçlendirmeFiyatı)
            {
                gözyaşı -= güçlendirmeFiyatı;
                ağlamaGücü += 1;
                güçlendirmeFiyatı = (int)(güçlendirmeFiyatı * 1.1);
                gözyaşılabel.Text = gözyaşı.ToString();
                button2.Text = "Ağlama gücünü arttır\n(" + güçlendirmeFiyatı.ToString() + " gözyaşı)";
            }
            else
            {
                MessageBox.Show("Yeterince gözyaşınız yok!", "Güçlendirme Alınamadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ses)
            {
                button3.Text = "Ses KAPALI";
                ses = false;
            }
            else
            {
                button3.Text = "Ses AÇIK";
                ses = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (gözyaşı >= 300)
            {
                gözyaşı -= 300;
                gözyaşılabel.Text = gözyaşı.ToString();
                if (otoağlaTimer.Enabled)
                {
                    otoağlaGücü++;
                }
                else
                {
                    otoağlaTimer.Start();
                    button4.Text = "OTOAĞLA'yı Güçlendir (+1)\n(300 gözyaşı)";
                }
            }
            else
            {
                MessageBox.Show("Yeterince gözyaşınız yok!", "Güçlendirme Alınamadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void otoağlaTimer_Tick(object sender, EventArgs e)
        {
            gözyaşı += otoağlaGücü;
            gözyaşılabel.Text = gözyaşı.ToString();
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            gözyaşı += ağlamaGücü;
            gözyaşılabel.Text = gözyaşı.ToString();
            if (ses) AğlamaSesiÇıkar();
        }
    }
}

























