using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinomniKoeficijenti
{
    public partial class Form1 : Form
    {
        BinomniK bk = new BinomniK();
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }       

        private void button1_Click(object sender, EventArgs e)
        {   
            try
            {
                int n, k;
                n = Convert.ToInt32(textBox1.Text);
                k = Convert.ToInt32(textBox2.Text);
                if (bk.BinK(n, k) == 0)
                    MessageBox.Show("Unijeli ste krive vrijednosti.");
                else
                    label11.Text = bk.BinK(n, k).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Morate unijeti vrijednosti.");
            }

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int x;
                x = Convert.ToInt32(textBox3.Text);
                if (bk.Faktorijel(x) == 0)
                    MessageBox.Show("Unijeli ste krive vrijednosti.");
                else
                    label13.Text = bk.Faktorijel(x).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Morate unijeti vrijednosti.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
           {
                int n, k, x;
                n = Convert.ToInt32(textBox4.Text);
                k = Convert.ToInt32(textBox5.Text);
                x = n - k;
                
                if (bk.BinK(n, k) == 0)
                    MessageBox.Show("Unijeli ste krive vrijednosti.");
                else
                {
                    label17.Text = $"{n}!";
                    label18.Text = $"{k}!";
                    label19.Text = $"{x}!";
                    label21.Text = bk.BinK(n, k).ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Morate unijeti vrijednosti.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
