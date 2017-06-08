using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qltaisan
{
    public partial class trangNhaptaisan : Form
    {
        qltaisan data = new qltaisan();
        public trangNhaptaisan()
        {
            InitializeComponent();
        }
        private void loadDstaisan()
        {
            qltaisan data = new qltaisan();
            cbTaisan.DataSource = data.TAISANs.Select(ts => new
            {
                ten = ts.TENTAISAN,
                id = ts.MATAISAN,
            }).ToList();
            cbTaisan.DisplayMember = "ten";
            cbTaisan.ValueMember = "id";
            if (cbTaisan.Items.Count > 0)
                cbTaisan.SelectedIndex = 0;
        }
        private void trangThongketaisan_Load(object sender, EventArgs e)
        {
            loadDs();
            loadDstaisan();
        }

        private void themNhap()
        {
            DateTime now = DateTime.Now;
            data = new qltaisan();
            NHAPT nhap = new NHAPT();
            nhap.NGAYNHAP = now;
            data.NHAPTS.Add(nhap);
            data.SaveChanges();
        }
        private void loadDs()
        {
            qltaisan data = new qltaisan();
            var query = (from a in data.TAISANs           
                         from b in data.NHAPTS
                         from c in data.CHITIETNHAPTS
                         where  a.MATAISAN == c.MATAISAN
                         && b.MANHAPTS == c.MANHAPTS
                         select new
                         {
                             manhap = c.MACHITIETNHAP,
                             nhanvien = c.NHANVIEN,
                             tents = a.TENTAISAN,
                             soluong = c.SOLUONG,
                             ngaynhap = b.NGAYNHAP,
                         }
                ).ToList();
            dataGridView1.DataSource = query;
            dataGridView1.Columns[0].HeaderText = "MÃ NHẬP";
            dataGridView1.Columns[1].HeaderText = "NHÂN VIÊN NHẬP";
            dataGridView1.Columns[2].HeaderText = "TÀI SẢN";
            dataGridView1.Columns[3].HeaderText = "SỐ LƯỢNG";
            dataGridView1.Columns[4].HeaderText = "NGÀY NHẬP";
            if (dataGridView1.RowCount > 0)
            {
                lbManhap.DataBindings.Clear();
                lbManhap.DataBindings.Add("text", dataGridView1.DataSource, "manhap");
                txtNhanvien.DataBindings.Clear();
                txtNhanvien.DataBindings.Add("text", dataGridView1.DataSource, "nhanvien");
                cbTaisan.DataBindings.Clear();
                cbTaisan.DataBindings.Add("text", dataGridView1.DataSource, "tents");
                soluong.DataBindings.Clear();
                soluong.DataBindings.Add("text", dataGridView1.DataSource, "soluong");
                ngaynhap.DataBindings.Clear();
                ngaynhap.DataBindings.Add("text", dataGridView1.DataSource, "ngaynhap");
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            themNhap();
            if (MessageBox.Show(this, "Bạn có muốn thêm?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int manhap = (from a in data.NHAPTS
                            orderby a.MANHAPTS descending
                            select a.MANHAPTS).FirstOrDefault();
                data = new qltaisan();
                CHITIETNHAPT nhap = new CHITIETNHAPT();
                nhap.MANHAPTS = manhap;
                nhap.MATAISAN = Int32.Parse(cbTaisan.SelectedValue.ToString());
                nhap.NHANVIEN = txtNhanvien.Text;
                nhap.SOLUONG = soluong.Value.ToString();
                try
                {
                    data.CHITIETNHAPTS.Add(nhap);
                    data.SaveChanges();
                    loadDs();
                    MessageBox.Show(this, "Thêm thành công !!!");
                }
                catch
                {
                    MessageBox.Show(this, "Thêm thất bại !!!");
                }

            }    
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            data = new qltaisan();
            if (MessageBox.Show(this, "bạn có muốn sửa" + lbManhap.Text + "?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    int manhap = Int32.Parse(lbManhap.Text);
                    CHITIETNHAPT nhap = data.CHITIETNHAPTS.Single(_ct => _ct.MACHITIETNHAP.Equals(manhap));
                    nhap.MANHAPTS = manhap;
                    nhap.MATAISAN = Int32.Parse(cbTaisan.SelectedValue.ToString());
                    nhap.NHANVIEN = txtNhanvien.Text;
                    nhap.SOLUONG = soluong.Value.ToString();
                    data.SaveChanges();
                    loadDs();
                    MessageBox.Show(this, "Cập nhật thành công !!!");
                }
                catch
                {
                    MessageBox.Show(this, "Cập nhật thất bại !!!");
                }
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            data = new qltaisan();
            if (MessageBox.Show(this, "bạn có muốn xóa" + lbManhap.Text + " này không ?", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    int manhap = Int32.Parse(lbManhap.Text);
                    CHITIETNHAPT ct = data.CHITIETNHAPTS.Single(_ct => _ct.MACHITIETNHAP.Equals(manhap));
                    data.CHITIETNHAPTS.Remove(ct);
                    data.SaveChanges();
                    loadDs();
                    MessageBox.Show(this, "Xóa thành công");
                }
                catch
                {
                    MessageBox.Show(this, "Xóa thất bại");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadDs();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbTimkiem.Text == "Tên tài sản")
                {
                     var query = (from a in data.TAISANs           
                         from b in data.NHAPTS
                         from c in data.CHITIETNHAPTS
                         where  a.MATAISAN == c.MATAISAN
                         && b.MANHAPTS == c.MANHAPTS 
                         && a.TENTAISAN == txtTimkiem.Text.Trim()
                         select new
                         {
                             manhap = c.MACHITIETNHAP,
                             nhanvien = c.NHANVIEN,
                             tents = a.TENTAISAN,
                             soluong = c.SOLUONG,
                             ngaynhap = b.NGAYNHAP,
                         }
                ).ToList();
                     dataGridView1.DataSource = query;
                }
               
                if (cbTimkiem.Text == "Tên nhân viên")
                {
                    var query = (from a in data.TAISANs
                                 from b in data.NHAPTS
                                 from c in data.CHITIETNHAPTS
                                 where a.MATAISAN == c.MATAISAN
                                 && b.MANHAPTS == c.MANHAPTS
                                 && c.NHANVIEN == txtTimkiem.Text.Trim()
                                 select new
                                 {
                                     manhap = c.MACHITIETNHAP,
                                     nhanvien = c.NHANVIEN,
                                     tents = a.TENTAISAN,
                                     soluong = c.SOLUONG,
                                     ngaynhap = b.NGAYNHAP,
                                 }
                ).ToList();
                    dataGridView1.DataSource = query;
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể load dữ liệu. Lỗi: " + ex.Message);
            }
        }
    }
}
