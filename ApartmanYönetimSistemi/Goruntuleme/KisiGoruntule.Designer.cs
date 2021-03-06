﻿namespace ApartmanYönetimSistemi.Goruntuleme
{
	partial class KisiGoruntule
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.gb_islemler = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.bt_sil = new System.Windows.Forms.Button();
			this.bt_duzenle = new System.Windows.Forms.Button();
			this.bt_kisiEkle = new System.Windows.Forms.Button();
			this.gb_filtrele = new System.Windows.Forms.GroupBox();
			this.rb_cikisTarihi = new System.Windows.Forms.RadioButton();
			this.rb_girisTarihi = new System.Windows.Forms.RadioButton();
			this.rb_soyad = new System.Windows.Forms.RadioButton();
			this.rb_ad = new System.Windows.Forms.RadioButton();
			this.rb_sahipKiraci = new System.Windows.Forms.RadioButton();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.bt_filtrele = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.gb_islemler.SuspendLayout();
			this.gb_filtrele.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// gb_islemler
			// 
			this.gb_islemler.Controls.Add(this.button1);
			this.gb_islemler.Controls.Add(this.bt_sil);
			this.gb_islemler.Controls.Add(this.bt_duzenle);
			this.gb_islemler.Controls.Add(this.bt_kisiEkle);
			this.gb_islemler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.gb_islemler.Location = new System.Drawing.Point(12, 280);
			this.gb_islemler.Name = "gb_islemler";
			this.gb_islemler.Size = new System.Drawing.Size(115, 215);
			this.gb_islemler.TabIndex = 5;
			this.gb_islemler.TabStop = false;
			this.gb_islemler.Text = "İşlemler";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
			this.button1.Location = new System.Drawing.Point(6, 166);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(101, 43);
			this.button1.TabIndex = 11;
			this.button1.Text = "Raporla";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// bt_sil
			// 
			this.bt_sil.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.bt_sil.ForeColor = System.Drawing.Color.MidnightBlue;
			this.bt_sil.Location = new System.Drawing.Point(6, 117);
			this.bt_sil.Name = "bt_sil";
			this.bt_sil.Size = new System.Drawing.Size(101, 43);
			this.bt_sil.TabIndex = 10;
			this.bt_sil.Text = "Kişiyi Sil";
			this.bt_sil.UseVisualStyleBackColor = false;
			this.bt_sil.Click += new System.EventHandler(this.bt_sil_Click);
			// 
			// bt_duzenle
			// 
			this.bt_duzenle.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.bt_duzenle.ForeColor = System.Drawing.Color.MidnightBlue;
			this.bt_duzenle.Location = new System.Drawing.Point(6, 68);
			this.bt_duzenle.Name = "bt_duzenle";
			this.bt_duzenle.Size = new System.Drawing.Size(101, 43);
			this.bt_duzenle.TabIndex = 9;
			this.bt_duzenle.Text = "Kişiyi Düzenle";
			this.bt_duzenle.UseVisualStyleBackColor = false;
			this.bt_duzenle.Click += new System.EventHandler(this.bt_duzenle_Click);
			// 
			// bt_kisiEkle
			// 
			this.bt_kisiEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.bt_kisiEkle.ForeColor = System.Drawing.Color.MidnightBlue;
			this.bt_kisiEkle.Location = new System.Drawing.Point(6, 19);
			this.bt_kisiEkle.Name = "bt_kisiEkle";
			this.bt_kisiEkle.Size = new System.Drawing.Size(101, 43);
			this.bt_kisiEkle.TabIndex = 8;
			this.bt_kisiEkle.Text = "Kişi Ekle";
			this.bt_kisiEkle.UseVisualStyleBackColor = false;
			this.bt_kisiEkle.Click += new System.EventHandler(this.bt_kisiEkle_Click);
			// 
			// gb_filtrele
			// 
			this.gb_filtrele.Controls.Add(this.rb_cikisTarihi);
			this.gb_filtrele.Controls.Add(this.rb_girisTarihi);
			this.gb_filtrele.Controls.Add(this.rb_soyad);
			this.gb_filtrele.Controls.Add(this.rb_ad);
			this.gb_filtrele.Controls.Add(this.rb_sahipKiraci);
			this.gb_filtrele.Controls.Add(this.textBox1);
			this.gb_filtrele.Controls.Add(this.bt_filtrele);
			this.gb_filtrele.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.gb_filtrele.Location = new System.Drawing.Point(12, 39);
			this.gb_filtrele.Name = "gb_filtrele";
			this.gb_filtrele.Size = new System.Drawing.Size(115, 233);
			this.gb_filtrele.TabIndex = 4;
			this.gb_filtrele.TabStop = false;
			this.gb_filtrele.Text = "Filtrele";
			// 
			// rb_cikisTarihi
			// 
			this.rb_cikisTarihi.AutoSize = true;
			this.rb_cikisTarihi.Location = new System.Drawing.Point(6, 122);
			this.rb_cikisTarihi.Name = "rb_cikisTarihi";
			this.rb_cikisTarihi.Size = new System.Drawing.Size(88, 30);
			this.rb_cikisTarihi.TabIndex = 5;
			this.rb_cikisTarihi.TabStop = true;
			this.rb_cikisTarihi.Tag = "CikisTarihi";
			this.rb_cikisTarihi.Text = "Daireden \r\nÇıkış Tarihi";
			this.rb_cikisTarihi.UseVisualStyleBackColor = true;
			this.rb_cikisTarihi.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
			// 
			// rb_girisTarihi
			// 
			this.rb_girisTarihi.AutoSize = true;
			this.rb_girisTarihi.Location = new System.Drawing.Point(6, 88);
			this.rb_girisTarihi.Name = "rb_girisTarihi";
			this.rb_girisTarihi.Size = new System.Drawing.Size(86, 30);
			this.rb_girisTarihi.TabIndex = 4;
			this.rb_girisTarihi.TabStop = true;
			this.rb_girisTarihi.Tag = "GirisTarihi";
			this.rb_girisTarihi.Text = "Daireye\r\nGiriş Tarihi";
			this.rb_girisTarihi.UseVisualStyleBackColor = true;
			this.rb_girisTarihi.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
			// 
			// rb_soyad
			// 
			this.rb_soyad.AutoSize = true;
			this.rb_soyad.Location = new System.Drawing.Point(6, 65);
			this.rb_soyad.Name = "rb_soyad";
			this.rb_soyad.Size = new System.Drawing.Size(60, 17);
			this.rb_soyad.TabIndex = 3;
			this.rb_soyad.TabStop = true;
			this.rb_soyad.Tag = "Soyad";
			this.rb_soyad.Text = "Soyad";
			this.rb_soyad.UseVisualStyleBackColor = true;
			this.rb_soyad.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
			// 
			// rb_ad
			// 
			this.rb_ad.AutoSize = true;
			this.rb_ad.Location = new System.Drawing.Point(6, 42);
			this.rb_ad.Name = "rb_ad";
			this.rb_ad.Size = new System.Drawing.Size(40, 17);
			this.rb_ad.TabIndex = 2;
			this.rb_ad.TabStop = true;
			this.rb_ad.Tag = "Ad";
			this.rb_ad.Text = "Ad";
			this.rb_ad.UseVisualStyleBackColor = true;
			this.rb_ad.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
			// 
			// rb_sahipKiraci
			// 
			this.rb_sahipKiraci.AutoSize = true;
			this.rb_sahipKiraci.Location = new System.Drawing.Point(6, 19);
			this.rb_sahipKiraci.Name = "rb_sahipKiraci";
			this.rb_sahipKiraci.Size = new System.Drawing.Size(95, 17);
			this.rb_sahipKiraci.TabIndex = 1;
			this.rb_sahipKiraci.TabStop = true;
			this.rb_sahipKiraci.Tag = "KisiDurum";
			this.rb_sahipKiraci.Text = "Sahip/Kiracı";
			this.rb_sahipKiraci.UseVisualStyleBackColor = true;
			this.rb_sahipKiraci.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(6, 158);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(101, 20);
			this.textBox1.TabIndex = 6;
			// 
			// bt_filtrele
			// 
			this.bt_filtrele.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.bt_filtrele.ForeColor = System.Drawing.Color.MidnightBlue;
			this.bt_filtrele.Location = new System.Drawing.Point(6, 184);
			this.bt_filtrele.Name = "bt_filtrele";
			this.bt_filtrele.Size = new System.Drawing.Size(101, 43);
			this.bt_filtrele.TabIndex = 7;
			this.bt_filtrele.Text = "Filtrele";
			this.bt_filtrele.UseVisualStyleBackColor = false;
			this.bt_filtrele.Click += new System.EventHandler(this.bt_filtrele_Click);
			// 
			// dataGridView1
			// 
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(142, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(600, 472);
			this.dataGridView1.TabIndex = 3;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.MidnightBlue;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label1.Location = new System.Drawing.Point(2, 12);
			this.label1.MinimumSize = new System.Drawing.Size(145, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(145, 24);
			this.label1.TabIndex = 8;
			this.label1.Text = "Kişiler";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// KisiGoruntule
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.ClientSize = new System.Drawing.Size(754, 496);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.gb_islemler);
			this.Controls.Add(this.gb_filtrele);
			this.MinimumSize = new System.Drawing.Size(770, 535);
			this.Name = "KisiGoruntule";
			this.Text = "Kişileri Görüntüle - KKY Site Yönetim Sistemi";
			this.Resize += new System.EventHandler(this.KisiGoruntule_Resize);
			this.gb_islemler.ResumeLayout(false);
			this.gb_filtrele.ResumeLayout(false);
			this.gb_filtrele.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox gb_islemler;
		private System.Windows.Forms.Button bt_sil;
		private System.Windows.Forms.Button bt_duzenle;
		private System.Windows.Forms.Button bt_kisiEkle;
		private System.Windows.Forms.GroupBox gb_filtrele;
		private System.Windows.Forms.RadioButton rb_soyad;
		private System.Windows.Forms.RadioButton rb_ad;
		private System.Windows.Forms.RadioButton rb_sahipKiraci;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button bt_filtrele;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.RadioButton rb_cikisTarihi;
		private System.Windows.Forms.RadioButton rb_girisTarihi;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
	}
}