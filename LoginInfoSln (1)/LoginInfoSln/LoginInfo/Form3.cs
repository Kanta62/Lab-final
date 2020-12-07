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
    public partial class Form3 : Form
    {
        public String lp;
        public String Qus;
        private String firstName;
        private String lastName;
        private String Gender;
        private String Email;
        private String Password;
        private String Sans;
        private String Address;
        private String city;
        private String State;
        private String zip;
        private String PhoneNumber;
        public void getfirstName(String v)
        {
            firstName = v;
        }
        public void getlastName(String v)
        {
            lastName = v;
        }
        public void getGender(String v)
        {
            Gender = v;
        }
        public void getEmail(String v)
        {
            Email = v;
        }
        public void getPassword(String v)
        {
            Password = v;
        }
        public void getSans(String v)
        {
            Sans = v;
        }
        public void getAddress(String v)
        {
            Address = v;
        }
        public void getcity(String v)
        {
            city = v;
        }
        public void getState(String v)
        {
            State = v;
        }
        public void getzip(String v)
        {
            zip = v;
        }
        public void getPhoneNumber(String v)
        {
            PhoneNumber = v;
        }
        public String setPhoneNumber()
        {
            return PhoneNumber;
        }
        public String setzip()
        {
            return zip;
        }
        public String setState()
        {
            return State;
        }
        public String setcity()
        {
            return city;
        }
        public String setAddress()
        {
            return Address;
        }
        public String setSans()
        {
            return Sans;
        }
        public String setPassword()
        {
            return Password;
        }
        public String setEmail()
        {
            return Email;
        }
        public String setGender()
        {
            return Gender;
        }
        public String setlastName()
        {
            return lastName;
        }
        public String setfirstName()
        {
            return firstName;
        }




        public Form3()
        {
            InitializeComponent();
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            lp = comboBox2.Text;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            getState(comboBox3.Text);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            getAddress(textBox8.Text);
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            getPhoneNumber(textBox9.Text);
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            getzip(textBox10.Text);
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            getcity(textBox11.Text);
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (setEmail() != textBox4.Text)
            {
                MessageBox.Show("Email is incorrect");
            }
            else if (setPassword() != textBox6.Text)
            {
                MessageBox.Show("Password is incorrect");

            }
            else if (setPassword().Length <= 7)
            {
                MessageBox.Show("Password cant be less then 8 word");
            }
            else
            {
                Form1 f = new Form1();
                f.Show();
                Close();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            getfirstName(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            getlastName(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            getEmail(textBox3.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            getPassword(textBox5.Text);
 
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            getSans(textBox7.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Qus = comboBox1.Text;
            
        }
    }
}
