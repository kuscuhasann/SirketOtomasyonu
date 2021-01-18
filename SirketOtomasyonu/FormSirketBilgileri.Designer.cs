
namespace SirketOtomasyonu
{
    partial class FormSirketBilgileri
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
            this.dgvSirketToplamMaas = new System.Windows.Forms.DataGridView();
            this.dgvAsgariUcretAlmayanPersonel = new System.Windows.Forms.DataGridView();
            this.btnToplamMaasGetir = new System.Windows.Forms.Button();
            this.btnAsgariUcrettenYuksekPersonel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSirketToplamMaas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsgariUcretAlmayanPersonel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSirketToplamMaas
            // 
            this.dgvSirketToplamMaas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSirketToplamMaas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSirketToplamMaas.Location = new System.Drawing.Point(12, 12);
            this.dgvSirketToplamMaas.Name = "dgvSirketToplamMaas";
            this.dgvSirketToplamMaas.Size = new System.Drawing.Size(370, 343);
            this.dgvSirketToplamMaas.TabIndex = 0;
            // 
            // dgvAsgariUcretAlmayanPersonel
            // 
            this.dgvAsgariUcretAlmayanPersonel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAsgariUcretAlmayanPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsgariUcretAlmayanPersonel.Location = new System.Drawing.Point(431, 12);
            this.dgvAsgariUcretAlmayanPersonel.Name = "dgvAsgariUcretAlmayanPersonel";
            this.dgvAsgariUcretAlmayanPersonel.Size = new System.Drawing.Size(357, 343);
            this.dgvAsgariUcretAlmayanPersonel.TabIndex = 1;
            // 
            // btnToplamMaasGetir
            // 
            this.btnToplamMaasGetir.Location = new System.Drawing.Point(76, 379);
            this.btnToplamMaasGetir.Name = "btnToplamMaasGetir";
            this.btnToplamMaasGetir.Size = new System.Drawing.Size(219, 59);
            this.btnToplamMaasGetir.TabIndex = 2;
            this.btnToplamMaasGetir.Text = "Toplam Maaş Gideri Görüntüle";
            this.btnToplamMaasGetir.UseVisualStyleBackColor = true;
            this.btnToplamMaasGetir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAsgariUcrettenYuksekPersonel
            // 
            this.btnAsgariUcrettenYuksekPersonel.Location = new System.Drawing.Point(517, 379);
            this.btnAsgariUcrettenYuksekPersonel.Name = "btnAsgariUcrettenYuksekPersonel";
            this.btnAsgariUcrettenYuksekPersonel.Size = new System.Drawing.Size(219, 59);
            this.btnAsgariUcrettenYuksekPersonel.TabIndex = 3;
            this.btnAsgariUcrettenYuksekPersonel.Text = "Asgari Ücretten Yüksek Ücret Alan Personeller";
            this.btnAsgariUcrettenYuksekPersonel.UseVisualStyleBackColor = true;
            this.btnAsgariUcrettenYuksekPersonel.Click += new System.EventHandler(this.btnAsgariUcrettenYuksekPersonel_Click);
            // 
            // FormSirketBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnAsgariUcrettenYuksekPersonel);
            this.Controls.Add(this.btnToplamMaasGetir);
            this.Controls.Add(this.dgvAsgariUcretAlmayanPersonel);
            this.Controls.Add(this.dgvSirketToplamMaas);
            this.Name = "FormSirketBilgileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şirket Bilgileri";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSirketToplamMaas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsgariUcretAlmayanPersonel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSirketToplamMaas;
        private System.Windows.Forms.DataGridView dgvAsgariUcretAlmayanPersonel;
        private System.Windows.Forms.Button btnToplamMaasGetir;
        private System.Windows.Forms.Button btnAsgariUcrettenYuksekPersonel;
    }
}