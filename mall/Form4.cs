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
    public partial class Form4 : Form
    {
        public static List<string> ELC = new List<string>();
        public static List<string> CLO = new List<string>();
        public static List<string>  GRO = new List<string>();
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
            ELC.Add("Laptop    1000$");
            PELC.Add(1000);
            ELC.Add("Mobile    1000$");
            PELC.Add(1000);
            ELC.Add("Microwave  500$");
            PELC.Add(500);
            ELC.Add("Fridge      550$");
            PELC.Add(550);
            CLO.Add("Shoes        30$");
            PCLO.Add(30);
            CLO.Add("T-shirt       35$");
            PCLO.Add(35);
            CLO.Add("Jacket        65$");
            PCLO.Add(65);
            CLO.Add("Pant          45$");
            PCLO.Add(45);
            GRO.Add("Flour          7$");
            PGRO.Add(7);
            GRO.Add("Rice           35.5$");
            PGRO.Add(35.5f);
            GRO.Add("Suger           2$");
            PGRO.Add(2);
            GRO.Add("Salt             1$");
            PGRO.Add(1);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
