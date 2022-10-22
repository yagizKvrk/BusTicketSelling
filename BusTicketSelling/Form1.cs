using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTicketSelling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            btnRezervasyonYap.Enabled=false;
            int koltukNo=1;
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Button b = new Button();
                    b.Click += b_Click;
                    b.BackColor=Color.AntiqueWhite;
                    b.Width = 30;
                    b.Height = 30;
                    b.Top = 30 + (i * 35);
                    b.Text = koltukNo.ToString();
                    koltukNo++;
                    if(j == 1)
                    {
                        b.Left = 5 + (j * 70);
                    }
                    else
                    {
                        b.Left = 5 + (j * 50);
                    }
                    this.Controls.Add(b);
                }
            }
        }
        Veriler v = new Veriler();
        private void btnRezervasyonYap_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtAd.Text) || String.IsNullOrEmpty(txtSoyad.Text) || String.IsNullOrEmpty(txtTc.Text) || String.IsNullOrEmpty(mtbTel.Text))
            {
                MessageBox.Show("Boş bırakılamaz");
                return;
            }

            Yolcu y = new Yolcu();
            foreach (Control b in this.Controls)
            {
                if (b.BackColor == Color.Green)
                {
                    if(Convert.ToInt32(b.Text)%3==0 && rdbKadin.Checked)
                    {
                        foreach (Control c in this.Controls)
                        {
                            if(c.Text==(Convert.ToInt32(b.Text)-1).ToString())
                            {
                                if(c.BackColor == Color.Blue)
                                {
                                    MessageBox.Show("Bu koltuk seçilemez");
                                }
                                else
                                {
                                    Reserve(b, y);
                                    MessageBox.Show("Kayıt Başarılı");
                                    btnRezervasyonYap.Enabled = false;
                                    return;
                                }
                            }
                        }
                    }
                    else if (Convert.ToInt32(b.Text) % 3 == 0 && rdbErkek.Checked)
                    {
                        foreach (Control c in this.Controls)
                        {
                            if (c.Text == (Convert.ToInt32(b.Text) - 1).ToString())
                            {
                                if(c.BackColor == Color.HotPink)
                                {
                                    MessageBox.Show("Bu koltuk seçilemez");
                                }
                                else
                                {
                                    Reserve(b, y);
                                    MessageBox.Show("Kayıt Başarılı");
                                    btnRezervasyonYap.Enabled = false;
                                    return;
                                }
                            }
                        }
                    }
                    else if (Convert.ToInt32(b.Text) % 3 == 2 && rdbKadin.Checked)
                    {
                        foreach (Control c in this.Controls)
                        {
                            if (c.Text == (Convert.ToInt32(b.Text) + 1).ToString())
                            {
                                if(c.BackColor == Color.Blue)
                                {
                                    MessageBox.Show("Bu koltuk seçilemez");
                                }
                                else
                                {
                                    Reserve(b, y);
                                    MessageBox.Show("Kayıt Başarılı");
                                    btnRezervasyonYap.Enabled = false;
                                    return;
                                }
                            }
                        }
                    }
                    else if (Convert.ToInt32(b.Text) % 3 == 2 && rdbErkek.Checked)
                    {
                        foreach (Control c in this.Controls)
                        {
                            if (c.Text == (Convert.ToInt32(b.Text) + 1).ToString() )
                            {
                                if(c.BackColor == Color.HotPink)
                                {
                                    MessageBox.Show("Bu koltuk seçilemez");
                                }
                                else
                                {
                                    Reserve(b, y);
                                    MessageBox.Show("Kayıt Başarılı");
                                    btnRezervasyonYap.Enabled = false;
                                    return;
                                }
                            }
                        }
                    }
                    else
                    {
                        Reserve(b, y);
                        MessageBox.Show("Kayıt Başarılı");
                        btnRezervasyonYap.Enabled = false;
                    }
                }
            }
        }
        private void b_Click(object sender, EventArgs e)
        {
            btnRezervasyonYap.Enabled = true;
            Button bTiklanan = (Button)sender;
            bTiklanan.BackColor = Color.Green;
            string sayi = bTiklanan.Text;
            foreach(Control b in this.Controls)
            {
                if(b is Button)
                {
                    if (b.Text != sayi && (b.BackColor!=Color.Blue && b.BackColor != Color.HotPink))
                    {
                        b.BackColor = Color.AntiqueWhite;
                    }
                }
            }
        }

        public void btnAdminGirisi_Click(object sender, EventArgs e)
        {
            Girisfrm gf = new Girisfrm(v);
            gf.Show();
        }
        public void Reserve(Control b, Yolcu y)
        {
            b.Enabled = false;
            if (rdbErkek.Checked)
                b.BackColor = Color.Blue;
            else
                b.BackColor = Color.HotPink;

            y.KoltukNo = Convert.ToInt32(b.Text);
            y.Ad = txtAd.Text;
            y.Soyad = txtSoyad.Text;
            y.TcNo = txtTc.Text;
            y.TelNo = mtbTel.Text;
            y.ErkekMi = rdbErkek.Checked ? "Erkek" : "Kadın";

            v.YolcuListesi.Add(y);
        }
    }
}
