namespace PizzaOrderForm
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
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.FullNametextBox1 = new System.Windows.Forms.TextBox();
            this.PersonalInformation = new System.Windows.Forms.GroupBox();
            this.PhoneNummaskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.NeighborhoodcomboBox1 = new System.Windows.Forms.ComboBox();
            this.NeighborhoodLabel = new System.Windows.Forms.Label();
            this.AdresstextBox1 = new System.Windows.Forms.TextBox();
            this.OrderNotetextBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AdressLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PizzacheckedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.ExtraMaterialgroupBox2 = new System.Windows.Forms.GroupBox();
            this.ExtraMaterialcheckedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CartContents = new System.Windows.Forms.ListBox();
            this.Sizelabel4 = new System.Windows.Forms.Label();
            this.sizecheckedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.quantitylabel5 = new System.Windows.Forms.Label();
            this.QuantitylistBox1 = new System.Windows.Forms.ListBox();
            this.DrinkgroupBox2 = new System.Windows.Forms.GroupBox();
            this.drinkcheckedListBox3 = new System.Windows.Forms.CheckedListBox();
            this.Addbutton1 = new System.Windows.Forms.Button();
            this.Resetbutton2 = new System.Windows.Forms.Button();
            this.Orderbutton3 = new System.Windows.Forms.Button();
            this.Removebutton1 = new System.Windows.Forms.Button();
            this.ExtraslistBox1 = new System.Windows.Forms.ListBox();
            this.PricelistBox2 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Totalamountlabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PersonalInformation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ExtraMaterialgroupBox2.SuspendLayout();
            this.DrinkgroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.FullNameLabel.Location = new System.Drawing.Point(26, 50);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(85, 20);
            this.FullNameLabel.TabIndex = 0;
            this.FullNameLabel.Text = "Full Name";
            // 
            // FullNametextBox1
            // 
            this.FullNametextBox1.Location = new System.Drawing.Point(155, 44);
            this.FullNametextBox1.Name = "FullNametextBox1";
            this.FullNametextBox1.Size = new System.Drawing.Size(257, 29);
            this.FullNametextBox1.TabIndex = 1;
            // 
            // PersonalInformation
            // 
            this.PersonalInformation.BackColor = System.Drawing.Color.Transparent;
            this.PersonalInformation.Controls.Add(this.PhoneNummaskedTextBox1);
            this.PersonalInformation.Controls.Add(this.NeighborhoodcomboBox1);
            this.PersonalInformation.Controls.Add(this.NeighborhoodLabel);
            this.PersonalInformation.Controls.Add(this.AdresstextBox1);
            this.PersonalInformation.Controls.Add(this.OrderNotetextBox1);
            this.PersonalInformation.Controls.Add(this.label1);
            this.PersonalInformation.Controls.Add(this.label3);
            this.PersonalInformation.Controls.Add(this.AdressLabel);
            this.PersonalInformation.Controls.Add(this.PhoneLabel);
            this.PersonalInformation.Controls.Add(this.FullNametextBox1);
            this.PersonalInformation.Controls.Add(this.FullNameLabel);
            this.PersonalInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.PersonalInformation.ForeColor = System.Drawing.Color.Azure;
            this.PersonalInformation.Location = new System.Drawing.Point(12, 70);
            this.PersonalInformation.Name = "PersonalInformation";
            this.PersonalInformation.Size = new System.Drawing.Size(1096, 195);
            this.PersonalInformation.TabIndex = 2;
            this.PersonalInformation.TabStop = false;
            this.PersonalInformation.Text = "Personal Information";
            // 
            // PhoneNummaskedTextBox1
            // 
            this.PhoneNummaskedTextBox1.Location = new System.Drawing.Point(155, 138);
            this.PhoneNummaskedTextBox1.Mask = "(999) 000-0000";
            this.PhoneNummaskedTextBox1.Name = "PhoneNummaskedTextBox1";
            this.PhoneNummaskedTextBox1.Size = new System.Drawing.Size(257, 29);
            this.PhoneNummaskedTextBox1.TabIndex = 5;
            // 
            // NeighborhoodcomboBox1
            // 
            this.NeighborhoodcomboBox1.FormattingEnabled = true;
            this.NeighborhoodcomboBox1.Location = new System.Drawing.Point(155, 87);
            this.NeighborhoodcomboBox1.Name = "NeighborhoodcomboBox1";
            this.NeighborhoodcomboBox1.Size = new System.Drawing.Size(257, 32);
            this.NeighborhoodcomboBox1.TabIndex = 4;
            // 
            // NeighborhoodLabel
            // 
            this.NeighborhoodLabel.AutoSize = true;
            this.NeighborhoodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.NeighborhoodLabel.Location = new System.Drawing.Point(26, 95);
            this.NeighborhoodLabel.Name = "NeighborhoodLabel";
            this.NeighborhoodLabel.Size = new System.Drawing.Size(112, 20);
            this.NeighborhoodLabel.TabIndex = 0;
            this.NeighborhoodLabel.Text = "Neighborhood";
            this.NeighborhoodLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // AdresstextBox1
            // 
            this.AdresstextBox1.Location = new System.Drawing.Point(498, 132);
            this.AdresstextBox1.Multiline = true;
            this.AdresstextBox1.Name = "AdresstextBox1";
            this.AdresstextBox1.Size = new System.Drawing.Size(573, 42);
            this.AdresstextBox1.TabIndex = 2;
            // 
            // OrderNotetextBox1
            // 
            this.OrderNotetextBox1.Location = new System.Drawing.Point(498, 28);
            this.OrderNotetextBox1.Multiline = true;
            this.OrderNotetextBox1.Name = "OrderNotetextBox1";
            this.OrderNotetextBox1.Size = new System.Drawing.Size(573, 91);
            this.OrderNotetextBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(428, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adress";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(428, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Note";
            // 
            // AdressLabel
            // 
            this.AdressLabel.AutoSize = true;
            this.AdressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.AdressLabel.Location = new System.Drawing.Point(428, 44);
            this.AdressLabel.Name = "AdressLabel";
            this.AdressLabel.Size = new System.Drawing.Size(52, 20);
            this.AdressLabel.TabIndex = 0;
            this.AdressLabel.Text = "Order";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.PhoneLabel.Location = new System.Drawing.Point(26, 144);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(120, 20);
            this.PhoneLabel.TabIndex = 0;
            this.PhoneLabel.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.label2.Location = new System.Drawing.Point(323, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(494, 63);
            this.label2.TabIndex = 3;
            this.label2.Text = "Boston Pizza Order";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.PizzacheckedListBox2);
            this.groupBox1.ForeColor = System.Drawing.Color.Azure;
            this.groupBox1.Location = new System.Drawing.Point(15, 281);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 171);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pizza";
            // 
            // PizzacheckedListBox2
            // 
            this.PizzacheckedListBox2.BackColor = System.Drawing.Color.Green;
            this.PizzacheckedListBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PizzacheckedListBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.PizzacheckedListBox2.ForeColor = System.Drawing.Color.Azure;
            this.PizzacheckedListBox2.FormattingEnabled = true;
            this.PizzacheckedListBox2.Location = new System.Drawing.Point(9, 21);
            this.PizzacheckedListBox2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.PizzacheckedListBox2.Name = "PizzacheckedListBox2";
            this.PizzacheckedListBox2.Size = new System.Drawing.Size(126, 135);
            this.PizzacheckedListBox2.TabIndex = 9;
            this.PizzacheckedListBox2.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.PizzacheckedListBox2_ItemCheck);
            this.PizzacheckedListBox2.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // ExtraMaterialgroupBox2
            // 
            this.ExtraMaterialgroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.ExtraMaterialgroupBox2.Controls.Add(this.ExtraMaterialcheckedListBox2);
            this.ExtraMaterialgroupBox2.Controls.Add(this.label4);
            this.ExtraMaterialgroupBox2.ForeColor = System.Drawing.Color.Azure;
            this.ExtraMaterialgroupBox2.Location = new System.Drawing.Point(375, 281);
            this.ExtraMaterialgroupBox2.Name = "ExtraMaterialgroupBox2";
            this.ExtraMaterialgroupBox2.Size = new System.Drawing.Size(169, 171);
            this.ExtraMaterialgroupBox2.TabIndex = 5;
            this.ExtraMaterialgroupBox2.TabStop = false;
            this.ExtraMaterialgroupBox2.Text = "Extra Material";
            // 
            // ExtraMaterialcheckedListBox2
            // 
            this.ExtraMaterialcheckedListBox2.BackColor = System.Drawing.Color.Green;
            this.ExtraMaterialcheckedListBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExtraMaterialcheckedListBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ExtraMaterialcheckedListBox2.ForeColor = System.Drawing.Color.Azure;
            this.ExtraMaterialcheckedListBox2.FormattingEnabled = true;
            this.ExtraMaterialcheckedListBox2.Location = new System.Drawing.Point(6, 21);
            this.ExtraMaterialcheckedListBox2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ExtraMaterialcheckedListBox2.Name = "ExtraMaterialcheckedListBox2";
            this.ExtraMaterialcheckedListBox2.Size = new System.Drawing.Size(126, 120);
            this.ExtraMaterialcheckedListBox2.TabIndex = 9;
            this.ExtraMaterialcheckedListBox2.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(6, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "+1 Dollar each choice";
            // 
            // CartContents
            // 
            this.CartContents.FormattingEnabled = true;
            this.CartContents.Location = new System.Drawing.Point(15, 506);
            this.CartContents.Name = "CartContents";
            this.CartContents.ScrollAlwaysVisible = true;
            this.CartContents.Size = new System.Drawing.Size(185, 173);
            this.CartContents.TabIndex = 6;
            // 
            // Sizelabel4
            // 
            this.Sizelabel4.AutoSize = true;
            this.Sizelabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Sizelabel4.Location = new System.Drawing.Point(270, 288);
            this.Sizelabel4.Name = "Sizelabel4";
            this.Sizelabel4.Size = new System.Drawing.Size(42, 20);
            this.Sizelabel4.TabIndex = 7;
            this.Sizelabel4.Text = "Size";
            // 
            // sizecheckedListBox1
            // 
            this.sizecheckedListBox1.BackColor = System.Drawing.Color.Green;
            this.sizecheckedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sizecheckedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.sizecheckedListBox1.ForeColor = System.Drawing.Color.Azure;
            this.sizecheckedListBox1.FormattingEnabled = true;
            this.sizecheckedListBox1.Items.AddRange(new object[] {
            "Large",
            "Medium",
            "Small"});
            this.sizecheckedListBox1.Location = new System.Drawing.Point(232, 313);
            this.sizecheckedListBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.sizecheckedListBox1.Name = "sizecheckedListBox1";
            this.sizecheckedListBox1.Size = new System.Drawing.Size(126, 45);
            this.sizecheckedListBox1.TabIndex = 9;
            this.sizecheckedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.sizecheckedListBox1_ItemCheck);
            // 
            // quantitylabel5
            // 
            this.quantitylabel5.AutoSize = true;
            this.quantitylabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.quantitylabel5.Location = new System.Drawing.Point(260, 369);
            this.quantitylabel5.Name = "quantitylabel5";
            this.quantitylabel5.Size = new System.Drawing.Size(71, 20);
            this.quantitylabel5.TabIndex = 7;
            this.quantitylabel5.Text = "Quantity";
            // 
            // QuantitylistBox1
            // 
            this.QuantitylistBox1.FormattingEnabled = true;
            this.QuantitylistBox1.Location = new System.Drawing.Point(232, 396);
            this.QuantitylistBox1.Name = "QuantitylistBox1";
            this.QuantitylistBox1.Size = new System.Drawing.Size(120, 56);
            this.QuantitylistBox1.TabIndex = 10;
            // 
            // DrinkgroupBox2
            // 
            this.DrinkgroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.DrinkgroupBox2.Controls.Add(this.drinkcheckedListBox3);
            this.DrinkgroupBox2.ForeColor = System.Drawing.Color.Azure;
            this.DrinkgroupBox2.Location = new System.Drawing.Point(581, 281);
            this.DrinkgroupBox2.Name = "DrinkgroupBox2";
            this.DrinkgroupBox2.Size = new System.Drawing.Size(185, 171);
            this.DrinkgroupBox2.TabIndex = 4;
            this.DrinkgroupBox2.TabStop = false;
            this.DrinkgroupBox2.Text = "Drinks";
            // 
            // drinkcheckedListBox3
            // 
            this.drinkcheckedListBox3.BackColor = System.Drawing.Color.Green;
            this.drinkcheckedListBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.drinkcheckedListBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.drinkcheckedListBox3.ForeColor = System.Drawing.Color.Azure;
            this.drinkcheckedListBox3.FormattingEnabled = true;
            this.drinkcheckedListBox3.Location = new System.Drawing.Point(6, 21);
            this.drinkcheckedListBox3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.drinkcheckedListBox3.Name = "drinkcheckedListBox3";
            this.drinkcheckedListBox3.Size = new System.Drawing.Size(126, 120);
            this.drinkcheckedListBox3.TabIndex = 9;
            this.drinkcheckedListBox3.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.drinkcheckedListBox3_ItemCheck);
            this.drinkcheckedListBox3.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // Addbutton1
            // 
            this.Addbutton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Addbutton1.Location = new System.Drawing.Point(786, 411);
            this.Addbutton1.Name = "Addbutton1";
            this.Addbutton1.Size = new System.Drawing.Size(144, 41);
            this.Addbutton1.TabIndex = 11;
            this.Addbutton1.Text = "Add to Cart";
            this.Addbutton1.UseVisualStyleBackColor = true;
            this.Addbutton1.Click += new System.EventHandler(this.Addbutton1_Click);
            // 
            // Resetbutton2
            // 
            this.Resetbutton2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Resetbutton2.Location = new System.Drawing.Point(658, 617);
            this.Resetbutton2.Name = "Resetbutton2";
            this.Resetbutton2.Size = new System.Drawing.Size(117, 32);
            this.Resetbutton2.TabIndex = 11;
            this.Resetbutton2.Text = "Reset Cart";
            this.Resetbutton2.UseVisualStyleBackColor = true;
            this.Resetbutton2.Click += new System.EventHandler(this.Resetbutton2_Click);
            // 
            // Orderbutton3
            // 
            this.Orderbutton3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Orderbutton3.Location = new System.Drawing.Point(921, 685);
            this.Orderbutton3.Name = "Orderbutton3";
            this.Orderbutton3.Size = new System.Drawing.Size(187, 45);
            this.Orderbutton3.TabIndex = 11;
            this.Orderbutton3.Text = "Order";
            this.Orderbutton3.UseVisualStyleBackColor = true;
            this.Orderbutton3.Click += new System.EventHandler(this.Orderbutton3_Click);
            // 
            // Removebutton1
            // 
            this.Removebutton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Removebutton1.Location = new System.Drawing.Point(658, 553);
            this.Removebutton1.Name = "Removebutton1";
            this.Removebutton1.Size = new System.Drawing.Size(117, 32);
            this.Removebutton1.TabIndex = 11;
            this.Removebutton1.Text = "Remove Cart";
            this.Removebutton1.UseVisualStyleBackColor = true;
            this.Removebutton1.Click += new System.EventHandler(this.Removebutton1_Click);
            // 
            // ExtraslistBox1
            // 
            this.ExtraslistBox1.FormattingEnabled = true;
            this.ExtraslistBox1.HorizontalScrollbar = true;
            this.ExtraslistBox1.Location = new System.Drawing.Point(232, 506);
            this.ExtraslistBox1.Name = "ExtraslistBox1";
            this.ExtraslistBox1.ScrollAlwaysVisible = true;
            this.ExtraslistBox1.Size = new System.Drawing.Size(185, 173);
            this.ExtraslistBox1.TabIndex = 6;
            // 
            // PricelistBox2
            // 
            this.PricelistBox2.FormattingEnabled = true;
            this.PricelistBox2.Location = new System.Drawing.Point(444, 506);
            this.PricelistBox2.Name = "PricelistBox2";
            this.PricelistBox2.ScrollAlwaysVisible = true;
            this.PricelistBox2.Size = new System.Drawing.Size(185, 173);
            this.PricelistBox2.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.label5.Location = new System.Drawing.Point(19, 701);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "Total amount:";
            // 
            // Totalamountlabel
            // 
            this.Totalamountlabel.AutoSize = true;
            this.Totalamountlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.Totalamountlabel.Location = new System.Drawing.Point(178, 704);
            this.Totalamountlabel.Name = "Totalamountlabel";
            this.Totalamountlabel.Size = new System.Drawing.Size(0, 25);
            this.Totalamountlabel.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.Location = new System.Drawing.Point(81, 483);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Cart";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label7.Location = new System.Drawing.Point(298, 483);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Extras";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label8.Location = new System.Drawing.Point(506, 483);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Price";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1120, 742);
            this.Controls.Add(this.Totalamountlabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Orderbutton3);
            this.Controls.Add(this.Removebutton1);
            this.Controls.Add(this.Resetbutton2);
            this.Controls.Add(this.Addbutton1);
            this.Controls.Add(this.QuantitylistBox1);
            this.Controls.Add(this.quantitylabel5);
            this.Controls.Add(this.sizecheckedListBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Sizelabel4);
            this.Controls.Add(this.PricelistBox2);
            this.Controls.Add(this.ExtraslistBox1);
            this.Controls.Add(this.CartContents);
            this.Controls.Add(this.ExtraMaterialgroupBox2);
            this.Controls.Add(this.DrinkgroupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PersonalInformation);
            this.ForeColor = System.Drawing.Color.Azure;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PersonalInformation.ResumeLayout(false);
            this.PersonalInformation.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ExtraMaterialgroupBox2.ResumeLayout(false);
            this.ExtraMaterialgroupBox2.PerformLayout();
            this.DrinkgroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.TextBox FullNametextBox1;
        private System.Windows.Forms.GroupBox PersonalInformation;
        private System.Windows.Forms.Label NeighborhoodLabel;
        private System.Windows.Forms.ComboBox NeighborhoodcomboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OrderNotetextBox1;
        private System.Windows.Forms.Label AdressLabel;
        private System.Windows.Forms.MaskedTextBox PhoneNummaskedTextBox1;
        private System.Windows.Forms.TextBox AdresstextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox ExtraMaterialgroupBox2;
        private System.Windows.Forms.ListBox CartContents;
        private System.Windows.Forms.Label Sizelabel4;
        private System.Windows.Forms.CheckedListBox sizecheckedListBox1;
        private System.Windows.Forms.Label quantitylabel5;
        private System.Windows.Forms.ListBox QuantitylistBox1;
        private System.Windows.Forms.CheckedListBox ExtraMaterialcheckedListBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox PizzacheckedListBox2;
        private System.Windows.Forms.GroupBox DrinkgroupBox2;
        private System.Windows.Forms.CheckedListBox drinkcheckedListBox3;
        private System.Windows.Forms.Button Addbutton1;
        private System.Windows.Forms.Button Resetbutton2;
        private System.Windows.Forms.Button Orderbutton3;
        private System.Windows.Forms.Button Removebutton1;
        private System.Windows.Forms.ListBox ExtraslistBox1;
        private System.Windows.Forms.ListBox PricelistBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Totalamountlabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

