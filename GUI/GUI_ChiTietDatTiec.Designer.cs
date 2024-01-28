namespace GUI
{
    partial class GUI_ChiTietDatTiec
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
            groupBox1 = new GroupBox();
            dataGridViewNuoc = new DataGridView();
            groupBox2 = new GroupBox();
            btnThemChiTietNuoc = new Button();
            groupBox6 = new GroupBox();
            cboNuoc = new ComboBox();
            groupBox4 = new GroupBox();
            numericUpDownSoLuong = new NumericUpDown();
            groupBox3 = new GroupBox();
            cboLoaiNuoc = new ComboBox();
            groupBox19 = new GroupBox();
            lblMaTiec = new Label();
            groupBox5 = new GroupBox();
            groupBox7 = new GroupBox();
            cboDichVuTinhPhi = new ComboBox();
            btnThemDichVu = new Button();
            groupBox11 = new GroupBox();
            dataGridViewDichVu = new DataGridView();
            groupBox12 = new GroupBox();
            groupBox9 = new GroupBox();
            txtMaMenu = new TextBox();
            groupBox14 = new GroupBox();
            btnThemMenu = new Button();
            groupBox17 = new GroupBox();
            dataGridViewMenu = new DataGridView();
            numericUpDownSoLuongMenuCuaTiec = new NumericUpDown();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNuoc).BeginInit();
            groupBox2.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSoLuong).BeginInit();
            groupBox3.SuspendLayout();
            groupBox19.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDichVu).BeginInit();
            groupBox12.SuspendLayout();
            groupBox9.SuspendLayout();
            groupBox14.SuspendLayout();
            groupBox17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSoLuongMenuCuaTiec).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridViewNuoc);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(609, 243);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách nước Order";
            // 
            // dataGridViewNuoc
            // 
            dataGridViewNuoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewNuoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNuoc.Location = new Point(6, 22);
            dataGridViewNuoc.Name = "dataGridViewNuoc";
            dataGridViewNuoc.RowTemplate.Height = 25;
            dataGridViewNuoc.Size = new Size(597, 214);
            dataGridViewNuoc.TabIndex = 0;
            dataGridViewNuoc.CellClick += dataGridViewNuoc_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnThemChiTietNuoc);
            groupBox2.Controls.Add(groupBox6);
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(627, 67);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(241, 243);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin Order nước";
            // 
            // btnThemChiTietNuoc
            // 
            btnThemChiTietNuoc.Image = Properties.Resources.them;
            btnThemChiTietNuoc.ImageAlign = ContentAlignment.MiddleLeft;
            btnThemChiTietNuoc.Location = new Point(196, 168);
            btnThemChiTietNuoc.Name = "btnThemChiTietNuoc";
            btnThemChiTietNuoc.Size = new Size(33, 33);
            btnThemChiTietNuoc.TabIndex = 28;
            btnThemChiTietNuoc.UseVisualStyleBackColor = true;
            btnThemChiTietNuoc.Click += btnThemChiTietNuoc_Click_1;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(cboNuoc);
            groupBox6.Location = new Point(6, 100);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(223, 49);
            groupBox6.TabIndex = 27;
            groupBox6.TabStop = false;
            groupBox6.Text = "Nước";
            // 
            // cboNuoc
            // 
            cboNuoc.FormattingEnabled = true;
            cboNuoc.Location = new Point(6, 20);
            cboNuoc.Name = "cboNuoc";
            cboNuoc.Size = new Size(211, 23);
            cboNuoc.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(numericUpDownSoLuong);
            groupBox4.Location = new Point(6, 155);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(139, 49);
            groupBox4.TabIndex = 25;
            groupBox4.TabStop = false;
            groupBox4.Text = "Số lượng";
            // 
            // numericUpDownSoLuong
            // 
            numericUpDownSoLuong.Location = new Point(6, 20);
            numericUpDownSoLuong.Name = "numericUpDownSoLuong";
            numericUpDownSoLuong.Size = new Size(127, 23);
            numericUpDownSoLuong.TabIndex = 0;
            numericUpDownSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cboLoaiNuoc);
            groupBox3.Location = new Point(6, 45);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(223, 49);
            groupBox3.TabIndex = 24;
            groupBox3.TabStop = false;
            groupBox3.Text = "Loại nước";
            // 
            // cboLoaiNuoc
            // 
            cboLoaiNuoc.FormattingEnabled = true;
            cboLoaiNuoc.Location = new Point(6, 20);
            cboLoaiNuoc.Name = "cboLoaiNuoc";
            cboLoaiNuoc.Size = new Size(211, 23);
            cboLoaiNuoc.TabIndex = 0;
            cboLoaiNuoc.SelectedIndexChanged += cboLoaiNuoc_SelectedIndexChanged;
            // 
            // groupBox19
            // 
            groupBox19.Controls.Add(lblMaTiec);
            groupBox19.Location = new Point(18, 12);
            groupBox19.Name = "groupBox19";
            groupBox19.Size = new Size(223, 49);
            groupBox19.TabIndex = 20;
            groupBox19.TabStop = false;
            groupBox19.Text = "Mã tiệc";
            // 
            // lblMaTiec
            // 
            lblMaTiec.AutoSize = true;
            lblMaTiec.Location = new Point(6, 23);
            lblMaTiec.Name = "lblMaTiec";
            lblMaTiec.Size = new Size(38, 15);
            lblMaTiec.TabIndex = 0;
            lblMaTiec.Text = "label1";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(groupBox7);
            groupBox5.Controls.Add(btnThemDichVu);
            groupBox5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox5.Location = new Point(627, 316);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(241, 243);
            groupBox5.TabIndex = 3;
            groupBox5.TabStop = false;
            groupBox5.Text = "Thông tin Order dịch vụ";
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(cboDichVuTinhPhi);
            groupBox7.Location = new Point(12, 95);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(223, 49);
            groupBox7.TabIndex = 27;
            groupBox7.TabStop = false;
            groupBox7.Text = "Dịch vụ tính phí";
            // 
            // cboDichVuTinhPhi
            // 
            cboDichVuTinhPhi.FormattingEnabled = true;
            cboDichVuTinhPhi.Location = new Point(6, 20);
            cboDichVuTinhPhi.Name = "cboDichVuTinhPhi";
            cboDichVuTinhPhi.Size = new Size(211, 23);
            cboDichVuTinhPhi.TabIndex = 0;
            // 
            // btnThemDichVu
            // 
            btnThemDichVu.Image = Properties.Resources.them;
            btnThemDichVu.ImageAlign = ContentAlignment.MiddleLeft;
            btnThemDichVu.Location = new Point(196, 150);
            btnThemDichVu.Name = "btnThemDichVu";
            btnThemDichVu.Size = new Size(33, 33);
            btnThemDichVu.TabIndex = 21;
            btnThemDichVu.UseVisualStyleBackColor = true;
            btnThemDichVu.Click += btnThemDichVu_Click;
            // 
            // groupBox11
            // 
            groupBox11.Controls.Add(dataGridViewDichVu);
            groupBox11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox11.Location = new Point(12, 316);
            groupBox11.Name = "groupBox11";
            groupBox11.Size = new Size(609, 243);
            groupBox11.TabIndex = 2;
            groupBox11.TabStop = false;
            groupBox11.Text = "Danh sách dịch vụ Order";
            // 
            // dataGridViewDichVu
            // 
            dataGridViewDichVu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDichVu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDichVu.Location = new Point(6, 22);
            dataGridViewDichVu.Name = "dataGridViewDichVu";
            dataGridViewDichVu.RowTemplate.Height = 25;
            dataGridViewDichVu.Size = new Size(597, 214);
            dataGridViewDichVu.TabIndex = 0;
            dataGridViewDichVu.CellClick += dataGridViewDichVu_CellClick;
            // 
            // groupBox12
            // 
            groupBox12.Controls.Add(groupBox9);
            groupBox12.Controls.Add(groupBox14);
            groupBox12.Controls.Add(btnThemMenu);
            groupBox12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox12.Location = new Point(627, 565);
            groupBox12.Name = "groupBox12";
            groupBox12.Size = new Size(241, 243);
            groupBox12.TabIndex = 5;
            groupBox12.TabStop = false;
            groupBox12.Text = "Thông tin Order menu";
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(txtMaMenu);
            groupBox9.Location = new Point(12, 46);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(223, 49);
            groupBox9.TabIndex = 26;
            groupBox9.TabStop = false;
            groupBox9.Text = "Mã menu";
            // 
            // txtMaMenu
            // 
            txtMaMenu.Location = new Point(6, 20);
            txtMaMenu.Name = "txtMaMenu";
            txtMaMenu.Size = new Size(205, 23);
            txtMaMenu.TabIndex = 0;
            // 
            // groupBox14
            // 
            groupBox14.Controls.Add(numericUpDownSoLuongMenuCuaTiec);
            groupBox14.Location = new Point(12, 101);
            groupBox14.Name = "groupBox14";
            groupBox14.Size = new Size(157, 49);
            groupBox14.TabIndex = 25;
            groupBox14.TabStop = false;
            groupBox14.Text = "Số lượng menu của tiệc";
            // 
            // btnThemMenu
            // 
            btnThemMenu.Image = Properties.Resources.them;
            btnThemMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnThemMenu.Location = new Point(196, 114);
            btnThemMenu.Name = "btnThemMenu";
            btnThemMenu.Size = new Size(33, 33);
            btnThemMenu.TabIndex = 21;
            btnThemMenu.UseVisualStyleBackColor = true;
            btnThemMenu.Click += btnThemMenu_Click;
            // 
            // groupBox17
            // 
            groupBox17.Controls.Add(dataGridViewMenu);
            groupBox17.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox17.Location = new Point(12, 565);
            groupBox17.Name = "groupBox17";
            groupBox17.Size = new Size(609, 243);
            groupBox17.TabIndex = 4;
            groupBox17.TabStop = false;
            groupBox17.Text = "Danh sách menu Order";
            // 
            // dataGridViewMenu
            // 
            dataGridViewMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMenu.Location = new Point(6, 22);
            dataGridViewMenu.Name = "dataGridViewMenu";
            dataGridViewMenu.RowTemplate.Height = 25;
            dataGridViewMenu.Size = new Size(597, 214);
            dataGridViewMenu.TabIndex = 0;
            dataGridViewMenu.CellClick += dataGridViewMenu_CellClick;
            // 
            // numericUpDownSoLuongMenuCuaTiec
            // 
            numericUpDownSoLuongMenuCuaTiec.Location = new Point(7, 20);
            numericUpDownSoLuongMenuCuaTiec.Name = "numericUpDownSoLuongMenuCuaTiec";
            numericUpDownSoLuongMenuCuaTiec.Size = new Size(144, 23);
            numericUpDownSoLuongMenuCuaTiec.TabIndex = 0;
            numericUpDownSoLuongMenuCuaTiec.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // GUI_ChiTietDatTiec
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 818);
            Controls.Add(groupBox12);
            Controls.Add(groupBox17);
            Controls.Add(groupBox5);
            Controls.Add(groupBox11);
            Controls.Add(groupBox2);
            Controls.Add(groupBox19);
            Controls.Add(groupBox1);
            Name = "GUI_ChiTietDatTiec";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GUI_ChiTietNuocUong";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewNuoc).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownSoLuong).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox19.ResumeLayout(false);
            groupBox19.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDichVu).EndInit();
            groupBox12.ResumeLayout(false);
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            groupBox14.ResumeLayout(false);
            groupBox17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSoLuongMenuCuaTiec).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridViewNuoc;
        private GroupBox groupBox2;
        private GroupBox groupBox19;
        private Button btnXoa;
        private Button btnThem;
        private GroupBox groupBox6;
        private ComboBox comboBox2;
        private GroupBox groupBox4;
        private NumericUpDown numericUpDownSoLuong;
        private GroupBox groupBox3;
        private ComboBox cboLoaiNuoc;
        private Label lblMaTiec;
        private GroupBox groupBox5;
        private GroupBox groupBox7;
        private ComboBox cboDichVuTinhPhi;
        private GroupBox groupBox8;
        private NumericUpDown numericUpDown1;
        private Button btnThemDichVu;
        private GroupBox groupBox11;
        private DataGridView dataGridViewDichVu;
        private GroupBox groupBox12;
        private GroupBox groupBox13;
        private ComboBox comboBox5;
        private GroupBox groupBox14;
        private NumericUpDown numericUpDown2;
        private GroupBox groupBox15;
        private ComboBox comboBox6;
        private Button button3;
        private Button btnThemMenu;
        private GroupBox groupBox16;
        private Label label2;
        private GroupBox groupBox17;
        private DataGridView dataGridViewMenu;
        private Button btnThemChiTietNuoc;
        private ComboBox cboNuoc;
        private GroupBox groupBox9;
        private TextBox txtMaMenu;
        private NumericUpDown numericUpDownSoLuongMenuCuaTiec;
    }
}