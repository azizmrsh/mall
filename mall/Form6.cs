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
    public partial class Form6 : Form
    {
        List<string> dep = new List<string>();
        public static List<string> emi = new List<string>();
        public static List<string> emp = new List<string>(); 

        public Form6()
        {
            InitializeComponent();
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            { 
                for (int i = 0; i < emi.Count; i++)
                {
                    if(emi[i].ToString()[0] == '1')
                    {
                        listBox1.Items.Add(emi[i].ToString());
                    }
                }
                
            }
            else if (comboBox1.SelectedIndex == 1) 
            {
                for (int i = 0; i < emi.Count; i++)
                {
                    if (emi[i].ToString()[0] == '2')
                    {
                        listBox1.Items.Add(emi[i].ToString());
                    }
                }
            }
            else if (comboBox1.SelectedIndex == 2) 
            { 
                for (int i = 0; i < emi.Count; i++)
                {
                    if (emi[i].ToString()[0] == '3')
                    {
                        listBox1.Items.Add(emi[i].ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a valid department.");
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            dep.Add("Electronic");  //1
            dep.Add("Clothes");    //2
            dep.Add("Grosery");   //3

            emi.Add("11");
            emp.Add("1111");
            emi.Add("12");
            emp.Add("1212");
            emi.Add("21");
            emp.Add("2121");
            emi.Add("22");
            emp.Add("2222");
            emi.Add("31");
            emp.Add("3131");
            emi.Add("32");
            emp.Add("3232");

            if (comboBox1.SelectedItem.ToString()[0] == '1')
            {
                textBox2.Text = "Electronic";
                
            }
            else if (comboBox1.SelectedItem.ToString()[0] == '2')
            {
                textBox2.Text = "Clothes";
               
            }
            else if (comboBox1.SelectedItem.ToString()[0] == '3')
            {
                textBox2.Text = "Grosery";
                
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (emi.Contains(textBox1.Text) == false)
            {
                if(comboBox1.SelectedIndex == 0)
                {
                    textBox2 .Text =comboBox1.SelectedItem.ToString();
                    textBox1.Text = "1" + textBox1.Text;
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    textBox2.Text = comboBox1.SelectedItem.ToString();
                    textBox1.Text = "2" + textBox1.Text;
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    textBox2.Text = comboBox1.SelectedItem.ToString();
                    textBox1.Text = "3" + textBox1.Text;
                }
                else 
                {
                    MessageBox.Show("Please select a valid department.");
                }

                emi.Add(textBox1.Text);
                emp.Add(textBox2.Text);
                listBox1.Items.Add(textBox1.Text);
            }
            else
                MessageBox.Show("User already exists");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                emi.RemoveAt(listBox1.SelectedIndex);
                emp.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else
                MessageBox.Show("Please select a user to be deleted");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                emp[listBox1.SelectedIndex] = textBox2.Text;
                MessageBox.Show("The Employee updated successfuly");
            }
            else
                MessageBox.Show("Please select a Employee to be updated");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1.f1.Show();
            this.Close();
        }
    }
}
