using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Waluta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] Nominaly = {100, 50, 20, 10, 5, 2, 1 };

        Dictionary<int, string> ObrazekNominalu = new Dictionary<int, string>
        {
            { 1, "one.jpg" },
            { 2, "two.jpg" },
            { 5, "five.jpg" },
            { 10, "ten.jpg" },
            { 20, "twenty.jpg" },
            { 50, "fifty.jpg" },
            { 100, "hundred.jpg" },
        };

        List<int> RozdzielenieNaNominaly(int kwota)
        {
            List<int> NominalyDlaKwoty = new List<int>();

            foreach (int nominal in Nominaly)
            {
                while (kwota >= nominal)
                {
                    kwota -= nominal;
                    NominalyDlaKwoty.Add(nominal);
                }
            }

            return NominalyDlaKwoty;
        }

        void WyswietlenieNominalowDlaKwoty(int nomianal)
        {
            if (ObrazekNominalu.TryGetValue(nomianal, out string obrazek))
            {
                string obrazekPath = Path.Combine(@"C:\Users\karin\source\repos\Waluta\Waluta\Waluty\", obrazek);

                PictureBox pictureBox = new PictureBox
                {
                    Image = Image.FromFile(obrazekPath),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Width = 100,
                    Height = 50
                };

                flowLayoutPanel.Controls.Add(pictureBox);
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();

            if (int.TryParse(textBox.Text, out int kwota) && kwota > 0)
            {
                List<int> NominalyDlaKwoty = RozdzielenieNaNominaly(kwota);

                foreach (int nominal in NominalyDlaKwoty)
                    WyswietlenieNominalowDlaKwoty(nominal);
            }
            else
                MessageBox.Show("Podaj poprawną kwotę.");
        }
    }
}
