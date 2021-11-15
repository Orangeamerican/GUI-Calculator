using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {

        private string hold;
        private string value;
        string operation = "";

        private Solver solving = new Solver();
        public Form1()
        {
            InitializeComponent();
            hold = "" + Environment.NewLine + Environment.NewLine + "----------------------" + Environment.NewLine;
            textBox1.Text = "" + Environment.NewLine + Environment.NewLine + "----------------------" + Environment.NewLine;
        }
        
        //clears everything pressed
        private void AC_Click(object sender, EventArgs e)
        {
            value = "";
            textBox1.Text = value + hold;
        }

        //adds plus or minus
        private void plusOrminus_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            value += button.Text;
            textBox1.Text = value + hold;
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            value += button.Text;
            textBox1.Text = value + hold;
        }

        private void operation_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation += button.Text;
            if (button.Text == "x")
            {
                value += "*";
                textBox1.Text = value + hold;
            }
            else
            {
                value += button.Text;
                textBox1.Text = value + hold;
            }
        }

        private void equals_Click(object sender, EventArgs e)
        {
            
        }
    }
}