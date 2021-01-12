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
    public partial class FormPersonelBilgiIslem : Form
    {
        public FormPersonelBilgiIslem()
        {
            InitializeComponent();
        }

        private void FormPersonelBilgiIslem_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'sirketOtomasyonuDataSet.tblDepartman' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tblDepartmanTableAdapter.Fill(this.sirketOtomasyonuDataSet.tblDepartman);

        }
    }
}
