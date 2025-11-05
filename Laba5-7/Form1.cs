using System;
using System.Windows.Forms;

namespace Laba5_7
{
    public partial class Form1 : Form
    {
        private int[] mas;
        private int n = 100000000;
        private int CountOfFind = 1500000;
        private int CountOfFind2 = 100;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            mas = new int[n];

            mas[0] = 1;
            for (int i = 1; i < n; i++)
            {
                mas[i] = mas[i - 1] + rnd.Next(1, 5);
            }

            Key.Maximum = mas[n - 1];
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            int index = -1;
            int key = (int)Key.Value;

            //Неоптимальный бинарный поиск
            int StartTime = Environment.TickCount;
            for (int j = 0; j < CountOfFind; j++)
            {
                int l = 0;
                int r = n - 1;

                while (r >= l)
                {
                    int i = (r + l) / 2;
                    if (key == mas[i])
                    {
                        index = i;
                        break;
                    }
                    if (key < mas[i])
                    {
                        r = i - 1;
                    }
                    else
                    {
                        l = i + 1;
                    }
                }
            }
            int ResultTime = Environment.TickCount - StartTime;

            Time01.Text = ResultTime.ToString();
            Index01.Text = (index >= 0) ? index.ToString() : "поиск неудачен";

            //Оптимальный бинарный поиск
            index = -1;

            int StartTime1 = Environment.TickCount;
            for (int j = 0; j < CountOfFind; j++)
            {
                int l = 0;
                int r = n - 1;

                while (r > l)
                {
                    int i = (r + l) / 2;
                    if (key <= mas[i])
                    {
                        r = i;
                    }
                    else
                    {
                        l = i + 1;
                    }
                }
                index = (mas[r] == key) ? r : -1;
            }
            int ResultTime1 = Environment.TickCount - StartTime1;

            Time02.Text = ResultTime1.ToString();
            Index02.Text = (index >= 0) ? index.ToString() : "поиск неудачен";
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
