namespace GUI
{
    partial class GUI_QuanLyMenu
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
            groupBox8 = new GroupBox();
            groupBox7 = new GroupBox();
            txtMaMenu = new TextBox();
            btnSua = new Button();
            groupBox5 = new GroupBox();
            txtTenMenu = new TextBox();
            btnXoa = new Button();
            groupBox6 = new GroupBox();
            txtDonGiaMenu = new TextBox();
            btnThem = new Button();
            groupBox4 = new GroupBox();
            dataGridViewMenu = new DataGridView();
            groupBox3 = new GroupBox();
            btnThemMonAn = new Button();
            groupBox11 = new GroupBox();
            numericUpDownSoLuong = new NumericUpDown();
            groupBox10 = new GroupBox();
            cboMonAn = new ComboBox();
            onAnTrongMenu = new DataGridView();
            groupBox9 = new GroupBox();
            cboLoaiMonAn = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMenu).BeginInit();
            groupBox3.SuspendLayout();
            groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSoLuong).BeginInit();
            groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)onAnTrongMenu).BeginInit();
            groupBox9.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1224, 765);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quản lý menu";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox8);
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Location = new Point(260, 42);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(720, 686);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Menu";
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(groupBox7);
            groupBox8.Controls.Add(btnSua);
            groupBox8.Controls.Add(groupBox5);
            groupBox8.Controls.Add(btnXoa);
            groupBox8.Controls.Add(groupBox6);
            groupBox8.Controls.Add(btnThem);
            groupBox8.Location = new Point(6, 22);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(306, 307);
            groupBox8.TabIndex = 16;
            groupBox8.TabStop = false;
            groupBox8.Text = "Thông tin Menu";
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(txtMaMenu);
            groupBox7.Location = new Point(6, 22);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(294, 49);
            groupBox7.TabIndex = 6;
            groupBox7.TabStop = false;
            groupBox7.Text = "Mã menu";
            // 
            // txtMaMenu
            // 
            txtMaMenu.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaMenu.Location = new Point(6, 17);
            txtMaMenu.Name = "txtMaMenu";
            txtMaMenu.Size = new Size(282, 23);
            txtMaMenu.TabIndex = 0;
            // 
            // btnSua
            // 
            btnSua.Image = Properties.Resources.sua;
            btnSua.Location = new Point(261, 247);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(33, 33);
            btnSua.TabIndex = 15;
            btnSua.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txtTenMenu);
            groupBox5.Location = new Point(6, 98);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(294, 49);
            groupBox5.TabIndex = 7;
            groupBox5.TabStop = false;
            groupBox5.Text = "Tên menu";
            // 
            // txtTenMenu
            // 
            txtTenMenu.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenMenu.Location = new Point(6, 17);
            txtTenMenu.Name = "txtTenMenu";
            txtTenMenu.Size = new Size(282, 23);
            txtTenMenu.TabIndex = 0;
            // 
            // btnXoa
            // 
            btnXoa.Image = Properties.Resources.xoa;
            btnXoa.Location = new Point(222, 247);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(33, 33);
            btnXoa.TabIndex = 14;
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(txtDonGiaMenu);
            groupBox6.Location = new Point(6, 174);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(294, 49);
            groupBox6.TabIndex = 8;
            groupBox6.TabStop = false;
            groupBox6.Text = "Đơn giá menu";
            // 
            // txtDonGiaMenu
            // 
            txtDonGiaMenu.Enabled = false;
            txtDonGiaMenu.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtDonGiaMenu.Location = new Point(6, 17);
            txtDonGiaMenu.Name = "txtDonGiaMenu";
            txtDonGiaMenu.Size = new Size(282, 23);
            txtDonGiaMenu.TabIndex = 0;
            // 
            // btnThem
            // 
            btnThem.Image = Properties.Resources.them;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(183, 247);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(33, 33);
            btnThem.TabIndex = 13;
            btnThem.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridViewMenu);
            groupBox4.Location = new Point(6, 335);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(704, 344);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Danh sách menu";
            // 
            // dataGridViewMenu
            // 
            dataGridViewMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMenu.Location = new Point(6, 22);
            dataGridViewMenu.Name = "dataGridViewMenu";
            dataGridViewMenu.RowTemplate.Height = 25;
            dataGridViewMenu.Size = new Size(692, 316);
            dataGridViewMenu.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnThemMonAn);
            groupBox3.Controls.Add(groupBox11);
            groupBox3.Controls.Add(groupBox10);
            groupBox3.Controls.Add(onAnTrongMenu);
            groupBox3.Controls.Add(groupBox9);
            groupBox3.Location = new Point(318, 22);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(392, 307);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Món ăn trong menu";
            // 
            // btnThemMonAn
            // 
            btnThemMonAn.Image = Properties.Resources.them;
            btnThemMonAn.ImageAlign = ContentAlignment.MiddleLeft;
            btnThemMonAn.Location = new Point(346, 88);
            btnThemMonAn.Name = "btnThemMonAn";
            btnThemMonAn.Size = new Size(33, 33);
            btnThemMonAn.TabIndex = 19;
            btnThemMonAn.UseVisualStyleBackColor = true;
            // 
            // groupBox11
            // 
            groupBox11.Controls.Add(numericUpDownSoLuong);
            groupBox11.Location = new Point(289, 22);
            groupBox11.Name = "groupBox11";
            groupBox11.Size = new Size(97, 61);
            groupBox11.TabIndex = 18;
            groupBox11.TabStop = false;
            groupBox11.Text = "Số lượng";
            // 
            // numericUpDownSoLuong
            // 
            numericUpDownSoLuong.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            numericUpDownSoLuong.Location = new Point(6, 20);
            numericUpDownSoLuong.Name = "numericUpDownSoLuong";
            numericUpDownSoLuong.Size = new Size(84, 33);
            numericUpDownSoLuong.TabIndex = 19;
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(cboMonAn);
            groupBox10.Location = new Point(6, 77);
            groupBox10.Name = "groupBox10";
            groupBox10.Size = new Size(248, 49);
            groupBox10.TabIndex = 17;
            groupBox10.TabStop = false;
            groupBox10.Text = "Món ăn";
            // 
            // cboMonAn
            // 
            cboMonAn.FormattingEnabled = true;
            cboMonAn.Location = new Point(6, 17);
            cboMonAn.Name = "cboMonAn";
            cboMonAn.Size = new Size(236, 23);
            cboMonAn.TabIndex = 0;
            // 
            // onAnTrongMenu
            // 
            onAnTrongMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            onAnTrongMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            onAnTrongMenu.Location = new Point(6, 132);
            onAnTrongMenu.Name = "onAnTrongMenu";
            onAnTrongMenu.RowTemplate.Height = 25;
            onAnTrongMenu.Size = new Size(380, 170);
            onAnTrongMenu.TabIndex = 0;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(cboLoaiMonAn);
            groupBox9.Location = new Point(6, 22);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(248, 49);
            groupBox9.TabIndex = 5;
            groupBox9.TabStop = false;
            groupBox9.Text = "Loại món ăn";
            // 
            // cboLoaiMonAn
            // 
            cboLoaiMonAn.FormattingEnabled = true;
            cboLoaiMonAn.Location = new Point(6, 17);
            cboLoaiMonAn.Name = "cboLoaiMonAn";
            cboLoaiMonAn.Size = new Size(236, 23);
            cboLoaiMonAn.TabIndex = 0;
            cboLoaiMonAn.SelectedIndexChanged += cboLoaiMonAn_SelectedIndexChanged;
            // 
            // GUI_QuanLyMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "GUI_QuanLyMenu";
            Size = new Size(1230, 771);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMenu).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownSoLuong).EndInit();
            groupBox10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)onAnTrongMenu).EndInit();
            groupBox9.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridView onAnTrongMenu;
        private GroupBox groupBox4;
        private DataGridView dataGridViewMenu;
        private GroupBox groupBox5;
        private TextBox txtTenMenu;
        private GroupBox groupBox9;
        private ComboBox cboLoaiMonAn;
        private GroupBox groupBox7;
        private TextBox txtMaMenu;
        private GroupBox groupBox6;
        private TextBox txtDonGiaMenu;
        private GroupBox groupBox8;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private GroupBox groupBox10;
        private ComboBox cboMonAn;
        private GroupBox groupBox11;
        private NumericUpDown numericUpDownSoLuong;
        private Button btnThemMonAn;
    }
}
