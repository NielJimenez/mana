using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinamiHigashi1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button24_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = richTextBox1.Text;
            pass = richTextBox2.Text;

            if(user == "Admin" && pass == "Admin") 
            {
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
                MessageBox.Show("successful");
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
         }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
