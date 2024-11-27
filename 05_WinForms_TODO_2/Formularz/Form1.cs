using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Formularz
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || (radioButtonFemale.Checked == false && radioButtonMale.Checked == false) || richTextBoxDescribe.Text == "")
            {
                MessageBox.Show("Nie uzupełniono wszystkich kolumn!");
                return;
            }

            string name = textBoxName.Text;
            string gender = radioButtonFemale.Checked ? "K" : "M";
            string description = richTextBoxDescribe.Text;

            Person p = new Person();
            List<Person> listPerson = p.People;

            listPerson.Add(new Person(name, gender, description));

            string path = @"C:\Users\karin\source\repos\Formularz\Formularz\Dane.txt";
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                foreach (var person in listPerson)
                {
                    sw.WriteLine($"{person.Name} {person.Gender} {person.Description}");
                }
            }

            textBoxName.Text = "";
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
            richTextBoxDescribe.Text = "";

            MessageBox.Show("Zapisano dane!");
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
