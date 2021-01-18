using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SirketOtomasyonu
{
    public partial class FormYonetici : Form
    {
        public FormYonetici()
        {
            InitializeComponent();
        }
        

        private void btnPersonelBilgiIslem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPersonelBilgiIslem formPersonelBilgiIslem = new FormPersonelBilgiIslem();
            formPersonelBilgiIslem.Show();
        }

        private void btnPersonelTaskAtama_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPersonelTaskAtama formPersonelTaskAtama = new FormPersonelTaskAtama();
            formPersonelTaskAtama.Show();
        }

        private void btnPersonelGoruntuleme_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPersonelGoruntuleme formPersonelGoruntuleme = new FormPersonelGoruntuleme();
            formPersonelGoruntuleme.Show();
        }

        private void btnToplamMaasGetir_Click(object sender, EventArgs e)
        {
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin fr = new FormLogin();
            fr.Show();
        }
    }
}
