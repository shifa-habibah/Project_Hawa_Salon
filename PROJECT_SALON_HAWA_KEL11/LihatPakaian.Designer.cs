namespace PROJECT_SALON_HAWA_KEL11
{
    partial class LihatPakaian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LihatPakaian));
            this.btnKembali = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idbajuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskripsiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuantitassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuantitasmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuantitaslDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuantitasxlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pakaianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetHawaSalon = new PROJECT_SALON_HAWA_KEL11.DataSetHawaSalon();
            this.pakaianTableAdapter = new PROJECT_SALON_HAWA_KEL11.DataSetHawaSalonTableAdapters.PakaianTableAdapter();
            this.btnKeluar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pakaianBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetHawaSalon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKembali
            // 
            this.btnKembali.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnKembali.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnKembali.ForeColor = System.Drawing.Color.LightCoral;
            this.btnKembali.Location = new System.Drawing.Point(65, 260);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(80, 27);
            this.btnKembali.TabIndex = 27;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = false;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MistyRose;
            this.label2.Location = new System.Drawing.Point(366, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 22);
            this.label2.TabIndex = 26;
            this.label2.Text = "Lihat Data Kostum Sewa";
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
            this.label1.TabIndex = 25;
            this.label1.Text = "Hello Admin";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idbajuDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.deskripsiDataGridViewTextBoxColumn,
            this.kuantitassDataGridViewTextBoxColumn,
            this.kuantitasmDataGridViewTextBoxColumn,
            this.kuantitaslDataGridViewTextBoxColumn,
            this.kuantitasxlDataGridViewTextBoxColumn,
            this.hargaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pakaianBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(225, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(475, 345);
            this.dataGridView1.TabIndex = 28;
            // 
            // idbajuDataGridViewTextBoxColumn
            // 
            this.idbajuDataGridViewTextBoxColumn.DataPropertyName = "Id_baju";
            this.idbajuDataGridViewTextBoxColumn.HeaderText = "ID Baju";
            this.idbajuDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idbajuDataGridViewTextBoxColumn.Name = "idbajuDataGridViewTextBoxColumn";
            this.idbajuDataGridViewTextBoxColumn.Width = 150;
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "Nama";
            this.namaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            this.namaDataGridViewTextBoxColumn.Width = 150;
            // 
            // deskripsiDataGridViewTextBoxColumn
            // 
            this.deskripsiDataGridViewTextBoxColumn.DataPropertyName = "deskripsi";
            this.deskripsiDataGridViewTextBoxColumn.HeaderText = "Deskripsi";
            this.deskripsiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.deskripsiDataGridViewTextBoxColumn.Name = "deskripsiDataGridViewTextBoxColumn";
            this.deskripsiDataGridViewTextBoxColumn.Width = 150;
            // 
            // kuantitassDataGridViewTextBoxColumn
            // 
            this.kuantitassDataGridViewTextBoxColumn.DataPropertyName = "kuantitas_s";
            this.kuantitassDataGridViewTextBoxColumn.HeaderText = "Kuantitas S";
            this.kuantitassDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kuantitassDataGridViewTextBoxColumn.Name = "kuantitassDataGridViewTextBoxColumn";
            this.kuantitassDataGridViewTextBoxColumn.Width = 150;
            // 
            // kuantitasmDataGridViewTextBoxColumn
            // 
            this.kuantitasmDataGridViewTextBoxColumn.DataPropertyName = "kuantitas_m";
            this.kuantitasmDataGridViewTextBoxColumn.HeaderText = "Kuantitas M";
            this.kuantitasmDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kuantitasmDataGridViewTextBoxColumn.Name = "kuantitasmDataGridViewTextBoxColumn";
            this.kuantitasmDataGridViewTextBoxColumn.Width = 150;
            // 
            // kuantitaslDataGridViewTextBoxColumn
            // 
            this.kuantitaslDataGridViewTextBoxColumn.DataPropertyName = "kuantitas_l";
            this.kuantitaslDataGridViewTextBoxColumn.HeaderText = "Kuantitas L";
            this.kuantitaslDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kuantitaslDataGridViewTextBoxColumn.Name = "kuantitaslDataGridViewTextBoxColumn";
            this.kuantitaslDataGridViewTextBoxColumn.Width = 150;
            // 
            // kuantitasxlDataGridViewTextBoxColumn
            // 
            this.kuantitasxlDataGridViewTextBoxColumn.DataPropertyName = "kuantitas_xl";
            this.kuantitasxlDataGridViewTextBoxColumn.HeaderText = "Kuantitas XL";
            this.kuantitasxlDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kuantitasxlDataGridViewTextBoxColumn.Name = "kuantitasxlDataGridViewTextBoxColumn";
            this.kuantitasxlDataGridViewTextBoxColumn.Width = 150;
            // 
            // hargaDataGridViewTextBoxColumn
            // 
            this.hargaDataGridViewTextBoxColumn.DataPropertyName = "harga";
            this.hargaDataGridViewTextBoxColumn.HeaderText = "Harga";
            this.hargaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hargaDataGridViewTextBoxColumn.Name = "hargaDataGridViewTextBoxColumn";
            this.hargaDataGridViewTextBoxColumn.Width = 150;
            // 
            // pakaianBindingSource
            // 
            this.pakaianBindingSource.DataMember = "Pakaian";
            this.pakaianBindingSource.DataSource = this.dataSetHawaSalon;
            // 
            // dataSetHawaSalon
            // 
            this.dataSetHawaSalon.DataSetName = "DataSetHawaSalon";
            this.dataSetHawaSalon.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pakaianTableAdapter
            // 
            this.pakaianTableAdapter.ClearBeforeFill = true;
            // 
            // btnKeluar
            // 
            this.btnKeluar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnKeluar.ForeColor = System.Drawing.Color.LightCoral;
            this.btnKeluar.Location = new System.Drawing.Point(65, 305);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(80, 27);
            this.btnKeluar.TabIndex = 29;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = false;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // LihatPakaian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "LihatPakaian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LihatPakaian";
            this.Load += new System.EventHandler(this.LihatPakaian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pakaianBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetHawaSalon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetHawaSalon dataSetHawaSalon;
        private System.Windows.Forms.BindingSource pakaianBindingSource;
        private DataSetHawaSalonTableAdapters.PakaianTableAdapter pakaianTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbajuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deskripsiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuantitassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuantitasmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuantitaslDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuantitasxlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnKeluar;
    }
}