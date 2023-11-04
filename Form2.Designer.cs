namespace projectdataasrama
{
    partial class Form2
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtboxNama = new System.Windows.Forms.TextBox();
            this.txtboxNIM = new System.Windows.Forms.TextBox();
            this.txtboxnotlpn1 = new System.Windows.Forms.TextBox();
            this.txtboxnotlpn2 = new System.Windows.Forms.TextBox();
            this.txtboxkamar = new System.Windows.Forms.TextBox();
            this.btncari = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btntambah = new System.Windows.Forms.Button();
            this.btnhapus = new System.Windows.Forms.Button();
            this.btnkembali = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Data Asrama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.label3.Location = new System.Drawing.Point(89, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "NIM :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.label4.Location = new System.Drawing.Point(89, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "No. Telpon :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.Location = new System.Drawing.Point(89, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "No. Telpon Orangtua :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.label6.Location = new System.Drawing.Point(89, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Kamar :";
            // 
            // txtboxNama
            // 
            this.txtboxNama.Location = new System.Drawing.Point(259, 77);
            this.txtboxNama.Name = "txtboxNama";
            this.txtboxNama.Size = new System.Drawing.Size(175, 20);
            this.txtboxNama.TabIndex = 6;
            // 
            // txtboxNIM
            // 
            this.txtboxNIM.Location = new System.Drawing.Point(259, 118);
            this.txtboxNIM.Name = "txtboxNIM";
            this.txtboxNIM.Size = new System.Drawing.Size(175, 20);
            this.txtboxNIM.TabIndex = 7;
            // 
            // txtboxnotlpn1
            // 
            this.txtboxnotlpn1.Location = new System.Drawing.Point(259, 160);
            this.txtboxnotlpn1.Name = "txtboxnotlpn1";
            this.txtboxnotlpn1.Size = new System.Drawing.Size(175, 20);
            this.txtboxnotlpn1.TabIndex = 8;
            // 
            // txtboxnotlpn2
            // 
            this.txtboxnotlpn2.Location = new System.Drawing.Point(259, 207);
            this.txtboxnotlpn2.Name = "txtboxnotlpn2";
            this.txtboxnotlpn2.Size = new System.Drawing.Size(175, 20);
            this.txtboxnotlpn2.TabIndex = 9;
            // 
            // txtboxkamar
            // 
            this.txtboxkamar.Location = new System.Drawing.Point(259, 254);
            this.txtboxkamar.Name = "txtboxkamar";
            this.txtboxkamar.Size = new System.Drawing.Size(175, 20);
            this.txtboxkamar.TabIndex = 10;
            // 
            // btncari
            // 
            this.btncari.Location = new System.Drawing.Point(511, 75);
            this.btncari.Name = "btncari";
            this.btncari.Size = new System.Drawing.Size(75, 23);
            this.btncari.TabIndex = 11;
            this.btncari.Text = "Cari";
            this.btncari.UseVisualStyleBackColor = true;
            this.btncari.Click += new System.EventHandler(this.btncari_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(610, 75);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 12;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btntambah
            // 
            this.btntambah.Location = new System.Drawing.Point(511, 116);
            this.btntambah.Name = "btntambah";
            this.btntambah.Size = new System.Drawing.Size(75, 23);
            this.btntambah.TabIndex = 13;
            this.btntambah.Text = "Tambah";
            this.btntambah.UseVisualStyleBackColor = true;
            // 
            // btnhapus
            // 
            this.btnhapus.Location = new System.Drawing.Point(610, 116);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Size = new System.Drawing.Size(75, 23);
            this.btnhapus.TabIndex = 14;
            this.btnhapus.Text = "Hapus";
            this.btnhapus.UseVisualStyleBackColor = true;
            // 
            // btnkembali
            // 
            this.btnkembali.Location = new System.Drawing.Point(610, 158);
            this.btnkembali.Name = "btnkembali";
            this.btnkembali.Size = new System.Drawing.Size(75, 23);
            this.btnkembali.TabIndex = 15;
            this.btnkembali.Text = "Kembali";
            this.btnkembali.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(116, 306);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(569, 187);
            this.dataGridView1.TabIndex = 16;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 537);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnkembali);
            this.Controls.Add(this.btnhapus);
            this.Controls.Add(this.btntambah);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btncari);
            this.Controls.Add(this.txtboxkamar);
            this.Controls.Add(this.txtboxnotlpn2);
            this.Controls.Add(this.txtboxnotlpn1);
            this.Controls.Add(this.txtboxNIM);
            this.Controls.Add(this.txtboxNama);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtboxNama;
        private System.Windows.Forms.TextBox txtboxNIM;
        private System.Windows.Forms.TextBox txtboxnotlpn1;
        private System.Windows.Forms.TextBox txtboxnotlpn2;
        private System.Windows.Forms.TextBox txtboxkamar;
        private System.Windows.Forms.Button btncari;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btntambah;
        private System.Windows.Forms.Button btnhapus;
        private System.Windows.Forms.Button btnkembali;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}