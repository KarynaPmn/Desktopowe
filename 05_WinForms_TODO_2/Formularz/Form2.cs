using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Formularz
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e) {}

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\karin\source\repos\Formularz\Formularz\Dane.txt";

            if (!File.Exists(path))
            {
                MessageBox.Show("Plik z danymi nie istnieje.");
                return;
            }

            string[] lines = File.ReadAllLines(path);

            List<Person> ListPersons = new List<Person>();
            foreach (string line in lines)
            {
                string[] parts = line.Split(' ');

                string name = parts[0];
                string gender = parts[1];
                string description = string.Join(" ", parts.Skip(2));

                ListPersons.Add(new Person { Name = name, Gender = gender, Description = description });
            }

            dataGridViewPeople.DataSource = ListPersons;
        }
    }
}
