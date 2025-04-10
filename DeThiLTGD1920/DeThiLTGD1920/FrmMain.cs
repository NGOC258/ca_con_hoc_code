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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            FrmDelay f = new FrmDelay();
            f.ShowDialog();
            InitializeComponent();
            
        }

        int cash = 1000;
        Random random = new Random();

        private void FrmMain_Load(object sender, EventArgs e)
        {
            
            String[] arr = { "Bầu", "Cá", "Cua", "Gà", "Nai", "Tôm" };
            cbChon.Items.AddRange(arr);
            txtCuoc.Text = "100";
            lbTien.Text = cash.ToString();
        }

        private void btQuay_Click(object sender, EventArgs e)
        {
            int tienCuoc = Convert.ToInt16(txtCuoc.Text);
            int chon = cbChon.SelectedIndex;

            if(chon < 0)
            {
                MessageBox.Show("Chưa chọn!");
                return;
            }

            if (txtCuoc.Text == "" || tienCuoc % 100 != 0 || cash < tienCuoc)
            {
                MessageBox.Show("Không hợp lệ!");
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

                if(chon != ranPic1 && chon != ranPic2 && chon != ranPic3)
                {
                    cash -= tienCuoc;
                    if(cash <= 0)
                    {
                        btQuay.Enabled = false;
                    }
                }
                else
                {
                    if (chon == ranPic1) cash += tienCuoc;
                    if (chon == ranPic2) cash += tienCuoc;
                    if (chon == ranPic3) cash += tienCuoc;
                }
                lbTien.Text = cash.ToString();
            }
            catch { }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn muốn đóng chương trình?", "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                Application.Exit();
            }
        }

        private void FrmMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }

        private void txtCuoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8)
            {

            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
