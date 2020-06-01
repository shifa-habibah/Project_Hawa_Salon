﻿namespace PROJECT_SALON_HAWA_KEL11
{
    partial class UbahPaketLengkap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UbahPaketLengkap));
            this.btnKembali = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.cmbWajah = new System.Windows.Forms.ComboBox();
            this.perawatanWajahBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetHawaSalon = new PROJECT_SALON_HAWA_KEL11.DataSetHawaSalon();
            this.cmbRambut = new System.Windows.Forms.ComboBox();
            this.perawatanRambutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnCari = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.perawatan_RambutTableAdapter = new PROJECT_SALON_HAWA_KEL11.DataSetHawaSalonTableAdapters.Perawatan_RambutTableAdapter();
            this.perawatan_WajahTableAdapter = new PROJECT_SALON_HAWA_KEL11.DataSetHawaSalonTableAdapters.Perawatan_WajahTableAdapter();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.perawatanWajahBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetHawaSalon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perawatanRambutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKembali
            // 
            this.btnKembali.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnKembali.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKembali.ForeColor = System.Drawing.Color.LightCoral;
            this.btnKembali.Location = new System.Drawing.Point(65, 260);
            this.btnKembali.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(80, 27);
            this.btnKembali.TabIndex = 63;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = false;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.MistyRose;
            this.label13.Location = new System.Drawing.Point(417, 207);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 15);
            this.label13.TabIndex = 62;
            this.label13.Text = "Rp.";
            // 
            // txtHarga
            // 
            this.txtHarga.Enabled = false;
            this.txtHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHarga.Location = new System.Drawing.Point(447, 206);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(213, 21);
            this.txtHarga.TabIndex = 6;
            this.txtHarga.Leave += new System.EventHandler(this.txtHarga_Leave);
            // 
            // cmbWajah
            // 
            this.cmbWajah.DataSource = this.perawatanWajahBindingSource;
            this.cmbWajah.DisplayMember = "Id_prwt_wajah";
            this.cmbWajah.Enabled = false;
            this.cmbWajah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbWajah.FormattingEnabled = true;
            this.cmbWajah.Location = new System.Drawing.Point(420, 173);
            this.cmbWajah.Name = "cmbWajah";
            this.cmbWajah.Size = new System.Drawing.Size(240, 23);
            this.cmbWajah.TabIndex = 5;
            this.cmbWajah.ValueMember = "Id_prwt_wajah";
            this.cmbWajah.Leave += new System.EventHandler(this.cmbWajah_Leave);
            // 
            // perawatanWajahBindingSource
            // 
            this.perawatanWajahBindingSource.DataMember = "Perawatan_Wajah";
            this.perawatanWajahBindingSource.DataSource = this.dataSetHawaSalon;
            // 
            // dataSetHawaSalon
            // 
            this.dataSetHawaSalon.DataSetName = "DataSetHawaSalon";
            this.dataSetHawaSalon.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbRambut
            // 
            this.cmbRambut.DataSource = this.perawatanRambutBindingSource;
            this.cmbRambut.DisplayMember = "Id_prwt_rambut";
            this.cmbRambut.Enabled = false;
            this.cmbRambut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRambut.FormattingEnabled = true;
            this.cmbRambut.Location = new System.Drawing.Point(420, 141);
            this.cmbRambut.Name = "cmbRambut";
            this.cmbRambut.Size = new System.Drawing.Size(240, 23);
            this.cmbRambut.TabIndex = 4;
            this.cmbRambut.ValueMember = "Id_prwt_rambut";
            this.cmbRambut.Leave += new System.EventHandler(this.cmbRambut_Leave);
            // 
            // perawatanRambutBindingSource
            // 
            this.perawatanRambutBindingSource.DataMember = "Perawatan_Rambut";
            this.perawatanRambutBindingSource.DataSource = this.dataSetHawaSalon;
            // 
            // txtNama
            // 
            this.txtNama.Enabled = false;
            this.txtNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNama.Location = new System.Drawing.Point(420, 108);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(240, 21);
            this.txtNama.TabIndex = 3;
            this.txtNama.Leave += new System.EventHandler(this.txtNama_Leave);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(420, 75);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(175, 21);
            this.txtID.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MistyRose;
            this.label7.Location = new System.Drawing.Point(240, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 56;
            this.label7.Text = "Harga";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MistyRose;
            this.label6.Location = new System.Drawing.Point(240, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 17);
            this.label6.TabIndex = 55;
            this.label6.Text = "Perawatan Wajah";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MistyRose;
            this.label5.Location = new System.Drawing.Point(240, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 17);
            this.label5.TabIndex = 54;
            this.label5.Text = "Perawatan Rambut";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MistyRose;
            this.label4.Location = new System.Drawing.Point(240, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 53;
            this.label4.Text = "Nama Paket";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MistyRose;
            this.label3.Location = new System.Drawing.Point(240, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 52;
            this.label3.Text = "ID Paket";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MistyRose;
            this.label2.Location = new System.Drawing.Point(384, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 22);
            this.label2.TabIndex = 51;
            this.label2.Text = "Ubah Paket Lengkap";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MistyRose;
            this.label1.Location = new System.Drawing.Point(50, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 50;
            this.label1.Text = "Hello Admin";
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBatal.Enabled = false;
            this.btnBatal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnBatal.ForeColor = System.Drawing.Color.LightCoral;
            this.btnBatal.Location = new System.Drawing.Point(525, 390);
            this.btnBatal.Margin = new System.Windows.Forms.Padding(2);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(80, 27);
            this.btnBatal.TabIndex = 9;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUbah.Enabled = false;
            this.btnUbah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnUbah.ForeColor = System.Drawing.Color.LightCoral;
            this.btnUbah.Location = new System.Drawing.Point(325, 390);
            this.btnUbah.Margin = new System.Windows.Forms.Padding(2);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(80, 27);
            this.btnUbah.TabIndex = 7;
            this.btnUbah.Text = "Perbarui";
            this.btnUbah.UseVisualStyleBackColor = false;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnCari
            // 
            this.btnCari.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnCari.ForeColor = System.Drawing.Color.LightCoral;
            this.btnCari.Location = new System.Drawing.Point(600, 72);
            this.btnCari.Margin = new System.Windows.Forms.Padding(2);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(60, 27);
            this.btnCari.TabIndex = 2;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = false;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnHapus.Enabled = false;
            this.btnHapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnHapus.ForeColor = System.Drawing.Color.LightCoral;
            this.btnHapus.Location = new System.Drawing.Point(425, 390);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(2);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(80, 27);
            this.btnHapus.TabIndex = 8;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnKeluar.ForeColor = System.Drawing.Color.LightCoral;
            this.btnKeluar.Location = new System.Drawing.Point(65, 310);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(80, 27);
            this.btnKeluar.TabIndex = 72;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = false;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // perawatan_RambutTableAdapter
            // 
            this.perawatan_RambutTableAdapter.ClearBeforeFill = true;
            // 
            // perawatan_WajahTableAdapter
            // 
            this.perawatan_WajahTableAdapter.ClearBeforeFill = true;
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // epCorrect
            // 
            this.epCorrect.ContainerControl = this;
            this.epCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("epCorrect.Icon")));
            // 
            // UbahPaketLengkap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.cmbWajah);
            this.Controls.Add(this.cmbRambut);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "UbahPaketLengkap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UbahPaketLengkap";
            this.Load += new System.EventHandler(this.UbahPaketLengkap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.perawatanWajahBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetHawaSalon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perawatanRambutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.ComboBox cmbWajah;
        private System.Windows.Forms.ComboBox cmbRambut;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnKeluar;
        private DataSetHawaSalon dataSetHawaSalon;
        private System.Windows.Forms.BindingSource perawatanRambutBindingSource;
        private DataSetHawaSalonTableAdapters.Perawatan_RambutTableAdapter perawatan_RambutTableAdapter;
        private System.Windows.Forms.BindingSource perawatanWajahBindingSource;
        private DataSetHawaSalonTableAdapters.Perawatan_WajahTableAdapter perawatan_WajahTableAdapter;
        private System.Windows.Forms.ErrorProvider epError;
        private System.Windows.Forms.ErrorProvider epCorrect;
    }
}