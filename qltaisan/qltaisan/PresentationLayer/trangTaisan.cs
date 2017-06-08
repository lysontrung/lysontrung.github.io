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
    public partial class trangTaisan : Form
    {

        qltaisan data = new qltaisan();
        public trangTaisan()
        {
            InitializeComponent();
        }

        private void trangTaisan_Load(object sender, EventArgs e)
        {
            loadDs();
            loadDsdvtinh();
            loadDsloaits();
        }
        private void loadDsloaits()
        {
            qltaisan data = new qltaisan();
            cbLoaitaisan.DataSource = data.LOAITAISANs.Select(loai => new
            {
                ten = loai.TENLOAI,
                id = loai.MALOAI,
            }).ToList();
            cbLoaitaisan.DisplayMember = "ten";
            cbLoaitaisan.ValueMember = "id";
            if (cbLoaitaisan.Items.Count > 0)
                cbLoaitaisan.SelectedIndex = 0;
        }
        private void loadDsdvtinh()
        {
            qltaisan data = new qltaisan();
            cbDonvitinh.DataSource = data.DONVITINHs.Select(dv => new
            {
                ten = dv.TENDONVITINH,
                id = dv.MADONVITINH,
            }).ToList();
            cbDonvitinh.DisplayMember = "ten";
            cbDonvitinh.ValueMember = "id";
            if (cbDonvitinh.Items.Count > 0)
                cbDonvitinh.SelectedIndex = 0;
        }
        private void loadDs()
        {
            qltaisan data = new qltaisan();
            var query = (from a in data.TAISANs
                         from b in data.DONVITINHs
                         from c in data.LOAITAISANs
                         where a.MADONVITINH == b.MADONVITINH
                         && a.MALOAI == c.MALOAI
                         select new
                         {
                             mats = a.MATAISAN,
                             tents = a.TENTAISAN,
                             tenloai = c.TENLOAI,
                             dvtinh = b.TENDONVITINH,
                             gia = a.GIA
                         }
                ).ToList();
            dataGridView1.DataSource = query;
            dataGridView1.Columns[0].HeaderText = "MÃ TÀI SẢN";
            dataGridView1.Columns[1].HeaderText = "TÊN TÀI SẢN";
            dataGridView1.Columns[2].HeaderText = "LOẠI TÀI SẢN";
            dataGridView1.Columns[3].HeaderText = "ÐƠN VỊ";
            dataGridView1.Columns[4].HeaderText = "GIÁ THÀNH(TRIỆU)";

            if (dataGridView1.RowCount > 0)
            {
                lbMats.DataBindings.Clear();
                lbMats.DataBindings.Add("text", dataGridView1.DataSource, "mats");
                txtTaisan.DataBindings.Clear();
                txtTaisan.DataBindings.Add("text", dataGridView1.DataSource, "tents");
                cbLoaitaisan.DataBindings.Clear();
                cbLoaitaisan.DataBindings.Add("text", dataGridView1.DataSource, "tenloai");
                giathanh.DataBindings.Clear();
                giathanh.DataBindings.Add("text", dataGridView1.DataSource, "gia");
                cbDonvitinh.DataBindings.Clear();
                cbDonvitinh.DataBindings.Add("text", dataGridView1.DataSource, "dvtinh");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Bạn có muốn thêm?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                data = new qltaisan();
                TAISAN ts = new TAISAN();
                ts.MALOAI = Int32.Parse(cbLoaitaisan.SelectedValue.ToString());
                ts.TENTAISAN = txtTaisan.Text;
                ts.MADONVITINH = Int32.Parse(cbDonvitinh.SelectedValue.ToString());
                ts.GIA = giathanh.Value.ToString();
                try
                {
                    data.TAISANs.Add(ts);
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
            if (MessageBox.Show(this, "bạn có muốn sửa" + lbMats.Text + "?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    int mats = Int32.Parse(lbMats.Text);
                    TAISAN ts = data.TAISANs.Single(_ts => _ts.MATAISAN.Equals(mats));
                    ts.MALOAI = Int32.Parse(cbLoaitaisan.SelectedValue.ToString());
                    ts.TENTAISAN = txtTaisan.Text;
                    ts.MADONVITINH = Int32.Parse(cbDonvitinh.SelectedValue.ToString());
                    ts.GIA = giathanh.Value.ToString();
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
            if (MessageBox.Show(this, "bạn có muốn xóa" + lbMats.Text + " này không ?", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    int mats = Int32.Parse(lbMats.Text);
                    TAISAN ts = data.TAISANs.Single(_ts => _ts.MATAISAN.Equals(mats));
                    data.TAISANs.Remove(ts);
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

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbTimkiem.Text == "Tên tài sản")
                {
                    var query = (from a in data.TAISANs
                                 from b in data.DONVITINHs
                                 from c in data.LOAITAISANs
                                 where a.MADONVITINH == b.MADONVITINH
                                 && a.MALOAI == c.MALOAI
                                 && a.TENTAISAN == txtTimkiem.Text.Trim()
                                 select new
                                 {
                                     mats = a.MATAISAN,
                                     tents = a.TENTAISAN,
                                     tenloai = c.TENLOAI,
                                     dvtinh = b.TENDONVITINH,
                                     gia = a.GIA
                                 }
                   ).ToList();
                    dataGridView1.DataSource = query;
                    dataGridView1.Columns[0].HeaderText = "MÃ TÀI SẢN";
                    dataGridView1.Columns[1].HeaderText = "TÊN TÀI SẢN";
                    dataGridView1.Columns[2].HeaderText = "LOẠI TÀI SẢN";
                    dataGridView1.Columns[3].HeaderText = "ÐƠN VỊ";
                    dataGridView1.Columns[4].HeaderText = "GIÁ THÀNH";

                    if (dataGridView1.RowCount > 0)
                    {
                        lbMats.DataBindings.Clear();
                        lbMats.DataBindings.Add("text", dataGridView1.DataSource, "mats");
                        txtTaisan.DataBindings.Clear();
                        txtTaisan.DataBindings.Add("text", dataGridView1.DataSource, "tents");
                        cbLoaitaisan.DataBindings.Clear();
                        cbLoaitaisan.DataBindings.Add("text", dataGridView1.DataSource, "tenloai");
                        giathanh.DataBindings.Clear();
                        giathanh.DataBindings.Add("text", dataGridView1.DataSource, "gia");
                        cbDonvitinh.DataBindings.Clear();
                        cbDonvitinh.DataBindings.Add("text", dataGridView1.DataSource, "dvtinh");
                    }
                }

                if (cbTimkiem.Text == "Loại tài sản")
                {
                    var query = (from a in data.TAISANs
                                 from b in data.DONVITINHs
                                 from c in data.LOAITAISANs
                                 where a.MADONVITINH == b.MADONVITINH
                                 && a.MALOAI == c.MALOAI
                                 && c.TENLOAI == txtTimkiem.Text.Trim()
                                 select new
                                 {
                                     mats = a.MATAISAN,
                                     tents = a.TENTAISAN,
                                     tenloai = c.TENLOAI,
                                     dvtinh = b.TENDONVITINH,
                                     gia = a.GIA
                                 }
                  ).ToList();
                    dataGridView1.DataSource = query;
                    dataGridView1.Columns[0].HeaderText = "MÃ TÀI SẢN";
                    dataGridView1.Columns[1].HeaderText = "TÊN TÀI SẢN";
                    dataGridView1.Columns[2].HeaderText = "LOẠI TÀI SẢN";
                    dataGridView1.Columns[3].HeaderText = "ÐƠN VỊ";
                    dataGridView1.Columns[4].HeaderText = "GIÁ THÀNH";

                    if (dataGridView1.RowCount > 0)
                    {
                        lbMats.DataBindings.Clear();
                        lbMats.DataBindings.Add("text", dataGridView1.DataSource, "mats");
                        txtTaisan.DataBindings.Clear();
                        txtTaisan.DataBindings.Add("text", dataGridView1.DataSource, "tents");
                        cbLoaitaisan.DataBindings.Clear();
                        cbLoaitaisan.DataBindings.Add("text", dataGridView1.DataSource, "tenloai");
                        giathanh.DataBindings.Clear();
                        giathanh.DataBindings.Add("text", dataGridView1.DataSource, "gia");
                        cbDonvitinh.DataBindings.Clear();
                        cbDonvitinh.DataBindings.Add("text", dataGridView1.DataSource, "dvtinh");
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_Sorted(object sender, EventArgs e)
        {
            this.dataGridView1.FirstDisplayedCell = this.dataGridView1.CurrentCell;
        }
    }
}
