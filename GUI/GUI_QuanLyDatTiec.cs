using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class GUI_QuanLyDatTiec : UserControl
    {
        BLL_DatTiec bll = new BLL_DatTiec();

        int luachon = 0;
        public GUI_QuanLyDatTiec()
        {
            InitializeComponent();
        }

        private void LoadDanhSach()
        {
            dataGridView1.DataSource = bll.GetAll();
        }

        private void LamMoi()
        {
            txtMaTiec.Text = "";
            txtLoaiHinhTiec.Text = "";
            dateTimePickerNgayDatTiec.Value = DateTime.Now;
            txtNgayToChuc.Text = "";
            txtThoiGianToChuc.Text = "";
            txtSoLuongBanChinhThuc.Text = "";
            txtSoLuongBanTang.Text = "";
            txtSoLuongBanChay.Text = "";
            txtSoLuongBanDuPhong.Text = "";
            txtTongBanSetup.Text = "";
            txtLoaiBan.Text = "";
            txtPhiDichVu.Text = "";
            txtTongTienDuKien.Text = "";
            txtTongTienGiam.Text = "";
            txtTongTienPhaiTra.Text = "";
            txtTienCocLan1.Text = "";
            txtTienCocLan2.Text = "";
            txtGhiChu.Text = "";
            txtMaKhachHang.Text = "";
            txtTrangThai.Text = "";

            txtMaTiec.Enabled = false;
            txtLoaiHinhTiec.Enabled = false;
            dateTimePickerNgayDatTiec.Enabled = false;
            txtNgayToChuc.Enabled = false;
            txtThoiGianToChuc.Enabled = false;
            txtSoLuongBanChinhThuc.Enabled = false;
            txtSoLuongBanTang.Enabled = false;
            txtSoLuongBanChay.Enabled = false;
            txtSoLuongBanDuPhong.Enabled = false;
            txtTongBanSetup.Enabled = false;
            txtLoaiBan.Enabled = false;
            txtPhiDichVu.Enabled = false;
            txtTongTienDuKien.Enabled = false;
            txtTongTienGiam.Enabled = false;
            txtTongTienPhaiTra.Enabled = false;
            txtTienCocLan1.Enabled = false;
            txtTienCocLan2.Enabled = false;
            txtGhiChu.Enabled = false;
            txtMaKhachHang.Enabled = false;
            txtTrangThai.Enabled = false;

            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void xoa()
        {
            try
            {
                if (txtMaTiec.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Nhập mã tiệc!");
                }
                else
                {
                    if (bll.KiemTraID(txtMaTiec.Text.Trim()) == true)
                    {
                        bll.Delete(txtMaTiec.Text.Trim());
                        MessageBox.Show("Xóa thành công.");
                        LamMoi();
                        LoadDanhSach();
                        luachon = 0;
                    }
                    else
                    {
                        MessageBox.Show("Mã tiệc không tồn tại!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void sua()
        {
            try
            {
                if (txtMaTiec.Text.Trim().Equals("") ||
                    txtLoaiHinhTiec.Text.Trim().Equals("") ||
                    txtNgayToChuc.Text.Trim().Equals("") ||
                    txtThoiGianToChuc.Text.Trim().Equals("") ||
                    txtSoLuongBanChinhThuc.Text.Trim().Equals("") ||
                    txtSoLuongBanTang.Text.Trim().Equals("") ||
                    txtSoLuongBanChay.Text.Trim().Equals("") ||
                    txtSoLuongBanDuPhong.Text.Trim().Equals("") ||
                    txtTongBanSetup.Text.Trim().Equals("") ||
                    txtLoaiBan.Text.Trim().Equals("") ||
                    txtPhiDichVu.Text.Trim().Equals("") ||
                    txtTongTienDuKien.Text.Trim().Equals("") ||
                    txtTongTienGiam.Text.Trim().Equals("") ||
                    txtTongTienPhaiTra.Text.Trim().Equals("") ||
                    txtTienCocLan1.Text.Trim().Equals("") ||
                    txtTienCocLan2.Text.Trim().Equals("") ||
                    txtGhiChu.Text.Trim().Equals("") ||
                    txtMaKhachHang.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Nhập đầy đủ thông tin tiệc!");
                }
                else
                {
                    if (bll.KiemTraID(txtMaTiec.Text.Trim()) == true)
                    {
                        DTO_DatTiec dto = new DTO_DatTiec();
                        dto.MaTiec = txtMaTiec.Text.Trim();
                        dto.LoaiHinhTiec = txtLoaiHinhTiec.Text.Trim();
                        dto.NgayDatTiec = dateTimePickerNgayDatTiec.Value;
                        dto.NgayToChuc = txtNgayToChuc.Text.Trim();
                        dto.ThoiGianToChuc = txtThoiGianToChuc.Text.Trim();
                        dto.SoLuongBanChinhThuc = int.Parse(txtSoLuongBanChinhThuc.Text.Trim());
                        dto.SoLuongBanTang = int.Parse(txtSoLuongBanTang.Text.Trim());
                        dto.SoLuongBanChay = int.Parse(txtSoLuongBanTang.Text.Trim());
                        dto.SoLuongBanDuPhong = int.Parse(txtSoLuongBanDuPhong.Text.Trim());
                        dto.TongBanSetup = int.Parse(txtTongBanSetup.Text.Trim());
                        dto.LoaiBan = txtLoaiBan.Text.Trim();
                        dto.PhiDichVu = float.Parse(txtPhiDichVu.Text.Trim());
                        dto.TongTienDuKien = float.Parse(txtTongTienDuKien.Text.Trim());
                        dto.TongTienGiam = float.Parse(txtTongTienGiam.Text.Trim());
                        dto.TongTienPhaiTra = float.Parse(txtTongTienPhaiTra.Text.Trim());
                        dto.TienCocLan1 = float.Parse(txtTienCocLan1.Text.Trim());
                        dto.TienCocLan2 = float.Parse(txtTienCocLan2.Text.Trim());
                        dto.GhiChu = txtGhiChu.Text.Trim();
                        dto.MaKhachHang = txtMaKhachHang.Text.Trim();
                        dto.TrangThai = txtTrangThai.Text.Trim();

                        bll.Update(dto);
                        MessageBox.Show("Sửa thành công.");
                        LamMoi();
                        LoadDanhSach();
                        luachon = 0;
                    }
                    else
                    {
                        MessageBox.Show("Mã tiệc không tồn tại!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void GUI_QuanLyDatTiec_Load(object sender, EventArgs e)
        {
            LoadDanhSach();
            LamMoi();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtMaTiec.Text = row.Cells["MaTiec"].Value?.ToString();
                txtLoaiHinhTiec.Text = row.Cells["LoaiHinhTiec"].Value?.ToString();
                dateTimePickerNgayDatTiec.Value = (DateTime)row.Cells["NgayDatTiec"].Value;
                txtNgayToChuc.Text = row.Cells["NgayToChuc"].Value?.ToString();
                txtThoiGianToChuc.Text = row.Cells["ThoiGianToChuc"].Value?.ToString();
                txtSoLuongBanChinhThuc.Text = row.Cells["SoLuongBanChinhThuc"].Value?.ToString();
                txtSoLuongBanTang.Text = row.Cells["SoLuongBanTang"].Value?.ToString();
                txtSoLuongBanChay.Text = row.Cells["SoLuongBanChay"].Value?.ToString();
                txtSoLuongBanDuPhong.Text = row.Cells["SoLuongBanDuPhong"].Value?.ToString();
                txtTongBanSetup.Text = row.Cells["SoLuongBanChinhThuc"].Value?.ToString();
                txtLoaiBan.Text = row.Cells["LoaiBan"].Value?.ToString();
                txtPhiDichVu.Text = row.Cells["PhiDichVu"].Value?.ToString();
                txtTongTienDuKien.Text = row.Cells["TongTienDuKien"].Value?.ToString();
                txtTongTienGiam.Text = row.Cells["TongTienGiam"].Value?.ToString();
                txtTongTienPhaiTra.Text = row.Cells["TongTienPhaiTra"].Value?.ToString();
                txtTienCocLan1.Text = row.Cells["TienCocLan1"].Value?.ToString();
                txtTienCocLan2.Text = row.Cells["TienCocLan2"].Value?.ToString();
                txtGhiChu.Text = row.Cells["GhiChu"].Value?.ToString();
                txtMaKhachHang.Text = row.Cells["MaKhachHang"].Value?.ToString();
                txtTrangThai.Text = row.Cells["TrangThai"].Value?.ToString();
            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaTiec.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Nhập mã tiệc!");
                }
                else
                {
                    if (bll.KiemTraID(txtMaTiec.Text.Trim()) == true)
                    {
                        GUI_ChiTietDatTiec gui = new GUI_ChiTietDatTiec(txtMaTiec.Text.Trim());
                        gui.FormClosing += Gui_FormClosing;
                        gui.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Mã tiệc không tồn tại!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Gui_FormClosing(object? sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            luachon = 1;
            txtMaTiec.Enabled = true;

            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            luachon = 2;

            txtMaTiec.Enabled = true;
            txtLoaiHinhTiec.Enabled = true;
            dateTimePickerNgayDatTiec.Enabled = true;
            txtNgayToChuc.Enabled = true;
            txtThoiGianToChuc.Enabled = true;
            txtSoLuongBanChinhThuc.Enabled = true;
            txtSoLuongBanTang.Enabled = true;
            txtSoLuongBanChay.Enabled = true;
            txtSoLuongBanDuPhong.Enabled = true;
            txtTongBanSetup.Enabled = true;
            txtLoaiBan.Enabled = true;
            txtPhiDichVu.Enabled = true;
            txtTongTienDuKien.Enabled = true;
            txtTongTienGiam.Enabled = true;
            txtTongTienPhaiTra.Enabled = true;
            txtTienCocLan1.Enabled = true;
            txtTienCocLan2.Enabled = true;
            txtGhiChu.Enabled = true;
            txtMaKhachHang.Enabled = true;
            txtTrangThai.Enabled = true;

            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (luachon == 1)
            {
                xoa();
            }
            if (luachon == 2)
            {
                sua();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LamMoi();
            luachon = 0;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void txtSoLuongBanChinhThuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoLuongBanTang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoLuongBanChay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoLuongBanDuPhong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTongBanSetup_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPhiDichVu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTongTienDuKien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTongTienGiam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTongTienPhaiTra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTienCocLan1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTienCocLan2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
