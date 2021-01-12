using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SirketOtomasyonu
{
    public partial class FormPersonelTaskAtama : Form
    {
        public FormPersonelTaskAtama()
        {
            InitializeComponent();
        }

        private void FormPersonelTaskAtama_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'sirketOtomasyonuDataSet2.tblPersonel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tblPersonelTableAdapter.Fill(this.sirketOtomasyonuDataSet2.tblPersonel);
            // TODO: Bu kod satırı 'sirketOtomasyonuDataSet11.tblKullanicilar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tblKullanicilarTableAdapter.Fill(this.sirketOtomasyonuDataSet11.tblKullanicilar);
            // TODO: Bu kod satırı 'sirketOtomasyonuDataSet1.tblKullanicilar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tblKullanicilarTableAdapter.Fill(this.sirketOtomasyonuDataSet1.tblKullanicilar);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblKullanicilarTableAdapter.FillBy(this.sirketOtomasyonuDataSet1.tblKullanicilar);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void personelKullanicilariniGetirmeToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblKullanicilarTableAdapter.PersonelKullanicilariniGetirme(this.sirketOtomasyonuDataSet1.tblKullanicilar);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void personelKullanicilariniGetirmeToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.tblKullanicilarTableAdapter.PersonelKullanicilariniGetirme(this.sirketOtomasyonuDataSet1.tblKullanicilar);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void personelKullanicilariToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblKullanicilarTableAdapter.PersonelKullanicilari(this.sirketOtomasyonuDataSet1.tblKullanicilar);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblKullanicilarTableAdapter.FillBy2(this.sirketOtomasyonuDataSet11.tblKullanicilar);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
