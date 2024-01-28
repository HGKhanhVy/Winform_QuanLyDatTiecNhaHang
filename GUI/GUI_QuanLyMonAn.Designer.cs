namespace GUI
{
    partial class GUI_QuanLyMonAn
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
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            btnHuyMonAn = new Button();
            btnLuuMonAn = new Button();
            btnSuaMonAn = new Button();
            btnXoaMonAn = new Button();
            btnThemMonAn = new Button();
            cboMaLoaiMonAn = new ComboBox();
            txtDonGia = new TextBox();
            btnChonAnh = new Button();
            pictureBoxHinhAnh = new PictureBox();
            txtDVT = new TextBox();
            txtTenMonAn = new TextBox();
            txtMaMonAn = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox5 = new GroupBox();
            dataGridViewMonAn = new DataGridView();
            groupBox2 = new GroupBox();
            btnHuyLoaiMonAn = new Button();
            btnLuuLoaiMonAn = new Button();
            btnSuaLoaiMonAn = new Button();
            btnXoaLoaiMonAn = new Button();
            btnThemLoaiMonAn = new Button();
            txtTenLoaiMonAn = new TextBox();
            txtMaLoaiMonAn = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox4 = new GroupBox();
            dataGridViewLoaiMonAn = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHinhAnh).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMonAn).BeginInit();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoaiMonAn).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1224, 765);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quản lý món ăn";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnHuyMonAn);
            groupBox3.Controls.Add(btnLuuMonAn);
            groupBox3.Controls.Add(btnSuaMonAn);
            groupBox3.Controls.Add(btnXoaMonAn);
            groupBox3.Controls.Add(btnThemMonAn);
            groupBox3.Controls.Add(cboMaLoaiMonAn);
            groupBox3.Controls.Add(txtDonGia);
            groupBox3.Controls.Add(btnChonAnh);
            groupBox3.Controls.Add(pictureBoxHinhAnh);
            groupBox3.Controls.Add(txtDVT);
            groupBox3.Controls.Add(txtTenMonAn);
            groupBox3.Controls.Add(txtMaMonAn);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(groupBox5);
            groupBox3.Location = new Point(460, 37);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(737, 696);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Món ăn";
            // 
            // btnHuyMonAn
            // 
            btnHuyMonAn.Image = Properties.Resources.xoa;
            btnHuyMonAn.Location = new Point(634, 156);
            btnHuyMonAn.Name = "btnHuyMonAn";
            btnHuyMonAn.Size = new Size(33, 33);
            btnHuyMonAn.TabIndex = 18;
            btnHuyMonAn.UseVisualStyleBackColor = true;
            btnHuyMonAn.Click += btnHuyMonAn_Click;
            // 
            // btnLuuMonAn
            // 
            btnLuuMonAn.Image = Properties.Resources.luu;
            btnLuuMonAn.Location = new Point(595, 156);
            btnLuuMonAn.Name = "btnLuuMonAn";
            btnLuuMonAn.Size = new Size(33, 33);
            btnLuuMonAn.TabIndex = 17;
            btnLuuMonAn.UseVisualStyleBackColor = true;
            btnLuuMonAn.Click += btnLuuMonAn_Click;
            // 
            // btnSuaMonAn
            // 
            btnSuaMonAn.Image = Properties.Resources.sua;
            btnSuaMonAn.Location = new Point(556, 156);
            btnSuaMonAn.Name = "btnSuaMonAn";
            btnSuaMonAn.Size = new Size(33, 33);
            btnSuaMonAn.TabIndex = 16;
            btnSuaMonAn.UseVisualStyleBackColor = true;
            btnSuaMonAn.Click += btnSuaMonAn_Click;
            // 
            // btnXoaMonAn
            // 
            btnXoaMonAn.Image = Properties.Resources.xoa;
            btnXoaMonAn.Location = new Point(517, 156);
            btnXoaMonAn.Name = "btnXoaMonAn";
            btnXoaMonAn.Size = new Size(33, 33);
            btnXoaMonAn.TabIndex = 15;
            btnXoaMonAn.UseVisualStyleBackColor = true;
            btnXoaMonAn.Click += btnXoaMonAn_Click;
            // 
            // btnThemMonAn
            // 
            btnThemMonAn.Image = Properties.Resources.them;
            btnThemMonAn.ImageAlign = ContentAlignment.MiddleLeft;
            btnThemMonAn.Location = new Point(478, 156);
            btnThemMonAn.Name = "btnThemMonAn";
            btnThemMonAn.Size = new Size(33, 33);
            btnThemMonAn.TabIndex = 14;
            btnThemMonAn.UseVisualStyleBackColor = true;
            btnThemMonAn.Click += btnThemMonAn_Click;
            // 
            // cboMaLoaiMonAn
            // 
            cboMaLoaiMonAn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboMaLoaiMonAn.FormattingEnabled = true;
            cboMaLoaiMonAn.Location = new Point(471, 65);
            cboMaLoaiMonAn.Name = "cboMaLoaiMonAn";
            cboMaLoaiMonAn.Size = new Size(196, 23);
            cboMaLoaiMonAn.TabIndex = 13;
            // 
            // txtDonGia
            // 
            txtDonGia.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtDonGia.Location = new Point(471, 25);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(196, 23);
            txtDonGia.TabIndex = 12;
            txtDonGia.KeyPress += txtDonGia_KeyPress;
            // 
            // btnChonAnh
            // 
            btnChonAnh.Location = new Point(259, 137);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(75, 23);
            btnChonAnh.TabIndex = 11;
            btnChonAnh.Text = "Chọn ảnh";
            btnChonAnh.UseVisualStyleBackColor = true;
            btnChonAnh.Click += btnChonAnh_Click;
            // 
            // pictureBoxHinhAnh
            // 
            pictureBoxHinhAnh.Image = Properties.Resources.anhkhongtontai;
            pictureBoxHinhAnh.Location = new Point(138, 141);
            pictureBoxHinhAnh.Name = "pictureBoxHinhAnh";
            pictureBoxHinhAnh.Size = new Size(100, 100);
            pictureBoxHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxHinhAnh.TabIndex = 10;
            pictureBoxHinhAnh.TabStop = false;
            // 
            // txtDVT
            // 
            txtDVT.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtDVT.Location = new Point(138, 100);
            txtDVT.Name = "txtDVT";
            txtDVT.Size = new Size(196, 23);
            txtDVT.TabIndex = 9;
            // 
            // txtTenMonAn
            // 
            txtTenMonAn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenMonAn.Location = new Point(138, 62);
            txtTenMonAn.Name = "txtTenMonAn";
            txtTenMonAn.Size = new Size(196, 23);
            txtTenMonAn.TabIndex = 8;
            // 
            // txtMaMonAn
            // 
            txtMaMonAn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaMonAn.Location = new Point(138, 24);
            txtMaMonAn.Name = "txtMaMonAn";
            txtMaMonAn.Size = new Size(196, 23);
            txtMaMonAn.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(364, 65);
            label8.Name = "label8";
            label8.Size = new Size(90, 15);
            label8.TabIndex = 6;
            label8.Text = "Mã loại món ăn";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(364, 27);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 5;
            label7.Text = "Đơn giá";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 141);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 4;
            label6.Text = "Hình ảnh";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 103);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 3;
            label5.Text = "DVT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 65);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 2;
            label4.Text = "Tên món ăn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 27);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 1;
            label3.Text = "Mã món ăn";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dataGridViewMonAn);
            groupBox5.Location = new Point(6, 242);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(725, 448);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "Danh sách món ăn";
            // 
            // dataGridViewMonAn
            // 
            dataGridViewMonAn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMonAn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMonAn.Location = new Point(6, 22);
            dataGridViewMonAn.Name = "dataGridViewMonAn";
            dataGridViewMonAn.RowTemplate.Height = 25;
            dataGridViewMonAn.Size = new Size(713, 420);
            dataGridViewMonAn.TabIndex = 0;
            dataGridViewMonAn.CellClick += dataGridViewMonAn_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnHuyLoaiMonAn);
            groupBox2.Controls.Add(btnLuuLoaiMonAn);
            groupBox2.Controls.Add(btnSuaLoaiMonAn);
            groupBox2.Controls.Add(btnXoaLoaiMonAn);
            groupBox2.Controls.Add(btnThemLoaiMonAn);
            groupBox2.Controls.Add(txtTenLoaiMonAn);
            groupBox2.Controls.Add(txtMaLoaiMonAn);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Location = new Point(35, 37);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(393, 696);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Loại món ăn";
            // 
            // btnHuyLoaiMonAn
            // 
            btnHuyLoaiMonAn.Image = Properties.Resources.xoa;
            btnHuyLoaiMonAn.Location = new Point(331, 156);
            btnHuyLoaiMonAn.Name = "btnHuyLoaiMonAn";
            btnHuyLoaiMonAn.Size = new Size(33, 33);
            btnHuyLoaiMonAn.TabIndex = 9;
            btnHuyLoaiMonAn.UseVisualStyleBackColor = true;
            btnHuyLoaiMonAn.Click += btnHuyLoaiMonAn_Click;
            // 
            // btnLuuLoaiMonAn
            // 
            btnLuuLoaiMonAn.Image = Properties.Resources.luu;
            btnLuuLoaiMonAn.Location = new Point(292, 156);
            btnLuuLoaiMonAn.Name = "btnLuuLoaiMonAn";
            btnLuuLoaiMonAn.Size = new Size(33, 33);
            btnLuuLoaiMonAn.TabIndex = 8;
            btnLuuLoaiMonAn.UseVisualStyleBackColor = true;
            btnLuuLoaiMonAn.Click += btnLuuLoaiMonAn_Click;
            // 
            // btnSuaLoaiMonAn
            // 
            btnSuaLoaiMonAn.Image = Properties.Resources.sua;
            btnSuaLoaiMonAn.Location = new Point(253, 156);
            btnSuaLoaiMonAn.Name = "btnSuaLoaiMonAn";
            btnSuaLoaiMonAn.Size = new Size(33, 33);
            btnSuaLoaiMonAn.TabIndex = 7;
            btnSuaLoaiMonAn.UseVisualStyleBackColor = true;
            btnSuaLoaiMonAn.Click += btnSuaLoaiMonAn_Click;
            // 
            // btnXoaLoaiMonAn
            // 
            btnXoaLoaiMonAn.Image = Properties.Resources.xoa;
            btnXoaLoaiMonAn.Location = new Point(214, 156);
            btnXoaLoaiMonAn.Name = "btnXoaLoaiMonAn";
            btnXoaLoaiMonAn.Size = new Size(33, 33);
            btnXoaLoaiMonAn.TabIndex = 6;
            btnXoaLoaiMonAn.UseVisualStyleBackColor = true;
            btnXoaLoaiMonAn.Click += btnXoaLoaiMonAn_Click;
            // 
            // btnThemLoaiMonAn
            // 
            btnThemLoaiMonAn.Image = Properties.Resources.them;
            btnThemLoaiMonAn.ImageAlign = ContentAlignment.MiddleLeft;
            btnThemLoaiMonAn.Location = new Point(175, 156);
            btnThemLoaiMonAn.Name = "btnThemLoaiMonAn";
            btnThemLoaiMonAn.Size = new Size(33, 33);
            btnThemLoaiMonAn.TabIndex = 5;
            btnThemLoaiMonAn.UseVisualStyleBackColor = true;
            btnThemLoaiMonAn.Click += btnThemLoaiMonAn_Click;
            // 
            // txtTenLoaiMonAn
            // 
            txtTenLoaiMonAn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenLoaiMonAn.Location = new Point(137, 86);
            txtTenLoaiMonAn.Name = "txtTenLoaiMonAn";
            txtTenLoaiMonAn.Size = new Size(227, 23);
            txtTenLoaiMonAn.TabIndex = 4;
            // 
            // txtMaLoaiMonAn
            // 
            txtMaLoaiMonAn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaLoaiMonAn.Location = new Point(137, 35);
            txtMaLoaiMonAn.Name = "txtMaLoaiMonAn";
            txtMaLoaiMonAn.Size = new Size(227, 23);
            txtMaLoaiMonAn.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 89);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 2;
            label2.Text = "Tên loại món ăn";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 38);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 1;
            label1.Text = "Mã loại món ăn";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridViewLoaiMonAn);
            groupBox4.Location = new Point(6, 242);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(381, 448);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Danh sách món ăn";
            // 
            // dataGridViewLoaiMonAn
            // 
            dataGridViewLoaiMonAn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewLoaiMonAn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLoaiMonAn.Location = new Point(6, 22);
            dataGridViewLoaiMonAn.Name = "dataGridViewLoaiMonAn";
            dataGridViewLoaiMonAn.RowTemplate.Height = 25;
            dataGridViewLoaiMonAn.Size = new Size(369, 420);
            dataGridViewLoaiMonAn.TabIndex = 0;
            dataGridViewLoaiMonAn.CellClick += dataGridViewLoaiMonAn_CellClick;
            // 
            // GUI_QuanLyMonAn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            MaximumSize = new Size(1230, 771);
            MinimumSize = new Size(1230, 771);
            Name = "GUI_QuanLyMonAn";
            Size = new Size(1230, 771);
            Load += GUI_QuanLyMonAn_Load;
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHinhAnh).EndInit();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMonAn).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoaiMonAn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private Button btnHuyMonAn;
        private Button btnLuuMonAn;
        private Button btnSuaMonAn;
        private Button btnXoaMonAn;
        private Button btnThemMonAn;
        private ComboBox cboMaLoaiMonAn;
        private TextBox txtDonGia;
        private Button btnChonAnh;
        private PictureBox pictureBoxHinhAnh;
        private TextBox txtDVT;
        private TextBox txtTenMonAn;
        private TextBox txtMaMonAn;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private GroupBox groupBox5;
        private DataGridView dataGridViewMonAn;
        private GroupBox groupBox2;
        private Button btnHuyLoaiMonAn;
        private Button btnLuuLoaiMonAn;
        private Button btnSuaLoaiMonAn;
        private Button btnXoaLoaiMonAn;
        private Button btnThemLoaiMonAn;
        private TextBox txtTenLoaiMonAn;
        private TextBox txtMaLoaiMonAn;
        private Label label2;
        private Label label1;
        private GroupBox groupBox4;
        private DataGridView dataGridViewLoaiMonAn;
    }
}
