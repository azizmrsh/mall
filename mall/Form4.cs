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

        public static List<float> PELC = new List<float>();
        public static List<float> PCLO = new List<float>();
        public static List<float> PGRO = new List<float>();


        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

            ELC.Add("Laptop 1000$");
            PELC.Add(1000);
            ELC.Add("Mobile1000$");
            PELC.Add(1000);
            ELC.Add("Microwave500$");
            PELC.Add(500);
            ELC.Add("Fridge550$");
            PELC.Add(550);
            CLO.Add("Shoes30$");
            PCLO.Add(30);
            CLO.Add("T-shirt35$");
            PCLO.Add(35);
            CLO.Add("Jacket65$");
            PCLO.Add(65);
            CLO.Add("Pant45$");
            PCLO.Add(45);
            GRO.Add("Flour7$");
            PGRO.Add(7);
            GRO.Add("Rice35.5$");
            PGRO.Add(35.5f);
            GRO.Add("Suger2$");
            PGRO.Add(2);
            GRO.Add("Salt1$");
            PGRO.Add(1);



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


