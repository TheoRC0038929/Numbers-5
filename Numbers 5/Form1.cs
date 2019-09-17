using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numbers_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            double pi = 3.14159265;
            richTextBox1.AppendText(pi.ToString() + "\n");
            richTextBox1.AppendText(3.ToString("N3") + "\n");
            richTextBox1.AppendText(3.ToString("N5") + "\n");
            richTextBox1.AppendText(3.ToString("N15") + "\n");
            ;
            double c = 299792458;
            richTextBox1.AppendText(c.ToString() + "\n");
            richTextBox1.AppendText(3.ToString("N3") + "\n");
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
