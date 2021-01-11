using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SirketOtomasyonu
{
       
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection(@"Data Source = DESKTOP-QOR4M8B; Initial Catalog = sirketOtomasyonu; Integrated Security = True");

        SqlCommand command;

        SqlDataReader read;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTcNo.Text) && !string.IsNullOrEmpty(txtSifre.Text))
            {
                connect.Open();
                command = new SqlCommand("Select * From tblKullanicilar where kullaniciTcNo = @p1 and kullaniciSifre = @p2", connect);
                command.Parameters.AddWithValue("@p1", txtTcNo.Text);
                command.Parameters.AddWithValue("@p2", txtSifre.Text);
                read = command.ExecuteReader();
                if (read.Read())
                {
                    if (read[4].Equals(1)) 
                    {
                        this.Hide();
                        FormPersonel formPersonel = new FormPersonel();
                        formPersonel.Show();
                    }
                    else if (read[4].Equals(2)) 
                    {
                        this.Hide();
                        FormYonetici formYonetici = new FormYonetici();
                        formYonetici.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Hatalıdır. Tekrar Deneyiniz");
                }
                connect.Close();
            }
            else
            {
                MessageBox.Show("Lütfen Kullanıcı Adını ve Şifre Giriniz.");
            }

        }
    }
}
