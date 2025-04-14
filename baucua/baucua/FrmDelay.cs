using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baucua
{
    public partial class FrmDelay : Form
    {
        Random random = new Random();   
        Bitmap bmp;
        public FrmDelay()
        {
            InitializeComponent();
        }

        private void FrmDelay_Load(object sender, EventArgs e)
        {
            bmp= new Bitmap(ClientRectangle.Width, ClientRectangle.Height);
            Graphics g = Graphics.FromImage(bmp);
            Font font = new Font( "Times New Roman", 25, FontStyle.Bold | FontStyle.Italic);
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;
            SolidBrush br = new SolidBrush(Color.Blue);
            g.DrawString("2354050077-VHN", font, br, ClientRectangle, format);
            this.BackgroundImage = bmp;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left++;
            pictureBox2.Left--;
            if( pictureBox1.Right>pictureBox2.Left)
            {
                timer1.Enabled = false;
                this.Close();
            }
        }
    }
}
