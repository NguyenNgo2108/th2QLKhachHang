using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhachHang
{
    public partial class Form3 : Form
    {
        public string MaKhachHang { get; set; }
        public string TenKhachHang { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        public List<string> DanhSachDichVu { get; set; }
        public decimal TongGia { get; set; }
        public Form3(string maKH, string tenKH, string sdt, string diaChi, List<string> danhSachDichVu, decimal tongGia)
        {
            InitializeComponent();

            MaKhachHang = maKH;
            TenKhachHang = tenKH;
            SoDienThoai = sdt;
            DiaChi = diaChi;
            DanhSachDichVu = danhSachDichVu;
            TongGia = tongGia;

            tbMaKhachHang.Text = MaKhachHang;
            tbTenKhachHang.Text = TenKhachHang;
            tbSoDienThoai.Text = SoDienThoai;
            tbDiaChi.Text = DiaChi;
            tbTongGia.Text = TongGia.ToString("N0");

            // Hiển thị danh sách dịch vụ đã chọn
            tbTenDV.Text = string.Join(", ", DanhSachDichVu);
        }



        private void tbMaKhachHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTenKhachHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSoDienThoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTenDV_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTongGia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
