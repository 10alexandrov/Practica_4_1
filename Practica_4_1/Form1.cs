using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_4_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            label1.Font = new Font("Microsoft Sans Serif", 18, FontStyle.Bold);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Font = new Font("Microsoft Sans Serif", 18, FontStyle.Italic);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Font = new Font("Microsoft Sans Serif", 18, FontStyle.Underline);
        }

    }
}
