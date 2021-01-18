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
    public partial class FormPersonelBilgiIslem : Form
    {
        public FormPersonelBilgiIslem()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection(@"Data Source = DESKTOP-QOR4M8B; Initial Catalog = sirketOtomasyonu; Integrated Security = True");

        SqlCommand addUser,addStaff, getUserId,personelGuncelle,personelSil,deleteUser;

        int idEkle, idCikar,idDepartman;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormYonetici fr = new FormYonetici();
            fr.Show();
        }

        private void dgvPersonelCikart_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dgvPersonelGuncelle.SelectedCells[0].RowIndex;
            lblKullaniciSil.Text = dgvPersonelGuncelle.Rows[secilen].Cells[4].Value.ToString();
            
        }

        private void btnPersonelCikart_Click(object sender, EventArgs e)
        {
            connect.Open();
            personelSil = new SqlCommand("delete from tblPersonel where kullanici_ID=@p1 ", connect);
            personelSil.Parameters.AddWithValue("@p1", lblKullaniciSil.Text);
            personelSil.ExecuteNonQuery();
            deleteUser = new SqlCommand("delete from tblKullanicilar where id=@p1", connect);
            deleteUser.Parameters.AddWithValue("@p1", lblKullaniciSil.Text);
            deleteUser.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Personel silme işlemi başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnPersonelGuncelle_Click(object sender, EventArgs e)
        {
            connect.Open();
            personelGuncelle = new SqlCommand("Update tblPersonel set personelAdi=@p1,personelMaas=@p2 where id=@p3",connect);
            personelGuncelle.Parameters.AddWithValue("@p1",txtKAdiGuncelle.Text);
            personelGuncelle.Parameters.AddWithValue("@p2",txtMaasGuncelle.Text);
            personelGuncelle.Parameters.AddWithValue("@p3",lblPersonelId.Text);
            personelGuncelle.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Güncelleme İşleminiz Başarıyla Gerçekleştirilmiştir","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dgvPersonelGuncelle.SelectedCells[0].RowIndex;
            lblPersonelId.Text = dgvPersonelGuncelle.Rows[secilen].Cells[0].Value.ToString();
            txtKAdiGuncelle.Text = dgvPersonelGuncelle.Rows[secilen].Cells[1].Value.ToString();
            txtMaasGuncelle.Text = dgvPersonelGuncelle.Rows[secilen].Cells[2].Value.ToString();            
        }

        SqlDataReader read;

        private void FormPersonelBilgiIslem_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'sirketOtomasyonuDataSet4.tblPersonel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tblPersonelTableAdapter1.Fill(this.sirketOtomasyonuDataSet4.tblPersonel);
            // TODO: Bu kod satırı 'sirketOtomasyonuDataSet2.tblPersonel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tblPersonelTableAdapter.Fill(this.sirketOtomasyonuDataSet2.tblPersonel);
            // TODO: Bu kod satırı 'sirketOtomasyonuDataSet.tblDepartman' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tblDepartmanTableAdapter.Fill(this.sirketOtomasyonuDataSet.tblDepartman);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (connect.State == ConnectionState.Closed)
                connect.Open();
            addUser = new SqlCommand("insert into tblKullanicilar(kullaniciAdi,kullaniciTcNo,kullaniciSifre,kullaniciRol_ID) values (@p1,@p2,@p3,@p4)", connect);
            addUser.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
            addUser.Parameters.AddWithValue("@p2", txtTcKimlikNo.Text);
            addUser.Parameters.AddWithValue("@p3", txtSifre.Text);
            addUser.Parameters.AddWithValue("@p4", 1);
            addUser.ExecuteNonQuery();
            getUserId = new SqlCommand("select id from tblKullanicilar where kullaniciTcNo=@p2", connect);
            getUserId.Parameters.AddWithValue("@p2", txtTcKimlikNo.Text);
            read = getUserId.ExecuteReader();
            if (read.Read())
            {
                idEkle = Convert.ToInt32(read["id"]);
                
                read.Close();
            }         
            addStaff = new SqlCommand("insert into tblPersonel (personelAdi,personelMaas,departman_ID,kullanici_ID) values (@p1,@p2,@p3,@p4)", connect);
            addStaff.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
            addStaff.Parameters.AddWithValue("@p2", txtMaas.Text);
            addStaff.Parameters.AddWithValue("@p3", txtDepartman_ID.Text);
            addStaff.Parameters.AddWithValue("@p4", idEkle);
            addStaff.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("İşleminiz Başarıyla Tamamlanmıştır.");
        }
    }
}
