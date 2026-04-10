namespace CRUDMahasiswaADO
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNIM = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.cmbJK = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpTanggalLahir = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKodeProdi = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnUpdate_Click = new System.Windows.Forms.Button();
            this.btnDelete_Click = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnInsert_Click = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jenis Kelamin";
            // 
            // txtNIM
            // 
            this.txtNIM.Location = new System.Drawing.Point(175, 83);
            this.txtNIM.Name = "txtNIM";
            this.txtNIM.Size = new System.Drawing.Size(132, 22);
            this.txtNIM.TabIndex = 3;
            this.txtNIM.TextChanged += new System.EventHandler(this.txtNIM_TextChanged);
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(175, 125);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(200, 22);
            this.txtNama.TabIndex = 4;
            this.txtNama.TextChanged += new System.EventHandler(this.txtNama_TextChanged);
            // 
            // cmbJK
            // 
            this.cmbJK.FormattingEnabled = true;
            this.cmbJK.Location = new System.Drawing.Point(175, 176);
            this.cmbJK.Name = "cmbJK";
            this.cmbJK.Size = new System.Drawing.Size(117, 24);
            this.cmbJK.TabIndex = 5;
            this.cmbJK.SelectedIndexChanged += new System.EventHandler(this.cmbJK_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tanggal Lahir";
            // 
            // dtpTanggalLahir
            // 
            this.dtpTanggalLahir.Location = new System.Drawing.Point(175, 221);
            this.dtpTanggalLahir.Name = "dtpTanggalLahir";
            this.dtpTanggalLahir.Size = new System.Drawing.Size(200, 22);
            this.dtpTanggalLahir.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Alamat";
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(175, 268);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(200, 22);
            this.txtAlamat.TabIndex = 9;
            this.txtAlamat.TextChanged += new System.EventHandler(this.txtAlamat_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Kode Prodi";
            // 
            // txtKodeProdi
            // 
            this.txtKodeProdi.Location = new System.Drawing.Point(175, 311);
            this.txtKodeProdi.Name = "txtKodeProdi";
            this.txtKodeProdi.Size = new System.Drawing.Size(77, 22);
            this.txtKodeProdi.TabIndex = 11;
            this.txtKodeProdi.TextChanged += new System.EventHandler(this.txtKodeProdi_TextChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(450, 82);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(144, 23);
            this.btnConnect.TabIndex = 12;
            this.btnConnect.Text = "Membuka Koneksi";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(450, 125);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(144, 23);
            this.btnLoad.TabIndex = 13;
            this.btnLoad.Text = "Menampilkan Data";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnUpdate_Click
            // 
            this.btnUpdate_Click.Location = new System.Drawing.Point(450, 223);
            this.btnUpdate_Click.Name = "btnUpdate_Click";
            this.btnUpdate_Click.Size = new System.Drawing.Size(144, 23);
            this.btnUpdate_Click.TabIndex = 15;
            this.btnUpdate_Click.Text = "Mengubah Data";
            this.btnUpdate_Click.UseVisualStyleBackColor = true;
            this.btnUpdate_Click.Click += new System.EventHandler(this.btnUpdate_Click_Click);
            // 
            // btnDelete_Click
            // 
            this.btnDelete_Click.Location = new System.Drawing.Point(450, 268);
            this.btnDelete_Click.Name = "btnDelete_Click";
            this.btnDelete_Click.Size = new System.Drawing.Size(144, 23);
            this.btnDelete_Click.TabIndex = 16;
            this.btnDelete_Click.Text = "Menghapus Data";
            this.btnDelete_Click.UseVisualStyleBackColor = true;
            this.btnDelete_Click.Click += new System.EventHandler(this.btnDelete_Click_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(69, 377);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(525, 213);
            this.dataGridView1.TabIndex = 17;
            // 
            // btnInsert_Click
            // 
            this.btnInsert_Click.Location = new System.Drawing.Point(450, 169);
            this.btnInsert_Click.Name = "btnInsert_Click";
            this.btnInsert_Click.Size = new System.Drawing.Size(144, 23);
            this.btnInsert_Click.TabIndex = 18;
            this.btnInsert_Click.Text = "Menambahkan Data";
            this.btnInsert_Click.UseVisualStyleBackColor = true;
            this.btnInsert_Click.Click += new System.EventHandler(this.btnInsert_Click_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 624);
            this.Controls.Add(this.btnInsert_Click);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete_Click);
            this.Controls.Add(this.btnUpdate_Click);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtKodeProdi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpTanggalLahir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbJK);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtNIM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNIM;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.ComboBox cmbJK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpTanggalLahir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKodeProdi;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnUpdate_Click;
        private System.Windows.Forms.Button btnDelete_Click;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnInsert_Click;
    }
}

