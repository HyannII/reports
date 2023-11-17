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
    public partial class QLHV : Form
    {
        private readonly Form1 _form1;
        //sqlrelated
        SqlConnection con;

        //datatable
        DataTable tbHocVien;
        DataTable tbTG = new DataTable();
        DataTable tbTG2 = new DataTable();

        //dictionary
        Dictionary<string, string> rowStatus = new Dictionary<string, string>();
        //Flag
        private bool shouldReload = true;

        public QLHV()
        {
            InitializeComponent();
        }

        public QLHV(Form1 form, SqlConnection con)
        {
            InitializeComponent();
            _form1 = form;
            this.con = con;
            LoadComboBox(con);
            disableButtons();
            enableButtons2();
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
        private bool KiemTraMaLopHoc(string maLopHoc, SqlConnection connection)
        {
            string query = "SELECT COUNT(*) FROM LopHoc WHERE MaLop = @MaLopHoc";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaLopHoc", maLopHoc);
                int lopHocCount = (int)command.ExecuteScalar();
                return lopHocCount > 0;
            }
        }
        private bool KiemTraMaHocVien(string maHocVien, SqlConnection connect)
        {
            string query = "Select Count(*) from HocVien Where MaHocVien = @MaHocVien";
            using (SqlCommand command = new SqlCommand(query, connect))
            {
                command.Parameters.AddWithValue("@MaHocVien", maHocVien);
                int hocVienCount = (int)command.ExecuteScalar();
                return hocVienCount > 0;
            }
        }
        private void cloneTable()
        {
            tbTG = tbHocVien.Clone();
            tbTG2 = tbHocVien.Clone();
            tbTG2.PrimaryKey = new DataColumn[] { tbTG2.Columns["MaHocVien"] };
            tbTG.PrimaryKey = new DataColumn[] { tbTG.Columns["MaHocVien"] };
        }
        private void saveData()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM HocVien", con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            if (tbTG.Rows.Count > 0)
            {
                DataTable newDataTable = new DataTable();
                addColumns(newDataTable);

                foreach (DataRow row in tbTG.Rows)
                {
                    // Lấy giá trị từ hai cột của DataTable gốc
                    string maHocVien = row["MaHocVien"].ToString();
                    string maLop = row["MaLop"].ToString();

                    // Thêm dữ liệu vào DataTable mới
                    newDataTable.Rows.Add(maHocVien, maLop);
                }

                if (tbTG.Columns.Contains("MaLop"))
                {
                    // Xóa cột
                    tbTG.Columns.Remove("MaLop");
                }

                foreach (DataRow row in tbTG.Rows)
                {
                    string maHocVien = row["MaHocVien"].ToString();
                    if (rowStatus.ContainsKey(maHocVien))
                    {
                        DataRow targetRow = tbHocVien.Rows.Find(maHocVien);
                        if (targetRow != null)
                        {
                            if (rowStatus[maHocVien] == "edit")
                            {
                                targetRow.ItemArray = row.ItemArray;
                            }
                        }
                        else if (rowStatus[maHocVien] == "new")
                        {
                            tbHocVien.Rows.Add(row.ItemArray);
                        }
                    }
                }
                DataTable changes = tbHocVien.GetChanges();
                if (changes != null)
                {
                    dataAdapter.Update(changes);
                    tbHocVien.AcceptChanges();
                }
                foreach (DataRow row in newDataTable.Rows)
                {
                    string maHocVien = row["MaHocVien"].ToString();
                    string maLop = row["MaLop"].ToString();
                    if (rowStatus.ContainsKey(maHocVien))
                    {
                        if (rowStatus[maHocVien] == "new")
                        {
                            insertHocVien(maHocVien, maLop);
                        }
                        else if (rowStatus[maHocVien] == "edit")
                        {
                            updateHocVien(maHocVien, maLop);
                        }
                    }
                }
            }

            if (tbTG2.Rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Học viên đang có tham gia các lớp học!\nBạn có chắc chắn muốn xóa hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    //if (tbHocVien.Columns.Contains("MaLop"))
                    //{
                    //    tbHocVien.Columns.Remove("MaLop");
                    //}
                    foreach (DataRow row in tbTG2.Rows)
                    {
                        string maHocVien = row["MaHocVien"].ToString();
                        if (rowStatus.ContainsKey(maHocVien) && rowStatus[maHocVien] == "delete")
                        {
                            DeleteHocVien(maHocVien);
                            DataRow targetRow = tbHocVien.Rows.Find(maHocVien);
                            if (targetRow != null)
                            {
                                targetRow.Delete();
                            }
                        }
                    }
                    DataTable deletedRows = tbHocVien.GetChanges(DataRowState.Deleted);
                    if (deletedRows != null)
                    {

                        dataAdapter.Update(deletedRows);
                        tbHocVien.AcceptChanges();
                    }
                }
                if (result == DialogResult.No)
                {
                    return;
                }
            }
            else return;
            reCalculateSiSo();
        }

        private void DeleteHocVien(string maHocVien)
        {
            runSQL("DELETE FROM DanhSachHocSinh_MonHoc WHERE MaHocVien = '" + maHocVien + "'");
        }
        private void insertHocVien(string maHocVien, string maLop)
        {
            runSQL("INSERT INTO DanhSachHocSinh_MonHoc (MaHocVien, MaLop, Diem) VALUES ('" + maHocVien + "', '" + maLop + "', 0)");
        }
        private void updateHocVien(string maHocVien, string maLop)
        {
            runSQL("UPDATE DanhSachHocSinh_MonHoc SET MaLop = '" + maLop + "' WHERE MaHocVien = '" + maHocVien + "'");
        }
        private void reCalculateSiSo()
        {
            runSQL("UPDATE LopHoc SET SiSo = (SELECT COUNT(*) FROM DanhSachHocSinh_MonHoc WHERE DanhSachHocSinh_MonHoc.MaLop = LopHoc.MaLop)");
        }
        private void NewData()
        {
            Control[] controls = { txtMaHV, txtTenHV, dtpNS, cbbGT, txtDC, txtDT, dtpNNHP, txtNN, txtXL, cbbMaLop };

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

            txtMaHV.ReadOnly = false;
        }
        private void LoadComboBox(SqlConnection connection)
        {
            string query1 = "select MaLop from LopHoc";
            using (SqlCommand command1 = new SqlCommand(query1, connection))
            {
                using (SqlDataAdapter da1 = new SqlDataAdapter(command1))
                {
                    DataTable dt1 = new DataTable();
                    da1.Fill(dt1);

                    cbbMaLop.DataSource = dt1;
                    cbbMaLop.ValueMember = "MaLop";
                    cbbMaLop.SelectedIndex = -1;
                }
            }
        }
        //Ultility
        private bool CheckDataTable(string maHocVien)
        {
            DataRow existingRow = tbTG.Rows.Find(maHocVien);
            DataRow existingRow2 = tbTG2.Rows.Find(maHocVien);
            if (existingRow != null)
            {
                MessageBox.Show("Học viên với mã đã cho đã tồn tại trong danh sách thêm/sửa", "Lỗi");
                return false;
            }
            if (existingRow2 != null)
            {
                MessageBox.Show("Học viên với mã đã cho đã tồn tại trong danh sách xóa", "Lỗi");
                return false;
            }
            return true;
        }
        private void formatDataGrid()
        {
            // Lấy tất cả cột trong DataGridView
            DataGridViewColumnCollection columns = dataGridView1.Columns;

            // Sử dụng index hoặc tên cột để thay đổi tên
            columns["MaHocVien"].HeaderText = "Mã học viên";
            columns["TenHocVien"].HeaderText = "Tên học viên";
            columns["NgaySinh"].HeaderText = "Ngày sinh";
            columns["GioiTinh"].HeaderText = "Giới tính";
            columns["DiaChi"].HeaderText = "Địa chỉ";
            columns["DienThoai"].HeaderText = "Điện Thoại";
            columns["TenNghe"].HeaderText = "Nghề nghiệp";
            columns["NgayNopHocPhi"].HeaderText = "Ngày nộp học phí";
            columns["NgayNopHocPhi"].Width = 120;
            columns["XepLoai"].HeaderText = "Xếp loại";

        }
        private void enableButtons2()
        {
            btnThemTTCT.Enabled = true;
            btnSuaTTCT.Enabled = true;
            btnXoaTTCT.Enabled = true;
        }
        private void DeleteSelectedRows()
        {
            List<DataGridViewRow> selectedRows = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (row.IsNewRow == false)
                {
                    string maHocVien = row.Cells["MaHocVien"].Value.ToString();
                    rowStatus.Remove(maHocVien);
                    rowStatus[maHocVien] = "";
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
            btnSuaTTCT.Enabled = false;
            btnXoaTTCT.Enabled = false;
        }
        private bool kiemTraDuLieu()
        {
            if (txtMaHV.Text == "" || txtTenHV.Text == "" || txtNN.Text == "" || txtXL.Text == "" || txtDC.Text == "" || txtDT.Text == "" || cbbGT.Text == "" || cbbMaLop.Text == "" || dtpNS.Text == "" || dtpNNHP.Text == "")
            {
                return false;
            }
            return true;
        }
        private void addColumns(DataTable newDataTable)
        {
            newDataTable.Columns.Add("MaHocVien", typeof(string));
            newDataTable.Columns.Add("MaLop", typeof(string));
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

        private void btnThemTTCT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thêm không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string maHocVien = txtMaHV.Text;
                string maLop = cbbMaLop.Text.ToString();
                if (!kiemTraDuLieu())
                {
                    MessageBox.Show("Lỗi rồi", "Thông báo");
                    return;
                }
                // Kiểm tra sự tồn tại của Mã Học Viên
                if (KiemTraMaHocVien(maHocVien, con))
                {
                    MessageBox.Show("Đã tồn tại học viên này", "Thông báo");
                    return;
                }

                // Kiểm tra sự tồn tại của Mã Lớp Học
                if (!KiemTraMaLopHoc(maLop, con))
                {
                    MessageBox.Show("Không tồn tại lớp học này", "Thông báo");
                    return;
                }
                // Lấy giá trị từ các điều khiển
                string value1 = txtMaHV.Text;
                string value2 = txtTenHV.Text;
                DateTime value3 = dtpNS.Value;
                string value4 = cbbGT.Text;
                string value5 = txtDC.Text;
                string value6 = txtDT.Text;
                DateTime value7 = dtpNNHP.Value;
                //string value8 = textBox11.Text;
                string value9 = txtNN.Text;
                string value10 = txtXL.Text;
                string value11 = cbbMaLop.Text;
                // Tạo mảng giá trị
                string[] row = { value1, value2, value3.ToString(), value4, value5, value6, value7.ToString(), value9, value10, value11 };
                if (row.Length != tbTG.Columns.Count)
                {
                    cloneTable();
                }

                if (CheckDataTable(value1))
                {
                    tbTG.Rows.Add(row);

                    dataGridView1.DataSource = tbTG;
                    rowStatus[value1] = "new";
                }
                else
                {
                    return;
                }
                disableButtons2();
            }
        }

        private void btnSuaTTCT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn sửa không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Lấy giá trị từ các điều khiển
                string value1 = txtMaHV.Text;
                string value2 = txtTenHV.Text;
                DateTime value3 = dtpNS.Value;
                string value4 = cbbGT.Text;
                string value5 = txtDC.Text;
                string value6 = txtDT.Text;
                DateTime value7 = dtpNNHP.Value;
                //string value8 = textBox11.Text;
                string value9 = txtNN.Text;
                string value10 = txtXL.Text;
                string value11 = cbbMaLop.Text;

                string maLop = cbbMaLop.Text.ToString();
                if (!KiemTraMaLopHoc(maLop, con))
                {
                    MessageBox.Show("Không tồn tại lớp học này", "Thông báo");
                    return;
                }

                string[] row = { value1, value2, value3.ToString(), value4, value5, value6, value7.ToString(), value9, value10, value11 };

                if (row.Length != tbTG.Columns.Count)
                {
                    cloneTable();
                }
                string maHocVien = txtMaHV.Text;
                if (CheckDataTable(value1))
                {
                    // Đánh dấu là cập nhật
                    tbTG.Rows.Add(row);
                    dataGridView1.DataSource = tbTG;
                    rowStatus[value1] = "edit";
                }
                else
                {
                    return;
                }
                disableButtons2();
            }
        }

        private void btnXoaTTCT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (tbHocVien.Columns.Count != tbTG.Columns.Count)
                {
                    cloneTable();
                }
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow dgvRow in dataGridView1.SelectedRows)
                    {
                        if (dgvRow.IsNewRow == false)
                        {
                            string maHocVien = dgvRow.Cells["MaHocVien"].Value.ToString();
                            if (CheckDataTable(maHocVien))
                            {
                                if (!rowStatus.ContainsKey(maHocVien) || rowStatus[maHocVien] != "delete")
                                {
                                    DataRow newRow = tbTG2.NewRow();

                                    for (int i = 0; i < dgvRow.Cells.Count; i++)
                                    {
                                        newRow[i] = dgvRow.Cells[i].Value;
                                    }

                                    tbTG2.Rows.Add(newRow);
                                    rowStatus[maHocVien] = "delete";
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
            }
        }

        private void btnLuuTTCT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn lưu không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                saveData();
                tbTG.Clear();
                tbTG2.Clear();
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
                    // Kiểm tra xem ô "maHocVien" có tồn tại trong hàng không
                    if (row.Cells["MaHocVien"] != null && row.Cells["MaHocVien"].Value != null)
                    {
                        string maGV = row.Cells["MaHocVien"].Value.ToString();
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if ((DataTable)dataGridView1.DataSource == tbHocVien)
                {
                    shouldReload = false;
                    if (dataGridView1.Rows[e.RowIndex].IsNewRow)
                    {
                        NewData();
                        shouldReload = true;
                    }
                    else
                    {
                        DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                        Control[] controls = { txtMaHV, txtTenHV, dtpNS, cbbGT, txtDC, txtDT, dtpNNHP, txtNN, txtXL, cbbMaLop };

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
                        shouldReload = true;
                        txtMaHV.ReadOnly = true;
                    }
                    disableButtons();
                    enableButtons2();
                }
                if ((DataTable)dataGridView1.DataSource == tbTG || (DataTable)dataGridView1.DataSource == tbTG2)
                {
                    enableButtons();
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

        private void cbbMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbMaLop.SelectedIndex != -1 && shouldReload)
            {
                //string query = "select * from HocVien where MaHocVien in (select MaHocVien from DanhSachHocSinh_MonHoc where MaLop = N'" + cbbMaLop.SelectedValue.ToString() + "')";
                string query = "SELECT HocVien.*, DanhSachHocSinh_MonHoc.MaLop FROM HocVien INNER JOIN DanhSachHocSinh_MonHoc ON HocVien.MaHocVien = DanhSachHocSinh_MonHoc.MaHocVien WHERE DanhSachHocSinh_MonHoc.MaLop = N'" + cbbMaLop.SelectedValue.ToString() + "'";
                SqlDataAdapter myData = new SqlDataAdapter(query, con);
                tbHocVien = new DataTable();
                myData.Fill(tbHocVien);
                tbHocVien.PrimaryKey = new DataColumn[] { tbHocVien.Columns["MaHocVien"] };  // Thiết lập khóa chính tại đây
                dataGridView1.DataSource = tbHocVien;
                formatDataGrid();
                enableButtons2();
                disableButtons();
            }
        }

        private void cbbMaLop_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbMaLop.SelectedIndex == -1)
            {
                labelBTT.Text = "Bảng";
            }

            if (cbbMaLop.SelectedIndex != -1)
                labelBTT.Text = "Bảng học viên: " + cbbMaLop.SelectedValue.ToString();
        }
    }
}