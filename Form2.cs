using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circuits_and_Physics_Calculator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        // initialize
        double[] num = new double[10];
        int count;
        double ans;

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        // set up labels and operations op1 is add op2 is divide
        private void Capacitor_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Parallel_Capacitor;
            label3.Text = "F";
        }

        private void Resistor_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Series_Resistor;
            label3.Text = "Ohm";
        }


        private void Add_Click(object sender, EventArgs e)
        {
            // limit the array list to 10 because arrays need a limit
            if (count >= 9)
            {
                MessageBox.Show("Error: Max limit reached");
            }
            //take the entered value to the array
            num[count] = double.Parse(textBox1.Text);
            count++;
            textBox1.Text = "";
        }

        private void Solve_Click(object sender, EventArgs e)
        {
            //in case there is still a number
            if (textBox1.Text != "")
            {
                num[count] = double.Parse(textBox1.Text);
                count++;
                textBox1.Text = "";
            }
            // solve
            while (count > -1)
            {
                ans += num[count];
                count--;
            }
            // bring count back to 0 for next computation
            count = 0;
            //display answers
            ans = Math.Round(ans, 2);
            label1.Show();
            label2.Text = ans.ToString();
            label2.Show();
            label3.Show();
            //reset ans back to 0 for next computation
            ans = 0;

        }
    }
}
