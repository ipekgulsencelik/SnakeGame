using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class Form1 : Form
    {
        private Label _yilanKafasi;

        private int _yilanParcasiArasiMesafe = 2;
        private int _yilanParcasiSayisi;

        private int _yilanBoyutu = 20;
        private int _yemBoyutu = 20;

        private Label _yem;

        private Random _random;

        private HareketYonu _yon;

        public Form1()
        {
            InitializeComponent();

            _random = new Random();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Sifirlama();
        }

        private void YenidenBaslatma()
        {
            lblPuan.Text = "0";
            lblSure.Text = "0";

            Sifirlama();
        }

        public void Sifirlama()
        {
            pnl.Controls.Clear();

            _yilanParcasiSayisi = 0;

            YemOlusturma();
            YemYeriDegistirme();
            YilanYerlestirme();

            _yon = HareketYonu.Saga;

            timerYilanHareket.Enabled = true;
            timer.Enabled = true;
        }

        private Label YilanParcasiOlusturma(int locationX, int locationY)
        {
            _yilanParcasiSayisi++;

            Label lbl = new Label()
            {
                Name = "yilanParca" + _yilanParcasiSayisi,
                BackColor = Color.Red,
                Width = _yilanBoyutu,
                Height = _yilanBoyutu,
                Location = new Point(locationX, locationY)
            };

            this.pnl.Controls.Add(lbl);

            return lbl;
        }

        private void YilanYerlestirme()
        {
            _yilanKafasi = YilanParcasiOlusturma(0, 0);

            _yilanKafasi.Text = ":";
            _yilanKafasi.TextAlign = ContentAlignment.MiddleCenter;

            _yilanKafasi.ForeColor = Color.White;

            var locationX = (pnl.Width / 2) - (_yilanKafasi.Width / 2);
            var locationY = (pnl.Height / 2) - (_yilanKafasi.Height / 2);

            _yilanKafasi.Location = new Point(locationX, locationY);
        }

        private void YemOlusturma()
        {
            Label lbl = new Label()
            {
                Name = "yem",
                BackColor = Color.Yellow,
                Width = _yemBoyutu,
                Height = _yemBoyutu,
            };

            _yem = lbl;

            this.pnl.Controls.Add(lbl);
        }

        private void YemYeriDegistirme()
        {
            var locationX = 0;
            var locationY = 0;

            bool durum;

            do
            {
                durum = false;

                locationX = _random.Next(0, pnl.Width - _yemBoyutu);
                locationY = _random.Next(0, pnl.Height - _yemBoyutu);

                var rect1 = new Rectangle(new Point(locationX, locationY), _yem.Size);

                foreach (Control control in pnl.Controls)
                {
                    if (control is Label && control.Name.Contains("yilanParca"))
                    {
                        var rect2 = new Rectangle(control.Location, control.Size);

                        if (rect1.IntersectsWith(rect2))
                        {
                            durum = true;

                            break;
                        }
                    }
                }
            } while (durum);

            _yem.Location = new Point(locationX, locationY);
        }

        private enum HareketYonu
        {
            Yukari,
            Asagi,
            Sola,
            Saga
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            var KeyCode = e.KeyCode;

            if (_yon == HareketYonu.Sola && KeyCode == Keys.D || _yon == HareketYonu.Saga && KeyCode == Keys.A || _yon == HareketYonu.Yukari && KeyCode == Keys.W || _yon == HareketYonu.Asagi && KeyCode == Keys.S)
                return;

            switch (KeyCode)
            {
                case Keys.W:
                    _yon = HareketYonu.Yukari;
                    break;
                case Keys.S:
                    _yon = HareketYonu.Asagi;
                    break;
                case Keys.A:
                    _yon = HareketYonu.Sola;
                    break;
                case Keys.D:
                    _yon = HareketYonu.Saga;
                    break;
                case Keys.P:
                    timer.Enabled = false;
                    timerYilanHareket.Enabled = false;
                    break;
                case Keys.C:
                    timer.Enabled = true;
                    timerYilanHareket.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        private void timerYilanHareket_Tick(object sender, EventArgs e)
        {
            YilanKafasiniTakipEtme();

            YilanYurutme();

            OyunBittiMi();

            YilanYemiYediMi();
        }

        private void YilanYurutme()
        {
            var locationX = _yilanKafasi.Location.X;
            var locationY = _yilanKafasi.Location.Y;

            switch (_yon)
            {
                case HareketYonu.Yukari:
                    _yilanKafasi.Location = new Point(locationX, locationY - (_yilanKafasi.Width + _yilanParcasiArasiMesafe));
                    break;
                case HareketYonu.Asagi:
                    _yilanKafasi.Location = new Point(locationX, locationY + (_yilanKafasi.Width + _yilanParcasiArasiMesafe));
                    break;
                case HareketYonu.Sola:
                    _yilanKafasi.Location = new Point(locationX - (_yilanKafasi.Width + _yilanParcasiArasiMesafe), locationY);
                    break;
                case HareketYonu.Saga:
                    _yilanKafasi.Location = new Point(locationX + (_yilanKafasi.Width + _yilanParcasiArasiMesafe), locationY);
                    break;
                default:
                    break;
            }
        }

        private void OyunBittiMi()
        {
            bool oyunBitti = false;

            var rect1 = new Rectangle(_yilanKafasi.Location, _yilanKafasi.Size);

            foreach (Control control in pnl.Controls)
            {
                if (control is Label && control.Name.Contains("yilanParca") && control.Name != _yilanKafasi.Name)
                {
                    var rect2 = new Rectangle(control.Location, control.Size);

                    if (rect1.IntersectsWith(rect2))
                    {
                        oyunBitti = true;
                        break;
                    }
                }
            }
            
            if (oyunBitti)
            {
                timerYilanHareket.Enabled = false;
                timer.Enabled = false;

                DialogResult result = MessageBox.Show("Puan : " + lblPuan.Text, "Oyun Bitti...", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                    YenidenBaslatma();
            }
        }

        private void YilanYemiYediMi()
        {
            var rect1 = new Rectangle(_yilanKafasi.Location, _yilanKafasi.Size);
            var rect2 = new Rectangle(_yem.Location, _yem.Size);

            if (rect1.IntersectsWith(rect2))
            {
                lblPuan.Text = (Convert.ToInt32(lblPuan.Text) + 10).ToString();

                YemYeriDegistirme();
                YilanParcasiOlusturma(-_yilanBoyutu, -_yilanBoyutu);
            }
        }

        private void YilanKafasiniTakipEtme()
        {
            if (_yilanParcasiSayisi <= 1) return;

            for (int i = _yilanParcasiSayisi; i > 1; i--)
            {
                var sonrakiParca = (Label)pnl.Controls[i];
                var oncekiParca = (Label)pnl.Controls[i-1];

                sonrakiParca.Location = oncekiParca.Location;
            }
            {

            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblSure.Text = (Convert.ToInt32(lblSure.Text) + 1).ToString();
        }
    }
}