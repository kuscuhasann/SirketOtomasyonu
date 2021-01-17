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

        SqlCommand addUser,addStaff, getUserId,getDepartmanId;

        int idEkle, idCikar,idDepartman;

       

        SqlDataReader read;

        private void FormPersonelBilgiIslem_Load(object sender, EventArgs e)
        {
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
