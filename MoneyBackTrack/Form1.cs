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

        private void butRun_Click(object sender, EventArgs e)
        {
            SetInterfaceState(false);
            if (Double.TryParse(textdano.Text, out double result))
            {
                string[] temp = textdano.Text.Split('.', ',');
                if (((result>=0)&&(result <= 10)) && ((temp[0].Length<3)&&(temp[1].Length<3)))
                {
                    //////
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
    }
}
