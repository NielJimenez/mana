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
    public partial class Form4 : Form
    {
        int h;
        int m;
        int s;
        public Form4()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";


            }
            if (textBox2.Text == "")
            {   
                textBox2.Text = "0";


            }
            if (textBox3.Text == "")
            {
                textBox3.Text = "0";


            }

            h = Convert.ToInt32(textBox1.Text);
            m = Convert.ToInt32(textBox2.Text);
            s = Convert.ToInt32(textBox3.Text);

            timer2.Start();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {
                
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            s = s - 1;
           

            if(s == -1)
            {
                m = m-1;
                s = 59;

            }
            if (m == -1)
            {
                h = -1;
                m = 59;




            }
            if (h == 0 && m == 0 && s == 0)
            {
                timer2.Stop();
                MessageBox.Show("TimeS Up!", "Time");
            }
          

            string hh = Convert.ToString(h);
            string mm = Convert.ToString(m);
            string ss = Convert.ToString(s);

            label1.Text = hh;
            label2.Text = mm;
            label3.Text = ss;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            timer2.Stop();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
