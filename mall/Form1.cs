using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mall
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static Form1 f1 = new Form1();
        public static List<string> usn = new List<string>();
        public static List<string> usp = new List<string>();
        private void Form1_Load(object sender, EventArgs e)
        {
            f1 = this;
            textBox1.Text = Form2.urn;
            textBox2.Text = Form2.urp;

           usn.Add("user1");
            usp.Add("1234");
            Form6.emi.Add("11");
            Form6.emp.Add("1111");
            Form6.emi.Add("12");
            Form6.emp.Add("1212");
            Form6.emi.Add("21");
            Form6.emp.Add("2121");
            Form6.emi.Add("22");
            Form6.emp.Add("2222");
            Form6.emi.Add("31");
            Form6.emp.Add("3131");
            Form6.emi.Add("32");
            Form6.emp.Add("3232");

            Form4.ELC.Add("Laptop 1000$");
            Form4.PELC.Add(1000);
            Form4.ELC.Add("Mobile1000$");
            Form4.PELC.Add(1000);
            Form4.ELC.Add("Microwave500$");
            Form4.PELC.Add(500);
            Form4.ELC.Add("Fridge550$");
            Form4.PELC.Add(550);
            Form4.CLO.Add("Shoes30$");
            Form4.PCLO.Add(30);
            Form4.CLO.Add("T-shirt35$");
            Form4.PCLO.Add(35);
            Form4.CLO.Add("Jacket65$");
            Form4.PCLO.Add(65);
            Form4.CLO.Add("Pant45$");
            Form4.PCLO.Add(45);
            Form4.GRO.Add("Flour7$");
            Form4.PGRO.Add(7);
            Form4.GRO.Add("Rice35.5$");
            Form4.PGRO.Add(35.5f);
            Form4.GRO.Add("Suger2$");
            Form4.PGRO.Add(2);
            Form4.GRO.Add("Salt1$");
            Form4.PGRO.Add(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int found = 0;
            //1 Manager
            //2 Employee
            //3 user
            
            for (int i = 0; i < Form6.emi.Count; i++)
            {
                if (Form6.emi[i] == textBox1.Text && Form6.emp[i] == textBox2.Text)
                {
                    found = 2;
                    break;
                }
            }

            for (int i = 0; i < usn.Count; i++)
            {
                if (usn[i] == textBox1.Text && usp[i] == textBox2.Text)
                {
                    found = 3;
                    break;
                }
            }



            if (found == 2)
            {
                Form4 f4 = new Form4();
                f4.Show();
                this.Hide();
            }
            else if (found == 3)
            {
                Form3 f3 = new Form3();
                f3.Show();
                this.Hide();
            }
            else if (textBox1.Text == "manager" && textBox2.Text == "123456")
            {
                Form6 f6 = new Form6();
                f6.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Unvalide user name or password");
            }



        }
    }
}
