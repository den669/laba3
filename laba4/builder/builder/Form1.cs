using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace builder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Builder pizza = new AwesomePizzzaBuilder();
            Director director = new Director(pizza);
            Pizzza pizz = director.Buildpiz();
            richTextBox1.Text += pizz.Data();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Builder pizza2 = new NormalPizzzaBuilder();
            Director director = new Director(pizza2);
            Pizzza pizz2 = director.Buildpiz();
            richTextBox1.Text += pizz2.Data();
            for (int i = 0; i < Convert.ToInt32(textBox1.Text); i++)
            {
                Pizza clone = pizz2.Copy();
                richTextBox1.Text += "Копія" + (i + 1) + ((Pizzza)clone).crust + ((Pizzza)clone).sauce + ((Pizzza)clone).toppings + "\n";
            }
        }
    }
}
