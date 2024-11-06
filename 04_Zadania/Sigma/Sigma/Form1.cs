using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sigma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCzySigma_Click(object sender, EventArgs e)
        {
            DateTime data = DateTime.Parse(textBoxDateOfBirth.Text);
            int[] liczby = new int[] { data.Day, data.Month, data.Year };
            int sumaCyfr = 0;
            for (int i = 0; i < 3; i++)
            {
                sumaCyfr += SumaCyfr(liczby[i]);
            }

            if (sumaCyfr > 10 && sumaCyfr % 10 == sumaCyfr / 10)
            {
                label1.ForeColor = Color.Blue;
                label1.Text = $"{sumaCyfr} -- To jest sigma";
            }
            else
            {
                label1.ForeColor = Color.Red;
                label1.Text = $"{sumaCyfr} -- Nie jest to sigma";
            }
        }

        int SumaCyfr(int a)
        {
            int suma = 0;
            while (a > 0)
            {
                suma += a % 10;
                a = a / 10;
            }
            return suma;
        }
    }
}
