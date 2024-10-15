using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_lekcja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCzyZaprzyjaznione_Click(object sender, EventArgs e)
        {
            int number_1 = int.Parse(textBoxNumber_1.Text);
            int number_2 = int.Parse(textBoxNumber_2.Text);

            labelResult.Text = CzyZaprzyjaznione(number_1, number_2);
        }

        public string CzyZaprzyjaznione(int a, int b)
        {
            int sumaA = sumaDzielnikow(a);
            int sumaB = sumaDzielnikow(b);
            
            if (sumaA == b && sumaB == a)
                return $"Tak";
            else
                return $"Nie";
        }

        public int sumaDzielnikow(int n)
        {
            int suma = 0;

            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                    suma += i;
            }

            return suma;
        }
    }
}
