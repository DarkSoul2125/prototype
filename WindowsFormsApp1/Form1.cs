using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        persona p;
        builder b;
        persona pp;
        private void button1_Click(object sender, EventArgs e)
        {
            b = new poorconfig();
            p = b.build();
            pictureBox1.Image = p.pictures;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            b = new mediumconfig();
            p = b.build();
            pictureBox1.Image = p.pictures;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            b = new richconfig();
            p = b.build();
            pictureBox1.Image = p.pictures;
        }

        private void button4_Click(object sender, EventArgs e)
        {
           pp = p.clone();
            pictureBox2.Image = pp.pictures;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add(p.weapon);
            listBox1.Items.Add(p.armor);
            listBox1.Items.Add(p.amulet);
            listBox1.Items.Add(p.ring);
            listBox1.Items.Add(p.subweapon);
            listBox1.Items.Add(p.potions);

            listBox1.Items.Add("===========================");

            listBox1.Items.Add(pp.weapon);
            listBox1.Items.Add(pp.armor);
            listBox1.Items.Add(pp.amulet);
            listBox1.Items.Add(pp.ring);
            listBox1.Items.Add(pp.subweapon);
            listBox1.Items.Add(pp.potions);
        }
    }
}
