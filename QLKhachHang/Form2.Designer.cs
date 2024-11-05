namespace QLKhachHang
{
    partial class Form2
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
            tbDiaChi = new TextBox();
            tbSoDienThoai = new TextBox();
            tbTenKhachHang = new TextBox();
            tbMaKhachHang = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnTaoHoaDon = new Button();
            tbTongGia = new TextBox();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            groupBox3 = new GroupBox();
            btnChonLai = new Button();
            btnThoat = new Button();
            btnThem = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbDiaChi);
            groupBox1.Controls.Add(tbSoDienThoai);
            groupBox1.Controls.Add(tbTenKhachHang);
            groupBox1.Controls.Add(tbMaKhachHang);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(6, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(297, 276);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Khách hàng";
            // 
            // tbDiaChi
            // 
            tbDiaChi.Location = new Point(145, 204);
            tbDiaChi.Name = "tbDiaChi";
            tbDiaChi.Size = new Size(125, 27);
            tbDiaChi.TabIndex = 15;
            // 
            // tbSoDienThoai
            // 
            tbSoDienThoai.Location = new Point(145, 151);
            tbSoDienThoai.Name = "tbSoDienThoai";
            tbSoDienThoai.Size = new Size(125, 27);
            tbSoDienThoai.TabIndex = 14;
            // 
            // tbTenKhachHang
            // 
            tbTenKhachHang.Location = new Point(145, 97);
            tbTenKhachHang.Name = "tbTenKhachHang";
            tbTenKhachHang.Size = new Size(125, 27);
            tbTenKhachHang.TabIndex = 13;
            // 
            // tbMaKhachHang
            // 
            tbMaKhachHang.Location = new Point(145, 46);
            tbMaKhachHang.Name = "tbMaKhachHang";
            tbMaKhachHang.Size = new Size(125, 27);
            tbMaKhachHang.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 207);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 11;
            label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 154);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 10;
            label3.Text = "Số điện thoại:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 97);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 9;
            label2.Text = "Tên khách hàng:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 46);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 8;
            label1.Text = "Mã khách hàng:";
            label1.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnTaoHoaDon);
            groupBox2.Controls.Add(tbTongGia);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(309, 13);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(486, 425);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dịch Vụ";
            // 
            // btnTaoHoaDon
            // 
            btnTaoHoaDon.Location = new Point(354, 369);
            btnTaoHoaDon.Name = "btnTaoHoaDon";
            btnTaoHoaDon.Size = new Size(115, 29);
            btnTaoHoaDon.TabIndex = 1;
            btnTaoHoaDon.Text = "Tạo hóa đơn";
            btnTaoHoaDon.UseVisualStyleBackColor = true;
            btnTaoHoaDon.Click += btnTaoHoaDon_Click;
            // 
            // tbTongGia
            // 
            tbTongGia.Location = new Point(344, 249);
            tbTongGia.Name = "tbTongGia";
            tbTongGia.Size = new Size(125, 27);
            tbTongGia.TabIndex = 17;
            tbTongGia.TextChanged += tbTongGia_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(226, 249);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 16;
            label5.Text = "Tổng giá:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(474, 188);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnChonLai);
            groupBox3.Controls.Add(btnThoat);
            groupBox3.Controls.Add(btnThem);
            groupBox3.Location = new Point(6, 295);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(297, 143);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức năng";
            // 
            // btnChonLai
            // 
            btnChonLai.Location = new Point(176, 46);
            btnChonLai.Name = "btnChonLai";
            btnChonLai.Size = new Size(94, 29);
            btnChonLai.TabIndex = 2;
            btnChonLai.Text = "Chọn lại ";
            btnChonLai.UseVisualStyleBackColor = true;
            btnChonLai.Click += btnChonLai_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(92, 98);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 1;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(27, 46);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox tbDiaChi;
        private TextBox tbSoDienThoai;
        private TextBox tbTenKhachHang;
        private TextBox tbMaKhachHang;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbTongGia;
        private Label label5;
        private DataGridView dataGridView1;
        private Button btnThem;
        private Button btnTaoHoaDon;
        private Button btnThoat;
        private Button btnChonLai;
    }
}