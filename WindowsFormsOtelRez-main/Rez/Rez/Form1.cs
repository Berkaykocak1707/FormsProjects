using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Rez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çözüm");
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void Form1_Load(object sender, EventArgs e)
        {
            rezBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            rezBox1.Items.Add("Ön ödeme");
            rezBox1.Items.Add("Yerinde ödeme");
            rezBox1.Items.Add("Taksitli ödeme");

            odaBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            odaBox2.Items.Add("Tek Kişilik odalar");
            odaBox2.Items.Add("2-4 Kişilik odalar");
            odaBox2.Items.Add("4+ Kişilik odalar");

            string[] kisi = { "1", "2", "3", "4", "5", "6+" };
            foreach (var item in kisi)
            {
                kisBox1.Items.Add(item);
            }

            string[] cocuksay = { "1", "2" ,"3","4","5","6+"};
            foreach (var item in cocuksay)
            {
                cocuk2.Items.Add(item);
            }

            string[] ulke = { "Türkiye", "Almanya", "İtalya", "İngiltere", "Belçika", "Diğer" };
            foreach (string item in ulke)
            {
                ulk3.Items.Add($"{item}");
            }


        }


        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectionRange selectedRange = girisCalendar1.SelectionRange;
            SelectionRange selectedRange2 = cikisCalendar2.SelectionRange;
            string mes, fiy,not;
            if (fiyListBox2.SelectedItem != null)
            {
                fiy = fiyListBox2.SelectedItem.ToString();
            }
            else
            {
                fiy = comboBox1.SelectedItem.ToString();
            }
            if (notBox4.Text == "")
            {
                not = "";
            }
            else
            {
                not = "\nNotunuz:" + notBox4.Text;
            }
            mes = "Adınız:" + adBox1.Text + "\nSoyadınız:" + soyadBox2.Text + "\nE-posta:" + postatBox3.Text + "\nTelefonunuz:" + telTextBox1.Text + "\nRezervasyon Türü:" + rezBox1.SelectedItem.ToString() + "\nKonaklama türü:" + konkListBox1.SelectedItem.ToString() + "\nFiyat:" + fiy + "\nOda Sayısı:" + odaBox2.SelectedItem.ToString() + "\nKişi Sayısı:" + kisBox1.SelectedItem.ToString() + "\nÇocuk Sayısı:" + "Ülke:" + ulk3.SelectedItem.ToString() + cocuk2.SelectedItem.ToString()+ "\nGiriş Tarihi:" + selectedRange.Start.ToString("dd.MM.yyyy") + "\nÇıkış Tarihi:" + selectedRange.Start.ToString("dd.MM.yyyy") + not;
            MessageBox.Show(mes);
            MessageBox.Show("Bilgileriniz kaydedildi!");

        }
        private void button2_Click(object sender, EventArgs e)
        {
            SelectionRange selectedRange = girisCalendar1.SelectionRange;
            SelectionRange selectedRange2 = cikisCalendar2.SelectionRange;
            string fiy,not;
            if (fiyListBox2.SelectedItem != null)
            {
                fiy = fiyListBox2.SelectedItem.ToString();
            }
            else
            {
                fiy = comboBox1.SelectedItem.ToString();
            }
            if (notBox4.Text == "")
            {                
                not = "";
            }
            else
            {
                not = "\nNotunuz:" + notBox4.Text;
            }
            listBox2.Items.Clear();
            listBox2.Items.Add("Adınız:" + adBox1.Text);
            listBox2.Items.Add("Soyadınız:" + soyadBox2.Text);
            listBox2.Items.Add("E-posta:" + postatBox3.Text);
            listBox2.Items.Add("Telefonunuz:" + telTextBox1.Text);
            listBox2.Items.Add("Rezervasyon Türü: " + rezBox1.SelectedItem.ToString());
            listBox2.Items.Add("Konaklama türü:" + konkListBox1.SelectedItem.ToString());
            listBox2.Items.Add("Fiyat:" + fiy);
            listBox2.Items.Add("Oda Sayısı:" + odaBox2.SelectedItem.ToString());
            listBox2.Items.Add("Kişi Sayısı:" + kisBox1.SelectedItem.ToString());
            listBox2.Items.Add("Çocuk Sayısı:" + cocuk2.SelectedItem.ToString());
            listBox2.Items.Add("Ülke:" + ulk3.SelectedItem.ToString());
            listBox2.Items.Add("Giriş Tarihi:" + selectedRange.Start.ToString("dd.MM.yyyy"));
            listBox2.Items.Add("Çıkış Tarihi: " + selectedRange.Start.ToString("dd.MM.yyyy"));
            listBox2.Items.Add(not);


        }

        private void konkListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox checkedListBox = (CheckedListBox)sender;
            SetSingleSelectionForCheckedListBox(checkedListBox, e);
        }

        private void fiyListBox2_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox checkedListBox = (CheckedListBox)sender;
            SetSingleSelectionForCheckedListBox(checkedListBox, e);
        }
        public void SetSingleSelectionForCheckedListBox(CheckedListBox checkedListBox, ItemCheckEventArgs e)
        {
            // Eğer seçilen öğe zaten işaretlenmişse
            if (e.CurrentValue == CheckState.Checked)
            {
                // İşaretlemeyi engelle ve öğeyi seçilmemiş yap
                e.NewValue = CheckState.Unchecked;
            }

            // Diğer tüm seçenekleri kaldırın
            for (int i = 0; i < checkedListBox.Items.Count; ++i)
            {
                if (i != e.Index)
                {
                    checkedListBox.SetItemChecked(i, false);
                }
            }
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            adBox1.Text = string.Empty;
            soyadBox2.Text = string.Empty;
            postatBox3 = null;
            telTextBox1.Text = string.Empty;
            rezBox1.SelectedItem = null;
            konkListBox1.SelectedItem= null;
            fiyListBox2 = null;
            odaBox2.SelectedItem = null;
            kisBox1.SelectedItem = null;
            ulk3.SelectedItems.Clear();
            cocuk2.SelectedItems.Clear();
            notBox4.Text= string.Empty;
            //label1_Click(sender, e);

        }
    }
}
