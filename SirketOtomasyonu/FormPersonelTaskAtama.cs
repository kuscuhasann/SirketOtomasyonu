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
    public partial class FormPersonelTaskAtama : Form
    {
        public FormPersonelTaskAtama()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection(@"Data Source = DESKTOP-QOR4M8B; Initial Catalog = sirketOtomasyonu; Integrated Security = True");

        SqlCommand  getUsersId,addToTask,getStaffId;
        SqlDataReader read;
        int id ,staffId;



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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormYonetici fr = new FormYonetici();
            fr.Show();
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

        private void btnGorevlendir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(rchTaskAciklama.Text) && !string.IsNullOrEmpty(cmbPersonelIsim.Text))
            {
                AddToTask();
                MessageBox.Show("Task atama işlemi başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Gerekli alanlar boş bırakılamaz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        void AddToTask() 
        {
            connect.Open();
           
           
            getStaffId = new SqlCommand("select id from tblPersonel where personelAdi=@p1", connect);
            getStaffId.Parameters.AddWithValue("@p1", cmbPersonelIsim.Text);
            read = getStaffId.ExecuteReader();
            if (read.Read())
            {
                staffId = Convert.ToInt32(read["id"]);
                  read.Close();
            }
          
            addToTask = new SqlCommand("insert into tblGorev (gorevAciklamasi,gorevDurum_ID,personel_ID) values (@p1,@p2,@p3)", connect);
            addToTask.Parameters.AddWithValue("@p1", rchTaskAciklama.Text);
            addToTask.Parameters.AddWithValue("@p2", 1);
            addToTask.Parameters.AddWithValue("@p3", staffId);
            addToTask.ExecuteNonQuery();
            connect.Close();
        }

    }
}
