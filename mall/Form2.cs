﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public static String urn;
        public static String urp;
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.usn.Add(textBox1.Text);
            Form1.usp.Add(textBox2.Text);
            urn = textBox1.Text;
            urp = textBox2.Text;

            Form1.f1.Show();
            this.Close();
        }
    }
}
