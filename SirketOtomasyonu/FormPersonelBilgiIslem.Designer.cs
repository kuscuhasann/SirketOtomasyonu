﻿
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.sirketOtomasyonuDataSet = new SirketOtomasyonu.sirketOtomasyonuDataSet();
            this.tblDepartmanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblDepartmanTableAdapter = new SirketOtomasyonu.sirketOtomasyonuDataSetTableAdapters.tblDepartmanTableAdapter();
            this.tblDepartmanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cmbDepartman = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sirketOtomasyonuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDepartmanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDepartmanBindingSource1)).BeginInit();
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
            this.tabPage1.Controls.Add(this.cmbDepartman);
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
            this.txtDepartman_ID.Location = new System.Drawing.Point(545, 202);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 46);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(779, 401);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Personel Güncelle";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 46);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(779, 401);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Personel Çıkart";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            // cmbDepartman
            // 
            this.cmbDepartman.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDepartman.FormattingEnabled = true;
            this.cmbDepartman.Location = new System.Drawing.Point(297, 226);
            this.cmbDepartman.Name = "cmbDepartman";
            this.cmbDepartman.Size = new System.Drawing.Size(234, 32);
            this.cmbDepartman.TabIndex = 13;
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
            ((System.ComponentModel.ISupportInitialize)(this.sirketOtomasyonuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDepartmanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDepartmanBindingSource1)).EndInit();
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
        private System.Windows.Forms.ComboBox cmbDepartman;
    }
}