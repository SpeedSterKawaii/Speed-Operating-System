using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeedOS
{
    public partial class Windows10 : Form
    {
        public Windows10()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (webBrowser1.Visible == true) 
            {
                webBrowser1.Visible = false;
                label6.Visible = false;
            }
            else 
            {
                webBrowser1.Visible = true;
                label6.Visible = true;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (webBrowser1.Visible == true) 
            {
                webBrowser1.Visible = false;
                label6.Visible = false;
            }
            else if (richTextBox1.Visible == true) 
            {
                webBrowser1.Visible = false;
                label6.Visible = false;
                richTextBox1.Visible = false;
            }
            else if (panel1.Visible == true) 
            {
                webBrowser1.Visible = false;
                label6.Visible = false;
                richTextBox1.Visible = false;
                panel1.Visible = false;
            }
        }

        private async void TimeUpdate() 
        {
            while (true) 
            {
                await Task.Delay(100);
                label7.Text = "Current Time: " + DateTime.Now.ToString() ;
            }
        }

        private void Windows10_Load(object sender, EventArgs e)
        {
            TimeUpdate();
            this.webBrowser1.Navigate("https://www.google.com/");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Visible == true)
            {
                richTextBox1.Visible = false;
                label6.Visible = false;
            }
            else
            {
                richTextBox1.Visible = true;
                label6.Visible = true;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
            {
                richTextBox1.Visible = false;
                label6.Visible = false;
                panel1.Visible = false;
            }
            else
            {
                panel1.Visible = true;
                label6.Visible = true;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All files (*.*)|*.*";

            var result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                BackgroundImage = new Bitmap(ofd.FileName);
            }
        }
    }
}
