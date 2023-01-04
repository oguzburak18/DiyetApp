using DiyetApp.Contexts;
using DiyetApp.Kullanici;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiyetApp
{
    public partial class GirisForm : Form
    {
        DiyetDbContext db = new DiyetDbContext();
        public GirisForm()
        {
            InitializeComponent();
            
        }

        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            btnKaydet.Visible = true;
            lblEmail.Visible = true;
            lblTelefon.Visible = true;
            lblSorular.Visible = true;
            txtEmail.Visible = true;
            txtTelefon.Visible = true;
            txtGizliYanit.Visible = true;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Uye uye = new Uye()
            {
                Email = txtEmail.Text,
                Telefon = txtTelefon.Text,
                GizliYanit = txtGizliYanit.Text,
                KullaniciAdi = txtKullaniciAdi.Text,
                Sifre = txtSifre.Text
            };
        }
    }
}
