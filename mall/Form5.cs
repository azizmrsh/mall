using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mall
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Form4.Copy.Count; i++)
            {
                listBox1.Items.Add(Form4.Copy[i]);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for shopping with us!");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = "Total: " + Form3.total.ToString() + "$";
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.Text = "Delivery price : " + (Form3.total * 0.01).ToString("$");

        }

        private void label3_Click(object sender, EventArgs e)
        {
            label4.Text = "Sales tax : " + (Form3.total * 0.12).ToString("$");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.f1.Show();
            this.Close();
        }
    }
}
