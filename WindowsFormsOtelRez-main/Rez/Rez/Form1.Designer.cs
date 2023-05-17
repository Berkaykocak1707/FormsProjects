namespace Rez
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
            this.texthead = new System.Windows.Forms.Label();
            this.ad = new System.Windows.Forms.Label();
            this.adBox1 = new System.Windows.Forms.TextBox();
            this.soyad = new System.Windows.Forms.Label();
            this.soyadBox2 = new System.Windows.Forms.TextBox();
            this.posta = new System.Windows.Forms.Label();
            this.postatBox3 = new System.Windows.Forms.TextBox();
            this.tel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rez = new System.Windows.Forms.Label();
            this.oda = new System.Windows.Forms.Label();
            this.rezBox1 = new System.Windows.Forms.ComboBox();
            this.odaBox2 = new System.Windows.Forms.ComboBox();
            this.telTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.konkListBox1 = new System.Windows.Forms.CheckedListBox();
            this.konk = new System.Windows.Forms.Label();
            this.fiyListBox2 = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.kis10 = new System.Windows.Forms.Label();
            this.kisBox1 = new System.Windows.Forms.ListBox();
            this.cocuk11 = new System.Windows.Forms.Label();
            this.cocuk2 = new System.Windows.Forms.ListBox();
            this.ulk12 = new System.Windows.Forms.Label();
            this.ulk3 = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.girisCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label14 = new System.Windows.Forms.Label();
            this.cikisCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.notBox4 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // texthead
            // 
            this.texthead.AutoSize = true;
            this.texthead.Font = new System.Drawing.Font("Ebrima", 24F);
            this.texthead.Location = new System.Drawing.Point(325, 31);
            this.texthead.Name = "texthead";
            this.texthead.Size = new System.Drawing.Size(373, 45);
            this.texthead.TabIndex = 0;
            this.texthead.Text = "Avrupa Otel Rezervasyon";
            // 
            // ad
            // 
            this.ad.AutoSize = true;
            this.ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ad.Location = new System.Drawing.Point(34, 118);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(34, 24);
            this.ad.TabIndex = 1;
            this.ad.Text = "Ad";
            this.ad.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // adBox1
            // 
            this.adBox1.Location = new System.Drawing.Point(84, 122);
            this.adBox1.Name = "adBox1";
            this.adBox1.Size = new System.Drawing.Size(93, 20);
            this.adBox1.TabIndex = 2;
            // 
            // soyad
            // 
            this.soyad.AutoSize = true;
            this.soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.soyad.Location = new System.Drawing.Point(199, 119);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(63, 24);
            this.soyad.TabIndex = 1;
            this.soyad.Text = "Soyad";
            this.soyad.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // soyadBox2
            // 
            this.soyadBox2.Location = new System.Drawing.Point(268, 123);
            this.soyadBox2.Name = "soyadBox2";
            this.soyadBox2.Size = new System.Drawing.Size(93, 20);
            this.soyadBox2.TabIndex = 2;
            // 
            // posta
            // 
            this.posta.AutoSize = true;
            this.posta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.posta.Location = new System.Drawing.Point(34, 186);
            this.posta.Name = "posta";
            this.posta.Size = new System.Drawing.Size(75, 24);
            this.posta.TabIndex = 1;
            this.posta.Text = "E-Posta";
            this.posta.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // postatBox3
            // 
            this.postatBox3.Location = new System.Drawing.Point(115, 190);
            this.postatBox3.Name = "postatBox3";
            this.postatBox3.Size = new System.Drawing.Size(246, 20);
            this.postatBox3.TabIndex = 2;
            this.postatBox3.Text = "ornek@gmail.com";
            // 
            // tel
            // 
            this.tel.AutoSize = true;
            this.tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tel.Location = new System.Drawing.Point(34, 254);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(74, 24);
            this.tel.TabIndex = 1;
            this.tel.Text = "Telefon";
            this.tel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label5.Location = new System.Drawing.Point(115, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Alan Kodu";
            this.label5.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label7.Location = new System.Drawing.Point(186, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Telefon Numarası";
            this.label7.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // rez
            // 
            this.rez.AutoSize = true;
            this.rez.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.rez.Location = new System.Drawing.Point(35, 364);
            this.rez.Name = "rez";
            this.rez.Size = new System.Drawing.Size(164, 24);
            this.rez.TabIndex = 1;
            this.rez.Text = "Rezervasyon Türü";
            this.rez.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // oda
            // 
            this.oda.AutoSize = true;
            this.oda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.oda.Location = new System.Drawing.Point(35, 642);
            this.oda.Name = "oda";
            this.oda.Size = new System.Drawing.Size(96, 24);
            this.oda.TabIndex = 1;
            this.oda.Text = "Oda sayısı";
            this.oda.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // rezBox1
            // 
            this.rezBox1.FormattingEnabled = true;
            this.rezBox1.Location = new System.Drawing.Point(39, 403);
            this.rezBox1.Name = "rezBox1";
            this.rezBox1.Size = new System.Drawing.Size(322, 21);
            this.rezBox1.TabIndex = 5;
            // 
            // odaBox2
            // 
            this.odaBox2.FormattingEnabled = true;
            this.odaBox2.Location = new System.Drawing.Point(39, 681);
            this.odaBox2.Name = "odaBox2";
            this.odaBox2.Size = new System.Drawing.Size(134, 21);
            this.odaBox2.TabIndex = 5;
            // 
            // telTextBox1
            // 
            this.telTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.telTextBox1.Location = new System.Drawing.Point(115, 257);
            this.telTextBox1.Mask = "(999)   -    000-0000";
            this.telTextBox1.Name = "telTextBox1";
            this.telTextBox1.Size = new System.Drawing.Size(246, 26);
            this.telTextBox1.TabIndex = 6;
            // 
            // konkListBox1
            // 
            this.konkListBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.konkListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.konkListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.konkListBox1.ForeColor = System.Drawing.Color.Coral;
            this.konkListBox1.FormattingEnabled = true;
            this.konkListBox1.Items.AddRange(new object[] {
            "1 Yıldız",
            "2 Yıldız",
            "3 Yıldız",
            "4 Yıldız",
            "5 Yıldız"});
            this.konkListBox1.Location = new System.Drawing.Point(38, 495);
            this.konkListBox1.MultiColumn = true;
            this.konkListBox1.Name = "konkListBox1";
            this.konkListBox1.Size = new System.Drawing.Size(143, 105);
            this.konkListBox1.TabIndex = 0;
            this.konkListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.konkListBox1_ItemCheck);
            this.konkListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // konk
            // 
            this.konk.AutoSize = true;
            this.konk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.konk.Location = new System.Drawing.Point(35, 458);
            this.konk.Name = "konk";
            this.konk.Size = new System.Drawing.Size(156, 24);
            this.konk.TabIndex = 1;
            this.konk.Text = "Konaklama Puanı";
            this.konk.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // fiyListBox2
            // 
            this.fiyListBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fiyListBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fiyListBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fiyListBox2.ForeColor = System.Drawing.Color.Coral;
            this.fiyListBox2.FormattingEnabled = true;
            this.fiyListBox2.Items.AddRange(new object[] {
            "30€\'a kadar",
            "60€\'a kadar",
            "120€\'a kadar",
            "140€\'a kadar",
            " "});
            this.fiyListBox2.Location = new System.Drawing.Point(231, 495);
            this.fiyListBox2.Name = "fiyListBox2";
            this.fiyListBox2.Size = new System.Drawing.Size(143, 105);
            this.fiyListBox2.TabIndex = 0;
            this.fiyListBox2.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.fiyListBox2_ItemCheck);
            this.fiyListBox2.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.button1.Location = new System.Drawing.Point(36, 880);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(323, 54);
            this.button1.TabIndex = 9;
            this.button1.Text = "Formu Gönder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kis10
            // 
            this.kis10.AutoSize = true;
            this.kis10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.kis10.Location = new System.Drawing.Point(227, 642);
            this.kis10.Name = "kis10";
            this.kis10.Size = new System.Drawing.Size(92, 24);
            this.kis10.TabIndex = 1;
            this.kis10.Text = "Kişi Sayısı";
            this.kis10.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // kisBox1
            // 
            this.kisBox1.FormattingEnabled = true;
            this.kisBox1.Location = new System.Drawing.Point(232, 683);
            this.kisBox1.Name = "kisBox1";
            this.kisBox1.Size = new System.Drawing.Size(127, 30);
            this.kisBox1.TabIndex = 10;
            // 
            // cocuk11
            // 
            this.cocuk11.AutoSize = true;
            this.cocuk11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cocuk11.Location = new System.Drawing.Point(33, 734);
            this.cocuk11.Name = "cocuk11";
            this.cocuk11.Size = new System.Drawing.Size(117, 24);
            this.cocuk11.TabIndex = 1;
            this.cocuk11.Text = "Çocuk Sayısı";
            this.cocuk11.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // cocuk2
            // 
            this.cocuk2.FormattingEnabled = true;
            this.cocuk2.Location = new System.Drawing.Point(38, 775);
            this.cocuk2.Name = "cocuk2";
            this.cocuk2.Size = new System.Drawing.Size(127, 30);
            this.cocuk2.TabIndex = 10;
            // 
            // ulk12
            // 
            this.ulk12.AutoSize = true;
            this.ulk12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ulk12.Location = new System.Drawing.Point(228, 734);
            this.ulk12.Name = "ulk12";
            this.ulk12.Size = new System.Drawing.Size(68, 24);
            this.ulk12.TabIndex = 1;
            this.ulk12.Text = "Ülkeler";
            this.ulk12.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // ulk3
            // 
            this.ulk3.FormattingEnabled = true;
            this.ulk3.Location = new System.Drawing.Point(233, 775);
            this.ulk3.Name = "ulk3";
            this.ulk3.Size = new System.Drawing.Size(127, 30);
            this.ulk3.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label13.Location = new System.Drawing.Point(432, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 24);
            this.label13.TabIndex = 1;
            this.label13.Text = "Giriş Tarihi";
            this.label13.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // girisCalendar1
            // 
            this.girisCalendar1.Location = new System.Drawing.Point(436, 156);
            this.girisCalendar1.MinDate = new System.DateTime(2023, 5, 16, 0, 0, 0, 0);
            this.girisCalendar1.Name = "girisCalendar1";
            this.girisCalendar1.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label14.Location = new System.Drawing.Point(433, 331);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 24);
            this.label14.TabIndex = 1;
            this.label14.Text = "Çıkış Tarihi";
            this.label14.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // cikisCalendar2
            // 
            this.cikisCalendar2.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.cikisCalendar2.Location = new System.Drawing.Point(436, 364);
            this.cikisCalendar2.MinDate = new System.DateTime(2023, 5, 16, 0, 0, 0, 0);
            this.cikisCalendar2.Name = "cikisCalendar2";
            this.cikisCalendar2.TabIndex = 14;
            this.cikisCalendar2.TitleBackColor = System.Drawing.Color.Blue;
            this.cikisCalendar2.TodayDate = new System.DateTime(2023, 5, 16, 0, 0, 0, 0);
            // 
            // notBox4
            // 
            this.notBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.notBox4.Location = new System.Drawing.Point(439, 614);
            this.notBox4.Multiline = true;
            this.notBox4.Name = "notBox4";
            this.notBox4.Size = new System.Drawing.Size(230, 191);
            this.notBox4.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label15.Location = new System.Drawing.Point(435, 573);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 24);
            this.label15.TabIndex = 1;
            this.label15.Text = "Notunuz";
            this.label15.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(227, 458);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bütçe";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listBox2.FormattingEnabled = true;
            this.listBox2.HorizontalScrollbar = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(741, 156);
            this.listBox2.Name = "listBox2";
            this.listBox2.ScrollAlwaysVisible = true;
            this.listBox2.Size = new System.Drawing.Size(271, 580);
            this.listBox2.TabIndex = 17;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "150€",
            "250€",
            "350€",
            "450+€"});
            this.comboBox1.Location = new System.Drawing.Point(233, 583);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(108, 21);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.Text = "Other";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.button2.Location = new System.Drawing.Point(741, 751);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 54);
            this.button2.TabIndex = 9;
            this.button2.Text = "Bilgileri Göster";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.button3.Location = new System.Drawing.Point(741, 880);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(271, 54);
            this.button3.TabIndex = 9;
            this.button3.Text = "Formu Temizle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1049, 979);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.notBox4);
            this.Controls.Add(this.cikisCalendar2);
            this.Controls.Add(this.girisCalendar1);
            this.Controls.Add(this.ulk3);
            this.Controls.Add(this.cocuk2);
            this.Controls.Add(this.kisBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fiyListBox2);
            this.Controls.Add(this.konkListBox1);
            this.Controls.Add(this.telTextBox1);
            this.Controls.Add(this.odaBox2);
            this.Controls.Add(this.rezBox1);
            this.Controls.Add(this.soyadBox2);
            this.Controls.Add(this.ulk12);
            this.Controls.Add(this.soyad);
            this.Controls.Add(this.cocuk11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.kis10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.oda);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.konk);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.rez);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.postatBox3);
            this.Controls.Add(this.posta);
            this.Controls.Add(this.adBox1);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.texthead);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label texthead;
        private System.Windows.Forms.Label ad;
        private System.Windows.Forms.TextBox adBox1;
        private System.Windows.Forms.Label soyad;
        private System.Windows.Forms.TextBox soyadBox2;
        private System.Windows.Forms.Label posta;
        private System.Windows.Forms.TextBox postatBox3;
        private System.Windows.Forms.Label tel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label rez;
        private System.Windows.Forms.Label oda;
        private System.Windows.Forms.ComboBox rezBox1;
        private System.Windows.Forms.ComboBox odaBox2;
        private System.Windows.Forms.MaskedTextBox telTextBox1;
        private System.Windows.Forms.CheckedListBox konkListBox1;
        private System.Windows.Forms.Label konk;
        private System.Windows.Forms.CheckedListBox fiyListBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label kis10;
        private System.Windows.Forms.ListBox kisBox1;
        private System.Windows.Forms.Label cocuk11;
        private System.Windows.Forms.ListBox cocuk2;
        private System.Windows.Forms.Label ulk12;
        private System.Windows.Forms.ListBox ulk3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MonthCalendar girisCalendar1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MonthCalendar cikisCalendar2;
        private System.Windows.Forms.TextBox notBox4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

