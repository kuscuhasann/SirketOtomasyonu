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
    public partial class FormPersonelGoruntuleme : Form
    {
        public FormPersonelGoruntuleme()
        {
            InitializeComponent();
        }

        private void FormPersonelGoruntuleme_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'sirketOtomasyonuDataSet3.tblPersonel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tblPersonelTableAdapter.Fill(this.sirketOtomasyonuDataSet3.tblPersonel);

        }
    }
}
