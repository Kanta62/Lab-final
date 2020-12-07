using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginInfo
{
    public partial class Form1 : Form
    {
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 flog = new Form3();
            MessageBox.Show(flog.setfirstName());

            if (textBox1.Text == flog.setfirstName() && textBox2.Text == flog.setPassword())
            {
                MessageBox.Show("You have loged in sucsefully");
            }
            else
            {
                if(textBox1.Text==""&&textBox2.Text=="")
                {
                    MessageBox.Show("Please Enter user name and password");
                }

                else if (textBox1.Text != flog.setfirstName() && textBox2.Text == flog.setPassword())
                {
                    MessageBox.Show("Please Enter carect user name");
                }
                else if (textBox1.Text == flog.setfirstName() && textBox2.Text != flog.setPassword())
                {
                    MessageBox.Show("Please Enter carect password");
                }
                else if (textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("Please fill every info");
                }
                else
                {
                    MessageBox.Show("Please Enter carect user name and password");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
           }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
