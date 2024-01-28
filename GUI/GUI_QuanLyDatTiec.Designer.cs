namespace GUI
{
    partial class GUI_QuanLyDatTiec
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox6 = new GroupBox();
            dateTimePickerNgayDatTiec = new DateTimePicker();
            groupBox5 = new GroupBox();
            txtLoaiHinhTiec = new TextBox();
            groupBox4 = new GroupBox();
            txtMaTiec = new TextBox();
            groupBox1 = new GroupBox();
            txtSoLuongBanChay = new TextBox();
            groupBox2 = new GroupBox();
            txtSoLuongBanTang = new TextBox();
            groupBox3 = new GroupBox();
            txtSoLuongBanChinhThuc = new TextBox();
            groupBox7 = new GroupBox();
            txtTongTienDuKien = new TextBox();
            groupBox8 = new GroupBox();
            txtPhiDichVu = new TextBox();
            groupBox9 = new GroupBox();
            txtLoaiBan = new TextBox();
            groupBox10 = new GroupBox();
            txtGhiChu = new TextBox();
            groupBox11 = new GroupBox();
            txtTienCocLan2 = new TextBox();
            groupBox12 = new GroupBox();
            txtTienCocLan1 = new TextBox();
            groupBox14 = new GroupBox();
            txtThoiGianToChuc = new TextBox();
            groupBox15 = new GroupBox();
            txtNgayToChuc = new TextBox();
            groupBox13 = new GroupBox();
            txtTongBanSetup = new TextBox();
            groupBox16 = new GroupBox();
            txtSoLuongBanDuPhong = new TextBox();
            groupBox17 = new GroupBox();
            txtTongTienPhaiTra = new TextBox();
            groupBox18 = new GroupBox();
            txtTongTienGiam = new TextBox();
            groupBox19 = new GroupBox();
            txtTrangThai = new TextBox();
            groupBox20 = new GroupBox();
            txtMaKhachHang = new TextBox();
            btnHuy = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            cboTimKiemTheo = new ComboBox();
            groupBox21 = new GroupBox();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            btnChiTietDatTiec = new Button();
            groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox9.SuspendLayout();
            groupBox10.SuspendLayout();
            groupBox11.SuspendLayout();
            groupBox12.SuspendLayout();
            groupBox14.SuspendLayout();
            groupBox15.SuspendLayout();
            groupBox13.SuspendLayout();
            groupBox16.SuspendLayout();
            groupBox17.SuspendLayout();
            groupBox18.SuspendLayout();
            groupBox19.SuspendLayout();
            groupBox20.SuspendLayout();
            groupBox21.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox
            // 
            groupBox.Controls.Add(dataGridView1);
            groupBox.Location = new Point(0, 352);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(1227, 419);
            groupBox.TabIndex = 0;
            groupBox.TabStop = false;
            groupBox.Text = "Danh sách đặt tiệc";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1218, 391);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(dateTimePickerNgayDatTiec);
            groupBox6.Location = new Point(153, 113);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(223, 49);
            groupBox6.TabIndex = 6;
            groupBox6.TabStop = false;
            groupBox6.Text = "Ngày đặt tiệc";
            // 
            // dateTimePickerNgayDatTiec
            // 
            dateTimePickerNgayDatTiec.Location = new Point(6, 20);
            dateTimePickerNgayDatTiec.Name = "dateTimePickerNgayDatTiec";
            dateTimePickerNgayDatTiec.Size = new Size(211, 23);
            dateTimePickerNgayDatTiec.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txtLoaiHinhTiec);
            groupBox5.Location = new Point(153, 58);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(223, 49);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "Loại hình tiệc";
            // 
            // txtLoaiHinhTiec
            // 
            txtLoaiHinhTiec.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtLoaiHinhTiec.Location = new Point(6, 17);
            txtLoaiHinhTiec.Name = "txtLoaiHinhTiec";
            txtLoaiHinhTiec.Size = new Size(211, 23);
            txtLoaiHinhTiec.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtMaTiec);
            groupBox4.Location = new Point(153, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(223, 49);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Mã tiệc";
            // 
            // txtMaTiec
            // 
            txtMaTiec.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaTiec.Location = new Point(6, 17);
            txtMaTiec.Name = "txtMaTiec";
            txtMaTiec.Size = new Size(211, 23);
            txtMaTiec.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSoLuongBanChay);
            groupBox1.Location = new Point(382, 113);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(223, 49);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Số lượng bàn chay";
            // 
            // txtSoLuongBanChay
            // 
            txtSoLuongBanChay.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoLuongBanChay.Location = new Point(6, 17);
            txtSoLuongBanChay.Name = "txtSoLuongBanChay";
            txtSoLuongBanChay.Size = new Size(211, 23);
            txtSoLuongBanChay.TabIndex = 0;
            txtSoLuongBanChay.KeyPress += txtSoLuongBanChay_KeyPress;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtSoLuongBanTang);
            groupBox2.Location = new Point(382, 58);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(223, 49);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Số lượng bàn tặng";
            // 
            // txtSoLuongBanTang
            // 
            txtSoLuongBanTang.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoLuongBanTang.Location = new Point(6, 17);
            txtSoLuongBanTang.Name = "txtSoLuongBanTang";
            txtSoLuongBanTang.Size = new Size(211, 23);
            txtSoLuongBanTang.TabIndex = 0;
            txtSoLuongBanTang.KeyPress += txtSoLuongBanTang_KeyPress;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtSoLuongBanChinhThuc);
            groupBox3.Location = new Point(382, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(223, 49);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Số lượng bàn chính thức";
            // 
            // txtSoLuongBanChinhThuc
            // 
            txtSoLuongBanChinhThuc.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoLuongBanChinhThuc.Location = new Point(6, 17);
            txtSoLuongBanChinhThuc.Name = "txtSoLuongBanChinhThuc";
            txtSoLuongBanChinhThuc.Size = new Size(211, 23);
            txtSoLuongBanChinhThuc.TabIndex = 0;
            txtSoLuongBanChinhThuc.KeyPress += txtSoLuongBanChinhThuc_KeyPress;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(txtTongTienDuKien);
            groupBox7.Location = new Point(611, 113);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(223, 49);
            groupBox7.TabIndex = 12;
            groupBox7.TabStop = false;
            groupBox7.Text = "Tổng tiền dự kiến";
            // 
            // txtTongTienDuKien
            // 
            txtTongTienDuKien.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTongTienDuKien.Location = new Point(6, 17);
            txtTongTienDuKien.Name = "txtTongTienDuKien";
            txtTongTienDuKien.Size = new Size(211, 23);
            txtTongTienDuKien.TabIndex = 0;
            txtTongTienDuKien.KeyPress += txtTongTienDuKien_KeyPress;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(txtPhiDichVu);
            groupBox8.Location = new Point(611, 58);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(223, 49);
            groupBox8.TabIndex = 11;
            groupBox8.TabStop = false;
            groupBox8.Text = "Phí dịch vụ";
            // 
            // txtPhiDichVu
            // 
            txtPhiDichVu.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhiDichVu.Location = new Point(6, 17);
            txtPhiDichVu.Name = "txtPhiDichVu";
            txtPhiDichVu.Size = new Size(211, 23);
            txtPhiDichVu.TabIndex = 0;
            txtPhiDichVu.KeyPress += txtPhiDichVu_KeyPress;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(txtLoaiBan);
            groupBox9.Location = new Point(611, 3);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(223, 49);
            groupBox9.TabIndex = 10;
            groupBox9.TabStop = false;
            groupBox9.Text = "Loại bàn";
            // 
            // txtLoaiBan
            // 
            txtLoaiBan.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtLoaiBan.Location = new Point(6, 17);
            txtLoaiBan.Name = "txtLoaiBan";
            txtLoaiBan.Size = new Size(211, 23);
            txtLoaiBan.TabIndex = 0;
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(txtGhiChu);
            groupBox10.Location = new Point(840, 113);
            groupBox10.Name = "groupBox10";
            groupBox10.Size = new Size(223, 49);
            groupBox10.TabIndex = 15;
            groupBox10.TabStop = false;
            groupBox10.Text = "Ghi chú";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtGhiChu.Location = new Point(6, 17);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(211, 23);
            txtGhiChu.TabIndex = 0;
            // 
            // groupBox11
            // 
            groupBox11.Controls.Add(txtTienCocLan2);
            groupBox11.Location = new Point(840, 58);
            groupBox11.Name = "groupBox11";
            groupBox11.Size = new Size(223, 49);
            groupBox11.TabIndex = 14;
            groupBox11.TabStop = false;
            groupBox11.Text = "Tiền cọc lần 2";
            // 
            // txtTienCocLan2
            // 
            txtTienCocLan2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTienCocLan2.Location = new Point(6, 17);
            txtTienCocLan2.Name = "txtTienCocLan2";
            txtTienCocLan2.Size = new Size(211, 23);
            txtTienCocLan2.TabIndex = 0;
            txtTienCocLan2.KeyPress += txtTienCocLan2_KeyPress;
            // 
            // groupBox12
            // 
            groupBox12.Controls.Add(txtTienCocLan1);
            groupBox12.Location = new Point(840, 3);
            groupBox12.Name = "groupBox12";
            groupBox12.Size = new Size(223, 49);
            groupBox12.TabIndex = 13;
            groupBox12.TabStop = false;
            groupBox12.Text = "Tiền cọc lần 1";
            // 
            // txtTienCocLan1
            // 
            txtTienCocLan1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTienCocLan1.Location = new Point(6, 17);
            txtTienCocLan1.Name = "txtTienCocLan1";
            txtTienCocLan1.Size = new Size(211, 23);
            txtTienCocLan1.TabIndex = 0;
            txtTienCocLan1.KeyPress += txtTienCocLan1_KeyPress;
            // 
            // groupBox14
            // 
            groupBox14.Controls.Add(txtThoiGianToChuc);
            groupBox14.Location = new Point(153, 223);
            groupBox14.Name = "groupBox14";
            groupBox14.Size = new Size(223, 49);
            groupBox14.TabIndex = 17;
            groupBox14.TabStop = false;
            groupBox14.Text = "Thời gian tổ chức";
            // 
            // txtThoiGianToChuc
            // 
            txtThoiGianToChuc.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtThoiGianToChuc.Location = new Point(6, 17);
            txtThoiGianToChuc.Name = "txtThoiGianToChuc";
            txtThoiGianToChuc.Size = new Size(211, 23);
            txtThoiGianToChuc.TabIndex = 0;
            // 
            // groupBox15
            // 
            groupBox15.Controls.Add(txtNgayToChuc);
            groupBox15.Location = new Point(153, 168);
            groupBox15.Name = "groupBox15";
            groupBox15.Size = new Size(223, 49);
            groupBox15.TabIndex = 16;
            groupBox15.TabStop = false;
            groupBox15.Text = "Ngày tổ chức";
            // 
            // txtNgayToChuc
            // 
            txtNgayToChuc.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNgayToChuc.Location = new Point(6, 17);
            txtNgayToChuc.Name = "txtNgayToChuc";
            txtNgayToChuc.Size = new Size(211, 23);
            txtNgayToChuc.TabIndex = 0;
            // 
            // groupBox13
            // 
            groupBox13.Controls.Add(txtTongBanSetup);
            groupBox13.Location = new Point(382, 223);
            groupBox13.Name = "groupBox13";
            groupBox13.Size = new Size(223, 49);
            groupBox13.TabIndex = 19;
            groupBox13.TabStop = false;
            groupBox13.Text = "Tổng bàn setup";
            // 
            // txtTongBanSetup
            // 
            txtTongBanSetup.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTongBanSetup.Location = new Point(6, 17);
            txtTongBanSetup.Name = "txtTongBanSetup";
            txtTongBanSetup.Size = new Size(211, 23);
            txtTongBanSetup.TabIndex = 0;
            txtTongBanSetup.KeyPress += txtTongBanSetup_KeyPress;
            // 
            // groupBox16
            // 
            groupBox16.Controls.Add(txtSoLuongBanDuPhong);
            groupBox16.Location = new Point(382, 168);
            groupBox16.Name = "groupBox16";
            groupBox16.Size = new Size(223, 49);
            groupBox16.TabIndex = 18;
            groupBox16.TabStop = false;
            groupBox16.Text = "Số lượng bàn dự phòng";
            // 
            // txtSoLuongBanDuPhong
            // 
            txtSoLuongBanDuPhong.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoLuongBanDuPhong.Location = new Point(6, 17);
            txtSoLuongBanDuPhong.Name = "txtSoLuongBanDuPhong";
            txtSoLuongBanDuPhong.Size = new Size(211, 23);
            txtSoLuongBanDuPhong.TabIndex = 0;
            txtSoLuongBanDuPhong.KeyPress += txtSoLuongBanDuPhong_KeyPress;
            // 
            // groupBox17
            // 
            groupBox17.Controls.Add(txtTongTienPhaiTra);
            groupBox17.Location = new Point(611, 223);
            groupBox17.Name = "groupBox17";
            groupBox17.Size = new Size(223, 49);
            groupBox17.TabIndex = 19;
            groupBox17.TabStop = false;
            groupBox17.Text = "Tổng tiền phải trả";
            // 
            // txtTongTienPhaiTra
            // 
            txtTongTienPhaiTra.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTongTienPhaiTra.Location = new Point(6, 17);
            txtTongTienPhaiTra.Name = "txtTongTienPhaiTra";
            txtTongTienPhaiTra.Size = new Size(211, 23);
            txtTongTienPhaiTra.TabIndex = 0;
            txtTongTienPhaiTra.KeyPress += txtTongTienPhaiTra_KeyPress;
            // 
            // groupBox18
            // 
            groupBox18.Controls.Add(txtTongTienGiam);
            groupBox18.Location = new Point(611, 168);
            groupBox18.Name = "groupBox18";
            groupBox18.Size = new Size(223, 49);
            groupBox18.TabIndex = 18;
            groupBox18.TabStop = false;
            groupBox18.Text = "Tổng tiền giảm";
            // 
            // txtTongTienGiam
            // 
            txtTongTienGiam.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTongTienGiam.Location = new Point(6, 17);
            txtTongTienGiam.Name = "txtTongTienGiam";
            txtTongTienGiam.Size = new Size(211, 23);
            txtTongTienGiam.TabIndex = 0;
            txtTongTienGiam.KeyPress += txtTongTienGiam_KeyPress;
            // 
            // groupBox19
            // 
            groupBox19.Controls.Add(txtTrangThai);
            groupBox19.Location = new Point(840, 223);
            groupBox19.Name = "groupBox19";
            groupBox19.Size = new Size(223, 49);
            groupBox19.TabIndex = 19;
            groupBox19.TabStop = false;
            groupBox19.Text = "Trạng thái";
            // 
            // txtTrangThai
            // 
            txtTrangThai.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTrangThai.Location = new Point(6, 17);
            txtTrangThai.Name = "txtTrangThai";
            txtTrangThai.Size = new Size(211, 23);
            txtTrangThai.TabIndex = 0;
            // 
            // groupBox20
            // 
            groupBox20.Controls.Add(txtMaKhachHang);
            groupBox20.Location = new Point(840, 168);
            groupBox20.Name = "groupBox20";
            groupBox20.Size = new Size(223, 49);
            groupBox20.TabIndex = 18;
            groupBox20.TabStop = false;
            groupBox20.Text = "Mã khách hàng";
            // 
            // txtMaKhachHang
            // 
            txtMaKhachHang.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaKhachHang.Location = new Point(6, 17);
            txtMaKhachHang.Name = "txtMaKhachHang";
            txtMaKhachHang.Size = new Size(211, 23);
            txtMaKhachHang.TabIndex = 0;
            // 
            // btnHuy
            // 
            btnHuy.Image = Properties.Resources.xoa1;
            btnHuy.Location = new Point(873, 306);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(33, 33);
            btnHuy.TabIndex = 23;
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.Image = Properties.Resources.luu;
            btnLuu.Location = new Point(834, 306);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(33, 33);
            btnLuu.TabIndex = 22;
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Image = Properties.Resources.sua;
            btnSua.Location = new Point(795, 306);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(33, 33);
            btnSua.TabIndex = 21;
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Image = Properties.Resources.xoa;
            btnXoa.Location = new Point(756, 306);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(33, 33);
            btnXoa.TabIndex = 20;
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // cboTimKiemTheo
            // 
            cboTimKiemTheo.FormattingEnabled = true;
            cboTimKiemTheo.Items.AddRange(new object[] { "MaTiec", "LoaiHinhTiec", "NgayDatTiec", "NgayToChuc", "GhiChu", "MaKhachHang", "TrangThai" });
            cboTimKiemTheo.Location = new Point(6, 20);
            cboTimKiemTheo.Name = "cboTimKiemTheo";
            cboTimKiemTheo.Size = new Size(211, 23);
            cboTimKiemTheo.TabIndex = 24;
            // 
            // groupBox21
            // 
            groupBox21.Controls.Add(btnTimKiem);
            groupBox21.Controls.Add(txtTimKiem);
            groupBox21.Controls.Add(cboTimKiemTheo);
            groupBox21.Location = new Point(153, 292);
            groupBox21.Name = "groupBox21";
            groupBox21.Size = new Size(586, 49);
            groupBox21.TabIndex = 25;
            groupBox21.TabStop = false;
            groupBox21.Text = "Tìm kiếm theo";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Image = Properties.Resources.timkiem;
            btnTimKiem.Location = new Point(547, 14);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(33, 33);
            btnTimKiem.TabIndex = 26;
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(223, 20);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(318, 23);
            txtTimKiem.TabIndex = 25;
            // 
            // btnChiTietDatTiec
            // 
            btnChiTietDatTiec.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnChiTietDatTiec.Location = new Point(912, 306);
            btnChiTietDatTiec.Name = "btnChiTietDatTiec";
            btnChiTietDatTiec.Size = new Size(145, 33);
            btnChiTietDatTiec.TabIndex = 26;
            btnChiTietDatTiec.Text = "Chi tiết đặt tiệc";
            btnChiTietDatTiec.UseVisualStyleBackColor = true;
            btnChiTietDatTiec.Click += btnChiTiet_Click;
            // 
            // GUI_QuanLyDatTiec
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnChiTietDatTiec);
            Controls.Add(groupBox21);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(groupBox19);
            Controls.Add(groupBox17);
            Controls.Add(groupBox20);
            Controls.Add(groupBox13);
            Controls.Add(groupBox18);
            Controls.Add(groupBox16);
            Controls.Add(groupBox14);
            Controls.Add(groupBox15);
            Controls.Add(groupBox10);
            Controls.Add(groupBox11);
            Controls.Add(groupBox12);
            Controls.Add(groupBox7);
            Controls.Add(groupBox8);
            Controls.Add(groupBox9);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox);
            Name = "GUI_QuanLyDatTiec";
            Size = new Size(1230, 771);
            Load += GUI_QuanLyDatTiec_Load;
            groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox6.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            groupBox10.ResumeLayout(false);
            groupBox10.PerformLayout();
            groupBox11.ResumeLayout(false);
            groupBox11.PerformLayout();
            groupBox12.ResumeLayout(false);
            groupBox12.PerformLayout();
            groupBox14.ResumeLayout(false);
            groupBox14.PerformLayout();
            groupBox15.ResumeLayout(false);
            groupBox15.PerformLayout();
            groupBox13.ResumeLayout(false);
            groupBox13.PerformLayout();
            groupBox16.ResumeLayout(false);
            groupBox16.PerformLayout();
            groupBox17.ResumeLayout(false);
            groupBox17.PerformLayout();
            groupBox18.ResumeLayout(false);
            groupBox18.PerformLayout();
            groupBox19.ResumeLayout(false);
            groupBox19.PerformLayout();
            groupBox20.ResumeLayout(false);
            groupBox20.PerformLayout();
            groupBox21.ResumeLayout(false);
            groupBox21.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox;
        private DataGridView dataGridView1;
        private GroupBox groupBox6;
        private GroupBox groupBox5;
        private TextBox txtLoaiHinhTiec;
        private GroupBox groupBox4;
        private TextBox txtMaTiec;
        private GroupBox groupBox1;
        private TextBox txtSoLuongBanChay;
        private GroupBox groupBox2;
        private TextBox txtSoLuongBanTang;
        private GroupBox groupBox3;
        private TextBox txtSoLuongBanChinhThuc;
        private GroupBox groupBox7;
        private TextBox txtTongTienDuKien;
        private GroupBox groupBox8;
        private TextBox txtPhiDichVu;
        private GroupBox groupBox9;
        private TextBox txtLoaiBan;
        private GroupBox groupBox10;
        private TextBox txtGhiChu;
        private GroupBox groupBox11;
        private TextBox txtTienCocLan2;
        private GroupBox groupBox12;
        private TextBox txtTienCocLan1;
        private GroupBox groupBox14;
        private TextBox txtThoiGianToChuc;
        private GroupBox groupBox15;
        private TextBox txtNgayToChuc;
        private GroupBox groupBox13;
        private TextBox txtTongBanSetup;
        private GroupBox groupBox16;
        private TextBox txtSoLuongBanDuPhong;
        private GroupBox groupBox17;
        private TextBox txtTongTienPhaiTra;
        private GroupBox groupBox18;
        private TextBox txtTongTienGiam;
        private GroupBox groupBox19;
        private TextBox txtTrangThai;
        private GroupBox groupBox20;
        private TextBox txtMaKhachHang;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private ComboBox cboTimKiemTheo;
        private GroupBox groupBox21;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private DateTimePicker dateTimePickerNgayDatTiec;
        private Button btnChiTietDatTiec;
    }
}
