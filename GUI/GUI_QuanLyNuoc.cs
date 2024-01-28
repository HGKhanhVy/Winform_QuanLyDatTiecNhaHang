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
    public partial class GUI_QuanLyNuoc : UserControl
    {
        BLL_LoaiNuoc bllloainuoc = new BLL_LoaiNuoc();
        BLL_Nuoc bllnuoc = new BLL_Nuoc();

        string tenhinhanh;

        int luachonloainuoc = 0;
        int luachonnuoc = 0;

        public GUI_QuanLyNuoc()
        {
            InitializeComponent();
        }
        private void GUI_QuanLyNuoc_Load(object sender, EventArgs e)
        {
            LayDanhSachLoaiNuoc();
            LayDanhSachNuoc();

            LoadComboBoxLoaiNuoc();

            LamMoiLoaiNuoc();
            LamMoiNuoc();
        }

        private void LayDanhSachLoaiNuoc()
        {
            dataGridViewLoaiNuoc.DataSource = bllloainuoc.GetAll();
        }

        private void LayDanhSachNuoc()
        {
            dataGridViewNuoc.DataSource = bllnuoc.GetAll();
        }

        private void LoadComboBoxLoaiNuoc()
        {
            cboMaLoaiNuoc.Items.Clear();
            List<DTO_LoaiNuoc> ds = bllloainuoc.GetAll();

            foreach (DTO_LoaiNuoc d in ds)
            {
                cboMaLoaiNuoc.Items.Add(d.MaLoaiNuoc);
            }
        }

        private void LamMoiLoaiNuoc()
        {
            txtMaLoaiNuoc.Enabled = false;
            txtTenLoaiNuoc.Enabled = false;

            txtMaLoaiNuoc.Text = "";
            txtTenLoaiNuoc.Text = "";

            btnThemLoaiNuoc.Enabled = true;
            btnXoaLoaiNuoc.Enabled = true;
            btnSuaLoaiNuoc.Enabled = true;
            btnLuuLoaiNuoc.Enabled = false;
            btnHuyLoaiNuoc.Enabled = false;
        }

        private void ThemLoaiNuoc()
        {
            if (txtMaLoaiNuoc.Text.Trim().Equals("") || txtTenLoaiNuoc.Text.Trim().Equals(""))
            {
                MessageBox.Show("Thông tin không được để trống!");
            }
            else
            {
                if (bllloainuoc.GetByID(txtMaLoaiNuoc.Text.Trim()) != null)
                {
                    MessageBox.Show("Mã loại nước đã tồn tại!");
                }
                else
                {
                    DTO_LoaiNuoc dto = new DTO_LoaiNuoc();
                    dto.MaLoaiNuoc = txtMaLoaiNuoc.Text.Trim();
                    dto.TenLoaiNuoc = txtTenLoaiNuoc.Text.Trim();

                    bllloainuoc.Add(dto);

                    MessageBox.Show("Thêm thành công.");

                    LamMoiLoaiNuoc();
                    LayDanhSachLoaiNuoc();
                    LoadComboBoxLoaiNuoc();
                    luachonloainuoc = 0;
                }
            }
        }

        private void XoaLoaiNuoc()
        {
            if (txtMaLoaiNuoc.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mã loại nước không được để trống!");
            }
            else
            {
                if (bllloainuoc.GetByID(txtMaLoaiNuoc.Text.Trim()) != null)
                {
                    bllloainuoc.Delete(txtMaLoaiNuoc.Text.Trim());

                    MessageBox.Show("Xóa thành công.");

                    LamMoiLoaiNuoc();
                    LayDanhSachLoaiNuoc();
                    LoadComboBoxLoaiNuoc();
                    luachonloainuoc = 0;
                }
                else
                {
                    MessageBox.Show("Mã loại nước không tồn tại");
                }
            }
        }

        private void SuaLoaiNuoc()
        {
            if (txtMaLoaiNuoc.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mã loại nước không được để trống!");
            }
            else
            {
                if (bllloainuoc.GetByID(txtMaLoaiNuoc.Text.Trim()) != null)
                {
                    DTO_LoaiNuoc dto = new DTO_LoaiNuoc();
                    dto.MaLoaiNuoc = txtMaLoaiNuoc.Text.Trim();
                    dto.TenLoaiNuoc = txtTenLoaiNuoc.Text.Trim();

                    bllloainuoc.Update(dto);

                    MessageBox.Show("Sửa thành công.");

                    LamMoiLoaiNuoc();
                    LayDanhSachLoaiNuoc();
                    LoadComboBoxLoaiNuoc();
                    luachonloainuoc = 0;
                }
                else
                {
                    MessageBox.Show("Mã loại nước không tồn tại");
                }
            }
        }

        private void btnThemLoaiNuoc_Click(object sender, EventArgs e)
        {
            txtMaLoaiNuoc.Enabled = true;
            txtTenLoaiNuoc.Enabled = true;

            btnThemLoaiNuoc.Enabled = false;
            btnXoaLoaiNuoc.Enabled = false;
            btnSuaLoaiNuoc.Enabled = false;
            btnLuuLoaiNuoc.Enabled = true;
            btnHuyLoaiNuoc.Enabled = true;

            luachonloainuoc = 1;
        }

        private void btnXoaLoaiNuoc_Click(object sender, EventArgs e)
        {
            txtMaLoaiNuoc.Enabled = true;
            txtTenLoaiNuoc.Enabled = false;

            btnThemLoaiNuoc.Enabled = false;
            btnXoaLoaiNuoc.Enabled = false;
            btnSuaLoaiNuoc.Enabled = false;
            btnLuuLoaiNuoc.Enabled = true;
            btnHuyLoaiNuoc.Enabled = true;

            luachonloainuoc = 2;
        }

        private void btnSuaLoaiNuoc_Click(object sender, EventArgs e)
        {
            txtMaLoaiNuoc.Enabled = true;
            txtTenLoaiNuoc.Enabled = true;

            btnThemLoaiNuoc.Enabled = false;
            btnXoaLoaiNuoc.Enabled = false;
            btnSuaLoaiNuoc.Enabled = false;
            btnLuuLoaiNuoc.Enabled = true;
            btnHuyLoaiNuoc.Enabled = true;

            luachonloainuoc = 3;
        }

        private void btnLuuLoaiNuoc_Click(object sender, EventArgs e)
        {
            if (luachonloainuoc == 1)
            {
                ThemLoaiNuoc();
            }
            if (luachonloainuoc == 2)
            {
                XoaLoaiNuoc();
            }
            if (luachonloainuoc == 3)
            {
                SuaLoaiNuoc();
            }
        }

        private void btnHuyLoaiNuoc_Click(object sender, EventArgs e)
        {
            LamMoiLoaiNuoc();
            luachonloainuoc = 0;
        }

        private void LamMoiNuoc()
        {
            txtMaNuoc.Enabled = false;
            txtTenNuoc.Enabled = false;
            txtDVT.Enabled = false;
            btnChonAnh.Enabled = false;
            txtDonGia.Enabled = false;
            cboMaLoaiNuoc.Enabled = false;

            txtMaNuoc.Text = "";
            txtTenNuoc.Text = "";
            txtDVT.Text = "";
            pictureBoxHinhAnh.Image = null;
            txtDonGia.Text = "";
            cboMaLoaiNuoc.Text = "";

            tenhinhanh = "";

            btnThemNuoc.Enabled = true;
            btnXoaNuoc.Enabled = true;
            btnSuaNuoc.Enabled = true;
            btnLuuNuoc.Enabled = false;
            btnHuyNuoc.Enabled = false;
        }

        private void ThemNuoc()
        {
            if (txtMaNuoc.Text.Trim().Equals("") || txtTenNuoc.Text.Trim().Equals("") || txtDVT.Text.Trim().Equals("") || txtDonGia.Text.Trim().Equals("") || cboMaLoaiNuoc.Text.Equals(""))
            {
                MessageBox.Show("Thông tin không được để trống!");
            }
            else
            {
                if (bllnuoc.GetByID(txtMaNuoc.Text.Trim()) != null)
                {
                    MessageBox.Show("Mã nước đã tồn tại!");
                }
                else
                {
                    DTO_Nuoc dto = new DTO_Nuoc();
                    dto.MaNuoc = txtMaNuoc.Text.Trim();
                    dto.TenNuoc = txtTenNuoc.Text.Trim();
                    dto.DVT = txtDVT.Text.Trim();
                    dto.HinhAnh = tenhinhanh;
                    dto.DonGia = float.Parse(txtDonGia.Text.Trim());
                    dto.MaLoaiNuoc = cboMaLoaiNuoc.Text;

                    bllnuoc.Add(dto);

                    MessageBox.Show("Thêm thành công.");

                    LamMoiNuoc();
                    LayDanhSachNuoc();
                    LamMoiNuoc();
                    luachonnuoc = 0;
                }
            }
        }

        private void XoaNuoc()
        {
            if (txtMaNuoc.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mã nước không được để trống!");
            }
            else
            {
                if (bllnuoc.GetByID(txtMaNuoc.Text.Trim()) != null)
                {
                    bllnuoc.Delete(txtMaNuoc.Text.Trim());

                    MessageBox.Show("Xóa thành công.");

                    LamMoiNuoc();
                    LayDanhSachNuoc();
                    LamMoiNuoc();
                    luachonnuoc = 0;
                }
                else
                {
                    MessageBox.Show("Mã nước không tồn tại!");
                }
            }
        }

        private void SuaNuoc()
        {
            if (txtMaNuoc.Text.Trim().Equals("") || txtTenNuoc.Text.Trim().Equals("") || txtDVT.Text.Trim().Equals("") || txtDonGia.Text.Trim().Equals("") || cboMaLoaiNuoc.Text.Equals(""))
            {
                MessageBox.Show("Thông tin không được để trống!");
            }
            else
            {
                if (bllnuoc.GetByID(txtMaNuoc.Text.Trim()) != null)
                {
                    DTO_Nuoc dto = new DTO_Nuoc();
                    dto.MaNuoc = txtMaNuoc.Text.Trim();
                    dto.TenNuoc = txtTenNuoc.Text.Trim();
                    dto.DVT = txtDVT.Text.Trim();
                    dto.HinhAnh = tenhinhanh;
                    dto.DonGia = float.Parse(txtDonGia.Text.Trim());
                    dto.MaLoaiNuoc = cboMaLoaiNuoc.Text;

                    bllnuoc.Update(dto);

                    MessageBox.Show("Sửa thành công.");

                    LamMoiNuoc();
                    LayDanhSachNuoc();
                    LamMoiNuoc();
                    luachonnuoc = 0;
                }
                else
                {

                    MessageBox.Show("Mã nước không tồn tại!");
                }
            }
        }

        private void btnThemNuoc_Click(object sender, EventArgs e)
        {
            txtMaNuoc.Enabled = true;
            txtTenNuoc.Enabled = true;
            txtDVT.Enabled = true;
            btnChonAnh.Enabled = true;
            txtDonGia.Enabled = true;
            cboMaLoaiNuoc.Enabled = true;

            btnThemNuoc.Enabled = false;
            btnXoaNuoc.Enabled = false;
            btnSuaNuoc.Enabled = false;
            btnLuuNuoc.Enabled = true;
            btnHuyNuoc.Enabled = true;

            luachonnuoc = 1;
        }

        private void btnXoaNuoc_Click(object sender, EventArgs e)
        {
            txtMaNuoc.Enabled = true;
            txtTenNuoc.Enabled = false;
            txtDVT.Enabled = false;
            btnChonAnh.Enabled = false;
            txtDonGia.Enabled = false;
            cboMaLoaiNuoc.Enabled = false;

            btnThemNuoc.Enabled = false;
            btnXoaNuoc.Enabled = false;
            btnSuaNuoc.Enabled = false;
            btnLuuNuoc.Enabled = true;
            btnHuyNuoc.Enabled = true;

            luachonnuoc = 2;
        }

        private void btnSuaNuoc_Click(object sender, EventArgs e)
        {
            txtMaNuoc.Enabled = true;
            txtTenNuoc.Enabled = true;
            txtDVT.Enabled = true;
            btnChonAnh.Enabled = true;
            txtDonGia.Enabled = true;
            cboMaLoaiNuoc.Enabled = true;

            btnThemNuoc.Enabled = false;
            btnXoaNuoc.Enabled = false;
            btnSuaNuoc.Enabled = false;
            btnLuuNuoc.Enabled = true;
            btnHuyNuoc.Enabled = true;

            luachonnuoc = 3;
        }

        private void btnLuuNuoc_Click(object sender, EventArgs e)
        {
            if (luachonnuoc == 1)
            {
                ThemNuoc();
            }
            if (luachonnuoc == 2)
            {
                XoaNuoc();
            }
            if (luachonnuoc == 3)
            {
                SuaNuoc();
            }
        }

        private void btnHuyNuoc_Click(object sender, EventArgs e)
        {
            LamMoiNuoc();
            luachonnuoc = 0;
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
                    string targetFolderPath = Path.Combine(projectDirectory, "HinhAnh", "Nuoc");

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

        private void dataGridViewLoaiNuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewLoaiNuoc.Rows[e.RowIndex];

                txtMaLoaiNuoc.Text = row.Cells["MaLoaiNuoc"].Value.ToString();
                txtTenLoaiNuoc.Text = row.Cells["TenLoaiNuoc"].Value.ToString();
            }
        }

        private void dataGridViewNuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewNuoc.Rows[e.RowIndex];

                txtMaNuoc.Text = row.Cells["MaNuoc"].Value.ToString();
                txtTenNuoc.Text = row.Cells["TenNuoc"].Value.ToString();
                txtDVT.Text = row.Cells["DVT"].Value.ToString();

                tenhinhanh = row.Cells["HinhAnh"].Value?.ToString();

                string projectDirectory = Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.Parent.FullName;
                string targetFolderPath = Path.Combine(projectDirectory, "HinhAnh", "Nuoc");

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

                cboMaLoaiNuoc.Text = row.Cells["MaLoaiNuoc"].Value.ToString();
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