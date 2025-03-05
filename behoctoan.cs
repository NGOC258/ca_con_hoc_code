using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTHoctoan
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        string[] arrphepToan = { "+", "-", "*", ":" };
        int viTri =0;
        public Form1()
        {
            InitializeComponent();
        }
        private void taoPhepToan()
        {
            int a = 0;
            int b = 0;
            do
            {

                a = rand.Next(10);
                b = rand.Next(10);
                viTri = rand.Next(4);
            } while (b == 0 && viTri ==3);
            lbS1.Text = a.ToString();
            lbS2.Text = b.ToString();
            lbToantu.Text = arrphepToan[viTri];
            txtTraLoi.Text = " ";
            txtTraLoi.Focus();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            taoPhepToan();
        }

        private void btTiepTuc_Click(object sender, EventArgs e)
        {
            taoPhepToan();
        }

        private void btXem_Click(object sender, EventArgs e)
        {
            int a = int.Parse(lbS1.Text);
            int b = int.Parse(lbS2.Text);
            
            int dapAn = 0;
            switch (viTri)
            {
                case 0:
                    dapAn = a + b; break;
                case 1:
                    dapAn = a - b; break;
                case 2:
                    dapAn = a * b; break;
                case 3: 
                    dapAn= a / b ; break; 
            }
            try
            {
                //Nam trong try chu k nam ngoai
                int soChon = int.Parse(txtTraLoi.Text);
                if (soChon == dapAn)
                    lbKq.Text = " That's Right!!!";
                else
                    lbKq.Text = "That's Wrong! Result : " + dapAn.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("ban phai nhap so!");
            }
            
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            Button bt = (Button) sender;
            txtTraLoi.Text += bt.Text;
        }

        private void btDau_Click(object sender, EventArgs e)
        {
            if (txtTraLoi.Text!= " ")return;
            txtTraLoi.Text = "-";
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (txtTraLoi.Text == " ") return;
            txtTraLoi.Text = txtTraLoi.Text.Substring(0,txtTraLoi.Text.Length-1);
        }
    }
}
