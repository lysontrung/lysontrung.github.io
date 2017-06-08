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
    public partial class trangKiemke : Form
    {
        qltaisan data = new qltaisan();
        public trangKiemke()
        {
            InitializeComponent();
        }
        private void loadDs()
        {
            qltaisan data = new qltaisan();
            var query = (from a in data.KIEMKEs
                         from b in data.TAISANs
                         from c in data.TINHTRANGs
                         where a.MATINHTRANG == c.MATINHTRANG
                         && a.MATAISAN == b.MATAISAN
                         select new
                         {
                             makk = a.MAKIEMKE,
                             tents = b.TENTAISAN,                            
                             nguoikiem = a.NHANVIEN,
                             tinhtrang = c.TINHTRANG1,
                             ngaykiem = a.NGAYKIEMKE
                         }
                ).ToList();
            dataGridView1.DataSource = query;
            dataGridView1.Columns[0].HeaderText = "MÃ TÀI SẢN";
            dataGridView1.Columns[1].HeaderText = "TÊN TÀI SẢN";
            dataGridView1.Columns[2].HeaderText = "NGƯỜI KIỂM";
            dataGridView1.Columns[3].HeaderText = "TÌNH TRẠNG";
            dataGridView1.Columns[4].HeaderText = "NGÀY KIỂM";

            if (dataGridView1.RowCount > 0)
            {
                lbMakk.DataBindings.Clear();
                lbMakk.DataBindings.Add("text", dataGridView1.DataSource, "makk");
                cbTaisan.DataBindings.Clear();
                cbTaisan.DataBindings.Add("text", dataGridView1.DataSource, "tents");
                txtNguoikiem.DataBindings.Clear();
                txtNguoikiem.DataBindings.Add("text", dataGridView1.DataSource, "nguoikiem");
                ngaykiem.DataBindings.Clear();
                ngaykiem.DataBindings.Add("text", dataGridView1.DataSource, "ngaykiem");
                cbTinhtrang.DataBindings.Clear();
                cbTinhtrang.DataBindings.Add("text", dataGridView1.DataSource, "tinhtrang");
            }
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
        private void loadDstinhtrang()
        {
            qltaisan data = new qltaisan();
            cbTinhtrang.DataSource = data.TINHTRANGs.Select(tt => new
            {
                ten = tt.TINHTRANG1,
                id = tt.MATINHTRANG,
            }).ToList();
            cbTinhtrang.DisplayMember = "ten";
            cbTinhtrang.ValueMember = "id";
            if (cbTinhtrang.Items.Count > 0)
                cbTinhtrang.SelectedIndex = 0;
        }
        private void trangKiemke_Load(object sender, EventArgs e)
        {
            loadDs();
            loadDstaisan();
            loadDstinhtrang();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Bạn có muốn thêm?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DateTime now = DateTime.Now;
                data = new qltaisan();
                KIEMKE kk = new KIEMKE();
                kk.MATAISAN = Int32.Parse(cbTaisan.SelectedValue.ToString());
                kk.NHANVIEN = txtNguoikiem.Text;
                kk.MATINHTRANG = Int32.Parse(cbTinhtrang.SelectedValue.ToString());
                kk.NGAYKIEMKE = now;
                try
                {
                    data.KIEMKEs.Add(kk);
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

        private void ngaykiem_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            data = new qltaisan();
            if (MessageBox.Show(this, "bạn có muốn sửa" + lbMakk.Text + "?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    int makk = Int32.Parse(lbMakk.Text);
                    KIEMKE kk = data.KIEMKEs.Single(_kk => _kk.MATAISAN.Equals(makk));
                    kk.MATAISAN = Int32.Parse(cbTaisan.SelectedValue.ToString());
                    kk.NHANVIEN = txtNguoikiem.Text;
                    kk.MATINHTRANG = Int32.Parse(cbTinhtrang.SelectedValue.ToString());
                    kk.NGAYKIEMKE = now;
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            data = new qltaisan();
            if (MessageBox.Show(this, "bạn có muốn xóa" + lbMakk.Text + " này không ?", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    int makk = Int32.Parse(lbMakk.Text);
                    KIEMKE kk = data.KIEMKEs.Single(_kk => _kk.MAKIEMKE.Equals(makk));
                    data.KIEMKEs.Remove(kk);
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

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbTimkiem.Text == "Tên tài sản")
                {
                    var query = (from a in data.KIEMKEs
                                 from b in data.TAISANs
                                 from c in data.TINHTRANGs
                                 where a.MATINHTRANG == c.MATINHTRANG
                                 && a.MATAISAN == b.MATAISAN
                                 && b.TENTAISAN ==  txtTimkiem.Text.Trim()
                                 select new
                                 {
                                     makk = a.MAKIEMKE,
                                     tents = b.TENTAISAN,
                                     nguoikiem = a.NHANVIEN,
                                     tinhtrang = c.TINHTRANG1,
                                     ngaykiem = a.NGAYKIEMKE
                                 }
              ).ToList();
                    dataGridView1.DataSource = query;
                    dataGridView1.Columns[0].HeaderText = "MÃ TÀI SẢN";
                    dataGridView1.Columns[1].HeaderText = "TÊN TÀI SẢN";
                    dataGridView1.Columns[2].HeaderText = "NGƯỜI KIỂM";
                    dataGridView1.Columns[3].HeaderText = "TÌNH TRẠNG";
                    dataGridView1.Columns[4].HeaderText = "NGÀY KIỂM";

                    if (dataGridView1.RowCount > 0)
                    {
                        lbMakk.DataBindings.Clear();
                        lbMakk.DataBindings.Add("text", dataGridView1.DataSource, "makk");
                        cbTaisan.DataBindings.Clear();
                        cbTaisan.DataBindings.Add("text", dataGridView1.DataSource, "tents");
                        txtNguoikiem.DataBindings.Clear();
                        txtNguoikiem.DataBindings.Add("text", dataGridView1.DataSource, "nguoikiem");
                        ngaykiem.DataBindings.Clear();
                        ngaykiem.DataBindings.Add("text", dataGridView1.DataSource, "ngaykiem");
                        cbTinhtrang.DataBindings.Clear();
                        cbTinhtrang.DataBindings.Add("text", dataGridView1.DataSource, "tinhtrang");
                    }
                }

                if (cbTimkiem.Text == "Người kiểm")
                {
                    var query = (from a in data.KIEMKEs
                                 from b in data.TAISANs
                                 from c in data.TINHTRANGs
                                 where a.MATINHTRANG == c.MATINHTRANG
                                 && a.MATAISAN == b.MATAISAN
                                 && a.NHANVIEN == txtTimkiem.Text.Trim()
                                 select new
                                 {
                                     makk = a.MAKIEMKE,
                                     tents = b.TENTAISAN,
                                     nguoikiem = a.NHANVIEN,
                                     tinhtrang = c.TINHTRANG1,
                                     ngaykiem = a.NGAYKIEMKE
                                 }
                 ).ToList();
                    dataGridView1.DataSource = query;
                    dataGridView1.Columns[0].HeaderText = "MÃ TÀI SẢN";
                    dataGridView1.Columns[1].HeaderText = "TÊN TÀI SẢN";
                    dataGridView1.Columns[2].HeaderText = "NGƯỜI KIỂM";
                    dataGridView1.Columns[3].HeaderText = "TÌNH TRẠNG";
                    dataGridView1.Columns[4].HeaderText = "NGÀY KIỂM";

                    if (dataGridView1.RowCount > 0)
                    {
                        lbMakk.DataBindings.Clear();
                        lbMakk.DataBindings.Add("text", dataGridView1.DataSource, "makk");
                        cbTaisan.DataBindings.Clear();
                        cbTaisan.DataBindings.Add("text", dataGridView1.DataSource, "tents");
                        txtNguoikiem.DataBindings.Clear();
                        txtNguoikiem.DataBindings.Add("text", dataGridView1.DataSource, "nguoikiem");
                        ngaykiem.DataBindings.Clear();
                        ngaykiem.DataBindings.Add("text", dataGridView1.DataSource, "ngaykiem");
                        cbTinhtrang.DataBindings.Clear();
                        cbTinhtrang.DataBindings.Add("text", dataGridView1.DataSource, "tinhtrang");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể load dữ liệu. Lỗi: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadDs();
        }
    }
}
