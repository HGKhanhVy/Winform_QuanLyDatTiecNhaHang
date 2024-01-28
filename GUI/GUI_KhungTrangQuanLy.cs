using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class GUI_KhungTrangQuanLy : Form
    {
        bool menu1 = false;
        bool menu2 = false;
        bool menu3 = false;

        string username;
        public GUI_KhungTrangQuanLy()
        {
            InitializeComponent();
        }

        public GUI_KhungTrangQuanLy(string user, string ten)
        {
            InitializeComponent();
            this.lblTenNhanVien.Text = ten;
            username = user;
        }

        private void GUI_KhungTrangQuanLy_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (menu1 == false)
            {
                menu1 = true;
                panelQuanLyDichVu.Size = new Size(277, 155);
            }
            else
            {
                menu1 = false;
                panelQuanLyDichVu.Size = new Size(277, 50);
            }
        }

        private void btnQuanLyThucDon_Click(object sender, EventArgs e)
        {
            if (menu2 == false)
            {
                menu2 = true;
                panelQuanLyThucDon.Size = new Size(277, 155);
            }
            else
            {
                menu2 = false;
                panelQuanLyThucDon.Size = new Size(277, 50);
            }
        }

        private void btnMenuDichVu_Click(object sender, EventArgs e)
        {
            panelKhungTrang.Controls.Clear();
            GUI_QuanLyDichVu gui = new GUI_QuanLyDichVu();
            panelKhungTrang.Controls.Add(gui);
            gui.Show();
        }

        private void btnMenuDichVuTinhPhi_Click(object sender, EventArgs e)
        {
            panelKhungTrang.Controls.Clear();
            GUI_DichVuTinhPhi gui = new GUI_DichVuTinhPhi();
            panelKhungTrang.Controls.Add(gui);
            gui.Show();
        }

        private void btnMenuDichVuUuDai_Click(object sender, EventArgs e)
        {
            panelKhungTrang.Controls.Clear();
            GUI_DichVuUuDai gui = new GUI_DichVuUuDai();
            panelKhungTrang.Controls.Add(gui);
            gui.Show();
        }

        private void btnMonAn_Click(object sender, EventArgs e)
        {
            panelKhungTrang.Controls.Clear();
            GUI_QuanLyMonAn gui = new GUI_QuanLyMonAn();
            panelKhungTrang.Controls.Add(gui);
            gui.Show();
        }

        private void btnDoUong_Click(object sender, EventArgs e)
        {
            panelKhungTrang.Controls.Clear();
            GUI_QuanLyNuoc gui = new GUI_QuanLyNuoc();
            panelKhungTrang.Controls.Add(gui);
            gui.Show();
        }

        private void btnQuanLyMenu_Click(object sender, EventArgs e)
        {
            panelKhungTrang.Controls.Clear();
            GUI_QuanLyMenu gui = new GUI_QuanLyMenu();
            panelKhungTrang.Controls.Add(gui);
            gui.Show();
        }

        private void btnQuanLyDatTiec_Click(object sender, EventArgs e)
        {
            if (menu3 == false)
            {
                menu3 = true;
                panelQuanLyDatTiec.Size = new Size(277, 85);
            }
            else
            {
                menu3 = false;
                panelQuanLyDatTiec.Size = new Size(277, 50);
            }
        }

        private void btnDanhSachDatTiec_Click(object sender, EventArgs e)
        {
            panelKhungTrang.Controls.Clear();
            GUI_QuanLyDatTiec gui = new GUI_QuanLyDatTiec();
            panelKhungTrang.Controls.Add(gui);
            gui.Show();
        }
    }
}
