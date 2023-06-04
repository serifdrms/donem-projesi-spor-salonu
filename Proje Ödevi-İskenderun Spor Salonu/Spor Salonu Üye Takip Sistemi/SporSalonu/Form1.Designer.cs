namespace SporSalonu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.ad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.soyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uyeno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tckimlik = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.iletişim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.TEMİZLE = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ad,
            this.soyad,
            this.uyeno,
            this.tckimlik,
            this.iletişim,
            this.bas,
            this.bit});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(107, 321);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(874, 219);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // ad
            // 
            this.ad.Text = "AD";
            this.ad.Width = 120;
            // 
            // soyad
            // 
            this.soyad.Text = "SOYAD";
            this.soyad.Width = 120;
            // 
            // uyeno
            // 
            this.uyeno.Text = "ÜYE NUMARASI";
            this.uyeno.Width = 100;
            // 
            // tckimlik
            // 
            this.tckimlik.Text = "TC KİMLİK NO";
            this.tckimlik.Width = 120;
            // 
            // iletişim
            // 
            this.iletişim.Text = "İLETİŞİM";
            this.iletişim.Width = 120;
            // 
            // bas
            // 
            this.bas.Text = "ÜYELİK BAŞLANGIÇ TARİHİ";
            this.bas.Width = 160;
            // 
            // bit
            // 
            this.bit.Text = "ÜYELİK BİTİŞ TARİHİ";
            this.bit.Width = 130;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 21);
            this.button1.TabIndex = 1;
            this.button1.Text = "ÜYE EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(191, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(191, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(191, 92);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(188, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 21);
            this.button2.TabIndex = 5;
            this.button2.Text = "ÜYE SİL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(274, 244);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 21);
            this.button3.TabIndex = 6;
            this.button3.Text = "DÜZENLE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(501, 281);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 34);
            this.button4.TabIndex = 7;
            this.button4.Text = "ÜYE ARA";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(191, 124);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "ÜYE NO :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "AD :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "SOYAD :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "TC KİMLİK NO :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "ÜYELİK BAŞLANGIÇ TARİHİ :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "ÜYELİK BİTİŞ TARİHİ :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(124, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "İLETİŞİM :";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(191, 148);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 18;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(341, 183);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 46);
            this.button5.TabIndex = 19;
            this.button5.Text = "TARİH GİRİŞİ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(188, 183);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(45, 20);
            this.textBox6.TabIndex = 20;
            this.textBox6.Text = "GÜN";
            this.textBox6.Click += new System.EventHandler(this.textBox6_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(239, 183);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(42, 20);
            this.textBox7.TabIndex = 21;
            this.textBox7.Text = "AY";
            this.textBox7.Click += new System.EventHandler(this.textBox7_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(287, 183);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(45, 20);
            this.textBox8.TabIndex = 23;
            this.textBox8.Text = "2023";
            this.textBox8.Click += new System.EventHandler(this.textBox8_Click);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(188, 183);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(147, 20);
            this.textBox9.TabIndex = 24;
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(188, 209);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(45, 20);
            this.textBox10.TabIndex = 25;
            this.textBox10.Text = "GÜN";
            this.textBox10.Click += new System.EventHandler(this.textBox10_Click);
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(239, 209);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(45, 20);
            this.textBox11.TabIndex = 26;
            this.textBox11.Text = "AY";
            this.textBox11.Click += new System.EventHandler(this.textBox11_Click);
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(290, 209);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(45, 20);
            this.textBox12.TabIndex = 27;
            this.textBox12.Text = "2023";
            this.textBox12.Click += new System.EventHandler(this.textBox12_Click);
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(188, 209);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(147, 20);
            this.textBox13.TabIndex = 28;
            this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TEMİZLE
            // 
            this.TEMİZLE.Location = new System.Drawing.Point(1038, 281);
            this.TEMİZLE.Name = "TEMİZLE";
            this.TEMİZLE.Size = new System.Drawing.Size(91, 34);
            this.TEMİZLE.TabIndex = 29;
            this.TEMİZLE.Text = "TEMİZLE";
            this.TEMİZLE.UseVisualStyleBackColor = true;
            this.TEMİZLE.Click += new System.EventHandler(this.TEMİZLE_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.Location = new System.Drawing.Point(268, 271);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(88, 21);
            this.button8.TabIndex = 31;
            this.button8.Text = "TARİH DÜZENLE";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 552);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.TEMİZLE);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "İskenderun Spor salonu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ColumnHeader ad;
        private System.Windows.Forms.ColumnHeader soyad;
        private System.Windows.Forms.ColumnHeader uyeno;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ColumnHeader tckimlik;
        private System.Windows.Forms.ColumnHeader iletişim;
        private System.Windows.Forms.ColumnHeader bas;
        private System.Windows.Forms.ColumnHeader bit;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Button TEMİZLE;
        private System.Windows.Forms.Button button8;
    }
}

