﻿namespace PROJECT_SALON_HAWA_KEL11
{
    partial class LihatPaketLengkap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LihatPaketLengkap));
            this.btnKeluar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idpktlengkapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idprwtrambutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idprwtwajahDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namapaketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paketLengkapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetHawaSalon = new PROJECT_SALON_HAWA_KEL11.DataSetHawaSalon();
            this.paket_LengkapTableAdapter = new PROJECT_SALON_HAWA_KEL11.DataSetHawaSalonTableAdapters.Paket_LengkapTableAdapter();
            this.btnKembali = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paketLengkapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetHawaSalon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKeluar
            // 
            this.btnKeluar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnKeluar.ForeColor = System.Drawing.Color.LightCoral;
            this.btnKeluar.Location = new System.Drawing.Point(65, 305);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(80, 27);
            this.btnKeluar.TabIndex = 33;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = false;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MistyRose;
            this.label2.Location = new System.Drawing.Point(379, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 22);
            this.label2.TabIndex = 32;
            this.label2.Text = "Lihat Paket Lengkap";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.Color.MistyRose;
            this.label1.Location = new System.Drawing.Point(50, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Hello Admin";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpktlengkapDataGridViewTextBoxColumn,
            this.idprwtrambutDataGridViewTextBoxColumn,
            this.idprwtwajahDataGridViewTextBoxColumn,
            this.namapaketDataGridViewTextBoxColumn,
            this.hargaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.paketLengkapBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(225, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(475, 345);
            this.dataGridView1.TabIndex = 34;
            // 
            // idpktlengkapDataGridViewTextBoxColumn
            // 
            this.idpktlengkapDataGridViewTextBoxColumn.DataPropertyName = "Id_pkt_lengkap";
            this.idpktlengkapDataGridViewTextBoxColumn.HeaderText = "ID Paket Lengkap";
            this.idpktlengkapDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idpktlengkapDataGridViewTextBoxColumn.Name = "idpktlengkapDataGridViewTextBoxColumn";
            this.idpktlengkapDataGridViewTextBoxColumn.Width = 150;
            // 
            // idprwtrambutDataGridViewTextBoxColumn
            // 
            this.idprwtrambutDataGridViewTextBoxColumn.DataPropertyName = "Id_prwt_rambut";
            this.idprwtrambutDataGridViewTextBoxColumn.HeaderText = "ID Perawatan Rambut";
            this.idprwtrambutDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idprwtrambutDataGridViewTextBoxColumn.Name = "idprwtrambutDataGridViewTextBoxColumn";
            this.idprwtrambutDataGridViewTextBoxColumn.Width = 150;
            // 
            // idprwtwajahDataGridViewTextBoxColumn
            // 
            this.idprwtwajahDataGridViewTextBoxColumn.DataPropertyName = "Id_prwt_wajah";
            this.idprwtwajahDataGridViewTextBoxColumn.HeaderText = "ID Perawatan Wajah";
            this.idprwtwajahDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idprwtwajahDataGridViewTextBoxColumn.Name = "idprwtwajahDataGridViewTextBoxColumn";
            this.idprwtwajahDataGridViewTextBoxColumn.Width = 150;
            // 
            // namapaketDataGridViewTextBoxColumn
            // 
            this.namapaketDataGridViewTextBoxColumn.DataPropertyName = "nama_paket";
            this.namapaketDataGridViewTextBoxColumn.HeaderText = "Nama Paket";
            this.namapaketDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.namapaketDataGridViewTextBoxColumn.Name = "namapaketDataGridViewTextBoxColumn";
            this.namapaketDataGridViewTextBoxColumn.Width = 150;
            // 
            // hargaDataGridViewTextBoxColumn
            // 
            this.hargaDataGridViewTextBoxColumn.DataPropertyName = "harga";
            this.hargaDataGridViewTextBoxColumn.HeaderText = "Harga";
            this.hargaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hargaDataGridViewTextBoxColumn.Name = "hargaDataGridViewTextBoxColumn";
            this.hargaDataGridViewTextBoxColumn.Width = 150;
            // 
            // paketLengkapBindingSource
            // 
            this.paketLengkapBindingSource.DataMember = "Paket_Lengkap";
            this.paketLengkapBindingSource.DataSource = this.dataSetHawaSalon;
            // 
            // dataSetHawaSalon
            // 
            this.dataSetHawaSalon.DataSetName = "DataSetHawaSalon";
            this.dataSetHawaSalon.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paket_LengkapTableAdapter
            // 
            this.paket_LengkapTableAdapter.ClearBeforeFill = true;
            // 
            // btnKembali
            // 
            this.btnKembali.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnKembali.ForeColor = System.Drawing.Color.LightCoral;
            this.btnKembali.Location = new System.Drawing.Point(65, 260);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(80, 27);
            this.btnKembali.TabIndex = 35;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = false;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // LihatPaketLengkap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "LihatPaketLengkap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LihatPaketLengkap";
            this.Load += new System.EventHandler(this.LihatPaketLengkap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paketLengkapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetHawaSalon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetHawaSalon dataSetHawaSalon;
        private System.Windows.Forms.BindingSource paketLengkapBindingSource;
        private DataSetHawaSalonTableAdapters.Paket_LengkapTableAdapter paket_LengkapTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpktlengkapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprwtrambutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprwtwajahDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namapaketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnKembali;
    }
}