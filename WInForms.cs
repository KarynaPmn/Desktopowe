using System.Text.RegularExpressions;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^\d{13,15}$");
            long s = long.Parse(textBox1.Text);

            if (regex.IsMatch(textBox1.Text))
            {
                if (czyPodzielna(s))
                    label1.Text = "Liczba jest podzielna przez 3 i 11";
                else
                    label1.Text = "Liczba nie jest podzielna przez 3 i 11";
            }
            else
                label1.Text = "Nieprawidłowe dane";
            
        }

        private static bool czyPodzielna(long liczba)
        {
            long wynik = 0;
            int i = 1;
            long cyfra;
            while (liczba > 0)
            {
                cyfra = liczba % 10;
                liczba /= 10;
                if (i % 2 == 0)
                    wynik += cyfra;
                else
                    wynik -= cyfra;
            }

            if (wynik / 3 == 0 && wynik / 11 == 0)
                return true;
            return false;
        }
    }
}
