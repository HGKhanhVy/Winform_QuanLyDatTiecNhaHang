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
    public partial class GUI_QuanLyMonAn : UserControl
    {
        BLL_LoaiMonAn bllloaimonan = new BLL_LoaiMonAn();
        BLL_MonAn bllmonan = new BLL_MonAn();

        string tenhinhanh;

        int luachonloaimonan = 0;
        int luachonmonan = 0;

        public GUI_QuanLyMonAn()
        {
            InitializeComponent();
        }
        private void GUI_QuanLyMonAn_Load(object sender, EventArgs e)
        {
            LayDanhSachLoaiMonAn();
            LayDanhSachMonAn();

            LoadComboBoxLoaiMonAn();

            LamMoiLoaiMonAn();
            LamMoiMonAn();
        }

        private void LayDanhSachLoaiMonAn()
        {
            dataGridViewLoaiMonAn.DataSource = bllloaimonan.GetAll();
        }

        private void LayDanhSachMonAn()
        {
            dataGridViewMonAn.DataSource = bllmonan.GetAll();
        }

        private void LoadComboBoxLoaiMonAn()
        {
            cboMaLoaiMonAn.Items.Clear();
            List<DTO_LoaiMonAn> ds = bllloaimonan.GetAll();

            foreach (DTO_LoaiMonAn d in ds)
            {
                cboMaLoaiMonAn.Items.Add(d.MaLoaiMonAn);
            }
        }

        private void LamMoiLoaiMonAn()
        {
            txtMaLoaiMonAn.Enabled = false;
            txtTenLoaiMonAn.Enabled = false;

            txtMaLoaiMonAn.Text = "";
            txtTenLoaiMonAn.Text = "";

            btnThemLoaiMonAn.Enabled = true;
            btnXoaLoaiMonAn.Enabled = true;
            btnSuaLoaiMonAn.Enabled = true;
            btnLuuLoaiMonAn.Enabled = false;
            btnHuyLoaiMonAn.Enabled = false;
        }

        private void ThemLoaiMonAn()
        {
            if (txtMaLoaiMonAn.Text.Trim().Equals("") || txtTenLoaiMonAn.Text.Trim().Equals(""))
            {
                MessageBox.Show("Thông tin không được để trống!");
            }
            else
            {
                if (bllloaimonan.GetByID(txtMaLoaiMonAn.Text.Trim()) != null)
                {
                    MessageBox.Show("Mã loại món ăn đã tồn tại!");
                }
                else
                {
                    DTO_LoaiMonAn dto = new DTO_LoaiMonAn();
                    dto.MaLoaiMonAn = txtMaLoaiMonAn.Text.Trim();
                    dto.TenLoaiMonAn = txtTenLoaiMonAn.Text.Trim();

                    bllloaimonan.Add(dto);

                    MessageBox.Show("Thêm thành công.");

                    LamMoiLoaiMonAn();
                    LayDanhSachLoaiMonAn();
                    LoadComboBoxLoaiMonAn();
                    luachonloaimonan = 0;
                }
            }
        }

        private void XoaLoaiMonAn()
        {
            if (txtMaLoaiMonAn.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mã loại món ăn không được để trống!");
            }
            else
            {
                if (bllloaimonan.GetByID(txtMaLoaiMonAn.Text.Trim()) != null)
                {
                    bllloaimonan.Delete(txtMaLoaiMonAn.Text.Trim());

                    MessageBox.Show("Xóa thành công.");

                    LamMoiLoaiMonAn();
                    LayDanhSachLoaiMonAn();
                    LoadComboBoxLoaiMonAn();
                    luachonloaimonan = 0;
                }
                else
                {
                    MessageBox.Show("Mã loại món ăn không tồn tại");
                }
            }
        }

        private void SuaLoaiNuoc()
        {
            if (txtMaLoaiMonAn.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mã loại món ăn không được để trống!");
            }
            else
            {
                if (bllloaimonan.GetByID(txtMaLoaiMonAn.Text.Trim()) != null)
                {
                    DTO_LoaiMonAn dto = new DTO_LoaiMonAn();
                    dto.MaLoaiMonAn = txtMaLoaiMonAn.Text.Trim();
                    dto.TenLoaiMonAn = txtTenLoaiMonAn.Text.Trim();

                    bllloaimonan.Update(dto);

                    MessageBox.Show("Sửa thành công.");

                    LamMoiLoaiMonAn();
                    LayDanhSachLoaiMonAn();
                    LoadComboBoxLoaiMonAn();
                    luachonloaimonan = 0;
                }
                else
                {
                    MessageBox.Show("Mã loại món ăn không tồn tại");
                }
            }
        }

        private void btnThemLoaiMonAn_Click(object sender, EventArgs e)
        {
            txtMaLoaiMonAn.Enabled = true;
            txtTenLoaiMonAn.Enabled = true;

            btnThemLoaiMonAn.Enabled = false;
            btnXoaLoaiMonAn.Enabled = false;
            btnSuaLoaiMonAn.Enabled = false;
            btnLuuLoaiMonAn.Enabled = true;
            btnHuyLoaiMonAn.Enabled = true;

            luachonloaimonan = 1;
        }

        private void btnXoaLoaiMonAn_Click(object sender, EventArgs e)
        {
            txtMaLoaiMonAn.Enabled = true;
            txtTenLoaiMonAn.Enabled = false;

            btnThemLoaiMonAn.Enabled = false;
            btnXoaLoaiMonAn.Enabled = false;
            btnSuaLoaiMonAn.Enabled = false;
            btnLuuLoaiMonAn.Enabled = true;
            btnHuyLoaiMonAn.Enabled = true;

            luachonloaimonan = 2;
        }

        private void btnSuaLoaiMonAn_Click(object sender, EventArgs e)
        {
            txtMaLoaiMonAn.Enabled = true;
            txtTenLoaiMonAn.Enabled = true;

            btnThemLoaiMonAn.Enabled = false;
            btnXoaLoaiMonAn.Enabled = false;
            btnSuaLoaiMonAn.Enabled = false;
            btnLuuLoaiMonAn.Enabled = true;
            btnHuyLoaiMonAn.Enabled = true;

            luachonloaimonan = 3;
        }

        private void btnLuuLoaiMonAn_Click(object sender, EventArgs e)
        {
            if (luachonloaimonan == 1)
            {
                ThemLoaiMonAn();
            }
            if (luachonloaimonan == 2)
            {
                XoaLoaiMonAn();
            }
            if (luachonloaimonan == 3)
            {
                SuaLoaiNuoc();
            }
        }

        private void btnHuyLoaiMonAn_Click(object sender, EventArgs e)
        {
            LamMoiLoaiMonAn();
            luachonloaimonan = 0;
        }

        private void LamMoiMonAn()
        {
            txtMaMonAn.Enabled = false;
            txtTenMonAn.Enabled = false;
            txtDVT.Enabled = false;
            btnChonAnh.Enabled = false;
            txtDonGia.Enabled = false;
            cboMaLoaiMonAn.Enabled = false;

            txtMaMonAn.Text = "";
            txtTenMonAn.Text = "";
            txtDVT.Text = "";
            pictureBoxHinhAnh.Image = null;
            txtDonGia.Text = "";
            cboMaLoaiMonAn.Text = "";

            tenhinhanh = "";

            btnThemMonAn.Enabled = true;
            btnXoaMonAn.Enabled = true;
            btnSuaMonAn.Enabled = true;
            btnLuuMonAn.Enabled = false;
            btnHuyMonAn.Enabled = false;
        }

        private void ThemMonAn()
        {
            if (txtMaMonAn.Text.Trim().Equals("") || txtTenMonAn.Text.Trim().Equals("") || txtDVT.Text.Trim().Equals("") || txtDonGia.Text.Trim().Equals("") || cboMaLoaiMonAn.Text.Equals(""))
            {
                MessageBox.Show("Thông tin không được để trống!");
            }
            else
            {
                if (bllmonan.GetByID(txtMaMonAn.Text.Trim()) != null)
                {
                    MessageBox.Show("Mã món ăn đã tồn tại!");
                }
                else
                {
                    DTO_MonAn dto = new DTO_MonAn();
                    dto.MaMonAn = txtMaMonAn.Text.Trim();
                    dto.TenMonAn = txtTenMonAn.Text.Trim();
                    dto.DVT = txtDVT.Text.Trim();
                    dto.HinhAnh = tenhinhanh;
                    dto.DonGia = float.Parse(txtDonGia.Text.Trim());
                    dto.MaLoaiMonAn = cboMaLoaiMonAn.Text;

                    bllmonan.Add(dto);

                    MessageBox.Show("Thêm thành công.");

                    LamMoiMonAn();
                    LayDanhSachMonAn();
                    LamMoiMonAn();
                    luachonmonan = 0;
                }
            }
        }

        private void XoaMonAn()
        {
            if (txtMaMonAn.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mã món ăn không được để trống!");
            }
            else
            {
                if (bllmonan.GetByID(txtMaMonAn.Text.Trim()) != null)
                {
                    bllmonan.Delete(txtMaMonAn.Text.Trim());

                    MessageBox.Show("Xóa thành công.");

                    LamMoiMonAn();
                    LayDanhSachMonAn();
                    LamMoiMonAn();
                    luachonmonan = 0;
                }
                else
                {
                    MessageBox.Show("Mã món ăn không tồn tại!");
                }
            }
        }

        private void SuaMonAn()
        {
            if (txtMaMonAn.Text.Trim().Equals("") || txtTenMonAn.Text.Trim().Equals("") || txtDVT.Text.Trim().Equals("") || txtDonGia.Text.Trim().Equals("") || cboMaLoaiMonAn.Text.Equals(""))
            {
                MessageBox.Show("Thông tin không được để trống!");
            }
            else
            {
                if (bllmonan.GetByID(txtMaMonAn.Text.Trim()) != null)
                {
                    DTO_MonAn dto = new DTO_MonAn();
                    dto.MaMonAn = txtMaMonAn.Text.Trim();
                    dto.TenMonAn = txtTenMonAn.Text.Trim();
                    dto.DVT = txtDVT.Text.Trim();
                    dto.HinhAnh = tenhinhanh;
                    dto.DonGia = float.Parse(txtDonGia.Text.Trim());
                    dto.MaLoaiMonAn = cboMaLoaiMonAn.Text;

                    bllmonan.Update(dto);

                    MessageBox.Show("Sửa thành công.");

                    LamMoiMonAn();
                    LayDanhSachMonAn();
                    LamMoiMonAn();
                    luachonmonan = 0;
                }
                else
                {

                    MessageBox.Show("Mã món ăn không tồn tại!");
                }
            }
        }

        private void btnThemMonAn_Click(object sender, EventArgs e)
        {
            txtMaMonAn.Enabled = true;
            txtTenMonAn.Enabled = true;
            txtDVT.Enabled = true;
            btnChonAnh.Enabled = true;
            txtDonGia.Enabled = true;
            cboMaLoaiMonAn.Enabled = true;

            btnThemMonAn.Enabled = false;
            btnXoaMonAn.Enabled = false;
            btnSuaMonAn.Enabled = false;
            btnLuuMonAn.Enabled = true;
            btnHuyMonAn.Enabled = true;

            luachonmonan = 1;
        }

        private void btnXoaMonAn_Click(object sender, EventArgs e)
        {
            txtMaMonAn.Enabled = true;
            txtTenMonAn.Enabled = false;
            txtDVT.Enabled = false;
            btnChonAnh.Enabled = false;
            txtDonGia.Enabled = false;
            cboMaLoaiMonAn.Enabled = false;

            btnThemMonAn.Enabled = false;
            btnXoaMonAn.Enabled = false;
            btnSuaMonAn.Enabled = false;
            btnLuuMonAn.Enabled = true;
            btnHuyMonAn.Enabled = true;

            luachonmonan = 2;
        }

        private void btnSuaMonAn_Click(object sender, EventArgs e)
        {
            txtMaMonAn.Enabled = true;
            txtTenMonAn.Enabled = true;
            txtDVT.Enabled = true;
            btnChonAnh.Enabled = true;
            txtDonGia.Enabled = true;
            cboMaLoaiMonAn.Enabled = true;

            btnThemMonAn.Enabled = false;
            btnXoaMonAn.Enabled = false;
            btnSuaMonAn.Enabled = false;
            btnLuuMonAn.Enabled = true;
            btnHuyMonAn.Enabled = true;

            luachonmonan = 3;
        }

        private void btnLuuMonAn_Click(object sender, EventArgs e)
        {
            if (luachonmonan == 1)
            {
                ThemMonAn();
            }
            if (luachonmonan == 2)
            {
                XoaMonAn();
            }
            if (luachonmonan == 3)
            {
                SuaMonAn();
            }
        }

        private void btnHuyMonAn_Click(object sender, EventArgs e)
        {
            LamMoiMonAn();
            luachonmonan = 0;
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedImagePath = openFileDialog.FileName;

                    // Đường dẫn thư mục trong dự án
                    string projectDirectory = Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.Parent.FullName;
                    string targetFolderPath = Path.Combine(projectDirectory, "HinhAnh", "MonAn");

                    // Kiểm tra và tạo thư mục nếu chưa tồn tại
                    if (!Directory.Exists(targetFolderPath))
                    {
                        Directory.CreateDirectory(targetFolderPath);
                    }

                    // Tạo đường dẫn đến thư mục đích
                    string targetFileName = Path.GetFileName(selectedImagePath);
                    string targetFilePath = Path.Combine(targetFolderPath, targetFileName);

                    // Copy hình ảnh vào thư mục đích
                    File.Copy(selectedImagePath, targetFilePath, true);

                    // Lấy tên của hình ảnh trong thư mục đích;
                    tenhinhanh = targetFileName;

                    // Hiển thị hình ảnh trong PictureBox
                    pictureBoxHinhAnh.Image = Image.FromFile(targetFilePath);
                }
            }
        }

        private void dataGridViewLoaiMonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewLoaiMonAn.Rows[e.RowIndex];

                txtMaLoaiMonAn.Text = row.Cells["MaLoaiMonAn"].Value.ToString();
                txtTenLoaiMonAn.Text = row.Cells["TenLoaiMonAn"].Value.ToString();
            }
        }

        private void dataGridViewMonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewMonAn.Rows[e.RowIndex];

                txtMaMonAn.Text = row.Cells["MaMonAn"].Value.ToString();
                txtTenMonAn.Text = row.Cells["TenMonAn"].Value.ToString();
                txtDVT.Text = row.Cells["DVT"].Value.ToString();
                tenhinhanh = row.Cells["HinhAnh"].Value?.ToString();

                string projectDirectory = Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.Parent.FullName;
                string targetFolderPath = Path.Combine(projectDirectory, "HinhAnh", "MonAn");

                if (!string.IsNullOrEmpty(tenhinhanh))
                {
                    try
                    {
                        string targetFilePath = Path.Combine(targetFolderPath, tenhinhanh);
                        pictureBoxHinhAnh.Image = Image.FromFile(targetFilePath);
                    }
                    catch (Exception ex)
                    {
                        pictureBoxHinhAnh.Image = Properties.Resources.anhkhongtontai;
                    }
                }
                else
                {
                    pictureBoxHinhAnh.Image = Properties.Resources.anhkhongtontai;
                }

                txtDonGia.Text = row.Cells["DonGia"].Value.ToString();

                cboMaLoaiMonAn.Text = row.Cells["MaLoaiMonAn"].Value.ToString();
            }
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
