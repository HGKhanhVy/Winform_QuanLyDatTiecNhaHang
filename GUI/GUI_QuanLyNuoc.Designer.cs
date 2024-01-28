namespace GUI
{
    partial class GUI_QuanLyNuoc
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            btnHuyNuoc = new Button();
            btnLuuNuoc = new Button();
            btnSuaNuoc = new Button();
            btnXoaNuoc = new Button();
            btnThemNuoc = new Button();
            cboMaLoaiNuoc = new ComboBox();
            txtDonGia = new TextBox();
            btnChonAnh = new Button();
            pictureBoxHinhAnh = new PictureBox();
            txtDVT = new TextBox();
            txtTenNuoc = new TextBox();
            txtMaNuoc = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox5 = new GroupBox();
            dataGridViewNuoc = new DataGridView();
            groupBox2 = new GroupBox();
            btnHuyLoaiNuoc = new Button();
            btnLuuLoaiNuoc = new Button();
            btnSuaLoaiNuoc = new Button();
            btnXoaLoaiNuoc = new Button();
            btnThemLoaiNuoc = new Button();
            txtTenLoaiNuoc = new TextBox();
            txtMaLoaiNuoc = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox4 = new GroupBox();
            dataGridViewLoaiNuoc = new DataGridView();
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHinhAnh).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNuoc).BeginInit();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoaiNuoc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
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
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quản lý Nước";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnHuyNuoc);
            groupBox3.Controls.Add(btnLuuNuoc);
            groupBox3.Controls.Add(btnSuaNuoc);
            groupBox3.Controls.Add(btnXoaNuoc);
            groupBox3.Controls.Add(btnThemNuoc);
            groupBox3.Controls.Add(cboMaLoaiNuoc);
            groupBox3.Controls.Add(txtDonGia);
            groupBox3.Controls.Add(btnChonAnh);
            groupBox3.Controls.Add(pictureBoxHinhAnh);
            groupBox3.Controls.Add(txtDVT);
            groupBox3.Controls.Add(txtTenNuoc);
            groupBox3.Controls.Add(txtMaNuoc);
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
            groupBox3.Text = "Nước";
            // 
            // btnHuyNuoc
            // 
            btnHuyNuoc.Image = Properties.Resources.xoa1;
            btnHuyNuoc.Location = new Point(634, 156);
            btnHuyNuoc.Name = "btnHuyNuoc";
            btnHuyNuoc.Size = new Size(33, 33);
            btnHuyNuoc.TabIndex = 18;
            btnHuyNuoc.UseVisualStyleBackColor = true;
            btnHuyNuoc.Click += btnHuyNuoc_Click;
            // 
            // btnLuuNuoc
            // 
            btnLuuNuoc.Image = Properties.Resources.luu;
            btnLuuNuoc.Location = new Point(595, 156);
            btnLuuNuoc.Name = "btnLuuNuoc";
            btnLuuNuoc.Size = new Size(33, 33);
            btnLuuNuoc.TabIndex = 17;
            btnLuuNuoc.UseVisualStyleBackColor = true;
            btnLuuNuoc.Click += btnLuuNuoc_Click;
            // 
            // btnSuaNuoc
            // 
            btnSuaNuoc.Image = Properties.Resources.sua;
            btnSuaNuoc.Location = new Point(556, 156);
            btnSuaNuoc.Name = "btnSuaNuoc";
            btnSuaNuoc.Size = new Size(33, 33);
            btnSuaNuoc.TabIndex = 16;
            btnSuaNuoc.UseVisualStyleBackColor = true;
            btnSuaNuoc.Click += btnSuaNuoc_Click;
            // 
            // btnXoaNuoc
            // 
            btnXoaNuoc.Image = Properties.Resources.xoa;
            btnXoaNuoc.Location = new Point(517, 156);
            btnXoaNuoc.Name = "btnXoaNuoc";
            btnXoaNuoc.Size = new Size(33, 33);
            btnXoaNuoc.TabIndex = 15;
            btnXoaNuoc.UseVisualStyleBackColor = true;
            btnXoaNuoc.Click += btnXoaNuoc_Click;
            // 
            // btnThemNuoc
            // 
            btnThemNuoc.Image = Properties.Resources.them;
            btnThemNuoc.ImageAlign = ContentAlignment.MiddleLeft;
            btnThemNuoc.Location = new Point(478, 156);
            btnThemNuoc.Name = "btnThemNuoc";
            btnThemNuoc.Size = new Size(33, 33);
            btnThemNuoc.TabIndex = 14;
            btnThemNuoc.UseVisualStyleBackColor = true;
            btnThemNuoc.Click += btnThemNuoc_Click;
            // 
            // cboMaLoaiNuoc
            // 
            cboMaLoaiNuoc.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboMaLoaiNuoc.FormattingEnabled = true;
            cboMaLoaiNuoc.Location = new Point(471, 65);
            cboMaLoaiNuoc.Name = "cboMaLoaiNuoc";
            cboMaLoaiNuoc.Size = new Size(196, 23);
            cboMaLoaiNuoc.TabIndex = 13;
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
            // txtTenNuoc
            // 
            txtTenNuoc.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenNuoc.Location = new Point(138, 62);
            txtTenNuoc.Name = "txtTenNuoc";
            txtTenNuoc.Size = new Size(196, 23);
            txtTenNuoc.TabIndex = 8;
            // 
            // txtMaNuoc
            // 
            txtMaNuoc.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaNuoc.Location = new Point(138, 24);
            txtMaNuoc.Name = "txtMaNuoc";
            txtMaNuoc.Size = new Size(196, 23);
            txtMaNuoc.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(364, 65);
            label8.Name = "label8";
            label8.Size = new Size(78, 15);
            label8.TabIndex = 6;
            label8.Text = "Mã loại nước";
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
            label4.Size = new Size(59, 15);
            label4.TabIndex = 2;
            label4.Text = "Tên nước";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 27);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 1;
            label3.Text = "Mã nước";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dataGridViewNuoc);
            groupBox5.Location = new Point(6, 242);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(725, 448);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "Danh sách nước";
            // 
            // dataGridViewNuoc
            // 
            dataGridViewNuoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewNuoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNuoc.Location = new Point(6, 22);
            dataGridViewNuoc.Name = "dataGridViewNuoc";
            dataGridViewNuoc.RowTemplate.Height = 25;
            dataGridViewNuoc.Size = new Size(713, 420);
            dataGridViewNuoc.TabIndex = 0;
            dataGridViewNuoc.CellClick += dataGridViewNuoc_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnHuyLoaiNuoc);
            groupBox2.Controls.Add(btnLuuLoaiNuoc);
            groupBox2.Controls.Add(btnSuaLoaiNuoc);
            groupBox2.Controls.Add(btnXoaLoaiNuoc);
            groupBox2.Controls.Add(btnThemLoaiNuoc);
            groupBox2.Controls.Add(txtTenLoaiNuoc);
            groupBox2.Controls.Add(txtMaLoaiNuoc);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Location = new Point(35, 37);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(393, 696);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Loại nước";
            // 
            // btnHuyLoaiNuoc
            // 
            btnHuyLoaiNuoc.Image = Properties.Resources.xoa;
            btnHuyLoaiNuoc.Location = new Point(331, 156);
            btnHuyLoaiNuoc.Name = "btnHuyLoaiNuoc";
            btnHuyLoaiNuoc.Size = new Size(33, 33);
            btnHuyLoaiNuoc.TabIndex = 9;
            btnHuyLoaiNuoc.UseVisualStyleBackColor = true;
            btnHuyLoaiNuoc.Click += btnHuyLoaiNuoc_Click;
            // 
            // btnLuuLoaiNuoc
            // 
            btnLuuLoaiNuoc.Image = Properties.Resources.luu;
            btnLuuLoaiNuoc.Location = new Point(292, 156);
            btnLuuLoaiNuoc.Name = "btnLuuLoaiNuoc";
            btnLuuLoaiNuoc.Size = new Size(33, 33);
            btnLuuLoaiNuoc.TabIndex = 8;
            btnLuuLoaiNuoc.UseVisualStyleBackColor = true;
            btnLuuLoaiNuoc.Click += btnLuuLoaiNuoc_Click;
            // 
            // btnSuaLoaiNuoc
            // 
            btnSuaLoaiNuoc.Image = Properties.Resources.sua;
            btnSuaLoaiNuoc.Location = new Point(253, 156);
            btnSuaLoaiNuoc.Name = "btnSuaLoaiNuoc";
            btnSuaLoaiNuoc.Size = new Size(33, 33);
            btnSuaLoaiNuoc.TabIndex = 7;
            btnSuaLoaiNuoc.UseVisualStyleBackColor = true;
            btnSuaLoaiNuoc.Click += btnSuaLoaiNuoc_Click;
            // 
            // btnXoaLoaiNuoc
            // 
            btnXoaLoaiNuoc.Image = Properties.Resources.xoa;
            btnXoaLoaiNuoc.Location = new Point(214, 156);
            btnXoaLoaiNuoc.Name = "btnXoaLoaiNuoc";
            btnXoaLoaiNuoc.Size = new Size(33, 33);
            btnXoaLoaiNuoc.TabIndex = 6;
            btnXoaLoaiNuoc.UseVisualStyleBackColor = true;
            btnXoaLoaiNuoc.Click += btnXoaLoaiNuoc_Click;
            // 
            // btnThemLoaiNuoc
            // 
            btnThemLoaiNuoc.Image = Properties.Resources.them;
            btnThemLoaiNuoc.ImageAlign = ContentAlignment.MiddleLeft;
            btnThemLoaiNuoc.Location = new Point(175, 156);
            btnThemLoaiNuoc.Name = "btnThemLoaiNuoc";
            btnThemLoaiNuoc.Size = new Size(33, 33);
            btnThemLoaiNuoc.TabIndex = 5;
            btnThemLoaiNuoc.UseVisualStyleBackColor = true;
            btnThemLoaiNuoc.Click += btnThemLoaiNuoc_Click;
            // 
            // txtTenLoaiNuoc
            // 
            txtTenLoaiNuoc.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenLoaiNuoc.Location = new Point(137, 86);
            txtTenLoaiNuoc.Name = "txtTenLoaiNuoc";
            txtTenLoaiNuoc.Size = new Size(227, 23);
            txtTenLoaiNuoc.TabIndex = 4;
            // 
            // txtMaLoaiNuoc
            // 
            txtMaLoaiNuoc.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaLoaiNuoc.Location = new Point(137, 35);
            txtMaLoaiNuoc.Name = "txtMaLoaiNuoc";
            txtMaLoaiNuoc.Size = new Size(227, 23);
            txtMaLoaiNuoc.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 89);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 2;
            label2.Text = "Tên loại nước";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 38);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 1;
            label1.Text = "Mã loại nước";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridViewLoaiNuoc);
            groupBox4.Location = new Point(6, 242);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(381, 448);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Danh sách loại nước";
            // 
            // dataGridViewLoaiNuoc
            // 
            dataGridViewLoaiNuoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewLoaiNuoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLoaiNuoc.Location = new Point(6, 22);
            dataGridViewLoaiNuoc.Name = "dataGridViewLoaiNuoc";
            dataGridViewLoaiNuoc.RowTemplate.Height = 25;
            dataGridViewLoaiNuoc.Size = new Size(369, 420);
            dataGridViewLoaiNuoc.TabIndex = 0;
            dataGridViewLoaiNuoc.CellClick += dataGridViewLoaiNuoc_CellClick;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // GUI_QuanLyNuoc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            MaximumSize = new Size(1230, 771);
            Name = "GUI_QuanLyNuoc";
            Size = new Size(1230, 771);
            Load += GUI_QuanLyNuoc_Load;
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHinhAnh).EndInit();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewNuoc).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoaiNuoc).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private GroupBox groupBox5;
        private Label label2;
        private Label label1;
        private GroupBox groupBox4;
        private Label label8;
        private Label label7;
        private Button btnHuyLoaiNuoc;
        private Button btnLuuLoaiNuoc;
        private Button btnSuaLoaiNuoc;
        private Button btnXoaLoaiNuoc;
        private Button btnThemLoaiNuoc;
        private TextBox txtTenLoaiNuoc;
        private TextBox txtMaLoaiNuoc;
        private Button btnHuyNuoc;
        private Button btnLuuNuoc;
        private Button btnSuaNuoc;
        private Button btnXoaNuoc;
        private Button btnThemNuoc;
        private ComboBox cboMaLoaiNuoc;
        private TextBox txtDonGia;
        private Button btnChonAnh;
        private PictureBox pictureBoxHinhAnh;
        private TextBox txtDVT;
        private TextBox txtTenNuoc;
        private TextBox txtMaNuoc;
        private DataGridView dataGridViewNuoc;
        private DataGridView dataGridViewLoaiNuoc;
        private ErrorProvider errorProvider1;
    }
}
