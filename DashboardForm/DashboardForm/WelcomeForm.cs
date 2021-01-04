using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashboardForm
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AboutForm f = new AboutForm();
            this.Hide();
            f.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panel3.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            
        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Login to Ur Account First ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnContactus_Click(object sender, EventArgs e)
        {
            ContactusForm c = new ContactusForm();
            this.Hide();
            c.Show();

        }
    }
}
