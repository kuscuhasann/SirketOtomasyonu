
namespace SirketOtomasyonu
{
    partial class FormPersonelTaskAtama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPersonelTaskAtama));
            this.cmbPersonelIsim = new System.Windows.Forms.ComboBox();
            this.tblPersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sirketOtomasyonuDataSet2 = new SirketOtomasyonu.sirketOtomasyonuDataSet2();
            this.rchTaskAciklama = new System.Windows.Forms.RichTextBox();
            this.btnGorevlendir = new System.Windows.Forms.Button();
            this.sirketOtomasyonuDataSet11 = new SirketOtomasyonu.sirketOtomasyonuDataSet1();
            this.tblKullanicilarTableAdapter = new SirketOtomasyonu.sirketOtomasyonuDataSet1TableAdapters.tblKullanicilarTableAdapter();
            this.tblKullanicilarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sirketOtomasyonuDataSet1 = new SirketOtomasyonu.sirketOtomasyonuDataSet1();
            this.tblKullanicilarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblPersonelTableAdapter = new SirketOtomasyonu.sirketOtomasyonuDataSet2TableAdapters.tblPersonelTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirketOtomasyonuDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirketOtomasyonuDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKullanicilarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirketOtomasyonuDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKullanicilarBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPersonelIsim
            // 
            this.cmbPersonelIsim.DataSource = this.tblPersonelBindingSource;
            this.cmbPersonelIsim.DisplayMember = "personelAdi";
            this.cmbPersonelIsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbPersonelIsim.FormattingEnabled = true;
            this.cmbPersonelIsim.Location = new System.Drawing.Point(397, 124);
            this.cmbPersonelIsim.Name = "cmbPersonelIsim";
            this.cmbPersonelIsim.Size = new System.Drawing.Size(175, 39);
            this.cmbPersonelIsim.TabIndex = 0;
            this.cmbPersonelIsim.ValueMember = "kullaniciAdi";
            // 
            // tblPersonelBindingSource
            // 
            this.tblPersonelBindingSource.DataMember = "tblPersonel";
            this.tblPersonelBindingSource.DataSource = this.sirketOtomasyonuDataSet2;
            // 
            // sirketOtomasyonuDataSet2
            // 
            this.sirketOtomasyonuDataSet2.DataSetName = "sirketOtomasyonuDataSet2";
            this.sirketOtomasyonuDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rchTaskAciklama
            // 
            this.rchTaskAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rchTaskAciklama.Location = new System.Drawing.Point(12, 53);
            this.rchTaskAciklama.Name = "rchTaskAciklama";
            this.rchTaskAciklama.Size = new System.Drawing.Size(330, 151);
            this.rchTaskAciklama.TabIndex = 1;
            this.rchTaskAciklama.Text = "";
            // 
            // btnGorevlendir
            // 
            this.btnGorevlendir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGorevlendir.Location = new System.Drawing.Point(397, 228);
            this.btnGorevlendir.Name = "btnGorevlendir";
            this.btnGorevlendir.Size = new System.Drawing.Size(175, 76);
            this.btnGorevlendir.TabIndex = 2;
            this.btnGorevlendir.Text = "Görevlendir";
            this.btnGorevlendir.UseVisualStyleBackColor = true;
            this.btnGorevlendir.Click += new System.EventHandler(this.btnGorevlendir_Click);
            // 
            // sirketOtomasyonuDataSet11
            // 
            this.sirketOtomasyonuDataSet11.DataSetName = "sirketOtomasyonuDataSet1";
            this.sirketOtomasyonuDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblKullanicilarTableAdapter
            // 
            this.tblKullanicilarTableAdapter.ClearBeforeFill = true;
            // 
            // tblKullanicilarBindingSource
            // 
            this.tblKullanicilarBindingSource.DataMember = "tblKullanicilar";
            // 
            // sirketOtomasyonuDataSet1
            // 
            this.sirketOtomasyonuDataSet1.DataSetName = "sirketOtomasyonuDataSet1";
            this.sirketOtomasyonuDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblKullanicilarBindingSource1
            // 
            this.tblKullanicilarBindingSource1.DataMember = "tblKullanicilar";
            this.tblKullanicilarBindingSource1.DataSource = this.sirketOtomasyonuDataSet11;
            // 
            // tblPersonelTableAdapter
            // 
            this.tblPersonelTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(688, 345);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormPersonelTaskAtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGorevlendir);
            this.Controls.Add(this.rchTaskAciklama);
            this.Controls.Add(this.cmbPersonelIsim);
            this.Name = "FormPersonelTaskAtama";
            this.Text = "FormPersonelTaskAtama";
            this.Load += new System.EventHandler(this.FormPersonelTaskAtama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirketOtomasyonuDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirketOtomasyonuDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKullanicilarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirketOtomasyonuDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKullanicilarBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPersonelIsim;
        private System.Windows.Forms.RichTextBox rchTaskAciklama;
        private System.Windows.Forms.Button btnGorevlendir;
        private System.Windows.Forms.BindingSource tblKullanicilarBindingSource1;
        private sirketOtomasyonuDataSet1 sirketOtomasyonuDataSet11;
        private sirketOtomasyonuDataSet1TableAdapters.tblKullanicilarTableAdapter tblKullanicilarTableAdapter;
        private System.Windows.Forms.BindingSource tblKullanicilarBindingSource;
        private sirketOtomasyonuDataSet1 sirketOtomasyonuDataSet1;
        private sirketOtomasyonuDataSet2 sirketOtomasyonuDataSet2;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource;
        private sirketOtomasyonuDataSet2TableAdapters.tblPersonelTableAdapter tblPersonelTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}