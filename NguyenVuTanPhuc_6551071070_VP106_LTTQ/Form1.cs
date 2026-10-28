using System.Data;
using Microsoft.Data.SqlClient;
namespace NguyenVuTanPhuc_6551071070_VP106_LTTQ
{
    public partial class Form1 : Form
    {
        string connectString = @"Data Source=.;Initial Catalog=DuLieu;Integrated Security=True;TrustServerCertificate=True;"; bool isThem = false;
        public Form1()
        {
            InitializeComponent();
        }


        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM SanPham";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối: " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtMaSP.Text = row.Cells["MaSanPham"].Value.ToString();
                txtTenSP.Text = row.Cells["TenSanPham"].Value.ToString();
                txtGia.Text = row.Cells["GiaBan"].Value.ToString();
            }

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            KhoaMoBanDau();
        }
        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }


            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void KhoaMoBanDau()
        {
            btnThem.Enabled = true;
            btnThoat.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            XoaTrangTextBox();
        }

        private void XoaTrangTextBox()
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtGia.Clear();
            txtMaSP.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSP.Text) || string.IsNullOrWhiteSpace(txtTenSP.Text) || string.IsNullOrWhiteSpace(txtGia.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu vào các ô TextBox!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectString))
            {
                try
                {
                    conn.Open();


                    string checkQuery = "SELECT COUNT(*) FROM SanPham WHERE MaSanPham = @MaSP";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@MaSP", txtMaSP.Text.Trim());
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Mã sản phẩm này đã tồn tại! Vui lòng nhập mã khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaSP.Focus();
                        return;
                    }


                    string insertQuery = "INSERT INTO SanPham (MaSanPham, TenSanPham, GiaBan) VALUES (@MaSP, @TenSP, @GiaBan)";
                    SqlCommand cmd = new SqlCommand(insertQuery, conn);
                    cmd.Parameters.AddWithValue("@MaSP", txtMaSP.Text.Trim());
                    cmd.Parameters.AddWithValue("@TenSP", txtTenSP.Text.Trim());
                    cmd.Parameters.AddWithValue("@GiaBan", decimal.Parse(txtGia.Text.Trim()));

                    cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    KhoaMoBanDau();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenSP.Text) || string.IsNullOrWhiteSpace(txtGia.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE SanPham SET TenSanPham = @TenSP, GiaBan = @GiaBan WHERE MaSanPham = @MaSP";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaSP", txtMaSP.Text.Trim());
                    cmd.Parameters.AddWithValue("@TenSP", txtTenSP.Text.Trim());
                    cmd.Parameters.AddWithValue("@GiaBan", decimal.Parse(txtGia.Text.Trim()));

                    cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtMaSP.ReadOnly = false;
                    KhoaMoBanDau();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa sản phẩm này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM SanPham WHERE MaSanPham = @MaSP";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@MaSP", txtMaSP.Text.Trim());

                        cmd.ExecuteNonQuery();
                        LoadData();
                        MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtMaSP.ReadOnly = false;
                        KhoaMoBanDau();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}





