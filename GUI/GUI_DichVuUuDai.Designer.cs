namespace GUI
{
    partial class GUI_DichVuUuDai
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
            groupBox2 = new GroupBox();
            btnHuy = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            groupBox9 = new GroupBox();
            cboMaDichVu = new ComboBox();
            groupBox8 = new GroupBox();
            btnChonAnh = new Button();
            pictureBoxHinhAnh = new PictureBox();
            groupBox7 = new GroupBox();
            txtMoTa = new TextBox();
            groupBox6 = new GroupBox();
            txtDieuKienBanToiThieu = new TextBox();
            groupBox5 = new GroupBox();
            txtTenDichVu = new TextBox();
            groupBox4 = new GroupBox();
            txtMaDichVuUuDai = new TextBox();
            groupBox3 = new GroupBox();
            dataGridViewDichVuUuDai = new DataGridView();
            groupBox10 = new GroupBox();
            txtDieuKienBanToiDa = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox9.SuspendLayout();
            groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHinhAnh).BeginInit();
            groupBox7.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDichVuUuDai).BeginInit();
            groupBox10.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(3, 4);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1399, 1020);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quản lý dịch vụ ưu đãi";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox10);
            groupBox2.Controls.Add(btnHuy);
            groupBox2.Controls.Add(btnLuu);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Controls.Add(groupBox9);
            groupBox2.Controls.Add(groupBox8);
            groupBox2.Controls.Add(groupBox7);
            groupBox2.Controls.Add(groupBox6);
            groupBox2.Controls.Add(groupBox5);
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Location = new Point(87, 81);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(1222, 845);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dịch vụ ưu đãi";
            // 
            // btnHuy
            // 
            btnHuy.Image = Properties.Resources.xoa;
            btnHuy.Location = new Point(977, 219);
            btnHuy.Margin = new Padding(3, 4, 3, 4);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(38, 44);
            btnHuy.TabIndex = 14;
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.Image = Properties.Resources.luu;
            btnLuu.Location = new Point(933, 219);
            btnLuu.Margin = new Padding(3, 4, 3, 4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(38, 44);
            btnLuu.TabIndex = 13;
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Image = Properties.Resources.sua;
            btnSua.Location = new Point(888, 219);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(38, 44);
            btnSua.TabIndex = 12;
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Image = Properties.Resources.xoa;
            btnXoa.Location = new Point(843, 219);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(38, 44);
            btnXoa.TabIndex = 11;
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Image = Properties.Resources.them;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(799, 219);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(38, 44);
            btnThem.TabIndex = 10;
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(cboMaDichVu);
            groupBox9.Location = new Point(193, 205);
            groupBox9.Margin = new Padding(3, 4, 3, 4);
            groupBox9.Name = "groupBox9";
            groupBox9.Padding = new Padding(3, 4, 3, 4);
            groupBox9.Size = new Size(255, 65);
            groupBox9.TabIndex = 2;
            groupBox9.TabStop = false;
            groupBox9.Text = "Mã dịch vụ";
            // 
            // cboMaDichVu
            // 
            cboMaDichVu.FormattingEnabled = true;
            cboMaDichVu.Location = new Point(7, 23);
            cboMaDichVu.Margin = new Padding(3, 4, 3, 4);
            cboMaDichVu.Name = "cboMaDichVu";
            cboMaDichVu.Size = new Size(241, 28);
            cboMaDichVu.TabIndex = 0;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(btnChonAnh);
            groupBox8.Controls.Add(pictureBoxHinhAnh);
            groupBox8.Location = new Point(480, 131);
            groupBox8.Margin = new Padding(3, 4, 3, 4);
            groupBox8.Name = "groupBox8";
            groupBox8.Padding = new Padding(3, 4, 3, 4);
            groupBox8.Size = new Size(255, 139);
            groupBox8.TabIndex = 2;
            groupBox8.TabStop = false;
            groupBox8.Text = "Hình ảnh";
            // 
            // btnChonAnh
            // 
            btnChonAnh.Location = new Point(162, 21);
            btnChonAnh.Margin = new Padding(3, 4, 3, 4);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(86, 31);
            btnChonAnh.TabIndex = 1;
            btnChonAnh.Text = "Chọn ảnh";
            btnChonAnh.UseVisualStyleBackColor = true;
            btnChonAnh.Click += btnChonAnh_Click;
            // 
            // pictureBoxHinhAnh
            // 
            pictureBoxHinhAnh.Location = new Point(7, 23);
            pictureBoxHinhAnh.Margin = new Padding(3, 4, 3, 4);
            pictureBoxHinhAnh.Name = "pictureBoxHinhAnh";
            pictureBoxHinhAnh.Size = new Size(149, 108);
            pictureBoxHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxHinhAnh.TabIndex = 0;
            pictureBoxHinhAnh.TabStop = false;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(txtMoTa);
            groupBox7.Location = new Point(480, 57);
            groupBox7.Margin = new Padding(3, 4, 3, 4);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(3, 4, 3, 4);
            groupBox7.Size = new Size(255, 65);
            groupBox7.TabIndex = 4;
            groupBox7.TabStop = false;
            groupBox7.Text = "Mô tả";
            // 
            // txtMoTa
            // 
            txtMoTa.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMoTa.Location = new Point(7, 23);
            txtMoTa.Margin = new Padding(3, 4, 3, 4);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(241, 27);
            txtMoTa.TabIndex = 0;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(txtDieuKienBanToiThieu);
            groupBox6.Location = new Point(760, 66);
            groupBox6.Margin = new Padding(3, 4, 3, 4);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(3, 4, 3, 4);
            groupBox6.Size = new Size(255, 65);
            groupBox6.TabIndex = 3;
            groupBox6.TabStop = false;
            groupBox6.Text = "Điều kiện bàn tối thiểu";
            // 
            // txtDieuKienBanToiThieu
            // 
            txtDieuKienBanToiThieu.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtDieuKienBanToiThieu.Location = new Point(7, 23);
            txtDieuKienBanToiThieu.Margin = new Padding(3, 4, 3, 4);
            txtDieuKienBanToiThieu.Name = "txtDieuKienBanToiThieu";
            txtDieuKienBanToiThieu.Size = new Size(241, 27);
            txtDieuKienBanToiThieu.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txtTenDichVu);
            groupBox5.Location = new Point(193, 131);
            groupBox5.Margin = new Padding(3, 4, 3, 4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 4, 3, 4);
            groupBox5.Size = new Size(255, 65);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            groupBox5.Text = "Tên dịch vụ";
            // 
            // txtTenDichVu
            // 
            txtTenDichVu.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenDichVu.Location = new Point(7, 23);
            txtTenDichVu.Margin = new Padding(3, 4, 3, 4);
            txtTenDichVu.Name = "txtTenDichVu";
            txtTenDichVu.Size = new Size(241, 27);
            txtTenDichVu.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtMaDichVuUuDai);
            groupBox4.Location = new Point(193, 57);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(255, 65);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Mã dịch vụ ưu đãi";
            // 
            // txtMaDichVuUuDai
            // 
            txtMaDichVuUuDai.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaDichVuUuDai.Location = new Point(7, 23);
            txtMaDichVuUuDai.Margin = new Padding(3, 4, 3, 4);
            txtMaDichVuUuDai.Name = "txtMaDichVuUuDai";
            txtMaDichVuUuDai.Size = new Size(241, 27);
            txtMaDichVuUuDai.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridViewDichVuUuDai);
            groupBox3.Location = new Point(7, 337);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(1208, 500);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách dịch vụ ưu đãi";
            // 
            // dataGridViewDichVuUuDai
            // 
            dataGridViewDichVuUuDai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDichVuUuDai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDichVuUuDai.Location = new Point(7, 29);
            dataGridViewDichVuUuDai.Margin = new Padding(3, 4, 3, 4);
            dataGridViewDichVuUuDai.Name = "dataGridViewDichVuUuDai";
            dataGridViewDichVuUuDai.RowHeadersWidth = 51;
            dataGridViewDichVuUuDai.RowTemplate.Height = 25;
            dataGridViewDichVuUuDai.Size = new Size(1194, 463);
            dataGridViewDichVuUuDai.TabIndex = 0;
            dataGridViewDichVuUuDai.CellClick += dataGridViewDichVuUuDai_CellClick;
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(txtDieuKienBanToiDa);
            groupBox10.Location = new Point(760, 139);
            groupBox10.Margin = new Padding(3, 4, 3, 4);
            groupBox10.Name = "groupBox10";
            groupBox10.Padding = new Padding(3, 4, 3, 4);
            groupBox10.Size = new Size(255, 65);
            groupBox10.TabIndex = 15;
            groupBox10.TabStop = false;
            groupBox10.Text = "Điều kiện bàn tối đa";
            // 
            // txtDieuKienBanToiDa
            // 
            txtDieuKienBanToiDa.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtDieuKienBanToiDa.Location = new Point(7, 23);
            txtDieuKienBanToiDa.Margin = new Padding(3, 4, 3, 4);
            txtDieuKienBanToiDa.Name = "txtDieuKienBanToiDa";
            txtDieuKienBanToiDa.Size = new Size(241, 27);
            txtDieuKienBanToiDa.TabIndex = 0;
            // 
            // GUI_DichVuUuDai
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "GUI_DichVuUuDai";
            Size = new Size(1406, 1028);
            Load += GUI_DichVuUuDai_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox9.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxHinhAnh).EndInit();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDichVuUuDai).EndInit();
            groupBox10.ResumeLayout(false);
            groupBox10.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox5;
        private TextBox txtTenDichVu;
        private GroupBox groupBox4;
        private TextBox txtMaDichVuUuDai;
        private GroupBox groupBox3;
        private DataGridView dataGridViewDichVuUuDai;
        private GroupBox groupBox9;
        private ComboBox cboMaDichVu;
        private GroupBox groupBox8;
        private Button btnChonAnh;
        private PictureBox pictureBoxHinhAnh;
        private GroupBox groupBox7;
        private TextBox txtMoTa;
        private GroupBox groupBox6;
        private TextBox txtDieuKienBanToiThieu;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private GroupBox groupBox10;
        private TextBox txtDieuKienBanToiDa;
    }
}
