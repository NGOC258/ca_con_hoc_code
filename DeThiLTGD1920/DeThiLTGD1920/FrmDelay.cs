using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeThiLTGD1920
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
            bmp = new Bitmap(ClientRectangle.Width, ClientRectangle.Height);
            Graphics g = Graphics.FromImage(bmp);
            for (int i = 0; i < 100; i++)
            {
                int x = random.Next(0, ClientRectangle.Width);
                int y = random.Next(0, ClientRectangle.Height);
                int size = random.Next(0, 5);
                g.FillEllipse(Brushes.Red, x, y, size, size);
            }

            Font font = new Font("Arial", 25, FontStyle.Bold);
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;
            SolidBrush br = new SolidBrush(Color.Blue);
            g.DrawString("2351010082 - Hoàng Phi Hùng", font, br, ClientRectangle, format);
            g.DrawRectangle(new Pen(Brushes.Red, 5), ClientRectangle);
            this.BackgroundImage = bmp;
        }

        private void FrmDelay_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pic1.Left++;
            pic2.Left--;
            if(pic1.Right > pic2.Left)
            {
                timer1.Enabled = false;
                this.Close();
                

            }
        }
    }
}
