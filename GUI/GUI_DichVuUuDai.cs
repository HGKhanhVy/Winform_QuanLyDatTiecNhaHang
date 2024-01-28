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
    public partial class GUI_DichVuUuDai : UserControl
    {
        BLL_DichVu blldichvu = new BLL_DichVu();
        BLL_DichVuUuDai blldichvuuudai = new BLL_DichVuUuDai();

        int luachon = 0;

        string tenhinhanh = "";
        public GUI_DichVuUuDai()
        {
            InitializeComponent();
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
            dataGridViewDichVuUuDai.DataSource = blldichvuuudai.GetAll();
        }

        private void GUI_DichVuUuDai_Load(object sender, EventArgs e)
        {
            LayDanhSach();
            LoadComboBoxDichVu();
            LamMoi();
        }



        private void LamMoi()
        {
            txtMaDichVuUuDai.Enabled = false;
            txtTenDichVu.Enabled = false;
            txtDieuKienBanToiThieu.Enabled = false;

            txtDieuKienBanToiDa.Enabled = false;
            txtMoTa.Enabled = false;
            pictureBoxHinhAnh.Image = Properties.Resources.anhkhongtontai;
            cboMaDichVu.Enabled = false;

            txtMaDichVuUuDai.Text = "";
            txtTenDichVu.Text = "";
            txtDieuKienBanToiThieu.Text = "";
            txtDieuKienBanToiDa.Text = "";
            txtMoTa.Text = "";
            cboMaDichVu.SelectedIndex = -1;

            btnChonAnh.Enabled = false;

            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void Them()
        {
            if (txtMaDichVuUuDai.Text.Trim().Equals("") || txtTenDichVu.Text.Trim().Equals("") || txtDieuKienBanToiDa.Text.Trim().Equals("") || txtDieuKienBanToiThieu.Text.Trim().Equals("") || txtMoTa.Text.Trim().Equals(""))
            {
                MessageBox.Show("Thông tin không được để trống!");
            }
            else
            {
                if (blldichvuuudai.GetByID(txtMaDichVuUuDai.Text.Trim()) != null)
                {
                    MessageBox.Show("Mã dịch vụ ưu đãi đã tồn tại!");
                }
                else
                {
                    DTO_DichVuUuDai dto = new DTO_DichVuUuDai();
                    dto.MaDichVuUuDai = txtMaDichVuUuDai.Text.Trim();
                    dto.TenDichVu = txtTenDichVu.Text.Trim();
                    dto.DieuKienBanToiThieu = int.Parse(txtDieuKienBanToiThieu.Text.Trim());
                    dto.DieuKienBanToiDa = int.Parse(txtDieuKienBanToiDa.Text.Trim());
                    dto.MoTa = txtMoTa.Text.Trim();
                    dto.HinhAnh = tenhinhanh;
                    dto.MaDichVu = (string)cboMaDichVu.SelectedValue;

                    blldichvuuudai.Add(dto);

                    MessageBox.Show("Thêm thành công.");

                    LamMoi();
                    LayDanhSach();
                    luachon = 0;
                }
            }
        }

        private void Xoa()
        {
            if (txtMaDichVuUuDai.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mã dịch vụ ưu đãi không được để trống!");
            }
            else
            {
                if (blldichvuuudai.GetByID(txtMaDichVuUuDai.Text.Trim()) != null)
                {
                    blldichvuuudai.Delete(txtMaDichVuUuDai.Text.Trim());
                    MessageBox.Show("Xóa thành công!");
                    LamMoi();
                    LayDanhSach();
                    luachon = 0;
                }
                else
                {
                    MessageBox.Show("Mã dịch vụ ưu đãi không tồn tại!");
                }
            }
        }

        private void Sua()
        {
            if (txtMaDichVuUuDai.Text.Trim().Equals("") || txtTenDichVu.Text.Trim().Equals("") || txtDieuKienBanToiDa.Text.Trim().Equals("") || txtDieuKienBanToiThieu.Text.Trim().Equals("") || txtMoTa.Text.Trim().Equals(""))
            {
                MessageBox.Show("Thông tin không được để trống!");
            }
            else
            {
                if (blldichvuuudai.GetByID(txtMaDichVuUuDai.Text.Trim()) != null)
                {
                    DTO_DichVuUuDai dto = new DTO_DichVuUuDai();
                    dto.MaDichVuUuDai = txtMaDichVuUuDai.Text.Trim();
                    dto.TenDichVu = txtTenDichVu.Text.Trim();
                    dto.DieuKienBanToiThieu = int.Parse(txtDieuKienBanToiThieu.Text.Trim());
                    dto.DieuKienBanToiDa = int.Parse(txtDieuKienBanToiDa.Text.Trim());
                    dto.MoTa = txtMoTa.Text.Trim();
                    dto.HinhAnh = tenhinhanh;
                    dto.MaDichVu = (string)cboMaDichVu.SelectedValue;

                    blldichvuuudai.Update(dto);

                    MessageBox.Show("Sửa thành công.");

                    LamMoi();
                    LayDanhSach();
                    luachon = 0;
                }
                else
                {
                    MessageBox.Show("Mã dịch vụ ưu đãi không tồn tại!");
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
            txtMaDichVuUuDai.Enabled = true;
            txtTenDichVu.Enabled = true;
            txtDieuKienBanToiThieu.Enabled = true;
            txtDieuKienBanToiDa.Enabled = true;
            txtMoTa.Enabled = true;
            cboMaDichVu.Enabled = true;

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
            txtMaDichVuUuDai.Enabled = true;
            txtTenDichVu.Enabled = false;
            txtDieuKienBanToiThieu.Enabled = false;
            txtDieuKienBanToiDa.Enabled=false;
            txtMoTa.Enabled = false;
            cboMaDichVu.Enabled = false;

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
            txtMaDichVuUuDai.Enabled = true;
            txtTenDichVu.Enabled = true;
            txtDieuKienBanToiThieu.Enabled = true;
            txtDieuKienBanToiDa.Enabled = true;
            txtMoTa.Enabled = true;
            cboMaDichVu.Enabled = true;

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

        private void dataGridViewDichVuUuDai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewDichVuUuDai.Rows[e.RowIndex];

                txtMaDichVuUuDai.Text = row.Cells["MaDichVuUuDai"].Value.ToString();
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
            }
        }
    }
}
