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
        List<string> use = new List<string>();
        List<string> pas = new List<string>();
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
            int fond = 0;
            //1 Manager
            //2 Employee
            //3 user
            
            for (int i = 0; i < Form6.emi.Count; i++)
            {
                if (Form6.emi[i] == textBox1.Text && Form6.emp[i] == textBox2.Text)
                {
                    fond = 2;
                    break;
                }
            }

            for (int i = 0; i < Form6.emi.Count; i++)
            {
                if (Form6.emi[i] == textBox1.Text && Form6.emp[i] == textBox2.Text)
                {
                    fond = 2;
                    break;
                }
            }



            if (textBox1.Text == "user" && textBox2.Text == "123456")
            {
                Form3 f3 = new Form3();
                f3.Show();
                this.Hide();
            }
            else if (textBox1.Text == "Manager" && textBox2.Text == "123456")
            {
                Form6 f6 = new Form6();
                f6.Show();
                this.Hide();
            }
            else if (textBox1.Text == "Employee" && textBox2.Text == "123456")
            {
                Form4 f4 = new Form4();
                f4.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("用户名或密码错误！");
            }


        }
    }
}
