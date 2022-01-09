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
        int operacao = 1;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            operacao = 2;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            operacao = 1;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            operacao = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            operacao = 4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor;
            int n100, n50, n20;
            int resto;
            
            valor =Convert.ToInt16(textBox1.Text);

            n100 = valor / 100;
            resto = valor - (n100 * 20);

            textBox3.Text = n100.ToString();

            n50 = valor / 50;
            resto = valor - (n50 * 20);

            textBox5.Text = n50.ToString();

            n20 = valor / 20;
            resto = valor - (n20 * 20);

            textBox4.Text = n20.ToString();


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
