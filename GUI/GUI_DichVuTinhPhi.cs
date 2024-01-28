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
    public partial class GUI_DichVuTinhPhi : UserControl
    {
        BLL_DichVu blldichvu = new BLL_DichVu();
        BLL_DichVuTinhPhi blldichvutinhphi = new BLL_DichVuTinhPhi();

        int luachon = 0;

        string tenhinhanh = "";
        public GUI_DichVuTinhPhi()
        {
            InitializeComponent();
            LayDanhSach();
            LoadComboBoxDichVu();
            LamMoi();
        }

        private void LoadComboBoxDichVu()
        {
            cboMaDichVu.DataSource = null;
            List<DTO_DichVu> ds = blldichvu.GetAll();

            cboMaDichVu.DataSource = ds;

            cboMaDichVu.ValueMember = "MaDichVu";
            cboMaDichVu.DisplayMember = "TenDichVu";
        }

        private void LayDanhSach()
        {
            dataGridViewDichVuTinhPhi.DataSource = blldichvutinhphi.GetAll();
        }

        private void LamMoi()
        {
            txtMaDichVuTinhPhi.Enabled = false;
            txtTenDichVu.Enabled = false;
            txtDieuKienBanToiThieu.Enabled = false;
            txtDieuKienBanToiDa.Enabled = false;
            txtMoTa.Enabled = false;
            pictureBoxHinhAnh.Image = Properties.Resources.anhkhongtontai;
            cboMaDichVu.Enabled = false;
            txtGiaTronGoi.Enabled = false;
            txtGiaLe.Enabled = false;
            txtGiaGiam30.Enabled = false;


            txtMaDichVuTinhPhi.Text = "";
            txtTenDichVu.Text = "";
            txtDieuKienBanToiThieu.Text = "";
            txtDieuKienBanToiDa.Text = "";
            txtMoTa.Text = "";
            cboMaDichVu.SelectedIndex = -1;
            txtGiaTronGoi.Text = "";
            txtGiaLe.Text = "";
            txtGiaGiam30.Text = "";

            btnChonAnh.Enabled = false;

            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void Them()
        {
            if (txtMaDichVuTinhPhi.Text.Trim().Equals("") || txtTenDichVu.Text.Trim().Equals("") || txtDieuKienBanToiThieu.Text.Trim().Equals("") || txtDieuKienBanToiDa.Text.Trim().Equals("") || txtMoTa.Text.Trim().Equals("") || txtGiaTronGoi.Text.Trim().Equals("") || txtGiaGiam30.Text.Trim().Equals("") || txtGiaLe.Text.Trim().Equals(""))
            {
                MessageBox.Show("Thông tin không được để trống!");
            }
            else
            {
                if (blldichvutinhphi.GetByID(txtMaDichVuTinhPhi.Text.Trim()) != null)
                {
                    MessageBox.Show("Mã dịch vụ tính phí đã tồn tại!");
                }
                else
                {
                    DTO_DichVuTinhPhi dto = new DTO_DichVuTinhPhi();
                    dto.MaDichVuTinhPhi = txtMaDichVuTinhPhi.Text.Trim();
                    dto.TenDichVu = txtTenDichVu.Text.Trim();
                    dto.DieuKienBanToiThieu = int.Parse(txtDieuKienBanToiThieu.Text.Trim());
                    dto.DieuKienBanToiDa = int.Parse(txtDieuKienBanToiDa.Text.Trim());
                    dto.MoTa = txtMoTa.Text.Trim();
                    dto.HinhAnh = tenhinhanh;
                    dto.MaDichVu = (string)cboMaDichVu.SelectedValue;
                    dto.GiaTronGoi = float.Parse(txtGiaTronGoi.Text.Trim());
                    dto.GiaLe = float.Parse(txtGiaLe.Text.Trim());
                    dto.GiaGiam30 = float.Parse(txtGiaGiam30.Text.Trim());

                    blldichvutinhphi.Add(dto);

                    MessageBox.Show("Thêm thành công.");

                    LamMoi();
                    LayDanhSach();
                    luachon = 0;
                }
            }
        }

        private void Xoa()
        {
            if (txtMaDichVuTinhPhi.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mã dịch vụ tính phí không được để trống!");
            }
            else
            {
                if (blldichvutinhphi.GetByID(txtMaDichVuTinhPhi.Text.Trim()) != null)
                {
                    blldichvutinhphi.Delete(txtMaDichVuTinhPhi.Text.Trim());
                    MessageBox.Show("Xóa thành công!");
                    LamMoi();
                    LayDanhSach();
                    luachon = 0;
                }
                else
                {
                    MessageBox.Show("Mã dịch vụ tính phí không tồn tại!");
                }
            }
        }

        private void Sua()
        {
            if (txtMaDichVuTinhPhi.Text.Trim().Equals("") || txtTenDichVu.Text.Trim().Equals("") || txtDieuKienBanToiDa.Text.Trim().Equals("") || txtDieuKienBanToiThieu.Text.Trim().Equals("") || txtMoTa.Text.Trim().Equals("") || txtGiaTronGoi.Text.Trim().Equals("") || txtGiaGiam30.Text.Trim().Equals("") || txtGiaLe.Text.Trim().Equals(""))
            {
                MessageBox.Show("Thông tin không được để trống!");
            }
            else
            {
                if (blldichvutinhphi.GetByID(txtMaDichVuTinhPhi.Text.Trim()) != null)
                {
                    DTO_DichVuTinhPhi dto = new DTO_DichVuTinhPhi();
                    dto.MaDichVuTinhPhi = txtMaDichVuTinhPhi.Text.Trim();
                    dto.TenDichVu = txtTenDichVu.Text.Trim();
                    dto.DieuKienBanToiThieu = int.Parse(txtDieuKienBanToiThieu.Text.Trim());
                    dto.DieuKienBanToiDa = int.Parse(txtDieuKienBanToiDa.Text.Trim());
                    dto.MoTa = txtMoTa.Text.Trim();
                    dto.HinhAnh = tenhinhanh;
                    dto.MaDichVu = (string)cboMaDichVu.SelectedValue;
                    dto.GiaTronGoi = float.Parse(txtGiaTronGoi.Text.Trim());
                    dto.GiaLe = float.Parse(txtGiaLe.Text.Trim());
                    dto.GiaGiam30 = float.Parse(txtGiaGiam30.Text.Trim());

                    blldichvutinhphi.Update(dto);

                    MessageBox.Show("Sửa thành công.");

                    LamMoi();
                    LayDanhSach();
                    luachon = 0;
                }
                else
                {
                    MessageBox.Show("Mã dịch vụ tính phí không tồn tại!");
                }
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
                    pictureBoxHinhAnh.Image = Image.FromFile(targetFilePath);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaDichVuTinhPhi.Enabled = true;
            txtTenDichVu.Enabled = true;
            txtDieuKienBanToiThieu.Enabled = true;
            txtDieuKienBanToiDa.Enabled = true;
            txtMoTa.Enabled = true;
            cboMaDichVu.Enabled = true;
            txtGiaTronGoi.Enabled = true;
            txtGiaLe.Enabled = true;
            txtGiaGiam30.Enabled = true;

            btnChonAnh.Enabled = true;

            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            luachon = 1;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtMaDichVuTinhPhi.Enabled = true;
            txtTenDichVu.Enabled = false;
            txtDieuKienBanToiThieu.Enabled = false;
            txtDieuKienBanToiDa.Enabled = false;
            txtMoTa.Enabled = false;
            cboMaDichVu.Enabled = false;
            txtGiaTronGoi.Enabled = false;
            txtGiaLe.Enabled = false;
            txtGiaGiam30.Enabled = false;

            btnChonAnh.Enabled = false;

            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            luachon = 2;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMaDichVuTinhPhi.Enabled = true;
            txtTenDichVu.Enabled = true;
            txtDieuKienBanToiThieu.Enabled = true;
            txtDieuKienBanToiDa.Enabled = true;
            txtMoTa.Enabled = true;
            cboMaDichVu.Enabled = true;
            txtGiaTronGoi.Enabled = true;
            txtGiaLe.Enabled = true;
            txtGiaGiam30.Enabled = true;

            btnChonAnh.Enabled = true;

            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LamMoi();
            luachon = 0;
        }

        private void dataGridViewDichVuTinhPhi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewDichVuTinhPhi.Rows[e.RowIndex];

                txtMaDichVuTinhPhi.Text = row.Cells["MaDichVuTinhPhi"].Value.ToString();
                txtTenDichVu.Text = row.Cells["TenDichVu"].Value?.ToString();
                txtDieuKienBanToiThieu.Text = row.Cells["DieuKienBanToiThieu"].Value?.ToString();

                txtDieuKienBanToiDa.Text = row.Cells["DieuKienBanToiDa"].Value?.ToString();

                txtMoTa.Text = row.Cells["MoTa"].Value?.ToString();

                tenhinhanh = row.Cells["HinhAnh"].Value?.ToString();

                string projectDirectory = Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.Parent.FullName;
                string targetFolderPath = Path.Combine(projectDirectory, "HinhAnh", "DichVu");

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

                List<DTO_DichVu> ds = blldichvu.GetAll();
                cboMaDichVu.DataSource = ds;
                cboMaDichVu.ValueMember = "MaDichVu";
                cboMaDichVu.DisplayMember = "TenDichVu";

                string maDichVu = row.Cells["MaDichVu"].Value.ToString();
                DTO_DichVu selectedDichVu = ds.Find(dv => dv.MaDichVu == maDichVu);
                if (selectedDichVu != null)
                {
                    cboMaDichVu.SelectedItem = selectedDichVu;
                }
                else
                {
                    cboMaDichVu.SelectedIndex = -1;
                }

                txtGiaTronGoi.Text = row.Cells["GiaTronGoi"].Value.ToString();
                txtGiaLe.Text = row.Cells["GiaLe"].Value.ToString();
                txtGiaGiam30.Text = row.Cells["GiaGiam30"].Value.ToString();

            }
        }

        private void txtGiaTronGoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
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
    }
}