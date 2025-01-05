using System.Drawing;
using System.Security.Policy;
using static System.Net.WebRequestMethods;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (Cof_check.Checked == false)
            {
                CoffeePrice.Enabled = false;
                HowManyCoffee.Enabled = false;
            }
            if (Cof_check.Checked == true)
            {
                CoffeePrice.Enabled = true;
                HowManyCoffee.Enabled = true;
            }

        }

        private void CoffeePrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            string inCofprice = CoffeePrice.Text;
            string inamount = HowManyCoffee.Text;
            string inTeaprice = TeaPrice.Text;
            string inTeaAmount = HowManyTea.Text;

            int Cofprice = 0;
            int amount = 0;
            int teaAmount = 0;
            int teaprice = 0;

            try
            {
                if (Cof_check.Checked)
                    Cofprice = int.Parse(inCofprice);
                amount = int.Parse(inamount);

            }
            catch (FormatException) { }
            try
            {
                if (Tea_check.Checked)
                    teaprice = int.Parse(inTeaprice);
                teaAmount = int.Parse(inTeaAmount);
            }
            catch (FormatException)
            {

            }
            double sum1 = Cofprice * amount;
            double sum2 = teaprice * teaAmount;
            double sum = sum1 + sum2;
            Total.Text = sum.ToString();
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int total = 0;
            int cash = 0;
            try
            {
             
                 cash =int.Parse( Cash.Text);

            }
            catch (FormatException) { }
            
            try
            {
                total = int.Parse(Total.Text);
            }
            catch (FormatException) { }
            int change = cash - total;
            Change.Text = change.ToString();

            int OneT = 0;
            int FiveH = 0;
            int oneH = 0;
            int fifty = 0;
            int twenty = 0;
            int ten = 0;
            int five = 0;
            int one = 0;
            while (change > 0)
            {
                if (change >= 1000)
                {
                    change -= 1000;
                    OneT++;
                }
                else if (change >= 500)
                {
                    change -= 500;
                    FiveH++;
                }
                else if (change >= 100)
                {
                    change -= 100;
                    oneH++;
                }
                else if (change >= 50)
                {
                    change -= 50;
                    fifty++;
                }
                else if (change >= 20)
                {
                    change -= 20;
                    twenty++;
                }
                else if (change >= 10)
                {
                    change -= 10;
                    ten++;
                }
                else if (change >= 5)
                {
                    change -= 5;
                    five++;
                }
                else if (change >= 1)
                {
                    change -= 1;
                    one++;
                }
            }
            OneThousand.Text = OneT.ToString();
            FiveHundred.Text = FiveH.ToString();
            OneHundred.Text = oneH.ToString();
            Fifty.Text = fifty.ToString();
            Twenty.Text = twenty.ToString();
            Ten.Text = ten.ToString();
            Five.Text = five.ToString();
            One.Text = one.ToString();

        }

        private void Tea_check_CheckedChanged(object sender, EventArgs e)
        {
            if (Tea_check.Checked == true)
            {
                TeaPrice.Enabled = true;
                HowManyTea.Enabled = true;
            }
            if (Tea_check.Checked == false)
            {
                TeaPrice.Enabled = false;
                HowManyTea.Enabled= false;
            }
        }
    }
}
