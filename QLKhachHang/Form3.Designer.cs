namespace QLKhachHang
{
    partial class Form3
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
            tbDiaChi = new TextBox();
            tbSoDienThoai = new TextBox();
            tbTenKhachHang = new TextBox();
            tbMaKhachHang = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbTenDV = new TextBox();
            label5 = new Label();
            tbTongGia = new TextBox();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // tbDiaChi
            // 
            tbDiaChi.Location = new Point(367, 230);
            tbDiaChi.Name = "tbDiaChi";
            tbDiaChi.Size = new Size(125, 27);
            tbDiaChi.TabIndex = 23;
            tbDiaChi.TextChanged += tbDiaChi_TextChanged;
            // 
            // tbSoDienThoai
            // 
            tbSoDienThoai.Location = new Point(367, 177);
            tbSoDienThoai.Name = "tbSoDienThoai";
            tbSoDienThoai.Size = new Size(125, 27);
            tbSoDienThoai.TabIndex = 22;
            tbSoDienThoai.TextChanged += tbSoDienThoai_TextChanged;
            // 
            // tbTenKhachHang
            // 
            tbTenKhachHang.Location = new Point(367, 123);
            tbTenKhachHang.Name = "tbTenKhachHang";
            tbTenKhachHang.Size = new Size(125, 27);
            tbTenKhachHang.TabIndex = 21;
            tbTenKhachHang.TextChanged += tbTenKhachHang_TextChanged;
            // 
            // tbMaKhachHang
            // 
            tbMaKhachHang.Location = new Point(367, 72);
            tbMaKhachHang.Name = "tbMaKhachHang";
            tbMaKhachHang.Size = new Size(125, 27);
            tbMaKhachHang.TabIndex = 20;
            tbMaKhachHang.TextChanged += tbMaKhachHang_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(249, 233);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 19;
            label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(249, 180);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 18;
            label3.Text = "Số điện thoại:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(249, 123);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 17;
            label2.Text = "Tên khách hàng:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(249, 72);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 16;
            label1.Text = "Mã khách hàng:";
            // 
            // tbTenDV
            // 
            tbTenDV.Location = new Point(367, 283);
            tbTenDV.Name = "tbTenDV";
            tbTenDV.Size = new Size(125, 27);
            tbTenDV.TabIndex = 25;
            tbTenDV.TextChanged += tbTenDV_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(249, 283);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 24;
            label5.Text = "Tên dịch vụ:";
            // 
            // tbTongGia
            // 
            tbTongGia.Location = new Point(367, 338);
            tbTongGia.Name = "tbTongGia";
            tbTongGia.Size = new Size(125, 27);
            tbTongGia.TabIndex = 27;
            tbTongGia.TextChanged += tbTongGia_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(249, 338);
            label6.Name = "label6";
            label6.Size = new Size(71, 20);
            label6.TabIndex = 26;
            label6.Text = "Tổng giá:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(342, 18);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 28;
            label7.Text = "Hóa đơn";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(tbTongGia);
            Controls.Add(label6);
            Controls.Add(tbTenDV);
            Controls.Add(label5);
            Controls.Add(tbDiaChi);
            Controls.Add(tbSoDienThoai);
            Controls.Add(tbTenKhachHang);
            Controls.Add(tbMaKhachHang);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Hóa đơn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbDiaChi;
        private TextBox tbSoDienThoai;
        private TextBox tbTenKhachHang;
        private TextBox tbMaKhachHang;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbTenDV;
        private Label label5;
        private TextBox tbTongGia;
        private Label label6;
        private Label label7;
    }
}