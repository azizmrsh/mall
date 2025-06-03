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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static Form1 f1 = new Form1();
        List<string> usn = new List<string>();
        List<string> usp = new List<string>();
        private void Form1_Load(object sender, EventArgs e)
        {

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

            for (int i = 0; i < Form6.emi.Count; i++)
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
            else if (textBox1.Text == "Manger" && textBox2.Text == "123456")
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
