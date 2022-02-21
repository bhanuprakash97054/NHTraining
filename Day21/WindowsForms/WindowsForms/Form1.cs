using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms.ServiceReference1;

namespace WindowsForms
{
    /**********************************
     * author:bhanu rama krishna prakash jakkamsetti
     * purpose:access web server by using windows app
     * ***************************************/
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           int n=Convert.ToInt32(textBox1.Text);
            WebService1SoapClient w = new WebService1SoapClient();
            textBox2.Text = w.Factorial(n).ToString();        
        }
    }
}
