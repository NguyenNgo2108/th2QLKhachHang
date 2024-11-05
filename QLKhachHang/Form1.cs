using System.Data;
using System.Data.SqlClient;

namespace QLKhachHang
{
    public partial class Form1 : Form
    {
        private string connectionString = KetNoi.chuoiKN;
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM QLKhachHang";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có phải là hàng không phải tiêu đề không
            if (e.RowIndex >= 0)
            {
                // Lấy mã khách hàng từ DataGridView và điền vào TextBox
                tbMaKhachHang.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();  // Giả sử MaKH ở cột 0
                tbTenKhachHang.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(); // Giả sử TenKH ở cột 1
                tbSoDienThoai.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();  // Giả sử SDT ở cột 2
                tbDiaChi.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();       // Giả sử DiaChi ở cột 3
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maKH = tbMaKhachHang.Text;
            string tenKH = tbTenKhachHang.Text;
            float sdt;
            string diaChi = tbDiaChi.Text;

            // Kiểm tra nếu các trường không được để trống
            if (string.IsNullOrEmpty(maKH) || string.IsNullOrEmpty(tenKH) || string.IsNullOrEmpty(diaChi) || !float.TryParse(tbSoDienThoai.Text, out sdt))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO QLKhachHang (MaKH, TenKH, SDT, DiaChi) VALUES (@MaKH, @TenKH, @SDT, @DiaChi)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaKH", maKH);
                    cmd.Parameters.AddWithValue("@TenKH", tenKH);
                    cmd.Parameters.AddWithValue("@SDT", sdt);
                    cmd.Parameters.AddWithValue("@DiaChi", diaChi);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Thêm khách hàng thành công!");
                        LoadData(); // Cập nhật lại DataGridView sau khi thêm

                        // Sau khi thêm thành công, xóa nội dung trong các TextBox
                        tbMaKhachHang.Clear();
                        tbTenKhachHang.Clear();
                        tbSoDienThoai.Clear();
                        tbDiaChi.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Thêm khách hàng không thành công!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maKH = tbMaKhachHang.Text; // Lấy mã khách hàng từ TextBox.

            // Kiểm tra nếu mã khách hàng trống hoặc không hợp lệ.
            if (string.IsNullOrEmpty(maKH))
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng cần xóa!");
                return;
            }

            // Xác nhận người dùng có muốn xóa không.
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return; // Nếu người dùng không xác nhận, dừng thao tác xóa.
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM QLKhachHang WHERE MaKH = @MaKH"; // Câu lệnh xóa theo mã khách hàng.
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaKH", maKH); // Thêm tham số mã khách hàng vào câu lệnh.

                    int result = cmd.ExecuteNonQuery(); // Thực thi câu lệnh.

                    if (result > 0)
                    {
                        MessageBox.Show("Xóa khách hàng thành công!");
                        LoadData(); // Cập nhật lại DataGridView sau khi xóa.
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy khách hàng với mã đã nhập!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa khách hàng: " + ex.Message);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maKH = tbMaKhachHang.Text;   // Mã khách hàng không thể sửa
            string tenKH = tbTenKhachHang.Text;  // Tên khách hàng sẽ được sửa
            string sdtText = tbSoDienThoai.Text; // Số điện thoại
            string diaChi = tbDiaChi.Text;       // Địa chỉ

            // Kiểm tra nếu các trường cần sửa không trống
            if (string.IsNullOrEmpty(tenKH) || string.IsNullOrEmpty(sdtText) || string.IsNullOrEmpty(diaChi))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin để sửa!");
                return;
            }

            // Kiểm tra xem số điện thoại có hợp lệ hay không
            float sdt;
            if (!float.TryParse(sdtText, out sdt))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!");
                return;
            }

            // Cập nhật thông tin khách hàng trong cơ sở dữ liệu
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE QLKhachHang SET TenKH = @TenKH, SDT = @SDT, DiaChi = @DiaChi WHERE MaKH = @MaKH";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaKH", maKH);         // Giữ nguyên MaKH
                    cmd.Parameters.AddWithValue("@TenKH", tenKH);       // Sửa TenKH
                    cmd.Parameters.AddWithValue("@SDT", sdt);           // Sửa SDT
                    cmd.Parameters.AddWithValue("@DiaChi", diaChi);     // Sửa DiaChi

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Cập nhật khách hàng thành công!");
                        LoadData(); // Cập nhật lại DataGridView sau khi sửa

                        // Xóa nội dung trong các TextBox sau khi sửa thành công
                        tbMaKhachHang.Clear();   // Xóa Mã Khách Hàng (trường này không sửa)
                        tbTenKhachHang.Clear();  // Xóa Tên Khách Hàng
                        tbSoDienThoai.Clear();   // Xóa Số Điện Thoại
                        tbDiaChi.Clear();        // Xóa Địa Chỉ
                    }
                    else
                    {
                        MessageBox.Show("Không có khách hàng với mã này!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi sửa khách hàng: " + ex.Message);
                }
            }
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có dòng nào được chọn trong DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy thông tin khách hàng từ hàng đã chọn
                string maKH = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string tenKH = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string sdt = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string diaChi = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

                // Khởi tạo Form2 và truyền các dữ liệu khách hàng
                Form2 form2 = new Form2(maKH, tenKH, sdt, diaChi);
                form2.Show();  // Hiển thị Form2
                this.Hide();
            }
            else
            {
                // Nếu không có khách hàng nào được chọn, thông báo cho người dùng
                MessageBox.Show("Vui lòng chọn khách hàng từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
