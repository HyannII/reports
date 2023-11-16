using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTTQ_Layout_New.Forms
{
    public partial class QLGV : Form
    {
        private readonly Form1 _form1;
        //sqlrelated
        SqlConnection con;

        //datatable
        DataTable tbGiangVien;
        DataTable tbTG = new DataTable();
        DataTable tbTG2 = new DataTable();

        //dictionary
        Dictionary<string, string> rowStatus = new Dictionary<string, string>();

        //flag

        public QLGV()
        {
            InitializeComponent();
        }

        public QLGV(Form1 form, SqlConnection con)
        {
            InitializeComponent();
            _form1 = form;
            this.con = con;
            loadData();
            LoadComboBox(con);
            disableButtons();
        }
        private void HienThiAnhGiaoVien(string maGV, string imagePath)
        {
            // Kết hợp đường dẫn và mã giáo viên để tạo đường dẫn đầy đủ đến ảnh
            string fullPath = Path.Combine(imagePath, $"{maGV}");

            // Kiểm tra xem tệp ảnh có tồn tại không
            if (File.Exists(fullPath))
            {
                // Hiển thị ảnh lên PictureBox
                pictureBox1.Image = Image.FromFile(fullPath);
            }
            else
            {
                // Xử lý khi không tìm thấy ảnh
                MessageBox.Show("Không tìm thấy ảnh giáo viên.");
            }
        }
        private void runSQL(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = con;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }//DataRelated
        private bool KiemTraMaGiaoVien(string maLopHoc, SqlConnection connection)
        {
            string query = "SELECT COUNT(*) FROM GiaoVien WHERE MaGV = @MaGV";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaGV", maLopHoc);
                int giaoviencount = (int)command.ExecuteScalar();
                return giaoviencount > 0;
            }
        }
        private bool KiemTraMaCoQuan(string maHocVien, SqlConnection connect)
        {
            string query = "Select Count(*) from CoQuan Where MaCQ = @MaCQ";
            using (SqlCommand command = new SqlCommand(query, connect))
            {
                command.Parameters.AddWithValue("@MaCQ", maHocVien);
                int coQuanCount = (int)command.ExecuteScalar();
                return coQuanCount > 0;
            }
        }
        private void cloneTable()
        {
            tbTG = tbGiangVien.Clone();
            tbTG2 = tbGiangVien.Clone();
            tbTG2.PrimaryKey = new DataColumn[] { tbTG2.Columns["MaGV"] };
            tbTG.PrimaryKey = new DataColumn[] { tbTG.Columns["MaGV"] };
        }
        private void saveData()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM GiaoVien", con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);


            foreach (DataRow row in tbTG.Rows)
            {
                string maGV = row["MaGV"].ToString();
                if (rowStatus.ContainsKey(maGV))
                {
                    DataRow targetRow = tbGiangVien.Rows.Find(maGV);
                    if (targetRow != null)
                    {
                        if (rowStatus[maGV] == "edit")
                        {
                            targetRow.ItemArray = row.ItemArray;
                        }
                    }
                    else if (rowStatus[maGV] == "new")
                    {
                        tbGiangVien.Rows.Add(row.ItemArray);
                    }
                }
            }
            foreach (DataRow row in tbTG2.Rows)
            {
                string maGV = row["MaGV"].ToString();
                if (rowStatus.ContainsKey(maGV) && rowStatus[maGV] == "delete")
                {
                    DataRow targetRow = tbGiangVien.Rows.Find(maGV);
                    if (targetRow != null)
                    {
                        targetRow.Delete();
                    }
                }
            }
            DataTable changes = tbGiangVien.GetChanges();
            if (changes != null)
            {
                dataAdapter.Update(changes);
                tbGiangVien.AcceptChanges();

            }
            DataTable deletedRows = tbGiangVien.GetChanges(DataRowState.Deleted);
            if (deletedRows != null)
            {
                dataAdapter.Update(deletedRows);
                tbGiangVien.AcceptChanges();
            }

            tbGiangVien.AcceptChanges();
            //tbHocVien.AcceptChanges();
            //rowStatus.Clear();
            tbTG.Clear();
            tbTG2.Clear();
            // Cập nhật cơ sở dữ liệu như bạn đã làm
            // ...
        }
        private void NewData()
        {
            txtMaGV.ReadOnly = false;
            Control[] controls = { txtMaGV, txtTenGV, dtpNS, cbbGT, txtDC, txtDT, txtAnh, txtTD, txtCD, txtCM, cbbMaCQ };
            pictureBox1.ImageLocation = null;
            for (int i = 0; i < controls.Length; i++)
            {

                controls[i].Text = "";

                if (controls[i] is DateTimePicker)
                {
                    DateTimePicker dateTimePicker = (DateTimePicker)controls[i];
                    dateTimePicker.Value = DateTime.Now;
                }
                if (controls[i] is System.Windows.Forms.ComboBox)
                {
                    System.Windows.Forms.ComboBox combobox = (System.Windows.Forms.ComboBox)controls[i];
                    combobox.SelectedIndex = -1;
                }
            }
        }
        private void loadData()
        {
            string query = "SELECT * FROM GiaoVien";
            SqlDataAdapter myData = new SqlDataAdapter(query, con);
            tbGiangVien = new DataTable();
            myData.Fill(tbGiangVien);
            dataGridView1.DataSource = tbGiangVien;
            tbGiangVien.PrimaryKey = new DataColumn[] { tbGiangVien.Columns["MaGV"] };
            formatDataGrid();
        }
        private void LoadComboBox(SqlConnection connection)
        {
            string query = "select MaCQ from CoQuan";
            using (SqlCommand command1 = new SqlCommand(query, connection))
            {
                using (SqlDataAdapter da1 = new SqlDataAdapter(command1))
                {
                    DataTable dt1 = new DataTable();
                    da1.Fill(dt1);

                    cbbMaCQ.DataSource = dt1;
                    cbbMaCQ.ValueMember = "MaCQ";
                    cbbMaCQ.SelectedIndex = -1;
                }
            }
        }
        //Ultility
        private void DeleteSelectedRows()
        {
            List<DataGridViewRow> selectedRows = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (row.IsNewRow == false)
                {
                    string maGV = row.Cells["MaGV"].Value.ToString();
                    rowStatus.Remove(maGV);
                    rowStatus[maGV] = "";
                    selectedRows.Add(row);
                }
            }

            if ((DataTable)dataGridView1.DataSource == tbTG)
            {
                // Xóa các dòng đã chọn từ DataTable
                foreach (DataGridViewRow row in selectedRows)
                {
                    DataRowView drv = (DataRowView)row.DataBoundItem;
                    if (drv != null)
                    {
                        DataRow dr = drv.Row;
                        tbTG.Rows.Remove(dr);

                    }
                }
                dataGridView1.DataSource = tbTG;
            }

            if ((DataTable)dataGridView1.DataSource == tbTG2)
            {
                // Xóa các dòng đã chọn từ DataTable
                foreach (DataGridViewRow row in selectedRows)
                {
                    DataRowView drv = (DataRowView)row.DataBoundItem;
                    if (drv != null)
                    {
                        DataRow dr = drv.Row;
                        tbTG2.Rows.Remove(dr);
                    }
                }
                dataGridView1.DataSource = tbTG2;
            }
        }
        private void formatDataGrid()
        {
            // Lấy tất cả cột trong DataGridView
            DataGridViewColumnCollection columns = dataGridView1.Columns;

            // Sử dụng index hoặc tên cột để thay đổi tên
            columns["MaGV"].HeaderText = "Mã giáo viên";
            columns["TenGV"].HeaderText = "Tên giáo viên";
            columns["NgaySinh"].HeaderText = "Ngày sinh";
            columns["GioiTinh"].HeaderText = "Giới tính";
            columns["DiaChi"].HeaderText = "Địa chỉ";
            columns["DienThoai"].HeaderText = "Điện thoại";
            columns["Anh"].HeaderText = "Tên File ảnh";
            columns["TrinhDo"].HeaderText = "Trình độ";
            columns["ChucDanh"].HeaderText = "Chức danh";
            columns["TenChuyenMon"].HeaderText = "Chuyên môn";
            columns["MaCQ"].HeaderText = "Mã cơ quan";
        }
        private void enableButtons2()
        {
            btnThemTTCT.Enabled = true;
            btnXoaTTCT.Enabled = true;
            btnSuaTTCT.Enabled = true;
        }
        private void disableButtons()
        {
            btnHuyDaChonTemp.Enabled = false;
            btnHuyTemp.Enabled = false;
        }
        private void enableButtons()
        {
            btnHuyDaChonTemp.Enabled = true;
            btnHuyTemp.Enabled = true;
        }
        private void disableButtons2()
        {
            btnThemTTCT.Enabled = false;
            btnXoaTTCT.Enabled = false;
            btnSuaTTCT.Enabled = false;
        }
        private bool kiemTraDuLieu()
        {
            if (txtMaGV.Text == "" || txtTenGV.Text == "" || cbbGT.Text == "" 
                || txtDC.Text == "" || txtAnh.Text == "" || txtDC.Text == "" 
                || txtDT.Text == "" || txtTD.Text == "" || txtCD.Text == "" 
                || txtCM.Text == "" || cbbMaCQ.Text == "")
            {
                return false;
            }
            return true;
        }
        private bool CheckDataTable(string maGV)
        {
            DataRow existingRow = tbTG.Rows.Find(maGV);
            DataRow existingRow2 = tbTG2.Rows.Find(maGV);
            if (existingRow != null)
            {
                MessageBox.Show("Giảng viên với mã đã cho đã tồn tại trong danh sách thêm/sửa", "Lỗi");
                return false;
            }
            if (existingRow2 != null)
            {
                MessageBox.Show("Giảng viên với mã đã cho đã tồn tại trong danh sách xóa", "Lỗi");
                return false;
            }
            return true;
        }
        private void btnClick(object sender, MouseEventArgs e)
        {
            IconButton btn = (IconButton)sender;
             if (_form1.DarkModeOn)
             {
                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 50, 50);
             }
            else
            {
                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 255);
            }
        }
        private void btnHover(object sender, EventArgs e)
        {
            IconButton btn = (IconButton)sender;
             if (_form1.DarkModeOn)
            {
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 30);
            }
            else
            {
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 120, 120);
            }
        }
        private void changeDGVBackground()
        {
            if(_form1.DarkModeOn)
            {
                dataGridView1.BackgroundColor = Color.FromArgb(8, 8, 8);
            }
            else
            {
                dataGridView1.BackgroundColor = Color.FromArgb(214, 214, 214);
            }
        }

        private void btnThemTTCT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thêm không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string maGV = txtMaGV.Text;
                string maCQ = cbbMaCQ.Text.ToString();

                if (!kiemTraDuLieu())
                {
                    MessageBox.Show("lỗi rồi", "Thông báo");
                    return;
                }
                // Kiểm tra sự tồn tại của Mã Giáo viên
                if (KiemTraMaGiaoVien(maGV, con))
                {
                    MessageBox.Show("Đã tồn tại giáo viên này", "Thông báo");
                    return;
                }

                // Kiểm tra sự tồn tại của Mã cơ quan
                if (!KiemTraMaCoQuan(maCQ, con))
                {
                    MessageBox.Show("Không tồn tại cơ quan này", "Thông báo");
                    return;
                }
                // Lấy giá trị từ các điều khiển
                string value1 = txtMaGV.Text;
                string value2 = txtTenGV.Text;
                DateTime value3 = dtpNS.Value;
                string value4 = cbbGT.Text;
                string value5 = txtDC.Text;
                string value6 = txtDT.Text;
                string value7 = txtAnh.Text;
                string value8 = txtTD.Text;
                string value9 = txtCD.Text;
                string value10 = txtCM.Text;
                string value11 = cbbMaCQ.Text;
                // Tạo mảng giá trị
                string[] row = { value1, value2, value3.ToString(), value4, value5, value6, value7, value8, value9, value10, value11 };
                if (row.Length != tbTG.Columns.Count)
                {
                    cloneTable();
                }
                if (CheckDataTable(maGV))
                {
                    tbTG.Rows.Add(row);
                    dataGridView1.DataSource = tbTG;
                    rowStatus[value1] = "new";
                    disableButtons2();
                    enableButtons();
                }
                else
                {
                    return;
                }
            }
        }

        private void btnSuaTTCT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn sửa không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Lấy giá trị từ các điều khiển
                string value1 = txtMaGV.Text;
                string value2 = txtTenGV.Text;
                DateTime value3 = dtpNS.Value;
                string value4 = cbbGT.Text;
                string value5 = txtDC.Text;
                string value6 = txtDT.Text;
                string value7 = txtAnh.Text;
                string value8 = txtTD.Text;
                string value9 = txtCD.Text;
                string value10 = txtCM.Text;
                string value11 = cbbMaCQ.Text;

                string maCQ = cbbMaCQ.Text.ToString();
                // Kiểm tra sự tồn tại của Cơ quan
                if (!KiemTraMaCoQuan(maCQ, con))
                {
                    MessageBox.Show("Không tồn tại cơ quan này", "Thông báo");
                    return;
                }

                string[] row = { value1, value2, value3.ToString(), value4, value5, value6, value7, value8, value9, value10, value11 };
                if (row.Length != tbTG.Columns.Count)
                {
                    cloneTable();
                }

                if (CheckDataTable(value1))
                {
                    tbTG.Rows.Add(row);
                    dataGridView1.DataSource = tbTG;
                    rowStatus[value1] = "edit";
                    disableButtons2();
                    enableButtons();
                }
                else
                {
                    return;
                }
            }
        }

        private void btnXoaTTCT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (tbGiangVien.Columns.Count != tbTG.Columns.Count)
                {
                    cloneTable();
                }
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow dgvRow in dataGridView1.SelectedRows)
                    {
                        if (dgvRow.IsNewRow == false)
                        {
                            string maGV = dgvRow.Cells["MaGV"].Value.ToString();
                            if (CheckDataTable(maGV))
                            {
                                if (!rowStatus.ContainsKey(maGV) || rowStatus[maGV] != "delete")
                                {
                                    DataRow newRow = tbTG2.NewRow();

                                    for (int i = 0; i < dgvRow.Cells.Count; i++)
                                    {
                                        newRow[i] = dgvRow.Cells[i].Value;
                                    }

                                    tbTG2.Rows.Add(newRow);
                                    rowStatus[maGV] = "delete";
                                }
                            }
                            else
                            {
                                return;
                            }
                        }

                    }
                    dataGridView1.DataSource = tbTG2;
                }
                disableButtons2();
                enableButtons();
            }
        }

        private void btnLuuTTCT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn lưu không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                saveData();
            }
        }

        private void btnHuyDaChonTemp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DeleteSelectedRows();
            }
        }

        private void btnHuyTemp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                List<DataGridViewRow> selectedRows = new List<DataGridViewRow>();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    // Kiểm tra xem ô "MaGV" có tồn tại trong hàng không
                    if (row.Cells["MaGV"] != null && row.Cells["MaGV"].Value != null)
                    {
                        string maGV = row.Cells["MaGV"].Value.ToString();
                        rowStatus.Remove(maGV);
                        selectedRows.Add(row);
                    }
                }

                if ((DataTable)dataGridView1.DataSource == tbTG)
                {
                    // Xóa các dòng đã chọn từ DataTable
                    foreach (DataGridViewRow row in selectedRows)
                    {
                        DataRowView drv = (DataRowView)row.DataBoundItem;
                        if (drv != null)
                        {
                            DataRow dr = drv.Row;
                            tbTG.Rows.Remove(dr);

                        }
                    }
                    dataGridView1.DataSource = tbTG;
                }

                if ((DataTable)dataGridView1.DataSource == tbTG2)
                {
                    // Xóa các dòng đã chọn từ DataTable
                    foreach (DataGridViewRow row in selectedRows)
                    {
                        DataRowView drv = (DataRowView)row.DataBoundItem;
                        if (drv != null)
                        {
                            DataRow dr = drv.Row;
                            tbTG2.Rows.Remove(dr);
                        }
                    }
                    dataGridView1.DataSource = tbTG2;
                }
            }
        }

        private void btnT_SBTT_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tbTG;
            label2.Text = "Bảng thêm/sửa";
            enableButtons();
            disableButtons2();
        }

        private void btnXoaBTT_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tbTG2;
            label2.Text = "Bảng xóa";
            enableButtons();
            disableButtons2();
        }

        private void btnThongTinBTT_Click(object sender, EventArgs e)
        {
            loadData();
            label2.Text = "Bảng thông tin";
            disableButtons();
            enableButtons2();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                if (dataGridView1.Rows[e.RowIndex].IsNewRow)
                {
                    NewData();
                }
                else
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    Control[] controls = { txtMaGV, txtTenGV, dtpNS, cbbGT, txtDC, txtDT, txtAnh, txtTD, txtCD, txtCM, cbbMaCQ };

                    for (int i = 0; i < controls.Length; i++)
                    {
                        string columnValue = row.Cells[i].Value.ToString();
                        controls[i].Text = columnValue;

                        if (controls[i] is DateTimePicker)
                        {
                            DateTimePicker dateTimePicker = (DateTimePicker)controls[i];
                            dateTimePicker.Value = DateTime.Parse(columnValue);
                        }
                        if (controls[i] is System.Windows.Forms.ComboBox)
                        {
                            System.Windows.Forms.ComboBox combobox = (System.Windows.Forms.ComboBox)controls[i];
                            combobox.SelectedValue = columnValue;
                        }
                    }
                    txtMaGV.ReadOnly = true;
                    // Giả sử bạn có mã giáo viên (MaGV) và đường dẫn đến thư mục ảnh (imagePath)
                    string maGV = txtAnh.Text; // Thay thế bằng mã giáo viên thực tế
                    string imagePath = "D:/Picture/"; // Thay thế bằng đường dẫn thực tế

                    // Gọi mã hiển thị ảnh khi cần
                    HienThiAnhGiaoVien(maGV, imagePath);
                }
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 6 || e.ColumnIndex == 2)
            {
                // Kiểm tra cột là cột ngày tháng (yourDateColumnIndex)
                if (e.Value is DateTime)
                {
                    // Định dạng lại giá trị ngày tháng theo định dạng "dd/MM/yyyy"
                    e.Value = ((DateTime)e.Value).ToString("dd/MM/yyyy");
                    e.FormattingApplied = true;
                }
            }
        }

        private void txtDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Từ chối ký tự không phải số
            }
        }

        private void txtTenGV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Từ chối ký tự không phải số
            }
        }
    }
}
