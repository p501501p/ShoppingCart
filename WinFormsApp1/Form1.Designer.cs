namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Total = new TextBox();
            OneThousand = new TextBox();
            Change = new TextBox();
            Twenty = new TextBox();
            Fifty = new TextBox();
            OneHundred = new TextBox();
            FiveHundred = new TextBox();
            One = new TextBox();
            Five = new TextBox();
            Ten = new TextBox();
            Cof_check = new CheckBox();
            button1 = new Button();
            CoffeePrice = new TextBox();
            HowManyCoffee = new TextBox();
            HowManyTea = new TextBox();
            TeaPrice = new TextBox();
            Tea_check = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            Cash = new TextBox();
            button2 = new Button();
            label12 = new Label();
            label13 = new Label();
            SuspendLayout();
            // 
            // Total
            // 
            Total.BackColor = SystemColors.ButtonHighlight;
            Total.Location = new Point(469, 26);
            Total.Name = "Total";
            Total.Size = new Size(100, 23);
            Total.TabIndex = 7;
            // 
            // OneThousand
            // 
            OneThousand.BackColor = SystemColors.ButtonHighlight;
            OneThousand.Location = new Point(469, 169);
            OneThousand.Name = "OneThousand";
            OneThousand.Size = new Size(100, 23);
            OneThousand.TabIndex = 22;
            // 
            // Change
            // 
            Change.BackColor = SystemColors.ButtonHighlight;
            Change.Location = new Point(469, 140);
            Change.Name = "Change";
            Change.Size = new Size(100, 23);
            Change.TabIndex = 21;
            // 
            // Twenty
            // 
            Twenty.BackColor = SystemColors.ButtonHighlight;
            Twenty.Location = new Point(469, 281);
            Twenty.Name = "Twenty";
            Twenty.Size = new Size(100, 23);
            Twenty.TabIndex = 26;
            // 
            // Fifty
            // 
            Fifty.BackColor = SystemColors.ButtonHighlight;
            Fifty.Location = new Point(469, 252);
            Fifty.Name = "Fifty";
            Fifty.Size = new Size(100, 23);
            Fifty.TabIndex = 25;
            // 
            // OneHundred
            // 
            OneHundred.BackColor = SystemColors.ButtonHighlight;
            OneHundred.Location = new Point(469, 227);
            OneHundred.Name = "OneHundred";
            OneHundred.Size = new Size(100, 23);
            OneHundred.TabIndex = 24;
            // 
            // FiveHundred
            // 
            FiveHundred.BackColor = SystemColors.ButtonHighlight;
            FiveHundred.Location = new Point(469, 198);
            FiveHundred.Name = "FiveHundred";
            FiveHundred.Size = new Size(100, 23);
            FiveHundred.TabIndex = 23;
            // 
            // One
            // 
            One.BackColor = SystemColors.ButtonHighlight;
            One.Location = new Point(469, 364);
            One.Name = "One";
            One.Size = new Size(100, 23);
            One.TabIndex = 29;
            // 
            // Five
            // 
            Five.BackColor = SystemColors.ButtonHighlight;
            Five.Location = new Point(469, 335);
            Five.Name = "Five";
            Five.Size = new Size(100, 23);
            Five.TabIndex = 28;
            // 
            // Ten
            // 
            Ten.BackColor = SystemColors.ButtonHighlight;
            Ten.Location = new Point(469, 310);
            Ten.Name = "Ten";
            Ten.Size = new Size(100, 23);
            Ten.TabIndex = 27;
            // 
            // Cof_check
            // 
            Cof_check.AutoSize = true;
            Cof_check.Location = new Point(34, 26);
            Cof_check.Name = "Cof_check";
            Cof_check.Size = new Size(61, 19);
            Cof_check.TabIndex = 0;
            Cof_check.Text = "Coffee";
            Cof_check.UseVisualStyleBackColor = true;
            Cof_check.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(335, 22);
            button1.Name = "button1";
            button1.Size = new Size(75, 63);
            button1.TabIndex = 1;
            button1.Text = "Check out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CoffeePrice
            // 
            CoffeePrice.Enabled = false;
            CoffeePrice.Location = new Point(123, 24);
            CoffeePrice.Name = "CoffeePrice";
            CoffeePrice.Size = new Size(100, 23);
            CoffeePrice.TabIndex = 2;
            CoffeePrice.TextChanged += CoffeePrice_TextChanged;
            // 
            // HowManyCoffee
            // 
            HowManyCoffee.Enabled = false;
            HowManyCoffee.Location = new Point(229, 24);
            HowManyCoffee.Name = "HowManyCoffee";
            HowManyCoffee.Size = new Size(100, 23);
            HowManyCoffee.TabIndex = 3;
            // 
            // HowManyTea
            // 
            HowManyTea.Enabled = false;
            HowManyTea.Location = new Point(229, 53);
            HowManyTea.Name = "HowManyTea";
            HowManyTea.Size = new Size(100, 23);
            HowManyTea.TabIndex = 6;
            HowManyTea.TextChanged += textBox3_TextChanged;
            // 
            // TeaPrice
            // 
            TeaPrice.Enabled = false;
            TeaPrice.Location = new Point(123, 53);
            TeaPrice.Name = "TeaPrice";
            TeaPrice.Size = new Size(100, 23);
            TeaPrice.TabIndex = 5;
            // 
            // Tea_check
            // 
            Tea_check.AutoSize = true;
            Tea_check.Location = new Point(34, 55);
            Tea_check.Name = "Tea_check";
            Tea_check.Size = new Size(43, 19);
            Tea_check.TabIndex = 4;
            Tea_check.Text = "Tea";
            Tea_check.UseVisualStyleBackColor = true;
            Tea_check.CheckedChanged += Tea_check_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(417, 26);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 8;
            label1.Text = "Total";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(417, 54);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 9;
            label2.Text = "Cash";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(417, 171);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 11;
            label3.Text = "1000";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(417, 143);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 10;
            label4.Text = "Change";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(417, 282);
            label5.Name = "label5";
            label5.Size = new Size(19, 15);
            label5.TabIndex = 15;
            label5.Text = "20";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(417, 254);
            label6.Name = "label6";
            label6.Size = new Size(19, 15);
            label6.TabIndex = 14;
            label6.Text = "50";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(417, 225);
            label7.Name = "label7";
            label7.Size = new Size(25, 15);
            label7.TabIndex = 13;
            label7.Text = "100";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(417, 197);
            label8.Name = "label8";
            label8.Size = new Size(25, 15);
            label8.TabIndex = 12;
            label8.Text = "500";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(417, 367);
            label9.Name = "label9";
            label9.Size = new Size(13, 15);
            label9.TabIndex = 18;
            label9.Text = "1";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(417, 339);
            label10.Name = "label10";
            label10.Size = new Size(13, 15);
            label10.TabIndex = 17;
            label10.Text = "5";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(417, 310);
            label11.Name = "label11";
            label11.Size = new Size(19, 15);
            label11.TabIndex = 16;
            label11.Text = "10";
            // 
            // Cash
            // 
            Cash.Location = new Point(469, 55);
            Cash.Name = "Cash";
            Cash.Size = new Size(100, 23);
            Cash.TabIndex = 20;
            // 
            // button2
            // 
            button2.Location = new Point(575, 22);
            button2.Name = "button2";
            button2.Size = new Size(65, 63);
            button2.TabIndex = 30;
            button2.Text = "Change";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(151, 79);
            label12.Name = "label12";
            label12.Size = new Size(29, 15);
            label12.TabIndex = 31;
            label12.Text = "ราคา";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(256, 79);
            label13.Name = "label13";
            label13.Size = new Size(37, 15);
            label13.TabIndex = 32;
            label13.Text = "จำนวน";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(button2);
            Controls.Add(One);
            Controls.Add(Five);
            Controls.Add(Ten);
            Controls.Add(Twenty);
            Controls.Add(Fifty);
            Controls.Add(OneHundred);
            Controls.Add(FiveHundred);
            Controls.Add(OneThousand);
            Controls.Add(Change);
            Controls.Add(Cash);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Total);
            Controls.Add(HowManyTea);
            Controls.Add(TeaPrice);
            Controls.Add(Tea_check);
            Controls.Add(HowManyCoffee);
            Controls.Add(CoffeePrice);
            Controls.Add(button1);
            Controls.Add(Cof_check);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox Cof_check;
        private Button button1;
        private TextBox CoffeePrice;
        private TextBox HowManyCoffee;
        private TextBox HowManyTea;
        private TextBox TeaPrice;
        private CheckBox Tea_check;
        private TextBox Total;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox Cash;
        private TextBox OneThousand;
        private TextBox Change;
        private TextBox Twenty;
        private TextBox Fifty;
        private TextBox OneHundred;
        private TextBox FiveHundred;
        private TextBox One;
        private TextBox Five;
        private TextBox Ten;
        private Button button2;
        private Label label12;
        private Label label13;
    }
}
