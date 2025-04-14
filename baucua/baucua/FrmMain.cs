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
    public partial class FrmMain : Form
    {
        private void label1_Click(object sender, EventArgs e)
        {

        }

        public FrmMain()
        {
            FrmDelay fm = new FrmDelay();
            fm.ShowDialog();
            InitializeComponent();
        }
        int tien = 1000;
        Random random = new Random();

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Ban muon dong chuong trinh?", "Chu y!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) 
            {
               Application.Exit();
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            String[] arr = { "Bầu", "Cá", "Cua", "Gà", "Nai", "Tôm" };
            cbChon.Items.AddRange(arr);
            lbTien.Text = tien.ToString();



        }

        private void btnQuay_Click(object sender, EventArgs e)
        {
            int tiencuoc = Convert.ToInt16(txtCuoc.Text);
            int chon = cbChon.SelectedIndex;
            if (chon < 0)
            {
                MessageBox.Show("Chưa chọn !");
            }
            if (txtCuoc.Text == "" || tiencuoc % 100 != 0 || tien < tiencuoc)
            {
                MessageBox.Show("Không hợp lệ !");
                return;

            }
            try
            {
                int ranPic1 = random.Next(0, 6);
                int ranPic2 = random.Next(0, 6);
                int ranPic3 = random.Next(0, 6);

                pic1.Image = Image.FromFile(@"Hinh\" + ranPic1.ToString() + ".jpg");
                pic2.Image = Image.FromFile(@"Hinh\" + ranPic2.ToString() + ".jpg");
                pic3.Image = Image.FromFile(@"Hinh\" + ranPic3.ToString() + ".jpg");

                if (chon != ranPic1 && chon != ranPic2 && chon != ranPic3)
                {
                    tien -= tiencuoc;
                    if (tien <= 0)
                    {
                        btnQuay.Enabled = false;
                    }
                }
                else
                {
                    if (chon == ranPic1) tien += tiencuoc;
                    if (chon == ranPic2) tien += tiencuoc;
                    if (chon == ranPic3) tien += tiencuoc;



                }
                lbTien.Text = tien.ToString();
            }

            catch { }
        }
    }
}
