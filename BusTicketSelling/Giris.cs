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
    public partial class Girisfrm : Form
    {
        Veriler vr;
        public Girisfrm(Veriler v)
        {
            InitializeComponent();
            vr = v;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtSifre.Text == "1234")
            {
                frmMusteriListesi fm = new frmMusteriListesi(vr);
                fm.Show();
            }
            else
            {
                MessageBox.Show("Hatalı giriş yaptınız. Tekrar deneyin.");
            }
        }
    }
}
