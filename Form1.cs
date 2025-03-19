using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoanXucXac
{
    public partial class Form1 : Form
    {
        string imgPath;
        int nChoose, nCount, nWin, nLose;
        Random rand = new Random();

        private void btn1_Click(object sender, EventArgs e)
        {
            Choose(sender);
        }
        private void Choose (object sender)
        {
            Button bt = (Button)sender;
            nChoose = int.Parse(bt.Text);
            picChoose.Image = Image.FromFile(imgPath + bt.Text + ".jpg");
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            imgPath = Application.StartupPath + @"\hinhxucxac\";
            Init();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            nCount = nWin = nLose = 0;
            nChoose = 1;
            picChoose.Image = Image.FromFile(imgPath + "1.jpg");
            picResult.Image = null;
            lbCount.Text = lbLose.Text = lbWin.Text = " ";
            listResult.Items.Clear();
        }

        private void btPlay_Click(object sender, EventArgs e)
        {
            Play();
        }
        private void Play()
        {
            nCount++;
            int n = rand.Next(1, 7);
            picResult.Image = Image.FromFile(imgPath + n.ToString() + ".jpg");
            string result = "";
            if(nChoose== n)
            {
                nWin++;
                result = "Win!";
            }
            else
            {
                nLose++;
                result = "Lose!";
            }
            lbCount.Text = String.Format("Lan doan: {0}", nCount);
            lbWin.Text = String.Format("lan thang :{0} ({1:0.##}%)", nWin, (double)nWin * 100 / nCount);
            lbLose.Text = String.Format("lan thua: ({1:0.##}%)", nLose, (double)nLose * 100 / nCount);
            listResult.Items.Add(String.Format("{0}. {1} (Doan {2} ra {3})", nCount, result, nChoose, n));

        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter:Play(); break;
                case Keys.Escape: Init(); break;
                case Keys.D1: case Keys.NumPad1: Choose(btn1); break;
                case Keys.D2: case Keys.NumPad2: Choose(btn2); break;
                case Keys.D3: case Keys.NumPad3: Choose(btn3); break;
                case Keys.D4: case Keys.NumPad4: Choose(btn4); break;
                case Keys.D5: case Keys.NumPad5: Choose(btn5); break;
                case Keys.D6: case Keys.NumPad6: Choose(btn6); break;
            }
            return base.ProcessDialogKey(keyData);

        }

    }
}
