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
    public partial class GUI_ChiTietDatTiec : Form
    {
        BLL_ChiTietNuocUong bll_chitietnuocuong = new BLL_ChiTietNuocUong();
        BLL_LoaiNuoc bll_loainuoc = new BLL_LoaiNuoc();
        BLL_Nuoc bll_nuoc = new BLL_Nuoc();
        BLL_DichVuTinhPhi bll_dichvutinhphi = new BLL_DichVuTinhPhi();
        BLL_ChiTietDichVuTinhPhi bll_chitietdichvutinhphi = new BLL_ChiTietDichVuTinhPhi();
        BLL_ChiTietMenu bll_chitietmenu = new BLL_ChiTietMenu();

        public GUI_ChiTietDatTiec()
        {
            InitializeComponent();
        }

        public GUI_ChiTietDatTiec(string matiec)
        {
            InitializeComponent();
            lblMaTiec.Text = matiec;



            LoadChiTietNuoc();
            LoadComboBoxLoaiNuoc();

            LoadChiTietDichVu();
            LoadComboBoxDichVuTinhPhi();

            LoadChiTietMenu();
        }

        private void LoadChiTietNuoc()
        {
            dataGridViewNuoc.DataSource = bll_chitietnuocuong.GetAll(lblMaTiec.Text);
            if (!dataGridViewNuoc.Columns.Contains("DeleteButtonColumn"))
            {
                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
                deleteButtonColumn.HeaderText = "Xóa";
                deleteButtonColumn.Name = "DeleteButtonColumn";
                deleteButtonColumn.Text = "Xóa";
                deleteButtonColumn.UseColumnTextForButtonValue = true;
                dataGridViewNuoc.Columns.Add(deleteButtonColumn);
            }
        }

        private void LoadComboBoxLoaiNuoc()
        {
            cboLoaiNuoc.DataSource = bll_loainuoc.GetAll();
            cboLoaiNuoc.DisplayMember = "TenLoaiNuoc";
            cboLoaiNuoc.ValueMember = "MaLoaiNuoc";
        }

        private void LoadChiTietDichVu()
        {
            dataGridViewDichVu.DataSource = bll_chitietdichvutinhphi.GetAll(lblMaTiec.Text);
            if (!dataGridViewDichVu.Columns.Contains("DeleteButtonColumn"))
            {
                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
                deleteButtonColumn.HeaderText = "Xóa";
                deleteButtonColumn.Name = "DeleteButtonColumn";
                deleteButtonColumn.Text = "Xóa";
                deleteButtonColumn.UseColumnTextForButtonValue = true;
                dataGridViewDichVu.Columns.Add(deleteButtonColumn);
            }
        }

        private void LoadComboBoxDichVuTinhPhi()
        {
            cboDichVuTinhPhi.DataSource = bll_dichvutinhphi.GetAll();
            cboDichVuTinhPhi.DisplayMember = "TenDichVu";
            cboDichVuTinhPhi.ValueMember = "MaDichVuTinhPhi";
        }

        private void dataGridViewNuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewNuoc.Columns["DeleteButtonColumn"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewNuoc.Rows[e.RowIndex];

                string manuoc = row.Cells["MaNuoc"].Value?.ToString();

                bll_chitietnuocuong.Delete(lblMaTiec.Text, manuoc);

                LoadChiTietNuoc();
            }
        }

        private void cboLoaiNuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboNuoc.DataSource = bll_nuoc.GetAll(cboLoaiNuoc.SelectedValue.ToString());
            cboNuoc.DisplayMember = "TenNuoc";
            cboNuoc.ValueMember = "MaNuoc";
        }

        private void btnThemChiTietNuoc_Click_1(object sender, EventArgs e)
        {
            if (cboNuoc.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn nước!");
            }
            else
            {
                if (bll_chitietnuocuong.KiemTra(lblMaTiec.Text, cboNuoc.SelectedValue.ToString()) == false)
                {
                    DTO_ChiTietNuocUong dto = new DTO_ChiTietNuocUong();
                    dto.MaTiec = lblMaTiec.Text;
                    dto.MaNuoc = cboNuoc.SelectedValue.ToString();
                    dto.SoLuong = (int)numericUpDownSoLuong.Value;
                    dto.TrangThai = "";
                    bll_chitietnuocuong.Add(dto);
                    LoadChiTietNuoc();
                }
                else
                {
                    DTO_ChiTietNuocUong dto = new DTO_ChiTietNuocUong();
                    dto.MaTiec = lblMaTiec.Text;
                    dto.MaNuoc = cboNuoc.SelectedValue.ToString();
                    dto.SoLuong = (int)numericUpDownSoLuong.Value;
                    dto.TrangThai = "";
                    bll_chitietnuocuong.Update(dto);
                    LoadChiTietNuoc();
                }
            }
        }

        private void dataGridViewDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewDichVu.Columns["DeleteButtonColumn"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewDichVu.Rows[e.RowIndex];

                string madichvutinhphi = row.Cells["MaDichVuTinhPhi"].Value?.ToString();

                bll_chitietdichvutinhphi.Delete(lblMaTiec.Text, madichvutinhphi);

                LoadChiTietDichVu();
            }
        }

        private void btnThemDichVu_Click(object sender, EventArgs e)
        {
            if (cboDichVuTinhPhi.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Dịch vụ!");
            }
            else
            {
                if (bll_chitietdichvutinhphi.KiemTra(lblMaTiec.Text, cboDichVuTinhPhi.SelectedValue.ToString()) == false)
                {
                    DTO_ChiTietDichVuTinhPhi dto = new DTO_ChiTietDichVuTinhPhi();
                    dto.MaTiec = lblMaTiec.Text;
                    dto.MaDichVuTinhPhi = cboDichVuTinhPhi.SelectedValue.ToString();
                    dto.TrangThai = "";
                    bll_chitietdichvutinhphi.Add(dto);
                    LoadChiTietDichVu();
                }
                else
                {
                    MessageBox.Show("Dịch vụ đã được Order!");
                }
            }
        }


        private void LoadChiTietMenu()
        {
            dataGridViewMenu.DataSource = bll_chitietmenu.GetAll(lblMaTiec.Text);
            if (!dataGridViewMenu.Columns.Contains("DeleteButtonColumn"))
            {
                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
                deleteButtonColumn.HeaderText = "Xóa";
                deleteButtonColumn.Name = "DeleteButtonColumn";
                deleteButtonColumn.Text = "Xóa";
                deleteButtonColumn.UseColumnTextForButtonValue = true;
                dataGridViewMenu.Columns.Add(deleteButtonColumn);
            }
            if (!dataGridViewMenu.Columns.Contains("ChiTietButton"))
            {
                DataGridViewButtonColumn chitietbutton = new DataGridViewButtonColumn();
                chitietbutton.HeaderText = "Chi tiết";
                chitietbutton.Name = "ChiTietButton";
                chitietbutton.Text = "Chi tiết";
                chitietbutton.UseColumnTextForButtonValue = true;
                dataGridViewMenu.Columns.Add(chitietbutton);
            }
        }


        private void dataGridViewMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dataGridViewMenu.Columns["DeleteButtonColumn"].Index)
                {
                    DataGridViewRow row = dataGridViewMenu.Rows[e.RowIndex];

                    string mamenu = row.Cells["MaMenu"].Value?.ToString();

                    bll_chitietmenu.Delete(lblMaTiec.Text, mamenu);

                    LoadChiTietMenu();
                }
                else if (e.ColumnIndex == dataGridViewMenu.Columns["ChiTietButton"].Index)
                {
                    
                }
            }
        }

        private void btnThemMenu_Click(object sender, EventArgs e)
        {
            if (txtMaMenu.Text.Trim().Equals(""))
            {
                MessageBox.Show("Nhập mã menu!");
            }
            else
            {
                if(bll_chitietmenu.KiemTra(lblMaTiec.Text,txtMaMenu.Text.Trim()) == false)
                {
                    DTO_ChiTietMenu dto = new DTO_ChiTietMenu();
                    dto.MaTiec = lblMaTiec.Text;
                    dto.MaMenu = txtMaMenu.Text.Trim();
                    dto.SoLuongMenuCuaTiec = (int)numericUpDownSoLuongMenuCuaTiec.Value;
                    bll_chitietmenu.Add(dto);
                    LoadChiTietMenu();
                }
                else
                {
                    DTO_ChiTietMenu dto = new DTO_ChiTietMenu();
                    dto.MaTiec = lblMaTiec.Text;
                    dto.MaMenu = txtMaMenu.Text.Trim();
                    dto.SoLuongMenuCuaTiec = (int)numericUpDownSoLuongMenuCuaTiec.Value;
                    bll_chitietmenu.Update(dto);
                    LoadChiTietMenu();
                }
            }
        }
    }
}
