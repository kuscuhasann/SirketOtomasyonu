
namespace SirketOtomasyonu
{
    partial class FormPersonelBilgiIslem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPersonelBilgiIslem));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtDepartman_ID = new System.Windows.Forms.TextBox();
            this.btnPersonelKaydet = new System.Windows.Forms.Button();
            this.txtTcKimlikNo = new System.Windows.Forms.TextBox();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblPersonelId = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPersonelGuncelle = new System.Windows.Forms.Button();
            this.txtMaasGuncelle = new System.Windows.Forms.TextBox();
            this.txtKAdiGuncelle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvPersonelGuncelle = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmanIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPersonelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sirketOtomasyonuDataSet4 = new SirketOtomasyonu.sirketOtomasyonuDataSet4();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblKullaniciSil = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPersonelCikart = new System.Windows.Forms.Button();
            this.dgvPersonelCikart = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sirketOtomasyonuDataSet = new SirketOtomasyonu.sirketOtomasyonuDataSet();
            this.tblDepartmanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblDepartmanTableAdapter = new SirketOtomasyonu.sirketOtomasyonuDataSetTableAdapters.tblDepartmanTableAdapter();
            this.tblDepartmanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sirketOtomasyonuDataSet2 = new SirketOtomasyonu.sirketOtomasyonuDataSet2();
            this.tblPersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblPersonelTableAdapter = new SirketOtomasyonu.sirketOtomasyonuDataSet2TableAdapters.tblPersonelTableAdapter();
            this.tblPersonelTableAdapter1 = new SirketOtomasyonu.sirketOtomasyonuDataSet4TableAdapters.tblPersonelTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonelGuncelle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirketOtomasyonuDataSet4)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonelCikart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirketOtomasyonuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDepartmanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDepartmanBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirketOtomasyonuDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.ItemSize = new System.Drawing.Size(77, 42);
            this.tabControl1.Location = new System.Drawing.Point(12, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(787, 451);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.txtDepartman_ID);
            this.tabPage1.Controls.Add(this.btnPersonelKaydet);
            this.tabPage1.Controls.Add(this.txtTcKimlikNo);
            this.tabPage1.Controls.Add(this.txtMaas);
            this.tabPage1.Controls.Add(this.txtSifre);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtKullaniciAdi);
            this.tabPage1.Location = new System.Drawing.Point(4, 46);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(779, 401);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Personel Ekle";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtDepartman_ID
            // 
            this.txtDepartman_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDepartman_ID.Location = new System.Drawing.Point(297, 227);
            this.txtDepartman_ID.Name = "txtDepartman_ID";
            this.txtDepartman_ID.Size = new System.Drawing.Size(234, 38);
            this.txtDepartman_ID.TabIndex = 12;
            // 
            // btnPersonelKaydet
            // 
            this.btnPersonelKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelKaydet.Location = new System.Drawing.Point(297, 287);
            this.btnPersonelKaydet.Name = "btnPersonelKaydet";
            this.btnPersonelKaydet.Size = new System.Drawing.Size(234, 50);
            this.btnPersonelKaydet.TabIndex = 10;
            this.btnPersonelKaydet.Text = "Personel Kaydet";
            this.btnPersonelKaydet.UseVisualStyleBackColor = true;
            this.btnPersonelKaydet.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTcKimlikNo
            // 
            this.txtTcKimlikNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTcKimlikNo.Location = new System.Drawing.Point(297, 86);
            this.txtTcKimlikNo.Name = "txtTcKimlikNo";
            this.txtTcKimlikNo.Size = new System.Drawing.Size(234, 38);
            this.txtTcKimlikNo.TabIndex = 9;
            // 
            // txtMaas
            // 
            this.txtMaas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMaas.Location = new System.Drawing.Point(297, 176);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(234, 38);
            this.txtMaas.TabIndex = 8;
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(297, 132);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(234, 38);
            this.txtSifre.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(85, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 31);
            this.label5.TabIndex = 5;
            this.label5.Text = "Departman ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(181, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "Maaş :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(191, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Şifre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(8, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "TC Kimlik Numarası :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(100, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.Location = new System.Drawing.Point(297, 42);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(234, 38);
            this.txtKullaniciAdi.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblPersonelId);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.btnPersonelGuncelle);
            this.tabPage2.Controls.Add(this.txtMaasGuncelle);
            this.tabPage2.Controls.Add(this.txtKAdiGuncelle);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.dgvPersonelGuncelle);
            this.tabPage2.Location = new System.Drawing.Point(4, 46);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(779, 401);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Personel Güncelle";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblPersonelId
            // 
            this.lblPersonelId.AutoSize = true;
            this.lblPersonelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelId.Location = new System.Drawing.Point(264, 191);
            this.lblPersonelId.Name = "lblPersonelId";
            this.lblPersonelId.Size = new System.Drawing.Size(0, 31);
            this.lblPersonelId.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(87, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 31);
            this.label6.TabIndex = 19;
            this.label6.Text = "Personel ID :";
            // 
            // btnPersonelGuncelle
            // 
            this.btnPersonelGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelGuncelle.Location = new System.Drawing.Point(541, 238);
            this.btnPersonelGuncelle.Name = "btnPersonelGuncelle";
            this.btnPersonelGuncelle.Size = new System.Drawing.Size(231, 92);
            this.btnPersonelGuncelle.TabIndex = 18;
            this.btnPersonelGuncelle.Text = "Personel Güncelle";
            this.btnPersonelGuncelle.UseVisualStyleBackColor = true;
            this.btnPersonelGuncelle.Click += new System.EventHandler(this.btnPersonelGuncelle_Click);
            // 
            // txtMaasGuncelle
            // 
            this.txtMaasGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMaasGuncelle.Location = new System.Drawing.Point(264, 275);
            this.txtMaasGuncelle.Name = "txtMaasGuncelle";
            this.txtMaasGuncelle.Size = new System.Drawing.Size(234, 38);
            this.txtMaasGuncelle.TabIndex = 15;
            // 
            // txtKAdiGuncelle
            // 
            this.txtKAdiGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKAdiGuncelle.Location = new System.Drawing.Point(264, 231);
            this.txtKAdiGuncelle.Name = "txtKAdiGuncelle";
            this.txtKAdiGuncelle.Size = new System.Drawing.Size(234, 38);
            this.txtKAdiGuncelle.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(163, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 31);
            this.label7.TabIndex = 9;
            this.label7.Text = "Maaş :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(76, 238);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(182, 31);
            this.label10.TabIndex = 6;
            this.label10.Text = "Personel Adı :";
            // 
            // dgvPersonelGuncelle
            // 
            this.dgvPersonelGuncelle.AutoGenerateColumns = false;
            this.dgvPersonelGuncelle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersonelGuncelle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonelGuncelle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.personelAdiDataGridViewTextBoxColumn,
            this.personelMaasDataGridViewTextBoxColumn,
            this.departmanIDDataGridViewTextBoxColumn,
            this.kullaniciIDDataGridViewTextBoxColumn});
            this.dgvPersonelGuncelle.DataSource = this.tblPersonelBindingSource1;
            this.dgvPersonelGuncelle.Location = new System.Drawing.Point(6, 6);
            this.dgvPersonelGuncelle.Name = "dgvPersonelGuncelle";
            this.dgvPersonelGuncelle.Size = new System.Drawing.Size(766, 146);
            this.dgvPersonelGuncelle.TabIndex = 0;
            this.dgvPersonelGuncelle.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personelAdiDataGridViewTextBoxColumn
            // 
            this.personelAdiDataGridViewTextBoxColumn.DataPropertyName = "personelAdi";
            this.personelAdiDataGridViewTextBoxColumn.HeaderText = "personelAdi";
            this.personelAdiDataGridViewTextBoxColumn.Name = "personelAdiDataGridViewTextBoxColumn";
            // 
            // personelMaasDataGridViewTextBoxColumn
            // 
            this.personelMaasDataGridViewTextBoxColumn.DataPropertyName = "personelMaas";
            this.personelMaasDataGridViewTextBoxColumn.HeaderText = "personelMaas";
            this.personelMaasDataGridViewTextBoxColumn.Name = "personelMaasDataGridViewTextBoxColumn";
            // 
            // departmanIDDataGridViewTextBoxColumn
            // 
            this.departmanIDDataGridViewTextBoxColumn.DataPropertyName = "departman_ID";
            this.departmanIDDataGridViewTextBoxColumn.HeaderText = "departman_ID";
            this.departmanIDDataGridViewTextBoxColumn.Name = "departmanIDDataGridViewTextBoxColumn";
            // 
            // kullaniciIDDataGridViewTextBoxColumn
            // 
            this.kullaniciIDDataGridViewTextBoxColumn.DataPropertyName = "kullanici_ID";
            this.kullaniciIDDataGridViewTextBoxColumn.HeaderText = "kullanici_ID";
            this.kullaniciIDDataGridViewTextBoxColumn.Name = "kullaniciIDDataGridViewTextBoxColumn";
            // 
            // tblPersonelBindingSource1
            // 
            this.tblPersonelBindingSource1.DataMember = "tblPersonel";
            this.tblPersonelBindingSource1.DataSource = this.sirketOtomasyonuDataSet4;
            // 
            // sirketOtomasyonuDataSet4
            // 
            this.sirketOtomasyonuDataSet4.DataSetName = "sirketOtomasyonuDataSet4";
            this.sirketOtomasyonuDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblKullaniciSil);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.btnPersonelCikart);
            this.tabPage3.Controls.Add(this.dgvPersonelCikart);
            this.tabPage3.Location = new System.Drawing.Point(4, 46);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(779, 401);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Personel Çıkart";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblKullaniciSil
            // 
            this.lblKullaniciSil.AutoSize = true;
            this.lblKullaniciSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciSil.Location = new System.Drawing.Point(177, 165);
            this.lblKullaniciSil.Name = "lblKullaniciSil";
            this.lblKullaniciSil.Size = new System.Drawing.Size(0, 31);
            this.lblKullaniciSil.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(6, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 31);
            this.label8.TabIndex = 20;
            this.label8.Text = "Kullanıcı ID :";
            // 
            // btnPersonelCikart
            // 
            this.btnPersonelCikart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelCikart.Location = new System.Drawing.Point(285, 217);
            this.btnPersonelCikart.Name = "btnPersonelCikart";
            this.btnPersonelCikart.Size = new System.Drawing.Size(231, 92);
            this.btnPersonelCikart.TabIndex = 19;
            this.btnPersonelCikart.Text = "Seçili Personel Çıkart";
            this.btnPersonelCikart.UseVisualStyleBackColor = true;
            this.btnPersonelCikart.Click += new System.EventHandler(this.btnPersonelCikart_Click);
            // 
            // dgvPersonelCikart
            // 
            this.dgvPersonelCikart.AutoGenerateColumns = false;
            this.dgvPersonelCikart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersonelCikart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonelCikart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvPersonelCikart.DataSource = this.tblPersonelBindingSource1;
            this.dgvPersonelCikart.Location = new System.Drawing.Point(7, 6);
            this.dgvPersonelCikart.Name = "dgvPersonelCikart";
            this.dgvPersonelCikart.Size = new System.Drawing.Size(766, 146);
            this.dgvPersonelCikart.TabIndex = 1;
            this.dgvPersonelCikart.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonelCikart_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "personelAdi";
            this.dataGridViewTextBoxColumn2.HeaderText = "personelAdi";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "personelMaas";
            this.dataGridViewTextBoxColumn3.HeaderText = "personelMaas";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "departman_ID";
            this.dataGridViewTextBoxColumn4.HeaderText = "departman_ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "kullanici_ID";
            this.dataGridViewTextBoxColumn5.HeaderText = "kullanici_ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // sirketOtomasyonuDataSet
            // 
            this.sirketOtomasyonuDataSet.DataSetName = "sirketOtomasyonuDataSet";
            this.sirketOtomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDepartmanBindingSource
            // 
            this.tblDepartmanBindingSource.DataMember = "tblDepartman";
            this.tblDepartmanBindingSource.DataSource = this.sirketOtomasyonuDataSet;
            // 
            // tblDepartmanTableAdapter
            // 
            this.tblDepartmanTableAdapter.ClearBeforeFill = true;
            // 
            // tblDepartmanBindingSource1
            // 
            this.tblDepartmanBindingSource1.DataMember = "tblDepartman";
            this.tblDepartmanBindingSource1.DataSource = this.sirketOtomasyonuDataSet;
            // 
            // sirketOtomasyonuDataSet2
            // 
            this.sirketOtomasyonuDataSet2.DataSetName = "sirketOtomasyonuDataSet2";
            this.sirketOtomasyonuDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPersonelBindingSource
            // 
            this.tblPersonelBindingSource.DataMember = "tblPersonel";
            this.tblPersonelBindingSource.DataSource = this.sirketOtomasyonuDataSet2;
            // 
            // tblPersonelTableAdapter
            // 
            this.tblPersonelTableAdapter.ClearBeforeFill = true;
            // 
            // tblPersonelTableAdapter1
            // 
            this.tblPersonelTableAdapter1.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(664, 293);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormPersonelBilgiIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormPersonelBilgiIslem";
            this.Text = "FormPersonelBilgiIslem";
            this.Load += new System.EventHandler(this.FormPersonelBilgiIslem_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonelGuncelle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirketOtomasyonuDataSet4)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonelCikart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirketOtomasyonuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDepartmanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDepartmanBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirketOtomasyonuDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtTcKimlikNo;
        private System.Windows.Forms.TextBox txtMaas;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private sirketOtomasyonuDataSet sirketOtomasyonuDataSet;
        private System.Windows.Forms.BindingSource tblDepartmanBindingSource;
        private sirketOtomasyonuDataSetTableAdapters.tblDepartmanTableAdapter tblDepartmanTableAdapter;
        private System.Windows.Forms.Button btnPersonelKaydet;
        private System.Windows.Forms.BindingSource tblDepartmanBindingSource1;
        private System.Windows.Forms.TextBox txtDepartman_ID;
        private System.Windows.Forms.DataGridView dgvPersonelGuncelle;
        private sirketOtomasyonuDataSet2 sirketOtomasyonuDataSet2;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource;
        private sirketOtomasyonuDataSet2TableAdapters.tblPersonelTableAdapter tblPersonelTableAdapter;
        private sirketOtomasyonuDataSet4 sirketOtomasyonuDataSet4;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource1;
        private sirketOtomasyonuDataSet4TableAdapters.tblPersonelTableAdapter tblPersonelTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelMaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmanIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnPersonelGuncelle;
        private System.Windows.Forms.TextBox txtMaasGuncelle;
        private System.Windows.Forms.TextBox txtKAdiGuncelle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblPersonelId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPersonelCikart;
        private System.Windows.Forms.DataGridView dgvPersonelCikart;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblKullaniciSil;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}