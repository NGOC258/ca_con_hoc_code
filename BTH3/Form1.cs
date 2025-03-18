using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PheptinhTrenPS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            lbDau.Text = btnCong.Text;
            LopPhanSo ps1, ps2;
            try
            {
                ps1 = new LopPhanSo(int.Parse(txtTu1.Text), int.Parse(txtMau1.Text));
                ps2 = new LopPhanSo(int.Parse(txtTu2.Text), int.Parse(txtMau2.Text));
                LopPhanSo kq = ps1.Cong(ps2);
                txtTu3.Text = kq.Tuso.ToString();
                txtMau3.Text = kq.Mauso.ToString();
            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            lbDau.Text = btnTru.Text;
            LopPhanSo ps1, ps2;
            try
            {
                ps1 = new LopPhanSo(int.Parse(txtTu1.Text), int.Parse(txtMau1.Text));
                ps2 = new LopPhanSo(int.Parse(txtTu2.Text), int.Parse(txtMau2.Text));
                LopPhanSo kq = ps1.Tru(ps2);
                txtTu3.Text = kq.Tuso.ToString();
                txtMau3.Text = kq.Mauso.ToString();
            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            lbDau.Text = btnNhan.Text;
            LopPhanSo ps1, ps2;
            try
            {
                ps1 = new LopPhanSo(int.Parse(txtTu1.Text), int.Parse(txtMau1.Text));
                ps2 = new LopPhanSo(int.Parse(txtTu2.Text), int.Parse(txtMau2.Text));
                LopPhanSo kq = ps1.Nhan(ps2);
                txtTu3.Text = kq.Tuso.ToString();
                txtMau3.Text = kq.Mauso.ToString();
            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            lbDau.Text = btnChia.Text;
            LopPhanSo ps1, ps2;
            try
            {
                ps1 = new LopPhanSo(int.Parse(txtTu1.Text), int.Parse(txtMau1.Text));
                ps2 = new LopPhanSo(int.Parse(txtTu2.Text), int.Parse(txtMau2.Text));
                LopPhanSo kq = ps1.Chia(ps2);
                txtTu3.Text = kq.Tuso.ToString();
                txtMau3.Text = kq.Mauso.ToString();
            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTu1.Clear();
            txtMau1.Clear();    
            txtTu2.Clear();                 
            txtMau2.Clear();
            txtTu3.Clear();
            txtMau3.Clear();
                

        }
    }
}
