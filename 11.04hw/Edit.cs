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
    public partial class Edit : Form
    {
        public Form1 mainform;
        public Edit()
        {
            InitializeComponent();
        }
        public void Start()
        {
            
            textBox3.Text = mainform.a92_p;
            textBox1.Text = mainform.a95_p;
            textBox4.Text = mainform.a98_p;
            textBox5.Text = mainform.hotdog;
            textBox6.Text = mainform.hamburger;
            textBox7.Text = mainform.potato;
            textBox8.Text = mainform.cocacola;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            
            mainform.a92_p = textBox3.Text;
            mainform.a98_p = textBox4.Text;
            mainform.a95_p = textBox1.Text;
            mainform.hotdog = textBox5.Text; ;
            mainform.hamburger = textBox6.Text; ;
            mainform.potato = textBox7.Text; ;
            mainform.cocacola = textBox8.Text; ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
