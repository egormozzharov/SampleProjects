using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Setting1
{
    public partial class Form1 : Form
    {
        private  Properties.Settings set = Properties.Settings.Default;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = set.testSetting;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            set.testSetting = textBox1.Text.Trim();
            set.Save();
        }
    }
}
