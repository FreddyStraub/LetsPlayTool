using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bunifu_Test
{
    public partial class Form1 : Form
    {

 

        public Form1()
        {
            InitializeComponent();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            bunifuDragControl1.Grab(this);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            bunifuDragControl1.Release();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

                }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            bunifuDragControl1.Grab(this);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            bunifuDragControl1.Release();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
