namespace GUI
{
    partial class GUI_KhungTrangQuanLy
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            lblTenNhanVien = new Label();
            panelQuanLyDichVu = new Panel();
            btnMenuDichVuUuDai = new Button();
            btnQuanLyDichVu = new Button();
            btnMenuDichVuTinhPhi = new Button();
            btnMenuDichVu = new Button();
            panelQuanLyThucDon = new Panel();
            btnQuanLyMenu = new Button();
            btnQuanLyThucDon = new Button();
            btnDoUong = new Button();
            btnMonAn = new Button();
            panelQuanLyDatTiec = new Panel();
            btnQuanLyDatTiec = new Button();
            btnDanhSachDatTiec = new Button();
            panelKhungTrang = new Panel();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelQuanLyDichVu.SuspendLayout();
            panelQuanLyThucDon.SuspendLayout();
            panelQuanLyDatTiec.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(35, 40, 45);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panelQuanLyDichVu);
            flowLayoutPanel1.Controls.Add(panelQuanLyThucDon);
            flowLayoutPanel1.Controls.Add(panelQuanLyDatTiec);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.MaximumSize = new Size(320, 1067);
            flowLayoutPanel1.MinimumSize = new Size(80, 1067);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(320, 1067);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(lblTenNhanVien);
            panel2.Location = new Point(3, 4);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(317, 149);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.anhkhongtontai;
            pictureBox1.Location = new Point(53, 33);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblTenNhanVien
            // 
            lblTenNhanVien.AutoSize = true;
            lblTenNhanVien.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTenNhanVien.ForeColor = Color.White;
            lblTenNhanVien.Location = new Point(134, 59);
            lblTenNhanVien.Name = "lblTenNhanVien";
            lblTenNhanVien.Size = new Size(119, 23);
            lblTenNhanVien.TabIndex = 0;
            lblTenNhanVien.Text = "Tên nhân viên";
            // 
            // panelQuanLyDichVu
            // 
            panelQuanLyDichVu.BackColor = Color.FromArgb(35, 40, 45);
            panelQuanLyDichVu.Controls.Add(btnMenuDichVuUuDai);
            panelQuanLyDichVu.Controls.Add(btnQuanLyDichVu);
            panelQuanLyDichVu.Controls.Add(btnMenuDichVuTinhPhi);
            panelQuanLyDichVu.Controls.Add(btnMenuDichVu);
            panelQuanLyDichVu.ForeColor = Color.White;
            panelQuanLyDichVu.Location = new Point(3, 161);
            panelQuanLyDichVu.Margin = new Padding(3, 4, 3, 4);
            panelQuanLyDichVu.Name = "panelQuanLyDichVu";
            panelQuanLyDichVu.Size = new Size(317, 212);
            panelQuanLyDichVu.TabIndex = 3;
            // 
            // btnMenuDichVuUuDai
            // 
            btnMenuDichVuUuDai.BackColor = Color.SlateGray;
            btnMenuDichVuUuDai.FlatStyle = FlatStyle.Flat;
            btnMenuDichVuUuDai.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMenuDichVuUuDai.ForeColor = Color.White;
            btnMenuDichVuUuDai.Location = new Point(39, 156);
            btnMenuDichVuUuDai.Margin = new Padding(3, 4, 3, 4);
            btnMenuDichVuUuDai.Name = "btnMenuDichVuUuDai";
            btnMenuDichVuUuDai.Size = new Size(315, 47);
            btnMenuDichVuUuDai.TabIndex = 7;
            btnMenuDichVuUuDai.Text = "               Dịch vụ ưu đãi";
            btnMenuDichVuUuDai.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuDichVuUuDai.UseVisualStyleBackColor = false;
            btnMenuDichVuUuDai.Click += btnMenuDichVuUuDai_Click;
            // 
            // btnQuanLyDichVu
            // 
            btnQuanLyDichVu.BackColor = Color.FromArgb(35, 40, 45);
            btnQuanLyDichVu.FlatStyle = FlatStyle.Flat;
            btnQuanLyDichVu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnQuanLyDichVu.ForeColor = Color.White;
            btnQuanLyDichVu.Location = new Point(0, 0);
            btnQuanLyDichVu.Margin = new Padding(3, 4, 3, 4);
            btnQuanLyDichVu.Name = "btnQuanLyDichVu";
            btnQuanLyDichVu.Size = new Size(315, 57);
            btnQuanLyDichVu.TabIndex = 4;
            btnQuanLyDichVu.Text = "               Quản lý dịch vụ";
            btnQuanLyDichVu.TextAlign = ContentAlignment.MiddleLeft;
            btnQuanLyDichVu.UseVisualStyleBackColor = false;
            btnQuanLyDichVu.Click += button1_Click;
            // 
            // btnMenuDichVuTinhPhi
            // 
            btnMenuDichVuTinhPhi.BackColor = Color.SlateGray;
            btnMenuDichVuTinhPhi.FlatStyle = FlatStyle.Flat;
            btnMenuDichVuTinhPhi.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMenuDichVuTinhPhi.ForeColor = Color.White;
            btnMenuDichVuTinhPhi.Location = new Point(39, 111);
            btnMenuDichVuTinhPhi.Margin = new Padding(3, 4, 3, 4);
            btnMenuDichVuTinhPhi.Name = "btnMenuDichVuTinhPhi";
            btnMenuDichVuTinhPhi.Size = new Size(315, 47);
            btnMenuDichVuTinhPhi.TabIndex = 6;
            btnMenuDichVuTinhPhi.Text = "               Dịch vụ tính phí";
            btnMenuDichVuTinhPhi.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuDichVuTinhPhi.UseVisualStyleBackColor = false;
            btnMenuDichVuTinhPhi.Click += btnMenuDichVuTinhPhi_Click;
            // 
            // btnMenuDichVu
            // 
            btnMenuDichVu.BackColor = Color.SlateGray;
            btnMenuDichVu.FlatStyle = FlatStyle.Flat;
            btnMenuDichVu.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMenuDichVu.ForeColor = Color.White;
            btnMenuDichVu.Location = new Point(39, 65);
            btnMenuDichVu.Margin = new Padding(3, 4, 3, 4);
            btnMenuDichVu.Name = "btnMenuDichVu";
            btnMenuDichVu.Size = new Size(315, 47);
            btnMenuDichVu.TabIndex = 5;
            btnMenuDichVu.Text = "               Dịch vụ";
            btnMenuDichVu.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuDichVu.UseVisualStyleBackColor = false;
            btnMenuDichVu.Click += btnMenuDichVu_Click;
            // 
            // panelQuanLyThucDon
            // 
            panelQuanLyThucDon.BackColor = Color.FromArgb(35, 40, 45);
            panelQuanLyThucDon.Controls.Add(btnQuanLyMenu);
            panelQuanLyThucDon.Controls.Add(btnQuanLyThucDon);
            panelQuanLyThucDon.Controls.Add(btnDoUong);
            panelQuanLyThucDon.Controls.Add(btnMonAn);
            panelQuanLyThucDon.ForeColor = Color.White;
            panelQuanLyThucDon.Location = new Point(3, 381);
            panelQuanLyThucDon.Margin = new Padding(3, 4, 3, 4);
            panelQuanLyThucDon.MinimumSize = new Size(317, 67);
            panelQuanLyThucDon.Name = "panelQuanLyThucDon";
            panelQuanLyThucDon.Size = new Size(317, 215);
            panelQuanLyThucDon.TabIndex = 4;
            // 
            // btnQuanLyMenu
            // 
            btnQuanLyMenu.BackColor = Color.SlateGray;
            btnQuanLyMenu.FlatStyle = FlatStyle.Flat;
            btnQuanLyMenu.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnQuanLyMenu.ForeColor = Color.White;
            btnQuanLyMenu.Location = new Point(41, 156);
            btnQuanLyMenu.Margin = new Padding(3, 4, 3, 4);
            btnQuanLyMenu.Name = "btnQuanLyMenu";
            btnQuanLyMenu.Size = new Size(315, 47);
            btnQuanLyMenu.TabIndex = 8;
            btnQuanLyMenu.Text = "               Quản lý menu";
            btnQuanLyMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnQuanLyMenu.UseVisualStyleBackColor = false;
            btnQuanLyMenu.Click += btnQuanLyMenu_Click;
            // 
            // btnQuanLyThucDon
            // 
            btnQuanLyThucDon.BackColor = Color.FromArgb(35, 40, 45);
            btnQuanLyThucDon.FlatStyle = FlatStyle.Flat;
            btnQuanLyThucDon.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnQuanLyThucDon.ForeColor = Color.White;
            btnQuanLyThucDon.Location = new Point(0, 0);
            btnQuanLyThucDon.Margin = new Padding(3, 4, 3, 4);
            btnQuanLyThucDon.Name = "btnQuanLyThucDon";
            btnQuanLyThucDon.Size = new Size(315, 63);
            btnQuanLyThucDon.TabIndex = 4;
            btnQuanLyThucDon.Text = "               Quản lý thực đơn";
            btnQuanLyThucDon.TextAlign = ContentAlignment.MiddleLeft;
            btnQuanLyThucDon.UseVisualStyleBackColor = false;
            btnQuanLyThucDon.Click += btnQuanLyThucDon_Click;
            // 
            // btnDoUong
            // 
            btnDoUong.BackColor = Color.SlateGray;
            btnDoUong.FlatStyle = FlatStyle.Flat;
            btnDoUong.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDoUong.ForeColor = Color.White;
            btnDoUong.Location = new Point(41, 111);
            btnDoUong.Margin = new Padding(3, 4, 3, 4);
            btnDoUong.Name = "btnDoUong";
            btnDoUong.Size = new Size(315, 47);
            btnDoUong.TabIndex = 6;
            btnDoUong.Text = "               Đồ uống";
            btnDoUong.TextAlign = ContentAlignment.MiddleLeft;
            btnDoUong.UseVisualStyleBackColor = false;
            btnDoUong.Click += btnDoUong_Click;
            // 
            // btnMonAn
            // 
            btnMonAn.BackColor = Color.SlateGray;
            btnMonAn.FlatStyle = FlatStyle.Flat;
            btnMonAn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMonAn.ForeColor = Color.White;
            btnMonAn.Location = new Point(41, 65);
            btnMonAn.Margin = new Padding(3, 4, 3, 4);
            btnMonAn.Name = "btnMonAn";
            btnMonAn.Size = new Size(315, 47);
            btnMonAn.TabIndex = 5;
            btnMonAn.Text = "               Món ăn";
            btnMonAn.TextAlign = ContentAlignment.MiddleLeft;
            btnMonAn.UseVisualStyleBackColor = false;
            btnMonAn.Click += btnMonAn_Click;
            // 
            // panelQuanLyDatTiec
            // 
            panelQuanLyDatTiec.BackColor = Color.FromArgb(35, 40, 45);
            panelQuanLyDatTiec.Controls.Add(btnQuanLyDatTiec);
            panelQuanLyDatTiec.Controls.Add(btnDanhSachDatTiec);
            panelQuanLyDatTiec.ForeColor = Color.White;
            panelQuanLyDatTiec.Location = new Point(3, 604);
            panelQuanLyDatTiec.Margin = new Padding(3, 4, 3, 4);
            panelQuanLyDatTiec.MinimumSize = new Size(317, 67);
            panelQuanLyDatTiec.Name = "panelQuanLyDatTiec";
            panelQuanLyDatTiec.Size = new Size(317, 128);
            panelQuanLyDatTiec.TabIndex = 5;
            // 
            // btnQuanLyDatTiec
            // 
            btnQuanLyDatTiec.BackColor = Color.FromArgb(35, 40, 45);
            btnQuanLyDatTiec.FlatStyle = FlatStyle.Flat;
            btnQuanLyDatTiec.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnQuanLyDatTiec.ForeColor = Color.White;
            btnQuanLyDatTiec.Location = new Point(0, 0);
            btnQuanLyDatTiec.Margin = new Padding(3, 4, 3, 4);
            btnQuanLyDatTiec.Name = "btnQuanLyDatTiec";
            btnQuanLyDatTiec.Size = new Size(315, 57);
            btnQuanLyDatTiec.TabIndex = 4;
            btnQuanLyDatTiec.Text = "               Quản lý đặt tiệc";
            btnQuanLyDatTiec.TextAlign = ContentAlignment.MiddleLeft;
            btnQuanLyDatTiec.UseVisualStyleBackColor = false;
            btnQuanLyDatTiec.Click += btnQuanLyDatTiec_Click;
            // 
            // btnDanhSachDatTiec
            // 
            btnDanhSachDatTiec.BackColor = Color.SlateGray;
            btnDanhSachDatTiec.FlatStyle = FlatStyle.Flat;
            btnDanhSachDatTiec.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDanhSachDatTiec.ForeColor = Color.White;
            btnDanhSachDatTiec.Location = new Point(41, 65);
            btnDanhSachDatTiec.Margin = new Padding(3, 4, 3, 4);
            btnDanhSachDatTiec.Name = "btnDanhSachDatTiec";
            btnDanhSachDatTiec.Size = new Size(315, 47);
            btnDanhSachDatTiec.TabIndex = 5;
            btnDanhSachDatTiec.Text = "               Danh sách đặt tiệc";
            btnDanhSachDatTiec.TextAlign = ContentAlignment.MiddleLeft;
            btnDanhSachDatTiec.UseVisualStyleBackColor = false;
            btnDanhSachDatTiec.Click += btnDanhSachDatTiec_Click;
            // 
            // panelKhungTrang
            // 
            panelKhungTrang.Location = new Point(339, 23);
            panelKhungTrang.Margin = new Padding(3, 4, 3, 4);
            panelKhungTrang.Name = "panelKhungTrang";
            panelKhungTrang.Size = new Size(1406, 1028);
            panelKhungTrang.TabIndex = 3;
            // 
            // GUI_KhungTrangQuanLy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1761, 1055);
            Controls.Add(panelKhungTrang);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "GUI_KhungTrangQuanLy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GUI_KhungTrangQuanLy";
            Load += GUI_KhungTrangQuanLy_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelQuanLyDichVu.ResumeLayout(false);
            panelQuanLyThucDon.ResumeLayout(false);
            panelQuanLyDatTiec.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private Button btnQuanLyDichVu;
        private Panel panelQuanLyDichVu;
        private Button btnMenuDichVu;
        private Button btnMenuDichVuTinhPhi;
        private Button btnMenuDichVuUuDai;
        private PictureBox pictureBox1;
        private Label lblTenNhanVien;
        private Panel panelQuanLyThucDon;
        private Button btnQuanLyThucDon;
        private Button btnDoUong;
        private Button btnMonAn;
        private Panel panelKhungTrang;
        private Button btnQuanLyMenu;
        private Panel panelQuanLyDatTiec;
        private Button btnQuanLyDatTiec;
        private Button btnDanhSachDatTiec;
    }
}