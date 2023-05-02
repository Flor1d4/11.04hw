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
    public partial class Form1 : Form
    {
        Petrol petrol;
        Cafe cafe;
        Edit edit;
        public string a92;
        public string a92_p;
        public string a95;
        public string a95_p;
        public string a98;
        public string a98_p;
        public string hotdog;
        public string hamburger;
        public string cocacola;
        public string potato;
        public Form1()
        {
            InitializeComponent();
         
            a92 = "А-92";
            a92_p = "44,55";
            a95 = "А-95";
            a95_p = "46,56";
            a98 = "А-98";
            a98_p = "49,60";
            hotdog = "50";
            hamburger = "75";
            cocacola = "19";
            potato = "43";
            string[] items = {  a92, a95, a98 };
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (petrol == null)
            {
                petrol = new Petrol();
                petrol.mainform = this;
            }
            string[] items = { a92, a95, a98 };
            petrol.Items = items;
            petrol.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (cafe == null)
            {
                cafe = new Cafe();
                cafe.mainform = this;
            }
            cafe.Start();
            cafe.ShowDialog();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (edit == null)
            {
                edit = new Edit();
                edit.mainform = this;
            }
            edit.Start();
            edit.ShowDialog();
        }
    }
}
