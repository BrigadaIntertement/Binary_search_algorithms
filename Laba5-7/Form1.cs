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
            
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
