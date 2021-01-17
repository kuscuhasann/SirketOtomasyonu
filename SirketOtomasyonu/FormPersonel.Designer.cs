
namespace SirketOtomasyonu
{
    partial class FormPersonel
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sirketOtomasyonuDataSet5 = new SirketOtomasyonu.sirketOtomasyonuDataSet5();
            this.tblGorevBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblGorevTableAdapter = new SirketOtomasyonu.sirketOtomasyonuDataSet5TableAdapters.tblGorevTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gorevAciklamasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gorevDurumIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirketOtomasyonuDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGorevBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.gorevAciklamasiDataGridViewTextBoxColumn,
            this.gorevDurumIDDataGridViewTextBoxColumn,
            this.personelIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblGorevBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // sirketOtomasyonuDataSet5
            // 
            this.sirketOtomasyonuDataSet5.DataSetName = "sirketOtomasyonuDataSet5";
            this.sirketOtomasyonuDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblGorevBindingSource
            // 
            this.tblGorevBindingSource.DataMember = "tblGorev";
            this.tblGorevBindingSource.DataSource = this.sirketOtomasyonuDataSet5;
            // 
            // tblGorevTableAdapter
            // 
            this.tblGorevTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gorevAciklamasiDataGridViewTextBoxColumn
            // 
            this.gorevAciklamasiDataGridViewTextBoxColumn.DataPropertyName = "gorevAciklamasi";
            this.gorevAciklamasiDataGridViewTextBoxColumn.HeaderText = "gorevAciklamasi";
            this.gorevAciklamasiDataGridViewTextBoxColumn.Name = "gorevAciklamasiDataGridViewTextBoxColumn";
            // 
            // gorevDurumIDDataGridViewTextBoxColumn
            // 
            this.gorevDurumIDDataGridViewTextBoxColumn.DataPropertyName = "gorevDurum_ID";
            this.gorevDurumIDDataGridViewTextBoxColumn.HeaderText = "gorevDurum_ID";
            this.gorevDurumIDDataGridViewTextBoxColumn.Name = "gorevDurumIDDataGridViewTextBoxColumn";
            // 
            // personelIDDataGridViewTextBoxColumn
            // 
            this.personelIDDataGridViewTextBoxColumn.DataPropertyName = "personel_ID";
            this.personelIDDataGridViewTextBoxColumn.HeaderText = "personel_ID";
            this.personelIDDataGridViewTextBoxColumn.Name = "personelIDDataGridViewTextBoxColumn";
            // 
            // FormPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormPersonel";
            this.Text = "FormPersonel";
            this.Load += new System.EventHandler(this.FormPersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirketOtomasyonuDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGorevBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private sirketOtomasyonuDataSet5 sirketOtomasyonuDataSet5;
        private System.Windows.Forms.BindingSource tblGorevBindingSource;
        private sirketOtomasyonuDataSet5TableAdapters.tblGorevTableAdapter tblGorevTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gorevAciklamasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gorevDurumIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelIDDataGridViewTextBoxColumn;
    }
}