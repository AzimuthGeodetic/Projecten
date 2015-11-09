using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PatrickFuncties;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 value = Int32.Parse(numericTextBox1.Text);
            Int32 value2 = Int32.Parse(numericTextBox2.Text);
            Int32 value3 = value + value2;
            string berekening = (String.Format("{0}" + "+" + "{1}" + "=" + "{2}", value, value2, value3));
            MessageBox.Show(berekening, "blup", MessageBoxButtons.OK);
        }
    }
}
