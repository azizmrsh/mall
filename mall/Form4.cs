using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using System.Xml.Linq;

namespace mall
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public partial class Form4 : Form
    {
        Form1 form1 = new Form1();
        private string employeeID;

        public static List<string> ELC = new List<string>();
        public static List<string> CLO = new List<string>();
        public static List<string> GRO = new List<string>();
        public static List<string> Copy = new List<string>();
        public static List<string> PELC = new List<string>();
        public static List<string> PCLO = new List<string>();
        public static List<string> PGRO = new List<string>();
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {


        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //item
        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //price
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string pricetext = textBox2.Text;

            if (name == "" || pricetext == "")
            {
                MessageBox.Show("Please enter the item name and price.");
                return;
            }
            float price;
            try
            {
                price = float.Parse(pricetext);
            }
            catch
            {
                MessageBox.Show("The price is incorrect. Please enter a number.");
                return;
            }
            if (employeeID == "")
                CLO.Add(name);
            else if (employeeID == "")
                GRO.Add(name);
            else if (employeeID == "")
                ELC.Add(name);
            else
            {
                MessageBox.Show("The employee is not attached to a department.");
                return;
            }

            MessageBox.Show("Added successfully.");

        }
        private void button2_Click(object sender, EventArgs e)
        {
            //update
        }
        private void button3_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Hide();
            //logout
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //remove
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //confirm
        }
    }
}


