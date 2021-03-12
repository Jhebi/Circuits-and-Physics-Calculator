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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // initialize
        int op;
        double num1, num2, ans;
        private void Circuits_CheckedChanged(object sender, EventArgs e)
        {
            //selects and reveals Circuits Group
            CGroup.Show();
            Pgroup.Hide();
            SeriesPara.Show();
        }

        private void Physics_CheckedChanged(object sender, EventArgs e)
        {
            //selects and reveals Physics Group
            Pgroup.Show();
            CGroup.Hide();
            SeriesPara.Hide();
        }

        private void Voltage_CheckedChanged(object sender, EventArgs e)
        {
            //set operation, units, and show the formula and solve button
            op = 1;
            label1.Show();
            label2.Show();
            label1.Text = "A";
            label2.Text = "Ohm";
            label5.Text = "V";
            Solve.Show();
            pictureBox1.Image = Properties.Resources.Voltage;
        }

        private void Current_CheckedChanged(object sender, EventArgs e)
        {
            //set operation, units, and show the formula and solve button
            op = 2;
            label1.Show();
            label2.Show();
            label1.Text = "V";
            label2.Text = "Ohm";
            label5.Text = "A";
            Solve.Show();
            pictureBox1.Image = Properties.Resources.Current;
        }

        private void Resistor_CheckedChanged(object sender, EventArgs e)
        {
            //set operation, units, and show the formula and solve button
            op = 2;
            label1.Show();
            label2.Show();
            label1.Text = "V";
            label2.Text = "A";
            label5.Text = "Ohm";
            Solve.Show();
            pictureBox1.Image = Properties.Resources.Resistance;
        }

        private void Power1_CheckedChanged(object sender, EventArgs e)
        {
            //set operation, units, and show the formula and solve button
            op = 1;
            label1.Show();
            label2.Show();
            label1.Text = "A";
            label2.Text = "V";
            label5.Text = "J";
            Solve.Show();
            pictureBox1.Image = Properties.Resources.Power_IV;
        }

        private void Power2_CheckedChanged(object sender, EventArgs e)
        {
            //set operation, units, and show the formula and solve button
            op = 3;
            label1.Show();
            label2.Show();
            label1.Text = "A";
            label2.Text = "Ohm";
            label5.Text = "J";
            Solve.Show();
            pictureBox1.Image = Properties.Resources.Power_IR;
        }

        private void Power3_CheckedChanged(object sender, EventArgs e)
        {
            //set operation, units, and show the formula and solve button
            op = 4;
            label1.Show();
            label2.Show();
            label1.Text = "V";
            label2.Text = "Ohm";
            label5.Text = "J";
            Solve.Show();
            pictureBox1.Image = Properties.Resources.Power_VR;
        }

        private void Distance_CheckedChanged(object sender, EventArgs e)
        {
            //set operation, units, and show the formula and solve button
            op = 1;
            label1.Show();
            label2.Show();
            label1.Text = "km/h";
            label2.Text = "h";
            label5.Text = "km";
            Solve.Show();
            pictureBox1.Image = Properties.Resources.Distance;
        }

        private void Speed_CheckedChanged(object sender, EventArgs e)
        {
            //set operation, units, and show the formula and solve button
            op = 2;
            label1.Show();
            label2.Show();
            label1.Text = "km";
            label2.Text = "h";
            label5.Text = "km/h";
            Solve.Show();
            pictureBox1.Image = Properties.Resources.Speed;
        }

        private void Force_CheckedChanged(object sender, EventArgs e)
        {
            //set operation, units, and show the formula and solve button
            op = 1;
            label1.Show();
            label2.Show();
            label1.Text = "kg";
            label2.Text = "m/s^2";
            label5.Text = "N";
            Solve.Show();
            pictureBox1.Image = Properties.Resources.Force;
        }

        private void Pressure_CheckedChanged(object sender, EventArgs e)
        {
            //set operation, units, and show the formula and solve button
            op = 1;
            label1.Show();
            label2.Show();
            label1.Text = "N";
            label2.Text = "m^2";
            label5.Text = "Pa";
            Solve.Show();
            pictureBox1.Image = Properties.Resources.Pressure;
        }
        private void Work_CheckedChanged(object sender, EventArgs e)
        {
            //set operation, units, and show the formula and solve button
            op = 1;
            label1.Show();
            label2.Show();
            label1.Text = "N";
            label2.Text = "m";
            label5.Text = "J";
            Solve.Show();
            pictureBox1.Image = Properties.Resources.Work;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only accept digits
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only accept digits
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void SeriesPara_Click(object sender, EventArgs e)
        {
            //go to second form
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void Solve_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
            num2 = double.Parse(textBox2.Text);
            label3.Show();
            switch(op)
            {
                case 1:
                    {
                        ans = num1 * num2;
                        break;
                    }
                case 2:
                    {
                        ans = num1 / num2;
                        break;
                    }
                case 3:
                    {
                        ans = (num1 * num1) * num2;
                        break;
                    }
                case 4:
                    {
                        ans = (num1 * num1) / num2;
                        break;
                    }
                default:
                    break;
            }
            ans = Math.Round(ans, 2);
            anspanel.Show();
            label4.Text = ans.ToString();
            label4.Show();
            label5.Show();
        }


       
    }
}
