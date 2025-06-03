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
    public partial class Form3 : Form
    {
        public static double total = 0.0;
        public static List<string> Copy = new List<string>();
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox4.Items.Add(listBox1.SelectedItem);
            Copy.Add(listBox4.SelectedItem.ToString());
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

           


        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox4.Items.Remove(listBox4.SelectedItem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.ShowDialog();
            this.Close();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                for (int i = 0; i < Form4.GRO.Count; i++)
                {
                    listBox1.Items.Add(Form4.GRO[i]);

                }

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                for (int i = 0; i < Form4.CLO.Count; i++)
                {
                    listBox1.Items.Add(Form4.CLO[i]);


                }
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                for (int i = 0; i < Form4.ELC.Count; i++)
                {
                    listBox1.Items.Add(Form4.ELC[i]);
                }
            }
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
