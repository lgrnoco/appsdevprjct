using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    
     private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = " ";
            //Checdkbox1 = Japan
            if (checkBox1.Checked == true)
            {
                str = str + checkBox1.Text;
                str += "";
            }
            //Checkbox2 = South Korea
            if (checkBox2.Checked == true)
            {
                str = str + checkBox2.Text;
                str += "";
            }
            //Checkbox3 = Italy
            if (checkBox3.Checked == true)
            {
                str = str + checkBox3.Text;
                str += "";
            }
            //Checkbox4 = Germany
            if (checkBox4.Checked == true)
            {
                str = str + checkBox4.Text;
                str += "";
            }
            if (str != null)
            {
                MessageBox.Show("You Selected  \n" + str + "\nThank You!", "Survey", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            othersLabel.Visible = true;
            othersTextBox.Visible = true;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)

    }
}
