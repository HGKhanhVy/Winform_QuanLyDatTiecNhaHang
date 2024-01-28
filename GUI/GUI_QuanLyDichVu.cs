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
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class GUI_QuanLyDichVu : UserControl
    {
        BLL_LoaiDichVu bll_loaidichvu = new BLL_LoaiDichVu();
        BLL_DichVu bll_dichvu = new BLL_DichVu();

        string tenhinhanh;

        int luachon = 0;
        int luachon2 = 0;
        public GUI_QuanLyDichVu()
        {
            InitializeComponent();
        }

        private void LayDanhSach()
        {
            dataGridView1.DataSource = bll_loaidichvu.GetAll();
        }

        private void LayDanhSachDichVu()
        {
            dataGridView2.DataSource = bll_dichvu.GetAll();
        }

        private void LoadComboBoxDichVu()
        {
            cboMaLoaiDichVu.Items.Clear();
            List<DTO_LoaiDichVu> ds = bll_loaidichvu.GetAll();

            foreach (DTO_LoaiDichVu d in ds)
            {
                cboMaLoaiDichVu.Items.Add(d.MaLoaiDichVu);
            }
        }

        private void Them()
        {
            if (txtMaLoaiDichVu.Text.Trim().Equals("") || txtTenLoaiDichVu.Text.Trim().Equals(""))
            {
                MessageBox.Show("Thông tin không được để trống!");
            }
            else
            {
                if (bll_loaidichvu.GetByID(txtMaLoaiDichVu.Text.Trim()) != null)
                {
                    MessageBox.Show("Mã loại dịch vụ đã tồn tại!");
                }
                else
                {
                    DTO_LoaiDichVu dto = new DTO_LoaiDichVu();
                    dto.MaLoaiDichVu = txtMaLoaiDichVu.Text.Trim();
                    dto.TenLoaiDichVu = txtTenLoaiDichVu.Text.Trim();

                    bll_loaidichvu.Add(dto);

                    MessageBox.Show("Thêm thành công.");
                    LamMoi();
                }
            }
        }

        private void Xoa()
        {
            if (txtMaLoaiDichVu.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mã loại dịch vụ không được để trống!");
            }
            else
            {
                if (bll_loaidichvu.GetByID(txtMaLoaiDichVu.Text.Trim()) != null)
                {
                    bll_loaidichvu.Delete(txtMaLoaiDichVu.Text.Trim());
                    MessageBox.Show("Xóa thành công.");
                    LamMoi();
                }
                else
                {
                    MessageBox.Show("Mã loại dịch vụ không tồn tại");
                }
            }
        }

        private void Sua()
        {
            if (txtMaLoaiDichVu.Text.Trim().Equals("") || txtTenLoaiDichVu.Text.Trim().Equals(""))
            {
                MessageBox.Show("Thông tin không được để trống!");
            }
            else
            {
                if (bll_loaidichvu.GetByID(txtMaLoaiDichVu.Text.Trim()) != null)
                {
                    DTO_LoaiDichVu dto = new DTO_LoaiDichVu();
                    dto.MaLoaiDichVu = txtMaLoaiDichVu.Text.Trim();
                    dto.TenLoaiDichVu = txtTenLoaiDichVu.Text.Trim();

                    bll_loaidichvu.Update(dto);
                    MessageBox.Show("Sửa thành công.");
                    LamMoi();
                }
                else
                {
                    MessageBox.Show("Mã loại dịch vụ không tồn tại!");
                }
            }
        }

        private void ThemDichVu()
        {
            if (txtMaDichVu.Text.Trim().Equals("") || txtTenDichVu.Text.Trim().Equals(""))
            {
                MessageBox.Show("Thông tin dịch vụ không được để trống!");
            }
            else
            {
                if (bll_dichvu.GetByID(txtMaDichVu.Text.Trim()) != null)
                {
                    MessageBox.Show("Mã dịch vụ đã tồn tại!");
                }
                else
                {
                    DTO_DichVu dto = new DTO_DichVu();
                    dto.MaDichVu = txtMaDichVu.Text.Trim();
                    dto.TenDichVu = txtTenDichVu.Text.Trim();
                    dto.HinhAnh = tenhinhanh;
                    dto.MaLoaiDichVu = cboMaLoaiDichVu.Text;
                    dto.DieuKienBanToiThieu = int.Parse(txtDieuKienBanToiThieu.Text);
                    dto.DieuKienBanToiDa = int.Parse(txtDieuKienBanToiDa.Text);
                    dto.GiaGiam30 = float.Parse(txtGiaGiam30.Text.Trim());
                    dto.GiaLe = float.Parse(txtGiaLe.Text.Trim());
                    dto.GiaTronGoi = float.Parse(txtGiaTronGoi.Text.Trim());

                    bll_dichvu.Add(dto);
                    MessageBox.Show("Thêm thành công.");
                    LamMoiDichVu();
                }
            }
        }
        private void XoaDichVu()
        {
            if (txtMaDichVu.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mã dịch vụ không được để trống!");
            }
            else
            {
                if (bll_dichvu.GetByID(txtMaDichVu.Text.Trim()) != null)
                {
                    bll_dichvu.Delete(txtMaDichVu.Text.Trim());
                    MessageBox.Show("Xóa thành công.");
                    LamMoiDichVu();
                }
                else
                {
                    MessageBox.Show("Mã dịch vụ không tồn tại");
                }
            }
        }

        private void SuaDichVu()
        {
            if (txtMaDichVu.Text.Trim().Equals("") || txtTenDichVu.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mã dịch vụ không được để trống!");
            }
            else
            {
                if (bll_dichvu.GetByID(txtMaDichVu.Text.Trim()) != null)
                {
                    DTO_DichVu dto = new DTO_DichVu();
                    dto.MaDichVu = txtMaDichVu.Text.Trim();
                    dto.TenDichVu = txtTenDichVu.Text.Trim();
                    dto.HinhAnh = tenhinhanh;
                    dto.MaLoaiDichVu = cboMaLoaiDichVu.Text;
                    dto.DieuKienBanToiThieu = int.Parse(txtDieuKienBanToiThieu.Text);
                    dto.DieuKienBanToiDa = int.Parse(txtDieuKienBanToiDa.Text);
                    dto.GiaGiam30 = float.Parse(txtGiaGiam30.Text.Trim());
                    dto.GiaLe = float.Parse(txtGiaLe.Text.Trim());
                    dto.GiaTronGoi = float.Parse(txtGiaTronGoi.Text.Trim());

                    bll_dichvu.Update(dto);

                    MessageBox.Show("Cập nhật thành công.");
                    LamMoiDichVu();
                }
                else
                {
                    MessageBox.Show("Mã dịch vụ không tồn tại");
                }
            }
        }


        private void LamMoi()
        {
            txtMaLoaiDichVu.Enabled = false;
            txtTenLoaiDichVu.Enabled = false;

            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;

            txtMaLoaiDichVu.Text = "";
            txtTenLoaiDichVu.Text = "";

            LayDanhSach();
        }

        private void LamMoiDichVu()
        {
            txtMaDichVu.Enabled = false;
            txtTenDichVu.Enabled = false;
            pcboxHinhAnh.Enabled = false;
            cboMaLoaiDichVu.Enabled = false;

            btnLuu2.Enabled = false;
            btnThem2.Enabled = true;
            btnXoa2.Enabled = true;
            btnSua2.Enabled = true;

            txtMaDichVu.Text = "";
            txtTenDichVu.Text = "";
            pcboxHinhAnh.Text = "";
            cboMaLoaiDichVu.Text = "";

            LayDanhSachDichVu();
            LoadComboBoxDichVu();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaLoaiDichVu.Enabled = true;
            txtTenLoaiDichVu.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;

            luachon = 1;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtMaLoaiDichVu.Enabled = true;
            txtTenLoaiDichVu.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;

            luachon = 2;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMaLoaiDichVu.Enabled = true;
            txtTenLoaiDichVu.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;

            luachon = 3;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (luachon == 1)
            {
                Them();
            }
            if (luachon == 2)
            {
                Xoa();
            }
            if (luachon == 3)
            {
                Sua();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtMaLoaiDichVu.Text = row.Cells["MaLoaiDichVu"].Value.ToString();
                txtTenLoaiDichVu.Text = row.Cells["TenLoaiDichVu"].Value.ToString();
            }
        }

        private void GUI_QuanLyDichVu_Load(object sender, EventArgs e)
        {
            LamMoi();
            LamMoiDichVu();
        }

        private void btnThem2_Click(object sender, EventArgs e)
        {
            txtMaDichVu.Enabled = true;
            txtTenDichVu.Enabled = true;
            pcboxHinhAnh.Enabled = true;
            cboMaLoaiDichVu.Enabled = true;

            btnLuu2.Enabled = true;
            btnThem2.Enabled = false;
            btnXoa2.Enabled = false;
            btnSua2.Enabled = false;

            luachon2 = 1;
        }

        private void btnXoa2_Click(object sender, EventArgs e)
        {
            txtMaDichVu.Enabled = true;
            txtTenDichVu.Enabled = false;
            pcboxHinhAnh.Enabled = false;
            cboMaLoaiDichVu.Enabled = false;

            btnLuu2.Enabled = true;
            btnThem2.Enabled = false;
            btnXoa2.Enabled = false;
            btnSua2.Enabled = false;

            luachon2 = 2;
        }

        private void btnSua2_Click(object sender, EventArgs e)
        {
            txtMaDichVu.Enabled = true;
            txtTenDichVu.Enabled = true;
            pcboxHinhAnh.Enabled = true;
            cboMaLoaiDichVu.Enabled = true;

            btnLuu2.Enabled = true;
            btnThem2.Enabled = false;
            btnXoa2.Enabled = false;
            btnSua2.Enabled = false;

            luachon2 = 3;
        }

        private void btnLuu2_Click(object sender, EventArgs e)
        {
            if (luachon2 == 1)
            {
                ThemDichVu();
            }
            if (luachon2 == 2)
            {
                XoaDichVu();
            }
            if (luachon2 == 3)
            {
                SuaDichVu();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                txtMaDichVu.Text = row.Cells["MaDichVu"].Value.ToString();
                txtTenDichVu.Text = row.Cells["TenDichVu"].Value.ToString();

                tenhinhanh = row.Cells["HinhAnh"].Value?.ToString();

                string projectDirectory = Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.Parent.FullName;
                string targetFolderPath = Path.Combine(projectDirectory, "HinhAnh", "DichVu");

                if (!string.IsNullOrEmpty(tenhinhanh))
                {
                    try
                    {
                        string targetFilePath = Path.Combine(targetFolderPath, tenhinhanh);
                        pcboxHinhAnh.Image = Image.FromFile(targetFilePath);
                    }
                    catch (Exception ex)
                    {
                        pcboxHinhAnh.Image = Properties.Resources.anhkhongtontai;
                    }
                }
                else
                {
                    pcboxHinhAnh.Image = Properties.Resources.anhkhongtontai;
                }

                cboMaLoaiDichVu.Text = row.Cells["MaLoaiDichVu"].Value.ToString();

                txtDieuKienBanToiThieu.Text = row.Cells["DieuKienBanToiThieu"].Value.ToString();

                txtDieuKienBanToiDa.Text = row.Cells["DieuKienBanToiDa"].Value.ToString();

                txtGiaGiam30.Text = row.Cells["GiaGiam30"].Value.ToString();

                txtGiaLe.Text = row.Cells["GiaLe"].Value.ToString();

                txtGiaTronGoi.Text = row.Cells["GiaTronGoi"].Value.ToString();

            }
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
                    string targetFolderPath = Path.Combine(projectDirectory, "HinhAnh", "DichVu");

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
                    pcboxHinhAnh.Image = Image.FromFile(targetFilePath);
                }
            }
        }

        private void txtGiaGiam30_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGiaLe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGiaTronGoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}

