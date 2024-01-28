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
    public partial class GUI_QuanLyMenu : UserControl
    {
        BLL_LoaiMonAn bll_loaimonan = new BLL_LoaiMonAn();
        BLL_MonAn bll_monan = new BLL_MonAn();


        public GUI_QuanLyMenu()
        {
            InitializeComponent();

            LoadComboBoxLoaiMonAn();
        }

        private void LayDanhSachMenu()
        {

        }

        private void LoadComboBoxLoaiMonAn()
        {
            cboLoaiMonAn.DataSource = null;

            cboLoaiMonAn.DataSource = bll_loaimonan.GetAll();

            cboLoaiMonAn.DisplayMember = "TenLoaiMonAn";
            cboLoaiMonAn.ValueMember = "MaLoaiMonAn";
        }

        private void cboLoaiMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cboMonAn.DataSource = bll_monan.GetByLoaiMonAn((string)cboLoaiMonAn.SelectedValue);

            //cboMonAn.DisplayMember = "TenMonAn";
            //cboMonAn.ValueMember = "MaMonAn";
        }
    }
}
