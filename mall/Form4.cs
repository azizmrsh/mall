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
    }
}


