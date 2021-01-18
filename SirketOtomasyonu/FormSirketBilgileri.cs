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
    public partial class FormSirketBilgileri : Form
    {
        public FormSirketBilgileri()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection(@"Data Source = DESKTOP-QOR4M8B; Initial Catalog = sirketOtomasyonu; Integrated Security = True");

       

        private void btnAsgariUcrettenYuksekPersonel_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("asgariUcretAlmayanPersonel", connect);
            komut.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dr = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            dr.Fill(ds);
            dgvAsgariUcretAlmayanPersonel.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("sirketToplamMaasGideri",connect);
            komut.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dr=new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            dr.Fill(ds);
            dgvSirketToplamMaas.DataSource = ds.Tables[0];
        }
    }
}
