using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrderForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private string[] mixpizzacheck;
        private string[] Vegetablepizcheck;
        private string[] Seafoodpizcheck;
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] BostonNeigh = new string[]
            {
                "Allston",
                "Back Bay",
                "Bay Village",
                "Beacon Hill",
                "Brighton",
                "Charlestown",
                "Chinatown",
                "Dorchester",
                "Downtown",
                "East Boston",
                "Fenway-Kenmore",
                "Hyde Park",
                "Jamaica Plain",
                "Leather District",
                "Mattapan",
                "Mid Dorchester",
                "Mission Hill",
                "North End",
                "Roslindale",
                "Roxbury",
                "South Boston",
                "South Boston Waterfront",
                "South End",
                "West End",
                "West Roxbury"
            };
            
            
            string[] pizzaExtraMaterial = new string[]
            {
                "Spinach", // Ispanak
                "Artichoke", // Enginar
                "Jalapeno", // Jalapeno biberi
                "Sun-dried tomatoes", // Güneşte kurutulmuş domates
                "Feta cheese", // Feta peyniri
                "Mushrooms", // Mantar
                "Prosciutto" // Prosciutto jambonu
            };

            Vegetablepizcheck = new string[]
            {
                "Vegetable Medley", // Sebze Karışımı
                "Mediterranean Veggie", // Akdeniz Sebzeli
                "Roasted Vegetable" // Fırınlanmış Sebzeli
            };

            mixpizzacheck = new string[]
            {
            "Supreme", // Supreme
            "Meat Lover's", // Et Sevenler
            "Four Cheese" // Dört Peynirli
            };

            Seafoodpizcheck = new string[]
            {
            "Seafood Delight", // Deniz Mahsulleri Şöleni
            "Shrimp Scampi", // Karides Scampi
            "Tuna & Olive" // Ton Balığı ve Zeytin
            };

            string[] icecekMarkalari = new string[]
            {
                "Coca-Cola",
                "Pepsi",
                "Sprite",
                "Mountain Dew",
                "Dr Pepper",
                "Fanta",
                "Red Bull"
            };
            
            foreach (var item in icecekMarkalari)
            {
                drinkcheckedListBox3.Items.Add(item);
            }
            foreach (var item in Vegetablepizcheck)
            {
                PizzacheckedListBox2.Items.Add(item);
            }
            foreach (var item in mixpizzacheck)
            {
                PizzacheckedListBox2.Items.Add(item);
            }
            foreach (var item in Seafoodpizcheck)
            {
                PizzacheckedListBox2.Items.Add(item);
            }
            foreach (var city in BostonNeigh)
            {
                NeighborhoodcomboBox1.Items.Add(city);
            }//Neighborhood
            foreach (var item in pizzaExtraMaterial)
            {
                ExtraMaterialcheckedListBox2.Items.Add(item.ToString());
            }//Extra Material

            for (int i = 1; i <= 10; i++)
            {
                QuantitylistBox1.Items.Add(i);
            }//Quantity
            QuantitylistBox1.SelectedIndex = 0;
            NeighborhoodcomboBox1.SelectedIndex = 0;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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
        double price = 0;
        double totalprice = 0;
        private void Addbutton1_Click(object sender, EventArgs e)
        {
            int seciliSira = QuantitylistBox1.SelectedIndex;
            string ordercontent, extras="";
            if (PizzacheckedListBox2.SelectedItem == null && drinkcheckedListBox3.SelectedItem == null)
            {
                MessageBox.Show("Please select a drink or pizza");
            }
            if (ExtraMaterialcheckedListBox2.SelectedIndex != -1)
            {
                for (int i = 0; i < ExtraMaterialcheckedListBox2.Items.Count; i++)
                {
                    if (ExtraMaterialcheckedListBox2.GetItemChecked(i))
                    {
                        string seciliItem = ExtraMaterialcheckedListBox2.Items[i].ToString();
                        // Seçili öğeyi metne ekler
                        extras += seciliItem + ", ";
                        price += 1;

                    }
                }

                // Metindeki son virgül ve boşluk karakterini kaldırır
                if (!string.IsNullOrEmpty(extras))
                {
                    extras = extras.TrimEnd(',', ' ');
                }
                
            }
            else if (ExtraMaterialcheckedListBox2.SelectedIndex == -1)
            {
                ExtraslistBox1.Items.Add(" ");
            }
            for (int o = -1; o < seciliSira; o++)
            {
            if (drinkcheckedListBox3.SelectedItem != null)
            {
                ordercontent = drinkcheckedListBox3.SelectedItem.ToString();
                CartContents.Items.Add(ordercontent);
                price += 2.99;
                totalprice += 2.99;
                PricelistBox2.Items.Add(2.99.ToString());
                ExtraslistBox1.Items.Add("");
            }
            else if (sizecheckedListBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a size");
            }
            else
            {

                string selectedpizza = PizzacheckedListBox2.SelectedItems[0].ToString();
                bool mixcheck = mixpizzacheck.Contains(selectedpizza);
                bool vegcheck = Vegetablepizcheck.Contains(selectedpizza);
                bool seacheck = Seafoodpizcheck.Contains(selectedpizza);
                ordercontent = PizzacheckedListBox2.SelectedItems[0].ToString();
                ExtraslistBox1.Items.Add(extras);


                    if (sizecheckedListBox1.SelectedItem == "Large")
                    {
                    
                    if (mixcheck == true)
                    {
                        double pricelist = 9.99 + 7.99 + price;
                        totalprice += pricelist;
                        PricelistBox2.Items.Add(pricelist.ToString());
                        
                    }
                    else if (vegcheck == true)
                    {
                        double pricelist = 9.99 + 5.99 + price;
                        totalprice += pricelist;
                        PricelistBox2.Items.Add(pricelist.ToString());
                        
                    }
                    else
                    {
                        double pricelist = 9.99 + 12.99 + price ;
                        totalprice += pricelist;
                        PricelistBox2.Items.Add(pricelist.ToString());
                        
                    }
                    CartContents.Items.Add(ordercontent + " (Large)");
                }
                else if (sizecheckedListBox1.SelectedItem == "Medium")
                {
                    if (mixcheck == true)
                    {
                        double pricelist = 5.99 + 7.99 + price;
                        totalprice += pricelist;
                        PricelistBox2.Items.Add(pricelist.ToString());
                        
                    }
                    else if (vegcheck == true)
                    {
                        double pricelist = 5.99 + 5.99 + price;
                        totalprice += pricelist;
                        PricelistBox2.Items.Add(pricelist.ToString());
                        
                    }
                    else
                    {
                        double pricelist = 5.99 + 12.99 + price;
                        totalprice += pricelist;
                        PricelistBox2.Items.Add(pricelist.ToString());
                        
                    }
                    CartContents.Items.Add(ordercontent + " (Medium)");
                }
                else
                {
                    if (mixcheck == true)
                    {
                        double pricelist = 2.99 + 7.99 + price;
                        totalprice += pricelist;
                        PricelistBox2.Items.Add(pricelist.ToString());
                        
                    }
                    else if (vegcheck == true)
                    {
                        double pricelist = 2.99 + 5.99 + price;
                        totalprice += pricelist;
                        PricelistBox2.Items.Add(pricelist.ToString());
                        
                    }
                    else
                    {
                        double pricelist = 2.99 + 12.99 + price;
                        totalprice += pricelist;
                        PricelistBox2.Items.Add(pricelist.ToString());
                        
                    }
                    CartContents.Items.Add(ordercontent + " (Small)");
                }
                
                
                
            }
            }
            Totalamountlabel.Text = totalprice.ToString() + "$";
            resetcheck();
        }

        private void PizzacheckedListBox2_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox checkedListBox = (CheckedListBox)sender;
            SetSingleSelectionForCheckedListBox(checkedListBox, e);
            drinkcheckedListBox3.ClearSelected();
            for (int i = 0; i < drinkcheckedListBox3.Items.Count; i++)
            {
                drinkcheckedListBox3.SetItemCheckState(i, CheckState.Unchecked);
            }

        }
        public void resetcheck()
        {
            for (int i = 0; i < drinkcheckedListBox3.Items.Count; i++)
            {
                drinkcheckedListBox3.SetItemCheckState(i, CheckState.Unchecked);
            }
            for (int i = 0; i < PizzacheckedListBox2.Items.Count; i++)
            {
                PizzacheckedListBox2.SetItemCheckState(i, CheckState.Unchecked);
            }
            for (int i = 0; i < sizecheckedListBox1.Items.Count; i++)
            {
                sizecheckedListBox1.SetItemCheckState(i, CheckState.Unchecked);
            }
            for (int i = 0; i < ExtraMaterialcheckedListBox2.Items.Count; i++)
            {
                ExtraMaterialcheckedListBox2.SetItemCheckState(i, CheckState.Unchecked);
            }

        }
        private void drinkcheckedListBox3_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox checkedListBox = (CheckedListBox)sender;
            SetSingleSelectionForCheckedListBox(checkedListBox, e);
            PizzacheckedListBox2.ClearSelected();
            ExtraMaterialcheckedListBox2.ClearSelected();
            for (int i = 0; i < PizzacheckedListBox2.Items.Count; i++)
            {
                PizzacheckedListBox2.SetItemCheckState(i, CheckState.Unchecked);
            }
            for (int i = 0; i < sizecheckedListBox1.Items.Count; i++)
            {
                sizecheckedListBox1.SetItemCheckState(i, CheckState.Unchecked);
            }
            for (int i = 0; i < ExtraMaterialcheckedListBox2.Items.Count; i++)
            {
                ExtraMaterialcheckedListBox2.SetItemCheckState(i, CheckState.Unchecked);
            }
        }
        private void sizecheckedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            PizzacheckedListBox2_ItemCheck(sender, e);
        }

        private void Resetbutton2_Click(object sender, EventArgs e)
        {
            CartContents.Items.Clear();
            ExtraslistBox1.Items.Clear();
            PricelistBox2.Items.Clear();
            price = 0;
            totalprice = 0;
            Totalamountlabel.Text = string.Empty;
        }

        private void Removebutton1_Click(object sender, EventArgs e)
        {
            if (CartContents.SelectedIndex == -1)
            {
                MessageBox.Show("Choose a product");
            }
            else
            {
                if (PricelistBox2.Items != null)
                {
                    int seciliSira = CartContents.SelectedIndex;
                    string seciliItem = PricelistBox2.Items[seciliSira].ToString();
                    double intDeger = double.Parse(seciliItem);
                    if (seciliSira >= 0 && seciliSira < ExtraslistBox1.Items.Count)
                    {
                        string seciliItem2 = ExtraslistBox1.Items[seciliSira].ToString();
                        ExtraslistBox1.Items.RemoveAt(seciliSira);

                    }
                    CartContents.Items.Remove(CartContents.SelectedItem);
                    PricelistBox2.Items.RemoveAt(seciliSira);
                    totalprice = totalprice - intDeger;
                    Totalamountlabel.Text = totalprice.ToString() + "$";
                }
                else
                {
                    Totalamountlabel.Text += string.Empty;
                    totalprice = 0;
                }
            }
        }

        private void Orderbutton3_Click(object sender, EventArgs e)
        {
            if (FullNametextBox1.Text != "" && AdresstextBox1.Text != "" && PhoneNummaskedTextBox1.Text != "")
            {
                string infos = "Full name:" + FullNametextBox1.Text + "\nNeighborhood:" + NeighborhoodcomboBox1.SelectedItem.ToString() + "\nPhone Number:" + PhoneNummaskedTextBox1.Text + "\nAdress:" + AdresstextBox1.Text + "\nOrder Note:" + OrderNotetextBox1.Text;
                string listBoxItems = "";
                foreach (var item in CartContents.Items)
                {
                    listBoxItems += item.ToString() + "\n";
                }

                MessageBox.Show("Personal Information:\n" + infos +"\n\nOrder Contens\n" +listBoxItems+ "\nTotal Amount:"+totalprice.ToString()+"$");
            }
            else
            {
                MessageBox.Show("Please enter your personal information.");
            }
            
        }
    }
}
