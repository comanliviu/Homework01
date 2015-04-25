using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Humanizer;

namespace Homework01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        { if (char.IsNumber(e.KeyChar))
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
                MessageBox.Show("This is not a number!");
            }
       

        }
        System.Globalization.CultureInfo French = new System.Globalization.CultureInfo("fr");
        System.Globalization.CultureInfo English = new System.Globalization.CultureInfo("en");

        System.Globalization.CultureInfo Deutch = new System.Globalization.CultureInfo("de");
        System.Globalization.CultureInfo Italian = new System.Globalization.CultureInfo("it");
        System.Globalization.CultureInfo Spanish = new System.Globalization.CultureInfo("es");

        private void button1_Click(object sender, EventArgs e)
        

         {
            System.Globalization.CultureInfo cult;
            int nr = 0;
            Int32.TryParse(textBox1.Text, out nr);
            switch (comboBox1.Text)
            {
                case "English": cult = English; break;
                case "French": cult = French; break;
                case "Deutch": cult = Deutch; break;
                case "Spanish": cult = Spanish ; break;
                case "Italian": cult = Italian ; break;
                default: cult = English; break;
            }
            string rez = nr.ToWords(cult);
            MessageBox.Show(rez);
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TabIndexChanged(object sender, EventArgs e)
        {

        }
       
    }
}
