using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema__Reservation
{
    public partial class Cinema : Form
    {
        public Cinema()
        {
            InitializeComponent();
        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text);
            listBox2.Items.Add(comboBox2.Text);
            listBox3.Items.Add(comboBox3.Text);
            listBox4.Items.Add(textBox3.Text);
            listBox5.Items.Add(comboBox1.Text);
            listBox6.Items.Add(comboBox4.Text);



        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox7.Items.Add(button3.Text);
            button3.BackColor = Color.Red;
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox7.Items.Add(button4.Text);
            button4.BackColor = Color.Red;
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox7.Items.Add(button5.Text);
            button5.BackColor = Color.Red;
            button5.Enabled = false;


        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox7.Items.Add(button6.Text);
            button6.BackColor = Color.Red;
            button6.Enabled = false;

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox7.Items.Add(button8.Text);
            button8.BackColor = Color.Red;
            button8.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            listBox7.Items.Add(button14.Text);
            button14.BackColor = Color.Red;
            button14.Enabled = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            listBox7.Items.Add(button17.Text);
            button17.BackColor = Color.Red;
            button17.Enabled = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            listBox7.Items.Add(button19.Text);
            button19.BackColor = Color.Red;
            button19.Enabled = false;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            listBox7.Items.Add(button20.Text);
            button20.BackColor = Color.Red;
            button20.Enabled = false;
        }
    }
}
