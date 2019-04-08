using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicaion_evento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked == true) {
                label1.Text = "seleccione el check1";
            }

            if(this.checkBox2.Checked == true) {
                label1.Text = "seleccione el check2";
          }
            if (this.checkBox3.Checked == true)
            {
                label1.Text = "seleccione el check3";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            radioButton2.Checked = true;
            radioButton3.Checked = true;
            radioButton4.Checked = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox3.Checked = false;
            radioButton1.Checked = true;
            radioButton3.Checked = true;
            radioButton4.Checked = true;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            radioButton1.Checked = true;
            radioButton2.Checked = true;
            radioButton4.Checked = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "un solo click";
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            label1.Text = "doble click";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                label1.BackColor = Color.Red;
            }
            if (comboBox1.SelectedIndex ==1)
            {
                label1.BackColor = Color.Blue;
            }
            if (comboBox1.SelectedIndex == 2)
            {

                this.BackColor = Color.Coral   ;


               // label1.BackColor = Color.Green;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
