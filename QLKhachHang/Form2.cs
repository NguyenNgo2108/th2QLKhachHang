using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhachHang
{
    public partial class Form2 : Form
    {
        private string connectionString = KetNoi.chuoiKN;
        private List<string> danhSachDichVu = new List<string>();
        private decimal tongGia = 0;
        private decimal giaDichVu = 0;
        public Form2(string maKH, string tenKH, string sdt, string diaChi)
        {
            InitializeComponent();
            tbMaKhachHang.Text = maKH;
            tbTenKhachHang.Text = tenKH;
            tbSoDienThoai.Text = sdt;
            tbDiaChi.Text = diaChi;
            LoadDichVu();
        }

        private void LoadDichVu()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM QLDichVu"; // Đảm bảo cột giá dịch vụ có tên là 'Gia'
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
                }
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Kiểm tra xem giá trị trong cột "Gia" có tồn tại không
                if (dataGridView1.Rows[e.RowIndex].Cells["TenDV"].Value != DBNull.Value)  // Sửa từ "TenDichVu" thành "TenDV"
                {
                    // Lấy tên dịch vụ và giá trị từ DataGridView
                    string tenDichVu = dataGridView1.Rows[e.RowIndex].Cells["TenDV"].Value.ToString();  // Sửa từ "TenDichVu" thành "TenDV"
                    giaDichVu = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["Gia"].Value);

                    // Thêm tên dịch vụ vào danh sách
                    danhSachDichVu.Add(tenDichVu);

                    // Cập nhật lại tổng giá
                    tongGia += giaDichVu;
                    tbTongGia.Text = tongGia.ToString("N0");
                }
                else
                {
                    MessageBox.Show("Không có giá trị hợp lệ trong cột Gia");
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (giaDichVu > 0) // Kiểm tra nếu giá trị dịch vụ đã được chọn
            {
                // Cộng dồn giá vào tổng giá
                tongGia += giaDichVu;

                // Cập nhật lại TextBox tổng giá
                tbTongGia.Text = tongGia.ToString("N0"); // Định dạng số (nghìn, triệu...)
                Console.WriteLine("Cập nhật tổng giá: " + tongGia); // Dòng debug
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dịch vụ hợp lệ!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();

        }

        private void tbTongGia_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnChonLai_Click(object sender, EventArgs e)
        {
            // Reset tổng giá về 0
            tongGia = 0;
            giaDichVu = 0; // Đặt lại giá dịch vụ đã chọn về 0

            // Cập nhật lại TextBox tổng giá
            tbTongGia.Text = string.Empty;

            // Cập nhật lại DataGridView (có thể tải lại danh sách dịch vụ nếu cần)
            LoadDichVu();

            // Thông báo cho người dùng
            MessageBox.Show("Bạn đã chọn lại và có thể chọn dịch vụ mới.");
        }

        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            // Truyền dữ liệu từ Form2 sang Form3
            Form3 form3 = new Form3(
                tbMaKhachHang.Text,      // Mã khách hàng
                tbTenKhachHang.Text,     // Tên khách hàng
                tbSoDienThoai.Text,      // Số điện thoại
                tbDiaChi.Text,           // Địa chỉ
                danhSachDichVu,          // Danh sách dịch vụ đã chọn
                tongGia                  // Tổng giá
            );

            // Hiển thị Form3
            form3.Show();

            // Đóng Form2 (tuỳ chọn)
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
