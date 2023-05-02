using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11._04hw
{
    public partial class Petrol : Form
    {
        public Form1 mainform;
        public Petrol()
        {
            InitializeComponent();
        }
        public string[] Items
        {
            set{comboBox1.Items.AddRange(value);} 
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBox1.SelectedItem.ToString();     
            if (selectedValue == mainform.a92)
            {
                textBox1.Text = mainform.a92_p;
            }             
            if (selectedValue == mainform.a95)
            {
                textBox1.Text = mainform.a95_p;
            }                
            if (selectedValue == mainform.a98)
            {
                textBox1.Text = mainform.a98_p;
            }               
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox2.ReadOnly = false;
                textBox3.ReadOnly = true;
            }
            else if (radioButton2.Checked)
            {
                textBox3.ReadOnly = false;
                textBox2.ReadOnly = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double priceOil;
            double countOil;
            bool isPriceValid = double.TryParse(textBox1.Text, out priceOil);
            bool isCountValid = double.TryParse(textBox2.Text, out countOil);
            if (isPriceValid && isCountValid)
            {
                double price = priceOil * countOil;
                label1.Text = price.ToString();
                double num1, result;
                num1 = double.TryParse(label1.Text, out num1) ? num1 : 0;
                result = num1;
                textBox3.Text = price.ToString();
            }
            else
            {
                label1.Text = "Ошибка";
            }               
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            double priceOil;
            double countOil;
            bool isPriceValid = double.TryParse(textBox3.Text, out priceOil);
            bool isCountValid = double.TryParse(textBox1.Text, out countOil);
            label1.Text = priceOil.ToString();
            double num1, result;
            num1 = double.TryParse(label1.Text, out num1) ? num1 : 0;
            result = num1;
            if (isPriceValid && isCountValid)
            {
                double price = priceOil / countOil;
                textBox2.Text = price.ToString();
            }
            else
            {
                label1.Text = "Ошибка";
            }              
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
