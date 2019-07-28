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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Form4 F4 = new Form4();
            F4.Show();
            this.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            userControl11.Visible = true;
            MessageBox.Show("ahhaha");
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
