﻿
namespace SirketOtomasyonu
{
    partial class FormYonetici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormYonetici));
            this.btnPersonelBilgiIslem = new System.Windows.Forms.Button();
            this.btnPersonelTaskAtama = new System.Windows.Forms.Button();
            this.btnPersonelGoruntuleme = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnToplamMaasGetir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPersonelBilgiIslem
            // 
            this.btnPersonelBilgiIslem.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonelBilgiIslem.Image")));
            this.btnPersonelBilgiIslem.Location = new System.Drawing.Point(127, 12);
            this.btnPersonelBilgiIslem.Name = "btnPersonelBilgiIslem";
            this.btnPersonelBilgiIslem.Size = new System.Drawing.Size(173, 139);
            this.btnPersonelBilgiIslem.TabIndex = 0;
            this.btnPersonelBilgiIslem.UseVisualStyleBackColor = true;
            this.btnPersonelBilgiIslem.Click += new System.EventHandler(this.btnPersonelBilgiIslem_Click);
            // 
            // btnPersonelTaskAtama
            // 
            this.btnPersonelTaskAtama.BackColor = System.Drawing.Color.Transparent;
            this.btnPersonelTaskAtama.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonelTaskAtama.Image")));
            this.btnPersonelTaskAtama.Location = new System.Drawing.Point(402, 12);
            this.btnPersonelTaskAtama.Name = "btnPersonelTaskAtama";
            this.btnPersonelTaskAtama.Size = new System.Drawing.Size(173, 139);
            this.btnPersonelTaskAtama.TabIndex = 1;
            this.btnPersonelTaskAtama.UseVisualStyleBackColor = false;
            this.btnPersonelTaskAtama.Click += new System.EventHandler(this.btnPersonelTaskAtama_Click);
            // 
            // btnPersonelGoruntuleme
            // 
            this.btnPersonelGoruntuleme.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonelGoruntuleme.Image")));
            this.btnPersonelGoruntuleme.Location = new System.Drawing.Point(127, 201);
            this.btnPersonelGoruntuleme.Name = "btnPersonelGoruntuleme";
            this.btnPersonelGoruntuleme.Size = new System.Drawing.Size(173, 139);
            this.btnPersonelGoruntuleme.TabIndex = 2;
            this.btnPersonelGoruntuleme.UseVisualStyleBackColor = true;
            this.btnPersonelGoruntuleme.Click += new System.EventHandler(this.btnPersonelGoruntuleme_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(150, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Personel İşlemleri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(123, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tüm Personellerimi Görüntüle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(404, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Personel Task İşlemleri";
            // 
            // btnToplamMaasGetir
            // 
            this.btnToplamMaasGetir.Location = new System.Drawing.Point(408, 201);
            this.btnToplamMaasGetir.Name = "btnToplamMaasGetir";
            this.btnToplamMaasGetir.Size = new System.Drawing.Size(173, 139);
            this.btnToplamMaasGetir.TabIndex = 8;
            this.btnToplamMaasGetir.Text = "Şirket Bilgileri";
            this.btnToplamMaasGetir.UseVisualStyleBackColor = true;
            this.btnToplamMaasGetir.Click += new System.EventHandler(this.btnToplamMaasGetir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(688, 345);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormYonetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnToplamMaasGetir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPersonelGoruntuleme);
            this.Controls.Add(this.btnPersonelTaskAtama);
            this.Controls.Add(this.btnPersonelBilgiIslem);
            this.Name = "FormYonetici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetici Paneli";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPersonelBilgiIslem;
        private System.Windows.Forms.Button btnPersonelTaskAtama;
        private System.Windows.Forms.Button btnPersonelGoruntuleme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnToplamMaasGetir;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}