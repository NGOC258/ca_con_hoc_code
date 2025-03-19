using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quaBong
{
    public partial class Form1 : Form
    {
        int dx = 10, dy = 13;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (picMew.Left < 0 || picMew.Right > ClientRectangle.Width)
                dx = -dx;
            if (picMew.Top < 0 || picMew.Bottom > ClientRectangle.Height)
                dy = -dy;
            picMew.Left += dx;
            picMew.Top += dy;

        }
    }
}
