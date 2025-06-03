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

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            ELC.Add("laptop");
        }
    }
}
