using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_click_count
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label_l.Text = "0";
            label_r.Text = "0";
        }

        private void Panel_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left ) {
                label_l.Text = (Int32.Parse(label_l.Text) + 1).ToString();
            }
            if (e.Button == MouseButtons.Right)
            {
                label_r.Text = (Int32.Parse(label_r.Text) + 1).ToString();
            }

        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            label_coord.Text= e.X.ToString() + "; " + e.Y.ToString();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            label_coord.Text = e.X.ToString() + "; " + e.Y.ToString();
        }
    }
}
