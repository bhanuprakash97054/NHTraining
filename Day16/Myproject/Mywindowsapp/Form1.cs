using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bhanulibrary;
using Publiclibrary;

namespace Mywindowsapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
   
        private void button1_Click(object sender, EventArgs e)
        {
            Mathematics m = new Mathematics();    
            int n=Convert.ToInt32(textBox1.Text);
            m.n = n;
            int f = m.Factorial();
            textBox2.Text = f.ToString();
        }
    }
}
