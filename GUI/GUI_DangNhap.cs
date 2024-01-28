using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class GUI_DangNhap : Form
    {
        BLL_NguoiDung bll = new BLL_NguoiDung();

        public GUI_DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.Text.Trim().Equals("") || txtTenDangNhap.Text.Trim().Equals(""))
            {
                MessageBox.Show("Nhập đầy đủ thông tin!");
            }
            else
            {
                DTO_NguoiDung dto = bll.GetByUserAndPass(txtTenDangNhap.Text.Trim(), txtMatKhau.Text.Trim());
                if (dto == null)
                {
                    MessageBox.Show("Tài khoản không tồn tại!");
                }
                else
                {
                    GUI_KhungTrangQuanLy gui = new GUI_KhungTrangQuanLy(dto.userName, dto.hoTen);
                    gui.FormClosing += Gui_FormClosing;
                    gui.Show();
                    this.Hide();
                }
            }
        }

        private void Gui_FormClosing(object? sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
