using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MoneyBackTrack
{
    public partial class Form1 : Form
    {
        int[] CostCoin = new int[7] { 1, 5, 10, 50, 100, 200, 500 };
        List<int> Coins = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }



        private void butUslovie_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Необходимо подсчитать кол-во вариантов " +
                "и вывести их для сдачи суммы от 1к... до 10р монетами достоинством 1к,5к,10к,50к,1р,2р,5р.. \n" +
                "Набор монет задается пользователем.",
               "Условие", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AddCoinsInList()
        {
            Coins.Add(int.Parse(textBox1.Text));
            Coins.Add(int.Parse(textBox2.Text));
            Coins.Add(int.Parse(textBox3.Text));
            Coins.Add(int.Parse(textBox4.Text));
            Coins.Add(int.Parse(textBox5.Text));
            Coins.Add(int.Parse(textBox6.Text));
            Coins.Add(int.Parse(textBox7.Text));
        }

        private void butRun_Click(object sender, EventArgs e)
        {
            int SumCassa()
            {
                int result = 0;
                for (int i = 0; i < 7; i++)
                {
                    result = result + CostCoin[i] * Coins[i];
                }
                return result;
            }
            int SumSdacha()
            {
                int result = 100 * (int.Parse(textdano.Text)) + (int.Parse(textdano2.Text));
                return result;

            }
            int Recursus(int sum, int ind)
            {
                int result;
                int tmp = 0;
                if ((sum < 0) || (ind >= 7))
                {
                    if (sum == 0)
                        tmp = 1;
                }
                else
                {
                    if (Coins[ind] == 0)
                        tmp = Recursus(sum, ind + 1);
                    else
                        for (int i = 0; i <= Coins[ind]; i++)
                        {
                            tmp = tmp + Recursus(sum - CostCoin[ind] * i, ind + 1);
                        }
                }
                return result = tmp;
            }
            SetInterfaceState(false);
            Coins.Clear();
            AddCoinsInList();

            if ((int.TryParse(textdano.Text, out int result1)) && (int.TryParse(textdano2.Text, out int result2)))
            {
                if ((((result1 >= 0) && (result1 <= 9)) && ((result2 >= 0) && (result2 <= 99))) || ((result1 == 10) && (result2 == 0)))
                {
                    if ((SumCassa()) >= (SumSdacha()))
                        textvars.Text = Convert.ToString(Recursus(SumSdacha(), 0));
                    else MessageBox.Show("Сумма монет меньше суммы денег!",
                       "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else MessageBox.Show("Число не соответствует диапазону(формату)! \n" + "Необходимо ввести число от 0 до 10. \n" +
                "Если есть копейки писать их через запятую.",
               "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Это не число! \n" + "Необходимо ввести число от 0 до 10. \n" +
               "Если есть копейки писать их через запятую",
              "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            SetInterfaceState(true);

        }
        private void SetInterfaceState(bool state)
        {
            butRun.Enabled = state;
            butUslovie.Enabled = state;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myPath1 = new System.Drawing.Drawing2D.GraphicsPath();
            myPath1.AddEllipse(0, 0, button1.Width, button1.Height);
            Region myRegion1 = new Region(myPath1);
            button1.Region = myRegion1;

            System.Drawing.Drawing2D.GraphicsPath myPath2 = new System.Drawing.Drawing2D.GraphicsPath();
            myPath2.AddEllipse(0, 0, button2.Width, button2.Height);
            Region myRegion2 = new Region(myPath2);
            button2.Region = myRegion2;

            System.Drawing.Drawing2D.GraphicsPath myPath3 = new System.Drawing.Drawing2D.GraphicsPath();
            myPath3.AddEllipse(0, 0, button3.Width, button3.Height);
            Region myRegion3 = new Region(myPath3);
            button3.Region = myRegion3;

            System.Drawing.Drawing2D.GraphicsPath myPath4 = new System.Drawing.Drawing2D.GraphicsPath();
            myPath4.AddEllipse(0, 0, button4.Width, button4.Height);
            Region myRegion4 = new Region(myPath4);
            button4.Region = myRegion4;

            System.Drawing.Drawing2D.GraphicsPath myPath5 = new System.Drawing.Drawing2D.GraphicsPath();
            myPath5.AddEllipse(0, 0, button5.Width, button5.Height);
            Region myRegion5 = new Region(myPath5);
            button5.Region = myRegion5;

            System.Drawing.Drawing2D.GraphicsPath myPath6 = new System.Drawing.Drawing2D.GraphicsPath();
            myPath6.AddEllipse(0, 0, button6.Width, button6.Height);
            Region myRegion6 = new Region(myPath6);
            button6.Region = myRegion6;

            System.Drawing.Drawing2D.GraphicsPath myPath7 = new System.Drawing.Drawing2D.GraphicsPath();
            myPath7.AddEllipse(0, 0, button7.Width, button7.Height);
            Region myRegion7 = new Region(myPath7);
            button7.Region = myRegion7;
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
        }
        private string but_lkm(string tb)
        {
            tb = Convert.ToString(int.Parse(tb) + 1);
            return tb;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = but_lkm(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = but_lkm(textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = but_lkm(textBox3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.Text = but_lkm(textBox4.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox5.Text = but_lkm(textBox5.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox6.Text = but_lkm(textBox6.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox7.Text = but_lkm(textBox7.Text);
        }

        private void butClear_Click(object sender, EventArgs e)
        {
            textdano.Text = "";
            textdano2.Text = "";
            textvars.Text = "";
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            Coins.Clear();
        }
    }
}
