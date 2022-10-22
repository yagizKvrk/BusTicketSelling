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
    public partial class frmMusteriListesi : Form
    {
        Veriler veri;
        public frmMusteriListesi(Veriler vr)
        {
            InitializeComponent();
            veri = vr;
        }
        private void frmMusteriListesi_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = veri.YolcuListesi;
        }
    }
}
